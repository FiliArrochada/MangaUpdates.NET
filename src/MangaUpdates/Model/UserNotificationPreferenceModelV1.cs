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
    /// UserNotificationPreferenceModelV1
    /// </summary>
    [DataContract(Name = "UserNotificationPreferenceModelV1")]
    public partial class UserNotificationPreferenceModelV1 : IEquatable<UserNotificationPreferenceModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotificationPreferenceModelV1" /> class.
        /// </summary>
        /// <param name="notificationType">notificationType.</param>
        /// <param name="channel">channel.</param>
        /// <param name="deliveryMethod">deliveryMethod.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="timeCreated">timeCreated.</param>
        /// <param name="timeUpdated">timeUpdated.</param>
        public UserNotificationPreferenceModelV1(string notificationType = default(string), string channel = default(string), string deliveryMethod = default(string), bool isDefault = default(bool), TimeV1 timeCreated = default(TimeV1), TimeV1 timeUpdated = default(TimeV1))
        {
            this.NotificationType = notificationType;
            this.Channel = channel;
            this.DeliveryMethod = deliveryMethod;
            this.IsDefault = isDefault;
            this.TimeCreated = timeCreated;
            this.TimeUpdated = timeUpdated;
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
        /// Gets or Sets IsDefault
        /// </summary>
        [JsonPropertyName("is_default")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets TimeCreated
        /// </summary>
        [JsonPropertyName("time_created")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 TimeCreated { get; set; }

        /// <summary>
        /// Gets or Sets TimeUpdated
        /// </summary>
        [JsonPropertyName("time_updated")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 TimeUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserNotificationPreferenceModelV1 {\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimeUpdated: ").Append(TimeUpdated).Append("\n");
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
            return this.Equals(input as UserNotificationPreferenceModelV1);
        }

        /// <summary>
        /// Returns true if UserNotificationPreferenceModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserNotificationPreferenceModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserNotificationPreferenceModelV1 input)
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
                ) &&
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) &&
                (
                    this.TimeCreated == input.TimeCreated ||
                    (this.TimeCreated != null &&
                    this.TimeCreated.Equals(input.TimeCreated))
                ) &&
                (
                    this.TimeUpdated == input.TimeUpdated ||
                    (this.TimeUpdated != null &&
                    this.TimeUpdated.Equals(input.TimeUpdated))
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
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.TimeCreated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeCreated.GetHashCode();
                }
                if (this.TimeUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeUpdated.GetHashCode();
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