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
using SwaggerDateConverter = Upcloud.Client.SwaggerDateConverter;

namespace Upcloud.Model
{
    /// <summary>
    /// Storage2
    /// </summary>
    [DataContract]
    public partial class Storage2 :  IEquatable<Storage2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage2" /> class.
        /// </summary>
        /// <param name="Zone">The zone in which the storage will be created, e.g. fi-hel1. See Zones..</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="Title">A short description..</param>
        public Storage2(string Zone = default(string), StorageTier Tier = default(StorageTier), string Title = default(string))
        {
            this.Zone = Zone;
            this.Tier = Tier;
            this.Title = Title;
        }
        
        /// <summary>
        /// The zone in which the storage will be created, e.g. fi-hel1. See Zones.
        /// </summary>
        /// <value>The zone in which the storage will be created, e.g. fi-hel1. See Zones.</value>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string Zone { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage2 {\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as Storage2);
        }

        /// <summary>
        /// Returns true if Storage2 instances are equal
        /// </summary>
        /// <param name="input">Instance of Storage2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Storage2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
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
                if (this.Zone != null)
                    hashCode = hashCode * 59 + this.Zone.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 64.", new [] { "Title" });
            }

            yield break;
        }
    }

}
