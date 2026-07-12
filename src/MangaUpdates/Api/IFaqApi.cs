using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Faq endpoints of the MangaUpdates API.
    /// </summary>
    public interface IFaqApi
    {
        /// <summary>add a faq category</summary>
        [Post("/faq")]
        Task<ApiResponseV1> AddFaqCategory([Body] FaqCategoryModelUpdateV1 faqCategoryModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>add a faq question</summary>
        [Post("/faq/{category_id}/questions")]
        Task<ApiResponseV1> AddFaqQuestion([AliasAs("category_id")] long categoryId, [Body] FaqQuestionModelUpdateV1 faqQuestionModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>delete a faq category</summary>
        [Delete("/faq/{category_id}")]
        Task<ApiResponseV1> DeleteFaqCategory([AliasAs("category_id")] long categoryId, CancellationToken cancellationToken = default);

        /// <summary>delete an faq</summary>
        [Delete("/faq/{category_id}/questions/{question_id}")]
        Task<ApiResponseV1> DeleteFaqQuestion([AliasAs("category_id")] long categoryId, [AliasAs("question_id")] long questionId, CancellationToken cancellationToken = default);

        /// <summary>reorder faq</summary>
        [Post("/faq/reorder")]
        Task<ApiResponseV1> ReorderFaq([Body] List<FaqCategoryReorderModelV1> faqCategoryReorderModelV1, CancellationToken cancellationToken = default);

        /// <summary>retrieve all categories and questions</summary>
        [Get("/faq")]
        Task<List<FaqCategoryQuestionsModelV1>> RetrieveAllFaqCategoriesAndQuestions(CancellationToken cancellationToken = default);

        /// <summary>retrieve all quesitons for a category</summary>
        [Get("/faq/{category_id}/questions")]
        Task<List<FaqQuestionModelV1>> RetrieveAllFaqCategoryQuestions([AliasAs("category_id")] long categoryId, CancellationToken cancellationToken = default);

        /// <summary>get a specific category</summary>
        [Get("/faq/{category_id}")]
        Task<FaqCategoryModelV1> RetrieveFaqCategory([AliasAs("category_id")] long categoryId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>get a specific question for a category</summary>
        [Get("/faq/{category_id}/questions/{question_id}")]
        Task<FaqQuestionModelV1> RetrieveFaqQuestion([AliasAs("category_id")] long categoryId, [AliasAs("question_id")] long questionId, [Query] bool? unrenderedFields = default, CancellationToken cancellationToken = default);

        /// <summary>update a faq category</summary>
        [Patch("/faq/{category_id}")]
        Task<ApiResponseV1> UpdateFaqCategory([AliasAs("category_id")] long categoryId, [Body] FaqCategoryModelUpdateV1 faqCategoryModelUpdateV1, CancellationToken cancellationToken = default);

        /// <summary>update a faq question</summary>
        [Patch("/faq/{category_id}/questions/{question_id}")]
        Task<ApiResponseV1> UpdateFaqQuestion([AliasAs("category_id")] long categoryId, [AliasAs("question_id")] long questionId, [Body] FaqQuestionModelUpdateV1 faqQuestionModelUpdateV1, CancellationToken cancellationToken = default);
    }
}