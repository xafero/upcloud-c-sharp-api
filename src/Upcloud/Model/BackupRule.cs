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
    /// The backup_rule block defines when the storage device is backed up automatically.
    /// </summary>
    [DataContract]
    public partial class BackupRule :  IEquatable<BackupRule>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets interval
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            
            /// <summary>
            /// Enum Daily for "daily"
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily,
            
            /// <summary>
            /// Enum Mon for "mon"
            /// </summary>
            [EnumMember(Value = "mon")]
            Mon,
            
            /// <summary>
            /// Enum Tue for "tue"
            /// </summary>
            [EnumMember(Value = "tue")]
            Tue,
            
            /// <summary>
            /// Enum Wed for "wed"
            /// </summary>
            [EnumMember(Value = "wed")]
            Wed,
            
            /// <summary>
            /// Enum Thu for "thu"
            /// </summary>
            [EnumMember(Value = "thu")]
            Thu,
            
            /// <summary>
            /// Enum Fri for "fri"
            /// </summary>
            [EnumMember(Value = "fri")]
            Fri,
            
            /// <summary>
            /// Enum Sat for "sat"
            /// </summary>
            [EnumMember(Value = "sat")]
            Sat,
            
            /// <summary>
            /// Enum Sun for "sun"
            /// </summary>
            [EnumMember(Value = "sun")]
            Sun
        }

        /// <summary>
        /// Gets or Sets interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public IntervalEnum? interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRule" /> class.
        /// </summary>
        /// <param name="interval">interval.</param>
        /// <param name="time">time.</param>
        /// <param name="retention">retention.</param>
        public BackupRule(IntervalEnum? interval = default(IntervalEnum?), string time = default(string), decimal? retention = default(decimal?))
        {
            this.interval = interval;
            this.time = time;
            this.retention = retention;
        }
        

        /// <summary>
        /// Gets or Sets time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string time { get; set; }

        /// <summary>
        /// Gets or Sets retention
        /// </summary>
        [DataMember(Name="retention", EmitDefaultValue=false)]
        public decimal? retention { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRule {\n");
            sb.Append("  interval: ").Append(interval).Append("\n");
            sb.Append("  time: ").Append(time).Append("\n");
            sb.Append("  retention: ").Append(retention).Append("\n");
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
            return this.Equals(input as BackupRule);
        }

        /// <summary>
        /// Returns true if BackupRule instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.interval == input.interval ||
                    (this.interval != null &&
                    this.interval.Equals(input.interval))
                ) && 
                (
                    this.time == input.time ||
                    (this.time != null &&
                    this.time.Equals(input.time))
                ) && 
                (
                    this.retention == input.retention ||
                    (this.retention != null &&
                    this.retention.Equals(input.retention))
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
                if (this.interval != null)
                    hashCode = hashCode * 59 + this.interval.GetHashCode();
                if (this.time != null)
                    hashCode = hashCode * 59 + this.time.GetHashCode();
                if (this.retention != null)
                    hashCode = hashCode * 59 + this.retention.GetHashCode();
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
