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
    /// An API user account and password is required to access the UpCloud API. The API user is associated with an UpCloud account. A user account may have multiple API users to be used in different client software. In order to use resources from the cloud, the account must have enough credits.
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="Credits">Credits are used to pay for cloud resources such as servers, storages, network traffic and IP addresses. Credits are automatically deducted for used resources on an hourly basis. Should the user run out of credits, active resources will be disabled and reactivated after the credit balance returns to positive. Credits can be purchased from the UpCloud website..</param>
        /// <param name="Username">Username.</param>
        public Account(decimal? Credits = default(decimal?), string Username = default(string))
        {
            this.Credits = Credits;
            this.Username = Username;
        }
        
        /// <summary>
        /// Credits are used to pay for cloud resources such as servers, storages, network traffic and IP addresses. Credits are automatically deducted for used resources on an hourly basis. Should the user run out of credits, active resources will be disabled and reactivated after the credit balance returns to positive. Credits can be purchased from the UpCloud website.
        /// </summary>
        /// <value>Credits are used to pay for cloud resources such as servers, storages, network traffic and IP addresses. Credits are automatically deducted for used resources on an hourly basis. Should the user run out of credits, active resources will be disabled and reactivated after the credit balance returns to positive. Credits can be purchased from the UpCloud website.</value>
        [DataMember(Name="credits", EmitDefaultValue=false)]
        public decimal? Credits { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
                    this.Credits == input.Credits ||
                    (this.Credits != null &&
                    this.Credits.Equals(input.Credits))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Credits != null)
                    hashCode = hashCode * 59 + this.Credits.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
