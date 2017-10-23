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
    /// StorageDevice
    /// </summary>
    [DataContract]
    public partial class StorageDevice :  IEquatable<StorageDevice>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets partOfPlan
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartOfPlanEnum
        {
            
            /// <summary>
            /// Enum Yes for "yes"
            /// </summary>
            [EnumMember(Value = "yes")]
            Yes,
            
            /// <summary>
            /// Enum No for "no"
            /// </summary>
            [EnumMember(Value = "no")]
            No
        }

        /// <summary>
        /// Gets or Sets partOfPlan
        /// </summary>
        [DataMember(Name="part_of_plan", EmitDefaultValue=false)]
        public PartOfPlanEnum? partOfPlan { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDevice" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="size">size.</param>
        /// <param name="tier">tier.</param>
        /// <param name="action">action.</param>
        /// <param name="address">address.</param>
        /// <param name="partOfPlan">partOfPlan.</param>
        /// <param name="storage">storage.</param>
        /// <param name="storageSize">storageSize.</param>
        /// <param name="storageTitle">storageTitle.</param>
        /// <param name="type">type.</param>
        public StorageDevice(string title = default(string), decimal? size = default(decimal?), string tier = default(string), string action = default(string), string address = default(string), PartOfPlanEnum? partOfPlan = default(PartOfPlanEnum?), string storage = default(string), decimal? storageSize = default(decimal?), string storageTitle = default(string), string type = default(string))
        {
            this.title = title;
            this.size = size;
            this.tier = tier;
            this.action = action;
            this.address = address;
            this.partOfPlan = partOfPlan;
            this.storage = storage;
            this.storageSize = storageSize;
            this.storageTitle = storageTitle;
            this.type = type;
        }
        
        /// <summary>
        /// Gets or Sets title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string title { get; set; }

        /// <summary>
        /// Gets or Sets size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? size { get; set; }

        /// <summary>
        /// Gets or Sets tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string tier { get; set; }

        /// <summary>
        /// Gets or Sets action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string action { get; set; }

        /// <summary>
        /// Gets or Sets address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string address { get; set; }


        /// <summary>
        /// Gets or Sets storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public string storage { get; set; }

        /// <summary>
        /// Gets or Sets storageSize
        /// </summary>
        [DataMember(Name="storage_size", EmitDefaultValue=false)]
        public decimal? storageSize { get; set; }

        /// <summary>
        /// Gets or Sets storageTitle
        /// </summary>
        [DataMember(Name="storage_title", EmitDefaultValue=false)]
        public string storageTitle { get; set; }

        /// <summary>
        /// Gets or Sets type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageDevice {\n");
            sb.Append("  title: ").Append(title).Append("\n");
            sb.Append("  size: ").Append(size).Append("\n");
            sb.Append("  tier: ").Append(tier).Append("\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  address: ").Append(address).Append("\n");
            sb.Append("  partOfPlan: ").Append(partOfPlan).Append("\n");
            sb.Append("  storage: ").Append(storage).Append("\n");
            sb.Append("  storageSize: ").Append(storageSize).Append("\n");
            sb.Append("  storageTitle: ").Append(storageTitle).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
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
            return this.Equals(input as StorageDevice);
        }

        /// <summary>
        /// Returns true if StorageDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.title == input.title ||
                    (this.title != null &&
                    this.title.Equals(input.title))
                ) && 
                (
                    this.size == input.size ||
                    (this.size != null &&
                    this.size.Equals(input.size))
                ) && 
                (
                    this.tier == input.tier ||
                    (this.tier != null &&
                    this.tier.Equals(input.tier))
                ) && 
                (
                    this.action == input.action ||
                    (this.action != null &&
                    this.action.Equals(input.action))
                ) && 
                (
                    this.address == input.address ||
                    (this.address != null &&
                    this.address.Equals(input.address))
                ) && 
                (
                    this.partOfPlan == input.partOfPlan ||
                    (this.partOfPlan != null &&
                    this.partOfPlan.Equals(input.partOfPlan))
                ) && 
                (
                    this.storage == input.storage ||
                    (this.storage != null &&
                    this.storage.Equals(input.storage))
                ) && 
                (
                    this.storageSize == input.storageSize ||
                    (this.storageSize != null &&
                    this.storageSize.Equals(input.storageSize))
                ) && 
                (
                    this.storageTitle == input.storageTitle ||
                    (this.storageTitle != null &&
                    this.storageTitle.Equals(input.storageTitle))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
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
                if (this.title != null)
                    hashCode = hashCode * 59 + this.title.GetHashCode();
                if (this.size != null)
                    hashCode = hashCode * 59 + this.size.GetHashCode();
                if (this.tier != null)
                    hashCode = hashCode * 59 + this.tier.GetHashCode();
                if (this.action != null)
                    hashCode = hashCode * 59 + this.action.GetHashCode();
                if (this.address != null)
                    hashCode = hashCode * 59 + this.address.GetHashCode();
                if (this.partOfPlan != null)
                    hashCode = hashCode * 59 + this.partOfPlan.GetHashCode();
                if (this.storage != null)
                    hashCode = hashCode * 59 + this.storage.GetHashCode();
                if (this.storageSize != null)
                    hashCode = hashCode * 59 + this.storageSize.GetHashCode();
                if (this.storageTitle != null)
                    hashCode = hashCode * 59 + this.storageTitle.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
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
