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
    /// ConfigurationListResponseServerSizes
    /// </summary>
    [DataContract]
    public partial class ConfigurationListResponseServerSizes :  IEquatable<ConfigurationListResponseServerSizes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationListResponseServerSizes" /> class.
        /// </summary>
        /// <param name="serverSize">serverSize.</param>
        public ConfigurationListResponseServerSizes(List<ServerSize> serverSize = default(List<ServerSize>))
        {
            this.serverSize = serverSize;
        }
        
        /// <summary>
        /// Gets or Sets serverSize
        /// </summary>
        [DataMember(Name="server_size", EmitDefaultValue=false)]
        public List<ServerSize> serverSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationListResponseServerSizes {\n");
            sb.Append("  serverSize: ").Append(serverSize).Append("\n");
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
            return this.Equals(input as ConfigurationListResponseServerSizes);
        }

        /// <summary>
        /// Returns true if ConfigurationListResponseServerSizes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationListResponseServerSizes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationListResponseServerSizes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.serverSize == input.serverSize ||
                    (this.serverSize != null &&
                    this.serverSize.SequenceEqual(input.serverSize))
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
                if (this.serverSize != null)
                    hashCode = hashCode * 59 + this.serverSize.GetHashCode();
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
