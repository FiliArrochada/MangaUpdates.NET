using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Lists endpoints of the MangaUpdates API.
    /// </summary>
    public interface IListsApi
    {
        /// <summary>add a custom user list</summary>
        [Post("/lists")]
        Task<ApiResponseV1> AddCustomList([Body] ListsModelUpdateV1 listsModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a series to a list</summary>
        [Post("/lists/series")]
        Task<object> AddListSeries([Body] List<ListsSeriesModelUpdateV1> listsSeriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a list of series to a list</summary>
        [Post("/lists/{id}/series/bulk")]
        Task<ApiResponseV1> AddListSeriesBulk(long id, [Body] List<ListsBulkAddModelV1> listsBulkAddModelV1, CancellationToken cancellationToken = default);

        /// <summary>remove a custom list</summary>
        [Delete("/lists/{id}")]
        Task<ApiResponseV1> DeleteCustomList(long id, CancellationToken cancellationToken = default);

        /// <summary>remove a series from a list</summary>
        [Post("/lists/series/delete")]
        Task<ApiResponseV1> DeleteListSeries([Body] List<long> requestBody, CancellationToken cancellationToken = default);

        /// <summary>retrieve list metadata and options</summary>
        [Get("/lists/{id}")]
        Task<ListsModelV1> RetrieveListById(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>retrieve list series item</summary>
        [Get("/lists/series/{series_id}")]
        Task<ListsSeriesModelV1> RetrieveListSeries([AliasAs("series_id")] long seriesId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>retrieve list of user lists</summary>
        [Get("/lists")]
        Task<List<ListsModelV1>> RetrieveLists(CancellationToken cancellationToken = default);

        /// <summary>retrieve stats for user public lists</summary>
        [Get("/lists/public/{user_id}/stats")]
        Task<ListsPublicStatsModelV1> RetrievePublicListStats([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>retrieve list of user lists</summary>
        [Get("/lists/public/{user_id}")]
        Task<List<ListsModelV1>> RetrievePublicLists([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>retrieve users who have similar interests based on series</summary>
        [Get("/lists/similar/{list_name}/{series_id}")]
        Task<ListsSimilarUsersResponseV1> RetrieveSimilarUsersBySeries([AliasAs("list_name")] string listName, [AliasAs("series_id")] long seriesId, CancellationToken cancellationToken = default);

        /// <summary>search lists</summary>
        [Post("/lists/{id}/search")]
        Task<ListsSearchResponseV1> SearchListsPost(long id, [Body] ListsSearchRequestV1 listsSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search lists</summary>
        [Post("/lists/public/{user_id}/search/{id}")]
        Task<ListsPublicSearchResponseV1> SearchPublicListsPost([AliasAs("user_id")] long userId, long id, [Body] ListsSearchRequestV1 listsSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update a user list</summary>
        [Patch("/lists/{id}")]
        Task<ApiResponseV1> UpdateList(long id, [Body] ListsModelUpdateV1 listsModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a series list item</summary>
        [Post("/lists/series/update")]
        Task<ApiResponseV1> UpdateListSeries([Body] List<ListsSeriesModelUpdateV1> listsSeriesModelUpdateV1, CancellationToken cancellationToken = default);
    }
}