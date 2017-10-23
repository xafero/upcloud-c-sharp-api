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
    /// Server plans are preconfigured server configurations with fixed price. Each plan includes certain number of CPU cores, memory amount, storage and transfer quota in addition of one public IPv4 address (private IPv4 addresses and public IPv6 addresses are currently free of charge, so they are not included in plan).
    /// </summary>
    [DataContract]
    public partial class Plan :  IEquatable<Plan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="coreNumber">coreNumber.</param>
        /// <param name="memoryAmount">memoryAmount.</param>
        /// <param name="name">name.</param>
        /// <param name="publicTrafficOut">publicTrafficOut.</param>
        /// <param name="storageSize">storageSize.</param>
        /// <param name="storageTier">storageTier.</param>
        public Plan(decimal? coreNumber = default(decimal?), decimal? memoryAmount = default(decimal?), string name = default(string), string publicTrafficOut = default(string), string storageSize = default(string), string storageTier = default(string))
        {
            this.coreNumber = coreNumber;
            this.memoryAmount = memoryAmount;
            this.name = name;
            this.publicTrafficOut = publicTrafficOut;
            this.storageSize = storageSize;
            this.storageTier = storageTier;
        }
        
        /// <summary>
        /// Gets or Sets coreNumber
        /// </summary>
        [DataMember(Name="core_number", EmitDefaultValue=false)]
        public decimal? coreNumber { get; set; }

        /// <summary>
        /// Gets or Sets memoryAmount
        /// </summary>
        [DataMember(Name="memory_amount", EmitDefaultValue=false)]
        public decimal? memoryAmount { get; set; }

        /// <summary>
        /// Gets or Sets name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Gets or Sets publicTrafficOut
        /// </summary>
        [DataMember(Name="public_traffic_out", EmitDefaultValue=false)]
        public string publicTrafficOut { get; set; }

        /// <summary>
        /// Gets or Sets storageSize
        /// </summary>
        [DataMember(Name="storage_size", EmitDefaultValue=false)]
        public string storageSize { get; set; }

        /// <summary>
        /// Gets or Sets storageTier
        /// </summary>
        [DataMember(Name="storage_tier", EmitDefaultValue=false)]
        public string storageTier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Plan {\n");
            sb.Append("  coreNumber: ").Append(coreNumber).Append("\n");
            sb.Append("  memoryAmount: ").Append(memoryAmount).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  publicTrafficOut: ").Append(publicTrafficOut).Append("\n");
            sb.Append("  storageSize: ").Append(storageSize).Append("\n");
            sb.Append("  storageTier: ").Append(storageTier).Append("\n");
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
                    this.coreNumber == input.coreNumber ||
                    (this.coreNumber != null &&
                    this.coreNumber.Equals(input.coreNumber))
                ) && 
                (
                    this.memoryAmount == input.memoryAmount ||
                    (this.memoryAmount != null &&
                    this.memoryAmount.Equals(input.memoryAmount))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.publicTrafficOut == input.publicTrafficOut ||
                    (this.publicTrafficOut != null &&
                    this.publicTrafficOut.Equals(input.publicTrafficOut))
                ) && 
                (
                    this.storageSize == input.storageSize ||
                    (this.storageSize != null &&
                    this.storageSize.Equals(input.storageSize))
                ) && 
                (
                    this.storageTier == input.storageTier ||
                    (this.storageTier != null &&
                    this.storageTier.Equals(input.storageTier))
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
                if (this.coreNumber != null)
                    hashCode = hashCode * 59 + this.coreNumber.GetHashCode();
                if (this.memoryAmount != null)
                    hashCode = hashCode * 59 + this.memoryAmount.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.publicTrafficOut != null)
                    hashCode = hashCode * 59 + this.publicTrafficOut.GetHashCode();
                if (this.storageSize != null)
                    hashCode = hashCode * 59 + this.storageSize.GetHashCode();
                if (this.storageTier != null)
                    hashCode = hashCode * 59 + this.storageTier.GetHashCode();
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
