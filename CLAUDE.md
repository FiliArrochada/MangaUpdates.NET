# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A hand-maintained C# client SDK for the [MangaUpdates API](https://api.mangaupdates.com/), distributed as the `MangaUpdates` NuGet package. Built on **[Refit](https://github.com/reactiveui/refit)** (compile-time source-generated REST clients) and **`System.Text.Json`**. Multi-targets **`net10.0;net48`** (`dotnet test` runs the suite on both; building net48 needs Windows). The client is a typed proxy over the live API, kept in sync with the vendored OpenAPI spec (`api/openapi-<version>.yaml`, highest version = current) **manually** — there is no code generator in this repo. Current: API 1.0.0, SDK 1.0.0.1.

This repo follows the workspace-level `guidelines/refit-api-client-sdk.md` (reference implementation: FireflyIII.Net).

## Commands

```bash
dotnet build MangaUpdates.sln -c Release
dotnet test  MangaUpdates.sln -c Release
dotnet pack src/MangaUpdates/MangaUpdates.csproj -c Release --output out

# Run a single test class or method (xUnit)
dotnet test --filter "FullyQualifiedName~RefitMangaUpdatesApiTests"

# Check whether the vendored spec has drifted from the upstream spec (.NET 10 file-based app)
dotnet run scripts/check-spec-version.cs -- --diff
```

NuGet versions are centrally managed in `Directory.Packages.props` (CPM) — `PackageReference` entries in the csprojs carry no `Version` attribute. Dependency updates are automated via Renovate (`renovate.json`). Tests are **xUnit v3** (`xunit.v3` — the test project builds as an executable).

## Layout

