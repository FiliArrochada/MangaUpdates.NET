# MangaUpdates.Api.AccountApi

All URIs are relative to *https://api.mangaupdates.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Captcha**](AccountApi.md#captcha) | **GET** /account/captcha | retrieve the public captcha key |
| [**ConfirmAndChangePassword**](AccountApi.md#confirmandchangepassword) | **POST** /account/forgotpass/confirm/{auth_hash} | update a password change using an auth hash |
| [**ConfirmDeleteAccount**](AccountApi.md#confirmdeleteaccount) | **POST** /account/delete/confirm/{auth_hash} | confirm deletion of your account |
| [**ConfirmRegistration**](AccountApi.md#confirmregistration) | **POST** /account/register/confirm/{auth_hash} | confirm a new member registration |
| [**DeleteAccount**](AccountApi.md#deleteaccount) | **POST** /account/delete/{captcha_response} | delete your account |
| [**ForgotPassword**](AccountApi.md#forgotpassword) | **POST** /account/forgotpass/{captcha_response} | send a forgotten password email |
| [**Login**](AccountApi.md#login) | **PUT** /account/login | create a session token |
| [**Logout**](AccountApi.md#logout) | **POST** /account/logout | remove a session token |
| [**Profile**](AccountApi.md#profile) | **GET** /account/profile | get the profile for the current user |
| [**RegisterMember**](AccountApi.md#registermember) | **POST** /account/register/{captcha_response} | register a new member |
| [**ResendAuthEmail**](AccountApi.md#resendauthemail) | **POST** /account/resendauth/{id} | send an auth email to a user |
| [**SendForgotEmail**](AccountApi.md#sendforgotemail) | **POST** /account/sendforgot/{id} | send a forgotten password email to a user |

<a id="captcha"></a>
# **Captcha**
> ApiResponseV1 Captcha ()

retrieve the public captcha key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class CaptchaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // retrieve the public captcha key
                ApiResponseV1 result = apiInstance.Captcha();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.Captcha: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptchaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // retrieve the public captcha key
    ApiResponse<ApiResponseV1> response = apiInstance.CaptchaWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.CaptchaWithHttpInfo: " + e.Message);
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
| **200** | Return captcha record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="confirmandchangepassword"></a>
# **ConfirmAndChangePassword**
> ApiResponseV1 ConfirmAndChangePassword (string authHash, UserModelUpdatePasswordV1 userModelUpdatePasswordV1)

update a password change using an auth hash

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ConfirmAndChangePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var authHash = "authHash_example";  // string | auth hash from email confirmation
            var userModelUpdatePasswordV1 = new UserModelUpdatePasswordV1(); // UserModelUpdatePasswordV1 | 

            try
            {
                // update a password change using an auth hash
                ApiResponseV1 result = apiInstance.ConfirmAndChangePassword(authHash, userModelUpdatePasswordV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ConfirmAndChangePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmAndChangePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update a password change using an auth hash
    ApiResponse<ApiResponseV1> response = apiInstance.ConfirmAndChangePasswordWithHttpInfo(authHash, userModelUpdatePasswordV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ConfirmAndChangePasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authHash** | **string** | auth hash from email confirmation |  |
| **userModelUpdatePasswordV1** | [**UserModelUpdatePasswordV1**](UserModelUpdatePasswordV1.md) |  |  |

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
| **200** | Password was changed |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="confirmdeleteaccount"></a>
# **ConfirmDeleteAccount**
> ApiResponseV1 ConfirmDeleteAccount (string authHash)

confirm deletion of your account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ConfirmDeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var authHash = "authHash_example";  // string | auth hash from email confirmation

            try
            {
                // confirm deletion of your account
                ApiResponseV1 result = apiInstance.ConfirmDeleteAccount(authHash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ConfirmDeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmDeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // confirm deletion of your account
    ApiResponse<ApiResponseV1> response = apiInstance.ConfirmDeleteAccountWithHttpInfo(authHash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ConfirmDeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authHash** | **string** | auth hash from email confirmation |  |

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
| **200** | Account was deleted |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="confirmregistration"></a>
# **ConfirmRegistration**
> ApiResponseV1 ConfirmRegistration (string authHash)

confirm a new member registration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ConfirmRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var authHash = "authHash_example";  // string | auth hash from email confirmation

            try
            {
                // confirm a new member registration
                ApiResponseV1 result = apiInstance.ConfirmRegistration(authHash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ConfirmRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // confirm a new member registration
    ApiResponse<ApiResponseV1> response = apiInstance.ConfirmRegistrationWithHttpInfo(authHash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ConfirmRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authHash** | **string** | auth hash from email confirmation |  |

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
| **200** | Member was confirmed |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaccount"></a>
# **DeleteAccount**
> ApiResponseV1 DeleteAccount (string captchaResponse)

delete your account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var captchaResponse = "captchaResponse_example";  // string | response of captcha

            try
            {
                // delete your account
                ApiResponseV1 result = apiInstance.DeleteAccount(captchaResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.DeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete your account
    ApiResponse<ApiResponseV1> response = apiInstance.DeleteAccountWithHttpInfo(captchaResponse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.DeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captchaResponse** | **string** | response of captcha |  |

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
| **200** | Account was deleted |  -  |
| **400** | Validation or service error |  -  |
| **401** | User does not have correct role |  -  |
| **412** | Five second update delay |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="forgotpassword"></a>
# **ForgotPassword**
> ApiResponseV1 ForgotPassword (string captchaResponse, AccountForgotPassModelV1 accountForgotPassModelV1)

send a forgotten password email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ForgotPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var captchaResponse = "captchaResponse_example";  // string | response of captcha
            var accountForgotPassModelV1 = new AccountForgotPassModelV1(); // AccountForgotPassModelV1 | 

            try
            {
                // send a forgotten password email
                ApiResponseV1 result = apiInstance.ForgotPassword(captchaResponse, accountForgotPassModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ForgotPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForgotPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // send a forgotten password email
    ApiResponse<ApiResponseV1> response = apiInstance.ForgotPasswordWithHttpInfo(captchaResponse, accountForgotPassModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ForgotPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captchaResponse** | **string** | response of captcha |  |
| **accountForgotPassModelV1** | [**AccountForgotPassModelV1**](AccountForgotPassModelV1.md) |  |  |

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
| **200** | Email was sent |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="login"></a>
# **Login**
> ApiResponseV1 Login (AccountLoginModelV1 accountLoginModelV1)

create a session token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var accountLoginModelV1 = new AccountLoginModelV1(); // AccountLoginModelV1 | 

            try
            {
                // create a session token
                ApiResponseV1 result = apiInstance.Login(accountLoginModelV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // create a session token
    ApiResponse<ApiResponseV1> response = apiInstance.LoginWithHttpInfo(accountLoginModelV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.LoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountLoginModelV1** | [**AccountLoginModelV1**](AccountLoginModelV1.md) |  |  |

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
| **200** | Login successful |  -  |
| **400** | Validation or service error |  -  |
| **401** | Invalid credentials or user error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logout"></a>
# **Logout**
> ApiResponseV1 Logout ()

remove a session token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // remove a session token
                ApiResponseV1 result = apiInstance.Logout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // remove a session token
    ApiResponse<ApiResponseV1> response = apiInstance.LogoutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.LogoutWithHttpInfo: " + e.Message);
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
| **200** | Logout successful |  -  |
| **401** | User is not logged in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="profile"></a>
# **Profile**
> UserModelV1 Profile ()

get the profile for the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);

            try
            {
                // get the profile for the current user
                UserModelV1 result = apiInstance.Profile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.Profile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get the profile for the current user
    ApiResponse<UserModelV1> response = apiInstance.ProfileWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **404** | User not found |  -  |
| **401** | User required |  -  |
| **200** | Return user record |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="registermember"></a>
# **RegisterMember**
> ApiResponseV1 RegisterMember (string captchaResponse, UserModelRegisterV1 userModelRegisterV1)

register a new member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class RegisterMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var captchaResponse = "captchaResponse_example";  // string | response of captcha
            var userModelRegisterV1 = new UserModelRegisterV1(); // UserModelRegisterV1 | 

            try
            {
                // register a new member
                ApiResponseV1 result = apiInstance.RegisterMember(captchaResponse, userModelRegisterV1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.RegisterMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // register a new member
    ApiResponse<ApiResponseV1> response = apiInstance.RegisterMemberWithHttpInfo(captchaResponse, userModelRegisterV1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.RegisterMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captchaResponse** | **string** | response of captcha |  |
| **userModelRegisterV1** | [**UserModelRegisterV1**](UserModelRegisterV1.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resendauthemail"></a>
# **ResendAuthEmail**
> ApiResponseV1 ResendAuthEmail (long id)

send an auth email to a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class ResendAuthEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // send an auth email to a user
                ApiResponseV1 result = apiInstance.ResendAuthEmail(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ResendAuthEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResendAuthEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // send an auth email to a user
    ApiResponse<ApiResponseV1> response = apiInstance.ResendAuthEmailWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ResendAuthEmailWithHttpInfo: " + e.Message);
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
| **200** | Auth email was sent |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendforgotemail"></a>
# **SendForgotEmail**
> ApiResponseV1 SendForgotEmail (long id)

send a forgotten password email to a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MangaUpdates.Api;
using MangaUpdates.Client;
using MangaUpdates.Model;

namespace Example
{
    public class SendForgotEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mangaupdates.com/v1";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountApi(config);
            var id = 789L;  // long | Member id

            try
            {
                // send a forgotten password email to a user
                ApiResponseV1 result = apiInstance.SendForgotEmail(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.SendForgotEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendForgotEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // send a forgotten password email to a user
    ApiResponse<ApiResponseV1> response = apiInstance.SendForgotEmailWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.SendForgotEmailWithHttpInfo: " + e.Message);
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
| **200** | Auth email was sent |  -  |
| **400** | Validation or service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

