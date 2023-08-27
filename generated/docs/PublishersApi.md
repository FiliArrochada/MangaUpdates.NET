# MangaUpdates.Api.PublishersApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPublisher**](PublishersApi.md#addpublisher) | **POST** /publishers | add an publisher |
| [**DeletePublisher**](PublishersApi.md#deletepublisher) | **DELETE** /publishers/{id} | delete a publisher |
| [**RetrievePublicationSeries**](PublishersApi.md#retrievepublicationseries) | **GET** /publishers/publication | get the list of series for a specific publication |
| [**RetrievePublisher**](PublishersApi.md#retrievepublisher) | **GET** /publishers/{id} | get a specific publisher |
| [**RetrievePublisherSeries**](PublishersApi.md#retrievepublisherseries) | **GET** /publishers/{id}/series | get the list of series for a specific publisher |
| [**SearchPublishersPost**](PublishersApi.md#searchpublisherspost) | **POST** /publishers/search | search publishers |
| [**UpdatePublisher**](PublishersApi.md#updatepublisher) | **PATCH** /publishers/{id} | update a publisher |

<a id="addpublisher"></a>
# **AddPublisher**
> ApiResponseV1 AddPublisher (PublishersModelUpdateV1 publishersModelUpdateV1)

add an publisher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddPublisherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var publishersModelUpdateV1 = new PublishersModelUpdateV1(); // PublishersModelUpdateV1 | 

            try
            {
                // add an publisher
                ApiResponseV1 result = apiInstance.AddPublisher(publishersModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.AddPublisher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPublisherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add an publisher
    ApiResponse<ApiResponseV1> response = apiInstance.AddPublisherWithHttpInfo(publishersModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.AddPublisherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishersModelUpdateV1** | [**PublishersModelUpdateV1**](PublishersModelUpdateV1.md) |  |  |

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
| **200** | Publisher was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepublisher"></a>
# **DeletePublisher**
> ApiResponseV1 DeletePublisher (long id)

delete a publisher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeletePublisherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var id = 56;  // long | id of publisher

            try
            {
                // delete a publisher
                ApiResponseV1 result = apiInstance.DeletePublisher(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.DeletePublisher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePublisherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a publisher
    ApiResponse<ApiResponseV1> response = apiInstance.DeletePublisherWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.DeletePublisherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of publisher |  |

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
| **200** | Publisher delete transaction submitted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Publisher not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepublicationseries"></a>
# **RetrievePublicationSeries**
> PublishersPublicationResponseV1 RetrievePublicationSeries (string pubname)

get the list of series for a specific publication

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePublicationSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var pubname = "pubname_example";  // string | Publication name

            try
            {
                // get the list of series for a specific publication
                PublishersPublicationResponseV1 result = apiInstance.RetrievePublicationSeries(pubname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.RetrievePublicationSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePublicationSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the list of series for a specific publication
    ApiResponse<PublishersPublicationResponseV1> response = apiInstance.RetrievePublicationSeriesWithHttpInfo(pubname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.RetrievePublicationSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pubname** | **string** | Publication name |  |

### Return type

[**PublishersPublicationResponseV1**](PublishersPublicationResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **404** | Publication not found |  -  |
| **200** | Return series list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepublisher"></a>
# **RetrievePublisher**
> PublishersModelV1 RetrievePublisher (long id, bool? unrenderedFields = null)

get a specific publisher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePublisherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var id = 56;  // long | Publisher id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific publisher
                PublishersModelV1 result = apiInstance.RetrievePublisher(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.RetrievePublisher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePublisherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific publisher
    ApiResponse<PublishersModelV1> response = apiInstance.RetrievePublisherWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.RetrievePublisherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Publisher id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**PublishersModelV1**](PublishersModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Publisher not found |  -  |
| **200** | Return publisher record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepublisherseries"></a>
# **RetrievePublisherSeries**
> PublishersSeriesListResponseV1 RetrievePublisherSeries (long id)

get the list of series for a specific publisher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePublisherSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var id = 789L;  // long | Publisher id

            try
            {
                // get the list of series for a specific publisher
                PublishersSeriesListResponseV1 result = apiInstance.RetrievePublisherSeries(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.RetrievePublisherSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePublisherSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the list of series for a specific publisher
    ApiResponse<PublishersSeriesListResponseV1> response = apiInstance.RetrievePublisherSeriesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.RetrievePublisherSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Publisher id |  |

### Return type

[**PublishersSeriesListResponseV1**](PublishersSeriesListResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Publisher not found |  -  |
| **200** | Return series list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchpublisherspost"></a>
# **SearchPublishersPost**
> PublishersSearchResponseV1 SearchPublishersPost (PublishersSearchRequestV1 publishersSearchRequestV1)

search publishers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchPublishersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var publishersSearchRequestV1 = new PublishersSearchRequestV1(); // PublishersSearchRequestV1 | 

            try
            {
                // search publishers
                PublishersSearchResponseV1 result = apiInstance.SearchPublishersPost(publishersSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.SearchPublishersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchPublishersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search publishers
    ApiResponse<PublishersSearchResponseV1> response = apiInstance.SearchPublishersPostWithHttpInfo(publishersSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.SearchPublishersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishersSearchRequestV1** | [**PublishersSearchRequestV1**](PublishersSearchRequestV1.md) |  |  |

### Return type

[**PublishersSearchResponseV1**](PublishersSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | Return publisher records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepublisher"></a>
# **UpdatePublisher**
> ApiResponseV1 UpdatePublisher (long id, PublishersModelUpdateV1 publishersModelUpdateV1)

update a publisher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdatePublisherExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PublishersApi(config);
            var id = 56;  // long | id of publisher
            var publishersModelUpdateV1 = new PublishersModelUpdateV1(); // PublishersModelUpdateV1 | 

            try
            {
                // update a publisher
                ApiResponseV1 result = apiInstance.UpdatePublisher(id, publishersModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublishersApi.UpdatePublisher: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePublisherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a publisher
    ApiResponse<ApiResponseV1> response = apiInstance.UpdatePublisherWithHttpInfo(id, publishersModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublishersApi.UpdatePublisherWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of publisher |  |
| **publishersModelUpdateV1** | [**PublishersModelUpdateV1**](PublishersModelUpdateV1.md) |  |  |

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
| **200** | Publisher was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Publisher not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

