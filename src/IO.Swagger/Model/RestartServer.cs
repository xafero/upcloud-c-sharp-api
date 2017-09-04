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
    /// RestartServer
    /// </summary>
    [DataContract]
    public partial class RestartServer :  IEquatable<RestartServer>, IValidatableObject
    {
        /// <summary>
        /// Restart type
        /// </summary>
        /// <value>Restart type</value>
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
        /// Action to take if timeout limit is exceeded.
        /// </summary>
        /// <value>Action to take if timeout limit is exceeded.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeoutActionEnum
        {
            
            /// <summary>
            /// Enum Destroy for "destroy"
            /// </summary>
            [EnumMember(Value = "destroy")]
            Destroy,
            
            /// <summary>
            /// Enum Ignore for "ignore"
            /// </summary>
            [EnumMember(Value = "ignore")]
            Ignore
        }

        /// <summary>
        /// Restart type
        /// </summary>
        /// <value>Restart type</value>
        [DataMember(Name="stop_type", EmitDefaultValue=false)]
        public StopTypeEnum? StopType { get; set; }
        /// <summary>
        /// Action to take if timeout limit is exceeded.
        /// </summary>
        /// <value>Action to take if timeout limit is exceeded.</value>
        [DataMember(Name="timeout_action", EmitDefaultValue=false)]
        public TimeoutActionEnum? TimeoutAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartServer" /> class.
        /// </summary>
        /// <param name="StopType">Restart type (default to StopTypeEnum.Soft).</param>
        /// <param name="Timeout">Stop timeout in seconds.</param>
        /// <param name="TimeoutAction">Action to take if timeout limit is exceeded..</param>
        public RestartServer(StopTypeEnum? StopType = StopTypeEnum.Soft, decimal? Timeout = default(decimal?), TimeoutActionEnum? TimeoutAction = default(TimeoutActionEnum?))
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
            this.TimeoutAction = TimeoutAction;
        }
        

        /// <summary>
        /// Stop timeout in seconds
        /// </summary>
        /// <value>Stop timeout in seconds</value>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public decimal? Timeout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartServer {\n");
            sb.Append("  StopType: ").Append(StopType).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  TimeoutAction: ").Append(TimeoutAction).Append("\n");
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
            return this.Equals(input as RestartServer);
        }

        /// <summary>
        /// Returns true if RestartServer instances are equal
        /// </summary>
        /// <param name="input">Instance of RestartServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestartServer input)
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
                ) && 
                (
                    this.TimeoutAction == input.TimeoutAction ||
                    (this.TimeoutAction != null &&
                    this.TimeoutAction.Equals(input.TimeoutAction))
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
                if (this.TimeoutAction != null)
                    hashCode = hashCode * 59 + this.TimeoutAction.GetHashCode();
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
