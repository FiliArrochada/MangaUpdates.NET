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
    /// AuthorsModelV1
    /// </summary>
    [DataContract(Name = "AuthorsModelV1")]
    public partial class AuthorsModelV1 : IEquatable<AuthorsModelV1>, IValidatableObject
    {
        /// <summary>
        /// Defines Bloodtype
        /// </summary>
        [JsonConverter(typeof(MangaUpdates.Client.JsonStringEnumMemberConverter))]
        public enum BloodtypeEnum
        {
            /// <summary>
            /// Enum NA for value: N/A
            /// </summary>
            [EnumMember(Value = "N/A")]
            NA = 1,

            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 2,

            /// <summary>
            /// Enum B for value: B
            /// </summary>
            [EnumMember(Value = "B")]
            B = 3,

            /// <summary>
            /// Enum AB for value: AB
            /// </summary>
            [EnumMember(Value = "AB")]
            AB = 4,

            /// <summary>
            /// Enum O for value: O
            /// </summary>
            [EnumMember(Value = "O")]
            O = 5

        }


        /// <summary>
        /// Gets or Sets Bloodtype
        /// </summary>
        [JsonPropertyName("bloodtype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public BloodtypeEnum? Bloodtype { get; set; }
        /// <summary>
        /// Defines Gender
        /// </summary>
        [JsonConverter(typeof(MangaUpdates.Client.JsonStringEnumMemberConverter))]
        public enum GenderEnum
        {
            /// <summary>
            /// Enum NA for value: N/A
            /// </summary>
            [EnumMember(Value = "N/A")]
            NA = 1,

            /// <summary>
            /// Enum Male for value: Male
            /// </summary>
            [EnumMember(Value = "Male")]
            Male = 2,

            /// <summary>
            /// Enum Female for value: Female
            /// </summary>
            [EnumMember(Value = "Female")]
            Female = 3,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 4

        }


        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [JsonPropertyName("gender")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsModelV1" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        /// <param name="associated">associated.</param>
        /// <param name="image">image.</param>
        /// <param name="actualname">actualname.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="birthplace">birthplace.</param>
        /// <param name="bloodtype">bloodtype.</param>
        /// <param name="gender">gender.</param>
        /// <param name="genres">genres.</param>
        /// <param name="stats">stats.</param>
        /// <param name="social">social.</param>
        /// <param name="comments">comments.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="addedBy">addedBy.</param>
        /// <param name="admin">admin.</param>
        public AuthorsModelV1(long id = default(long), string name = default(string), string url = default(string), List<AuthorsModelV1Associated> associated = default(List<AuthorsModelV1Associated>), ImageModelV1 image = default(ImageModelV1), string actualname = default(string), BirthdayModelV1 birthday = default(BirthdayModelV1), string birthplace = default(string), BloodtypeEnum? bloodtype = default(BloodtypeEnum?), GenderEnum? gender = default(GenderEnum?), List<string> genres = default(List<string>), AuthorsModelV1Stats stats = default(AuthorsModelV1Stats), AuthorsModelV1Social social = default(AuthorsModelV1Social), string comments = default(string), TimeV1 lastUpdated = default(TimeV1), UserModelSearchV1 addedBy = default(UserModelSearchV1), AuthorsModelV1Admin admin = default(AuthorsModelV1Admin))
        {
            this.Id = id;
            this.Name = name;
            this.Url = url;
            this.Associated = associated;
            this.Image = image;
            this.Actualname = actualname;
            this.Birthday = birthday;
            this.Birthplace = birthplace;
            this.Bloodtype = bloodtype;
            this.Gender = gender;
            this.Genres = genres;
            this.Stats = stats;
            this.Social = social;
            this.Comments = comments;
            this.LastUpdated = lastUpdated;
            this.AddedBy = addedBy;
            this.Admin = admin;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [JsonPropertyName("url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Associated
        /// </summary>
        [JsonPropertyName("associated")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<AuthorsModelV1Associated> Associated { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [JsonPropertyName("image")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ImageModelV1 Image { get; set; }

        /// <summary>
        /// Gets or Sets Actualname
        /// </summary>
        [JsonPropertyName("actualname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Actualname { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [JsonPropertyName("birthday")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public BirthdayModelV1 Birthday { get; set; }

        /// <summary>
        /// Gets or Sets Birthplace
        /// </summary>
        [JsonPropertyName("birthplace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Birthplace { get; set; }

        /// <summary>
        /// Gets or Sets Genres
        /// </summary>
        [JsonPropertyName("genres")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [JsonPropertyName("stats")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AuthorsModelV1Stats Stats { get; set; }

        /// <summary>
        /// Gets or Sets Social
        /// </summary>
        [JsonPropertyName("social")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AuthorsModelV1Social Social { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [JsonPropertyName("comments")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [JsonPropertyName("last_updated")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeV1 LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets AddedBy
        /// </summary>
        [JsonPropertyName("added_by")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public UserModelSearchV1 AddedBy { get; set; }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [JsonPropertyName("admin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public AuthorsModelV1Admin Admin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorsModelV1 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Associated: ").Append(Associated).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Actualname: ").Append(Actualname).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Birthplace: ").Append(Birthplace).Append("\n");
            sb.Append("  Bloodtype: ").Append(Bloodtype).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Social: ").Append(Social).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
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
            return this.Equals(input as AuthorsModelV1);
        }

        /// <summary>
        /// Returns true if AuthorsModelV1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorsModelV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorsModelV1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Associated == input.Associated ||
                    this.Associated != null &&
                    input.Associated != null &&
                    this.Associated.SequenceEqual(input.Associated)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Actualname == input.Actualname ||
                    (this.Actualname != null &&
                    this.Actualname.Equals(input.Actualname))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.Birthplace == input.Birthplace ||
                    (this.Birthplace != null &&
                    this.Birthplace.Equals(input.Birthplace))
                ) && 
                (
                    this.Bloodtype == input.Bloodtype ||
                    this.Bloodtype.Equals(input.Bloodtype)
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Genres == input.Genres ||
                    this.Genres != null &&
                    input.Genres != null &&
                    this.Genres.SequenceEqual(input.Genres)
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Social == input.Social ||
                    (this.Social != null &&
                    this.Social.Equals(input.Social))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.AddedBy == input.AddedBy ||
                    (this.AddedBy != null &&
                    this.AddedBy.Equals(input.AddedBy))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Associated != null)
                {
                    hashCode = (hashCode * 59) + this.Associated.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Actualname != null)
                {
                    hashCode = (hashCode * 59) + this.Actualname.GetHashCode();
                }
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                if (this.Birthplace != null)
                {
                    hashCode = (hashCode * 59) + this.Birthplace.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bloodtype.GetHashCode();
                hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                if (this.Genres != null)
                {
                    hashCode = (hashCode * 59) + this.Genres.GetHashCode();
                }
                if (this.Stats != null)
                {
                    hashCode = (hashCode * 59) + this.Stats.GetHashCode();
                }
                if (this.Social != null)
                {
                    hashCode = (hashCode * 59) + this.Social.GetHashCode();
                }
                if (this.Comments != null)
                {
                    hashCode = (hashCode * 59) + this.Comments.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.AddedBy != null)
                {
                    hashCode = (hashCode * 59) + this.AddedBy.GetHashCode();
                }
                if (this.Admin != null)
                {
                    hashCode = (hashCode * 59) + this.Admin.GetHashCode();
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
