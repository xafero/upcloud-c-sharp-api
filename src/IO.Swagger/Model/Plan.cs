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
    /// Server plans are preconfigured server configurations with fixed price. Each plan includes certain number of CPU cores, memory amount, storage and transfer quota in addition of one public IPv4 address (private IPv4 addresses and public IPv6 addresses are currently free of charge, so they are not included in plan).
    /// </summary>
    [DataContract]
    public partial class Plan :  IEquatable<Plan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="CoreNumber">CoreNumber.</param>
        /// <param name="MemoryAmount">MemoryAmount.</param>
        /// <param name="Name">Name.</param>
        /// <param name="PublicTrafficOut">PublicTrafficOut.</param>
        /// <param name="StorageSize">StorageSize.</param>
        /// <param name="StorageTier">StorageTier.</param>
        public Plan(decimal? CoreNumber = default(decimal?), decimal? MemoryAmount = default(decimal?), string Name = default(string), string PublicTrafficOut = default(string), string StorageSize = default(string), string StorageTier = default(string))
        {
            this.CoreNumber = CoreNumber;
            this.MemoryAmount = MemoryAmount;
            this.Name = Name;
            this.PublicTrafficOut = PublicTrafficOut;
            this.StorageSize = StorageSize;
            this.StorageTier = StorageTier;
        }
        
        /// <summary>
        /// Gets or Sets CoreNumber
        /// </summary>
        [DataMember(Name="core_number", EmitDefaultValue=false)]
        public decimal? CoreNumber { get; set; }

        /// <summary>
        /// Gets or Sets MemoryAmount
        /// </summary>
        [DataMember(Name="memory_amount", EmitDefaultValue=false)]
        public decimal? MemoryAmount { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PublicTrafficOut
        /// </summary>
        [DataMember(Name="public_traffic_out", EmitDefaultValue=false)]
        public string PublicTrafficOut { get; set; }

        /// <summary>
        /// Gets or Sets StorageSize
        /// </summary>
        [DataMember(Name="storage_size", EmitDefaultValue=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// Gets or Sets StorageTier
        /// </summary>
        [DataMember(Name="storage_tier", EmitDefaultValue=false)]
        public string StorageTier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Plan {\n");
            sb.Append("  CoreNumber: ").Append(CoreNumber).Append("\n");
            sb.Append("  MemoryAmount: ").Append(MemoryAmount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublicTrafficOut: ").Append(PublicTrafficOut).Append("\n");
            sb.Append("  StorageSize: ").Append(StorageSize).Append("\n");
            sb.Append("  StorageTier: ").Append(StorageTier).Append("\n");
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
            return this.Equals(input as Plan);
        }

        /// <summary>
        /// Returns true if Plan instances are equal
        /// </summary>
        /// <param name="input">Instance of Plan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoreNumber == input.CoreNumber ||
                    (this.CoreNumber != null &&
                    this.CoreNumber.Equals(input.CoreNumber))
                ) && 
                (
                    this.MemoryAmount == input.MemoryAmount ||
                    (this.MemoryAmount != null &&
                    this.MemoryAmount.Equals(input.MemoryAmount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicTrafficOut == input.PublicTrafficOut ||
                    (this.PublicTrafficOut != null &&
                    this.PublicTrafficOut.Equals(input.PublicTrafficOut))
                ) && 
                (
                    this.StorageSize == input.StorageSize ||
                    (this.StorageSize != null &&
                    this.StorageSize.Equals(input.StorageSize))
                ) && 
                (
                    this.StorageTier == input.StorageTier ||
                    (this.StorageTier != null &&
                    this.StorageTier.Equals(input.StorageTier))
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
                if (this.CoreNumber != null)
                    hashCode = hashCode * 59 + this.CoreNumber.GetHashCode();
                if (this.MemoryAmount != null)
                    hashCode = hashCode * 59 + this.MemoryAmount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublicTrafficOut != null)
                    hashCode = hashCode * 59 + this.PublicTrafficOut.GetHashCode();
                if (this.StorageSize != null)
                    hashCode = hashCode * 59 + this.StorageSize.GetHashCode();
                if (this.StorageTier != null)
                    hashCode = hashCode * 59 + this.StorageTier.GetHashCode();
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