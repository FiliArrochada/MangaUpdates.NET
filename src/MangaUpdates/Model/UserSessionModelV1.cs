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
    /// UserSessionModelV1
    /// </summary>
    [DataContract(Name = "UserSessionModelV1")]
    public partial class UserSessionModelV1 : IEquatable<UserSessionModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionModelV1" /> class.
        /// </summary>
        /// <param name="ip">ip.</param>
        /// <param name="lastAction">lastAction.</param>
        public UserSessionModelV1(string ip = default(string), TimeV1 lastAction = default(TimeV1))
        {
            this.Ip = ip;
            this.LastAction = lastAction;
        }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [JsonPropertyName("ip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets LastAction
        /// </summary>
        [JsonPropertyName("last_action")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 LastAction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSessionModelV1 {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  LastAction: ").Append(LastAction).Append("\n");
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
            return this.Equals(input as UserSessionModelV1);
        }

        /// <summary>
        /// Returns true if UserSessionModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSessionModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSessionModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) &&
                (
                    this.LastAction == input.LastAction ||
                    (this.LastAction != null &&
                    this.LastAction.Equals(input.LastAction))
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
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                if (this.LastAction != null)
                {
                    hashCode = (hashCode * 59) + this.LastAction.GetHashCode();
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