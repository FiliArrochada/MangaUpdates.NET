using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;
using Refit;
using Xunit;

namespace MangaUpdates.Test.Refit
{
    /// <summary>
    /// Vertical-slice tests: prove the Refit interfaces + shared serializer options actually build
    /// requests and parse responses correctly — path templating ([AliasAs] snake_case tokens),
    /// query formatting, snake_case JSON bodies with [EnumMember] enum values, multipart uploads
    /// and the raw-string RSS endpoints. No network (CapturingHandler intercepts).
    /// These tests lock down the wire shapes — keep them passing when touching the interfaces.
    /// </summary>
    public class RefitMangaUpdatesApiTests
    {
        private static (T api, CapturingHandler cap) Build<T>(string cannedJson = "{}", string contentType = "application/json")
        {
            var cap = new CapturingHandler(cannedJson, contentType);
            var http = new HttpClient(cap) { BaseAddress = new Uri("https://api.mangaupdates.com/v1") };
            var settings = new RefitSettings
            {
                ContentSerializer = new SystemTextJsonContentSerializer(MangaUpdatesJson.Options),
            };
            return (RestService.For<T>(http, settings), cap);
        }

        [Fact]
        public async Task RetrieveSeries_Builds_Path_And_Query()
        {
            var (api, cap) = Build<ISeriesApi>("{\"series_id\":33}");

            var result = await api.RetrieveSeries(33, unrenderedFields: true, cancellationToken: TestContext.Current.CancellationToken);

            Assert.Equal(HttpMethod.Get, cap.LastRequest.Method);
            Assert.Equal("/v1/series/33", cap.LastRequest.RequestUri.AbsolutePath);
            Assert.Contains("unrenderedFields=", cap.LastRequest.RequestUri.Query);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task AddSeriesCommentUsefulFlag_Uses_AliasAs_Path_Token()
        {
            var (api, cap) = Build<ISeriesApi>();

            await api.AddSeriesCommentUsefulFlag(5, 77, new SeriesCommentUsefulModelV1(), TestContext.Current.CancellationToken);

            Assert.Equal(HttpMethod.Put, cap.LastRequest.Method);
            // comment_id comes from [AliasAs("comment_id")] on the camelCase C# parameter
            Assert.Equal("/v1/series/5/comments/77/useful", cap.LastRequest.RequestUri.AbsolutePath);
        }

        [Fact]
        public async Task SearchSeriesPost_Serializes_Body_With_SnakeCase_And_EnumMember_Values()
        {
            var (api, cap) = Build<ISeriesApi>("{\"total_hits\":0}");

            await api.SearchSeriesPost(new SeriesSearchRequestV1
            {
                Search = "berserk",
                Stype = SeriesSearchRequestV1.StypeEnum.Title,
            }, TestContext.Current.CancellationToken);

            Assert.Equal(HttpMethod.Post, cap.LastRequest.Method);
            Assert.Equal("/v1/series/search", cap.LastRequest.RequestUri.AbsolutePath);
            Assert.Equal("application/json", cap.LastRequest.Content.Headers.ContentType.MediaType);
            Assert.Contains("\"search\":\"berserk\"", cap.LastRequestBody);
            // enum serialized via its [EnumMember] value, not the C# member name
            Assert.Contains("\"stype\":\"title\"", cap.LastRequestBody);
            // MangaUpdatesJson omits nulls — unset reference/nullable properties must not be sent
            Assert.DoesNotContain("null", cap.LastRequestBody);
        }

        [Fact]
        public async Task ReleaseRssFeed_Returns_Raw_Content()
        {
            const string rss = "<rss version=\"2.0\"><channel/></rss>";
            var (api, cap) = Build<IReleasesApi>(rss, "application/rss+xml");

            var result = await api.ReleaseRssFeed(TestContext.Current.CancellationToken);

            Assert.Equal("/v1/releases/rss", cap.LastRequest.RequestUri.AbsolutePath);
            Assert.Equal(rss, result);
        }

        [Fact]
        public async Task UpdateSeriesImage_Sends_Multipart_Form_Data()
        {
            var (api, cap) = Build<ISeriesApi>();
            using var ms = new MemoryStream(new byte[] { 1, 2, 3 });

            await api.UpdateSeriesImage(9, new StreamPart(ms, "cover.png", "image/png"), TestContext.Current.CancellationToken);

            Assert.Equal(HttpMethod.Post, cap.LastRequest.Method);
            Assert.Equal("/v1/series/9/image", cap.LastRequest.RequestUri.AbsolutePath);
            Assert.Equal("multipart/form-data", cap.LastRequest.Content.Headers.ContentType.MediaType);
            Assert.Contains("cover.png", cap.LastRequestBody);
        }
    }
}
