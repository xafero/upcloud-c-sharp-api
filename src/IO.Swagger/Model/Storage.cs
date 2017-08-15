/* 
 * Upcloud api
 *
 * Upcloud api specification
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    /// Storage
    /// </summary>
    [DataContract]
    public partial class Storage :  IEquatable<Storage>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Access
        /// </summary>
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
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Online for "online"
            /// </summary>
            [EnumMember(Value = "online")]
            Online,
            
            /// <summary>
            /// Enum Maintenance for "maintenance"
            /// </summary>
            [EnumMember(Value = "maintenance")]
            Maintenance,
            
            /// <summary>
            /// Enum Cloning for "cloning"
            /// </summary>
            [EnumMember(Value = "cloning")]
            Cloning,
            
            /// <summary>
            /// Enum Backuping for "backuping"
            /// </summary>
            [EnumMember(Value = "backuping")]
            Backuping,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error
        }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TierEnum
        {
            
            /// <summary>
            /// Enum Hdd for "hdd"
            /// </summary>
            [EnumMember(Value = "hdd")]
            Hdd,
            
            /// <summary>
            /// Enum Maxiops for "maxiops"
            /// </summary>
            [EnumMember(Value = "maxiops")]
            Maxiops
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Normal for "normal"
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal,
            
            /// <summary>
            /// Enum Disk for "disk"
            /// </summary>
            [EnumMember(Value = "disk")]
            Disk,
            
            /// <summary>
            /// Enum Cdrom for "cdrom"
            /// </summary>
            [EnumMember(Value = "cdrom")]
            Cdrom,
            
            /// <summary>
            /// Enum Template for "template"
            /// </summary>
            [EnumMember(Value = "template")]
            Template,
            
            /// <summary>
            /// Enum Backup for "backup"
            /// </summary>
            [EnumMember(Value = "backup")]
            Backup
        }

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public TierEnum? Tier { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage" /> class.
        /// </summary>
        /// <param name="Access">Access.</param>
        /// <param name="BackupRule">BackupRule.</param>
        /// <param name="Backups">Backups.</param>
        /// <param name="License">License.</param>
        /// <param name="Servers">Servers.</param>
        /// <param name="Size">Size.</param>
        /// <param name="State">State.</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Uuid">Uuid.</param>
        /// <param name="Zone">Zone.</param>
        public Storage(AccessEnum? Access = default(AccessEnum?), BackupRule BackupRule = default(BackupRule), StorageBackups Backups = default(StorageBackups), decimal? License = default(decimal?), StorageServers Servers = default(StorageServers), decimal? Size = default(decimal?), StateEnum? State = default(StateEnum?), TierEnum? Tier = default(TierEnum?), string Title = default(string), TypeEnum? Type = default(TypeEnum?), Guid? Uuid = default(Guid?), string Zone = default(string))
        {
            this.Access = Access;
            this.BackupRule = BackupRule;
            this.Backups = Backups;
            this.License = License;
            this.Servers = Servers;
            this.Size = Size;
            this.State = State;
            this.Tier = Tier;
            this.Title = Title;
            this.Type = Type;
            this.Uuid = Uuid;
            this.Zone = Zone;
        }
        

        /// <summary>
        /// Gets or Sets BackupRule
        /// </summary>
        [DataMember(Name="backup_rule", EmitDefaultValue=false)]
        public BackupRule BackupRule { get; set; }

        /// <summary>
        /// Gets or Sets Backups
        /// </summary>
        [DataMember(Name="backups", EmitDefaultValue=false)]
        public StorageBackups Backups { get; set; }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name="license", EmitDefaultValue=false)]
        public decimal? License { get; set; }

        /// <summary>
        /// Gets or Sets Servers
        /// </summary>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public StorageServers Servers { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }



        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }


        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string Zone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  BackupRule: ").Append(BackupRule).Append("\n");
            sb.Append("  Backups: ").Append(Backups).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
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
            return this.Equals(input as Storage);
        }

        /// <summary>
        /// Returns true if Storage instances are equal
        /// </summary>
        /// <param name="input">Instance of Storage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Storage input)
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
                    this.BackupRule == input.BackupRule ||
                    (this.BackupRule != null &&
                    this.BackupRule.Equals(input.BackupRule))
                ) && 
                (
                    this.Backups == input.Backups ||
                    (this.Backups != null &&
                    this.Backups.Equals(input.Backups))
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.Servers == input.Servers ||
                    (this.Servers != null &&
                    this.Servers.Equals(input.Servers))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
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
                if (this.BackupRule != null)
                    hashCode = hashCode * 59 + this.BackupRule.GetHashCode();
                if (this.Backups != null)
                    hashCode = hashCode * 59 + this.Backups.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Zone != null)
                    hashCode = hashCode * 59 + this.Zone.GetHashCode();
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
