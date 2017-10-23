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
    /// FirewallRuleListResponse
    /// </summary>
    [DataContract]
    public partial class FirewallRuleListResponse :  IEquatable<FirewallRuleListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRuleListResponse" /> class.
        /// </summary>
        /// <param name="firewallRules">firewallRules.</param>
        public FirewallRuleListResponse(FirewallRuleListResponseFirewallRules firewallRules = default(FirewallRuleListResponseFirewallRules))
        {
            this.firewallRules = firewallRules;
        }
        
        /// <summary>
        /// Gets or Sets firewallRules
        /// </summary>
        [DataMember(Name="firewall_rules", EmitDefaultValue=false)]
        public FirewallRuleListResponseFirewallRules firewallRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallRuleListResponse {\n");
            sb.Append("  firewallRules: ").Append(firewallRules).Append("\n");
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
            return this.Equals(input as FirewallRuleListResponse);
        }

        /// <summary>
        /// Returns true if FirewallRuleListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FirewallRuleListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirewallRuleListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.firewallRules == input.firewallRules ||
                    (this.firewallRules != null &&
                    this.firewallRules.Equals(input.firewallRules))
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
                if (this.firewallRules != null)
                    hashCode = hashCode * 59 + this.firewallRules.GetHashCode();
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
