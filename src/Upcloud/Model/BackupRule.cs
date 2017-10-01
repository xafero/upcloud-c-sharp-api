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
        /// Gets or Sets Interval
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
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public IntervalEnum? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRule" /> class.
        /// </summary>
        /// <param name="Interval">Interval.</param>
        /// <param name="Time">Time.</param>
        /// <param name="Retention">Retention.</param>
        public BackupRule(IntervalEnum? Interval = default(IntervalEnum?), string Time = default(string), decimal? Retention = default(decimal?))
        {
            this.Interval = Interval;
            this.Time = Time;
            this.Retention = Retention;
        }
        

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Retention
        /// </summary>
        [DataMember(Name="retention", EmitDefaultValue=false)]
        public decimal? Retention { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRule {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Retention: ").Append(Retention).Append("\n");
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
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Retention == input.Retention ||
                    (this.Retention != null &&
                    this.Retention.Equals(input.Retention))
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
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Retention != null)
                    hashCode = hashCode * 59 + this.Retention.GetHashCode();
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
