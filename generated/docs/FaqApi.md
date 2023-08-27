# MangaUpdates.Api.FaqApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFaqCategory**](FaqApi.md#addfaqcategory) | **POST** /faq | add a faq category |
| [**AddFaqQuestion**](FaqApi.md#addfaqquestion) | **POST** /faq/{category_id}/questions | add a faq question |
| [**DeleteFaqCategory**](FaqApi.md#deletefaqcategory) | **DELETE** /faq/{category_id} | delete a faq category |
| [**DeleteFaqQuestion**](FaqApi.md#deletefaqquestion) | **DELETE** /faq/{category_id}/questions/{question_id} | delete an faq |
| [**ReorderFaq**](FaqApi.md#reorderfaq) | **POST** /faq/reorder | reorder faq |
| [**RetrieveAllFaqCategoriesAndQuestions**](FaqApi.md#retrieveallfaqcategoriesandquestions) | **GET** /faq | retrieve all categories and questions |
| [**RetrieveAllFaqCategoryQuestions**](FaqApi.md#retrieveallfaqcategoryquestions) | **GET** /faq/{category_id}/questions | retrieve all quesitons for a category |
| [**RetrieveFaqCategory**](FaqApi.md#retrievefaqcategory) | **GET** /faq/{category_id} | get a specific category |
| [**RetrieveFaqQuestion**](FaqApi.md#retrievefaqquestion) | **GET** /faq/{category_id}/questions/{question_id} | get a specific question for a category |
| [**UpdateFaqCategory**](FaqApi.md#updatefaqcategory) | **PATCH** /faq/{category_id} | update a faq category |
| [**UpdateFaqQuestion**](FaqApi.md#updatefaqquestion) | **PATCH** /faq/{category_id}/questions/{question_id} | update a faq question |

<a id="addfaqcategory"></a>
# **AddFaqCategory**
> ApiResponseV1 AddFaqCategory (FaqCategoryModelUpdateV1 faqCategoryModelUpdateV1)

add a faq category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddFaqCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var faqCategoryModelUpdateV1 = new FaqCategoryModelUpdateV1(); // FaqCategoryModelUpdateV1 | 

            try
            {
                // add a faq category
                ApiResponseV1 result = apiInstance.AddFaqCategory(faqCategoryModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.AddFaqCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFaqCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a faq category
    ApiResponse<ApiResponseV1> response = apiInstance.AddFaqCategoryWithHttpInfo(faqCategoryModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.AddFaqCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **faqCategoryModelUpdateV1** | [**FaqCategoryModelUpdateV1**](FaqCategoryModelUpdateV1.md) |  |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq category was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addfaqquestion"></a>
# **AddFaqQuestion**
> ApiResponseV1 AddFaqQuestion (long categoryId, FaqQuestionModelUpdateV1 faqQuestionModelUpdateV1)

add a faq question

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddFaqQuestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | id of category to add question to
            var faqQuestionModelUpdateV1 = new FaqQuestionModelUpdateV1(); // FaqQuestionModelUpdateV1 | 

            try
            {
                // add a faq question
                ApiResponseV1 result = apiInstance.AddFaqQuestion(categoryId, faqQuestionModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.AddFaqQuestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFaqQuestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a faq question
    ApiResponse<ApiResponseV1> response = apiInstance.AddFaqQuestionWithHttpInfo(categoryId, faqQuestionModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.AddFaqQuestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | id of category to add question to |  |
| **faqQuestionModelUpdateV1** | [**FaqQuestionModelUpdateV1**](FaqQuestionModelUpdateV1.md) |  |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq question was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefaqcategory"></a>
# **DeleteFaqCategory**
> ApiResponseV1 DeleteFaqCategory (long categoryId)

delete a faq category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteFaqCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | id of faq category

            try
            {
                // delete a faq category
                ApiResponseV1 result = apiInstance.DeleteFaqCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.DeleteFaqCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFaqCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a faq category
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteFaqCategoryWithHttpInfo(categoryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.DeleteFaqCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | id of faq category |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq Category was deleted |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Faq Category not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefaqquestion"></a>
# **DeleteFaqQuestion**
> ApiResponseV1 DeleteFaqQuestion (long categoryId, long questionId)

delete an faq

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteFaqQuestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | Faq category id
            var questionId = 56;  // long | Faq question id

            try
            {
                // delete an faq
                ApiResponseV1 result = apiInstance.DeleteFaqQuestion(categoryId, questionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.DeleteFaqQuestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFaqQuestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete an faq
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteFaqQuestionWithHttpInfo(categoryId, questionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.DeleteFaqQuestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Faq category id |  |
| **questionId** | **long** | Faq question id |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq question was deleted |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Faq category or question not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reorderfaq"></a>
# **ReorderFaq**
> ApiResponseV1 ReorderFaq (List<FaqCategoryReorderModelV1> faqCategoryReorderModelV1)

reorder faq

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ReorderFaqExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var faqCategoryReorderModelV1 = new List<FaqCategoryReorderModelV1>(); // List<FaqCategoryReorderModelV1> | 

            try
            {
                // reorder faq
                ApiResponseV1 result = apiInstance.ReorderFaq(faqCategoryReorderModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.ReorderFaq: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReorderFaqWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // reorder faq
    ApiResponse<ApiResponseV1> response = apiInstance.ReorderFaqWithHttpInfo(faqCategoryReorderModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.ReorderFaqWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **faqCategoryReorderModelV1** | [**List&lt;FaqCategoryReorderModelV1&gt;**](FaqCategoryReorderModelV1.md) |  |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq was reordered |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveallfaqcategoriesandquestions"></a>
# **RetrieveAllFaqCategoriesAndQuestions**
> List&lt;FaqCategoryQuestionsModelV1&gt; RetrieveAllFaqCategoriesAndQuestions ()

retrieve all categories and questions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveAllFaqCategoriesAndQuestionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);

            try
            {
                // retrieve all categories and questions
                List<FaqCategoryQuestionsModelV1> result = apiInstance.RetrieveAllFaqCategoriesAndQuestions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.RetrieveAllFaqCategoriesAndQuestions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveAllFaqCategoriesAndQuestionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve all categories and questions
    ApiResponse<List<FaqCategoryQuestionsModelV1>> response = apiInstance.RetrieveAllFaqCategoriesAndQuestionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.RetrieveAllFaqCategoriesAndQuestionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FaqCategoryQuestionsModelV1&gt;**](FaqCategoryQuestionsModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return category and question records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveallfaqcategoryquestions"></a>
# **RetrieveAllFaqCategoryQuestions**
> List&lt;FaqQuestionModelV1&gt; RetrieveAllFaqCategoryQuestions (long categoryId)

retrieve all quesitons for a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveAllFaqCategoryQuestionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | Faq category id

            try
            {
                // retrieve all quesitons for a category
                List<FaqQuestionModelV1> result = apiInstance.RetrieveAllFaqCategoryQuestions(categoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.RetrieveAllFaqCategoryQuestions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveAllFaqCategoryQuestionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve all quesitons for a category
    ApiResponse<List<FaqQuestionModelV1>> response = apiInstance.RetrieveAllFaqCategoryQuestionsWithHttpInfo(categoryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.RetrieveAllFaqCategoryQuestionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Faq category id |  |

### Return type

[**List&lt;FaqQuestionModelV1&gt;**](FaqQuestionModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Category not found |  -  |
| **200** | Return question records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievefaqcategory"></a>
# **RetrieveFaqCategory**
> FaqCategoryModelV1 RetrieveFaqCategory (long categoryId, bool? unrenderedFields = null)

get a specific category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveFaqCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | Faq category id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific category
                FaqCategoryModelV1 result = apiInstance.RetrieveFaqCategory(categoryId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.RetrieveFaqCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveFaqCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific category
    ApiResponse<FaqCategoryModelV1> response = apiInstance.RetrieveFaqCategoryWithHttpInfo(categoryId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.RetrieveFaqCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Faq category id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**FaqCategoryModelV1**](FaqCategoryModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Category not found |  -  |
| **200** | Return category record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievefaqquestion"></a>
# **RetrieveFaqQuestion**
> FaqQuestionModelV1 RetrieveFaqQuestion (long categoryId, long questionId, bool? unrenderedFields = null)

get a specific question for a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveFaqQuestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | Faq category id
            var questionId = 56;  // long | Faq question id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific question for a category
                FaqQuestionModelV1 result = apiInstance.RetrieveFaqQuestion(categoryId, questionId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.RetrieveFaqQuestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveFaqQuestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific question for a category
    ApiResponse<FaqQuestionModelV1> response = apiInstance.RetrieveFaqQuestionWithHttpInfo(categoryId, questionId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.RetrieveFaqQuestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Faq category id |  |
| **questionId** | **long** | Faq question id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**FaqQuestionModelV1**](FaqQuestionModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Category or question not found |  -  |
| **200** | Return question record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefaqcategory"></a>
# **UpdateFaqCategory**
> ApiResponseV1 UpdateFaqCategory (long categoryId, FaqCategoryModelUpdateV1 faqCategoryModelUpdateV1)

update a faq category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateFaqCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | id of faq category
            var faqCategoryModelUpdateV1 = new FaqCategoryModelUpdateV1(); // FaqCategoryModelUpdateV1 | 

            try
            {
                // update a faq category
                ApiResponseV1 result = apiInstance.UpdateFaqCategory(categoryId, faqCategoryModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.UpdateFaqCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFaqCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a faq category
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateFaqCategoryWithHttpInfo(categoryId, faqCategoryModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.UpdateFaqCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | id of faq category |  |
| **faqCategoryModelUpdateV1** | [**FaqCategoryModelUpdateV1**](FaqCategoryModelUpdateV1.md) |  |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefaqquestion"></a>
# **UpdateFaqQuestion**
> ApiResponseV1 UpdateFaqQuestion (long categoryId, long questionId, FaqQuestionModelUpdateV1 faqQuestionModelUpdateV1)

update a faq question

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateFaqQuestionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FaqApi(config);
            var categoryId = 56;  // long | Faq category id
            var questionId = 56;  // long | Faq question id
            var faqQuestionModelUpdateV1 = new FaqQuestionModelUpdateV1(); // FaqQuestionModelUpdateV1 | 

            try
            {
                // update a faq question
                ApiResponseV1 result = apiInstance.UpdateFaqQuestion(categoryId, questionId, faqQuestionModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FaqApi.UpdateFaqQuestion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFaqQuestionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a faq question
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateFaqQuestionWithHttpInfo(categoryId, questionId, faqQuestionModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FaqApi.UpdateFaqQuestionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Faq category id |  |
| **questionId** | **long** | Faq question id |  |
| **faqQuestionModelUpdateV1** | [**FaqQuestionModelUpdateV1**](FaqQuestionModelUpdateV1.md) |  |  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Faq was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

