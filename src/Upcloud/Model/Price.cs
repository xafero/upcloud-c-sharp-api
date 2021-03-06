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
    /// UpCloud resources are billed by the hour according to the price list. We also offer pricing plans for fixed server configurations.
    /// </summary>
    [DataContract]
    public partial class Price :  IEquatable<Price>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="_price">_price.</param>
        public Price(decimal? amount = default(decimal?), decimal? _price = default(decimal?))
        {
            this.amount = amount;
            this._price = _price;
        }
        
        /// <summary>
        /// Gets or Sets amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? amount { get; set; }

        /// <summary>
        /// Gets or Sets _price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? _price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Price {\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  _price: ").Append(_price).Append("\n");
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
            return this.Equals(input as Price);
        }

        /// <summary>
        /// Returns true if Price instances are equal
        /// </summary>
        /// <param name="input">Instance of Price to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Price input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
                ) && 
                (
                    this._price == input._price ||
                    (this._price != null &&
                    this._price.Equals(input._price))
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
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this._price != null)
                    hashCode = hashCode * 59 + this._price.GetHashCode();
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
