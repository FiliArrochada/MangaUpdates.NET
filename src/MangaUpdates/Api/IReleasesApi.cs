using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Releases endpoints of the MangaUpdates API.
    /// </summary>
    public interface IReleasesApi
    {
        /// <summary>add an release</summary>
        [Post("/releases")]
        Task<ApiResponseV1> AddRelease([Body] List<ReleaseModelUpdateV1> releaseModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a release</summary>
        [Delete("/releases/{id}")]
        Task<ApiResponseV1> DeleteRelease(long id, CancellationToken cancellationToken = default);

        /// <summary>show releases by day</summary>
        [Get("/releases/days")]
        Task<ReleaseSearchResponseV1> ListReleasesByDay([Query] long? page = default, [Query][AliasAs("include_metadata")] bool? includeMetadata = default, CancellationToken cancellationToken = default);

        /// <summary>search releases to moderate</summary>
        [Post("/releases/moderate")]
        Task<ReleaseModerateResponseV1> ModerateReleasesPost([Body] ReleaseModerateRequestV1 releaseModerateRequestV1, CancellationToken cancellationToken = default);

        /// <summary>releases rss feed</summary>
        [Get("/releases/rss")]
        Task<string> ReleaseRssFeed(CancellationToken cancellationToken = default);

        /// <summary>get a specific release</summary>
        [Get("/releases/{id}")]
        Task<ReleaseModelV1> RetrieveRelease(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>search releases</summary>
        [Post("/releases/search")]
        Task<ReleaseSearchResponseV1> SearchReleasesPost([Body] ReleaseSearchRequestV1 releaseSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update an release</summary>
        [Patch("/releases/{id}")]
        Task<ApiResponseV1> UpdateRelease(long id, [Body] ReleaseModelUpdateV1 releaseModelUpdateV1, CancellationToken cancellationToken = default);
    }
}