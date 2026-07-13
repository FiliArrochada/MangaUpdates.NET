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
    /// SeriesModelSearchV1RankLists
    /// </summary>
    [DataContract(Name = "SeriesModelSearchV1RankLists")]
    public partial class SeriesModelSearchV1RankLists : IEquatable<SeriesModelSearchV1RankLists>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModelSearchV1RankLists" /> class.
        /// </summary>
        /// <param name="reading">reading.</param>
        /// <param name="wish">wish.</param>
        /// <param name="complete">complete.</param>
        /// <param name="unfinished">unfinished.</param>
        /// <param name="custom">custom.</param>
        public SeriesModelSearchV1RankLists(long reading = default(long), long wish = default(long), long complete = default(long), long unfinished = default(long), long custom = default(long))
        {
            this.Reading = reading;
            this.Wish = wish;
            this.Complete = complete;
            this.Unfinished = unfinished;
            this.Custom = custom;
        }

        /// <summary>
        /// Gets or Sets Reading
        /// </summary>
        [JsonPropertyName("reading")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Reading { get; set; }

        /// <summary>
        /// Gets or Sets Wish
        /// </summary>
        [JsonPropertyName("wish")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Wish { get; set; }

        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [JsonPropertyName("complete")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Complete { get; set; }

        /// <summary>
        /// Gets or Sets Unfinished
        /// </summary>
        [JsonPropertyName("unfinished")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Unfinished { get; set; }

        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [JsonPropertyName("custom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Custom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeriesModelSearchV1RankLists {\n");
            sb.Append("  Reading: ").Append(Reading).Append("\n");
            sb.Append("  Wish: ").Append(Wish).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  Unfinished: ").Append(Unfinished).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
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
            return this.Equals(input as SeriesModelSearchV1RankLists);
        }

        /// <summary>
        /// Returns true if SeriesModelSearchV1RankLists instances are equal
        /// </summary>
        /// <param name="input">Instance of SeriesModelSearchV1RankLists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesModelSearchV1RankLists input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Reading == input.Reading ||
                    this.Reading.Equals(input.Reading)
                ) &&
                (
                    this.Wish == input.Wish ||
                    this.Wish.Equals(input.Wish)
                ) &&
                (
                    this.Complete == input.Complete ||
                    this.Complete.Equals(input.Complete)
                ) &&
                (
                    this.Unfinished == input.Unfinished ||
                    this.Unfinished.Equals(input.Unfinished)
                ) &&
                (
                    this.Custom == input.Custom ||
                    this.Custom.Equals(input.Custom)
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
                hashCode = (hashCode * 59) + this.Reading.GetHashCode();
                hashCode = (hashCode * 59) + this.Wish.GetHashCode();
                hashCode = (hashCode * 59) + this.Complete.GetHashCode();
                hashCode = (hashCode * 59) + this.Unfinished.GetHashCode();
                hashCode = (hashCode * 59) + this.Custom.GetHashCode();
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