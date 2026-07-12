using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Series endpoints of the MangaUpdates API.
    /// </summary>
    public interface ISeriesApi
    {
        /// <summary>add an series</summary>
        [Post("/series")]
        Task<ApiResponseV1> AddSeries([Body] SeriesModelUpdateV1 seriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a vote for a category on a series</summary>
        [Post("/series/{id}/categories/vote")]
        Task<ApiResponseV1> AddSeriesCategoryVote(long id, [Body] SeriesCategoryVoteModelV1 seriesCategoryVoteModelV1, CancellationToken cancellationToken = default);

        /// <summary>add a series comment</summary>
        [Post("/series/{id}/comments")]
        Task<ApiResponseV1> AddSeriesComment(long id, [Body] SeriesCommentModelUpdateV1 seriesCommentModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>set usefulness of a series comment</summary>
        [Put("/series/{id}/comments/{comment_id}/useful")]
        Task<ApiResponseV1> AddSeriesCommentUsefulFlag(long id, [AliasAs("comment_id")] long commentId, [Body] SeriesCommentUsefulModelV1 seriesCommentUsefulModelV1, CancellationToken cancellationToken = default);

        /// <summary>combine two series categories</summary>
        [Post("/series/{id}/categories/combine")]
        Task<ApiResponseV1> CombineSeriesCategories(long id, [Body] SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1, CancellationToken cancellationToken = default);

        /// <summary>delete a series</summary>
        [Delete("/series/{id}")]
        Task<ApiResponseV1> DeleteSeries(long id, CancellationToken cancellationToken = default);

        /// <summary>deletes a series category</summary>
        [Post("/series/{id}/categories/delete")]
        Task<ApiResponseV1> DeleteSeriesCategory(long id, [Body] CategoriesModelUpdateV1 categoriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a series comment</summary>
        [Delete("/series/{id}/comments/{comment_id}")]
        Task<ApiResponseV1> DeleteSeriesComment(long id, [AliasAs("comment_id")] long commentId, CancellationToken cancellationToken = default);

        /// <summary>delete the image of an series</summary>
        [Delete("/series/{id}/image")]
        Task<ApiResponseV1> DeleteSeriesImage(long id, CancellationToken cancellationToken = default);

        /// <summary>delete a series rating for a user</summary>
        [Delete("/series/{id}/rating")]
        Task<ApiResponseV1> DeleteUserSeriesRating(long id, CancellationToken cancellationToken = default);

        /// <summary>lock a field of an series</summary>
        [Post("/series/{id}/locks/{item}/lock")]
        Task<ApiResponseV1> LockSeriesField(long id, string item, [Body] SeriesLockModelUpdateV1 seriesLockModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>remove series category vote for user</summary>
        [Post("/series/{id}/categories/vote/delete")]
        Task<ApiResponseV1> RemoveSeriesCategoryVote(long id, [Body] SeriesCategoryVoteDeleteModelV1 seriesCategoryVoteDeleteModelV1, CancellationToken cancellationToken = default);

        /// <summary>remove usefulness of a series comment</summary>
        [Delete("/series/{id}/comments/{comment_id}/useful")]
        Task<ApiResponseV1> RemoveSeriesCommentUsefulFlag(long id, [AliasAs("comment_id")] long commentId, CancellationToken cancellationToken = default);

        /// <summary>renames a series category</summary>
        [Post("/series/{id}/categories/rename")]
        Task<ApiResponseV1> RenameSeriesCategory(long id, [Body] SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1, CancellationToken cancellationToken = default);

        /// <summary>report a series comment</summary>
        [Post("/series/{id}/comments/{comment_id}/report")]
        Task<ApiResponseV1> ReportSeriesComment(long id, [AliasAs("comment_id")] long commentId, [Body] SeriesCommentReportModelV1 seriesCommentReportModelV1, CancellationToken cancellationToken = default);

        /// <summary>get my series comment</summary>
        [Get("/series/{id}/comments/my_comment")]
        Task<SeriesCommentModelV1> RetrieveMySeriesComment(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get a specific series</summary>
        [Get("/series/{id}")]
        Task<SeriesModelV1> RetrieveSeries(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get category votes for the current user</summary>
        [Get("/series/{id}/categories/votes")]
        Task<List<SeriesCategoryVoteModelV1>> RetrieveSeriesCategoryVotes(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific series comment</summary>
        [Get("/series/{id}/comments/{comment_id}")]
        Task<SeriesCommentModelV1> RetrieveSeriesComment(long id, [AliasAs("comment_id")] long commentId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get a specific series comment location</summary>
        [Get("/series/{id}/comments/{comment_id}/location")]
        Task<ApiResponseV1> RetrieveSeriesCommentLocation(long id, [AliasAs("comment_id")] long commentId, CancellationToken cancellationToken = default);

        /// <summary>get the list of groups scanlating a specific series</summary>
        [Get("/series/{id}/groups")]
        Task<SeriesGroupListResponseV1> RetrieveSeriesGroups(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific series lock</summary>
        [Get("/series/{id}/locks")]
        Task<List<SeriesLockModelV1>> RetrieveSeriesLocks(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific series rank location</summary>
        [Get("/series/{id}/rank/{type}")]
        Task<ApiResponseV1> RetrieveSeriesRankLocation(long id, string type, CancellationToken cancellationToken = default);

        /// <summary>get a the series rating rainbow</summary>
        [Get("/series/{id}/ratingrainbow")]
        Task<SeriesRatingRainbowModelV1> RetrieveSeriesRatingRainbow(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific series rating for a user</summary>
        [Get("/series/{id}/rating")]
        Task<SeriesRatingModelV1> RetrieveUserSeriesRating(long id, CancellationToken cancellationToken = default);

        /// <summary>search series comments</summary>
        [Post("/series/{id}/comments/search")]
        Task<SeriesCommentSearchResponseV1> SearchSeriesCommentsPost(long id, [Body] SeriesCommentSearchRequestV1 seriesCommentSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search series history</summary>
        [Post("/series/{id}/history")]
        Task<SeriesHistorySearchResponseV1> SearchSeriesHistoryPost(long id, [Body] PerPageSearchRequestV1 perPageSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search series</summary>
        [Post("/series/search")]
        Task<SeriesSearchResponseV1> SearchSeriesPost([Body] SeriesSearchRequestV1 seriesSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>moderate series comments</summary>
        [Post("/series/comments/moderation")]
        Task<SeriesCommentModerationResponseV1> SeriesCommentsModerationPost([Body] SeriesCommentSearchRequestV1 seriesCommentSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>releases rss feed for a specific series</summary>
        [Get("/series/{id}/rss")]
        Task<string> SeriesReleaseRssFeed(long id, CancellationToken cancellationToken = default);

        /// <summary>unlock a field of an series</summary>
        [Post("/series/{id}/locks/{item}/unlock")]
        Task<ApiResponseV1> UnlockSeriesField(long id, string item, CancellationToken cancellationToken = default);

        /// <summary>update an series</summary>
        [Patch("/series/{id}")]
        Task<ApiResponseV1> UpdateSeries(long id, [Body] SeriesModelUpdateV1 seriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a series comment</summary>
        [Patch("/series/{id}/comments/{comment_id}")]
        Task<ApiResponseV1> UpdateSeriesComment(long id, [AliasAs("comment_id")] long commentId, [Body] SeriesCommentModelUpdateV1 seriesCommentModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update the image of an series</summary>
        [Multipart]
        [Post("/series/{id}/image")]
        Task<ApiResponseV1> UpdateSeriesImage(long id, [AliasAs("image")] StreamPart image, CancellationToken cancellationToken = default);

        /// <summary>update the user rating for a series</summary>
        [Put("/series/{id}/rating")]
        Task<ApiResponseV1> UpdateUserSeriesRating(long id, [Body] SeriesRatingModelV1 seriesRatingModelV1, CancellationToken cancellationToken = default);
    }
}