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
    /// ZoneListResponseZones
    /// </summary>
    [DataContract]
    public partial class ZoneListResponseZones :  IEquatable<ZoneListResponseZones>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneListResponseZones" /> class.
        /// </summary>
        /// <param name="Zone">Zone.</param>
        public ZoneListResponseZones(List<Zone> Zone = default(List<Zone>))
        {
            this.Zone = Zone;
        }
        
        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public List<Zone> Zone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZoneListResponseZones {\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
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
            return this.Equals(input as ZoneListResponseZones);
        }

        /// <summary>
        /// Returns true if ZoneListResponseZones instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneListResponseZones to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneListResponseZones input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.SequenceEqual(input.Zone))
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
                if (this.Zone != null)
                    hashCode = hashCode * 59 + this.Zone.GetHashCode();
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
