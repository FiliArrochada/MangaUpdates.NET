# MangaUpdates.Api.CategoriesApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BulkCombineSeriesCategories**](CategoriesApi.md#bulkcombineseriescategories) | **POST** /categories/bulk/combine | combine two categories across the database |
| [**BulkDeleteSeriesCategories**](CategoriesApi.md#bulkdeleteseriescategories) | **POST** /categories/bulk/delete | delete a category across the database |
| [**FindCategoryByExact**](CategoriesApi.md#findcategorybyexact) | **POST** /categories/findByExact | find a category by name |
| [**FindCategoryByPrefix**](CategoriesApi.md#findcategorybyprefix) | **POST** /categories/findByPrefix | find a category by prefix |
| [**SearchCategoriesPost**](CategoriesApi.md#searchcategoriespost) | **POST** /categories/search | search categories |

<a id="bulkcombineseriescategories"></a>
# **BulkCombineSeriesCategories**
> ApiResponseV1 BulkCombineSeriesCategories (SeriesCategoryUpdateModelV1 seriesCategoryUpdateModelV1)

combine two categories across the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class BulkCombineSeriesCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var seriesCategoryUpdateModelV1 = new SeriesCategoryUpdateModelV1(); // SeriesCategoryUpdateModelV1 | 

            try
            {
                // combine two categories across the database
                ApiResponseV1 result = apiInstance.BulkCombineSeriesCategories(seriesCategoryUpdateModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.BulkCombineSeriesCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkCombineSeriesCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // combine two categories across the database
    ApiResponse<ApiResponseV1> response = apiInstance.BulkCombineSeriesCategoriesWithHttpInfo(seriesCategoryUpdateModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.BulkCombineSeriesCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **200** | Transaction has started |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkdeleteseriescategories"></a>
# **BulkDeleteSeriesCategories**
> ApiResponseV1 BulkDeleteSeriesCategories (CategoriesModelUpdateV1 categoriesModelUpdateV1)

delete a category across the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class BulkDeleteSeriesCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var categoriesModelUpdateV1 = new CategoriesModelUpdateV1(); // CategoriesModelUpdateV1 | 

            try
            {
                // delete a category across the database
                ApiResponseV1 result = apiInstance.BulkDeleteSeriesCategories(categoriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.BulkDeleteSeriesCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkDeleteSeriesCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a category across the database
    ApiResponse<ApiResponseV1> response = apiInstance.BulkDeleteSeriesCategoriesWithHttpInfo(categoriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.BulkDeleteSeriesCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **200** | Transaction has started |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findcategorybyexact"></a>
# **FindCategoryByExact**
> CategoriesModelV1 FindCategoryByExact (CategoriesModelUpdateV1 categoriesModelUpdateV1)

find a category by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class FindCategoryByExactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var categoriesModelUpdateV1 = new CategoriesModelUpdateV1(); // CategoriesModelUpdateV1 | 

            try
            {
                // find a category by name
                CategoriesModelV1 result = apiInstance.FindCategoryByExact(categoriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.FindCategoryByExact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindCategoryByExactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // find a category by name
    ApiResponse<CategoriesModelV1> response = apiInstance.FindCategoryByExactWithHttpInfo(categoriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.FindCategoryByExactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoriesModelUpdateV1** | [**CategoriesModelUpdateV1**](CategoriesModelUpdateV1.md) |  |  |

### Return type

[**CategoriesModelV1**](CategoriesModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Category not found |  -  |
| **200** | Return categories record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findcategorybyprefix"></a>
# **FindCategoryByPrefix**
> List&lt;CategoriesModelV1&gt; FindCategoryByPrefix (CategoriesModelUpdateV1 categoriesModelUpdateV1)

find a category by prefix

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class FindCategoryByPrefixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var categoriesModelUpdateV1 = new CategoriesModelUpdateV1(); // CategoriesModelUpdateV1 | 

            try
            {
                // find a category by prefix
                List<CategoriesModelV1> result = apiInstance.FindCategoryByPrefix(categoriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.FindCategoryByPrefix: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindCategoryByPrefixWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // find a category by prefix
    ApiResponse<List<CategoriesModelV1>> response = apiInstance.FindCategoryByPrefixWithHttpInfo(categoriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.FindCategoryByPrefixWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoriesModelUpdateV1** | [**CategoriesModelUpdateV1**](CategoriesModelUpdateV1.md) |  |  |

### Return type

[**List&lt;CategoriesModelV1&gt;**](CategoriesModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return categories records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchcategoriespost"></a>
# **SearchCategoriesPost**
> CategoriesSearchResponseV1 SearchCategoriesPost (CategoriesSearchRequestV1 categoriesSearchRequestV1)

search categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchCategoriesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var categoriesSearchRequestV1 = new CategoriesSearchRequestV1(); // CategoriesSearchRequestV1 | 

            try
            {
                // search categories
                CategoriesSearchResponseV1 result = apiInstance.SearchCategoriesPost(categoriesSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.SearchCategoriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchCategoriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search categories
    ApiResponse<CategoriesSearchResponseV1> response = apiInstance.SearchCategoriesPostWithHttpInfo(categoriesSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.SearchCategoriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoriesSearchRequestV1** | [**CategoriesSearchRequestV1**](CategoriesSearchRequestV1.md) |  |  |

### Return type

[**CategoriesSearchResponseV1**](CategoriesSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return categories records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

