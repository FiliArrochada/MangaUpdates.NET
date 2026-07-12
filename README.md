# MangaUpdates.NET

A type-safe C# client for the [MangaUpdates API](https://api.mangaupdates.com/), built on [Refit](https://github.com/reactiveui/refit) and `System.Text.Json`.

Most API functions are public and do not require an account. User-based functions require a bearer token; account registration must be done through the MangaUpdates website.

## Installation

```
dotnet add package MangaUpdates
```

Targets `net8.0`.

## Usage

The clients are registered through dependency injection. Each API tag (Series, Members, Releases, …) is exposed as its own Refit interface under the `MangaUpdates.Api` namespace.

```csharp
using MangaUpdates.Api;
using MangaUpdates.Client;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Unauthenticated (public endpoints only):
services.AddMangaUpdates();

// Or with a bearer token for user-based endpoints:
services.AddMangaUpdates("your-access-token");

// Or configure fully:
services.AddMangaUpdates(options =>
{
    options.AccessToken = "your-access-token";
    options.BaseUrl = "https://api.mangaupdates.com/v1"; // default
    options.MaxRetryAttempts = 3;                        // default; 0 disables retry
});

var provider = services.BuildServiceProvider();
```

Then inject or resolve the interface you need:

```csharp
var series = provider.GetRequiredService<ISeriesApi>();

var result = await series.RetrieveSeries(id: 12345);
Console.WriteLine(result.Title);
```

Every operation is asynchronous and returns the deserialized model directly (`Task<T>`). Pass a `CancellationToken` as the last argument to any call.

## Configuration (`MangaUpdatesOptions`)

| Option | Default | Description |
| --- | --- | --- |
| `BaseUrl` | `https://api.mangaupdates.com/v1` | API base address. |
| `AccessToken` | `null` | Bearer token; added automatically to every request when set. |
| `MaxRetryAttempts` | `3` | Automatic retries for transient failures (5xx, 408, 429, network errors). Set to `0` to disable. |
| `RetryBaseDelay` | `1s` | Base delay for the exponential backoff (with jitter). |

## How it works

- **`MangaUpdates.Api`** — one Refit interface per API tag (`ISeriesApi`, `IMembersApi`, …).
- **`MangaUpdates.Model`** — request/response DTOs annotated with `System.Text.Json` attributes.
- **`MangaUpdates.Client`** — DI registration (`AddMangaUpdates`), the bearer-token and Polly retry handlers, the shared serializer options, and the `EnumMember`-aware enum converter.

Errors surface as Refit's `Refit.ApiException`. Advanced users who do not use dependency injection can construct an interface manually with `RestService.For<ISeriesApi>(...)`, supplying `new SystemTextJsonContentSerializer(MangaUpdatesJson.Options)`.

## Acceptable Use

Per the MangaUpdates API terms: credit MangaUpdates when using their data, space out requests, cache where possible, and do not use the data to deceive users, perform illegal actions, create spam, or damage the database.

## License

MIT. See [LICENSE](LICENSE).
