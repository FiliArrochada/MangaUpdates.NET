using System;

namespace MangaUpdates.Client
{
    /// <summary>
    /// Configuration for the MangaUpdates client.
    /// </summary>
    public sealed class MangaUpdatesOptions
    {
        /// <summary>
        /// Base URL of the MangaUpdates API. Defaults to the public v1 endpoint.
        /// </summary>
        public string BaseUrl { get; set; } = "https://api.mangaupdates.com/v1";

        /// <summary>
        /// Bearer token used for authenticated endpoints. When null or empty, requests are sent
        /// unauthenticated (most GET endpoints are public).
        /// </summary>
        public string? AccessToken { get; set; }

        /// <summary>
        /// Number of automatic retries for transient failures (5xx, 408, 429, network errors).
        /// Set to 0 to disable retries.
        /// </summary>
        public int MaxRetryAttempts { get; set; } = 3;

        /// <summary>
        /// Base delay for the exponential retry backoff.
        /// </summary>
        public TimeSpan RetryBaseDelay { get; set; } = TimeSpan.FromSeconds(1);
    }
}
