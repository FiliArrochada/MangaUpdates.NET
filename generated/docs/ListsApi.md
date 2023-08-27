# MangaUpdates.Api.ListsApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddCustomList**](ListsApi.md#addcustomlist) | **POST** /lists | add a custom user list |
| [**AddListSeries**](ListsApi.md#addlistseries) | **POST** /lists/series | add a series to a list |
| [**AddListSeriesBulk**](ListsApi.md#addlistseriesbulk) | **POST** /lists/{id}/series/bulk | add a list of series to a list |
| [**DeleteCustomList**](ListsApi.md#deletecustomlist) | **DELETE** /lists/{id} | remove a custom list |
| [**DeleteListSeries**](ListsApi.md#deletelistseries) | **POST** /lists/series/delete | remove a series from a list |
| [**RetrieveListById**](ListsApi.md#retrievelistbyid) | **GET** /lists/{id} | retrieve list metadata and options |
| [**RetrieveListSeries**](ListsApi.md#retrievelistseries) | **GET** /lists/series/{series_id} | retrieve list series item |
| [**RetrieveLists**](ListsApi.md#retrievelists) | **GET** /lists | retrieve list of user lists |
| [**RetrievePublicListStats**](ListsApi.md#retrievepublicliststats) | **GET** /lists/public/{user_id}/stats | retrieve stats for user public lists |
| [**RetrievePublicLists**](ListsApi.md#retrievepubliclists) | **GET** /lists/public/{user_id} | retrieve list of user lists |
| [**RetrieveSimilarUsersBySeries**](ListsApi.md#retrievesimilarusersbyseries) | **GET** /lists/similar/{list_name}/{series_id} | retrieve users who have similar interests based on series |
| [**SearchListsPost**](ListsApi.md#searchlistspost) | **POST** /lists/{id}/search | search lists |
| [**SearchPublicListsPost**](ListsApi.md#searchpubliclistspost) | **POST** /lists/public/{user_id}/search/{id} | search lists |
| [**UpdateList**](ListsApi.md#updatelist) | **PATCH** /lists/{id} | update a user list |
| [**UpdateListSeries**](ListsApi.md#updatelistseries) | **POST** /lists/series/update | update a series list item |

<a id="addcustomlist"></a>
# **AddCustomList**
> ApiResponseV1 AddCustomList (ListsModelUpdateV1 listsModelUpdateV1)

add a custom user list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddCustomListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var listsModelUpdateV1 = new ListsModelUpdateV1(); // ListsModelUpdateV1 | 

            try
            {
                // add a custom user list
                ApiResponseV1 result = apiInstance.AddCustomList(listsModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.AddCustomList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddCustomListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a custom user list
    ApiResponse<ApiResponseV1> response = apiInstance.AddCustomListWithHttpInfo(listsModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.AddCustomListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listsModelUpdateV1** | [**ListsModelUpdateV1**](ListsModelUpdateV1.md) |  |  |

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
| **200** | List was added |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addlistseries"></a>
# **AddListSeries**
> void AddListSeries (List<ListsSeriesModelUpdateV1> listsSeriesModelUpdateV1)

add a series to a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddListSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var listsSeriesModelUpdateV1 = new List<ListsSeriesModelUpdateV1>(); // List<ListsSeriesModelUpdateV1> | 

            try
            {
                // add a series to a list
                apiInstance.AddListSeries(listsSeriesModelUpdateV1);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.AddListSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddListSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a series to a list
    apiInstance.AddListSeriesWithHttpInfo(listsSeriesModelUpdateV1);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.AddListSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listsSeriesModelUpdateV1** | [**List&lt;ListsSeriesModelUpdateV1&gt;**](ListsSeriesModelUpdateV1.md) |  |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Series was added |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addlistseriesbulk"></a>
# **AddListSeriesBulk**
> ApiResponseV1 AddListSeriesBulk (long id, List<ListsBulkAddModelV1> listsBulkAddModelV1)

add a list of series to a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddListSeriesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var id = 56;  // long | id of list
            var listsBulkAddModelV1 = new List<ListsBulkAddModelV1>(); // List<ListsBulkAddModelV1> | 

            try
            {
                // add a list of series to a list
                ApiResponseV1 result = apiInstance.AddListSeriesBulk(id, listsBulkAddModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.AddListSeriesBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddListSeriesBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a list of series to a list
    ApiResponse<ApiResponseV1> response = apiInstance.AddListSeriesBulkWithHttpInfo(id, listsBulkAddModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.AddListSeriesBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of list |  |
| **listsBulkAddModelV1** | [**List&lt;ListsBulkAddModelV1&gt;**](ListsBulkAddModelV1.md) |  |  |

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
| **200** | Series were (partially) added |  -  |
| **400** | Validation or service error |  -  |
| **404** | User list not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomlist"></a>
# **DeleteCustomList**
> ApiResponseV1 DeleteCustomList (long id)

remove a custom list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteCustomListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var id = 56;  // long | id of list

            try
            {
                // remove a custom list
                ApiResponseV1 result = apiInstance.DeleteCustomList(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.DeleteCustomList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a custom list
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteCustomListWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.DeleteCustomListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of list |  |

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
| **200** | Custom list was removed |  -  |
| **400** | Validation or service error |  -  |
| **404** | User list not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelistseries"></a>
# **DeleteListSeries**
> ApiResponseV1 DeleteListSeries (List<long> requestBody)

remove a series from a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteListSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var requestBody = new List<long>(); // List<long> | 

            try
            {
                // remove a series from a list
                ApiResponseV1 result = apiInstance.DeleteListSeries(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.DeleteListSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a series from a list
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteListSeriesWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.DeleteListSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;long&gt;**](long.md) |  |  |

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
| **200** | Series were removed |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievelistbyid"></a>
# **RetrieveListById**
> ListsModelV1 RetrieveListById (long id, bool? unrenderedFields = null)

retrieve list metadata and options

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveListByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var id = 56;  // long | List id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // retrieve list metadata and options
                ListsModelV1 result = apiInstance.RetrieveListById(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.RetrieveListById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveListByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve list metadata and options
    ApiResponse<ListsModelV1> response = apiInstance.RetrieveListByIdWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.RetrieveListByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | List id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ListsModelV1**](ListsModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | List not found |  -  |
| **200** | Return list record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievelistseries"></a>
# **RetrieveListSeries**
> ListsSeriesModelV1 RetrieveListSeries (long seriesId, bool? unrenderedFields = null)

retrieve list series item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveListSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var seriesId = 56;  // long | Series id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // retrieve list series item
                ListsSeriesModelV1 result = apiInstance.RetrieveListSeries(seriesId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.RetrieveListSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveListSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve list series item
    ApiResponse<ListsSeriesModelV1> response = apiInstance.RetrieveListSeriesWithHttpInfo(seriesId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.RetrieveListSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seriesId** | **long** | Series id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ListsSeriesModelV1**](ListsSeriesModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | List or series not found |  -  |
| **200** | Return list series record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievelists"></a>
# **RetrieveLists**
> List&lt;ListsModelV1&gt; RetrieveLists ()

retrieve list of user lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);

            try
            {
                // retrieve list of user lists
                List<ListsModelV1> result = apiInstance.RetrieveLists();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.RetrieveLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve list of user lists
    ApiResponse<List<ListsModelV1>> response = apiInstance.RetrieveListsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.RetrieveListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ListsModelV1&gt;**](ListsModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return list records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepublicliststats"></a>
# **RetrievePublicListStats**
> ListsPublicStatsModelV1 RetrievePublicListStats (long userId)

retrieve stats for user public lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePublicListStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var userId = 56;  // long | User id

            try
            {
                // retrieve stats for user public lists
                ListsPublicStatsModelV1 result = apiInstance.RetrievePublicListStats(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.RetrievePublicListStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePublicListStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve stats for user public lists
    ApiResponse<ListsPublicStatsModelV1> response = apiInstance.RetrievePublicListStatsWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.RetrievePublicListStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | User id |  |

### Return type

[**ListsPublicStatsModelV1**](ListsPublicStatsModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return public list stats records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepubliclists"></a>
# **RetrievePublicLists**
> List&lt;ListsModelV1&gt; RetrievePublicLists (long userId)

retrieve list of user lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePublicListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var userId = 56;  // long | User id

            try
            {
                // retrieve list of user lists
                List<ListsModelV1> result = apiInstance.RetrievePublicLists(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.RetrievePublicLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePublicListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve list of user lists
    ApiResponse<List<ListsModelV1>> response = apiInstance.RetrievePublicListsWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.RetrievePublicListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | User id |  |

### Return type

[**List&lt;ListsModelV1&gt;**](ListsModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return list records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievesimilarusersbyseries"></a>
# **RetrieveSimilarUsersBySeries**
> ListsSimilarUsersResponseV1 RetrieveSimilarUsersBySeries (string listName, long seriesId)

retrieve users who have similar interests based on series

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveSimilarUsersBySeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var listName = "read";  // string | name of list
            var seriesId = 56;  // long | Series id

            try
            {
                // retrieve users who have similar interests based on series
                ListsSimilarUsersResponseV1 result = apiInstance.RetrieveSimilarUsersBySeries(listName, seriesId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.RetrieveSimilarUsersBySeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSimilarUsersBySeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve users who have similar interests based on series
    ApiResponse<ListsSimilarUsersResponseV1> response = apiInstance.RetrieveSimilarUsersBySeriesWithHttpInfo(listName, seriesId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.RetrieveSimilarUsersBySeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listName** | **string** | name of list |  |
| **seriesId** | **long** | Series id |  |

### Return type

[**ListsSimilarUsersResponseV1**](ListsSimilarUsersResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | List or series not found |  -  |
| **200** | Return similar user records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchlistspost"></a>
# **SearchListsPost**
> ListsSearchResponseV1 SearchListsPost (long id, ListsSearchRequestV1 listsSearchRequestV1)

search lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchListsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var id = 56;  // long | list id to search
            var listsSearchRequestV1 = new ListsSearchRequestV1(); // ListsSearchRequestV1 | 

            try
            {
                // search lists
                ListsSearchResponseV1 result = apiInstance.SearchListsPost(id, listsSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.SearchListsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchListsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search lists
    ApiResponse<ListsSearchResponseV1> response = apiInstance.SearchListsPostWithHttpInfo(id, listsSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.SearchListsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | list id to search |  |
| **listsSearchRequestV1** | [**ListsSearchRequestV1**](ListsSearchRequestV1.md) |  |  |

### Return type

[**ListsSearchResponseV1**](ListsSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return list records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchpubliclistspost"></a>
# **SearchPublicListsPost**
> ListsPublicSearchResponseV1 SearchPublicListsPost (long userId, long id, ListsSearchRequestV1 listsSearchRequestV1)

search lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchPublicListsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var userId = 56;  // long | User id
            var id = 56;  // long | list id to search
            var listsSearchRequestV1 = new ListsSearchRequestV1(); // ListsSearchRequestV1 | 

            try
            {
                // search lists
                ListsPublicSearchResponseV1 result = apiInstance.SearchPublicListsPost(userId, id, listsSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.SearchPublicListsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchPublicListsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search lists
    ApiResponse<ListsPublicSearchResponseV1> response = apiInstance.SearchPublicListsPostWithHttpInfo(userId, id, listsSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.SearchPublicListsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | User id |  |
| **id** | **long** | list id to search |  |
| **listsSearchRequestV1** | [**ListsSearchRequestV1**](ListsSearchRequestV1.md) |  |  |

### Return type

[**ListsPublicSearchResponseV1**](ListsPublicSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return list records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatelist"></a>
# **UpdateList**
> ApiResponseV1 UpdateList (long id, ListsModelUpdateV1 listsModelUpdateV1)

update a user list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var id = 56;  // long | id of list
            var listsModelUpdateV1 = new ListsModelUpdateV1(); // ListsModelUpdateV1 | 

            try
            {
                // update a user list
                ApiResponseV1 result = apiInstance.UpdateList(id, listsModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.UpdateList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a user list
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateListWithHttpInfo(id, listsModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.UpdateListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of list |  |
| **listsModelUpdateV1** | [**ListsModelUpdateV1**](ListsModelUpdateV1.md) |  |  |

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
| **200** | User list was updated |  -  |
| **400** | Validation or service error |  -  |
| **404** | User list not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatelistseries"></a>
# **UpdateListSeries**
> ApiResponseV1 UpdateListSeries (List<ListsSeriesModelUpdateV1> listsSeriesModelUpdateV1)

update a series list item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateListSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ListsApi(config);
            var listsSeriesModelUpdateV1 = new List<ListsSeriesModelUpdateV1>(); // List<ListsSeriesModelUpdateV1> | 

            try
            {
                // update a series list item
                ApiResponseV1 result = apiInstance.UpdateListSeries(listsSeriesModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListsApi.UpdateListSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateListSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a series list item
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateListSeriesWithHttpInfo(listsSeriesModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ListsApi.UpdateListSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listsSeriesModelUpdateV1** | [**List&lt;ListsSeriesModelUpdateV1&gt;**](ListsSeriesModelUpdateV1.md) |  |  |

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
| **200** | Series list items were updated |  -  |
| **400** | Validation or service error |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

