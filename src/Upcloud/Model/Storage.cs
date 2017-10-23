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
    /// Storage
    /// </summary>
    [DataContract]
    public partial class Storage :  IEquatable<Storage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage" /> class.
        /// </summary>
        /// <param name="access">access.</param>
        /// <param name="backupRule">backupRule.</param>
        /// <param name="backups">backups.</param>
        /// <param name="license">license.</param>
        /// <param name="servers">servers.</param>
        /// <param name="size">size.</param>
        /// <param name="state">state.</param>
        /// <param name="tier">tier.</param>
        /// <param name="title">title.</param>
        /// <param name="type">type.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="zone">zone.</param>
        /// <param name="origin">origin.</param>
        /// <param name="created">created.</param>
        public Storage(StorageAccessType access = default(StorageAccessType), BackupRule backupRule = default(BackupRule), StorageBackups backups = default(StorageBackups), decimal? license = default(decimal?), StorageServers servers = default(StorageServers), decimal? size = default(decimal?), StorageState state = default(StorageState), StorageTier tier = default(StorageTier), string title = default(string), StorageType type = default(StorageType), Guid? uuid = default(Guid?), string zone = default(string), Guid? origin = default(Guid?), string created = default(string))
        {
            this.access = access;
            this.backupRule = backupRule;
            this.backups = backups;
            this.license = license;
            this.servers = servers;
            this.size = size;
            this.state = state;
            this.tier = tier;
            this.title = title;
            this.type = type;
            this.uuid = uuid;
            this.zone = zone;
            this.origin = origin;
            this.created = created;
        }
        
        /// <summary>
        /// Gets or Sets access
        /// </summary>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public StorageAccessType access { get; set; }

        /// <summary>
        /// Gets or Sets backupRule
        /// </summary>
        [DataMember(Name="backup_rule", EmitDefaultValue=false)]
        public BackupRule backupRule { get; set; }

        /// <summary>
        /// Gets or Sets backups
        /// </summary>
        [DataMember(Name="backups", EmitDefaultValue=false)]
        public StorageBackups backups { get; set; }

        /// <summary>
        /// Gets or Sets license
        /// </summary>
        [DataMember(Name="license", EmitDefaultValue=false)]
        public decimal? license { get; set; }

        /// <summary>
        /// Gets or Sets servers
        /// </summary>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public StorageServers servers { get; set; }

        /// <summary>
        /// Gets or Sets size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? size { get; set; }

        /// <summary>
        /// Gets or Sets state
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StorageState state { get; set; }

        /// <summary>
        /// Gets or Sets tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public StorageTier tier { get; set; }

        /// <summary>
        /// Gets or Sets title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string title { get; set; }

        /// <summary>
        /// Gets or Sets type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public StorageType type { get; set; }

        /// <summary>
        /// Gets or Sets uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? uuid { get; set; }

        /// <summary>
        /// Gets or Sets zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string zone { get; set; }

        /// <summary>
        /// Gets or Sets origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public Guid? origin { get; set; }

        /// <summary>
        /// Gets or Sets created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  access: ").Append(access).Append("\n");
            sb.Append("  backupRule: ").Append(backupRule).Append("\n");
            sb.Append("  backups: ").Append(backups).Append("\n");
            sb.Append("  license: ").Append(license).Append("\n");
            sb.Append("  servers: ").Append(servers).Append("\n");
            sb.Append("  size: ").Append(size).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  tier: ").Append(tier).Append("\n");
            sb.Append("  title: ").Append(title).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  uuid: ").Append(uuid).Append("\n");
            sb.Append("  zone: ").Append(zone).Append("\n");
            sb.Append("  origin: ").Append(origin).Append("\n");
            sb.Append("  created: ").Append(created).Append("\n");
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
                    this.access == input.access ||
                    (this.access != null &&
                    this.access.Equals(input.access))
                ) && 
                (
                    this.backupRule == input.backupRule ||
                    (this.backupRule != null &&
                    this.backupRule.Equals(input.backupRule))
                ) && 
                (
                    this.backups == input.backups ||
                    (this.backups != null &&
                    this.backups.Equals(input.backups))
                ) && 
                (
                    this.license == input.license ||
                    (this.license != null &&
                    this.license.Equals(input.license))
                ) && 
                (
                    this.servers == input.servers ||
                    (this.servers != null &&
                    this.servers.Equals(input.servers))
                ) && 
                (
                    this.size == input.size ||
                    (this.size != null &&
                    this.size.Equals(input.size))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.tier == input.tier ||
                    (this.tier != null &&
                    this.tier.Equals(input.tier))
                ) && 
                (
                    this.title == input.title ||
                    (this.title != null &&
                    this.title.Equals(input.title))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.uuid == input.uuid ||
                    (this.uuid != null &&
                    this.uuid.Equals(input.uuid))
                ) && 
                (
                    this.zone == input.zone ||
                    (this.zone != null &&
                    this.zone.Equals(input.zone))
                ) && 
                (
                    this.origin == input.origin ||
                    (this.origin != null &&
                    this.origin.Equals(input.origin))
                ) && 
                (
                    this.created == input.created ||
                    (this.created != null &&
                    this.created.Equals(input.created))
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
                if (this.backupRule != null)
                    hashCode = hashCode * 59 + this.backupRule.GetHashCode();
                if (this.backups != null)
                    hashCode = hashCode * 59 + this.backups.GetHashCode();
                if (this.license != null)
                    hashCode = hashCode * 59 + this.license.GetHashCode();
                if (this.servers != null)
                    hashCode = hashCode * 59 + this.servers.GetHashCode();
                if (this.size != null)
                    hashCode = hashCode * 59 + this.size.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.tier != null)
                    hashCode = hashCode * 59 + this.tier.GetHashCode();
                if (this.title != null)
                    hashCode = hashCode * 59 + this.title.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.uuid != null)
                    hashCode = hashCode * 59 + this.uuid.GetHashCode();
                if (this.zone != null)
                    hashCode = hashCode * 59 + this.zone.GetHashCode();
                if (this.origin != null)
                    hashCode = hashCode * 59 + this.origin.GetHashCode();
                if (this.created != null)
                    hashCode = hashCode * 59 + this.created.GetHashCode();
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
