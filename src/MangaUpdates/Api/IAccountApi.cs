using System.Threading;
using System.Threading.Tasks;
using MangaUpdates.Model;
using Refit;

namespace MangaUpdates.Api
{
    /// <summary>
    /// Refit client for the Account endpoints of the MangaUpdates API.
    /// </summary>
    public interface IAccountApi
    {
        /// <summary>retrieve the public captcha key</summary>
        [Get("/account/captcha")]
        Task<ApiResponseV1> Captcha(CancellationToken cancellationToken = default);

        /// <summary>update a password change using an auth hash</summary>
        [Post("/account/forgotpass/confirm/{auth_hash}")]
        Task<ApiResponseV1> ConfirmAndChangePassword([AliasAs("auth_hash")] string authHash, [Body] UserModelUpdatePasswordV1 userModelUpdatePasswordV1, CancellationToken cancellationToken = default);

        /// <summary>confirm deletion of your account</summary>
        [Post("/account/delete/confirm/{auth_hash}")]
        Task<ApiResponseV1> ConfirmDeleteAccount([AliasAs("auth_hash")] string authHash, CancellationToken cancellationToken = default);

        /// <summary>confirm and execute unsubscribe (no auth required)</summary>
        [Post("/account/notifications/unsubscribe/{token}")]
        Task<ApiResponseV1> ConfirmNotificationUnsubscribe(string token, CancellationToken cancellationToken = default);

        /// <summary>confirm a new member registration</summary>
        [Post("/account/register/confirm/{auth_hash}")]
        Task<ApiResponseV1> ConfirmRegistration([AliasAs("auth_hash")] string authHash, CancellationToken cancellationToken = default);

        /// <summary>delete your account</summary>
        [Post("/account/delete/{captcha_response}")]
        Task<ApiResponseV1> DeleteAccount([AliasAs("captcha_response")] string captchaResponse, CancellationToken cancellationToken = default);

        /// <summary>send a forgotten password email</summary>
        [Post("/account/forgotpass/{captcha_response}")]
        Task<ApiResponseV1> ForgotPassword([AliasAs("captcha_response")] string captchaResponse, [Body] AccountForgotPassModelV1 accountForgotPassModelV1, CancellationToken cancellationToken = default);

        /// <summary>create a session token</summary>
        [Put("/account/login")]
        Task<ApiResponseV1> Login([Body] AccountLoginModelV1 accountLoginModelV1, CancellationToken cancellationToken = default);

        /// <summary>create a session token as a cookie</summary>
        [Put("/account/loginWithCookie")]
        Task<ApiResponseV1> LoginWithCookie([Body] AccountLoginModelV1 accountLoginModelV1, CancellationToken cancellationToken = default);

        /// <summary>remove a session token</summary>
        [Post("/account/logout")]
        Task<ApiResponseV1> Logout(CancellationToken cancellationToken = default);

        /// <summary>preview what will be unsubscribed (no auth required)</summary>
        [Get("/account/notifications/unsubscribe/{token}")]
        Task<AccountNotificationUnsubscribePreviewV1> PreviewNotificationUnsubscribe(string token, CancellationToken cancellationToken = default);

        /// <summary>get the profile for the current user</summary>
        [Get("/account/profile")]
        Task<UserModelV1> Profile(CancellationToken cancellationToken = default);

        /// <summary>refresh session token cookie</summary>
        [Get("/account/refresh")]
        Task<ApiResponseV1> RefreshCookie(CancellationToken cancellationToken = default);

        /// <summary>register a new member</summary>
        [Post("/account/register/{captcha_response}")]
        Task<ApiResponseV1> RegisterMember([AliasAs("captcha_response")] string captchaResponse, [Body] UserModelRegisterV1 userModelRegisterV1, CancellationToken cancellationToken = default);

        /// <summary>send an auth email to a user</summary>
        [Post("/account/resendauth/{id}")]
        Task<ApiResponseV1> ResendAuthEmail(long id, CancellationToken cancellationToken = default);

        /// <summary>send a forgotten password email to a user</summary>
        [Post("/account/sendforgot/{id}")]
        Task<ApiResponseV1> SendForgotEmail(long id, CancellationToken cancellationToken = default);
    }
}