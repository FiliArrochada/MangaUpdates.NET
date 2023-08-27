# MangaUpdates.Api.GroupsApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGroup**](GroupsApi.md#addgroup) | **POST** /groups | add an group |
| [**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /groups/{id} | delete a group |
| [**RejectGroup**](GroupsApi.md#rejectgroup) | **POST** /groups/{id}/reject | reject and delete a group |
| [**RetrieveGroup**](GroupsApi.md#retrievegroup) | **GET** /groups/{id} | get a specific group |
| [**RetrieveGroupSeries**](GroupsApi.md#retrievegroupseries) | **GET** /groups/{id}/series | get the list of series and release frequency for a specific group |
| [**SearchGroupsPost**](GroupsApi.md#searchgroupspost) | **POST** /groups/search | search groups |
| [**UpdateGroup**](GroupsApi.md#updategroup) | **PATCH** /groups/{id} | update an group |

<a id="addgroup"></a>
# **AddGroup**
> ApiResponseV1 AddGroup (GroupsModelUpdateV1 groupsModelUpdateV1)

add an group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var groupsModelUpdateV1 = new GroupsModelUpdateV1(); // GroupsModelUpdateV1 | 

            try
            {
                // add an group
                ApiResponseV1 result = apiInstance.AddGroup(groupsModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.AddGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add an group
    ApiResponse<ApiResponseV1> response = apiInstance.AddGroupWithHttpInfo(groupsModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.AddGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupsModelUpdateV1** | [**GroupsModelUpdateV1**](GroupsModelUpdateV1.md) |  |  |

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
| **200** | Group was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletegroup"></a>
# **DeleteGroup**
> ApiResponseV1 DeleteGroup (long id)

delete a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var id = 56;  // long | id of group

            try
            {
                // delete a group
                ApiResponseV1 result = apiInstance.DeleteGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a group
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteGroupWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of group |  |

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
| **200** | Group delete transaction submitted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Group not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rejectgroup"></a>
# **RejectGroup**
> ApiResponseV1 RejectGroup (long id)

reject and delete a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RejectGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var id = 56;  // long | id of group

            try
            {
                // reject and delete a group
                ApiResponseV1 result = apiInstance.RejectGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RejectGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RejectGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // reject and delete a group
    ApiResponse<ApiResponseV1> response = apiInstance.RejectGroupWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.RejectGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of group |  |

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
| **200** | Group reject transaction submitted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Group not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievegroup"></a>
# **RetrieveGroup**
> GroupsModelV1 RetrieveGroup (long id, bool? unrenderedFields = null)

get a specific group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var id = 789L;  // long | Group id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific group
                GroupsModelV1 result = apiInstance.RetrieveGroup(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RetrieveGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific group
    ApiResponse<GroupsModelV1> response = apiInstance.RetrieveGroupWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.RetrieveGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Group id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**GroupsModelV1**](GroupsModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Group not found |  -  |
| **200** | Return group record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievegroupseries"></a>
# **RetrieveGroupSeries**
> GroupsSeriesListResponseV1 RetrieveGroupSeries (long id)

get the list of series and release frequency for a specific group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveGroupSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var id = 789L;  // long | Group id

            try
            {
                // get the list of series and release frequency for a specific group
                GroupsSeriesListResponseV1 result = apiInstance.RetrieveGroupSeries(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.RetrieveGroupSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveGroupSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the list of series and release frequency for a specific group
    ApiResponse<GroupsSeriesListResponseV1> response = apiInstance.RetrieveGroupSeriesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.RetrieveGroupSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Group id |  |

### Return type

[**GroupsSeriesListResponseV1**](GroupsSeriesListResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Group not found |  -  |
| **200** | Return series list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchgroupspost"></a>
# **SearchGroupsPost**
> GroupsSearchResponseV1 SearchGroupsPost (GroupsSearchRequestV1 groupsSearchRequestV1)

search groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var groupsSearchRequestV1 = new GroupsSearchRequestV1(); // GroupsSearchRequestV1 | 

            try
            {
                // search groups
                GroupsSearchResponseV1 result = apiInstance.SearchGroupsPost(groupsSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.SearchGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search groups
    ApiResponse<GroupsSearchResponseV1> response = apiInstance.SearchGroupsPostWithHttpInfo(groupsSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.SearchGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupsSearchRequestV1** | [**GroupsSearchRequestV1**](GroupsSearchRequestV1.md) |  |  |

### Return type

[**GroupsSearchResponseV1**](GroupsSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | List of groups |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updategroup"></a>
# **UpdateGroup**
> ApiResponseV1 UpdateGroup (long id, GroupsModelUpdateV1 groupsModelUpdateV1)

update an group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new GroupsApi(config);
            var id = 56;  // long | id of group
            var groupsModelUpdateV1 = new GroupsModelUpdateV1(); // GroupsModelUpdateV1 | 

            try
            {
                // update an group
                ApiResponseV1 result = apiInstance.UpdateGroup(id, groupsModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update an group
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateGroupWithHttpInfo(id, groupsModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of group |  |
| **groupsModelUpdateV1** | [**GroupsModelUpdateV1**](GroupsModelUpdateV1.md) |  |  |

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
| **200** | Group was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Group not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

