---
paths:
  - "src/MangaUpdates.Test/**"
---

# Tests (`src/MangaUpdates.Test`, xUnit v3) — never hit the network

- **`Refit/`** — the vertical-slice tests. `CapturingHandler` records the outgoing request (and
  body) and returns canned JSON, so tests assert method/path/query/body construction and response
  parsing.
  - `RefitMangaUpdatesApiTests` locks down the wire shapes: path templating with `[AliasAs]`
    snake_case tokens, snake_case JSON bodies with `[EnumMember]` enum values, null-omission,
    multipart uploads, raw-string RSS.
  - `DependencyInjectionTests` runs the **production DI pipeline** end to end (`AddMangaUpdates` →
    base URL → `RetryHandler` → `BearerTokenHandler`) with the primary handler swapped for the
    capturing fake via `ConfigureAll<HttpClientFactoryOptions>`. Its `AllClientInterfaces` list must
    include every client interface.
  - `RefitInterfaceConformanceTests` sweeps all 17 interfaces structurally (one verb attribute,
    rooted route, placeholders satisfied, ≤1 `[Body]`, Task-based returns, trailing optional
    `CancellationToken`), so adding an endpoint is self-checking.
  - **Keep these passing when touching interfaces or the DI wiring.**
- **`Fixtures/`** — deserialization of realistic hand-built payloads shaped after the spec schemas
  (the spec publishes no example values): `SeriesFixtureTests` (full `SeriesModelV1` with nested
  image/rank/authors/`TimeV1`, paged `SeriesSearchResponseV1`), `ReleasesFixtureTests`
  (`ReleaseModelV1`, `ApiResponseV1` error envelope), `MembersFixtureTests` (`UserModelV1` incl.
  the `"N/A"` gender `[EnumMember]` value), `ListsFixtureTests` (`ListsModelV1` + options,
  `ListsSeriesModelV1` with reading position).
- **`Model/AllModelsRoundTripTests`** — reflection-driven: every DTO must survive serialize →
  deserialize → serialize through `MangaUpdatesJson.Options` unchanged, and every `[EnumMember]`
  enum member must round-trip. Generated models have a `protected` parameterless ctor — instantiate
  via `Activator.CreateInstance(t, nonPublic: true)`. This theory replaced the ~354 deleted
  generated per-model stub files (empty `[Fact]`s); don't bring them back.

## Model gotcha the round-trip theory catches

A model whose ctor params can't bind 1:1 to its properties — a nullable param for a non-nullable
property (`TimeV1`; see the net48 `DateTime = default` note in CLAUDE.md and
`guidelines/refit-api-client-sdk.md`) or a reserved-word param renamed with an underscore
(`_public` in `ListsModelV1Options`, `_return` in `MiscSlowTransactionStatusResponseV1`) — must
carry a `[JsonConstructor] protected Xxx() { }`, or STJ throws a ctor-binding
`InvalidOperationException` as soon as a populated payload is deserialized.
