/*
 * MangaUpdates API
 *
 * This API powers our website. Most API functions are public and do not require an account. For user-based functions, you must register an account. Currently, user registration must be done through our main website and is disabled via this API.  Download OpenAPI Specification: [openapi.yaml](openapi.yaml)  Please contact us at the following emails if you have questions:  * lambchopsil@mangaupdates.com * manick@mangaupdates.com  ## Warranties  MangaUpdates makes no warranties about service availability, correctness of the data, or anything else. The service is provided as is, and may change at any time.  ## Acceptable Use Policy  * You will credit MangaUpdates when using data provided by this API. * You will use reasonable spacing between requests so as not to overwhelm the MangaUpdates servers, and employ caching mechanisms when accessing data. * You will NOT use MangaUpdates data or API in a way that will:     * Deceive or defraud users     * Assist or perform an illegal action     * Create spam     * Damage the database  We reserve the right to change this policy at any time.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace MangaUpdates.Model
{
    /// <summary>
    /// PollArchiveModelV1
    /// </summary>
    [DataContract(Name = "PollArchiveModelV1")]
    public partial class PollArchiveModelV1 : IEquatable<PollArchiveModelV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PollArchiveModelV1" /> class.
        /// </summary>
        /// <param name="pollId">pollId.</param>
        /// <param name="question">question.</param>
        /// <param name="responses">responses.</param>
        /// <param name="totalVotes">totalVotes.</param>
        /// <param name="timeFinished">timeFinished.</param>
        public PollArchiveModelV1(long pollId = default(long), string question = default(string), List<string> responses = default(List<string>), long totalVotes = default(long), TimeV1 timeFinished = default(TimeV1))
        {
            this.PollId = pollId;
            this.Question = question;
            this.Responses = responses;
            this.TotalVotes = totalVotes;
            this.TimeFinished = timeFinished;
        }

        /// <summary>
        /// Gets or Sets PollId
        /// </summary>
        [JsonPropertyName("poll_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long PollId { get; set; }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [JsonPropertyName("question")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Question { get; set; }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [JsonPropertyName("responses")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> Responses { get; set; }

        /// <summary>
        /// Gets or Sets TotalVotes
        /// </summary>
        [JsonPropertyName("total_votes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long TotalVotes { get; set; }

        /// <summary>
        /// Gets or Sets TimeFinished
        /// </summary>
        [JsonPropertyName("time_finished")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 TimeFinished { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PollArchiveModelV1 {\n");
            sb.Append("  PollId: ").Append(PollId).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Responses: ").Append(Responses).Append("\n");
            sb.Append("  TotalVotes: ").Append(TotalVotes).Append("\n");
            sb.Append("  TimeFinished: ").Append(TimeFinished).Append("\n");
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
            return this.Equals(input as PollArchiveModelV1);
        }

        /// <summary>
        /// Returns true if PollArchiveModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PollArchiveModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PollArchiveModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.PollId == input.PollId ||
                    this.PollId.Equals(input.PollId)
                ) &&
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
                ) &&
                (
                    this.Responses == input.Responses ||
                    this.Responses != null &&
                    input.Responses != null &&
                    this.Responses.SequenceEqual(input.Responses)
                ) &&
                (
                    this.TotalVotes == input.TotalVotes ||
                    this.TotalVotes.Equals(input.TotalVotes)
                ) &&
                (
                    this.TimeFinished == input.TimeFinished ||
                    (this.TimeFinished != null &&
                    this.TimeFinished.Equals(input.TimeFinished))
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
                hashCode = (hashCode * 59) + this.PollId.GetHashCode();
                if (this.Question != null)
                {
                    hashCode = (hashCode * 59) + this.Question.GetHashCode();
                }
                if (this.Responses != null)
                {
                    hashCode = (hashCode * 59) + this.Responses.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalVotes.GetHashCode();
                if (this.TimeFinished != null)
                {
                    hashCode = (hashCode * 59) + this.TimeFinished.GetHashCode();
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