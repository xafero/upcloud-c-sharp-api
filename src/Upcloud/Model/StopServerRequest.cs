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
    /// stop server request
    /// </summary>
    [DataContract]
    public partial class StopServerRequest :  IEquatable<StopServerRequest>, IValidatableObject
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
        public StopTypeEnum? stopType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerRequest" /> class.
        /// </summary>
        /// <param name="stopType">Type of stop operation performed on the server. (default to StopTypeEnum.Soft).</param>
        /// <param name="timeout">The stop timeout in seconds..</param>
        public StopServerRequest(StopTypeEnum? stopType = StopTypeEnum.Soft, decimal? timeout = default(decimal?))
        {
            // use default value if no "stopType" provided
            if (stopType == null)
            {
                this.stopType = StopTypeEnum.Soft;
            }
            else
            {
                this.stopType = stopType;
            }
            this.timeout = timeout;
        }
        

        /// <summary>
        /// The stop timeout in seconds.
        /// </summary>
        /// <value>The stop timeout in seconds.</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public decimal? timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopServerRequest {\n");
            sb.Append("  stopType: ").Append(stopType).Append("\n");
            sb.Append("  timeout: ").Append(timeout).Append("\n");
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
            return this.Equals(input as StopServerRequest);
        }

        /// <summary>
        /// Returns true if StopServerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StopServerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopServerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.stopType == input.stopType ||
                    (this.stopType != null &&
                    this.stopType.Equals(input.stopType))
                ) && 
                (
                    this.timeout == input.timeout ||
                    (this.timeout != null &&
                    this.timeout.Equals(input.timeout))
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
                if (this.stopType != null)
                    hashCode = hashCode * 59 + this.stopType.GetHashCode();
                if (this.timeout != null)
                    hashCode = hashCode * 59 + this.timeout.GetHashCode();
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
            // timeout (decimal?) maximum
            if(this.timeout > (decimal?)600)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for timeout, must be a value less than or equal to 600.", new [] { "timeout" });
            }

            // timeout (decimal?) minimum
            if(this.timeout < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for timeout, must be a value greater than or equal to 1.", new [] { "timeout" });
            }

            yield break;
        }
    }

}
