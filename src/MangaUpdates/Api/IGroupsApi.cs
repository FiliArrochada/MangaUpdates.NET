using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Groups endpoints of the MangaUpdates API.
    /// </summary>
    public interface IGroupsApi
    {
        /// <summary>add an group</summary>
        [Post("/groups")]
        Task<ApiResponseV1> AddGroup([Body] GroupsModelUpdateV1 groupsModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a group</summary>
        [Delete("/groups/{id}")]
        Task<ApiResponseV1> DeleteGroup(long id, CancellationToken cancellationToken = default);

        /// <summary>reject and delete a group</summary>
        [Post("/groups/{id}/reject")]
        Task<ApiResponseV1> RejectGroup(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific group</summary>
        [Get("/groups/{id}")]
        Task<GroupsModelV1> RetrieveGroup(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get the list of series and release frequency for a specific group</summary>
        [Get("/groups/{id}/series")]
        Task<GroupsSeriesListResponseV1> RetrieveGroupSeries(long id, CancellationToken cancellationToken = default);

        /// <summary>search groups</summary>
        [Post("/groups/search")]
        Task<GroupsSearchResponseV1> SearchGroupsPost([Body] GroupsSearchRequestV1 groupsSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update an group</summary>
        [Patch("/groups/{id}")]
        Task<ApiResponseV1> UpdateGroup(long id, [Body] GroupsModelUpdateV1 groupsModelUpdateV1, CancellationToken cancellationToken = default);
    }
}