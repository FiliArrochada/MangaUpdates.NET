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
    /// UserNotificationModelV1
    /// </summary>
    [DataContract(Name = "UserNotificationModelV1")]
    public partial class UserNotificationModelV1 : IEquatable<UserNotificationModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotificationModelV1" /> class.
        /// </summary>
        /// <param name="notificationId">notificationId.</param>
        /// <param name="notificationType">notificationType.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="payload">payload.</param>
        /// <param name="timeCreated">timeCreated.</param>
        /// <param name="timeRead">timeRead.</param>
        /// <param name="isRead">isRead.</param>
        public UserNotificationModelV1(long notificationId = default(long), string notificationType = default(string), long referenceId = default(long), Dictionary<string, object> payload = default(Dictionary<string, object>), TimeV1 timeCreated = default(TimeV1), TimeV1 timeRead = default(TimeV1), bool isRead = default(bool))
        {
            this.NotificationId = notificationId;
            this.NotificationType = notificationType;
            this.ReferenceId = referenceId;
            this.Payload = payload;
            this.TimeCreated = timeCreated;
            this.TimeRead = timeRead;
            this.IsRead = isRead;
        }

        /// <summary>
        /// Gets or Sets NotificationId
        /// </summary>
        [JsonPropertyName("notification_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long NotificationId { get; set; }

        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [JsonPropertyName("reference_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [JsonPropertyName("payload")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Dictionary<string, object> Payload { get; set; }

        /// <summary>
        /// Gets or Sets TimeCreated
        /// </summary>
        [JsonPropertyName("time_created")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 TimeCreated { get; set; }

        /// <summary>
        /// Gets or Sets TimeRead
        /// </summary>
        [JsonPropertyName("time_read")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 TimeRead { get; set; }

        /// <summary>
        /// Gets or Sets IsRead
        /// </summary>
        [JsonPropertyName("is_read")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool IsRead { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserNotificationModelV1 {\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimeRead: ").Append(TimeRead).Append("\n");
            sb.Append("  IsRead: ").Append(IsRead).Append("\n");
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
            return this.Equals(input as UserNotificationModelV1);
        }

        /// <summary>
        /// Returns true if UserNotificationModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserNotificationModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserNotificationModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.NotificationId == input.NotificationId ||
                    this.NotificationId.Equals(input.NotificationId)
                ) &&
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
                ) &&
                (
                    this.ReferenceId == input.ReferenceId ||
                    this.ReferenceId.Equals(input.ReferenceId)
                ) &&
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) &&
                (
                    this.TimeCreated == input.TimeCreated ||
                    (this.TimeCreated != null &&
                    this.TimeCreated.Equals(input.TimeCreated))
                ) &&
                (
                    this.TimeRead == input.TimeRead ||
                    (this.TimeRead != null &&
                    this.TimeRead.Equals(input.TimeRead))
                ) &&
                (
                    this.IsRead == input.IsRead ||
                    this.IsRead.Equals(input.IsRead)
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
                hashCode = (hashCode * 59) + this.NotificationId.GetHashCode();
                if (this.NotificationType != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }
                if (this.TimeCreated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeCreated.GetHashCode();
                }
                if (this.TimeRead != null)
                {
                    hashCode = (hashCode * 59) + this.TimeRead.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsRead.GetHashCode();
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