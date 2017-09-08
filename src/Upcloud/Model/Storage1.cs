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
    /// Storage1
    /// </summary>
    [DataContract]
    public partial class Storage1 :  IEquatable<Storage1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage1" /> class.
        /// </summary>
        /// <param name="BackupRule">BackupRule.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Title">Title.</param>
        public Storage1(BackupRule BackupRule = default(BackupRule), decimal? Size = default(decimal?), string Title = default(string))
        {
            this.BackupRule = BackupRule;
            this.Size = Size;
            this.Title = Title;
        }
        
        /// <summary>
        /// Gets or Sets BackupRule
        /// </summary>
        [DataMember(Name="backup_rule", EmitDefaultValue=false)]
        public BackupRule BackupRule { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage1 {\n");
            sb.Append("  BackupRule: ").Append(BackupRule).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as Storage1);
        }

        /// <summary>
        /// Returns true if Storage1 instances are equal
        /// </summary>
        /// <param name="input">Instance of Storage1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Storage1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupRule == input.BackupRule ||
                    (this.BackupRule != null &&
                    this.BackupRule.Equals(input.BackupRule))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.BackupRule != null)
                    hashCode = hashCode * 59 + this.BackupRule.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
            // Size (decimal?) maximum
            if(this.Size > (decimal?)1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value less than or equal to 1024.", new [] { "Size" });
            }

            // Size (decimal?) minimum
            if(this.Size < (decimal?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value greater than or equal to 10.", new [] { "Size" });
            }

            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 64.", new [] { "Title" });
            }

            yield break;
        }
    }

}
