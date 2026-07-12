using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Retry;

namespace MangaUpdates.Client
{
    /// <summary>
    /// Retries transient HTTP failures (5xx, 408, 429 and network errors) with exponential backoff,
    /// preserving the resilience behaviour the generated client provided via Polly.
    /// </summary>
    internal sealed class RetryHandler : DelegatingHandler
    {
        private readonly ResiliencePipeline<HttpResponseMessage> _pipeline;

        public RetryHandler(IOptions<MangaUpdatesOptions> options)
        {
            var value = options.Value;

            if (value.MaxRetryAttempts <= 0)
            {
                _pipeline = ResiliencePipeline<HttpResponseMessage>.Empty;
                return;
            }

            _pipeline = new ResiliencePipelineBuilder<HttpResponseMessage>()
                .AddRetry(new RetryStrategyOptions<HttpResponseMessage>
                {
                    ShouldHandle = new PredicateBuilder<HttpResponseMessage>()
                        .Handle<HttpRequestException>()
                        .Handle<TimeoutException>()
                        .HandleResult(IsTransient),
                    MaxRetryAttempts = value.MaxRetryAttempts,
                    BackoffType = DelayBackoffType.Exponential,
                    Delay = value.RetryBaseDelay,
                    UseJitter = true,
                })
                .Build();
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await _pipeline
                .ExecuteAsync(async token => await base.SendAsync(request, token).ConfigureAwait(false), cancellationToken)
                .ConfigureAwait(false);
        }

        private static bool IsTransient(HttpResponseMessage response)
        {
            return (int)response.StatusCode >= 500
                || response.StatusCode == HttpStatusCode.RequestTimeout
                || response.StatusCode == (HttpStatusCode)429;
        }
    }
}
