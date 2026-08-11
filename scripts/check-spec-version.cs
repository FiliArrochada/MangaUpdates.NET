#!/usr/bin/env dotnet run
/*
 * check-spec-version.cs  —  .NET 10 file-based app (run with: dotnet run scripts/check-spec-version.cs)
 *
 * Checks whether the local MangaUpdates OpenAPI spec (that this client mirrors) is up to date
 * with the spec MangaUpdates publishes upstream. This client is effectively a typed proxy over
 * the MangaUpdates REST API, so this reports whether the proxy has drifted from the live contract.
 *
 * Local specs live in api/openapi-<version>.yaml (one file per API version, kept as history);
 * the highest-versioned file is treated as current. Override with LOCAL_SPEC if needed.
 *
 * Dependencies: only the .NET SDK, which is already required to build this repo. There is NO
 * package/NuGet dependency (uses the BCL only).
 *
 * TLS note: if the HttpClient fetch fails (e.g. an edge requiring TLS 1.3 on an OS whose TLS
 * stack tops out at 1.2), the tool falls back to the `openssl` CLI (ships with git for Windows
 * and most dev boxes), which does TLS independently of the OS.
 *
 * Usage:
 *   dotnet run scripts/check-spec-version.cs -- --diff
 *   SPEC_URL=... LOCAL_SPEC=... dotnet run scripts/check-spec-version.cs -- --diff
 *
 * Exit codes: 0 = up to date, 1 = outdated / path drift, 2 = could not complete.
 */

using System.Diagnostics;
using System.Text;

const string UserAgent = "MangaUpdates.NET-spec-check/1.0 (+https://github.com/filipe-silva/MangaUpdates.NET)";

string specUrl = Environment.GetEnvironmentVariable("SPEC_URL")
                 ?? "https://api.mangaupdates.com/openapi.yaml";
bool showDiff = args.Contains("--diff");

// Local spec defaults to the highest-versioned <repo>/api/openapi-<version>.yaml.
// The api/ folder keeps one file per API version as history; the latest is the
// version this client currently mirrors.
string localSpec = Environment.GetEnvironmentVariable("LOCAL_SPEC") ?? "";
if (string.IsNullOrEmpty(localSpec))
{
    // Walk up to find the repo root (folder containing 'api' with versioned specs).
    var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
    while (dir != null && LatestSpec(Path.Combine(dir.FullName, "api")) == null)
        dir = dir.Parent;
    localSpec = (dir != null ? LatestSpec(Path.Combine(dir.FullName, "api")) : null)
                ?? Path.Combine("api", "openapi-0.0.0.yaml"); // nonexistent → clear error below
}

int Fail(string msg) { Console.Error.WriteLine($"ERROR: {msg}"); return 2; }

Console.WriteLine("=== Local spec ===");
if (!File.Exists(localSpec)) return Fail($"local spec not found at {localSpec}");
string localYaml = File.ReadAllText(localSpec);
string? localVersion = GetVersion(localYaml);
if (localVersion == null) return Fail($"could not parse info.version from {localSpec}");
Console.WriteLine($"path    : {localSpec}");
Console.WriteLine($"version : {localVersion}");

Console.WriteLine("\n=== Upstream spec ===");
Console.WriteLine($"url     : {specUrl}");
string upstreamYaml;
try
{
    upstreamYaml = await FetchAsync(specUrl);
}
catch (Exception e)
{
    Console.Error.WriteLine($"ERROR: could not fetch upstream spec: {e.Message}");
    Console.Error.WriteLine("Hint: check network access to api.mangaupdates.com, or set SPEC_URL if it moved.");
    return 2;
}
string? upstreamVersion = GetVersion(upstreamYaml);
if (upstreamVersion == null) return Fail("fetched upstream document but could not parse info.version (wrong URL?).");
Console.WriteLine($"version : {upstreamVersion}");

Console.WriteLine("\n=== Result ===");
bool drift = false;
if (localVersion == upstreamVersion)
{
    Console.WriteLine($"UP TO DATE: local and upstream are both {localVersion}");
}
else
{
    Console.WriteLine($"OUTDATED: local is {localVersion}, upstream is {upstreamVersion}");
    drift = true;
}

if (showDiff)
{
    Console.WriteLine("\n=== Path diff ===");
    var local = GetPaths(localYaml);
    var upstream = GetPaths(upstreamYaml);
    var added = upstream.Where(p => !local.Contains(p)).OrderBy(p => p).ToList();
    var removed = local.Where(p => !upstream.Contains(p)).OrderBy(p => p).ToList();
    Console.WriteLine($"local paths: {local.Count}   upstream paths: {upstream.Count}");
    if (added.Count == 0 && removed.Count == 0)
    {
        Console.WriteLine("No path-level differences.");
    }
    else
    {
        if (added.Count > 0)
        {
            Console.WriteLine("\nAdded upstream (missing locally):");
            foreach (var p in added) Console.WriteLine($"  + {p}");
        }
        if (removed.Count > 0)
        {
            Console.WriteLine("\nRemoved upstream (still local):");
            foreach (var p in removed) Console.WriteLine($"  - {p}");
        }
        drift = true;
    }
}

