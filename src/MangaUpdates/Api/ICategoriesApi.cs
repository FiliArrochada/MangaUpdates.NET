using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Categories endpoints of the MangaUpdates API.
    /// </summary>
    public interface ICategoriesApi
    {
        /// <summary>combine two categories across the database</summary>
        [Post("/categories/bulk/combine")]
        Task<ApiResponseV1> BulkCombineSeriesCategories([Body] SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1, CancellationToken cancellationToken = default);

        /// <summary>delete a category across the database</summary>
        [Post("/categories/bulk/delete")]
        Task<ApiResponseV1> BulkDeleteSeriesCategories([Body] CategoriesModelUpdateV1 categoriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>find a category by name</summary>
        [Post("/categories/findByExact")]
        Task<CategoriesModelV1> FindCategoryByExact([Body] CategoriesModelUpdateV1 categoriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>find a category by prefix</summary>
        [Post("/categories/findByPrefix")]
        Task<List<CategoriesModelV1>> FindCategoryByPrefix([Body] CategoriesModelUpdateV1 categoriesModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>search categories</summary>
        [Post("/categories/search")]
        Task<CategoriesSearchResponseV1> SearchCategoriesPost([Body] CategoriesSearchRequestV1 categoriesSearchRequestV1, CancellationToken cancellationToken = default);
    }
}