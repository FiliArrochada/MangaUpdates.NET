using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Aboutus endpoints of the MangaUpdates API.
    /// </summary>
    public interface IAboutusApi
    {
        /// <summary>add a category</summary>
        [Post("/aboutus/category")]
        Task<ApiResponseV1> AddAboutusCategory([Body] AboutusCategoryModelUpdateV1 aboutusCategoryModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a user to a category</summary>
        [Post("/aboutus/category/{category_id}/users")]
        Task<ApiResponseV1> AddAboutusCategoryUser([AliasAs("category_id")] long categoryId, [Body] AboutusUserModelUpdateV1 aboutusUserModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>remove a category</summary>
        [Delete("/aboutus/category/{category_id}")]
        Task<ApiResponseV1> DeleteAboutusCategory([AliasAs("category_id")] long categoryId, CancellationToken cancellationToken = default);

        /// <summary>remove a user from a category</summary>
        [Delete("/aboutus/category/{category_id}/users/{entry_id}")]
        Task<ApiResponseV1> DeleteAboutusCategoryUser([AliasAs("category_id")] long categoryId, [AliasAs("entry_id")] long entryId, CancellationToken cancellationToken = default);

        /// <summary>reorder aboutus</summary>
        [Post("/aboutus/reorder")]
        Task<ApiResponseV1> ReorderAboutus([Body] List<AboutusCategoryReorderModelV1> aboutusCategoryReorderModelV1, CancellationToken cancellationToken = default);

        /// <summary>returns categories and users</summary>
        [Get("/aboutus/users")]
        Task<List<AboutusCategoryModelV1>> RetrieveAboutusCategoriesAndUsers(CancellationToken cancellationToken = default);

        /// <summary>returns a single category</summary>
        [Get("/aboutus/category/{category_id}")]
        Task<AboutusCategoryModelV1> RetrieveAboutusCategory([AliasAs("category_id")] long categoryId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>returns description of site</summary>
        [Get("/aboutus")]
        Task<AboutusDescriptionModelV1> RetrieveAboutusDescription([Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>update a category</summary>
        [Patch("/aboutus/category/{category_id}")]
        Task<ApiResponseV1> UpdateAboutusCategory([AliasAs("category_id")] long categoryId, [Body] AboutusCategoryModelUpdateV1 aboutusCategoryModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update description of site</summary>
        [Post("/aboutus")]
        Task<ApiResponseV1> UpdateAboutusDescription([Body] AboutusDescriptionModelV1 aboutusDescriptionModelV1, CancellationToken cancellationToken = default);
    }
}