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
    /// An API user account and password is required to access the UpCloud API. The API user is associated with an UpCloud account. A user account may have multiple API users to be used in different client software. In order to use resources from the cloud, the account must have enough credits.
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="credits">Credits are used to pay for cloud resources such as servers, storages, network traffic and IP addresses. Credits are automatically deducted for used resources on an hourly basis. Should the user run out of credits, active resources will be disabled and reactivated after the credit balance returns to positive. Credits can be purchased from the UpCloud website..</param>
        /// <param name="username">username.</param>
        public Account(decimal? credits = default(decimal?), string username = default(string))
        {
            this.credits = credits;
            this.username = username;
        }
        
        /// <summary>
        /// Credits are used to pay for cloud resources such as servers, storages, network traffic and IP addresses. Credits are automatically deducted for used resources on an hourly basis. Should the user run out of credits, active resources will be disabled and reactivated after the credit balance returns to positive. Credits can be purchased from the UpCloud website.
        /// </summary>
        /// <value>Credits are used to pay for cloud resources such as servers, storages, network traffic and IP addresses. Credits are automatically deducted for used resources on an hourly basis. Should the user run out of credits, active resources will be disabled and reactivated after the credit balance returns to positive. Credits can be purchased from the UpCloud website.</value>
        [DataMember(Name="credits", EmitDefaultValue=false)]
        public decimal? credits { get; set; }

        /// <summary>
        /// Gets or Sets username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  credits: ").Append(credits).Append("\n");
            sb.Append("  username: ").Append(username).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.credits == input.credits ||
                    (this.credits != null &&
                    this.credits.Equals(input.credits))
                ) && 
                (
                    this.username == input.username ||
                    (this.username != null &&
                    this.username.Equals(input.username))
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
                if (this.credits != null)
                    hashCode = hashCode * 59 + this.credits.GetHashCode();
                if (this.username != null)
                    hashCode = hashCode * 59 + this.username.GetHashCode();
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
