# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A hand-maintained C# client SDK for the [MangaUpdates API](https://api.mangaupdates.com/),
distributed as the `MangaUpdates` NuGet package. Built on **[Refit](https://github.com/reactiveui/refit)**
(compile-time source-generated REST clients) and **`System.Text.Json`**. Multi-targets
**`net10.0;net48`** (`dotnet test` runs the suite on both; building net48 needs Windows). The client
is a typed proxy over the live API, kept in sync with the vendored OpenAPI spec **manually** — there
is no code generator in this repo. Current: API 1.0.0, SDK 1.0.0.1.

## Commands

```bash
dotnet build MangaUpdates.sln -c Release
dotnet test  MangaUpdates.sln -c Release
dotnet pack src/MangaUpdates/MangaUpdates.csproj -c Release --output out
dotnet test --filter "FullyQualifiedName~RefitMangaUpdatesApiTests"   # single class/method (xUnit)
dotnet run scripts/check-spec-version.cs -- --diff                     # vendored-spec drift check (.NET 10 file-based app)
```

Dependency updates are automated via Renovate (`renovate.json`). Tests are **xUnit v3**
(`xunit.v3` — the test project builds as an executable).

## Layout

- `src/MangaUpdates/` — the library (assembly and root namespace `MangaUpdates`).
- `src/MangaUpdates.Test/` — xUnit tests; they never hit the network (`.claude/rules/tests.md`).
- `api/openapi-<version>.yaml` — the specs this client mirrors, **append-only**: one file per API
  version kept as history; the highest version is the current source of truth. When the API
  updates, add a new file alongside the old ones (don't overwrite).
- `scripts/check-spec-version.cs` — compares the latest local spec against
  `https://api.mangaupdates.com/openapi.yaml`; `.github/workflows/spec-drift.yml` runs it weekly
  and opens/closes a `spec-drift`-labeled issue.
- `.github/workflows/` — `ci.yml` (build + test on push/PR; **windows-latest** for net48),
  `spec-drift.yml`, `release.yml` (manual `workflow_dispatch`: pack + push to nuget.org via Trusted
  Publishing, then creates the `v<version>` GitHub release). The version is `<Version>` in
  `MangaUpdates.csproj` — bump it there before releasing; it tracks the API version, 4th component
  = client-only changes.

## Architecture

Three namespaces under `src/MangaUpdates/`:

- **`MangaUpdates.Api`** (`Api/I*.cs`) — one **Refit interface per API tag** (`ISeriesApi`,
  `IMembersApi`, `IReleasesApi`, … 17 interfaces, 249 operations at API 1.0.0). Each operation is
  one async `Task<T>` method with `[Get]`/`[Post]`/`[Put]`/`[Delete]`/`[Patch]`:
  - path params use `[AliasAs("snake_case")]` when the route token differs from the camelCase name;
  - query params `[Query]`, bodies `[Body]`, file uploads `[Multipart]` + `StreamPart`;
  - XML/RSS endpoints (`ReleaseRssFeed`, `SeriesReleaseRssFeed`) return `Task<string>`;
  - no auth attributes — the bearer token is injected globally by a handler.
- **`MangaUpdates.Model`** (`Model/*.cs`, ~368) — DTOs with `System.Text.Json` attributes
  (`[JsonPropertyName]`, `[JsonIgnore(Condition = WhenWritingDefault)]`). Enums carry
  `[JsonConverter(typeof(MangaUpdates.Client.JsonStringEnumMemberConverter))]`. Models keep the
  generated `[DataContract]`, `IEquatable`, `IValidatableObject`, `ToString`/`ToJson` boilerplate;
  `ToJson` uses STJ.
- **`MangaUpdates.Client`** (`Client/*.cs`) — the plumbing:
  - `ServiceCollectionExtensions.AddMangaUpdates(...)` — the **only supported entry point**;
    registers all 17 Refit clients (`AddRefitClient`), base URL and the two handlers. This DI layer
    is deliberate: it is the shipped public surface. `RestService.For<T>` with `MangaUpdatesJson.Options` remains
    supported for non-DI consumers.
  - `BearerTokenHandler` — `Authorization: Bearer` from `MangaUpdatesOptions.AccessToken`.
  - `RetryHandler` — Polly v8 `ResiliencePipeline` retrying transient failures.
  - `MangaUpdatesJson` — the shared `JsonSerializerOptions` (used by `SystemTextJsonContentSerializer`).
  - `JsonStringEnumMemberConverter` — a `JsonConverterFactory` serializing enums via their
    `[EnumMember(Value=...)]` name (handles values like `"N/A"` and nullable enums); the STJ
    replacement for Newtonsoft's `StringEnumConverter`, and why the models compile.

## Conventions & gotchas

- **Async-only.** Refit has no sync API. Each operation takes an optional `CancellationToken` last.
- **Adding/changing an endpoint** means editing the `Api/I*.cs` interface by hand. A new client
  interface must also be registered in `ServiceCollectionExtensions.AddClient<T>()` **and** added
  to `AllClientInterfaces` in `DependencyInjectionTests`.
- **Keep `[EnumMember(Value=...)]` on model enums** — the custom converter reads them.
- **`EmitDefaultValue=false`** from the original models is preserved as
  `[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]` per property, so request
  bodies don't send unset fields.
- `Nullable` is `annotations` (not `enable`) to keep the generated model code warning-free.
- Internals (`BearerTokenHandler`, `RetryHandler`) are visible to the test project via `InternalsVisibleTo`.
- **Refit satellites:** since Refit 14 the reflection request builder is in `Refit.Reflection`; the
  library references it so `AddRefitClient` and `RestService.For<T>` work. Keep it and
  `Refit.HttpClientFactory` on the same version as `Refit` (Renovate groups them).
- **net48 reflection gotcha:** an optional ctor parameter `DateTime x = default(DateTime)` (or any
  non-primitive struct default other than `decimal`) breaks `ParameterInfo.HasDefaultValue` on
  .NET Framework with a `FormatException`, which STJ hits building type metadata. Use a nullable
  parameter (`DateTime? x = default`) — see `TimeV1`'s constructor.
- A model whose ctor params can't bind 1:1 to its properties needs a
  `[JsonConstructor] protected Xxx() { }` (details in `.claude/rules/tests.md`).

## Where the rest lives

- `.claude/rules/tests.md` — the test suites (Refit slices, DI pipeline, conformance sweep,
  fixtures, round-trip theory) and the ctor-binding model gotcha.
