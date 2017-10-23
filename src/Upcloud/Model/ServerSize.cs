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
    /// ServerSize
    /// </summary>
    [DataContract]
    public partial class ServerSize :  IEquatable<ServerSize>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerSize" /> class.
        /// </summary>
        /// <param name="coreNumber">coreNumber.</param>
        /// <param name="memoryAmount">memoryAmount.</param>
        public ServerSize(decimal? coreNumber = default(decimal?), decimal? memoryAmount = default(decimal?))
        {
            this.coreNumber = coreNumber;
            this.memoryAmount = memoryAmount;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerSize {\n");
            sb.Append("  coreNumber: ").Append(coreNumber).Append("\n");
            sb.Append("  memoryAmount: ").Append(memoryAmount).Append("\n");
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
            return this.Equals(input as ServerSize);
        }

        /// <summary>
        /// Returns true if ServerSize instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerSize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerSize input)
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
