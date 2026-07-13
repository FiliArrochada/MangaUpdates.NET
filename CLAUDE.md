# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

A C# client SDK for the [MangaUpdates API](https://api.mangaupdates.com/), distributed as the `MangaUpdates` NuGet package. Built on **[Refit](https://github.com/reactiveui/refit)** (compile-time source-generated REST clients) and **`System.Text.Json`**. Targets `net8.0`.

## Build / test commands

```bash
dotnet build MangaUpdates.sln -c Release
dotnet test  MangaUpdates.sln -c Release
dotnet pack src/MangaUpdates/MangaUpdates.csproj -c Release --output out
```

Run a single test:
```bash
dotnet test --filter "FullyQualifiedName~CategoriesModelV1Tests"
```

## Architecture

Three namespaces under `src/MangaUpdates/`:

- **`MangaUpdates.Api`** (`Api/I*.cs`) — one **Refit interface per API tag** (`ISeriesApi`, `IMembersApi`, `IReleasesApi`, … 17 total, 242 operations). Every operation is a single async method returning `Task<T>` decorated with `[Get]`/`[Post]`/`[Put]`/`[Delete]`/`[Patch]`. Conventions:
  - Path params use `[AliasAs("snake_case")]` when the route token differs from the camelCase C# name.
  - Query params are `[Query]`, request bodies `[Body]`, file uploads use `[Multipart]` + `StreamPart`.
  - XML/RSS endpoints (`ReleaseRssFeed`, `SeriesReleaseRssFeed`) return `Task<string>`.
  - No auth attributes on methods — the bearer token is injected globally by a handler.
- **`MangaUpdates.Model`** (`Model/*.cs`, ~354) — DTOs annotated with `System.Text.Json` (`[JsonPropertyName]`, `[JsonIgnore(Condition = WhenWritingDefault)]`). Enums carry `[JsonConverter(typeof(MangaUpdates.Client.JsonStringEnumMemberConverter))]`. Models still keep the generated `[DataContract]`, `IEquatable`, `IValidatableObject`, `ToString`/`ToJson` boilerplate; `ToJson` now uses `System.Text.Json`.
- **`MangaUpdates.Client`** (`Client/*.cs`) — the plumbing:
  - `ServiceCollectionExtensions.AddMangaUpdates(...)` — the **only supported entry point**; registers all 17 Refit clients (`AddRefitClient`), base URL, and the two handlers.
  - `BearerTokenHandler` — adds `Authorization: Bearer` from `MangaUpdatesOptions.AccessToken`.
  - `RetryHandler` — Polly v8 `ResiliencePipeline` retrying transient failures.
  - `MangaUpdatesJson` — the shared `JsonSerializerOptions` (used by `SystemTextJsonContentSerializer`).
  - `JsonStringEnumMemberConverter` — a `JsonConverterFactory` that serializes enums via their `[EnumMember(Value=...)]` name (handles values like `"N/A"` that aren't valid identifiers; also handles nullable enums). This is the STJ replacement for Newtonsoft's `StringEnumConverter` and is why models compile.

## Conventions & gotchas

- **Async-only.** Refit has no sync API; the old sync + `WithHttpInfo(ApiResponse<T>)` overloads are gone. Each operation is one `Task<T>` method.
- **Adding/changing an endpoint** means editing the relevant `Api/I*.cs` interface by hand. When adding a client interface, also register it in `ServiceCollectionExtensions.AddClient<T>()`.
- **Enum member names**: keep the `[EnumMember(Value=...)]` attributes on model enums — the custom converter reads them. Do not replace them with plain STJ `[JsonStringEnumMemberName]` unless bumping the target framework.
- **`EmitDefaultValue=false` semantics** from the original models are preserved as `[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]` per property — important so request bodies don't send unset fields.
- The `Nullable` property is set to `annotations` (not full `enable`) to keep the generated model code warning-free.

## Tests

`src/MangaUpdates.Test` is xUnit. The model tests are near-empty auto-generated stubs (they instantiate models); they pass trivially and mainly guard compilation. The original per-API test files were removed in the migration (they instantiated concrete API classes that no longer exist — the API surface is now interfaces). There is no live-network integration test suite.
