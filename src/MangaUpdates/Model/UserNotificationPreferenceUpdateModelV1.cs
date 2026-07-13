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
    /// UserNotificationPreferenceUpdateModelV1
    /// </summary>
    [DataContract(Name = "UserNotificationPreferenceUpdateModelV1")]
    public partial class UserNotificationPreferenceUpdateModelV1 : IEquatable<UserNotificationPreferenceUpdateModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotificationPreferenceUpdateModelV1" /> class.
        /// </summary>
        /// <param name="notificationType">notificationType.</param>
        /// <param name="channel">channel.</param>
        /// <param name="deliveryMethod">deliveryMethod.</param>
        public UserNotificationPreferenceUpdateModelV1(string notificationType = default(string), string channel = default(string), string deliveryMethod = default(string))
        {
            this.NotificationType = notificationType;
            this.Channel = channel;
            this.DeliveryMethod = deliveryMethod;
        }

        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [JsonPropertyName("channel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryMethod
        /// </summary>
        [JsonPropertyName("delivery_method")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserNotificationPreferenceUpdateModelV1 {\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
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
            return this.Equals(input as UserNotificationPreferenceUpdateModelV1);
        }

        /// <summary>
        /// Returns true if UserNotificationPreferenceUpdateModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserNotificationPreferenceUpdateModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserNotificationPreferenceUpdateModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
                ) &&
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) &&
                (
                    this.DeliveryMethod == input.DeliveryMethod ||
                    (this.DeliveryMethod != null &&
                    this.DeliveryMethod.Equals(input.DeliveryMethod))
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
                if (this.NotificationType != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationType.GetHashCode();
                }
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.DeliveryMethod != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMethod.GetHashCode();
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