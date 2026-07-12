using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace MangaUpdates.Client
{
    /// <summary>
    /// Adds a <c>Authorization: Bearer &lt;token&gt;</c> header when an access token is configured
    /// and the request does not already carry one.
    /// </summary>
    internal sealed class BearerTokenHandler : DelegatingHandler
    {
        private readonly IOptionsMonitor<MangaUpdatesOptions> _options;

        public BearerTokenHandler(IOptionsMonitor<MangaUpdatesOptions> options)
        {
            _options = options;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _options.CurrentValue.AccessToken;
            if (!string.IsNullOrEmpty(token) && request.Headers.Authorization is null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
