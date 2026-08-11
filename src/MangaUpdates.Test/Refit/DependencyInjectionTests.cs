using System;
using System.Threading.Tasks;
using MangaUpdates.Api;
using MangaUpdates.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using Xunit;

namespace MangaUpdates.Test.Refit
{
    /// <summary>
    /// Tests the production DI pipeline end to end: <c>AddMangaUpdates</c> registration of every
    /// client, the configured base URL, and the <c>BearerTokenHandler</c> — with the primary
    /// (network) handler swapped for <see cref="CapturingHandler"/> so nothing leaves the process.
    /// </summary>
    public class DependencyInjectionTests
    {
        private static readonly Type[] AllClientInterfaces =
        {
            typeof(IAboutusApi), typeof(IAccountApi), typeof(IAuthorsApi), typeof(ICategoriesApi),
            typeof(IConvoApi), typeof(IFaqApi), typeof(IForumApi), typeof(IGenreApi),
            typeof(IGroupsApi), typeof(IListsApi), typeof(IMembersApi), typeof(IMiscApi),
            typeof(IPollApi), typeof(IPublishersApi), typeof(IReleasesApi), typeof(IReviewsApi),
            typeof(ISeriesApi),
        };

        private static (ServiceProvider provider, CapturingHandler cap) Build(Action<MangaUpdatesOptions> configure)
        {
            var cap = new CapturingHandler("{}");
            var services = new ServiceCollection();
            services.AddMangaUpdates(configure);
            // Swap the primary (network) handler of every named client for the capturing fake.
            services.ConfigureAll<HttpClientFactoryOptions>(
                o => o.HttpMessageHandlerBuilderActions.Add(b => b.PrimaryHandler = cap));
            return (services.BuildServiceProvider(), cap);
        }

        [Fact]
        public void AddMangaUpdates_Registers_Every_Client_Interface()
        {
            var (provider, _) = Build(_ => { });
            using (provider)
            {
                foreach (var type in AllClientInterfaces)
                {
                    Assert.NotNull(provider.GetRequiredService(type));
                }
            }
        }

        [Fact]
        public async Task Pipeline_Uses_Default_BaseUrl_And_Attaches_Bearer_Token()
        {
            var (provider, cap) = Build(o => o.AccessToken = "token123");
            using (provider)
            {
                var api = provider.GetRequiredService<ISeriesApi>();
                await api.RetrieveSeries(42, cancellationToken: TestContext.Current.CancellationToken);

                Assert.Equal("https://api.mangaupdates.com/v1/series/42",
                    cap.LastRequest.RequestUri.GetLeftPart(UriPartial.Path));
                Assert.Equal("Bearer", cap.LastRequest.Headers.Authorization.Scheme);
                Assert.Equal("token123", cap.LastRequest.Headers.Authorization.Parameter);
            }
        }

        [Fact]
        public async Task Pipeline_Without_Token_Sends_No_Authorization_Header()
        {
            var (provider, cap) = Build(_ => { });
            using (provider)
            {
                var api = provider.GetRequiredService<ISeriesApi>();
                await api.RetrieveSeries(42, cancellationToken: TestContext.Current.CancellationToken);

                Assert.Null(cap.LastRequest.Headers.Authorization);
            }
        }
    }
}
