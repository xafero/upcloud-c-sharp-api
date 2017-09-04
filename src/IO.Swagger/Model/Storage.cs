/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Storage
    /// </summary>
    [DataContract]
    public partial class Storage :  IEquatable<Storage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage" /> class.
        /// </summary>
        /// <param name="Size">The size of the storage in gigabytes..</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="Title">A short description..</param>
        /// <param name="Zone">Zone (default to &quot;The zone in which the storage will be created, e.g. fi-hel1. See Zones.&quot;).</param>
        /// <param name="BackupRule">BackupRule.</param>
        public Storage(decimal? Size = default(decimal?), StorageTier Tier = default(StorageTier), string Title = default(string), string Zone = "The zone in which the storage will be created, e.g. fi-hel1. See Zones.", BackupRule BackupRule = default(BackupRule))
        {
            this.Size = Size;
            this.Tier = Tier;
            this.Title = Title;
            // use default value if no "Zone" provided
            if (Zone == null)
            {
                this.Zone = "The zone in which the storage will be created, e.g. fi-hel1. See Zones.";
            }
            else
            {
                this.Zone = Zone;
            }
            this.BackupRule = BackupRule;
        }
        
        /// <summary>
        /// The size of the storage in gigabytes.
        /// </summary>
        /// <value>The size of the storage in gigabytes.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public StorageTier Tier { get; set; }

        /// <summary>
        /// A short description.
        /// </summary>
        /// <value>A short description.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string Zone { get; set; }

        /// <summary>
        /// Gets or Sets BackupRule
        /// </summary>
        [DataMember(Name="backup_rule", EmitDefaultValue=false)]
        public BackupRule BackupRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  BackupRule: ").Append(BackupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Storage);
        }

        /// <summary>
        /// Returns true if Storage instances are equal
        /// </summary>
        /// <param name="input">Instance of Storage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Storage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
                ) && 
                (
                    this.BackupRule == input.BackupRule ||
                    (this.BackupRule != null &&
                    this.BackupRule.Equals(input.BackupRule))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Zone != null)
                    hashCode = hashCode * 59 + this.Zone.GetHashCode();
                if (this.BackupRule != null)
                    hashCode = hashCode * 59 + this.BackupRule.GetHashCode();
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
            // Size (decimal?) maximum
            if(this.Size > (decimal?)1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value less than or equal to 1024.", new [] { "Size" });
            }

            // Size (decimal?) minimum
            if(this.Size < (decimal?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value greater than or equal to 10.", new [] { "Size" });
            }

            yield break;
        }
    }

}
