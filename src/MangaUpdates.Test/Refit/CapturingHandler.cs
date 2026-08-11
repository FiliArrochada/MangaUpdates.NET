using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MangaUpdates.Test.Refit
{
    /// <summary>
    /// Terminal <see cref="HttpMessageHandler"/> for the Refit vertical-slice tests: records the
    /// outgoing request (and its body, read before the request is disposed) and answers with a
    /// canned payload, so tests assert URL/query/body construction and response parsing without
    /// any network access.
    /// </summary>
    public sealed class CapturingHandler : HttpMessageHandler
    {
        private readonly string _responseBody;
        private readonly string _responseContentType;

        public CapturingHandler(string responseBody = "{}", string responseContentType = "application/json")
        {
            _responseBody = responseBody;
            _responseContentType = responseContentType;
        }

        public HttpRequestMessage LastRequest { get; private set; }

        /// <summary>Body of the last request, captured as a string (empty when there was no body).</summary>
        public string LastRequestBody { get; private set; } = "";

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            LastRequest = request;
#if NET5_0_OR_GREATER
            LastRequestBody = request.Content != null
                ? await request.Content.ReadAsStringAsync(cancellationToken)
                : "";
#else
            LastRequestBody = request.Content != null
                ? await request.Content.ReadAsStringAsync()
                : "";
#endif

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = request,
                Content = new StringContent(_responseBody, Encoding.UTF8, _responseContentType),
            };
        }
    }
}
