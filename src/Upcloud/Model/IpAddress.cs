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
    /// The UpCloud network has public and private IP addresses.
    /// </summary>
    [DataContract]
    public partial class IpAddress :  IEquatable<IpAddress>, IValidatableObject
    {
        /// <summary>
        /// Is address for private or public network.
        /// </summary>
        /// <value>Is address for private or public network.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessEnum
        {
            
            /// <summary>
            /// Enum Public for "public"
            /// </summary>
            [EnumMember(Value = "public")]
            Public,
            
            /// <summary>
            /// Enum Private for "private"
            /// </summary>
            [EnumMember(Value = "private")]
            Private
        }

        /// <summary>
        /// The address family of new IP address.
        /// </summary>
        /// <value>The address family of new IP address.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FamilyEnum
        {
            
            /// <summary>
            /// Enum IPv4 for "IPv4"
            /// </summary>
            [EnumMember(Value = "IPv4")]
            IPv4,
            
            /// <summary>
            /// Enum IPv6 for "IPv6"
            /// </summary>
            [EnumMember(Value = "IPv6")]
            IPv6
        }

        /// <summary>
        /// Gets or Sets partOfPlan
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartOfPlanEnum
        {
            
            /// <summary>
            /// Enum Yes for "yes"
            /// </summary>
            [EnumMember(Value = "yes")]
            Yes,
            
            /// <summary>
            /// Enum No for "no"
            /// </summary>
            [EnumMember(Value = "no")]
            No
        }

        /// <summary>
        /// Is address for private or public network.
        /// </summary>
        /// <value>Is address for private or public network.</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public AccessEnum? access { get; set; }
        /// <summary>
        /// The address family of new IP address.
        /// </summary>
        /// <value>The address family of new IP address.</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public FamilyEnum? family { get; set; }
        /// <summary>
        /// Gets or Sets partOfPlan
        /// </summary>
        [DataMember(Name="part_of_plan", EmitDefaultValue=false)]
        public PartOfPlanEnum? partOfPlan { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IpAddress" /> class.
        /// </summary>
        /// <param name="access">Is address for private or public network..</param>
        /// <param name="address">address.</param>
        /// <param name="family">The address family of new IP address..</param>
        /// <param name="ptrRecord">ptrRecord.</param>
        /// <param name="server">server.</param>
        /// <param name="partOfPlan">partOfPlan.</param>
        public IpAddress(AccessEnum? access = default(AccessEnum?), string address = default(string), FamilyEnum? family = default(FamilyEnum?), string ptrRecord = default(string), Guid? server = default(Guid?), PartOfPlanEnum? partOfPlan = default(PartOfPlanEnum?))
        {
            this.access = access;
            this.address = address;
            this.family = family;
            this.ptrRecord = ptrRecord;
            this.server = server;
            this.partOfPlan = partOfPlan;
        }
        

        /// <summary>
        /// Gets or Sets address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string address { get; set; }


        /// <summary>
        /// Gets or Sets ptrRecord
        /// </summary>
        [DataMember(Name="ptr_record", EmitDefaultValue=false)]
        public string ptrRecord { get; set; }

        /// <summary>
        /// Gets or Sets server
        /// </summary>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public Guid? server { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpAddress {\n");
            sb.Append("  access: ").Append(access).Append("\n");
            sb.Append("  address: ").Append(address).Append("\n");
            sb.Append("  family: ").Append(family).Append("\n");
            sb.Append("  ptrRecord: ").Append(ptrRecord).Append("\n");
            sb.Append("  server: ").Append(server).Append("\n");
            sb.Append("  partOfPlan: ").Append(partOfPlan).Append("\n");
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
            return this.Equals(input as IpAddress);
        }

        /// <summary>
        /// Returns true if IpAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of IpAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.access == input.access ||
                    (this.access != null &&
                    this.access.Equals(input.access))
                ) && 
                (
                    this.address == input.address ||
                    (this.address != null &&
                    this.address.Equals(input.address))
                ) && 
                (
                    this.family == input.family ||
                    (this.family != null &&
                    this.family.Equals(input.family))
                ) && 
                (
                    this.ptrRecord == input.ptrRecord ||
                    (this.ptrRecord != null &&
                    this.ptrRecord.Equals(input.ptrRecord))
                ) && 
                (
                    this.server == input.server ||
                    (this.server != null &&
                    this.server.Equals(input.server))
                ) && 
                (
                    this.partOfPlan == input.partOfPlan ||
                    (this.partOfPlan != null &&
                    this.partOfPlan.Equals(input.partOfPlan))
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
                if (this.access != null)
                    hashCode = hashCode * 59 + this.access.GetHashCode();
                if (this.address != null)
                    hashCode = hashCode * 59 + this.address.GetHashCode();
                if (this.family != null)
                    hashCode = hashCode * 59 + this.family.GetHashCode();
                if (this.ptrRecord != null)
                    hashCode = hashCode * 59 + this.ptrRecord.GetHashCode();
                if (this.server != null)
                    hashCode = hashCode * 59 + this.server.GetHashCode();
                if (this.partOfPlan != null)
                    hashCode = hashCode * 59 + this.partOfPlan.GetHashCode();
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
