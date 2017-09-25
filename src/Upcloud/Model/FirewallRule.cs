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
    /// FirewallRule
    /// </summary>
    [DataContract]
    public partial class FirewallRule :  IEquatable<FirewallRule>, IValidatableObject
    {
        /// <summary>
        /// The direction of network traffic this rule will be applied to.
        /// </summary>
        /// <value>The direction of network traffic this rule will be applied to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum In for "in"
            /// </summary>
            [EnumMember(Value = "in")]
            In,
            
            /// <summary>
            /// Enum Out for "out"
            /// </summary>
            [EnumMember(Value = "out")]
            Out
        }

        /// <summary>
        /// Action to take if the rule conditions are met.
        /// </summary>
        /// <value>Action to take if the rule conditions are met.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Accept for "accept"
            /// </summary>
            [EnumMember(Value = "accept")]
            Accept,
            
            /// <summary>
            /// Enum Reject for "reject"
            /// </summary>
            [EnumMember(Value = "reject")]
            Reject,
            
            /// <summary>
            /// Enum Drop for "drop"
            /// </summary>
            [EnumMember(Value = "drop")]
            Drop
        }

        /// <summary>
        /// The protocol this rule will be applied to.
        /// </summary>
        /// <value>The protocol this rule will be applied to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            
            /// <summary>
            /// Enum Tcp for "tcp"
            /// </summary>
            [EnumMember(Value = "tcp")]
            Tcp,
            
            /// <summary>
            /// Enum Udp for "udp"
            /// </summary>
            [EnumMember(Value = "udp")]
            Udp,
            
            /// <summary>
            /// Enum Icmp for "icmp"
            /// </summary>
            [EnumMember(Value = "icmp")]
            Icmp
        }

        /// <summary>
        /// The direction of network traffic this rule will be applied to.
        /// </summary>
        /// <value>The direction of network traffic this rule will be applied to.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Action to take if the rule conditions are met.
        /// </summary>
        /// <value>Action to take if the rule conditions are met.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// The protocol this rule will be applied to.
        /// </summary>
        /// <value>The protocol this rule will be applied to.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirewallRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRule" /> class.
        /// </summary>
        /// <param name="Direction">The direction of network traffic this rule will be applied to. (required).</param>
        /// <param name="Action">Action to take if the rule conditions are met. (required).</param>
        /// <param name="Position">Add the firewall rule to this position in the server&#39;s firewall list..</param>
        /// <param name="Family">if protocol is set The address family of new firewall rule (required).</param>
        /// <param name="Protocol">The protocol this rule will be applied to..</param>
        /// <param name="IcmpType">The ICMP type..</param>
        /// <param name="DestinationAddressStart">The destination address range starts from this address..</param>
        /// <param name="DestinationAddressEnd">The destination address range ends to this address..</param>
        /// <param name="DestinationPortStart">The destination port range starts from this port number..</param>
        /// <param name="DestinationPortEnd">The destination port range ends to this port number..</param>
        /// <param name="SourceAddressStart">The source address range starts from this address..</param>
        /// <param name="SourceAddressEnd">The source address range ends to this address..</param>
        /// <param name="SourcePortStart">The source port range starts from this port number..</param>
        /// <param name="SourcePortEnd">The source port range ends to this port number..</param>
        /// <param name="Comment">Freeform comment string for the rule..</param>
        public FirewallRule(DirectionEnum? Direction = default(DirectionEnum?), ActionEnum? Action = default(ActionEnum?), decimal? Position = default(decimal?), AddressFamily Family = default(AddressFamily), ProtocolEnum? Protocol = default(ProtocolEnum?), decimal? IcmpType = default(decimal?), string DestinationAddressStart = default(string), string DestinationAddressEnd = default(string), decimal? DestinationPortStart = default(decimal?), decimal? DestinationPortEnd = default(decimal?), string SourceAddressStart = default(string), string SourceAddressEnd = default(string), decimal? SourcePortStart = default(decimal?), decimal? SourcePortEnd = default(decimal?), string Comment = default(string))
        {
            // to ensure "Direction" is required (not null)
            if (Direction == null)
            {
                throw new InvalidDataException("Direction is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.Direction = Direction;
            }
            // to ensure "Action" is required (not null)
            if (Action == null)
            {
                throw new InvalidDataException("Action is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.Action = Action;
            }
            // to ensure "Family" is required (not null)
            if (Family == null)
            {
                throw new InvalidDataException("Family is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.Family = Family;
            }
            this.Position = Position;
            this.Protocol = Protocol;
            this.IcmpType = IcmpType;
            this.DestinationAddressStart = DestinationAddressStart;
            this.DestinationAddressEnd = DestinationAddressEnd;
            this.DestinationPortStart = DestinationPortStart;
            this.DestinationPortEnd = DestinationPortEnd;
            this.SourceAddressStart = SourceAddressStart;
            this.SourceAddressEnd = SourceAddressEnd;
            this.SourcePortStart = SourcePortStart;
            this.SourcePortEnd = SourcePortEnd;
            this.Comment = Comment;
        }
        


        /// <summary>
        /// Add the firewall rule to this position in the server&#39;s firewall list.
        /// </summary>
        /// <value>Add the firewall rule to this position in the server&#39;s firewall list.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal? Position { get; set; }

        /// <summary>
        /// if protocol is set The address family of new firewall rule
        /// </summary>
        /// <value>if protocol is set The address family of new firewall rule</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public AddressFamily Family { get; set; }


        /// <summary>
        /// The ICMP type.
        /// </summary>
        /// <value>The ICMP type.</value>
        [DataMember(Name="icmp_type", EmitDefaultValue=false)]
        public decimal? IcmpType { get; set; }

        /// <summary>
        /// The destination address range starts from this address.
        /// </summary>
        /// <value>The destination address range starts from this address.</value>
        [DataMember(Name="destination_address_start", EmitDefaultValue=false)]
        public string DestinationAddressStart { get; set; }

        /// <summary>
        /// The destination address range ends to this address.
        /// </summary>
        /// <value>The destination address range ends to this address.</value>
        [DataMember(Name="destination_address_end", EmitDefaultValue=false)]
        public string DestinationAddressEnd { get; set; }

        /// <summary>
        /// The destination port range starts from this port number.
        /// </summary>
        /// <value>The destination port range starts from this port number.</value>
        [DataMember(Name="destination_port_start", EmitDefaultValue=false)]
        public decimal? DestinationPortStart { get; set; }

        /// <summary>
        /// The destination port range ends to this port number.
        /// </summary>
        /// <value>The destination port range ends to this port number.</value>
        [DataMember(Name="destination_port_end", EmitDefaultValue=false)]
        public decimal? DestinationPortEnd { get; set; }

        /// <summary>
        /// The source address range starts from this address.
        /// </summary>
        /// <value>The source address range starts from this address.</value>
        [DataMember(Name="source_address_start", EmitDefaultValue=false)]
        public string SourceAddressStart { get; set; }

        /// <summary>
        /// The source address range ends to this address.
        /// </summary>
        /// <value>The source address range ends to this address.</value>
        [DataMember(Name="source_address_end", EmitDefaultValue=false)]
        public string SourceAddressEnd { get; set; }

        /// <summary>
        /// The source port range starts from this port number.
        /// </summary>
        /// <value>The source port range starts from this port number.</value>
        [DataMember(Name="source_port_start", EmitDefaultValue=false)]
        public decimal? SourcePortStart { get; set; }

        /// <summary>
        /// The source port range ends to this port number.
        /// </summary>
        /// <value>The source port range ends to this port number.</value>
        [DataMember(Name="source_port_end", EmitDefaultValue=false)]
        public decimal? SourcePortEnd { get; set; }

        /// <summary>
        /// Freeform comment string for the rule.
        /// </summary>
        /// <value>Freeform comment string for the rule.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallRule {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  IcmpType: ").Append(IcmpType).Append("\n");
            sb.Append("  DestinationAddressStart: ").Append(DestinationAddressStart).Append("\n");
            sb.Append("  DestinationAddressEnd: ").Append(DestinationAddressEnd).Append("\n");
            sb.Append("  DestinationPortStart: ").Append(DestinationPortStart).Append("\n");
            sb.Append("  DestinationPortEnd: ").Append(DestinationPortEnd).Append("\n");
            sb.Append("  SourceAddressStart: ").Append(SourceAddressStart).Append("\n");
            sb.Append("  SourceAddressEnd: ").Append(SourceAddressEnd).Append("\n");
            sb.Append("  SourcePortStart: ").Append(SourcePortStart).Append("\n");
            sb.Append("  SourcePortEnd: ").Append(SourcePortEnd).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as FirewallRule);
        }

        /// <summary>
        /// Returns true if FirewallRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FirewallRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirewallRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Family == input.Family ||
                    (this.Family != null &&
                    this.Family.Equals(input.Family))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.IcmpType == input.IcmpType ||
                    (this.IcmpType != null &&
                    this.IcmpType.Equals(input.IcmpType))
                ) && 
                (
                    this.DestinationAddressStart == input.DestinationAddressStart ||
                    (this.DestinationAddressStart != null &&
                    this.DestinationAddressStart.Equals(input.DestinationAddressStart))
                ) && 
                (
                    this.DestinationAddressEnd == input.DestinationAddressEnd ||
                    (this.DestinationAddressEnd != null &&
                    this.DestinationAddressEnd.Equals(input.DestinationAddressEnd))
                ) && 
                (
                    this.DestinationPortStart == input.DestinationPortStart ||
                    (this.DestinationPortStart != null &&
                    this.DestinationPortStart.Equals(input.DestinationPortStart))
                ) && 
                (
                    this.DestinationPortEnd == input.DestinationPortEnd ||
                    (this.DestinationPortEnd != null &&
                    this.DestinationPortEnd.Equals(input.DestinationPortEnd))
                ) && 
                (
                    this.SourceAddressStart == input.SourceAddressStart ||
                    (this.SourceAddressStart != null &&
                    this.SourceAddressStart.Equals(input.SourceAddressStart))
                ) && 
                (
                    this.SourceAddressEnd == input.SourceAddressEnd ||
                    (this.SourceAddressEnd != null &&
                    this.SourceAddressEnd.Equals(input.SourceAddressEnd))
                ) && 
                (
                    this.SourcePortStart == input.SourcePortStart ||
                    (this.SourcePortStart != null &&
                    this.SourcePortStart.Equals(input.SourcePortStart))
                ) && 
                (
                    this.SourcePortEnd == input.SourcePortEnd ||
                    (this.SourcePortEnd != null &&
                    this.SourcePortEnd.Equals(input.SourcePortEnd))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Family != null)
                    hashCode = hashCode * 59 + this.Family.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.IcmpType != null)
                    hashCode = hashCode * 59 + this.IcmpType.GetHashCode();
                if (this.DestinationAddressStart != null)
                    hashCode = hashCode * 59 + this.DestinationAddressStart.GetHashCode();
                if (this.DestinationAddressEnd != null)
                    hashCode = hashCode * 59 + this.DestinationAddressEnd.GetHashCode();
                if (this.DestinationPortStart != null)
                    hashCode = hashCode * 59 + this.DestinationPortStart.GetHashCode();
                if (this.DestinationPortEnd != null)
                    hashCode = hashCode * 59 + this.DestinationPortEnd.GetHashCode();
                if (this.SourceAddressStart != null)
                    hashCode = hashCode * 59 + this.SourceAddressStart.GetHashCode();
                if (this.SourceAddressEnd != null)
                    hashCode = hashCode * 59 + this.SourceAddressEnd.GetHashCode();
                if (this.SourcePortStart != null)
                    hashCode = hashCode * 59 + this.SourcePortStart.GetHashCode();
                if (this.SourcePortEnd != null)
                    hashCode = hashCode * 59 + this.SourcePortEnd.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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
            // Position (decimal?) maximum
            if(this.Position > (decimal?)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Position, must be a value less than or equal to 1000.", new [] { "Position" });
            }

            // Position (decimal?) minimum
            if(this.Position < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Position, must be a value greater than or equal to 1.", new [] { "Position" });
            }

            // IcmpType (decimal?) maximum
            if(this.IcmpType > (decimal?)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IcmpType, must be a value less than or equal to 255.", new [] { "IcmpType" });
            }

            // IcmpType (decimal?) minimum
            if(this.IcmpType < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IcmpType, must be a value greater than or equal to 0.", new [] { "IcmpType" });
            }

            // DestinationPortStart (decimal?) maximum
            if(this.DestinationPortStart > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DestinationPortStart, must be a value less than or equal to 65535.", new [] { "DestinationPortStart" });
            }

            // DestinationPortStart (decimal?) minimum
            if(this.DestinationPortStart < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DestinationPortStart, must be a value greater than or equal to 1.", new [] { "DestinationPortStart" });
            }

            // DestinationPortEnd (decimal?) maximum
            if(this.DestinationPortEnd > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DestinationPortEnd, must be a value less than or equal to 65535.", new [] { "DestinationPortEnd" });
            }

            // DestinationPortEnd (decimal?) minimum
            if(this.DestinationPortEnd < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DestinationPortEnd, must be a value greater than or equal to 1.", new [] { "DestinationPortEnd" });
            }

            // SourcePortStart (decimal?) maximum
            if(this.SourcePortStart > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourcePortStart, must be a value less than or equal to 65535.", new [] { "SourcePortStart" });
            }

            // SourcePortStart (decimal?) minimum
            if(this.SourcePortStart < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourcePortStart, must be a value greater than or equal to 1.", new [] { "SourcePortStart" });
            }

            // SourcePortEnd (decimal?) maximum
            if(this.SourcePortEnd > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourcePortEnd, must be a value less than or equal to 65535.", new [] { "SourcePortEnd" });
            }

            // SourcePortEnd (decimal?) minimum
            if(this.SourcePortEnd < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourcePortEnd, must be a value greater than or equal to 1.", new [] { "SourcePortEnd" });
            }

            // Comment (string) maxLength
            if(this.Comment != null && this.Comment.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comment, length must be less than 255.", new [] { "Comment" });
            }

            // Comment (string) minLength
            if(this.Comment != null && this.Comment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comment, length must be greater than 0.", new [] { "Comment" });
            }

            yield break;
        }
    }

}
