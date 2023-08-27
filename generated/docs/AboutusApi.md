# MangaUpdates.Api.AboutusApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAboutusCategory**](AboutusApi.md#addaboutuscategory) | **POST** /aboutus/category | add a category |
| [**AddAboutusCategoryUser**](AboutusApi.md#addaboutuscategoryuser) | **POST** /aboutus/category/{category_id}/users | add a user to a category |
| [**DeleteAboutusCategory**](AboutusApi.md#deleteaboutuscategory) | **DELETE** /aboutus/category/{category_id} | remove a category |
| [**DeleteAboutusCategoryUser**](AboutusApi.md#deleteaboutuscategoryuser) | **DELETE** /aboutus/category/{category_id}/users/{entry_id} | remove a user from a category |
| [**ReorderAboutus**](AboutusApi.md#reorderaboutus) | **POST** /aboutus/reorder | reorder aboutus |
| [**RetrieveAboutusCategoriesAndUsers**](AboutusApi.md#retrieveaboutuscategoriesandusers) | **GET** /aboutus/users | returns categories and users |
| [**RetrieveAboutusCategory**](AboutusApi.md#retrieveaboutuscategory) | **GET** /aboutus/category/{category_id} | returns a single category |
| [**RetrieveAboutusDescription**](AboutusApi.md#retrieveaboutusdescription) | **GET** /aboutus | returns description of site |
| [**UpdateAboutusCategory**](AboutusApi.md#updateaboutuscategory) | **PATCH** /aboutus/category/{category_id} | update a category |
| [**UpdateAboutusDescription**](AboutusApi.md#updateaboutusdescription) | **POST** /aboutus | update description of site |

<a id="addaboutuscategory"></a>
# **AddAboutusCategory**
> ApiResponseV1 AddAboutusCategory (AboutusCategoryModelUpdateV1 aboutusCategoryModelUpdateV1)

add a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddAboutusCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var aboutusCategoryModelUpdateV1 = new AboutusCategoryModelUpdateV1(); // AboutusCategoryModelUpdateV1 | 

            try
            {
                // add a category
                ApiResponseV1 result = apiInstance.AddAboutusCategory(aboutusCategoryModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.AddAboutusCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAboutusCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a category
    ApiResponse<ApiResponseV1> response = apiInstance.AddAboutusCategoryWithHttpInfo(aboutusCategoryModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.AddAboutusCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aboutusCategoryModelUpdateV1** | [**AboutusCategoryModelUpdateV1**](AboutusCategoryModelUpdateV1.md) |  |  |

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
| **200** | Category was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addaboutuscategoryuser"></a>
# **AddAboutusCategoryUser**
> ApiResponseV1 AddAboutusCategoryUser (long categoryId, AboutusUserModelUpdateV1 aboutusUserModelUpdateV1)

add a user to a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddAboutusCategoryUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var categoryId = 56;  // long | Aboutus Category id
            var aboutusUserModelUpdateV1 = new AboutusUserModelUpdateV1(); // AboutusUserModelUpdateV1 | 

            try
            {
                // add a user to a category
                ApiResponseV1 result = apiInstance.AddAboutusCategoryUser(categoryId, aboutusUserModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.AddAboutusCategoryUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAboutusCategoryUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a user to a category
    ApiResponse<ApiResponseV1> response = apiInstance.AddAboutusCategoryUserWithHttpInfo(categoryId, aboutusUserModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.AddAboutusCategoryUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Aboutus Category id |  |
| **aboutusUserModelUpdateV1** | [**AboutusUserModelUpdateV1**](AboutusUserModelUpdateV1.md) |  |  |

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
| **200** | User was added |  -  |
| **400** | Validation or service error |  -  |
| **404** | Category does not exist |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaboutuscategory"></a>
# **DeleteAboutusCategory**
> ApiResponseV1 DeleteAboutusCategory (long categoryId)

remove a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteAboutusCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var categoryId = 56;  // long | Aboutus Category id

            try
            {
                // remove a category
                ApiResponseV1 result = apiInstance.DeleteAboutusCategory(categoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.DeleteAboutusCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAboutusCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a category
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteAboutusCategoryWithHttpInfo(categoryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.DeleteAboutusCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Aboutus Category id |  |

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
| **200** | Category was removed |  -  |
| **400** | Validation or service error |  -  |
| **404** | Category does not exist |  -  |
| **401** | Category does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaboutuscategoryuser"></a>
# **DeleteAboutusCategoryUser**
> ApiResponseV1 DeleteAboutusCategoryUser (long categoryId, long entryId)

remove a user from a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteAboutusCategoryUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var categoryId = 56;  // long | Aboutus Category id
            var entryId = 56;  // long | Aboutus Category User Entry id

            try
            {
                // remove a user from a category
                ApiResponseV1 result = apiInstance.DeleteAboutusCategoryUser(categoryId, entryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.DeleteAboutusCategoryUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAboutusCategoryUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a user from a category
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteAboutusCategoryUserWithHttpInfo(categoryId, entryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.DeleteAboutusCategoryUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Aboutus Category id |  |
| **entryId** | **long** | Aboutus Category User Entry id |  |

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
| **200** | User was removed |  -  |
| **404** | User does not exist |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reorderaboutus"></a>
# **ReorderAboutus**
> ApiResponseV1 ReorderAboutus (List<AboutusCategoryReorderModelV1> aboutusCategoryReorderModelV1)

reorder aboutus

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ReorderAboutusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var aboutusCategoryReorderModelV1 = new List<AboutusCategoryReorderModelV1>(); // List<AboutusCategoryReorderModelV1> | 

            try
            {
                // reorder aboutus
                ApiResponseV1 result = apiInstance.ReorderAboutus(aboutusCategoryReorderModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.ReorderAboutus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReorderAboutusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // reorder aboutus
    ApiResponse<ApiResponseV1> response = apiInstance.ReorderAboutusWithHttpInfo(aboutusCategoryReorderModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.ReorderAboutusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aboutusCategoryReorderModelV1** | [**List&lt;AboutusCategoryReorderModelV1&gt;**](AboutusCategoryReorderModelV1.md) |  |  |

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
| **200** | Categories and users were reordered |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveaboutuscategoriesandusers"></a>
# **RetrieveAboutusCategoriesAndUsers**
> List&lt;AboutusCategoryModelV1&gt; RetrieveAboutusCategoriesAndUsers ()

returns categories and users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveAboutusCategoriesAndUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);

            try
            {
                // returns categories and users
                List<AboutusCategoryModelV1> result = apiInstance.RetrieveAboutusCategoriesAndUsers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.RetrieveAboutusCategoriesAndUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveAboutusCategoriesAndUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns categories and users
    ApiResponse<List<AboutusCategoryModelV1>> response = apiInstance.RetrieveAboutusCategoriesAndUsersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.RetrieveAboutusCategoriesAndUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;AboutusCategoryModelV1&gt;**](AboutusCategoryModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of categories and users |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveaboutuscategory"></a>
# **RetrieveAboutusCategory**
> AboutusCategoryModelV1 RetrieveAboutusCategory (long categoryId, bool? unrenderedFields = null)

returns a single category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveAboutusCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var categoryId = 56;  // long | Aboutus Category id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // returns a single category
                AboutusCategoryModelV1 result = apiInstance.RetrieveAboutusCategory(categoryId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.RetrieveAboutusCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveAboutusCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns a single category
    ApiResponse<AboutusCategoryModelV1> response = apiInstance.RetrieveAboutusCategoryWithHttpInfo(categoryId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.RetrieveAboutusCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | Aboutus Category id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**AboutusCategoryModelV1**](AboutusCategoryModelV1.md)

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

<a id="retrieveaboutusdescription"></a>
# **RetrieveAboutusDescription**
> AboutusDescriptionModelV1 RetrieveAboutusDescription (bool? unrenderedFields = null)

returns description of site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveAboutusDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // returns description of site
                AboutusDescriptionModelV1 result = apiInstance.RetrieveAboutusDescription(unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.RetrieveAboutusDescription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveAboutusDescriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // returns description of site
    ApiResponse<AboutusDescriptionModelV1> response = apiInstance.RetrieveAboutusDescriptionWithHttpInfo(unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.RetrieveAboutusDescriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**AboutusDescriptionModelV1**](AboutusDescriptionModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Description of the site |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaboutuscategory"></a>
# **UpdateAboutusCategory**
> ApiResponseV1 UpdateAboutusCategory (long categoryId, AboutusCategoryModelUpdateV1 aboutusCategoryModelUpdateV1)

update a category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateAboutusCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var categoryId = 56;  // long | id of category
            var aboutusCategoryModelUpdateV1 = new AboutusCategoryModelUpdateV1(); // AboutusCategoryModelUpdateV1 | 

            try
            {
                // update a category
                ApiResponseV1 result = apiInstance.UpdateAboutusCategory(categoryId, aboutusCategoryModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.UpdateAboutusCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAboutusCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a category
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateAboutusCategoryWithHttpInfo(categoryId, aboutusCategoryModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.UpdateAboutusCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | id of category |  |
| **aboutusCategoryModelUpdateV1** | [**AboutusCategoryModelUpdateV1**](AboutusCategoryModelUpdateV1.md) |  |  |

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
| **200** | Category was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Category not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaboutusdescription"></a>
# **UpdateAboutusDescription**
> ApiResponseV1 UpdateAboutusDescription (AboutusDescriptionModelV1 aboutusDescriptionModelV1)

update description of site

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateAboutusDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AboutusApi(config);
            var aboutusDescriptionModelV1 = new AboutusDescriptionModelV1(); // AboutusDescriptionModelV1 | 

            try
            {
                // update description of site
                ApiResponseV1 result = apiInstance.UpdateAboutusDescription(aboutusDescriptionModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutusApi.UpdateAboutusDescription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAboutusDescriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update description of site
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateAboutusDescriptionWithHttpInfo(aboutusDescriptionModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AboutusApi.UpdateAboutusDescriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aboutusDescriptionModelV1** | [**AboutusDescriptionModelV1**](AboutusDescriptionModelV1.md) |  |  |

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
| **200** | Description of the site updated |  -  |
| **400** | Error updating description |  -  |
| **401** | User does not have appropriate role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

