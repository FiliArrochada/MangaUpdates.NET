using System;
using MangaUpdates.Api;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;

namespace MangaUpdates.Client
{
    /// <summary>
    /// Dependency-injection registration for the MangaUpdates Refit clients.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers every MangaUpdates API client (one Refit interface per tag) together with the
        /// bearer-token and retry handlers.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configure">Callback used to configure <see cref="MangaUpdatesOptions"/>.</param>
        public static IServiceCollection AddMangaUpdates(this IServiceCollection services, Action<MangaUpdatesOptions> configure)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configure == null) throw new ArgumentNullException(nameof(configure));

            services.AddOptions<MangaUpdatesOptions>().Configure(configure);
            services.AddTransient<BearerTokenHandler>();
            services.AddTransient<RetryHandler>();

            var settings = new RefitSettings
            {
                ContentSerializer = new SystemTextJsonContentSerializer(MangaUpdatesJson.Options),
            };

            services.AddClient<IAboutusApi>(settings);
            services.AddClient<IAccountApi>(settings);
            services.AddClient<IAuthorsApi>(settings);
            services.AddClient<ICategoriesApi>(settings);
            services.AddClient<IConvoApi>(settings);
            services.AddClient<IFaqApi>(settings);
            services.AddClient<IForumApi>(settings);
            services.AddClient<IGenreApi>(settings);
            services.AddClient<IGroupsApi>(settings);
            services.AddClient<IListsApi>(settings);
            services.AddClient<IMembersApi>(settings);
            services.AddClient<IMiscApi>(settings);
            services.AddClient<IPollApi>(settings);
            services.AddClient<IPublishersApi>(settings);
            services.AddClient<IReleasesApi>(settings);
            services.AddClient<IReviewsApi>(settings);
            services.AddClient<ISeriesApi>(settings);

            return services;
        }

        /// <summary>
        /// Registers every MangaUpdates API client using an optional bearer token and the default
        /// public base URL.
        /// </summary>
        public static IServiceCollection AddMangaUpdates(this IServiceCollection services, string? accessToken = null)
        {
            return services.AddMangaUpdates(options => options.AccessToken = accessToken);
        }

        private static IHttpClientBuilder AddClient<T>(this IServiceCollection services, RefitSettings settings)
            where T : class
        {
            return services.AddRefitClient<T>(settings)
                .ConfigureHttpClient((sp, client) =>
                {
                    var options = sp.GetRequiredService<IOptions<MangaUpdatesOptions>>().Value;
                    client.BaseAddress = new Uri(options.BaseUrl);
                })
                .AddHttpMessageHandler<RetryHandler>()
                .AddHttpMessageHandler<BearerTokenHandler>();
        }
    }
}
