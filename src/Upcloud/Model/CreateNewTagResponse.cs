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
    /// CreateNewTagResponse
    /// </summary>
    [DataContract]
    public partial class CreateNewTagResponse :  IEquatable<CreateNewTagResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewTagResponse" /> class.
        /// </summary>
        /// <param name="tag">tag.</param>
        public CreateNewTagResponse(Tag tag = default(Tag))
        {
            this.tag = tag;
        }
        
        /// <summary>
        /// Gets or Sets tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public Tag tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNewTagResponse {\n");
            sb.Append("  tag: ").Append(tag).Append("\n");
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
            return this.Equals(input as CreateNewTagResponse);
        }

        /// <summary>
        /// Returns true if CreateNewTagResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNewTagResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNewTagResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.tag == input.tag ||
                    (this.tag != null &&
                    this.tag.Equals(input.tag))
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
                if (this.tag != null)
                    hashCode = hashCode * 59 + this.tag.GetHashCode();
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
