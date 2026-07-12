using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Publishers endpoints of the MangaUpdates API.
    /// </summary>
    public interface IPublishersApi
    {
        /// <summary>add an publisher</summary>
        [Post("/publishers")]
        Task<ApiResponseV1> AddPublisher([Body] PublishersModelUpdateV1 publishersModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a publisher</summary>
        [Delete("/publishers/{id}")]
        Task<ApiResponseV1> DeletePublisher(long id, CancellationToken cancellationToken = default);

        /// <summary>get the list of series for a specific publication</summary>
        [Get("/publishers/publication")]
        Task<PublishersPublicationResponseV1> RetrievePublicationSeries([Query] string pubname, CancellationToken cancellationToken = default);

        /// <summary>get a specific publisher</summary>
        [Get("/publishers/{id}")]
        Task<PublishersModelV1> RetrievePublisher(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get the list of series for a specific publisher</summary>
        [Get("/publishers/{id}/series")]
        Task<PublishersSeriesListResponseV1> RetrievePublisherSeries(long id, CancellationToken cancellationToken = default);

        /// <summary>search publishers</summary>
        [Post("/publishers/search")]
        Task<PublishersSearchResponseV1> SearchPublishersPost([Body] PublishersSearchRequestV1 publishersSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>update a publisher</summary>
        [Patch("/publishers/{id}")]
        Task<ApiResponseV1> UpdatePublisher(long id, [Body] PublishersModelUpdateV1 publishersModelUpdateV1, CancellationToken cancellationToken = default);
    }
}