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
    /// ServerSize
    /// </summary>
    [DataContract]
    public partial class ServerSize :  IEquatable<ServerSize>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerSize" /> class.
        /// </summary>
        /// <param name="CoreNumber">CoreNumber.</param>
        /// <param name="MemoryAmount">MemoryAmount.</param>
        public ServerSize(decimal? CoreNumber = default(decimal?), decimal? MemoryAmount = default(decimal?))
        {
            this.CoreNumber = CoreNumber;
            this.MemoryAmount = MemoryAmount;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerSize {\n");
            sb.Append("  CoreNumber: ").Append(CoreNumber).Append("\n");
            sb.Append("  MemoryAmount: ").Append(MemoryAmount).Append("\n");
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
                    this.CoreNumber == input.CoreNumber ||
                    (this.CoreNumber != null &&
                    this.CoreNumber.Equals(input.CoreNumber))
                ) && 
                (
                    this.MemoryAmount == input.MemoryAmount ||
                    (this.MemoryAmount != null &&
                    this.MemoryAmount.Equals(input.MemoryAmount))
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
