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
    /// A zone identifies the physical site where the cloud services are located. Different zones may be used to provide geographical and logical separation of servers.
    /// </summary>
    [DataContract]
    public partial class Zone :  IEquatable<Zone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zone" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        public Zone(string name = default(string), string description = default(string))
        {
            this.name = name;
            this.description = description;
        }
        
        /// <summary>
        /// Gets or Sets name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Gets or Sets description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Zone {\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
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
            return this.Equals(input as Zone);
        }

        /// <summary>
        /// Returns true if Zone instances are equal
        /// </summary>
        /// <param name="input">Instance of Zone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Zone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
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
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
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
