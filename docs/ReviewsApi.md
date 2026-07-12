# MangaUpdates.Api.ReviewsApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddReview**](ReviewsApi.md#addreview) | **POST** /reviews | add a review |
| [**AddReviewComment**](ReviewsApi.md#addreviewcomment) | **POST** /reviews/{id}/comments | add a review comment |
| [**DeleteReview**](ReviewsApi.md#deletereview) | **DELETE** /reviews/{id} | delete a review |
| [**DeleteReviewComment**](ReviewsApi.md#deletereviewcomment) | **DELETE** /reviews/{id}/comments/{comment_id} | delete a review comment |
| [**RetrieveReview**](ReviewsApi.md#retrievereview) | **GET** /reviews/{id} | get a specific review |
| [**RetrieveReviewComment**](ReviewsApi.md#retrievereviewcomment) | **GET** /reviews/{id}/comments/{comment_id} | get a specific review comment |
| [**ReviewCommentsModerationPost**](ReviewsApi.md#reviewcommentsmoderationpost) | **POST** /reviews/comments/moderation | moderate review comments |
| [**SearchReviewCommentsPost**](ReviewsApi.md#searchreviewcommentspost) | **POST** /reviews/{id}/comments/search | search review comments |
| [**SearchReviewsPost**](ReviewsApi.md#searchreviewspost) | **POST** /reviews/search | search reviews |
| [**UpdateReview**](ReviewsApi.md#updatereview) | **PATCH** /reviews/{id} | update a review |
| [**UpdateReviewComment**](ReviewsApi.md#updatereviewcomment) | **PATCH** /reviews/{id}/comments/{comment_id} | update a review comment |

<a id="addreview"></a>
# **AddReview**
> ApiResponseV1 AddReview (ReviewModelUpdateV1 reviewModelUpdateV1)

add a review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var reviewModelUpdateV1 = new ReviewModelUpdateV1(); // ReviewModelUpdateV1 | 

            try
            {
                // add a review
                ApiResponseV1 result = apiInstance.AddReview(reviewModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.AddReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a review
    ApiResponse<ApiResponseV1> response = apiInstance.AddReviewWithHttpInfo(reviewModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.AddReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reviewModelUpdateV1** | [**ReviewModelUpdateV1**](ReviewModelUpdateV1.md) |  |  |

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
| **200** | Review was added |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addreviewcomment"></a>
# **AddReviewComment**
> ApiResponseV1 AddReviewComment (long id, ReviewCommentModelUpdateV1 reviewCommentModelUpdateV1)

add a review comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddReviewCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 789L;  // long | Review id
            var reviewCommentModelUpdateV1 = new ReviewCommentModelUpdateV1(); // ReviewCommentModelUpdateV1 | 

            try
            {
                // add a review comment
                ApiResponseV1 result = apiInstance.AddReviewComment(id, reviewCommentModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.AddReviewComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddReviewCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a review comment
    ApiResponse<ApiResponseV1> response = apiInstance.AddReviewCommentWithHttpInfo(id, reviewCommentModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.AddReviewCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Review id |  |
| **reviewCommentModelUpdateV1** | [**ReviewCommentModelUpdateV1**](ReviewCommentModelUpdateV1.md) |  |  |

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
| **200** | Review comment was added |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereview"></a>
# **DeleteReview**
> ApiResponseV1 DeleteReview (long id)

delete a review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 56;  // long | id of review

            try
            {
                // delete a review
                ApiResponseV1 result = apiInstance.DeleteReview(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.DeleteReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a review
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteReviewWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.DeleteReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of review |  |

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
| **200** | Review was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Review not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereviewcomment"></a>
# **DeleteReviewComment**
> ApiResponseV1 DeleteReviewComment (long id, long commentId)

delete a review comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteReviewCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 56;  // long | id of review
            var commentId = 56;  // long | id of review comment

            try
            {
                // delete a review comment
                ApiResponseV1 result = apiInstance.DeleteReviewComment(id, commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.DeleteReviewComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReviewCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a review comment
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteReviewCommentWithHttpInfo(id, commentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.DeleteReviewCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of review |  |
| **commentId** | **long** | id of review comment |  |

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
| **200** | Review comment was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role or own the review comment |  -  |
| **404** | Review or comment not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievereview"></a>
# **RetrieveReview**
> ReviewModelV1 RetrieveReview (long id, bool? unrenderedFields = null)

get a specific review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 789L;  // long | Review id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific review
                ReviewModelV1 result = apiInstance.RetrieveReview(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.RetrieveReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific review
    ApiResponse<ReviewModelV1> response = apiInstance.RetrieveReviewWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.RetrieveReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Review id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ReviewModelV1**](ReviewModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Review not found |  -  |
| **200** | Return review record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievereviewcomment"></a>
# **RetrieveReviewComment**
> ReviewCommentModelV1 RetrieveReviewComment (long id, long commentId, bool? unrenderedFields = null)

get a specific review comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveReviewCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 789L;  // long | Review id
            var commentId = 789L;  // long | Review comment id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific review comment
                ReviewCommentModelV1 result = apiInstance.RetrieveReviewComment(id, commentId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.RetrieveReviewComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveReviewCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific review comment
    ApiResponse<ReviewCommentModelV1> response = apiInstance.RetrieveReviewCommentWithHttpInfo(id, commentId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.RetrieveReviewCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Review id |  |
| **commentId** | **long** | Review comment id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ReviewCommentModelV1**](ReviewCommentModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Review or comment not found |  -  |
| **200** | Return review comment record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reviewcommentsmoderationpost"></a>
# **ReviewCommentsModerationPost**
> ReviewCommentSearchResponseV1 ReviewCommentsModerationPost (ReviewCommentSearchRequestV1 reviewCommentSearchRequestV1)

moderate review comments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ReviewCommentsModerationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var reviewCommentSearchRequestV1 = new ReviewCommentSearchRequestV1(); // ReviewCommentSearchRequestV1 | 

            try
            {
                // moderate review comments
                ReviewCommentSearchResponseV1 result = apiInstance.ReviewCommentsModerationPost(reviewCommentSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.ReviewCommentsModerationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReviewCommentsModerationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // moderate review comments
    ApiResponse<ReviewCommentSearchResponseV1> response = apiInstance.ReviewCommentsModerationPostWithHttpInfo(reviewCommentSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.ReviewCommentsModerationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reviewCommentSearchRequestV1** | [**ReviewCommentSearchRequestV1**](ReviewCommentSearchRequestV1.md) |  |  |

### Return type

[**ReviewCommentSearchResponseV1**](ReviewCommentSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return reviews comment moderation records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchreviewcommentspost"></a>
# **SearchReviewCommentsPost**
> ReviewCommentSearchResponseV1 SearchReviewCommentsPost (long id, ReviewCommentSearchRequestV1 reviewCommentSearchRequestV1)

search review comments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchReviewCommentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 789L;  // long | Review id
            var reviewCommentSearchRequestV1 = new ReviewCommentSearchRequestV1(); // ReviewCommentSearchRequestV1 | 

            try
            {
                // search review comments
                ReviewCommentSearchResponseV1 result = apiInstance.SearchReviewCommentsPost(id, reviewCommentSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.SearchReviewCommentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchReviewCommentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search review comments
    ApiResponse<ReviewCommentSearchResponseV1> response = apiInstance.SearchReviewCommentsPostWithHttpInfo(id, reviewCommentSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.SearchReviewCommentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Review id |  |
| **reviewCommentSearchRequestV1** | [**ReviewCommentSearchRequestV1**](ReviewCommentSearchRequestV1.md) |  |  |

### Return type

[**ReviewCommentSearchResponseV1**](ReviewCommentSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return review comment records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchreviewspost"></a>
# **SearchReviewsPost**
> ReviewSearchResponseV1 SearchReviewsPost (ReviewSearchRequestV1 reviewSearchRequestV1)

search reviews

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchReviewsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var reviewSearchRequestV1 = new ReviewSearchRequestV1(); // ReviewSearchRequestV1 | 

            try
            {
                // search reviews
                ReviewSearchResponseV1 result = apiInstance.SearchReviewsPost(reviewSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.SearchReviewsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchReviewsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search reviews
    ApiResponse<ReviewSearchResponseV1> response = apiInstance.SearchReviewsPostWithHttpInfo(reviewSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.SearchReviewsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reviewSearchRequestV1** | [**ReviewSearchRequestV1**](ReviewSearchRequestV1.md) |  |  |

### Return type

[**ReviewSearchResponseV1**](ReviewSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return review records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatereview"></a>
# **UpdateReview**
> ApiResponseV1 UpdateReview (long id, ReviewModelUpdateV1 reviewModelUpdateV1)

update a review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 56;  // long | id of review
            var reviewModelUpdateV1 = new ReviewModelUpdateV1(); // ReviewModelUpdateV1 | 

            try
            {
                // update a review
                ApiResponseV1 result = apiInstance.UpdateReview(id, reviewModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.UpdateReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a review
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateReviewWithHttpInfo(id, reviewModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.UpdateReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of review |  |
| **reviewModelUpdateV1** | [**ReviewModelUpdateV1**](ReviewModelUpdateV1.md) |  |  |

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
| **200** | Review was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role or own the review |  -  |
| **404** | Review not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatereviewcomment"></a>
# **UpdateReviewComment**
> ApiResponseV1 UpdateReviewComment (long id, long commentId, ReviewCommentModelUpdateV1 reviewCommentModelUpdateV1)

update a review comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateReviewCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ReviewsApi(config);
            var id = 56;  // long | id of review
            var commentId = 56;  // long | id of review comment
            var reviewCommentModelUpdateV1 = new ReviewCommentModelUpdateV1(); // ReviewCommentModelUpdateV1 | 

            try
            {
                // update a review comment
                ApiResponseV1 result = apiInstance.UpdateReviewComment(id, commentId, reviewCommentModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReviewsApi.UpdateReviewComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReviewCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a review comment
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateReviewCommentWithHttpInfo(id, commentId, reviewCommentModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReviewsApi.UpdateReviewCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of review |  |
| **commentId** | **long** | id of review comment |  |
| **reviewCommentModelUpdateV1** | [**ReviewCommentModelUpdateV1**](ReviewCommentModelUpdateV1.md) |  |  |

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
| **200** | Review comment was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role or own the review comment |  -  |
| **404** | Review or comment not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

