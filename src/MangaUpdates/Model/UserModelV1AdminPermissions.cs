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
    /// UserModelV1AdminPermissions
    /// </summary>
    [DataContract(Name = "UserModelV1AdminPermissions")]
    public partial class UserModelV1AdminPermissions : IEquatable<UserModelV1AdminPermissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserModelV1AdminPermissions" /> class.
        /// </summary>
        /// <param name="pAddReleases">pAddReleases.</param>
        /// <param name="pEditUsers">pEditUsers.</param>
        /// <param name="pEditGroups">pEditGroups.</param>
        /// <param name="pEditPoll">pEditPoll.</param>
        /// <param name="pEditSeries">pEditSeries.</param>
        /// <param name="pEditReviews">pEditReviews.</param>
        /// <param name="pEditNews">pEditNews.</param>
        /// <param name="pEditAffiliates">pEditAffiliates.</param>
        /// <param name="pEditAboutus">pEditAboutus.</param>
        /// <param name="pViewLog">pViewLog.</param>
        /// <param name="pEditConfig">pEditConfig.</param>
        /// <param name="pViewStats">pViewStats.</param>
        /// <param name="pEditGenre">pEditGenre.</param>
        /// <param name="pEditAuthors">pEditAuthors.</param>
        /// <param name="pEditPublishers">pEditPublishers.</param>
        /// <param name="pEditPartialUsers">pEditPartialUsers.</param>
        public UserModelV1AdminPermissions(bool pAddReleases = default(bool), bool pEditUsers = default(bool), bool pEditGroups = default(bool), bool pEditPoll = default(bool), bool pEditSeries = default(bool), bool pEditReviews = default(bool), bool pEditNews = default(bool), bool pEditAffiliates = default(bool), bool pEditAboutus = default(bool), bool pViewLog = default(bool), bool pEditConfig = default(bool), bool pViewStats = default(bool), bool pEditGenre = default(bool), bool pEditAuthors = default(bool), bool pEditPublishers = default(bool), bool pEditPartialUsers = default(bool))
        {
            this.PAddReleases = pAddReleases;
            this.PEditUsers = pEditUsers;
            this.PEditGroups = pEditGroups;
            this.PEditPoll = pEditPoll;
            this.PEditSeries = pEditSeries;
            this.PEditReviews = pEditReviews;
            this.PEditNews = pEditNews;
            this.PEditAffiliates = pEditAffiliates;
            this.PEditAboutus = pEditAboutus;
            this.PViewLog = pViewLog;
            this.PEditConfig = pEditConfig;
            this.PViewStats = pViewStats;
            this.PEditGenre = pEditGenre;
            this.PEditAuthors = pEditAuthors;
            this.PEditPublishers = pEditPublishers;
            this.PEditPartialUsers = pEditPartialUsers;
        }

        /// <summary>
        /// Gets or Sets PAddReleases
        /// </summary>
        [JsonPropertyName("p_add_releases")]
        public bool PAddReleases { get; set; }

        /// <summary>
        /// Gets or Sets PEditUsers
        /// </summary>
        [JsonPropertyName("p_edit_users")]
        public bool PEditUsers { get; set; }

        /// <summary>
        /// Gets or Sets PEditGroups
        /// </summary>
        [JsonPropertyName("p_edit_groups")]
        public bool PEditGroups { get; set; }

        /// <summary>
        /// Gets or Sets PEditPoll
        /// </summary>
        [JsonPropertyName("p_edit_poll")]
        public bool PEditPoll { get; set; }

        /// <summary>
        /// Gets or Sets PEditSeries
        /// </summary>
        [JsonPropertyName("p_edit_series")]
        public bool PEditSeries { get; set; }

        /// <summary>
        /// Gets or Sets PEditReviews
        /// </summary>
        [JsonPropertyName("p_edit_reviews")]
        public bool PEditReviews { get; set; }

        /// <summary>
        /// Gets or Sets PEditNews
        /// </summary>
        [JsonPropertyName("p_edit_news")]
        public bool PEditNews { get; set; }

        /// <summary>
        /// Gets or Sets PEditAffiliates
        /// </summary>
        [JsonPropertyName("p_edit_affiliates")]
        public bool PEditAffiliates { get; set; }

        /// <summary>
        /// Gets or Sets PEditAboutus
        /// </summary>
        [JsonPropertyName("p_edit_aboutus")]
        public bool PEditAboutus { get; set; }

        /// <summary>
        /// Gets or Sets PViewLog
        /// </summary>
        [JsonPropertyName("p_view_log")]
        public bool PViewLog { get; set; }

        /// <summary>
        /// Gets or Sets PEditConfig
        /// </summary>
        [JsonPropertyName("p_edit_config")]
        public bool PEditConfig { get; set; }

        /// <summary>
        /// Gets or Sets PViewStats
        /// </summary>
        [JsonPropertyName("p_view_stats")]
        public bool PViewStats { get; set; }

        /// <summary>
        /// Gets or Sets PEditGenre
        /// </summary>
        [JsonPropertyName("p_edit_genre")]
        public bool PEditGenre { get; set; }

        /// <summary>
        /// Gets or Sets PEditAuthors
        /// </summary>
        [JsonPropertyName("p_edit_authors")]
        public bool PEditAuthors { get; set; }

        /// <summary>
        /// Gets or Sets PEditPublishers
        /// </summary>
        [JsonPropertyName("p_edit_publishers")]
        public bool PEditPublishers { get; set; }

        /// <summary>
        /// Gets or Sets PEditPartialUsers
        /// </summary>
        [JsonPropertyName("p_edit_partial_users")]
        public bool PEditPartialUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserModelV1AdminPermissions {\n");
            sb.Append("  PAddReleases: ").Append(PAddReleases).Append("\n");
            sb.Append("  PEditUsers: ").Append(PEditUsers).Append("\n");
            sb.Append("  PEditGroups: ").Append(PEditGroups).Append("\n");
            sb.Append("  PEditPoll: ").Append(PEditPoll).Append("\n");
            sb.Append("  PEditSeries: ").Append(PEditSeries).Append("\n");
            sb.Append("  PEditReviews: ").Append(PEditReviews).Append("\n");
            sb.Append("  PEditNews: ").Append(PEditNews).Append("\n");
            sb.Append("  PEditAffiliates: ").Append(PEditAffiliates).Append("\n");
            sb.Append("  PEditAboutus: ").Append(PEditAboutus).Append("\n");
            sb.Append("  PViewLog: ").Append(PViewLog).Append("\n");
            sb.Append("  PEditConfig: ").Append(PEditConfig).Append("\n");
            sb.Append("  PViewStats: ").Append(PViewStats).Append("\n");
            sb.Append("  PEditGenre: ").Append(PEditGenre).Append("\n");
            sb.Append("  PEditAuthors: ").Append(PEditAuthors).Append("\n");
            sb.Append("  PEditPublishers: ").Append(PEditPublishers).Append("\n");
            sb.Append("  PEditPartialUsers: ").Append(PEditPartialUsers).Append("\n");
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
            return this.Equals(input as UserModelV1AdminPermissions);
        }

        /// <summary>
        /// Returns true if UserModelV1AdminPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of UserModelV1AdminPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserModelV1AdminPermissions input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.PAddReleases == input.PAddReleases ||
                    this.PAddReleases.Equals(input.PAddReleases)
                ) &&
                (
                    this.PEditUsers == input.PEditUsers ||
                    this.PEditUsers.Equals(input.PEditUsers)
                ) &&
                (
                    this.PEditGroups == input.PEditGroups ||
                    this.PEditGroups.Equals(input.PEditGroups)
                ) &&
                (
                    this.PEditPoll == input.PEditPoll ||
                    this.PEditPoll.Equals(input.PEditPoll)
                ) &&
                (
                    this.PEditSeries == input.PEditSeries ||
                    this.PEditSeries.Equals(input.PEditSeries)
                ) &&
                (
                    this.PEditReviews == input.PEditReviews ||
                    this.PEditReviews.Equals(input.PEditReviews)
                ) &&
                (
                    this.PEditNews == input.PEditNews ||
                    this.PEditNews.Equals(input.PEditNews)
                ) &&
                (
                    this.PEditAffiliates == input.PEditAffiliates ||
                    this.PEditAffiliates.Equals(input.PEditAffiliates)
                ) &&
                (
                    this.PEditAboutus == input.PEditAboutus ||
                    this.PEditAboutus.Equals(input.PEditAboutus)
                ) &&
                (
                    this.PViewLog == input.PViewLog ||
                    this.PViewLog.Equals(input.PViewLog)
                ) &&
                (
                    this.PEditConfig == input.PEditConfig ||
                    this.PEditConfig.Equals(input.PEditConfig)
                ) &&
                (
                    this.PViewStats == input.PViewStats ||
                    this.PViewStats.Equals(input.PViewStats)
                ) &&
                (
                    this.PEditGenre == input.PEditGenre ||
                    this.PEditGenre.Equals(input.PEditGenre)
                ) &&
                (
                    this.PEditAuthors == input.PEditAuthors ||
                    this.PEditAuthors.Equals(input.PEditAuthors)
                ) &&
                (
                    this.PEditPublishers == input.PEditPublishers ||
                    this.PEditPublishers.Equals(input.PEditPublishers)
                ) &&
                (
                    this.PEditPartialUsers == input.PEditPartialUsers ||
                    this.PEditPartialUsers.Equals(input.PEditPartialUsers)
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
                hashCode = (hashCode * 59) + this.PAddReleases.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditUsers.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditGroups.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditPoll.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditSeries.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditReviews.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditNews.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditAffiliates.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditAboutus.GetHashCode();
                hashCode = (hashCode * 59) + this.PViewLog.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditConfig.GetHashCode();
                hashCode = (hashCode * 59) + this.PViewStats.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditGenre.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditAuthors.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditPublishers.GetHashCode();
                hashCode = (hashCode * 59) + this.PEditPartialUsers.GetHashCode();
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