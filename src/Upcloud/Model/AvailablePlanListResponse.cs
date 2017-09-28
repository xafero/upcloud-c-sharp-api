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
    /// AvailablePlanListResponse
    /// </summary>
    [DataContract]
    public partial class AvailablePlanListResponse :  IEquatable<AvailablePlanListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePlanListResponse" /> class.
        /// </summary>
        /// <param name="Plans">Plans.</param>
        public AvailablePlanListResponse(AvailablePlanListResponsePlans Plans = default(AvailablePlanListResponsePlans))
        {
            this.Plans = Plans;
        }
        
        /// <summary>
        /// Gets or Sets Plans
        /// </summary>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public AvailablePlanListResponsePlans Plans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailablePlanListResponse {\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
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
            return this.Equals(input as AvailablePlanListResponse);
        }

        /// <summary>
        /// Returns true if AvailablePlanListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailablePlanListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailablePlanListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Plans == input.Plans ||
                    (this.Plans != null &&
                    this.Plans.Equals(input.Plans))
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
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
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