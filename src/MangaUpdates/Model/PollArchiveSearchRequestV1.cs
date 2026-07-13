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
    /// PollArchiveSearchRequestV1
    /// </summary>
    [DataContract(Name = "PollArchiveSearchRequestV1")]
    public partial class PollArchiveSearchRequestV1 : IEquatable<PollArchiveSearchRequestV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollArchiveSearchRequestV1" /> class.
        /// </summary>
        /// <param name="search">search.</param>
        /// <param name="page">page.</param>
        /// <param name="perpage">perpage.</param>
        /// <param name="orderby">orderby.</param>
        public PollArchiveSearchRequestV1(string search = default(string), long page = default(long), long perpage = default(long), string orderby = default(string))
        {
            this.Search = search;
            this.Page = page;
            this.Perpage = perpage;
            this.Orderby = orderby;
        }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [JsonPropertyName("search")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Search { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [JsonPropertyName("page")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Page { get; set; }

        /// <summary>
        /// Gets or Sets Perpage
        /// </summary>
        [JsonPropertyName("perpage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Perpage { get; set; }

        /// <summary>
        /// Gets or Sets Orderby
        /// </summary>
        [JsonPropertyName("orderby")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Orderby { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollArchiveSearchRequestV1 {\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Perpage: ").Append(Perpage).Append("\n");
            sb.Append("  Orderby: ").Append(Orderby).Append("\n");
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
            return this.Equals(input as PollArchiveSearchRequestV1);
        }

        /// <summary>
        /// Returns true if PollArchiveSearchRequestV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PollArchiveSearchRequestV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PollArchiveSearchRequestV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) &&
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) &&
                (
                    this.Perpage == input.Perpage ||
                    this.Perpage.Equals(input.Perpage)
                ) &&
                (
                    this.Orderby == input.Orderby ||
                    (this.Orderby != null &&
                    this.Orderby.Equals(input.Orderby))
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
                if (this.Search != null)
                {
                    hashCode = (hashCode * 59) + this.Search.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.Perpage.GetHashCode();
                if (this.Orderby != null)
                {
                    hashCode = (hashCode * 59) + this.Orderby.GetHashCode();
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