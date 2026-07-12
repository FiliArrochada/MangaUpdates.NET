# MangaUpdates.Api.ForumApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddForumAdmin**](ForumApi.md#addforumadmin) | **PUT** /forums/{forum_id}/admins/{user_id} | add a forum admin |
| [**AddPollVote**](ForumApi.md#addpollvote) | **POST** /forums/{forum_id}/topics/{topic_id}/poll/vote/{choice_id} | add a vote to a forum poll |
| [**AddPost**](ForumApi.md#addpost) | **POST** /forums/{forum_id}/topics/{topic_id} | add a forum post |
| [**AddTemporaryPollImage**](ForumApi.md#addtemporarypollimage) | **POST** /forums/temp_poll_images | add a temporary poll image |
| [**AddTopic**](ForumApi.md#addtopic) | **POST** /forums/{forum_id} | add a forum topic |
| [**DeletePost**](ForumApi.md#deletepost) | **DELETE** /forums/{forum_id}/topics/{topic_id}/posts/{post_id} | delete a post |
| [**DeletePostReport**](ForumApi.md#deletepostreport) | **DELETE** /forums/{forum_id}/topics/{topic_id}/posts/{post_id}/report | delete a post report |
| [**DeleteTopic**](ForumApi.md#deletetopic) | **DELETE** /forums/{forum_id}/topics/{topic_id} | delete a topic |
| [**GetCurrentWarnForUser**](ForumApi.md#getcurrentwarnforuser) | **GET** /forums/warn/{user_id} | gets the current warn status for user |
| [**ListCategories**](ForumApi.md#listcategories) | **GET** /forums | show forum categories and forums |
| [**ListGlobalTopics**](ForumApi.md#listglobaltopics) | **GET** /forums/global | list global topics |
| [**ListPopularForums**](ForumApi.md#listpopularforums) | **GET** /forums/popular | show popular forums |
| [**ListPosts**](ForumApi.md#listposts) | **POST** /forums/{forum_id}/topics/{topic_id}/list | list posts in topic |
| [**ListPostsByMe**](ForumApi.md#listpostsbyme) | **GET** /forums/{forum_id}/topics/{topic_id}/my_posts | list posts in topic that I made |
| [**ListReportedPosts**](ForumApi.md#listreportedposts) | **GET** /forums/report | show reported posts |
| [**ListTopics**](ForumApi.md#listtopics) | **POST** /forums/{forum_id}/list | list topics |
| [**ListWarnHistoryForUser**](ForumApi.md#listwarnhistoryforuser) | **GET** /forums/warn/{user_id}/history | show warn history for a user |
| [**LookupPost**](ForumApi.md#lookuppost) | **GET** /forums/lookup/post/{post_id} | lookup a post to find the forum and topic id |
| [**LookupSeries**](ForumApi.md#lookupseries) | **GET** /forums/lookup/series/{series_id} | lookup a series to find the forum id |
| [**LookupTopic**](ForumApi.md#lookuptopic) | **GET** /forums/lookup/topic/{topic_id} | lookup a topic to find the forum id |
| [**RemoveForumAdmin**](ForumApi.md#removeforumadmin) | **DELETE** /forums/{forum_id}/admins/{user_id} | remove a forum admin |
| [**ReportPost**](ForumApi.md#reportpost) | **POST** /forums/{forum_id}/topics/{topic_id}/posts/{post_id}/report | report a forum post |
| [**RetrieveForum**](ForumApi.md#retrieveforum) | **GET** /forums/{forum_id} | retrieve a forum |
| [**RetrievePost**](ForumApi.md#retrievepost) | **GET** /forums/{forum_id}/topics/{topic_id}/posts/{post_id} | retrieve a forum post |
| [**RetrievePostLocation**](ForumApi.md#retrievepostlocation) | **GET** /forums/{forum_id}/topics/{topic_id}/posts/{post_id}/location | retrieve a forum post location within topic |
| [**RetrieveTemporaryPollImages**](ForumApi.md#retrievetemporarypollimages) | **GET** /forums/temp_poll_images | retrieve temporary poll images |
| [**RetrieveTopic**](ForumApi.md#retrievetopic) | **GET** /forums/{forum_id}/topics/{topic_id} | retrieve a forum topic |
| [**RetrieveVote**](ForumApi.md#retrievevote) | **GET** /forums/{forum_id}/topics/{topic_id}/poll/vote | retrieve my vote from the poll |
| [**SearchForumPost**](ForumApi.md#searchforumpost) | **POST** /forums/search | search forum |
| [**SearchSpecificForumPost**](ForumApi.md#searchspecificforumpost) | **POST** /forums/{forum_id}/search | search specific forum |
| [**SearchSpecificTopicPost**](ForumApi.md#searchspecifictopicpost) | **POST** /forums/{forum_id}/topics/{topic_id}/search | search specific topic |
| [**ShowLogPost**](ForumApi.md#showlogpost) | **POST** /forums/log | show forum admin log |
| [**UpdatePost**](ForumApi.md#updatepost) | **PATCH** /forums/{forum_id}/topics/{topic_id}/posts/{post_id} | update a forum post |
| [**UpdateTopic**](ForumApi.md#updatetopic) | **PATCH** /forums/{forum_id}/topics/{topic_id} | update a forum topic |
| [**UpdateTopicPoll**](ForumApi.md#updatetopicpoll) | **PATCH** /forums/{forum_id}/topics/{topic_id}/poll | update a forum topic poll (if present) |
| [**UpdateUserWarnLevel**](ForumApi.md#updateuserwarnlevel) | **PUT** /forums/warn/{user_id} | update a user warn level |

<a id="addforumadmin"></a>
# **AddForumAdmin**
> ApiResponseV1 AddForumAdmin (long forumId, long userId)

add a forum admin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddForumAdminExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var userId = 56;  // long | User id

            try
            {
                // add a forum admin
                ApiResponseV1 result = apiInstance.AddForumAdmin(forumId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.AddForumAdmin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddForumAdminWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a forum admin
    ApiResponse<ApiResponseV1> response = apiInstance.AddForumAdminWithHttpInfo(forumId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.AddForumAdminWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **userId** | **long** | User id |  |

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
| **200** | Forum admin was added |  -  |
| **401** | User does not have correct role |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addpollvote"></a>
# **AddPollVote**
> ApiResponseV1 AddPollVote (long forumId, long topicId, long choiceId)

add a vote to a forum poll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddPollVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var choiceId = 56;  // long | Choice id

            try
            {
                // add a vote to a forum poll
                ApiResponseV1 result = apiInstance.AddPollVote(forumId, topicId, choiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.AddPollVote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPollVoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a vote to a forum poll
    ApiResponse<ApiResponseV1> response = apiInstance.AddPollVoteWithHttpInfo(forumId, topicId, choiceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.AddPollVoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **choiceId** | **long** | Choice id |  |

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
| **200** | Poll vote was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User is under a warn restriction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addpost"></a>
# **AddPost**
> ApiResponseV1 AddPost (long forumId, long topicId, ForumPostModelUpdateV1 forumPostModelUpdateV1)

add a forum post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var forumPostModelUpdateV1 = new ForumPostModelUpdateV1(); // ForumPostModelUpdateV1 | 

            try
            {
                // add a forum post
                ApiResponseV1 result = apiInstance.AddPost(forumId, topicId, forumPostModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.AddPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a forum post
    ApiResponse<ApiResponseV1> response = apiInstance.AddPostWithHttpInfo(forumId, topicId, forumPostModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.AddPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **forumPostModelUpdateV1** | [**ForumPostModelUpdateV1**](ForumPostModelUpdateV1.md) |  |  |

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
| **200** | Forum post was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User is under a warn restriction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addtemporarypollimage"></a>
# **AddTemporaryPollImage**
> ApiResponseV1 AddTemporaryPollImage (System.IO.Stream? image = null, string? caption = null)

add a temporary poll image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddTemporaryPollImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | Image to update (optional) 
            var caption = "caption_example";  // string? | Image caption (optional) 

            try
            {
                // add a temporary poll image
                ApiResponseV1 result = apiInstance.AddTemporaryPollImage(image, caption);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.AddTemporaryPollImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTemporaryPollImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a temporary poll image
    ApiResponse<ApiResponseV1> response = apiInstance.AddTemporaryPollImageWithHttpInfo(image, caption);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.AddTemporaryPollImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **image** | **System.IO.Stream?****System.IO.Stream?** | Image to update | [optional]  |
| **caption** | **string?** | Image caption | [optional]  |

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
| **403** | User is under a warn restriction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addtopic"></a>
# **AddTopic**
> ApiResponseV1 AddTopic (long forumId, ForumTopicModelAddV1 forumTopicModelAddV1)

add a forum topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var forumTopicModelAddV1 = new ForumTopicModelAddV1(); // ForumTopicModelAddV1 | 

            try
            {
                // add a forum topic
                ApiResponseV1 result = apiInstance.AddTopic(forumId, forumTopicModelAddV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.AddTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a forum topic
    ApiResponse<ApiResponseV1> response = apiInstance.AddTopicWithHttpInfo(forumId, forumTopicModelAddV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.AddTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **forumTopicModelAddV1** | [**ForumTopicModelAddV1**](ForumTopicModelAddV1.md) |  |  |

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
| **200** | Forum topic was added |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User is under a warn restriction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepost"></a>
# **DeletePost**
> ApiResponseV1 DeletePost (long forumId, long topicId, long postId)

delete a post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var postId = 56;  // long | Post id

            try
            {
                // delete a post
                ApiResponseV1 result = apiInstance.DeletePost(forumId, topicId, postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.DeletePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a post
    ApiResponse<ApiResponseV1> response = apiInstance.DeletePostWithHttpInfo(forumId, topicId, postId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.DeletePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **postId** | **long** | Post id |  |

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
| **200** | Post delete transaction submitted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepostreport"></a>
# **DeletePostReport**
> ApiResponseV1 DeletePostReport (long forumId, long topicId, long postId)

delete a post report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeletePostReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var postId = 56;  // long | Post id

            try
            {
                // delete a post report
                ApiResponseV1 result = apiInstance.DeletePostReport(forumId, topicId, postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.DeletePostReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePostReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a post report
    ApiResponse<ApiResponseV1> response = apiInstance.DeletePostReportWithHttpInfo(forumId, topicId, postId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.DeletePostReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **postId** | **long** | Post id |  |

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
| **200** | Post report was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetopic"></a>
# **DeleteTopic**
> ApiResponseV1 DeleteTopic (long forumId, long topicId)

delete a topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id

            try
            {
                // delete a topic
                ApiResponseV1 result = apiInstance.DeleteTopic(forumId, topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.DeleteTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete a topic
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteTopicWithHttpInfo(forumId, topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.DeleteTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |

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
| **200** | Topic delete transaction submitted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentwarnforuser"></a>
# **GetCurrentWarnForUser**
> ForumWarnModelV1 GetCurrentWarnForUser (long userId)

gets the current warn status for user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class GetCurrentWarnForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var userId = 56;  // long | User id

            try
            {
                // gets the current warn status for user
                ForumWarnModelV1 result = apiInstance.GetCurrentWarnForUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.GetCurrentWarnForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentWarnForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // gets the current warn status for user
    ApiResponse<ForumWarnModelV1> response = apiInstance.GetCurrentWarnForUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.GetCurrentWarnForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | User id |  |

### Return type

[**ForumWarnModelV1**](ForumWarnModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Warn status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcategories"></a>
# **ListCategories**
> List&lt;ForumCategoryModelListV1&gt; ListCategories ()

show forum categories and forums

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);

            try
            {
                // show forum categories and forums
                List<ForumCategoryModelListV1> result = apiInstance.ListCategories();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // show forum categories and forums
    ApiResponse<List<ForumCategoryModelListV1>> response = apiInstance.ListCategoriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ForumCategoryModelListV1&gt;**](ForumCategoryModelListV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of forums |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listglobaltopics"></a>
# **ListGlobalTopics**
> ForumTopicListResponseV1 ListGlobalTopics ()

list global topics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListGlobalTopicsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);

            try
            {
                // list global topics
                ForumTopicListResponseV1 result = apiInstance.ListGlobalTopics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListGlobalTopics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListGlobalTopicsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // list global topics
    ApiResponse<ForumTopicListResponseV1> response = apiInstance.ListGlobalTopicsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListGlobalTopicsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ForumTopicListResponseV1**](ForumTopicListResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return topic records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpopularforums"></a>
# **ListPopularForums**
> List&lt;ForumForumModelListV1&gt; ListPopularForums ()

show popular forums

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListPopularForumsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);

            try
            {
                // show popular forums
                List<ForumForumModelListV1> result = apiInstance.ListPopularForums();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListPopularForums: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPopularForumsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // show popular forums
    ApiResponse<List<ForumForumModelListV1>> response = apiInstance.ListPopularForumsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListPopularForumsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ForumForumModelListV1&gt;**](ForumForumModelListV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of forums |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listposts"></a>
# **ListPosts**
> ForumPostListResponseV1 ListPosts (long forumId, long topicId, PerPageSearchRequestV1 perPageSearchRequestV1)

list posts in topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListPostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var perPageSearchRequestV1 = new PerPageSearchRequestV1(); // PerPageSearchRequestV1 | 

            try
            {
                // list posts in topic
                ForumPostListResponseV1 result = apiInstance.ListPosts(forumId, topicId, perPageSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListPosts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPostsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // list posts in topic
    ApiResponse<ForumPostListResponseV1> response = apiInstance.ListPostsWithHttpInfo(forumId, topicId, perPageSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListPostsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **perPageSearchRequestV1** | [**PerPageSearchRequestV1**](PerPageSearchRequestV1.md) |  |  |

### Return type

[**ForumPostListResponseV1**](ForumPostListResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return post records |  -  |
| **400** | Validation or service error |  -  |
| **404** | Forum or topic not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpostsbyme"></a>
# **ListPostsByMe**
> ForumPostByUserResponseV1 ListPostsByMe (long forumId, long topicId)

list posts in topic that I made

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListPostsByMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id

            try
            {
                // list posts in topic that I made
                ForumPostByUserResponseV1 result = apiInstance.ListPostsByMe(forumId, topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListPostsByMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPostsByMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // list posts in topic that I made
    ApiResponse<ForumPostByUserResponseV1> response = apiInstance.ListPostsByMeWithHttpInfo(forumId, topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListPostsByMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |

### Return type

[**ForumPostByUserResponseV1**](ForumPostByUserResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return post id list |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreportedposts"></a>
# **ListReportedPosts**
> List&lt;ForumPostReportModelV1&gt; ListReportedPosts ()

show reported posts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListReportedPostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);

            try
            {
                // show reported posts
                List<ForumPostReportModelV1> result = apiInstance.ListReportedPosts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListReportedPosts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReportedPostsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // show reported posts
    ApiResponse<List<ForumPostReportModelV1>> response = apiInstance.ListReportedPostsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListReportedPostsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ForumPostReportModelV1&gt;**](ForumPostReportModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return Reported Posts |  -  |
| **401** | User does not have appropriate role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtopics"></a>
# **ListTopics**
> ForumTopicListResponseV1 ListTopics (long forumId, ForumTopicListRequestV1 forumTopicListRequestV1, bool? withFirstPost = null)

list topics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListTopicsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var forumTopicListRequestV1 = new ForumTopicListRequestV1(); // ForumTopicListRequestV1 | 
            var withFirstPost = true;  // bool? | Also return the first post of each topic (optional) 

            try
            {
                // list topics
                ForumTopicListResponseV1 result = apiInstance.ListTopics(forumId, forumTopicListRequestV1, withFirstPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListTopics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTopicsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // list topics
    ApiResponse<ForumTopicListResponseV1> response = apiInstance.ListTopicsWithHttpInfo(forumId, forumTopicListRequestV1, withFirstPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListTopicsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **forumTopicListRequestV1** | [**ForumTopicListRequestV1**](ForumTopicListRequestV1.md) |  |  |
| **withFirstPost** | **bool?** | Also return the first post of each topic | [optional]  |

### Return type

[**ForumTopicListResponseV1**](ForumTopicListResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return topic records |  -  |
| **400** | Validation or service error |  -  |
| **404** | Forum not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listwarnhistoryforuser"></a>
# **ListWarnHistoryForUser**
> List&lt;ForumWarnModelV1&gt; ListWarnHistoryForUser (long userId)

show warn history for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ListWarnHistoryForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var userId = 56;  // long | User id

            try
            {
                // show warn history for a user
                List<ForumWarnModelV1> result = apiInstance.ListWarnHistoryForUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ListWarnHistoryForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWarnHistoryForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // show warn history for a user
    ApiResponse<List<ForumWarnModelV1>> response = apiInstance.ListWarnHistoryForUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ListWarnHistoryForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | User id |  |

### Return type

[**List&lt;ForumWarnModelV1&gt;**](ForumWarnModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Warn history |  -  |
| **401** | User does not have appropriate role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lookuppost"></a>
# **LookupPost**
> ForumLookupResponseV1 LookupPost (long postId)

lookup a post to find the forum and topic id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class LookupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var postId = 56;  // long | Post id

            try
            {
                // lookup a post to find the forum and topic id
                ForumLookupResponseV1 result = apiInstance.LookupPost(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.LookupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LookupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // lookup a post to find the forum and topic id
    ApiResponse<ForumLookupResponseV1> response = apiInstance.LookupPostWithHttpInfo(postId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.LookupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postId** | **long** | Post id |  |

### Return type

[**ForumLookupResponseV1**](ForumLookupResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post lookup response |  -  |
| **404** | Post not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lookupseries"></a>
# **LookupSeries**
> ForumLookupResponseV1 LookupSeries (long seriesId)

lookup a series to find the forum id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class LookupSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var seriesId = 56;  // long | Series id

            try
            {
                // lookup a series to find the forum id
                ForumLookupResponseV1 result = apiInstance.LookupSeries(seriesId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.LookupSeries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LookupSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // lookup a series to find the forum id
    ApiResponse<ForumLookupResponseV1> response = apiInstance.LookupSeriesWithHttpInfo(seriesId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.LookupSeriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seriesId** | **long** | Series id |  |

### Return type

[**ForumLookupResponseV1**](ForumLookupResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Series lookup response |  -  |
| **404** | Series or forum not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lookuptopic"></a>
# **LookupTopic**
> ForumLookupResponseV1 LookupTopic (long topicId)

lookup a topic to find the forum id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class LookupTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var topicId = 56;  // long | Topic id

            try
            {
                // lookup a topic to find the forum id
                ForumLookupResponseV1 result = apiInstance.LookupTopic(topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.LookupTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LookupTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // lookup a topic to find the forum id
    ApiResponse<ForumLookupResponseV1> response = apiInstance.LookupTopicWithHttpInfo(topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.LookupTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **topicId** | **long** | Topic id |  |

### Return type

[**ForumLookupResponseV1**](ForumLookupResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Topic lookup response |  -  |
| **404** | Topic not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeforumadmin"></a>
# **RemoveForumAdmin**
> ApiResponseV1 RemoveForumAdmin (long forumId, long userId)

remove a forum admin

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RemoveForumAdminExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var userId = 56;  // long | User id

            try
            {
                // remove a forum admin
                ApiResponseV1 result = apiInstance.RemoveForumAdmin(forumId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RemoveForumAdmin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveForumAdminWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a forum admin
    ApiResponse<ApiResponseV1> response = apiInstance.RemoveForumAdminWithHttpInfo(forumId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RemoveForumAdminWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **userId** | **long** | User id |  |

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
| **200** | Forum admin was removed |  -  |
| **401** | User does not have correct role |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reportpost"></a>
# **ReportPost**
> ApiResponseV1 ReportPost (long forumId, long topicId, long postId, ForumPostReportModelUpdateV1 forumPostReportModelUpdateV1)

report a forum post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ReportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var postId = 56;  // long | Post id
            var forumPostReportModelUpdateV1 = new ForumPostReportModelUpdateV1(); // ForumPostReportModelUpdateV1 | 

            try
            {
                // report a forum post
                ApiResponseV1 result = apiInstance.ReportPost(forumId, topicId, postId, forumPostReportModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ReportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // report a forum post
    ApiResponse<ApiResponseV1> response = apiInstance.ReportPostWithHttpInfo(forumId, topicId, postId, forumPostReportModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ReportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **postId** | **long** | Post id |  |
| **forumPostReportModelUpdateV1** | [**ForumPostReportModelUpdateV1**](ForumPostReportModelUpdateV1.md) |  |  |

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
| **200** | Forum post was reported |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User is under a warn restriction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveforum"></a>
# **RetrieveForum**
> ForumForumModelV1 RetrieveForum (long forumId, bool? unrenderedFields = null)

retrieve a forum

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveForumExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // retrieve a forum
                ForumForumModelV1 result = apiInstance.RetrieveForum(forumId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RetrieveForum: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveForumWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve a forum
    ApiResponse<ForumForumModelV1> response = apiInstance.RetrieveForumWithHttpInfo(forumId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RetrieveForumWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ForumForumModelV1**](ForumForumModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return topic record |  -  |
| **404** | Forum not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepost"></a>
# **RetrievePost**
> ForumPostModelV1 RetrievePost (long forumId, long topicId, long postId, bool? unrenderedFields = null)

retrieve a forum post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var postId = 56;  // long | Post id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // retrieve a forum post
                ForumPostModelV1 result = apiInstance.RetrievePost(forumId, topicId, postId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RetrievePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve a forum post
    ApiResponse<ForumPostModelV1> response = apiInstance.RetrievePostWithHttpInfo(forumId, topicId, postId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RetrievePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **postId** | **long** | Post id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ForumPostModelV1**](ForumPostModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return post record |  -  |
| **404** | Post not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepostlocation"></a>
# **RetrievePostLocation**
> ApiResponseV1 RetrievePostLocation (long forumId, long topicId, long postId)

retrieve a forum post location within topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePostLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var postId = 56;  // long | Post id

            try
            {
                // retrieve a forum post location within topic
                ApiResponseV1 result = apiInstance.RetrievePostLocation(forumId, topicId, postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RetrievePostLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePostLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve a forum post location within topic
    ApiResponse<ApiResponseV1> response = apiInstance.RetrievePostLocationWithHttpInfo(forumId, topicId, postId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RetrievePostLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **postId** | **long** | Post id |  |

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
| **200** | Return post record |  -  |
| **404** | Post not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievetemporarypollimages"></a>
# **RetrieveTemporaryPollImages**
> List&lt;ForumPollTempImageModelV1&gt; RetrieveTemporaryPollImages ()

retrieve temporary poll images

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveTemporaryPollImagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);

            try
            {
                // retrieve temporary poll images
                List<ForumPollTempImageModelV1> result = apiInstance.RetrieveTemporaryPollImages();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RetrieveTemporaryPollImages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveTemporaryPollImagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve temporary poll images
    ApiResponse<List<ForumPollTempImageModelV1>> response = apiInstance.RetrieveTemporaryPollImagesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RetrieveTemporaryPollImagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ForumPollTempImageModelV1&gt;**](ForumPollTempImageModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return image records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievetopic"></a>
# **RetrieveTopic**
> ForumTopicModelV1 RetrieveTopic (long forumId, long topicId, bool? unrenderedFields = null)

retrieve a forum topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var unrenderedFields = true;  // bool? | Output fields in unrendered form for editing (optional) 

            try
            {
                // retrieve a forum topic
                ForumTopicModelV1 result = apiInstance.RetrieveTopic(forumId, topicId, unrenderedFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RetrieveTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve a forum topic
    ApiResponse<ForumTopicModelV1> response = apiInstance.RetrieveTopicWithHttpInfo(forumId, topicId, unrenderedFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RetrieveTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **unrenderedFields** | **bool?** | Output fields in unrendered form for editing | [optional]  |

### Return type

[**ForumTopicModelV1**](ForumTopicModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return topic record |  -  |
| **404** | Topic not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievevote"></a>
# **RetrieveVote**
> ForumPollVoteModelV1 RetrieveVote (long forumId, long topicId)

retrieve my vote from the poll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveVoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id

            try
            {
                // retrieve my vote from the poll
                ForumPollVoteModelV1 result = apiInstance.RetrieveVote(forumId, topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.RetrieveVote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveVoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve my vote from the poll
    ApiResponse<ForumPollVoteModelV1> response = apiInstance.RetrieveVoteWithHttpInfo(forumId, topicId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.RetrieveVoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |

### Return type

[**ForumPollVoteModelV1**](ForumPollVoteModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return poll vote record |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Poll or vote not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchforumpost"></a>
# **SearchForumPost**
> ForumSearchResponseV1 SearchForumPost (ForumSearchRequestV1 forumSearchRequestV1)

search forum

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchForumPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumSearchRequestV1 = new ForumSearchRequestV1(); // ForumSearchRequestV1 | 

            try
            {
                // search forum
                ForumSearchResponseV1 result = apiInstance.SearchForumPost(forumSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.SearchForumPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchForumPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search forum
    ApiResponse<ForumSearchResponseV1> response = apiInstance.SearchForumPostWithHttpInfo(forumSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.SearchForumPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumSearchRequestV1** | [**ForumSearchRequestV1**](ForumSearchRequestV1.md) |  |  |

### Return type

[**ForumSearchResponseV1**](ForumSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | Return search results |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchspecificforumpost"></a>
# **SearchSpecificForumPost**
> ForumSearchResponseV1 SearchSpecificForumPost (long forumId, ForumSearchRequestV1 forumSearchRequestV1)

search specific forum

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchSpecificForumPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var forumSearchRequestV1 = new ForumSearchRequestV1(); // ForumSearchRequestV1 | 

            try
            {
                // search specific forum
                ForumSearchResponseV1 result = apiInstance.SearchSpecificForumPost(forumId, forumSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.SearchSpecificForumPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchSpecificForumPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search specific forum
    ApiResponse<ForumSearchResponseV1> response = apiInstance.SearchSpecificForumPostWithHttpInfo(forumId, forumSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.SearchSpecificForumPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **forumSearchRequestV1** | [**ForumSearchRequestV1**](ForumSearchRequestV1.md) |  |  |

### Return type

[**ForumSearchResponseV1**](ForumSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | Return search results |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchspecifictopicpost"></a>
# **SearchSpecificTopicPost**
> ForumSearchResponseV1 SearchSpecificTopicPost (long forumId, long topicId, ForumSearchRequestV1 forumSearchRequestV1)

search specific topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SearchSpecificTopicPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var forumSearchRequestV1 = new ForumSearchRequestV1(); // ForumSearchRequestV1 | 

            try
            {
                // search specific topic
                ForumSearchResponseV1 result = apiInstance.SearchSpecificTopicPost(forumId, topicId, forumSearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.SearchSpecificTopicPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchSpecificTopicPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // search specific topic
    ApiResponse<ForumSearchResponseV1> response = apiInstance.SearchSpecificTopicPostWithHttpInfo(forumId, topicId, forumSearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.SearchSpecificTopicPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **forumSearchRequestV1** | [**ForumSearchRequestV1**](ForumSearchRequestV1.md) |  |  |

### Return type

[**ForumSearchResponseV1**](ForumSearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **200** | Return search results |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="showlogpost"></a>
# **ShowLogPost**
> ForumAdminHistorySearchResponseV1 ShowLogPost (ForumAdminHistorySearchRequestV1 forumAdminHistorySearchRequestV1)

show forum admin log

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ShowLogPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumAdminHistorySearchRequestV1 = new ForumAdminHistorySearchRequestV1(); // ForumAdminHistorySearchRequestV1 | 

            try
            {
                // show forum admin log
                ForumAdminHistorySearchResponseV1 result = apiInstance.ShowLogPost(forumAdminHistorySearchRequestV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ShowLogPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShowLogPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // show forum admin log
    ApiResponse<ForumAdminHistorySearchResponseV1> response = apiInstance.ShowLogPostWithHttpInfo(forumAdminHistorySearchRequestV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.ShowLogPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumAdminHistorySearchRequestV1** | [**ForumAdminHistorySearchRequestV1**](ForumAdminHistorySearchRequestV1.md) |  |  |

### Return type

[**ForumAdminHistorySearchResponseV1**](ForumAdminHistorySearchResponseV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Validation or service error |  -  |
| **401** | User does not have appropriate role |  -  |
| **200** | Return log records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepost"></a>
# **UpdatePost**
> ApiResponseV1 UpdatePost (long forumId, long topicId, long postId, ForumPostModelUpdateV1 forumPostModelUpdateV1)

update a forum post

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var postId = 56;  // long | Post id
            var forumPostModelUpdateV1 = new ForumPostModelUpdateV1(); // ForumPostModelUpdateV1 | 

            try
            {
                // update a forum post
                ApiResponseV1 result = apiInstance.UpdatePost(forumId, topicId, postId, forumPostModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.UpdatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a forum post
    ApiResponse<ApiResponseV1> response = apiInstance.UpdatePostWithHttpInfo(forumId, topicId, postId, forumPostModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.UpdatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **postId** | **long** | Post id |  |
| **forumPostModelUpdateV1** | [**ForumPostModelUpdateV1**](ForumPostModelUpdateV1.md) |  |  |

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
| **200** | Forum post was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **403** | User is under a warn restriction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetopic"></a>
# **UpdateTopic**
> ApiResponseV1 UpdateTopic (long forumId, long topicId, ForumTopicModelUpdateV1 forumTopicModelUpdateV1)

update a forum topic

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var forumTopicModelUpdateV1 = new ForumTopicModelUpdateV1(); // ForumTopicModelUpdateV1 | 

            try
            {
                // update a forum topic
                ApiResponseV1 result = apiInstance.UpdateTopic(forumId, topicId, forumTopicModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.UpdateTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a forum topic
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateTopicWithHttpInfo(forumId, topicId, forumTopicModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.UpdateTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **forumTopicModelUpdateV1** | [**ForumTopicModelUpdateV1**](ForumTopicModelUpdateV1.md) |  |  |

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
| **200** | Forum topic was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetopicpoll"></a>
# **UpdateTopicPoll**
> ApiResponseV1 UpdateTopicPoll (long forumId, long topicId, ForumPollModelUpdateV1 forumPollModelUpdateV1)

update a forum topic poll (if present)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateTopicPollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var forumId = 56;  // long | Forum id
            var topicId = 56;  // long | Topic id
            var forumPollModelUpdateV1 = new ForumPollModelUpdateV1(); // ForumPollModelUpdateV1 | 

            try
            {
                // update a forum topic poll (if present)
                ApiResponseV1 result = apiInstance.UpdateTopicPoll(forumId, topicId, forumPollModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.UpdateTopicPoll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTopicPollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a forum topic poll (if present)
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateTopicPollWithHttpInfo(forumId, topicId, forumPollModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.UpdateTopicPollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forumId** | **long** | Forum id |  |
| **topicId** | **long** | Topic id |  |
| **forumPollModelUpdateV1** | [**ForumPollModelUpdateV1**](ForumPollModelUpdateV1.md) |  |  |

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
| **200** | Topic poll was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuserwarnlevel"></a>
# **UpdateUserWarnLevel**
> ApiResponseV1 UpdateUserWarnLevel (long userId, ForumWarnModelUpdateV1 forumWarnModelUpdateV1)

update a user warn level

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class UpdateUserWarnLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ForumApi(config);
            var userId = 56;  // long | User id
            var forumWarnModelUpdateV1 = new ForumWarnModelUpdateV1(); // ForumWarnModelUpdateV1 | 

            try
            {
                // update a user warn level
                ApiResponseV1 result = apiInstance.UpdateUserWarnLevel(userId, forumWarnModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.UpdateUserWarnLevel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWarnLevelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a user warn level
    ApiResponse<ApiResponseV1> response = apiInstance.UpdateUserWarnLevelWithHttpInfo(userId, forumWarnModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForumApi.UpdateUserWarnLevelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | User id |  |
| **forumWarnModelUpdateV1** | [**ForumWarnModelUpdateV1**](ForumWarnModelUpdateV1.md) |  |  |

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
| **200** | User warn was updated |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **404** | Member not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

