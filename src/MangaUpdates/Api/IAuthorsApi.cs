using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Authors endpoints of the MangaUpdates API.
    /// </summary>
    public interface IAuthorsApi
    {
        /// <summary>add an author</summary>
        [Post("/authors")]
        Task<ApiResponseV1> AddAuthor([Body] AuthorsModelUpdateV1 authorsModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete an author</summary>
        [Delete("/authors/{id}")]
        Task<ApiResponseV1> DeleteAuthor(long id, CancellationToken cancellationToken = default);

        /// <summary>delete the image of an author</summary>
        [Delete("/authors/{id}/image")]
        Task<ApiResponseV1> DeleteImage(long id, CancellationToken cancellationToken = default);

        /// <summary>lock a field of an author</summary>
        [Post("/authors/{id}/locks/{item}/lock")]
        Task<ApiResponseV1> LockAuthorField(long id, string item, [Body] AuthorsLockModelUpdateV1 authorsLockModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>get a specific author</summary>
        [Get("/authors/{id}")]
        Task<AuthorsModelV1> RetrieveAuthor(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get locks for a specific author</summary>
        [Get("/authors/{id}/locks")]
        Task<List<AuthorsLockModelV1>> RetrieveAuthorLocks(long id, CancellationToken cancellationToken = default);

        /// <summary>get the list of series for a specific author</summary>
        [Post("/authors/{id}/series")]
        Task<AuthorsSeriesListResponseV1> RetrieveAuthorSeries(long id, [Body] AuthorsSeriesListRequestV1 authorsSeriesListRequestV1, CancellationToken cancellationToken = default);

        /// <summary>search authors</summary>
        [Post("/authors/search")]
        Task<AuthorsSearchResponseV1> SearchAuthorsPost([Body] AuthorsSearchRequestV1 authorsSearchRequestV1, CancellationToken cancellationToken = default);

        /// <summary>unlock a field of an author</summary>
        [Post("/authors/{id}/locks/{item}/unlock")]
        Task<ApiResponseV1> UnlockAuthorField(long id, string item, CancellationToken cancellationToken = default);

        /// <summary>update an author</summary>
        [Patch("/authors/{id}")]
        Task<ApiResponseV1> UpdateAuthor(long id, [Body] AuthorsModelUpdateV1 authorsModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update the image of an author</summary>
        [Multipart]
        [Post("/authors/{id}/image")]
        Task<ApiResponseV1> UpdateImage(long id, [AliasAs("image")] StreamPart image, CancellationToken cancellationToken = default);
    }
}