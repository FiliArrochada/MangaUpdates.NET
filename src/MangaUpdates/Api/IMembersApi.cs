using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Members endpoints of the MangaUpdates API.
    /// </summary>
    public interface IMembersApi
    {
        /// <summary>add a member</summary>
        [Post("/members")]
        Task<ApiResponseV1> AddMember([Body] UserModelUpdateV1 userModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a new member avatar</summary>
        [Post("/members/{id}/avatar")]
        [Multipart]
        Task<ApiResponseV1> AddMemberAvatar(long id, [AliasAs("image")] StreamPart image, [AliasAs("title")] string title, CancellationToken cancellationToken = default);

        /// <summary>add a change request</summary>
        [Post("/members/{id}/requests")]
        Task<ApiResponseV1> AddMemberChangeRequest(long id, [Body] UserChangeRequestModelUpdateV1 userChangeRequestModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>filter a genre for a user</summary>
        [Post("/members/{id}/genre/{genre_id}/filter")]
        Task<ApiResponseV1> AddMemberGenreFilter(long id, [AliasAs("genre_id")] long genreId, CancellationToken cancellationToken = default);

        /// <summary>highlight a genre for a user</summary>
        [Post("/members/{id}/genre/{genre_id}/highlight")]
        Task<ApiResponseV1> AddMemberGenreHighlight(long id, [AliasAs("genre_id")] long genreId, [Body] UserGenreHighlightModelUpdateV1 userGenreHighlightModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>filter a group for a user</summary>
        [Post("/members/{id}/group/{group_id}/filter")]
        Task<ApiResponseV1> AddUserGroupFilter(long id, [AliasAs("group_id")] long groupId, CancellationToken cancellationToken = default);

        /// <summary>add a topic subscription for a user</summary>
        [Post("/members/{id}/topics/{topic_id}")]
        Task<ApiResponseV1> AddUserTopicSubscription(long id, [AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>upgrade a member</summary>
        [Post("/members/{id}/upgrade/approve")]
        Task<ApiResponseV1> ApproveMemberUpgrade(long id, CancellationToken cancellationToken = default);

        /// <summary>delete a member</summary>
        [Delete("/members/{id}")]
        Task<ApiResponseV1> DeleteMember(long id, CancellationToken cancellationToken = default);

        /// <summary>delete a member avatar</summary>
        [Delete("/members/{id}/avatar/{avatar_id}")]
        Task<ApiResponseV1> DeleteMemberAvatar(long id, [AliasAs("avatar_id")] long avatarId, CancellationToken cancellationToken = default);

        /// <summary>add a change request</summary>
        [Delete("/members/{id}/requests/{request_id}")]
        Task<ApiResponseV1> DeleteMemberChangeRequest(long id, [AliasAs("request_id")] long requestId, CancellationToken cancellationToken = default);

        /// <summary>delete all a members sessions</summary>
        [Delete("/members/{id}/sessions")]
        Task<ApiResponseV1> DeleteMemberSessions(long id, CancellationToken cancellationToken = default);

        /// <summary>mark notifications as read for a specific user</summary>
        [Post("/members/{id}/notifications/mark-read")]
        Task<MemberNotificationMarkReadResponseV1> MarkMemberNotificationsRead(long id, [Body] MemberNotificationMarkReadRequestV1 memberNotificationMarkReadRequestV1, CancellationToken cancellationToken = default);

        /// <summary>reject a member upgrade</summary>
        [Post("/members/{id}/upgrade/reject")]
        Task<ApiResponseV1> RejectMemberUpgrade(long id, CancellationToken cancellationToken = default);

        /// <summary>remove a filter for a genre for a user</summary>
        [Delete("/members/{id}/genre/{genre_id}/filter")]
        Task<ApiResponseV1> RemoveMemberGenreFilter(long id, [AliasAs("genre_id")] long genreId, CancellationToken cancellationToken = default);

        /// <summary>remove a highlight for a genre for a user</summary>
        [Delete("/members/{id}/genre/{genre_id}/highlight")]
        Task<ApiResponseV1> RemoveMemberGenreHighlight(long id, [AliasAs("genre_id")] long genreId, CancellationToken cancellationToken = default);

        /// <summary>remove a filter for a group for a user</summary>
        [Delete("/members/{id}/group/{group_id}/filter")]
        Task<ApiResponseV1> RemoveUserGroupFilter(long id, [AliasAs("group_id")] long groupId, CancellationToken cancellationToken = default);

        /// <summary>remove a topic subscription for a user</summary>
        [Delete("/members/{id}/topics/{topic_id}")]
        Task<ApiResponseV1> RemoveUserTopicSubscription(long id, [AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>reset genre highlights and filters for a user</summary>
        [Post("/members/{id}/genre/reset")]
        Task<ApiResponseV1> ResetGenreSettings(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific members</summary>
        [Get("/members/{id}")]
        Task<UserModelV1> RetrieveMember(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get avatars for a specific user</summary>
        [Get("/members/{id}/avatars")]
        Task<List<AvatarModelV1>> RetrieveMemberAvatars(long id, CancellationToken cancellationToken = default);

        /// <summary>get change requests for a specific user</summary>
        [Get("/members/{id}/requests/{request_id}")]
        Task<UserChangeRequestModelV1> RetrieveMemberChangeRequest(long id, [AliasAs("request_id")] long requestId, CancellationToken cancellationToken = default);

        /// <summary>get genre filters for a specific user</summary>
        [Get("/members/{id}/genre/filters")]
        Task<List<UserGenreFilterModelV1>> RetrieveMemberGenreFilters(long id, CancellationToken cancellationToken = default);

        /// <summary>get highlights for a specific user</summary>
        [Get("/members/{id}/genre/highlights")]
        Task<List<UserGenreHighlightModelV1>> RetrieveMemberGenreHighlights(long id, CancellationToken cancellationToken = default);

        /// <summary>get group filters for a specific user</summary>
        [Get("/members/{id}/group/filters")]
        Task<List<UserGroupFilterModelV1>> RetrieveMemberGroupFilters(long id, CancellationToken cancellationToken = default);

        /// <summary>get notification preferences for a specific user</summary>
        [Get("/members/{id}/notification-preferences")]
        Task<List<UserNotificationPreferenceModelV1>> RetrieveMemberNotificationPreferences(long id, CancellationToken cancellationToken = default);

        /// <summary>get unread notification count for a specific user</summary>
        [Get("/members/{id}/notifications/unread-count")]
        Task<MemberNotificationUnreadCountV1> RetrieveMemberNotificationUnreadCount(long id, CancellationToken cancellationToken = default);

        /// <summary>get notifications for a specific user</summary>
        [Get("/members/{id}/notifications")]
        Task<List<UserNotificationModelV1>> RetrieveMemberNotifications(long id, [Query] [AliasAs("unread_only")] bool? unreadOnly = default, [Query] int? limit = default, [Query] int? offset = default, CancellationToken cancellationToken = default);

        /// <summary>get a subscription to a specific topic for a user</summary>
        [Get("/members/{id}/topics/{topic_id}")]
        Task<UserSubscribedTopicModelV1> RetrieveMemberTopicSubscription(long id, [AliasAs("topic_id")] long topicId, CancellationToken cancellationToken = default);

        /// <summary>get topic subscriptions for a specific user</summary>
        [Get("/members/{id}/topics")]
        Task<List<UserSubscribedTopicModelV1>> RetrieveMemberTopicSubscriptions(long id, CancellationToken cancellationToken = default);

        /// <summary>get a specific member sessions if they exists</summary>
        [Get("/members/{id}/sessions")]
        Task<UserSessionResponseV1> RetrieveSessions(long id, CancellationToken cancellationToken = default);

        /// <summary>search change requests for a specific user</summary>
        [Get("/members/{id}/requests")]
        Task<UserChangeRequestSearchResponseV1> SearchMemberChangeRequests(long id, [Query] long? page = default, [Query] long? perpage = default, [Query] string orderby = default, [Query] string asc = default, CancellationToken cancellationToken = default);

        /// <summary>search members</summary>
        [Post("/members/search")]
        Task<UserSearchResponseV1> SearchMembersPost([Body] UserSearchRequestV1 userSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update a member</summary>
        [Patch("/members/{id}")]
        Task<ApiResponseV1> UpdateMember(long id, [Body] UserModelUpdateV1 userModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a change request</summary>
        [Patch("/members/{id}/requests/{request_id}")]
        Task<ApiResponseV1> UpdateMemberChangeRequest(long id, [AliasAs("request_id")] long requestId, [Body] UserChangeRequestModelUpdateV1 userChangeRequestModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update all notification preferences for a specific user</summary>
        [Put("/members/{id}/notification-preferences")]
        Task<ApiResponseV1> UpdateMemberNotificationPreferences(long id, [Body] List<UserNotificationPreferenceUpdateModelV1> userNotificationPreferenceUpdateModelV1, CancellationToken cancellationToken = default);
    }
}