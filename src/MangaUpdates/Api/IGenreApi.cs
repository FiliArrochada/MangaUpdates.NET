using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Genre endpoints of the MangaUpdates API.
    /// </summary>
    public interface IGenreApi
    {
        /// <summary>add a genre</summary>
        [Post("/genres")]
        Task<ApiResponseV1> AddGenre([Body] GenreModelUpdateV1 genreModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a genre</summary>
        [Delete("/genres/{id}")]
        Task<ApiResponseV1> DeleteGenre(long id, CancellationToken cancellationToken = default);

        /// <summary>get genres</summary>
        [Get("/genres/{id}")]
        Task<GenreModelStatsV1> RetrieveGenreById(long id, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get genres</summary>
        [Get("/genres")]
        Task<List<GenreModelStatsV1>> RetrieveGenres(CancellationToken cancellationToken = default);

        /// <summary>update a genre</summary>
        [Patch("/genres/{id}")]
        Task<ApiResponseV1> UpdateGenre(long id, [Body] GenreModelUpdateV1 genreModelUpdateV1, CancellationToken cancellationToken = default);
    }
}