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
        /// Gets or Sets PartOfPlan
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
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// The address family of new IP address.
        /// </summary>
        /// <value>The address family of new IP address.</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public FamilyEnum? Family { get; set; }
        /// <summary>
        /// Gets or Sets PartOfPlan
        /// </summary>
        [DataMember(Name="part_of_plan", EmitDefaultValue=false)]
        public PartOfPlanEnum? PartOfPlan { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IpAddress" /> class.
        /// </summary>
        /// <param name="Access">Is address for private or public network..</param>
        /// <param name="Address">Address.</param>
        /// <param name="Family">The address family of new IP address..</param>
        /// <param name="PtrRecord">PtrRecord.</param>
        /// <param name="Server">Server.</param>
        /// <param name="PartOfPlan">PartOfPlan.</param>
        public IpAddress(AccessEnum? Access = default(AccessEnum?), string Address = default(string), FamilyEnum? Family = default(FamilyEnum?), string PtrRecord = default(string), Guid? Server = default(Guid?), PartOfPlanEnum? PartOfPlan = default(PartOfPlanEnum?))
        {
            this.Access = Access;
            this.Address = Address;
            this.Family = Family;
            this.PtrRecord = PtrRecord;
            this.Server = Server;
            this.PartOfPlan = PartOfPlan;
        }
        

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }


        /// <summary>
        /// Gets or Sets PtrRecord
        /// </summary>
        [DataMember(Name="ptr_record", EmitDefaultValue=false)]
        public string PtrRecord { get; set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public Guid? Server { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpAddress {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  PtrRecord: ").Append(PtrRecord).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  PartOfPlan: ").Append(PartOfPlan).Append("\n");
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
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Family == input.Family ||
                    (this.Family != null &&
                    this.Family.Equals(input.Family))
                ) && 
                (
                    this.PtrRecord == input.PtrRecord ||
                    (this.PtrRecord != null &&
                    this.PtrRecord.Equals(input.PtrRecord))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.PartOfPlan == input.PartOfPlan ||
                    (this.PartOfPlan != null &&
                    this.PartOfPlan.Equals(input.PartOfPlan))
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
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Family != null)
                    hashCode = hashCode * 59 + this.Family.GetHashCode();
                if (this.PtrRecord != null)
                    hashCode = hashCode * 59 + this.PtrRecord.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.PartOfPlan != null)
                    hashCode = hashCode * 59 + this.PartOfPlan.GetHashCode();
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
