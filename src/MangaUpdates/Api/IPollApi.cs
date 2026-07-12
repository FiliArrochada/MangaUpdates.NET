using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Poll endpoints of the MangaUpdates API.
    /// </summary>
    public interface IPollApi
    {
        /// <summary>add a new poll</summary>
        [Post("/poll")]
        Task<ApiResponseV1> AddPoll([Body] PollModelUpdateV1 pollModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>archive the active poll</summary>
        [Delete("/poll")]
        Task<ApiResponseV1> ArchivePoll(CancellationToken cancellationToken = default);

        /// <summary>get old polls</summary>
        [Get("/poll/old")]
        Task<ApiResponseV1> RetrieveOldPolls(CancellationToken cancellationToken = default);

        /// <summary>get the active poll</summary>
        [Get("/poll")]
        Task<PollModelV1> RetrievePoll(CancellationToken cancellationToken = default);

        /// <summary>get information about whether the user has voted</summary>
        [Get("/poll/vote/status")]
        Task<PollVoteStatusModelV1> RetrieveVoteStatus(CancellationToken cancellationToken = default);

        /// <summary>vote in a poll answer</summary>
        [Post("/poll/vote/{answer_id}")]
        Task<ApiResponseV1> VotePollAnswer([AliasAs("answer_id")] long answerId, CancellationToken cancellationToken = default);

        /// <summary>vote in a poll</summary>
        [Post("/poll/vote")]
        Task<ApiResponseV1> VotePollNoAnswer(CancellationToken cancellationToken = default);
    }
}