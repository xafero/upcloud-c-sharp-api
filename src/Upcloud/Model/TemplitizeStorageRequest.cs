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
    /// TemplitizeStorageRequest
    /// </summary>
    [DataContract]
    public partial class TemplitizeStorageRequest :  IEquatable<TemplitizeStorageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplitizeStorageRequest" /> class.
        /// </summary>
        /// <param name="title">A short description..</param>
        public TemplitizeStorageRequest(string title = default(string))
        {
            this.title = title;
        }
        
        /// <summary>
        /// A short description.
        /// </summary>
        /// <value>A short description.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplitizeStorageRequest {\n");
            sb.Append("  title: ").Append(title).Append("\n");
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
            return this.Equals(input as TemplitizeStorageRequest);
        }

        /// <summary>
        /// Returns true if TemplitizeStorageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplitizeStorageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplitizeStorageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.title == input.title ||
                    (this.title != null &&
                    this.title.Equals(input.title))
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
                if (this.title != null)
                    hashCode = hashCode * 59 + this.title.GetHashCode();
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
            // title (string) maxLength
            if(this.title != null && this.title.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for title, length must be less than 64.", new [] { "title" });
            }

            yield break;
        }
    }

}
