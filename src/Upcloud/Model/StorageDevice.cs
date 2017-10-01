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
        /// Gets or Sets PartOfPlan
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
        /// Gets or Sets PartOfPlan
        /// </summary>
        [DataMember(Name="part_of_plan", EmitDefaultValue=false)]
        public PartOfPlanEnum? PartOfPlan { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDevice" /> class.
        /// </summary>
        /// <param name="Title">Title.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Address">Address.</param>
        /// <param name="PartOfPlan">PartOfPlan.</param>
        /// <param name="Storage">Storage.</param>
        /// <param name="StorageSize">StorageSize.</param>
        /// <param name="StorageTitle">StorageTitle.</param>
        /// <param name="Type">Type.</param>
        public StorageDevice(string Title = default(string), decimal? Size = default(decimal?), string Tier = default(string), string Action = default(string), string Address = default(string), PartOfPlanEnum? PartOfPlan = default(PartOfPlanEnum?), string Storage = default(string), decimal? StorageSize = default(decimal?), string StorageTitle = default(string), string Type = default(string))
        {
            this.Title = Title;
            this.Size = Size;
            this.Tier = Tier;
            this.Action = Action;
            this.Address = Address;
            this.PartOfPlan = PartOfPlan;
            this.Storage = Storage;
            this.StorageSize = StorageSize;
            this.StorageTitle = StorageTitle;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }


        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public string Storage { get; set; }

        /// <summary>
        /// Gets or Sets StorageSize
        /// </summary>
        [DataMember(Name="storage_size", EmitDefaultValue=false)]
        public decimal? StorageSize { get; set; }

        /// <summary>
        /// Gets or Sets StorageTitle
        /// </summary>
        [DataMember(Name="storage_title", EmitDefaultValue=false)]
        public string StorageTitle { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageDevice {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PartOfPlan: ").Append(PartOfPlan).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  StorageSize: ").Append(StorageSize).Append("\n");
            sb.Append("  StorageTitle: ").Append(StorageTitle).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PartOfPlan == input.PartOfPlan ||
                    (this.PartOfPlan != null &&
                    this.PartOfPlan.Equals(input.PartOfPlan))
                ) && 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.StorageSize == input.StorageSize ||
                    (this.StorageSize != null &&
                    this.StorageSize.Equals(input.StorageSize))
                ) && 
                (
                    this.StorageTitle == input.StorageTitle ||
                    (this.StorageTitle != null &&
                    this.StorageTitle.Equals(input.StorageTitle))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PartOfPlan != null)
                    hashCode = hashCode * 59 + this.PartOfPlan.GetHashCode();
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.StorageSize != null)
                    hashCode = hashCode * 59 + this.StorageSize.GetHashCode();
                if (this.StorageTitle != null)
                    hashCode = hashCode * 59 + this.StorageTitle.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
