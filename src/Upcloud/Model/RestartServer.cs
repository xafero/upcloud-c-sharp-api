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
using static Upcloud.Model.RestartServerWrap;

namespace Upcloud.Model
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
        /// Gets or Sets restartServer
        /// </summary>
        [DataMember(Name="restart_server", EmitDefaultValue=false)]
        public RestartServerWrap restartServer { get; set; }

        public RestartServer(StopTypeEnum? stopType = StopTypeEnum.Soft, decimal? timeout = default(decimal?), TimeoutActionEnum? timeoutAction = default(TimeoutActionEnum?))
        {
            this.restartServer = new RestartServerWrap(stopType, timeout, timeoutAction);
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartServer {\n");
            sb.Append("  restartServer: ").Append(restartServer).Append("\n");
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
                    this.restartServer == input.restartServer ||
                    (this.restartServer != null &&
                    this.restartServer.Equals(input.restartServer))
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
                if (this.restartServer != null)
                    hashCode = hashCode * 59 + this.restartServer.GetHashCode();
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
