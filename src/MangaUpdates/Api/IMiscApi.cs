using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Misc endpoints of the MangaUpdates API.
    /// </summary>
    public interface IMiscApi
    {
        /// <summary>list online users</summary>
        [Get("/misc/online")]
        Task<MiscOnlineUsersModelV1> ListOnlineUsers(CancellationToken cancellationToken = default);

        /// <summary>get the status of a bulk transaction</summary>
        [Get("/misc/slow-transaction-status/{transaction_id}")]
        Task<MiscSlowTransactionStatusResponseV1> RetrieveSlowTransactionStatus([AliasAs("transaction_id")] string transactionId, CancellationToken cancellationToken = default);

        /// <summary>show various site stats</summary>
        [Get("/misc/stats")]
        Task<MiscStatsModelV1> SiteStats(CancellationToken cancellationToken = default);

        /// <summary>get the current time</summary>
        [Get("/misc/time")]
        Task<TimeV1> Time(CancellationToken cancellationToken = default);
    }
}