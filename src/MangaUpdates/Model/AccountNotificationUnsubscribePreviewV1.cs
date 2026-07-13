/*
 * MangaUpdates API
 *
 * This API powers our website. Most API functions are public and do not require an account. For user-based functions, you must register an account. Currently, user registration must be done through our main website and is disabled via this API.  Download OpenAPI Specification: [openapi.yaml](openapi.yaml)  Please contact us at the following emails if you have questions:  * lambchopsil@mangaupdates.com * manick@mangaupdates.com  ## Warranties  MangaUpdates makes no warranties about service availability, correctness of the data, or anything else. The service is provided as is, and may change at any time.  ## Acceptable Use Policy  * You will credit MangaUpdates when using data provided by this API. * You will use reasonable spacing between requests so as not to overwhelm the MangaUpdates servers, and employ caching mechanisms when accessing data. * You will NOT use MangaUpdates data or API in a way that will:     * Deceive or defraud users     * Assist or perform an illegal action     * Create spam     * Damage the database  We reserve the right to change this policy at any time.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace MangaUpdates.Model
{
    /// <summary>
    /// AccountNotificationUnsubscribePreviewV1
    /// </summary>
    [DataContract(Name = "AccountNotificationUnsubscribePreviewV1")]
    public partial class AccountNotificationUnsubscribePreviewV1 : IEquatable<AccountNotificationUnsubscribePreviewV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountNotificationUnsubscribePreviewV1" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="notificationType">notificationType.</param>
        /// <param name="username">username.</param>
        public AccountNotificationUnsubscribePreviewV1(string action = default(string), string notificationType = default(string), string username = default(string))
        {
            this.Action = action;
            this.NotificationType = notificationType;
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [JsonPropertyName("action")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [JsonPropertyName("username")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountNotificationUnsubscribePreviewV1 {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountNotificationUnsubscribePreviewV1);
        }

        /// <summary>
        /// Returns true if AccountNotificationUnsubscribePreviewV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountNotificationUnsubscribePreviewV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountNotificationUnsubscribePreviewV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) &&
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
                ) &&
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.NotificationType != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationType.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}