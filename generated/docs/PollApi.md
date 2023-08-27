# MangaUpdates.Api.PollApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPoll**](PollApi.md#addpoll) | **POST** /poll | add a new poll |
| [**ArchivePoll**](PollApi.md#archivepoll) | **DELETE** /poll | archive the active poll |
| [**RetrieveOldPolls**](PollApi.md#retrieveoldpolls) | **GET** /poll/old | get old polls |
| [**RetrievePoll**](PollApi.md#retrievepoll) | **GET** /poll | get the active poll |
| [**RetrieveVoteStatus**](PollApi.md#retrievevotestatus) | **GET** /poll/vote/status | get information about whether the user has voted |
| [**VotePollAnswer**](PollApi.md#votepollanswer) | **POST** /poll/vote/{answer_id} | vote in a poll answer |
| [**VotePollNoAnswer**](PollApi.md#votepollnoanswer) | **POST** /poll/vote | vote in a poll |

<a id="addpoll"></a>
# **AddPoll**
> ApiResponseV1 AddPoll (PollModelUpdateV1 pollModelUpdateV1)

add a new poll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class AddPollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);
            var pollModelUpdateV1 = new PollModelUpdateV1(); // PollModelUpdateV1 | 

            try
            {
                // add a new poll
                ApiResponseV1 result = apiInstance.AddPoll(pollModelUpdateV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.AddPoll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // add a new poll
    ApiResponse<ApiResponseV1> response = apiInstance.AddPollWithHttpInfo(pollModelUpdateV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.AddPollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pollModelUpdateV1** | [**PollModelUpdateV1**](PollModelUpdateV1.md) |  |  |

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
| **200** | Poll was successfully added |  -  |
| **401** | User does not have correct role |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="archivepoll"></a>
# **ArchivePoll**
> ApiResponseV1 ArchivePoll ()

archive the active poll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ArchivePollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);

            try
            {
                // archive the active poll
                ApiResponseV1 result = apiInstance.ArchivePoll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.ArchivePoll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchivePollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // archive the active poll
    ApiResponse<ApiResponseV1> response = apiInstance.ArchivePollWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.ArchivePollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Poll was successfully archived |  -  |
| **401** | User does not have correct role |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrieveoldpolls"></a>
# **RetrieveOldPolls**
> ApiResponseV1 RetrieveOldPolls ()

get old polls

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveOldPollsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);

            try
            {
                // get old polls
                ApiResponseV1 result = apiInstance.RetrieveOldPolls();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.RetrieveOldPolls: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveOldPollsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get old polls
    ApiResponse<ApiResponseV1> response = apiInstance.RetrieveOldPollsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.RetrieveOldPollsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Return poll records |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievepoll"></a>
# **RetrievePoll**
> PollModelV1 RetrievePoll ()

get the active poll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrievePollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);

            try
            {
                // get the active poll
                PollModelV1 result = apiInstance.RetrievePoll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.RetrievePoll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrievePollWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the active poll
    ApiResponse<PollModelV1> response = apiInstance.RetrievePollWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.RetrievePollWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PollModelV1**](PollModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return poll record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievevotestatus"></a>
# **RetrieveVoteStatus**
> PollVoteStatusModelV1 RetrieveVoteStatus ()

get information about whether the user has voted

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RetrieveVoteStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);

            try
            {
                // get information about whether the user has voted
                PollVoteStatusModelV1 result = apiInstance.RetrieveVoteStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.RetrieveVoteStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveVoteStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get information about whether the user has voted
    ApiResponse<PollVoteStatusModelV1> response = apiInstance.RetrieveVoteStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.RetrieveVoteStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PollVoteStatusModelV1**](PollVoteStatusModelV1.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return poll voter status record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="votepollanswer"></a>
# **VotePollAnswer**
> ApiResponseV1 VotePollAnswer (long answerId)

vote in a poll answer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class VotePollAnswerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);
            var answerId = 56;  // long | id of answer to vote for

            try
            {
                // vote in a poll answer
                ApiResponseV1 result = apiInstance.VotePollAnswer(answerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.VotePollAnswer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VotePollAnswerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // vote in a poll answer
    ApiResponse<ApiResponseV1> response = apiInstance.VotePollAnswerWithHttpInfo(answerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.VotePollAnswerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **answerId** | **long** | id of answer to vote for |  |

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
| **200** | Vote was successfully added |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="votepollnoanswer"></a>
# **VotePollNoAnswer**
> ApiResponseV1 VotePollNoAnswer ()

vote in a poll

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class VotePollNoAnswerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PollApi(config);

            try
            {
                // vote in a poll
                ApiResponseV1 result = apiInstance.VotePollNoAnswer();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PollApi.VotePollNoAnswer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VotePollNoAnswerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // vote in a poll
    ApiResponse<ApiResponseV1> response = apiInstance.VotePollNoAnswerWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PollApi.VotePollNoAnswerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Vote was successfully added |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

