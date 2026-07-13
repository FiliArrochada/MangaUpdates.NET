/*
 * MangaUpdates API
 *
 * This API powers our website. Most API functions are public and do not require an account. For user-based functions, you must register an account. Currently, user registration must be done through our main website and is disabled via this API.  Download OpenAPI Specification: [openapi.yaml](openapi.yaml)  Please contact us at the following emails if you have questions:  * lambchopsil@mangaupdates.com * manick@mangaupdates.com  ## Warranties  MangaUpdates makes no warranties about service availability, correctness of the data, or anything else. The service is provided as is, and may change at any time.  ## Acceptable Use Policy  * You will credit MangaUpdates when using data provided by this API. * You will use reasonable spacing between requests so as not to overwhelm the MangaUpdates servers, and employ caching mechanisms when accessing data. * You will NOT use MangaUpdates data or API in a way that will:     * Deceive or defraud users     * Assist or perform an illegal action     * Create spam     * Damage the database  We reserve the right to change this policy at any time.
 *
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace MangaUpdates.Model
{
    /// <summary>
    /// ListsSimilarUsersResponseV1Users
    /// </summary>
    [DataContract(Name = "ListsSimilarUsersResponseV1Users")]
    public partial class ListsSimilarUsersResponseV1Users : IEquatable<ListsSimilarUsersResponseV1Users>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListsSimilarUsersResponseV1Users" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="userRating">userRating.</param>
        /// <param name="intersectCount">intersectCount.</param>
        /// <param name="percentMatch">percentMatch.</param>
        public ListsSimilarUsersResponseV1Users(long userId = default(long), string userName = default(string), decimal userRating = default(decimal), long intersectCount = default(long), long percentMatch = default(long))
        {
            this.UserId = userId;
            this.UserName = userName;
            this.UserRating = userRating;
            this.IntersectCount = intersectCount;
            this.PercentMatch = percentMatch;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [JsonPropertyName("user_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets UserRating
        /// </summary>
        [JsonPropertyName("user_rating")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal UserRating { get; set; }

        /// <summary>
        /// Gets or Sets IntersectCount
        /// </summary>
        [JsonPropertyName("intersect_count")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long IntersectCount { get; set; }

        /// <summary>
        /// Gets or Sets PercentMatch
        /// </summary>
        [JsonPropertyName("percent_match")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long PercentMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListsSimilarUsersResponseV1Users {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserRating: ").Append(UserRating).Append("\n");
            sb.Append("  IntersectCount: ").Append(IntersectCount).Append("\n");
            sb.Append("  PercentMatch: ").Append(PercentMatch).Append("\n");
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
            return this.Equals(input as ListsSimilarUsersResponseV1Users);
        }

        /// <summary>
        /// Returns true if ListsSimilarUsersResponseV1Users instances are equal
        /// </summary>
        /// <param name="input">Instance of ListsSimilarUsersResponseV1Users to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListsSimilarUsersResponseV1Users input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserRating == input.UserRating ||
                    this.UserRating.Equals(input.UserRating)
                ) && 
                (
                    this.IntersectCount == input.IntersectCount ||
                    this.IntersectCount.Equals(input.IntersectCount)
                ) && 
                (
                    this.PercentMatch == input.PercentMatch ||
                    this.PercentMatch.Equals(input.PercentMatch)
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
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserRating.GetHashCode();
                hashCode = (hashCode * 59) + this.IntersectCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentMatch.GetHashCode();
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
