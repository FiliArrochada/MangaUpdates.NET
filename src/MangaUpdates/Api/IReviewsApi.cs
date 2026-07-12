using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Reviews endpoints of the MangaUpdates API.
    /// </summary>
    public interface IReviewsApi
    {
        /// <summary>add a review</summary>
        [Post("/reviews")]
        Task<ApiResponseV1> AddReview([Body] ReviewModelUpdateV1 reviewModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a review comment</summary>
        [Post("/reviews/{id}/comments")]
        Task<ApiResponseV1> AddReviewComment(long id, [Body] ReviewCommentModelUpdateV1 reviewCommentModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a review</summary>
        [Delete("/reviews/{id}")]
        Task<ApiResponseV1> DeleteReview(long id, CancellationToken cancellationToken = default);

        /// <summary>delete a review comment</summary>
        [Delete("/reviews/{id}/comments/{comment_id}")]
        Task<ApiResponseV1> DeleteReviewComment(long id, [AliasAs("comment_id")] long commentId, CancellationToken cancellationToken = default);

        /// <summary>get a specific review</summary>
        [Get("/reviews/{id}")]
        Task<ReviewModelV1> RetrieveReview(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get a specific review comment</summary>
        [Get("/reviews/{id}/comments/{comment_id}")]
        Task<ReviewCommentModelV1> RetrieveReviewComment(long id, [AliasAs("comment_id")] long commentId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>moderate review comments</summary>
        [Post("/reviews/comments/moderation")]
        Task<ReviewCommentSearchResponseV1> ReviewCommentsModerationPost([Body] ReviewCommentSearchRequestV1 reviewCommentSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search review comments</summary>
        [Post("/reviews/{id}/comments/search")]
        Task<ReviewCommentSearchResponseV1> SearchReviewCommentsPost(long id, [Body] ReviewCommentSearchRequestV1 reviewCommentSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search reviews</summary>
        [Post("/reviews/search")]
        Task<ReviewSearchResponseV1> SearchReviewsPost([Body] ReviewSearchRequestV1 reviewSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update a review</summary>
        [Patch("/reviews/{id}")]
        Task<ApiResponseV1> UpdateReview(long id, [Body] ReviewModelUpdateV1 reviewModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a review comment</summary>
        [Patch("/reviews/{id}/comments/{comment_id}")]
        Task<ApiResponseV1> UpdateReviewComment(long id, [AliasAs("comment_id")] long commentId, [Body] ReviewCommentModelUpdateV1 reviewCommentModelUpdateV1, CancellationToken cancellationToken = default);
    }
}