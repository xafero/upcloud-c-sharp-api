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
    /// accountResponse
    /// </summary>
    [DataContract]
    public partial class AccountResponse :  IEquatable<AccountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponse" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountResponse(Account account = default(Account))
        {
            this.account = account;
        }
        
        /// <summary>
        /// Gets or Sets account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Account account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountResponse {\n");
            sb.Append("  account: ").Append(account).Append("\n");
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
            return this.Equals(input as AccountResponse);
        }

        /// <summary>
        /// Returns true if AccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.account == input.account ||
                    (this.account != null &&
                    this.account.Equals(input.account))
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
                if (this.account != null)
                    hashCode = hashCode * 59 + this.account.GetHashCode();
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
