using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Convo endpoints of the MangaUpdates API.
    /// </summary>
    public interface IConvoApi
    {
        /// <summary>abandon a convo</summary>
        [Post("/convo/{id}/abandon")]
        Task<ApiResponseV1> AbandonConvo(long id, CancellationToken cancellationToken = default);

        /// <summary>abandon convos in bulk</summary>
        [Post("/convo/bulk/abandon")]
        Task<ApiResponseV1> AbandonConvoBulk([Body] ConvoBulkModelV1 convoBulkModelV1, CancellationToken cancellationToken = default);

        /// <summary>add an convo</summary>
        [Post("/convo")]
        Task<ApiResponseV1> AddConvo([Body] ConvoModelAddV1 convoModelAddV1, CancellationToken cancellationToken = default);

        /// <summary>add a message to a convo</summary>
        [Post("/convo/{id}/messages")]
        Task<ApiResponseV1> AddConvoMessage(long id, [Body] ConvoMessageModelUpdateV1 convoMessageModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>display unread messages</summary>
        [Get("/convo/inbox")]
        Task<ConvoSearchResponseV1> ConvoInbox(CancellationToken cancellationToken = default);

        /// <summary>retrieve number of unread messages</summary>
        [Get("/convo/inbox/count")]
        Task<ConvoSearchResponseV1> ConvoInboxCount(CancellationToken cancellationToken = default);

        /// <summary>display received (and read) messages</summary>
        [Post("/convo/received")]
        Task<ConvoSearchResponseV1> ConvoReceived([Body] PerPageSearchRequestV1 perPageSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>display sent messages</summary>
        [Post("/convo/sent")]
        Task<ConvoSearchResponseV1> ConvoSent([Body] PerPageSearchRequestV1 perPageSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>delete a convo</summary>
        [Delete("/convo/{id}")]
        Task<ApiResponseV1> DeleteConvo(long id, CancellationToken cancellationToken = default);

        /// <summary>delete convos in bulk</summary>
        [Post("/convo/bulk/delete")]
        Task<ApiResponseV1> DeleteConvoBulk([Body] ConvoBulkModelV1 convoBulkModelV1, CancellationToken cancellationToken = default);

        /// <summary>ignore a user</summary>
        [Post("/convo/ignore/{user_id}")]
        Task<ApiResponseV1> IgnoreUser([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>invite a user to a convo</summary>
        [Post("/convo/{id}/invite")]
        Task<ApiResponseV1> InviteUserToConvo(long id, [Body] List<ConvoParticipantModelAddV1> convoParticipantModelAddV1, CancellationToken cancellationToken = default);

        /// <summary>return whether the user is ignored</summary>
        [Get("/convo/ignore/{user_id}")]
        Task<ConvoUserIgnoreModelV1> IsUserIgnored([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>join a convo</summary>
        [Post("/convo/{id}/join")]
        Task<ApiResponseV1> JoinConvo(long id, CancellationToken cancellationToken = default);

        /// <summary>kick a user from a convo</summary>
        [Post("/convo/{id}/kick/{user_id}")]
        Task<ApiResponseV1> KickUserFromConvo(long id, [AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>list convo messages</summary>
        [Post("/convo/{id}/messages/list")]
        Task<ConvoMessageSearchResponseV1> ListConvoMessages(long id, [Body] ConvoMessageListRequestV1 convoMessageListRequestV1, CancellationToken cancellationToken = default);

        /// <summary>get a specific convo</summary>
        [Get("/convo/{id}")]
        Task<ConvoModelV1> RetrieveConvo(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get a specific convo message</summary>
        [Get("/convo/{id}/messages/{message_id}")]
        Task<ConvoMessageModelV1> RetrieveConvoMessage(long id, [AliasAs("message_id")] long messageId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get a specific convo message location</summary>
        [Get("/convo/{id}/messages/{message_id}/location")]
        Task<ApiResponseV1> RetrieveConvoMessageLocation(long id, [AliasAs("message_id")] long messageId, CancellationToken cancellationToken = default);

        /// <summary>get list of convo participants</summary>
        [Get("/convo/{id}/participants")]
        Task<List<ConvoParticipantModelV1>> RetrieveConvoParticipants(long id, CancellationToken cancellationToken = default);

        /// <summary>search convo</summary>
        [Post("/convo/{id}/messages/search")]
        Task<ConvoMessageSearchResponseV1> SearchConvoMessagesPost(long id, [Body] ConvoMessageSearchRequestV1 convoMessageSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search convo</summary>
        [Post("/convo/search")]
        Task<ConvoSearchResponseV1> SearchConvoPost([Body] ConvoSearchRequestV1 convoSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>remove ignore for a user</summary>
        [Delete("/convo/ignore/{user_id}")]
        Task<ApiResponseV1> UnIgnoreUser([AliasAs("user_id")] long userId, CancellationToken cancellationToken = default);

        /// <summary>update a convo</summary>
        [Patch("/convo/{id}")]
        Task<ApiResponseV1> UpdateConvo(long id, [Body] ConvoModelUpdateV1 convoModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a convo message</summary>
        [Patch("/convo/{id}/messages/{message_id}")]
        Task<ApiResponseV1> UpdateConvoMessage(long id, [AliasAs("message_id")] long messageId, [Body] ConvoMessageModelUpdateV1 convoMessageModelUpdateV1, CancellationToken cancellationToken = default);
    }
}