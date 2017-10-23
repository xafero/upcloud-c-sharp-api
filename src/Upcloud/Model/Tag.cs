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
    /// Tag
    /// </summary>
    [DataContract]
    public partial class Tag :  IEquatable<Tag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="name">The new tag (required).</param>
        /// <param name="description">Description of the tag.</param>
        /// <param name="servers">servers.</param>
        public Tag(string name = default(string), string description = default(string), TagServers servers = default(TagServers))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Tag and cannot be null");
            }
            else
            {
                this.name = name;
            }
            this.description = description;
            this.servers = servers;
        }
        
        /// <summary>
        /// The new tag
        /// </summary>
        /// <value>The new tag</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Description of the tag
        /// </summary>
        /// <value>Description of the tag</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Gets or Sets servers
        /// </summary>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public TagServers servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tag {\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  servers: ").Append(servers).Append("\n");
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
            return this.Equals(input as Tag);
        }

        /// <summary>
        /// Returns true if Tag instances are equal
        /// </summary>
        /// <param name="input">Instance of Tag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tag input)
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
                ) && 
                (
                    this.servers == input.servers ||
                    (this.servers != null &&
                    this.servers.Equals(input.servers))
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
                if (this.servers != null)
                    hashCode = hashCode * 59 + this.servers.GetHashCode();
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
            // name (string) maxLength
            if(this.name != null && this.name.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for name, length must be less than 32.", new [] { "name" });
            }

            // name (string) minLength
            if(this.name != null && this.name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for name, length must be greater than 1.", new [] { "name" });
            }

            // description (string) maxLength
            if(this.description != null && this.description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for description, length must be less than 255.", new [] { "description" });
            }

            yield break;
        }
    }

}
