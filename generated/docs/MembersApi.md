# MangaUpdates.Api.MembersApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMember**](MembersApi.md#addmember) | **POST** /members | add a member |
| [**AddMemberAvatar**](MembersApi.md#addmemberavatar) | **POST** /members/{id}/avatar | add a new member avatar |
| [**AddMemberChangeRequest**](MembersApi.md#addmemberchangerequest) | **POST** /members/{id}/requests | add a change request |
| [**AddMemberGenreFilter**](MembersApi.md#addmembergenrefilter) | **POST** /members/{id}/genre/{genre_id}/filter | filter a genre for a user |
| [**AddMemberGenreHighlight**](MembersApi.md#addmembergenrehighlight) | **POST** /members/{id}/genre/{genre_id}/highlight | highlight a genre for a user |
| [**AddOrUpdateUserGroup**](MembersApi.md#addorupdateusergroup) | **PUT** /membergroups/{id} | add or update a user group |
| [**AddUserGroupFilter**](MembersApi.md#addusergroupfilter) | **POST** /members/{id}/group/{group_id}/filter | filter a group for a user |
| [**AddUserTopicSubscription**](MembersApi.md#addusertopicsubscription) | **POST** /members/{id}/topics/{topic_id} | add a topic subscription for a user |
| [**ApproveMemberUpgrade**](MembersApi.md#approvememberupgrade) | **POST** /members/{id}/upgrade/approve | upgrade a member |
| [**DeleteMember**](MembersApi.md#deletemember) | **DELETE** /members/{id} | delete a member |
| [**DeleteMemberAvatar**](MembersApi.md#deletememberavatar) | **DELETE** /members/{id}/avatar/{avatar_id} | delete a member avatar |
| [**DeleteMemberChangeRequest**](MembersApi.md#deletememberchangerequest) | **DELETE** /members/{id}/requests/{request_id} | add a change request |
| [**DeleteUserGroup**](MembersApi.md#deleteusergroup) | **DELETE** /membergroups/{id} | delete a user group |
| [**RejectMemberUpgrade**](MembersApi.md#rejectmemberupgrade) | **POST** /members/{id}/upgrade/reject | reject a member upgrade |
| [**RemoveMemberGenreFilter**](MembersApi.md#removemembergenrefilter) | **DELETE** /members/{id}/genre/{genre_id}/filter | remove a filter for a genre for a user |
| [**RemoveMemberGenreHighlight**](MembersApi.md#removemembergenrehighlight) | **DELETE** /members/{id}/genre/{genre_id}/highlight | remove a highlight for a genre for a user |
| [**RemoveUserGroupFilter**](MembersApi.md#removeusergroupfilter) | **DELETE** /members/{id}/group/{group_id}/filter | remove a filter for a group for a user |
| [**RemoveUserTopicSubscription**](MembersApi.md#removeusertopicsubscription) | **DELETE** /members/{id}/topics/{topic_id} | remove a topic subscription for a user |
| [**ResetGenreSettings**](MembersApi.md#resetgenresettings) | **POST** /members/{id}/genre/reset | reset genre highlights and filters for a user |
| [**RetrieveMember**](MembersApi.md#retrievemember) | **GET** /members/{id} | get a specific members |
| [**RetrieveMemberAvatars**](MembersApi.md#retrievememberavatars) | **GET** /members/{id}/avatars | get avatars for a specific user |
| [**RetrieveMemberChangeRequest**](MembersApi.md#retrievememberchangerequest) | **GET** /members/{id}/requests/{request_id} | get change requests for a specific user |
| [**RetrieveMemberGenreFilters**](MembersApi.md#retrievemembergenrefilters) | **GET** /members/{id}/genre/filters | get genre filters for a specific user |
| [**RetrieveMemberGenreHighlights**](MembersApi.md#retrievemembergenrehighlights) | **GET** /members/{id}/genre/highlights | get highlights for a specific user |
| [**RetrieveMemberGroupFilters**](MembersApi.md#retrievemembergroupfilters) | **GET** /members/{id}/group/filters | get group filters for a specific user |
| [**RetrieveMemberTopicSubscription**](MembersApi.md#retrievemembertopicsubscription) | **GET** /members/{id}/topics/{topic_id} | get a subscription to a specific topic for a user |
| [**RetrieveMemberTopicSubscriptions**](MembersApi.md#retrievemembertopicsubscriptions) | **GET** /members/{id}/topics | get topic subscriptions for a specific user |
| [**RetrieveUserGroupById**](MembersApi.md#retrieveusergroupbyid) | **GET** /membergroups/{id} | get user group |
| [**RetrieveUserGroups**](MembersApi.md#retrieveusergroups) | **GET** /membergroups | get user groups |
| [**SearchMemberChangeRequests**](MembersApi.md#searchmemberchangerequests) | **GET** /members/{id}/requests | search change requests for a specific user |
| [**SearchMembersPost**](MembersApi.md#searchmemberspost) | **POST** /members/search | search members |
| [**UpdateMember**](MembersApi.md#updatemember) | **PATCH** /members/{id} | update a member |
| [**UpdateMemberChangeRequest**](MembersApi.md#updatememberchangerequest) | **PATCH** /members/{id}/requests/{request_id} | update a change request |

<a id="addmember"></a>
# **AddMember**
> ApiResponseV1 AddMember (UserModelUpdateV1 userModelUpdateV1)

add a member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var userModelUpdateV1 = new UserModelUpdateV1(); // UserModelUpdateV1 | 

            try
            {
                // add a member
                ApiResponseV1 result = apiInstance.AddMember(userModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a member
    ApiResponse<ApiResponseV1> response = apiInstance.AddMemberWithHttpInfo(userModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userModelUpdateV1** | [**UserModelUpdateV1**](UserModelUpdateV1.md) |  |  |

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
| **200** | Member was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addmemberavatar"></a>
# **AddMemberAvatar**
> ApiResponseV1 AddMemberAvatar (long id, System.IO.Stream image = null, string title = null)

add a new member avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddMemberAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Image to update (optional) 
            var title = "title_example";  // string | Title of the new avatar (optional) 

            try
            {
                // add a new member avatar
                ApiResponseV1 result = apiInstance.AddMemberAvatar(id, image, title);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddMemberAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a new member avatar
    ApiResponse<ApiResponseV1> response = apiInstance.AddMemberAvatarWithHttpInfo(id, image, title);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddMemberAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **image** | **System.IO.Stream****System.IO.Stream** | Image to update | [optional]  |
| **title** | **string** | Title of the new avatar | [optional]  |

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
| **200** | Image was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addmemberchangerequest"></a>
# **AddMemberChangeRequest**
> ApiResponseV1 AddMemberChangeRequest (long id, UserChangeRequestModelUpdateV1 userChangeRequestModelUpdateV1)

add a change request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddMemberChangeRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var userChangeRequestModelUpdateV1 = new UserChangeRequestModelUpdateV1(); // UserChangeRequestModelUpdateV1 | 

            try
            {
                // add a change request
                ApiResponseV1 result = apiInstance.AddMemberChangeRequest(id, userChangeRequestModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddMemberChangeRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberChangeRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a change request
    ApiResponse<ApiResponseV1> response = apiInstance.AddMemberChangeRequestWithHttpInfo(id, userChangeRequestModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddMemberChangeRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **userChangeRequestModelUpdateV1** | [**UserChangeRequestModelUpdateV1**](UserChangeRequestModelUpdateV1.md) |  |  |

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
| **200** | Change request was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Record not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addmembergenrefilter"></a>
# **AddMemberGenreFilter**
> ApiResponseV1 AddMemberGenreFilter (long id, long genreId)

filter a genre for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddMemberGenreFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var genreId = 56;  // long | genre id

            try
            {
                // filter a genre for a user
                ApiResponseV1 result = apiInstance.AddMemberGenreFilter(id, genreId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddMemberGenreFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberGenreFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // filter a genre for a user
    ApiResponse<ApiResponseV1> response = apiInstance.AddMemberGenreFilterWithHttpInfo(id, genreId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddMemberGenreFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **genreId** | **long** | genre id |  |

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
| **200** | Filter was added |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addmembergenrehighlight"></a>
# **AddMemberGenreHighlight**
> ApiResponseV1 AddMemberGenreHighlight (long id, long genreId, UserGenreHighlightModelUpdateV1 userGenreHighlightModelUpdateV1)

highlight a genre for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddMemberGenreHighlightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var genreId = 56;  // long | genre id
            var userGenreHighlightModelUpdateV1 = new UserGenreHighlightModelUpdateV1(); // UserGenreHighlightModelUpdateV1 | 

            try
            {
                // highlight a genre for a user
                ApiResponseV1 result = apiInstance.AddMemberGenreHighlight(id, genreId, userGenreHighlightModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddMemberGenreHighlight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberGenreHighlightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // highlight a genre for a user
    ApiResponse<ApiResponseV1> response = apiInstance.AddMemberGenreHighlightWithHttpInfo(id, genreId, userGenreHighlightModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddMemberGenreHighlightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **genreId** | **long** | genre id |  |
| **userGenreHighlightModelUpdateV1** | [**UserGenreHighlightModelUpdateV1**](UserGenreHighlightModelUpdateV1.md) |  |  |

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
| **200** | Highlight was added |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addorupdateusergroup"></a>
# **AddOrUpdateUserGroup**
> ApiResponseV1 AddOrUpdateUserGroup (string id, UserGroupModelUpdateV1 userGroupModelUpdateV1)

add or update a user group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddOrUpdateUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = "id_example";  // string | user group id
            var userGroupModelUpdateV1 = new UserGroupModelUpdateV1(); // UserGroupModelUpdateV1 | 

            try
            {
                // add or update a user group
                ApiResponseV1 result = apiInstance.AddOrUpdateUserGroup(id, userGroupModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddOrUpdateUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddOrUpdateUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add or update a user group
    ApiResponse<ApiResponseV1> response = apiInstance.AddOrUpdateUserGroupWithHttpInfo(id, userGroupModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddOrUpdateUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | user group id |  |
| **userGroupModelUpdateV1** | [**UserGroupModelUpdateV1**](UserGroupModelUpdateV1.md) |  |  |

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
| **200** | user group was added or updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addusergroupfilter"></a>
# **AddUserGroupFilter**
> ApiResponseV1 AddUserGroupFilter (long id, long groupId)

filter a group for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddUserGroupFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var groupId = 56;  // long | group id

            try
            {
                // filter a group for a user
                ApiResponseV1 result = apiInstance.AddUserGroupFilter(id, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddUserGroupFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddUserGroupFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // filter a group for a user
    ApiResponse<ApiResponseV1> response = apiInstance.AddUserGroupFilterWithHttpInfo(id, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddUserGroupFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **groupId** | **long** | group id |  |

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
| **200** | Filter was added |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addusertopicsubscription"></a>
# **AddUserTopicSubscription**
> ApiResponseV1 AddUserTopicSubscription (long id, long topicId)

add a topic subscription for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddUserTopicSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var topicId = 56;  // long | topic id

            try
            {
                // add a topic subscription for a user
                ApiResponseV1 result = apiInstance.AddUserTopicSubscription(id, topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.AddUserTopicSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddUserTopicSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a topic subscription for a user
    ApiResponse<ApiResponseV1> response = apiInstance.AddUserTopicSubscriptionWithHttpInfo(id, topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.AddUserTopicSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **topicId** | **long** | topic id |  |

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
| **200** | Topic Subscription was added |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member or Forum/Topic not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="approvememberupgrade"></a>
# **ApproveMemberUpgrade**
> ApiResponseV1 ApproveMemberUpgrade (long id)

upgrade a member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ApproveMemberUpgradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 56;  // long | Member id

            try
            {
                // upgrade a member
                ApiResponseV1 result = apiInstance.ApproveMemberUpgrade(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.ApproveMemberUpgrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApproveMemberUpgradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // upgrade a member
    ApiResponse<ApiResponseV1> response = apiInstance.ApproveMemberUpgradeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.ApproveMemberUpgradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

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
| **200** | Member was upgraded |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemember"></a>
# **DeleteMember**
> ApiResponseV1 DeleteMember (long id)

delete a member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 56;  // long | Member id

            try
            {
                // delete a member
                ApiResponseV1 result = apiInstance.DeleteMember(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.DeleteMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a member
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteMemberWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.DeleteMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

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
| **200** | Member was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Member not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletememberavatar"></a>
# **DeleteMemberAvatar**
> ApiResponseV1 DeleteMemberAvatar (long id, long avatarId)

delete a member avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteMemberAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var avatarId = 789L;  // long | Avatar id

            try
            {
                // delete a member avatar
                ApiResponseV1 result = apiInstance.DeleteMemberAvatar(id, avatarId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.DeleteMemberAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMemberAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a member avatar
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteMemberAvatarWithHttpInfo(id, avatarId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.DeleteMemberAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **avatarId** | **long** | Avatar id |  |

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
| **200** | Avatar was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member or avatar not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletememberchangerequest"></a>
# **DeleteMemberChangeRequest**
> ApiResponseV1 DeleteMemberChangeRequest (long id, long requestId)

add a change request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteMemberChangeRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var requestId = 789L;  // long | Change request id

            try
            {
                // add a change request
                ApiResponseV1 result = apiInstance.DeleteMemberChangeRequest(id, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.DeleteMemberChangeRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMemberChangeRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a change request
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteMemberChangeRequestWithHttpInfo(id, requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.DeleteMemberChangeRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **requestId** | **long** | Change request id |  |

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
| **200** | Change request was deleted |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Record not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteusergroup"></a>
# **DeleteUserGroup**
> ApiResponseV1 DeleteUserGroup (string id)

delete a user group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = "id_example";  // string | id of user group

            try
            {
                // delete a user group
                ApiResponseV1 result = apiInstance.DeleteUserGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.DeleteUserGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a user group
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteUserGroupWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.DeleteUserGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | id of user group |  |

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
| **200** | User group was deleted |  -  |
| **401** | User does not have correct role |  -  |
| **404** | user group not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rejectmemberupgrade"></a>
# **RejectMemberUpgrade**
> ApiResponseV1 RejectMemberUpgrade (long id)

reject a member upgrade

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RejectMemberUpgradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 56;  // long | Member id

            try
            {
                // reject a member upgrade
                ApiResponseV1 result = apiInstance.RejectMemberUpgrade(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RejectMemberUpgrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RejectMemberUpgradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // reject a member upgrade
    ApiResponse<ApiResponseV1> response = apiInstance.RejectMemberUpgradeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RejectMemberUpgradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

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
| **200** | Member upgrade was rejected |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removemembergenrefilter"></a>
# **RemoveMemberGenreFilter**
> ApiResponseV1 RemoveMemberGenreFilter (long id, long genreId)

remove a filter for a genre for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveMemberGenreFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var genreId = 56;  // long | genre id

            try
            {
                // remove a filter for a genre for a user
                ApiResponseV1 result = apiInstance.RemoveMemberGenreFilter(id, genreId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RemoveMemberGenreFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMemberGenreFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a filter for a genre for a user
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveMemberGenreFilterWithHttpInfo(id, genreId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RemoveMemberGenreFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **genreId** | **long** | genre id |  |

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
| **200** | Filter was removed |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removemembergenrehighlight"></a>
# **RemoveMemberGenreHighlight**
> ApiResponseV1 RemoveMemberGenreHighlight (long id, long genreId)

remove a highlight for a genre for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveMemberGenreHighlightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var genreId = 56;  // long | genre id

            try
            {
                // remove a highlight for a genre for a user
                ApiResponseV1 result = apiInstance.RemoveMemberGenreHighlight(id, genreId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RemoveMemberGenreHighlight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMemberGenreHighlightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a highlight for a genre for a user
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveMemberGenreHighlightWithHttpInfo(id, genreId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RemoveMemberGenreHighlightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **genreId** | **long** | genre id |  |

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
| **200** | Highlight was removed |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeusergroupfilter"></a>
# **RemoveUserGroupFilter**
> ApiResponseV1 RemoveUserGroupFilter (long id, long groupId)

remove a filter for a group for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveUserGroupFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var groupId = 56;  // long | group id

            try
            {
                // remove a filter for a group for a user
                ApiResponseV1 result = apiInstance.RemoveUserGroupFilter(id, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RemoveUserGroupFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveUserGroupFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a filter for a group for a user
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveUserGroupFilterWithHttpInfo(id, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RemoveUserGroupFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **groupId** | **long** | group id |  |

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
| **200** | Filter was removed |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeusertopicsubscription"></a>
# **RemoveUserTopicSubscription**
> ApiResponseV1 RemoveUserTopicSubscription (long id, long topicId)

remove a topic subscription for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveUserTopicSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member
            var topicId = 56;  // long | topic id

            try
            {
                // remove a topic subscription for a user
                ApiResponseV1 result = apiInstance.RemoveUserTopicSubscription(id, topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RemoveUserTopicSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveUserTopicSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a topic subscription for a user
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveUserTopicSubscriptionWithHttpInfo(id, topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RemoveUserTopicSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |
| **topicId** | **long** | topic id |  |

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
| **200** | Topic subscription was removed |  -  |
| **400** | Service or validation error |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resetgenresettings"></a>
# **ResetGenreSettings**
> ApiResponseV1 ResetGenreSettings (long id)

reset genre highlights and filters for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ResetGenreSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | id of member

            try
            {
                // reset genre highlights and filters for a user
                ApiResponseV1 result = apiInstance.ResetGenreSettings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.ResetGenreSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetGenreSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // reset genre highlights and filters for a user
    ApiResponse<ApiResponseV1> response = apiInstance.ResetGenreSettingsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.ResetGenreSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of member |  |

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
| **200** | Filters and highlights were reset |  -  |
| **401** | Member does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemember"></a>
# **RetrieveMember**
> UserModelV1 RetrieveMember (long id, bool? unrenderedFields = null)

get a specific members

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get a specific members
                UserModelV1 result = apiInstance.RetrieveMember(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a specific members
    ApiResponse<UserModelV1> response = apiInstance.RetrieveMemberWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**UserModelV1**](UserModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Member not found |  -  |
| **200** | Return user record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievememberavatars"></a>
# **RetrieveMemberAvatars**
> List&lt;AvatarModelV1&gt; RetrieveMemberAvatars (long id)

get avatars for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberAvatarsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // get avatars for a specific user
                List<AvatarModelV1> result = apiInstance.RetrieveMemberAvatars(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberAvatars: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberAvatarsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get avatars for a specific user
    ApiResponse<List<AvatarModelV1>> response = apiInstance.RetrieveMemberAvatarsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberAvatarsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

### Return type

[**List&lt;AvatarModelV1&gt;**](AvatarModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Member not found |  -  |
| **200** | Return user record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievememberchangerequest"></a>
# **RetrieveMemberChangeRequest**
> UserChangeRequestModelV1 RetrieveMemberChangeRequest (long id, long requestId)

get change requests for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberChangeRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var requestId = 789L;  // long | Change request id

            try
            {
                // get change requests for a specific user
                UserChangeRequestModelV1 result = apiInstance.RetrieveMemberChangeRequest(id, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberChangeRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberChangeRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get change requests for a specific user
    ApiResponse<UserChangeRequestModelV1> response = apiInstance.RetrieveMemberChangeRequestWithHttpInfo(id, requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberChangeRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **requestId** | **long** | Change request id |  |

### Return type

[**UserChangeRequestModelV1**](UserChangeRequestModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Record not found |  -  |
| **200** | Return member change requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemembergenrefilters"></a>
# **RetrieveMemberGenreFilters**
> List&lt;UserGenreFilterModelV1&gt; RetrieveMemberGenreFilters (long id)

get genre filters for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberGenreFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // get genre filters for a specific user
                List<UserGenreFilterModelV1> result = apiInstance.RetrieveMemberGenreFilters(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberGenreFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberGenreFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get genre filters for a specific user
    ApiResponse<List<UserGenreFilterModelV1>> response = apiInstance.RetrieveMemberGenreFiltersWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberGenreFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

### Return type

[**List&lt;UserGenreFilterModelV1&gt;**](UserGenreFilterModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |
| **200** | Return member filter records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemembergenrehighlights"></a>
# **RetrieveMemberGenreHighlights**
> List&lt;UserGenreHighlightModelV1&gt; RetrieveMemberGenreHighlights (long id)

get highlights for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberGenreHighlightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // get highlights for a specific user
                List<UserGenreHighlightModelV1> result = apiInstance.RetrieveMemberGenreHighlights(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberGenreHighlights: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberGenreHighlightsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get highlights for a specific user
    ApiResponse<List<UserGenreHighlightModelV1>> response = apiInstance.RetrieveMemberGenreHighlightsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberGenreHighlightsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

### Return type

[**List&lt;UserGenreHighlightModelV1&gt;**](UserGenreHighlightModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |
| **200** | Return member highlight records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemembergroupfilters"></a>
# **RetrieveMemberGroupFilters**
> List&lt;UserGroupFilterModelV1&gt; RetrieveMemberGroupFilters (long id)

get group filters for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberGroupFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // get group filters for a specific user
                List<UserGroupFilterModelV1> result = apiInstance.RetrieveMemberGroupFilters(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberGroupFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberGroupFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get group filters for a specific user
    ApiResponse<List<UserGroupFilterModelV1>> response = apiInstance.RetrieveMemberGroupFiltersWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberGroupFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

### Return type

[**List&lt;UserGroupFilterModelV1&gt;**](UserGroupFilterModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |
| **200** | Return member filter records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemembertopicsubscription"></a>
# **RetrieveMemberTopicSubscription**
> UserSubscribedTopicModelV1 RetrieveMemberTopicSubscription (long id, long topicId)

get a subscription to a specific topic for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberTopicSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var topicId = 789L;  // long | Topic id

            try
            {
                // get a subscription to a specific topic for a user
                UserSubscribedTopicModelV1 result = apiInstance.RetrieveMemberTopicSubscription(id, topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberTopicSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberTopicSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get a subscription to a specific topic for a user
    ApiResponse<UserSubscribedTopicModelV1> response = apiInstance.RetrieveMemberTopicSubscriptionWithHttpInfo(id, topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberTopicSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **topicId** | **long** | Topic id |  |

### Return type

[**UserSubscribedTopicModelV1**](UserSubscribedTopicModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Member or subscription not found |  -  |
| **200** | Return member topic subscriptions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemembertopicsubscriptions"></a>
# **RetrieveMemberTopicSubscriptions**
> List&lt;UserSubscribedTopicModelV1&gt; RetrieveMemberTopicSubscriptions (long id)

get topic subscriptions for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveMemberTopicSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // get topic subscriptions for a specific user
                List<UserSubscribedTopicModelV1> result = apiInstance.RetrieveMemberTopicSubscriptions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveMemberTopicSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMemberTopicSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get topic subscriptions for a specific user
    ApiResponse<List<UserSubscribedTopicModelV1>> response = apiInstance.RetrieveMemberTopicSubscriptionsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveMemberTopicSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |

### Return type

[**List&lt;UserSubscribedTopicModelV1&gt;**](UserSubscribedTopicModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |
| **200** | Return member topic subscriptions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveusergroupbyid"></a>
# **RetrieveUserGroupById**
> UserGroupModelV1 RetrieveUserGroupById (string id, bool? unrenderedFields = null)

get user group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveUserGroupByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = "id_example";  // string | user group id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // get user group
                UserGroupModelV1 result = apiInstance.RetrieveUserGroupById(id, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveUserGroupById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveUserGroupByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get user group
    ApiResponse<UserGroupModelV1> response = apiInstance.RetrieveUserGroupByIdWithHttpInfo(id, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveUserGroupByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | user group id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**UserGroupModelV1**](UserGroupModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return user group |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveusergroups"></a>
# **RetrieveUserGroups**
> List&lt;UserGroupModelV1&gt; RetrieveUserGroups ()

get user groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveUserGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);

            try
            {
                // get user groups
                List<UserGroupModelV1> result = apiInstance.RetrieveUserGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.RetrieveUserGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveUserGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get user groups
    ApiResponse<List<UserGroupModelV1>> response = apiInstance.RetrieveUserGroupsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.RetrieveUserGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserGroupModelV1&gt;**](UserGroupModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return User Groups |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchmemberchangerequests"></a>
# **SearchMemberChangeRequests**
> UserChangeRequestSearchResponseV1 SearchMemberChangeRequests (long id, long? page = null, long? perpage = null, string orderby = null, string asc = null)

search change requests for a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchMemberChangeRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var page = 56;  // long? | Start page (optional) 
            var perpage = 56;  // long? | Items per page (optional) 
            var orderby = "score";  // string | order by field (optional)  (default to time)
            var asc = "asc";  // string | Direction of results (optional)  (default to asc)

            try
            {
                // search change requests for a specific user
                UserChangeRequestSearchResponseV1 result = apiInstance.SearchMemberChangeRequests(id, page, perpage, orderby, asc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.SearchMemberChangeRequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchMemberChangeRequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search change requests for a specific user
    ApiResponse<UserChangeRequestSearchResponseV1> response = apiInstance.SearchMemberChangeRequestsWithHttpInfo(id, page, perpage, orderby, asc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.SearchMemberChangeRequestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **page** | **long?** | Start page | [optional]  |
| **perpage** | **long?** | Items per page | [optional]  |
| **orderby** | **string** | order by field | [optional] [default to time] |
| **asc** | **string** | Direction of results | [optional] [default to asc] |

### Return type

[**UserChangeRequestSearchResponseV1**](UserChangeRequestSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | User does not have permission |  -  |
| **404** | Record not found |  -  |
| **200** | Return member change requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchmemberspost"></a>
# **SearchMembersPost**
> UserSearchResponseV1 SearchMembersPost (UserSearchRequestV1 userSearchRequestV1)

search members

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchMembersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var userSearchRequestV1 = new UserSearchRequestV1(); // UserSearchRequestV1 | 

            try
            {
                // search members
                UserSearchResponseV1 result = apiInstance.SearchMembersPost(userSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.SearchMembersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchMembersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search members
    ApiResponse<UserSearchResponseV1> response = apiInstance.SearchMembersPostWithHttpInfo(userSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.SearchMembersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSearchRequestV1** | [**UserSearchRequestV1**](UserSearchRequestV1.md) |  |  |

### Return type

[**UserSearchResponseV1**](UserSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return user records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemember"></a>
# **UpdateMember**
> ApiResponseV1 UpdateMember (long id, UserModelUpdateV1 userModelUpdateV1)

update a member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 56;  // long | Member id
            var userModelUpdateV1 = new UserModelUpdateV1(); // UserModelUpdateV1 | 

            try
            {
                // update a member
                ApiResponseV1 result = apiInstance.UpdateMember(id, userModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.UpdateMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a member
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateMemberWithHttpInfo(id, userModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.UpdateMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **userModelUpdateV1** | [**UserModelUpdateV1**](UserModelUpdateV1.md) |  |  |

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
| **200** | Member was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Member not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatememberchangerequest"></a>
# **UpdateMemberChangeRequest**
> ApiResponseV1 UpdateMemberChangeRequest (long id, long requestId, UserChangeRequestModelUpdateV1 userChangeRequestModelUpdateV1)

update a change request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateMemberChangeRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MembersApi(config);
            var id = 789L;  // long | Member id
            var requestId = 789L;  // long | Change request id
            var userChangeRequestModelUpdateV1 = new UserChangeRequestModelUpdateV1(); // UserChangeRequestModelUpdateV1 | 

            try
            {
                // update a change request
                ApiResponseV1 result = apiInstance.UpdateMemberChangeRequest(id, requestId, userChangeRequestModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MembersApi.UpdateMemberChangeRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMemberChangeRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a change request
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateMemberChangeRequestWithHttpInfo(id, requestId, userChangeRequestModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MembersApi.UpdateMemberChangeRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Member id |  |
| **requestId** | **long** | Change request id |  |
| **userChangeRequestModelUpdateV1** | [**UserChangeRequestModelUpdateV1**](UserChangeRequestModelUpdateV1.md) |  |  |

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
| **200** | Change request was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User does not have permission |  -  |
| **404** | Record not found |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

