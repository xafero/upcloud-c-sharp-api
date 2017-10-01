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
    /// ErrorError
    /// </summary>
    [DataContract]
    public partial class ErrorError :  IEquatable<ErrorError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError" /> class.
        /// </summary>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorStatus">ErrorStatus.</param>
        public ErrorError(ErrorCode ErrorCode = default(ErrorCode), ErrorStatus ErrorStatus = default(ErrorStatus))
        {
            this.ErrorCode = ErrorCode;
            this.ErrorStatus = ErrorStatus;
        }
        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="error_code", EmitDefaultValue=false)]
        public ErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorStatus
        /// </summary>
        [DataMember(Name="error_status", EmitDefaultValue=false)]
        public ErrorStatus ErrorStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorError {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorStatus: ").Append(ErrorStatus).Append("\n");
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
            return this.Equals(input as ErrorError);
        }

        /// <summary>
        /// Returns true if ErrorError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
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
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorStatus != null)
                    hashCode = hashCode * 59 + this.ErrorStatus.GetHashCode();
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
