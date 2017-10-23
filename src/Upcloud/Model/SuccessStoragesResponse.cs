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
    /// SuccessStoragesResponse
    /// </summary>
    [DataContract]
    public partial class SuccessStoragesResponse :  IEquatable<SuccessStoragesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessStoragesResponse" /> class.
        /// </summary>
        /// <param name="storages">storages.</param>
        public SuccessStoragesResponse(SuccessStoragesResponseStorages storages = default(SuccessStoragesResponseStorages))
        {
            this.storages = storages;
        }
        
        /// <summary>
        /// Gets or Sets storages
        /// </summary>
        [DataMember(Name="storages", EmitDefaultValue=false)]
        public SuccessStoragesResponseStorages storages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuccessStoragesResponse {\n");
            sb.Append("  storages: ").Append(storages).Append("\n");
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
            return this.Equals(input as SuccessStoragesResponse);
        }

        /// <summary>
        /// Returns true if SuccessStoragesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SuccessStoragesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuccessStoragesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.storages == input.storages ||
                    (this.storages != null &&
                    this.storages.Equals(input.storages))
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
                if (this.storages != null)
                    hashCode = hashCode * 59 + this.storages.GetHashCode();
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
