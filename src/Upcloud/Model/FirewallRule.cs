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
        public DirectionEnum? direction { get; set; }
        /// <summary>
        /// Action to take if the rule conditions are met.
        /// </summary>
        /// <value>Action to take if the rule conditions are met.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? action { get; set; }
        /// <summary>
        /// The protocol this rule will be applied to.
        /// </summary>
        /// <value>The protocol this rule will be applied to.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public ProtocolEnum? protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirewallRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRule" /> class.
        /// </summary>
        /// <param name="direction">The direction of network traffic this rule will be applied to. (required).</param>
        /// <param name="action">Action to take if the rule conditions are met. (required).</param>
        /// <param name="position">Add the firewall rule to this position in the server&#39;s firewall list..</param>
        /// <param name="family">if protocol is set The address family of new firewall rule (required).</param>
        /// <param name="protocol">The protocol this rule will be applied to..</param>
        /// <param name="icmpType">The ICMP type..</param>
        /// <param name="destinationAddressStart">The destination address range starts from this address..</param>
        /// <param name="destinationAddressEnd">The destination address range ends to this address..</param>
        /// <param name="destinationPortStart">The destination port range starts from this port number..</param>
        /// <param name="destinationPortEnd">The destination port range ends to this port number..</param>
        /// <param name="sourceAddressStart">The source address range starts from this address..</param>
        /// <param name="sourceAddressEnd">The source address range ends to this address..</param>
        /// <param name="sourcePortStart">The source port range starts from this port number..</param>
        /// <param name="sourcePortEnd">The source port range ends to this port number..</param>
        /// <param name="comment">Freeform comment string for the rule..</param>
        public FirewallRule(DirectionEnum? direction = default(DirectionEnum?), ActionEnum? action = default(ActionEnum?), decimal? position = default(decimal?), AddressFamily family = default(AddressFamily), ProtocolEnum? protocol = default(ProtocolEnum?), string icmpType = default(string), string destinationAddressStart = default(string), string destinationAddressEnd = default(string), decimal? destinationPortStart = default(decimal?), decimal? destinationPortEnd = default(decimal?), string sourceAddressStart = default(string), string sourceAddressEnd = default(string), decimal? sourcePortStart = default(decimal?), decimal? sourcePortEnd = default(decimal?), string comment = default(string))
        {
            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.direction = direction;
            }
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.action = action;
            }
            // to ensure "family" is required (not null)
            if (family == null)
            {
                throw new InvalidDataException("family is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.family = family;
            }
            this.position = position;
            this.protocol = protocol;
            this.icmpType = icmpType;
            this.destinationAddressStart = destinationAddressStart;
            this.destinationAddressEnd = destinationAddressEnd;
            this.destinationPortStart = destinationPortStart;
            this.destinationPortEnd = destinationPortEnd;
            this.sourceAddressStart = sourceAddressStart;
            this.sourceAddressEnd = sourceAddressEnd;
            this.sourcePortStart = sourcePortStart;
            this.sourcePortEnd = sourcePortEnd;
            this.comment = comment;
        }
        


        /// <summary>
        /// Add the firewall rule to this position in the server&#39;s firewall list.
        /// </summary>
        /// <value>Add the firewall rule to this position in the server&#39;s firewall list.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal? position { get; set; }

        /// <summary>
        /// if protocol is set The address family of new firewall rule
        /// </summary>
        /// <value>if protocol is set The address family of new firewall rule</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public AddressFamily family { get; set; }


        /// <summary>
        /// The ICMP type.
        /// </summary>
        /// <value>The ICMP type.</value>
        [DataMember(Name="icmp_type", EmitDefaultValue=false)]
        public string icmpType { get; set; }

        /// <summary>
        /// The destination address range starts from this address.
        /// </summary>
        /// <value>The destination address range starts from this address.</value>
        [DataMember(Name="destination_address_start", EmitDefaultValue=false)]
        public string destinationAddressStart { get; set; }

        /// <summary>
        /// The destination address range ends to this address.
        /// </summary>
        /// <value>The destination address range ends to this address.</value>
        [DataMember(Name="destination_address_end", EmitDefaultValue=false)]
        public string destinationAddressEnd { get; set; }

        /// <summary>
        /// The destination port range starts from this port number.
        /// </summary>
        /// <value>The destination port range starts from this port number.</value>
        [DataMember(Name="destination_port_start", EmitDefaultValue=false)]
        public decimal? destinationPortStart { get; set; }

        /// <summary>
        /// The destination port range ends to this port number.
        /// </summary>
        /// <value>The destination port range ends to this port number.</value>
        [DataMember(Name="destination_port_end", EmitDefaultValue=false)]
        public decimal? destinationPortEnd { get; set; }

        /// <summary>
        /// The source address range starts from this address.
        /// </summary>
        /// <value>The source address range starts from this address.</value>
        [DataMember(Name="source_address_start", EmitDefaultValue=false)]
        public string sourceAddressStart { get; set; }

        /// <summary>
        /// The source address range ends to this address.
        /// </summary>
        /// <value>The source address range ends to this address.</value>
        [DataMember(Name="source_address_end", EmitDefaultValue=false)]
        public string sourceAddressEnd { get; set; }

        /// <summary>
        /// The source port range starts from this port number.
        /// </summary>
        /// <value>The source port range starts from this port number.</value>
        [DataMember(Name="source_port_start", EmitDefaultValue=false)]
        public decimal? sourcePortStart { get; set; }

        /// <summary>
        /// The source port range ends to this port number.
        /// </summary>
        /// <value>The source port range ends to this port number.</value>
        [DataMember(Name="source_port_end", EmitDefaultValue=false)]
        public decimal? sourcePortEnd { get; set; }

        /// <summary>
        /// Freeform comment string for the rule.
        /// </summary>
        /// <value>Freeform comment string for the rule.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallRule {\n");
            sb.Append("  direction: ").Append(direction).Append("\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  position: ").Append(position).Append("\n");
            sb.Append("  family: ").Append(family).Append("\n");
            sb.Append("  protocol: ").Append(protocol).Append("\n");
            sb.Append("  icmpType: ").Append(icmpType).Append("\n");
            sb.Append("  destinationAddressStart: ").Append(destinationAddressStart).Append("\n");
            sb.Append("  destinationAddressEnd: ").Append(destinationAddressEnd).Append("\n");
            sb.Append("  destinationPortStart: ").Append(destinationPortStart).Append("\n");
            sb.Append("  destinationPortEnd: ").Append(destinationPortEnd).Append("\n");
            sb.Append("  sourceAddressStart: ").Append(sourceAddressStart).Append("\n");
            sb.Append("  sourceAddressEnd: ").Append(sourceAddressEnd).Append("\n");
            sb.Append("  sourcePortStart: ").Append(sourcePortStart).Append("\n");
            sb.Append("  sourcePortEnd: ").Append(sourcePortEnd).Append("\n");
            sb.Append("  comment: ").Append(comment).Append("\n");
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
                    this.direction == input.direction ||
                    (this.direction != null &&
                    this.direction.Equals(input.direction))
                ) && 
                (
                    this.action == input.action ||
                    (this.action != null &&
                    this.action.Equals(input.action))
                ) && 
                (
                    this.position == input.position ||
                    (this.position != null &&
                    this.position.Equals(input.position))
                ) && 
                (
                    this.family == input.family ||
                    (this.family != null &&
                    this.family.Equals(input.family))
                ) && 
                (
                    this.protocol == input.protocol ||
                    (this.protocol != null &&
                    this.protocol.Equals(input.protocol))
                ) && 
                (
                    this.icmpType == input.icmpType ||
                    (this.icmpType != null &&
                    this.icmpType.Equals(input.icmpType))
                ) && 
                (
                    this.destinationAddressStart == input.destinationAddressStart ||
                    (this.destinationAddressStart != null &&
                    this.destinationAddressStart.Equals(input.destinationAddressStart))
                ) && 
                (
                    this.destinationAddressEnd == input.destinationAddressEnd ||
                    (this.destinationAddressEnd != null &&
                    this.destinationAddressEnd.Equals(input.destinationAddressEnd))
                ) && 
                (
                    this.destinationPortStart == input.destinationPortStart ||
                    (this.destinationPortStart != null &&
                    this.destinationPortStart.Equals(input.destinationPortStart))
                ) && 
                (
                    this.destinationPortEnd == input.destinationPortEnd ||
                    (this.destinationPortEnd != null &&
                    this.destinationPortEnd.Equals(input.destinationPortEnd))
                ) && 
                (
                    this.sourceAddressStart == input.sourceAddressStart ||
                    (this.sourceAddressStart != null &&
                    this.sourceAddressStart.Equals(input.sourceAddressStart))
                ) && 
                (
                    this.sourceAddressEnd == input.sourceAddressEnd ||
                    (this.sourceAddressEnd != null &&
                    this.sourceAddressEnd.Equals(input.sourceAddressEnd))
                ) && 
                (
                    this.sourcePortStart == input.sourcePortStart ||
                    (this.sourcePortStart != null &&
                    this.sourcePortStart.Equals(input.sourcePortStart))
                ) && 
                (
                    this.sourcePortEnd == input.sourcePortEnd ||
                    (this.sourcePortEnd != null &&
                    this.sourcePortEnd.Equals(input.sourcePortEnd))
                ) && 
                (
                    this.comment == input.comment ||
                    (this.comment != null &&
                    this.comment.Equals(input.comment))
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
                if (this.direction != null)
                    hashCode = hashCode * 59 + this.direction.GetHashCode();
                if (this.action != null)
                    hashCode = hashCode * 59 + this.action.GetHashCode();
                if (this.position != null)
                    hashCode = hashCode * 59 + this.position.GetHashCode();
                if (this.family != null)
                    hashCode = hashCode * 59 + this.family.GetHashCode();
                if (this.protocol != null)
                    hashCode = hashCode * 59 + this.protocol.GetHashCode();
                if (this.icmpType != null)
                    hashCode = hashCode * 59 + this.icmpType.GetHashCode();
                if (this.destinationAddressStart != null)
                    hashCode = hashCode * 59 + this.destinationAddressStart.GetHashCode();
                if (this.destinationAddressEnd != null)
                    hashCode = hashCode * 59 + this.destinationAddressEnd.GetHashCode();
                if (this.destinationPortStart != null)
                    hashCode = hashCode * 59 + this.destinationPortStart.GetHashCode();
                if (this.destinationPortEnd != null)
                    hashCode = hashCode * 59 + this.destinationPortEnd.GetHashCode();
                if (this.sourceAddressStart != null)
                    hashCode = hashCode * 59 + this.sourceAddressStart.GetHashCode();
                if (this.sourceAddressEnd != null)
                    hashCode = hashCode * 59 + this.sourceAddressEnd.GetHashCode();
                if (this.sourcePortStart != null)
                    hashCode = hashCode * 59 + this.sourcePortStart.GetHashCode();
                if (this.sourcePortEnd != null)
                    hashCode = hashCode * 59 + this.sourcePortEnd.GetHashCode();
                if (this.comment != null)
                    hashCode = hashCode * 59 + this.comment.GetHashCode();
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
            // position (decimal?) maximum
            if(this.position > (decimal?)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for position, must be a value less than or equal to 1000.", new [] { "position" });
            }

            // position (decimal?) minimum
            if(this.position < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for position, must be a value greater than or equal to 1.", new [] { "position" });
            }

            // destinationPortStart (decimal?) maximum
            if(this.destinationPortStart > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for destinationPortStart, must be a value less than or equal to 65535.", new [] { "destinationPortStart" });
            }

            // destinationPortStart (decimal?) minimum
            if(this.destinationPortStart < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for destinationPortStart, must be a value greater than or equal to 1.", new [] { "destinationPortStart" });
            }

            // destinationPortEnd (decimal?) maximum
            if(this.destinationPortEnd > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for destinationPortEnd, must be a value less than or equal to 65535.", new [] { "destinationPortEnd" });
            }

            // destinationPortEnd (decimal?) minimum
            if(this.destinationPortEnd < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for destinationPortEnd, must be a value greater than or equal to 1.", new [] { "destinationPortEnd" });
            }

            // sourcePortStart (decimal?) maximum
            if(this.sourcePortStart > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for sourcePortStart, must be a value less than or equal to 65535.", new [] { "sourcePortStart" });
            }

            // sourcePortStart (decimal?) minimum
            if(this.sourcePortStart < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for sourcePortStart, must be a value greater than or equal to 1.", new [] { "sourcePortStart" });
            }

            // sourcePortEnd (decimal?) maximum
            if(this.sourcePortEnd > (decimal?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for sourcePortEnd, must be a value less than or equal to 65535.", new [] { "sourcePortEnd" });
            }

            // sourcePortEnd (decimal?) minimum
            if(this.sourcePortEnd < (decimal?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for sourcePortEnd, must be a value greater than or equal to 1.", new [] { "sourcePortEnd" });
            }

            // comment (string) maxLength
            if(this.comment != null && this.comment.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for comment, length must be less than 255.", new [] { "comment" });
            }

            // comment (string) minLength
            if(this.comment != null && this.comment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for comment, length must be greater than 0.", new [] { "comment" });
            }

            yield break;
        }
    }

}