return drift ? 1 : 0;

// ---------- helpers ----------

// Pick the highest-versioned 'openapi-<version>.yaml' in the given directory, or null.
static string? LatestSpec(string apiDir)
{
    if (!Directory.Exists(apiDir)) return null;
    return Directory.EnumerateFiles(apiDir, "openapi-*.yaml")
        .Select(f => (File: f, Ver: ParseVersion(Path.GetFileNameWithoutExtension(f).Substring("openapi-".Length))))
        .Where(x => x.Ver != null)
        .OrderByDescending(x => x.Ver)
        .Select(x => x.File)
        .FirstOrDefault();
}

static Version? ParseVersion(string s) => Version.TryParse(s, out var v) ? v : null;

// Extract info.version (line-based; no multi-line regex backtracking on large specs).
static string? GetVersion(string yaml)
{
    var lines = yaml.Split('\n');
    bool inInfo = false;
    foreach (var raw in lines)
    {
        var line = raw.TrimEnd('\r');
        if (line == "info:") { inInfo = true; continue; }
        if (inInfo)
        {
            if (line.Length > 0 && !char.IsWhiteSpace(line[0])) break; // next top-level key
            var v = MatchVersion(line);
            if (v != null) return v;
        }
    }
    foreach (var raw in lines) { var v = MatchVersion(raw.TrimEnd('\r')); if (v != null) return v; }
    return null;
}

static string? MatchVersion(string line)
{
    var t = line.TrimStart();
    if (!t.StartsWith("version:")) return null;
    if (line == t) return null; // must be indented (nested under info)
    return t.Substring("version:".Length).Trim().Trim('"', '\'');
}

// Extract the set of top-level path keys under `paths:` (handles optional surrounding quotes).
static HashSet<string> GetPaths(string yaml)
{
    var set = new HashSet<string>();
    bool inPaths = false;
    foreach (var raw in yaml.Split('\n'))
    {
        var line = raw.TrimEnd('\r');
        if (line == "paths:") { inPaths = true; continue; }
        if (!inPaths) continue;
        if (line.Length > 0 && !char.IsWhiteSpace(line[0])) break; // next top-level key
        // Expect exactly two spaces of indent, then optional quote, then '/...:'.
        if (!line.StartsWith("  ") || line.StartsWith("   ")) continue;
        var key = line.Substring(2).TrimEnd();
        if (!key.EndsWith(":")) continue;
        key = key[..^1].Trim().Trim('"', '\'');
        if (key.StartsWith("/")) set.Add(key);
    }
    return set;
}

// Fetch via HttpClient; on TLS/connection failure fall back to the openssl CLI.
static async Task<string> FetchAsync(string url)
{
    try
    {
        using var http = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
        http.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        return await http.GetStringAsync(url);
    }
    catch (Exception e) when (e is HttpRequestException or System.Security.Authentication.AuthenticationException)
    {
        Console.Error.WriteLine($"(HttpClient failed: {e.Message}; retrying via openssl)");
        return FetchViaOpenSsl(url);
    }
}

// HTTP/1.0 GET over `openssl s_client`. HTTP/1.0 => no chunked encoding; server closes at EOF.
static string FetchViaOpenSsl(string url)
{
    var uri = new Uri(url);
    int port = uri.IsDefaultPort ? 443 : uri.Port;
    string request =
        $"GET {uri.PathAndQuery} HTTP/1.0\r\n" +
        $"Host: {uri.Host}\r\n" +
        $"User-Agent: {UserAgent}\r\n" +
        "Accept: */*\r\n" +
        "Connection: close\r\n\r\n";

    var psi = new ProcessStartInfo("openssl",
        $"s_client -quiet -connect {uri.Host}:{port} -servername {uri.Host}")
    {
        RedirectStandardInput = true,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
    };

    Process proc;
    try { proc = Process.Start(psi)!; }
    catch (Exception e) { throw new Exception($"openssl fallback unavailable ({e.Message}). Install openssl or run on a TLS 1.3-capable OS."); }

    proc.StandardInput.Write(request);
    proc.StandardInput.Flush();
    proc.StandardInput.Close();
    string output = proc.StandardOutput.ReadToEnd();
    proc.WaitForExit(30_000);

    int hdr = output.IndexOf("HTTP/", StringComparison.Ordinal);
    if (hdr < 0) throw new Exception("no HTTP response from openssl fallback.");
    string firstLine = output.Substring(hdr, Math.Min(40, output.Length - hdr));
    if (!firstLine.Contains(" 200")) throw new Exception($"upstream returned: {firstLine.Split('\r')[0]}");

    int sep = output.IndexOf("\r\n\r\n", hdr, StringComparison.Ordinal);
    if (sep < 0) throw new Exception("malformed HTTP response from openssl fallback.");
    return output.Substring(sep + 4);
}
