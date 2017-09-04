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
    /// StopServer
    /// </summary>
    [DataContract]
    public partial class StopServer :  IEquatable<StopServer>, IValidatableObject
    {
        /// <summary>
        /// Type of stop operation performed on the server.
        /// </summary>
        /// <value>Type of stop operation performed on the server.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StopTypeEnum
        {
            
            /// <summary>
            /// Enum Soft for "soft"
            /// </summary>
            [EnumMember(Value = "soft")]
            Soft,
            
            /// <summary>
            /// Enum Hard for "hard"
            /// </summary>
            [EnumMember(Value = "hard")]
            Hard
        }

        /// <summary>
        /// Type of stop operation performed on the server.
        /// </summary>
        /// <value>Type of stop operation performed on the server.</value>
        [DataMember(Name="stop_type", EmitDefaultValue=false)]
        public StopTypeEnum? StopType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopServer" /> class.
        /// </summary>
        /// <param name="StopType">Type of stop operation performed on the server. (default to StopTypeEnum.Soft).</param>
        /// <param name="Timeout">The stop timeout in seconds..</param>
        public StopServer(StopTypeEnum? StopType = StopTypeEnum.Soft, decimal? Timeout = default(decimal?))
        {
            // use default value if no "StopType" provided
            if (StopType == null)
            {
                this.StopType = StopTypeEnum.Soft;
            }
            else
            {
                this.StopType = StopType;
            }
            this.Timeout = Timeout;
        }
        

        /// <summary>
        /// The stop timeout in seconds.
        /// </summary>
        /// <value>The stop timeout in seconds.</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public decimal? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopServer {\n");
            sb.Append("  StopType: ").Append(StopType).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as StopServer);
        }

        /// <summary>
        /// Returns true if StopServer instances are equal
        /// </summary>
        /// <param name="input">Instance of StopServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopType == input.StopType ||
                    (this.StopType != null &&
                    this.StopType.Equals(input.StopType))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
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
                if (this.StopType != null)
                    hashCode = hashCode * 59 + this.StopType.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
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
            // Timeout (decimal?) maximum
            if(this.Timeout > (decimal?)600)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value less than or equal to 600.", new [] { "Timeout" });
            }

            // Timeout (decimal?) minimum
            if(this.Timeout < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timeout, must be a value greater than or equal to 1.", new [] { "Timeout" });
            }

            yield break;
        }
    }

}