- `src/MangaUpdates/` — the library (`MangaUpdates` assembly, root namespace `MangaUpdates`).
- `src/MangaUpdates.Test/` — xUnit tests (see "Tests" below).
- `api/openapi-<version>.yaml` — the specs this client mirrors, **append-only**: one file per API version kept as history; the highest-versioned file is the current source of truth. When the API updates, add a new file alongside the old ones (don't overwrite).
- `scripts/check-spec-version.cs` — upstream drift checker (compares the latest local spec against `https://api.mangaupdates.com/openapi.yaml`). `.github/workflows/spec-drift.yml` runs it weekly and opens/closes a `spec-drift`-labeled issue.
- `.github/workflows/` — `ci.yml` (build + test on push/PR; **windows-latest** because of the net48 target), `spec-drift.yml` (weekly), `release.yml` (manual `workflow_dispatch`: pack + push to nuget.org via Trusted Publishing, then creates the `v<version>` GitHub release; version comes from `<Version>` in `MangaUpdates.csproj` — bump it there before releasing; it tracks the API version, 4th component = client-only changes).

## Architecture

Three namespaces under `src/MangaUpdates/`:

- **`MangaUpdates.Api`** (`Api/I*.cs`) — one **Refit interface per API tag** (`ISeriesApi`, `IMembersApi`, `IReleasesApi`, … 17 total, 242 operations). Every operation is a single async method returning `Task<T>` decorated with `[Get]`/`[Post]`/`[Put]`/`[Delete]`/`[Patch]`. Conventions:
  - Path params use `[AliasAs("snake_case")]` when the route token differs from the camelCase C# name.
  - Query params are `[Query]`, request bodies `[Body]`, file uploads use `[Multipart]` + `StreamPart`.
  - XML/RSS endpoints (`ReleaseRssFeed`, `SeriesReleaseRssFeed`) return `Task<string>`.
  - No auth attributes on methods — the bearer token is injected globally by a handler.
- **`MangaUpdates.Model`** (`Model/*.cs`, ~368) — DTOs annotated with `System.Text.Json` (`[JsonPropertyName]`, `[JsonIgnore(Condition = WhenWritingDefault)]`). Enums carry `[JsonConverter(typeof(MangaUpdates.Client.JsonStringEnumMemberConverter))]`. Models still keep the generated `[DataContract]`, `IEquatable`, `IValidatableObject`, `ToString`/`ToJson` boilerplate; `ToJson` uses `System.Text.Json`.
- **`MangaUpdates.Client`** (`Client/*.cs`) — the plumbing:
  - `ServiceCollectionExtensions.AddMangaUpdates(...)` — the **only supported entry point**; registers all 17 Refit clients (`AddRefitClient`), base URL, and the two handlers. (This DI layer is a deliberate deviation from the guideline's "no wrapper" rule — it predates the guideline and is the package's shipped public surface. `RestService.For<T>` with `MangaUpdatesJson.Options` remains supported for non-DI consumers.)
  - `BearerTokenHandler` — adds `Authorization: Bearer` from `MangaUpdatesOptions.AccessToken`.
  - `RetryHandler` — Polly v8 `ResiliencePipeline` retrying transient failures.
  - `MangaUpdatesJson` — the shared `JsonSerializerOptions` (used by `SystemTextJsonContentSerializer`).
  - `JsonStringEnumMemberConverter` — a `JsonConverterFactory` that serializes enums via their `[EnumMember(Value=...)]` name (handles values like `"N/A"` that aren't valid identifiers; also handles nullable enums). This is the STJ replacement for Newtonsoft's `StringEnumConverter` and is why models compile.

## Conventions & gotchas

- **Async-only.** Refit has no sync API. Each operation is one `Task<T>` method taking an optional `CancellationToken` last.
- **Adding/changing an endpoint** means editing the relevant `Api/I*.cs` interface by hand. When adding a client interface, also register it in `ServiceCollectionExtensions.AddClient<T>()` **and** add it to `AllClientInterfaces` in `DependencyInjectionTests`.
- **Enum member names**: keep the `[EnumMember(Value=...)]` attributes on model enums — the custom converter reads them.
- **`EmitDefaultValue=false` semantics** from the original models are preserved as `[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]` per property — important so request bodies don't send unset fields.
- The `Nullable` property is set to `annotations` (not full `enable`) to keep the generated model code warning-free.
- The library exposes its internals to the test project via `InternalsVisibleTo` (`BearerTokenHandler`, `RetryHandler`).
- **Refit satellite packages**: since Refit 14 the reflection request builder lives in `Refit.Reflection` — the library references it so `AddRefitClient` and consumers' `RestService.For<T>` work; keep it and `Refit.HttpClientFactory` version-locked to `Refit` (Renovate groups them).
- **net48 reflection gotcha**: an optional ctor parameter declared `DateTime x = default(DateTime)` (or any non-primitive struct default other than `decimal`) breaks `ParameterInfo.HasDefaultValue` on .NET Framework with a `FormatException`, which System.Text.Json hits while building the type's metadata. Use a nullable parameter (`DateTime? x = default`) instead — see `TimeV1`'s constructor.

## Tests (never hit the network)

`src/MangaUpdates.Test`, xUnit v3:

- **`Refit/`** — the vertical-slice tests: `CapturingHandler` records the outgoing request (and body) and returns canned JSON, so tests assert method/path/query/body construction and response parsing. `RefitMangaUpdatesApiTests` locks down the wire shapes (path templating with `[AliasAs]` snake_case tokens, snake_case JSON bodies with `[EnumMember]` enum values, null-omission, multipart uploads, raw-string RSS). `DependencyInjectionTests` runs the **production DI pipeline** end to end (`AddMangaUpdates` → base URL → `RetryHandler` → `BearerTokenHandler`) with the primary handler swapped for the capturing fake via `ConfigureAll<HttpClientFactoryOptions>`. `RefitInterfaceConformanceTests` sweeps all 17 interfaces structurally (one verb attribute, rooted route, placeholders satisfied, ≤1 `[Body]`, Task-based returns, trailing optional `CancellationToken`) so adding an endpoint is self-checking. **Keep these passing when touching interfaces or the DI wiring.**
- **`Fixtures/`** — deserialization of realistic hand-built payloads shaped after the spec schemas (the spec publishes no example values): `SeriesFixtureTests` (full `SeriesModelV1` with nested image/rank/authors/`TimeV1`, paged `SeriesSearchResponseV1`), `ReleasesFixtureTests` (`ReleaseModelV1`, `ApiResponseV1` error envelope), `MembersFixtureTests` (`UserModelV1` incl. the `"N/A"` gender `[EnumMember]` value), `ListsFixtureTests` (`ListsModelV1` + options, `ListsSeriesModelV1` with reading position).
- **`Model/AllModelsRoundTripTests`** — reflection-driven: every DTO must survive serialize → deserialize → serialize through `MangaUpdatesJson.Options` unchanged, and every `[EnumMember]` enum member must round-trip. (Generated models have a `protected` parameterless ctor — instantiate via `Activator.CreateInstance(t, nonPublic: true)`.) The old ~354 generated per-model stub files (empty `[Fact]`s) were deleted — this theory is their replacement.
- **Model gotcha**: a model whose ctor params can't bind 1:1 to its properties — a nullable param for a non-nullable property (`TimeV1`; see the net48 `DateTime = default` note in `guidelines/refit-api-client-sdk.md`) or a reserved-word param renamed with an underscore (`_public` in `ListsModelV1Options`, `_return` in `MiscSlowTransactionStatusResponseV1`) — must carry a `[JsonConstructor] protected Xxx() { }`, or STJ throws a ctor-binding `InvalidOperationException` as soon as a populated payload is deserialized.
