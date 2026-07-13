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
    /// UserModelSearchV1
    /// </summary>
    [DataContract(Name = "UserModelSearchV1")]
    public partial class UserModelSearchV1 : IEquatable<UserModelSearchV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserModelSearchV1" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="username">username.</param>
        /// <param name="url">url.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="timeJoined">timeJoined.</param>
        /// <param name="signature">signature.</param>
        /// <param name="forumTitle">forumTitle.</param>
        /// <param name="foldingAtHome">foldingAtHome.</param>
        /// <param name="profile">profile.</param>
        /// <param name="stats">stats.</param>
        /// <param name="userGroup">userGroup.</param>
        /// <param name="userGroupName">userGroupName.</param>
        public UserModelSearchV1(long userId = default(long), string username = default(string), string url = default(string), AvatarModelSearchV1 avatar = default(AvatarModelSearchV1), TimeV1 timeJoined = default(TimeV1), string signature = default(string), string forumTitle = default(string), bool foldingAtHome = default(bool), UserModelSearchV1Profile profile = default(UserModelSearchV1Profile), UserModelSearchV1Stats stats = default(UserModelSearchV1Stats), string userGroup = default(string), string userGroupName = default(string))
        {
            this.UserId = userId;
            this.Username = username;
            this.Url = url;
            this.Avatar = avatar;
            this.TimeJoined = timeJoined;
            this.Signature = signature;
            this.ForumTitle = forumTitle;
            this.FoldingAtHome = foldingAtHome;
            this.Profile = profile;
            this.Stats = stats;
            this.UserGroup = userGroup;
            this.UserGroupName = userGroupName;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long UserId { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [JsonPropertyName("username")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [JsonPropertyName("avatar")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AvatarModelSearchV1 Avatar { get; set; }

        /// <summary>
        /// Gets or Sets TimeJoined
        /// </summary>
        [JsonPropertyName("time_joined")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 TimeJoined { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [JsonPropertyName("signature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets ForumTitle
        /// </summary>
        [JsonPropertyName("forum_title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string ForumTitle { get; set; }

        /// <summary>
        /// Gets or Sets FoldingAtHome
        /// </summary>
        [JsonPropertyName("folding_at_home")]
        public bool FoldingAtHome { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [JsonPropertyName("profile")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public UserModelSearchV1Profile Profile { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [JsonPropertyName("stats")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public UserModelSearchV1Stats Stats { get; set; }

        /// <summary>
        /// Gets or Sets UserGroup
        /// </summary>
        [JsonPropertyName("user_group")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string UserGroup { get; set; }

        /// <summary>
        /// Gets or Sets UserGroupName
        /// </summary>
        [JsonPropertyName("user_group_name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string UserGroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserModelSearchV1 {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  TimeJoined: ").Append(TimeJoined).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  ForumTitle: ").Append(ForumTitle).Append("\n");
            sb.Append("  FoldingAtHome: ").Append(FoldingAtHome).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  UserGroup: ").Append(UserGroup).Append("\n");
            sb.Append("  UserGroupName: ").Append(UserGroupName).Append("\n");
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
            return this.Equals(input as UserModelSearchV1);
        }

        /// <summary>
        /// Returns true if UserModelSearchV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserModelSearchV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserModelSearchV1 input)
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) &&
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) &&
                (
                    this.TimeJoined == input.TimeJoined ||
                    (this.TimeJoined != null &&
                    this.TimeJoined.Equals(input.TimeJoined))
                ) &&
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) &&
                (
                    this.ForumTitle == input.ForumTitle ||
                    (this.ForumTitle != null &&
                    this.ForumTitle.Equals(input.ForumTitle))
                ) &&
                (
                    this.FoldingAtHome == input.FoldingAtHome ||
                    this.FoldingAtHome.Equals(input.FoldingAtHome)
                ) &&
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) &&
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) &&
                (
                    this.UserGroup == input.UserGroup ||
                    (this.UserGroup != null &&
                    this.UserGroup.Equals(input.UserGroup))
                ) &&
                (
                    this.UserGroupName == input.UserGroupName ||
                    (this.UserGroupName != null &&
                    this.UserGroupName.Equals(input.UserGroupName))
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
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.TimeJoined != null)
                {
                    hashCode = (hashCode * 59) + this.TimeJoined.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.ForumTitle != null)
                {
                    hashCode = (hashCode * 59) + this.ForumTitle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FoldingAtHome.GetHashCode();
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.Stats != null)
                {
                    hashCode = (hashCode * 59) + this.Stats.GetHashCode();
                }
                if (this.UserGroup != null)
                {
                    hashCode = (hashCode * 59) + this.UserGroup.GetHashCode();
                }
                if (this.UserGroupName != null)
                {
                    hashCode = (hashCode * 59) + this.UserGroupName.GetHashCode();
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