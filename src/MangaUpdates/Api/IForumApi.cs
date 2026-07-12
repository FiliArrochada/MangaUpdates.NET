using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Forum endpoints of the MangaUpdates API.
    /// </summary>
    public interface IForumApi
    {
        /// <summary>add a forum admin</summary>
        [Put("/forums/{forum_id}/admins/{user_id}")]
        Task<ApiResponseV1> AddForumAdmin([AliasAs("forum_id")] long forumId, [AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>add a vote to a forum poll</summary>
        [Post("/forums/{forum_id}/topics/{topic_id}/poll/vote/{choice_id}")]
        Task<ApiResponseV1> AddPollVote([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("choice_id")] long choiceId, CancellationToken cancellationToken = default);

        /// <summary>add a forum post</summary>
        [Post("/forums/{forum_id}/topics/{topic_id}")]
        Task<ApiResponseV1> AddPost([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [Body] ForumPostModelUpdateV1 forumPostModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a temporary poll image</summary>
        [Multipart]
        [Post("/forums/temp_poll_images")]
        Task<ApiResponseV1> AddTemporaryPollImage([AliasAs("image")] StreamPart image = null, [AliasAs("caption")] string caption = null, CancellationToken cancellationToken = default);

        /// <summary>add a forum topic</summary>
        [Post("/forums/{forum_id}")]
        Task<ApiResponseV1> AddTopic([AliasAs("forum_id")] long forumId, [Body] ForumTopicModelAddV1 forumTopicModelAddV1, CancellationToken cancellationToken = default);

        /// <summary>delete a post</summary>
        [Delete("/forums/{forum_id}/topics/{topic_id}/posts/{post_id}")]
        Task<ApiResponseV1> DeletePost([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("post_id")] long postId, CancellationToken cancellationToken = default);

        /// <summary>delete a post report</summary>
        [Delete("/forums/{forum_id}/topics/{topic_id}/posts/{post_id}/report")]
        Task<ApiResponseV1> DeletePostReport([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("post_id")] long postId, CancellationToken cancellationToken = default);

        /// <summary>delete a topic</summary>
        [Delete("/forums/{forum_id}/topics/{topic_id}")]
        Task<ApiResponseV1> DeleteTopic([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>gets the current warn status for user</summary>
        [Get("/forums/warn/{user_id}")]
        Task<ForumWarnModelV1> GetCurrentWarnForUser([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>show forum categories and forums</summary>
        [Get("/forums")]
        Task<List<ForumCategoryModelListV1>> ListCategories(CancellationToken cancellationToken = default);

        /// <summary>list global topics</summary>
        [Get("/forums/global")]
        Task<ForumTopicListResponseV1> ListGlobalTopics(CancellationToken cancellationToken = default);

        /// <summary>show popular forums</summary>
        [Get("/forums/popular")]
        Task<List<ForumForumModelListV1>> ListPopularForums(CancellationToken cancellationToken = default);

        /// <summary>list posts in topic</summary>
        [Post("/forums/{forum_id}/topics/{topic_id}/list")]
        Task<ForumPostListResponseV1> ListPosts([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [Body] PerPageSearchRequestV1 perPageSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>list posts in topic that I made</summary>
        [Get("/forums/{forum_id}/topics/{topic_id}/my_posts")]
        Task<ForumPostByUserResponseV1> ListPostsByMe([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>show reported posts</summary>
        [Get("/forums/report")]
        Task<List<ForumPostReportModelV1>> ListReportedPosts(CancellationToken cancellationToken = default);

        /// <summary>list topics</summary>
        [Post("/forums/{forum_id}/list")]
        Task<ForumTopicListResponseV1> ListTopics([AliasAs("forum_id")] long forumId, [Body] ForumTopicListRequestV1 forumTopicListRequestV1, [Query][AliasAs("with_first_post")] bool? withFirstPost = null, CancellationToken cancellationToken = default);

        /// <summary>show warn history for a user</summary>
        [Get("/forums/warn/{user_id}/history")]
        Task<List<ForumWarnModelV1>> ListWarnHistoryForUser([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>lookup a post to find the forum and topic id</summary>
        [Get("/forums/lookup/post/{post_id}")]
        Task<ForumLookupResponseV1> LookupPost([AliasAs("post_id")] long postId, CancellationToken cancellationToken = default);

        /// <summary>lookup a series to find the forum id</summary>
        [Get("/forums/lookup/series/{series_id}")]
        Task<ForumLookupResponseV1> LookupSeries([AliasAs("series_id")] long seriesId, CancellationToken cancellationToken = default);

        /// <summary>lookup a topic to find the forum id</summary>
        [Get("/forums/lookup/topic/{topic_id}")]
        Task<ForumLookupResponseV1> LookupTopic([AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>remove a forum admin</summary>
        [Delete("/forums/{forum_id}/admins/{user_id}")]
        Task<ApiResponseV1> RemoveForumAdmin([AliasAs("forum_id")] long forumId, [AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>report a forum post</summary>
        [Post("/forums/{forum_id}/topics/{topic_id}/posts/{post_id}/report")]
        Task<ApiResponseV1> ReportPost([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("post_id")] long postId, [Body] ForumPostReportModelUpdateV1 forumPostReportModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>retrieve a forum</summary>
        [Get("/forums/{forum_id}")]
        Task<ForumForumModelV1> RetrieveForum([AliasAs("forum_id")] long forumId, [Query] bool? unrenderedFields = null, CancellationToken cancellationToken = default);

        /// <summary>retrieve a forum post</summary>
        [Get("/forums/{forum_id}/topics/{topic_id}/posts/{post_id}")]
        Task<ForumPostModelV1> RetrievePost([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("post_id")] long postId, [Query] bool? unrenderedFields = null, CancellationToken cancellationToken = default);

        /// <summary>retrieve a forum post location within topic</summary>
        [Get("/forums/{forum_id}/topics/{topic_id}/posts/{post_id}/location")]
        Task<ApiResponseV1> RetrievePostLocation([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("post_id")] long postId, CancellationToken cancellationToken = default);

        /// <summary>retrieve temporary poll images</summary>
        [Get("/forums/temp_poll_images")]
        Task<List<ForumPollTempImageModelV1>> RetrieveTemporaryPollImages(CancellationToken cancellationToken = default);

        /// <summary>retrieve a forum topic</summary>
        [Get("/forums/{forum_id}/topics/{topic_id}")]
        Task<ForumTopicModelV1> RetrieveTopic([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [Query] bool? unrenderedFields = null, CancellationToken cancellationToken = default);

        /// <summary>retrieve my vote from the poll</summary>
        [Get("/forums/{forum_id}/topics/{topic_id}/poll/vote")]
        Task<ForumPollVoteModelV1> RetrieveVote([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>search forum</summary>
        [Post("/forums/search")]
        Task<ForumSearchResponseV1> SearchForumPost([Body] ForumSearchRequestV1 forumSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search specific forum</summary>
        [Post("/forums/{forum_id}/search")]
        Task<ForumSearchResponseV1> SearchSpecificForumPost([AliasAs("forum_id")] long forumId, [Body] ForumSearchRequestV1 forumSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search specific topic</summary>
        [Post("/forums/{forum_id}/topics/{topic_id}/search")]
        Task<ForumSearchResponseV1> SearchSpecificTopicPost([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [Body] ForumSearchRequestV1 forumSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>show forum admin log</summary>
        [Post("/forums/log")]
        Task<ForumAdminHistorySearchResponseV1> ShowLogPost([Body] ForumAdminHistorySearchRequestV1 forumAdminHistorySearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update a forum post</summary>
        [Patch("/forums/{forum_id}/topics/{topic_id}/posts/{post_id}")]
        Task<ApiResponseV1> UpdatePost([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [AliasAs("post_id")] long postId, [Body] ForumPostModelUpdateV1 forumPostModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a forum topic</summary>
        [Patch("/forums/{forum_id}/topics/{topic_id}")]
        Task<ApiResponseV1> UpdateTopic([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [Body] ForumTopicModelUpdateV1 forumTopicModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a forum topic poll (if present)</summary>
        [Patch("/forums/{forum_id}/topics/{topic_id}/poll")]
        Task<ApiResponseV1> UpdateTopicPoll([AliasAs("forum_id")] long forumId, [AliasAs("topic_id")] long topicId, [Body] ForumPollModelUpdateV1 forumPollModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a user warn level</summary>
        [Put("/forums/warn/{user_id}")]
        Task<ApiResponseV1> UpdateUserWarnLevel([AliasAs("user_id")] long userId, [Body] ForumWarnModelUpdateV1 forumWarnModelUpdateV1, CancellationToken cancellationToken = default);
    }
}