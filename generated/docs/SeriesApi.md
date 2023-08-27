# MangaUpdates.Api.SeriesApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddSeries**](SeriesApi.md#addseries) | **POST** /series | add an series |
| [**AddSeriesCategoryVote**](SeriesApi.md#addseriescategoryvote) | **POST** /series/{id}/categories/vote | add a vote for a category on a series |
| [**AddSeriesComment**](SeriesApi.md#addseriescomment) | **POST** /series/{id}/comments | add a series comment |
| [**AddSeriesCommentUsefulFlag**](SeriesApi.md#addseriescommentusefulflag) | **PUT** /series/{id}/comments/{comment_id}/useful | set usefulness of a series comment |
| [**CombineSeriesCategories**](SeriesApi.md#combineseriescategories) | **POST** /series/{id}/categories/combine | combine two series categories |
| [**DeleteSeries**](SeriesApi.md#deleteseries) | **DELETE** /series/{id} | delete a series |
| [**DeleteSeriesCategory**](SeriesApi.md#deleteseriescategory) | **POST** /series/{id}/categories/delete | deletes a series category |
| [**DeleteSeriesComment**](SeriesApi.md#deleteseriescomment) | **DELETE** /series/{id}/comments/{comment_id} | delete a series comment |
| [**DeleteSeriesImage**](SeriesApi.md#deleteseriesimage) | **DELETE** /series/{id}/image | delete the image of an series |
| [**DeleteUserSeriesRating**](SeriesApi.md#deleteuserseriesrating) | **DELETE** /series/{id}/rating | delete a series rating for a user |
| [**LockSeriesField**](SeriesApi.md#lockseriesfield) | **POST** /series/{id}/locks/{item}/lock | lock a field of an series |
| [**RemoveSeriesCategoryVote**](SeriesApi.md#removeseriescategoryvote) | **POST** /series/{id}/categories/vote/delete | remove series category vote for user |
| [**RemoveSeriesCommentUsefulFlag**](SeriesApi.md#removeseriescommentusefulflag) | **DELETE** /series/{id}/comments/{comment_id}/useful | remove usefulness of a series comment |
| [**RenameSeriesCategory**](SeriesApi.md#renameseriescategory) | **POST** /series/{id}/categories/rename | renames a series category |
| [**ReportSeriesComment**](SeriesApi.md#reportseriescomment) | **POST** /series/{id}/comments/{comment_id}/report | report a series comment |
| [**RetrieveMySeriesComment**](SeriesApi.md#retrievemyseriescomment) | **GET** /series/{id}/comments/my_comment | get my series comment |
| [**RetrieveSeries**](SeriesApi.md#retrieveseries) | **GET** /series/{id} | get a specific series |
| [**RetrieveSeriesCategoryVotes**](SeriesApi.md#retrieveseriescategoryvotes) | **GET** /series/{id}/categories/votes | get category votes for the current user |
| [**RetrieveSeriesComment**](SeriesApi.md#retrieveseriescomment) | **GET** /series/{id}/comments/{comment_id} | get a specific series comment |
| [**RetrieveSeriesCommentLocation**](SeriesApi.md#retrieveseriescommentlocation) | **GET** /series/{id}/comments/{comment_id}/location | get a specific series comment location |
| [**RetrieveSeriesGroups**](SeriesApi.md#retrieveseriesgroups) | **GET** /series/{id}/groups | get the list of groups scanlating a specific series |
| [**RetrieveSeriesLocks**](SeriesApi.md#retrieveserieslocks) | **GET** /series/{id}/locks | get a specific series lock |
| [**RetrieveSeriesRankLocation**](SeriesApi.md#retrieveseriesranklocation) | **GET** /series/{id}/rank/{type} | get a specific series rank location |
| [**RetrieveSeriesRatingRainbow**](SeriesApi.md#retrieveseriesratingrainbow) | **GET** /series/{id}/ratingrainbow | get a the series rating rainbow |
| [**RetrieveUserSeriesRating**](SeriesApi.md#retrieveuserseriesrating) | **GET** /series/{id}/rating | get a specific series rating for a user |
| [**SearchSeriesCommentsPost**](SeriesApi.md#searchseriescommentspost) | **POST** /series/{id}/comments/search | search series comments |
| [**SearchSeriesHistoryPost**](SeriesApi.md#searchserieshistorypost) | **POST** /series/{id}/history | search series history |
| [**SearchSeriesPost**](SeriesApi.md#searchseriespost) | **POST** /series/search | search series |
| [**SeriesCommentsModerationPost**](SeriesApi.md#seriescommentsmoderationpost) | **POST** /series/comments/moderation | moderate series comments |
| [**SeriesReleaseRssFeed**](SeriesApi.md#seriesreleaserssfeed) | **GET** /series/{id}/rss | releases rss feed for a specific series |
| [**UnlockSeriesField**](SeriesApi.md#unlockseriesfield) | **POST** /series/{id}/locks/{item}/unlock | unlock a field of an series |
| [**UpdateSeries**](SeriesApi.md#updateseries) | **PATCH** /series/{id} | update an series |
| [**UpdateSeriesComment**](SeriesApi.md#updateseriescomment) | **PATCH** /series/{id}/comments/{comment_id} | update a series comment |
| [**UpdateSeriesImage**](SeriesApi.md#updateseriesimage) | **POST** /series/{id}/image | update the image of an series |
| [**UpdateUserSeriesRating**](SeriesApi.md#updateuserseriesrating) | **PUT** /series/{id}/rating | update the user rating for a series |

<a id="addseries"></a>
# **AddSeries**
> ApiResponseV1 AddSeries (SeriesModelUpdateV1 seriesModelUpdateV1)

add an series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var seriesModelUpdateV1 = new SeriesModelUpdateV1(); // SeriesModelUpdateV1 | 

            try
            {
                // add an series
                ApiResponseV1 result = apiInstance.AddSeries(seriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.AddSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add an series
    ApiResponse<ApiResponseV1> response = apiInstance.AddSeriesWithHttpInfo(seriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.AddSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seriesModelUpdateV1** | [**SeriesModelUpdateV1**](SeriesModelUpdateV1.md) |  |  |

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
| **200** | Series was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addseriescategoryvote"></a>
# **AddSeriesCategoryVote**
> ApiResponseV1 AddSeriesCategoryVote (long id, SeriesCategoryVoteModelV1 seriesCategoryVoteModelV1)

add a vote for a category on a series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddSeriesCategoryVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var seriesCategoryVoteModelV1 = new SeriesCategoryVoteModelV1(); // SeriesCategoryVoteModelV1 | 

            try
            {
                // add a vote for a category on a series
                ApiResponseV1 result = apiInstance.AddSeriesCategoryVote(id, seriesCategoryVoteModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.AddSeriesCategoryVote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSeriesCategoryVoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a vote for a category on a series
    ApiResponse<ApiResponseV1> response = apiInstance.AddSeriesCategoryVoteWithHttpInfo(id, seriesCategoryVoteModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.AddSeriesCategoryVoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesCategoryVoteModelV1** | [**SeriesCategoryVoteModelV1**](SeriesCategoryVoteModelV1.md) |  |  |

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
| **200** | Series category vote was added |  -  |
| **400** | Validation or service error |  -  |
| **404** | Series not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addseriescomment"></a>
# **AddSeriesComment**
> ApiResponseV1 AddSeriesComment (long id, SeriesCommentModelUpdateV1 seriesCommentModelUpdateV1)

add a series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddSeriesCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var seriesCommentModelUpdateV1 = new SeriesCommentModelUpdateV1(); // SeriesCommentModelUpdateV1 | 

            try
            {
                // add a series comment
                ApiResponseV1 result = apiInstance.AddSeriesComment(id, seriesCommentModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.AddSeriesComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSeriesCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a series comment
    ApiResponse<ApiResponseV1> response = apiInstance.AddSeriesCommentWithHttpInfo(id, seriesCommentModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.AddSeriesCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesCommentModelUpdateV1** | [**SeriesCommentModelUpdateV1**](SeriesCommentModelUpdateV1.md) |  |  |

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
| **200** | Series comment was added |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addseriescommentusefulflag"></a>
# **AddSeriesCommentUsefulFlag**
> ApiResponseV1 AddSeriesCommentUsefulFlag (long id, long commentId, SeriesCommentUsefulModelV1 seriesCommentUsefulModelV1)

set usefulness of a series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddSeriesCommentUsefulFlagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var commentId = 56;  // long | id of series comment
            var seriesCommentUsefulModelV1 = new SeriesCommentUsefulModelV1(); // SeriesCommentUsefulModelV1 | 

            try
            {
                // set usefulness of a series comment
                ApiResponseV1 result = apiInstance.AddSeriesCommentUsefulFlag(id, commentId, seriesCommentUsefulModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.AddSeriesCommentUsefulFlag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSeriesCommentUsefulFlagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // set usefulness of a series comment
    ApiResponse<ApiResponseV1> response = apiInstance.AddSeriesCommentUsefulFlagWithHttpInfo(id, commentId, seriesCommentUsefulModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.AddSeriesCommentUsefulFlagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **commentId** | **long** | id of series comment |  |
| **seriesCommentUsefulModelV1** | [**SeriesCommentUsefulModelV1**](SeriesCommentUsefulModelV1.md) |  |  |

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
| **200** | Series comment useful was added |  -  |
| **400** | Validation or service error |  -  |
| **404** | Series or comment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="combineseriescategories"></a>
# **CombineSeriesCategories**
> ApiResponseV1 CombineSeriesCategories (long id, SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1)

combine two series categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class CombineSeriesCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var seriesCategoryUpdateModelV1 = new SeriesCategoryUpdateModelV1(); // SeriesCategoryUpdateModelV1 | 

            try
            {
                // combine two series categories
                ApiResponseV1 result = apiInstance.CombineSeriesCategories(id, seriesCategoryUpdateModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.CombineSeriesCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CombineSeriesCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // combine two series categories
    ApiResponse<ApiResponseV1> response = apiInstance.CombineSeriesCategoriesWithHttpInfo(id, seriesCategoryUpdateModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.CombineSeriesCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesCategoryUpdateModelV1** | [**SeriesCategoryUpdateModelV1**](SeriesCategoryUpdateModelV1.md) |  |  |

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
| **200** | Series categories were combined |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series or category not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteseries"></a>
# **DeleteSeries**
> ApiResponseV1 DeleteSeries (long id)

delete a series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series

            try
            {
                // delete a series
                ApiResponseV1 result = apiInstance.DeleteSeries(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.DeleteSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a series
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteSeriesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.DeleteSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |

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
| **200** | Series was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteseriescategory"></a>
# **DeleteSeriesCategory**
> ApiResponseV1 DeleteSeriesCategory (long id, CategoriesModelUpdateV1 categoriesModelUpdateV1)

deletes a series category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteSeriesCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var categoriesModelUpdateV1 = new CategoriesModelUpdateV1(); // CategoriesModelUpdateV1 | 

            try
            {
                // deletes a series category
                ApiResponseV1 result = apiInstance.DeleteSeriesCategory(id, categoriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.DeleteSeriesCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSeriesCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // deletes a series category
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteSeriesCategoryWithHttpInfo(id, categoriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.DeleteSeriesCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **categoriesModelUpdateV1** | [**CategoriesModelUpdateV1**](CategoriesModelUpdateV1.md) |  |  |

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
| **200** | Series category was removed |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series or category not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteseriescomment"></a>
# **DeleteSeriesComment**
> ApiResponseV1 DeleteSeriesComment (long id, long commentId)

delete a series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteSeriesCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var commentId = 56;  // long | id of series comment

            try
            {
                // delete a series comment
                ApiResponseV1 result = apiInstance.DeleteSeriesComment(id, commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.DeleteSeriesComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSeriesCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a series comment
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteSeriesCommentWithHttpInfo(id, commentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.DeleteSeriesCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **commentId** | **long** | id of series comment |  |

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
| **200** | Series comment was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role or own the series comment |  -  |
| **404** | Series or comment not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteseriesimage"></a>
# **DeleteSeriesImage**
> ApiResponseV1 DeleteSeriesImage (long id)

delete the image of an series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteSeriesImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | id of series

            try
            {
                // delete the image of an series
                ApiResponseV1 result = apiInstance.DeleteSeriesImage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.DeleteSeriesImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSeriesImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete the image of an series
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteSeriesImageWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.DeleteSeriesImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |

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
| **200** | Image was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuserseriesrating"></a>
# **DeleteUserSeriesRating**
> ApiResponseV1 DeleteUserSeriesRating (long id)

delete a series rating for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteUserSeriesRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series

            try
            {
                // delete a series rating for a user
                ApiResponseV1 result = apiInstance.DeleteUserSeriesRating(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.DeleteUserSeriesRating: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserSeriesRatingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a series rating for a user
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteUserSeriesRatingWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.DeleteUserSeriesRatingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |

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
| **200** | Series rating was deleted |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lockseriesfield"></a>
# **LockSeriesField**
> ApiResponseV1 LockSeriesField (long id, string item, SeriesLockModelUpdateV1 seriesLockModelUpdateV1)

lock a field of an series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class LockSeriesFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | id of series
            var item = "item_example";  // string | field name
            var seriesLockModelUpdateV1 = new SeriesLockModelUpdateV1(); // SeriesLockModelUpdateV1 | 

            try
            {
                // lock a field of an series
                ApiResponseV1 result = apiInstance.LockSeriesField(id, item, seriesLockModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.LockSeriesField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LockSeriesFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // lock a field of an series
    ApiResponse<ApiResponseV1> response = apiInstance.LockSeriesFieldWithHttpInfo(id, item, seriesLockModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.LockSeriesFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **item** | **string** | field name |  |
| **seriesLockModelUpdateV1** | [**SeriesLockModelUpdateV1**](SeriesLockModelUpdateV1.md) |  |  |

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
| **200** | Field was locked |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series not found |  -  |
| **409** | Field is already locked |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeseriescategoryvote"></a>
# **RemoveSeriesCategoryVote**
> ApiResponseV1 RemoveSeriesCategoryVote (long id, SeriesCategoryVoteDeleteModelV1 seriesCategoryVoteDeleteModelV1)

remove series category vote for user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveSeriesCategoryVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var seriesCategoryVoteDeleteModelV1 = new SeriesCategoryVoteDeleteModelV1(); // SeriesCategoryVoteDeleteModelV1 | 

            try
            {
                // remove series category vote for user
                ApiResponseV1 result = apiInstance.RemoveSeriesCategoryVote(id, seriesCategoryVoteDeleteModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RemoveSeriesCategoryVote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSeriesCategoryVoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove series category vote for user
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveSeriesCategoryVoteWithHttpInfo(id, seriesCategoryVoteDeleteModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RemoveSeriesCategoryVoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesCategoryVoteDeleteModelV1** | [**SeriesCategoryVoteDeleteModelV1**](SeriesCategoryVoteDeleteModelV1.md) |  |  |

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
| **200** | Series category vote was removed |  -  |
| **400** | Validation or service error |  -  |
| **404** | Series or comment not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeseriescommentusefulflag"></a>
# **RemoveSeriesCommentUsefulFlag**
> ApiResponseV1 RemoveSeriesCommentUsefulFlag (long id, long commentId)

remove usefulness of a series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveSeriesCommentUsefulFlagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var commentId = 56;  // long | id of series comment

            try
            {
                // remove usefulness of a series comment
                ApiResponseV1 result = apiInstance.RemoveSeriesCommentUsefulFlag(id, commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RemoveSeriesCommentUsefulFlag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSeriesCommentUsefulFlagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove usefulness of a series comment
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveSeriesCommentUsefulFlagWithHttpInfo(id, commentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RemoveSeriesCommentUsefulFlagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **commentId** | **long** | id of series comment |  |

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
| **200** | Series comment useful was deleted |  -  |
| **400** | Validation or service error |  -  |
| **404** | Series or comment not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="renameseriescategory"></a>
# **RenameSeriesCategory**
> ApiResponseV1 RenameSeriesCategory (long id, SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1)

renames a series category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RenameSeriesCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var seriesCategoryUpdateModelV1 = new SeriesCategoryUpdateModelV1(); // SeriesCategoryUpdateModelV1 | 

            try
            {
                // renames a series category
                ApiResponseV1 result = apiInstance.RenameSeriesCategory(id, seriesCategoryUpdateModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RenameSeriesCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameSeriesCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // renames a series category
    ApiResponse<ApiResponseV1> response = apiInstance.RenameSeriesCategoryWithHttpInfo(id, seriesCategoryUpdateModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RenameSeriesCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesCategoryUpdateModelV1** | [**SeriesCategoryUpdateModelV1**](SeriesCategoryUpdateModelV1.md) |  |  |

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
| **200** | Series category was renamed |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series or category not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportseriescomment"></a>
# **ReportSeriesComment**
> ApiResponseV1 ReportSeriesComment (long id, long commentId, SeriesCommentReportModelV1 seriesCommentReportModelV1)

report a series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ReportSeriesCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var commentId = 56;  // long | id of series comment
            var seriesCommentReportModelV1 = new SeriesCommentReportModelV1(); // SeriesCommentReportModelV1 | 

            try
            {
                // report a series comment
                ApiResponseV1 result = apiInstance.ReportSeriesComment(id, commentId, seriesCommentReportModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.ReportSeriesComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportSeriesCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // report a series comment
    ApiResponse<ApiResponseV1> response = apiInstance.ReportSeriesCommentWithHttpInfo(id, commentId, seriesCommentReportModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.ReportSeriesCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **commentId** | **long** | id of series comment |  |
| **seriesCommentReportModelV1** | [**SeriesCommentReportModelV1**](SeriesCommentReportModelV1.md) |  |  |

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
| **200** | Series comment was reported |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series or comment not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemyseriescomment"></a>
# **RetrieveMySeriesComment**
> SeriesCommentModelV1 RetrieveMySeriesComment (long id, bool? unrenderedFields = null)

get my series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMySeriesCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get my series comment
                SeriesCommentModelV1 result = apiInstance.RetrieveMySeriesComment(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveMySeriesComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMySeriesCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get my series comment
    ApiResponse<SeriesCommentModelV1> response = apiInstance.RetrieveMySeriesCommentWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveMySeriesCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**SeriesCommentModelV1**](SeriesCommentModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series or comment not found |  -  |
| **200** | Return series comment record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseries"></a>
# **RetrieveSeries**
> SeriesModelV1 RetrieveSeries (long id, bool? unrenderedFields = null)

get a specific series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | Series id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific series
                SeriesModelV1 result = apiInstance.RetrieveSeries(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific series
    ApiResponse<SeriesModelV1> response = apiInstance.RetrieveSeriesWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**SeriesModelV1**](SeriesModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series not found |  -  |
| **200** | Return series record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseriescategoryvotes"></a>
# **RetrieveSeriesCategoryVotes**
> List&lt;SeriesCategoryVoteModelV1&gt; RetrieveSeriesCategoryVotes (long id)

get category votes for the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesCategoryVotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id

            try
            {
                // get category votes for the current user
                List<SeriesCategoryVoteModelV1> result = apiInstance.RetrieveSeriesCategoryVotes(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesCategoryVotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesCategoryVotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get category votes for the current user
    ApiResponse<List<SeriesCategoryVoteModelV1>> response = apiInstance.RetrieveSeriesCategoryVotesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesCategoryVotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |

### Return type

[**List&lt;SeriesCategoryVoteModelV1&gt;**](SeriesCategoryVoteModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return vote records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseriescomment"></a>
# **RetrieveSeriesComment**
> SeriesCommentModelV1 RetrieveSeriesComment (long id, long commentId, bool? unrenderedFields = null)

get a specific series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id
            var commentId = 789L;  // long | Series comment id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific series comment
                SeriesCommentModelV1 result = apiInstance.RetrieveSeriesComment(id, commentId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific series comment
    ApiResponse<SeriesCommentModelV1> response = apiInstance.RetrieveSeriesCommentWithHttpInfo(id, commentId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **commentId** | **long** | Series comment id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**SeriesCommentModelV1**](SeriesCommentModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series or comment not found |  -  |
| **200** | Return series comment record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseriescommentlocation"></a>
# **RetrieveSeriesCommentLocation**
> ApiResponseV1 RetrieveSeriesCommentLocation (long id, long commentId)

get a specific series comment location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesCommentLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id
            var commentId = 789L;  // long | Series comment id

            try
            {
                // get a specific series comment location
                ApiResponseV1 result = apiInstance.RetrieveSeriesCommentLocation(id, commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesCommentLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesCommentLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific series comment location
    ApiResponse<ApiResponseV1> response = apiInstance.RetrieveSeriesCommentLocationWithHttpInfo(id, commentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesCommentLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **commentId** | **long** | Series comment id |  |

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
| **200** | Return series comment location |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseriesgroups"></a>
# **RetrieveSeriesGroups**
> SeriesGroupListResponseV1 RetrieveSeriesGroups (long id)

get the list of groups scanlating a specific series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id

            try
            {
                // get the list of groups scanlating a specific series
                SeriesGroupListResponseV1 result = apiInstance.RetrieveSeriesGroups(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the list of groups scanlating a specific series
    ApiResponse<SeriesGroupListResponseV1> response = apiInstance.RetrieveSeriesGroupsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |

### Return type

[**SeriesGroupListResponseV1**](SeriesGroupListResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series not found |  -  |
| **200** | Return series list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveserieslocks"></a>
# **RetrieveSeriesLocks**
> List&lt;SeriesLockModelV1&gt; RetrieveSeriesLocks (long id)

get a specific series lock

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesLocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id

            try
            {
                // get a specific series lock
                List<SeriesLockModelV1> result = apiInstance.RetrieveSeriesLocks(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesLocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesLocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific series lock
    ApiResponse<List<SeriesLockModelV1>> response = apiInstance.RetrieveSeriesLocksWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesLocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |

### Return type

[**List&lt;SeriesLockModelV1&gt;**](SeriesLockModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series not found |  -  |
| **200** | Return series lock records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseriesranklocation"></a>
# **RetrieveSeriesRankLocation**
> ApiResponseV1 RetrieveSeriesRankLocation (long id, string type)

get a specific series rank location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesRankLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id
            var type = "type_example";  // string | Stat type

            try
            {
                // get a specific series rank location
                ApiResponseV1 result = apiInstance.RetrieveSeriesRankLocation(id, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesRankLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesRankLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific series rank location
    ApiResponse<ApiResponseV1> response = apiInstance.RetrieveSeriesRankLocationWithHttpInfo(id, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesRankLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **type** | **string** | Stat type |  |

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
| **200** | Return series rank location |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveseriesratingrainbow"></a>
# **RetrieveSeriesRatingRainbow**
> SeriesRatingRainbowModelV1 RetrieveSeriesRatingRainbow (long id)

get a the series rating rainbow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSeriesRatingRainbowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id

            try
            {
                // get a the series rating rainbow
                SeriesRatingRainbowModelV1 result = apiInstance.RetrieveSeriesRatingRainbow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveSeriesRatingRainbow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSeriesRatingRainbowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a the series rating rainbow
    ApiResponse<SeriesRatingRainbowModelV1> response = apiInstance.RetrieveSeriesRatingRainbowWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveSeriesRatingRainbowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |

### Return type

[**SeriesRatingRainbowModelV1**](SeriesRatingRainbowModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series not found |  -  |
| **200** | Return series rating records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveuserseriesrating"></a>
# **RetrieveUserSeriesRating**
> SeriesRatingModelV1 RetrieveUserSeriesRating (long id)

get a specific series rating for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveUserSeriesRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id

            try
            {
                // get a specific series rating for a user
                SeriesRatingModelV1 result = apiInstance.RetrieveUserSeriesRating(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.RetrieveUserSeriesRating: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveUserSeriesRatingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific series rating for a user
    ApiResponse<SeriesRatingModelV1> response = apiInstance.RetrieveUserSeriesRatingWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.RetrieveUserSeriesRatingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |

### Return type

[**SeriesRatingModelV1**](SeriesRatingModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Series not found |  -  |
| **200** | Return series rating records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchseriescommentspost"></a>
# **SearchSeriesCommentsPost**
> SeriesCommentSearchResponseV1 SearchSeriesCommentsPost (long id, SeriesCommentSearchRequestV1 seriesCommentSearchRequestV1)

search series comments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchSeriesCommentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id
            var seriesCommentSearchRequestV1 = new SeriesCommentSearchRequestV1(); // SeriesCommentSearchRequestV1 | 

            try
            {
                // search series comments
                SeriesCommentSearchResponseV1 result = apiInstance.SearchSeriesCommentsPost(id, seriesCommentSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.SearchSeriesCommentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchSeriesCommentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search series comments
    ApiResponse<SeriesCommentSearchResponseV1> response = apiInstance.SearchSeriesCommentsPostWithHttpInfo(id, seriesCommentSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.SearchSeriesCommentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **seriesCommentSearchRequestV1** | [**SeriesCommentSearchRequestV1**](SeriesCommentSearchRequestV1.md) |  |  |

### Return type

[**SeriesCommentSearchResponseV1**](SeriesCommentSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return series comment records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchserieshistorypost"></a>
# **SearchSeriesHistoryPost**
> SeriesHistorySearchResponseV1 SearchSeriesHistoryPost (long id, PerPageSearchRequestV1 perPageSearchRequestV1)

search series history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchSeriesHistoryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | Series id
            var perPageSearchRequestV1 = new PerPageSearchRequestV1(); // PerPageSearchRequestV1 | 

            try
            {
                // search series history
                SeriesHistorySearchResponseV1 result = apiInstance.SearchSeriesHistoryPost(id, perPageSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.SearchSeriesHistoryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchSeriesHistoryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search series history
    ApiResponse<SeriesHistorySearchResponseV1> response = apiInstance.SearchSeriesHistoryPostWithHttpInfo(id, perPageSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.SearchSeriesHistoryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Series id |  |
| **perPageSearchRequestV1** | [**PerPageSearchRequestV1**](PerPageSearchRequestV1.md) |  |  |

### Return type

[**SeriesHistorySearchResponseV1**](SeriesHistorySearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | Return series records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchseriespost"></a>
# **SearchSeriesPost**
> SeriesSearchResponseV1 SearchSeriesPost (SeriesSearchRequestV1 seriesSearchRequestV1)

search series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchSeriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var seriesSearchRequestV1 = new SeriesSearchRequestV1(); // SeriesSearchRequestV1 | 

            try
            {
                // search series
                SeriesSearchResponseV1 result = apiInstance.SearchSeriesPost(seriesSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.SearchSeriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchSeriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search series
    ApiResponse<SeriesSearchResponseV1> response = apiInstance.SearchSeriesPostWithHttpInfo(seriesSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.SearchSeriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seriesSearchRequestV1** | [**SeriesSearchRequestV1**](SeriesSearchRequestV1.md) |  |  |

### Return type

[**SeriesSearchResponseV1**](SeriesSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | Return series records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="seriescommentsmoderationpost"></a>
# **SeriesCommentsModerationPost**
> SeriesCommentModerationResponseV1 SeriesCommentsModerationPost (SeriesCommentSearchRequestV1 seriesCommentSearchRequestV1)

moderate series comments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SeriesCommentsModerationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var seriesCommentSearchRequestV1 = new SeriesCommentSearchRequestV1(); // SeriesCommentSearchRequestV1 | 

            try
            {
                // moderate series comments
                SeriesCommentModerationResponseV1 result = apiInstance.SeriesCommentsModerationPost(seriesCommentSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.SeriesCommentsModerationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SeriesCommentsModerationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // moderate series comments
    ApiResponse<SeriesCommentModerationResponseV1> response = apiInstance.SeriesCommentsModerationPostWithHttpInfo(seriesCommentSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.SeriesCommentsModerationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seriesCommentSearchRequestV1** | [**SeriesCommentSearchRequestV1**](SeriesCommentSearchRequestV1.md) |  |  |

### Return type

[**SeriesCommentModerationResponseV1**](SeriesCommentModerationResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return series comment moderation records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="seriesreleaserssfeed"></a>
# **SeriesReleaseRssFeed**
> string SeriesReleaseRssFeed (long id)

releases rss feed for a specific series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SeriesReleaseRssFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | id of series

            try
            {
                // releases rss feed for a specific series
                string result = apiInstance.SeriesReleaseRssFeed(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.SeriesReleaseRssFeed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SeriesReleaseRssFeedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // releases rss feed for a specific series
    ApiResponse<string> response = apiInstance.SeriesReleaseRssFeedWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.SeriesReleaseRssFeedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |

### Return type

**string**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return release feed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unlockseriesfield"></a>
# **UnlockSeriesField**
> ApiResponseV1 UnlockSeriesField (long id, string item)

unlock a field of an series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UnlockSeriesFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | id of series
            var item = "item_example";  // string | field name

            try
            {
                // unlock a field of an series
                ApiResponseV1 result = apiInstance.UnlockSeriesField(id, item);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.UnlockSeriesField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlockSeriesFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // unlock a field of an series
    ApiResponse<ApiResponseV1> response = apiInstance.UnlockSeriesFieldWithHttpInfo(id, item);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.UnlockSeriesFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **item** | **string** | field name |  |

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
| **200** | Field was unlocked |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series not found |  -  |
| **409** | Field is already unlocked |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateseries"></a>
# **UpdateSeries**
> ApiResponseV1 UpdateSeries (long id, SeriesModelUpdateV1 seriesModelUpdateV1)

update an series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var seriesModelUpdateV1 = new SeriesModelUpdateV1(); // SeriesModelUpdateV1 | 

            try
            {
                // update an series
                ApiResponseV1 result = apiInstance.UpdateSeries(id, seriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.UpdateSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update an series
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateSeriesWithHttpInfo(id, seriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.UpdateSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesModelUpdateV1** | [**SeriesModelUpdateV1**](SeriesModelUpdateV1.md) |  |  |

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
| **200** | Series was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | Field is locked |  -  |
| **404** | Series not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateseriescomment"></a>
# **UpdateSeriesComment**
> ApiResponseV1 UpdateSeriesComment (long id, long commentId, SeriesCommentModelUpdateV1 seriesCommentModelUpdateV1)

update a series comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateSeriesCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 56;  // long | id of series
            var commentId = 56;  // long | id of series comment
            var seriesCommentModelUpdateV1 = new SeriesCommentModelUpdateV1(); // SeriesCommentModelUpdateV1 | 

            try
            {
                // update a series comment
                ApiResponseV1 result = apiInstance.UpdateSeriesComment(id, commentId, seriesCommentModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.UpdateSeriesComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSeriesCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a series comment
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateSeriesCommentWithHttpInfo(id, commentId, seriesCommentModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.UpdateSeriesCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **commentId** | **long** | id of series comment |  |
| **seriesCommentModelUpdateV1** | [**SeriesCommentModelUpdateV1**](SeriesCommentModelUpdateV1.md) |  |  |

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
| **200** | Series comment was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role or own the series comment |  -  |
| **404** | Series or comment not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateseriesimage"></a>
# **UpdateSeriesImage**
> ApiResponseV1 UpdateSeriesImage (long id, System.IO.Stream image = null)

update the image of an series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateSeriesImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | id of series
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Image to update (optional) 

            try
            {
                // update the image of an series
                ApiResponseV1 result = apiInstance.UpdateSeriesImage(id, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.UpdateSeriesImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSeriesImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update the image of an series
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateSeriesImageWithHttpInfo(id, image);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.UpdateSeriesImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **image** | **System.IO.Stream****System.IO.Stream** | Image to update | [optional]  |

### Return type

[**ApiResponseV1**](ApiResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Image was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | Field is locked |  -  |
| **404** | Series not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuserseriesrating"></a>
# **UpdateUserSeriesRating**
> ApiResponseV1 UpdateUserSeriesRating (long id, SeriesRatingModelV1 seriesRatingModelV1)

update the user rating for a series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateUserSeriesRatingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SeriesApi(config);
            var id = 789L;  // long | id of series
            var seriesRatingModelV1 = new SeriesRatingModelV1(); // SeriesRatingModelV1 | 

            try
            {
                // update the user rating for a series
                ApiResponseV1 result = apiInstance.UpdateUserSeriesRating(id, seriesRatingModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SeriesApi.UpdateUserSeriesRating: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserSeriesRatingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update the user rating for a series
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateUserSeriesRatingWithHttpInfo(id, seriesRatingModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SeriesApi.UpdateUserSeriesRatingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of series |  |
| **seriesRatingModelV1** | [**SeriesRatingModelV1**](SeriesRatingModelV1.md) |  |  |

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
| **200** | Series rating was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Series not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

