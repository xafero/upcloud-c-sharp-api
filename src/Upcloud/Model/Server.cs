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
    /// The server configuration defines which storage devices the server is attached to, which IP addresses can be used and how the server can be reached for remote management. A server must have at least one storage device attached in order to be started. Servers may have from zero to five public IPv4 and IPv6 addresses. All servers have a private IP address that cannot be removed.
    /// </summary>
    [DataContract]
    public partial class Server :  IEquatable<Server>, IValidatableObject
    {
        /// <summary>
        /// The storage device boot order.
        /// </summary>
        /// <value>The storage device boot order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BootOrderEnum
        {
            
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
            /// Enum Diskcdrom for "disk,cdrom"
            /// </summary>
            [EnumMember(Value = "disk,cdrom")]
            Diskcdrom,
            
            /// <summary>
            /// Enum Cdromdisk for "cdrom,disk"
            /// </summary>
            [EnumMember(Value = "cdrom,disk")]
            Cdromdisk
        }

        /// <summary>
        /// The state of the server firewall rules.
        /// </summary>
        /// <value>The state of the server firewall rules.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FirewallEnum
        {
            
            /// <summary>
            /// Enum On for "on"
            /// </summary>
            [EnumMember(Value = "on")]
            On,
            
            /// <summary>
            /// Enum Off for "off"
            /// </summary>
            [EnumMember(Value = "off")]
            Off
        }

        /// <summary>
        /// The model of the server&#39;s video interface.
        /// </summary>
        /// <value>The model of the server&#39;s video interface.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VideoModelEnum
        {
            
            /// <summary>
            /// Enum Vga for "vga"
            /// </summary>
            [EnumMember(Value = "vga")]
            Vga,
            
            /// <summary>
            /// Enum Cirrus for "cirrus"
            /// </summary>
            [EnumMember(Value = "cirrus")]
            Cirrus
        }

        /// <summary>
        /// The state of the VNC remote access service.
        /// </summary>
        /// <value>The state of the VNC remote access service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VncEnum
        {
            
            /// <summary>
            /// Enum On for "on"
            /// </summary>
            [EnumMember(Value = "on")]
            On,
            
            /// <summary>
            /// Enum Off for "off"
            /// </summary>
            [EnumMember(Value = "off")]
            Off
        }

        /// <summary>
        /// The storage device boot order.
        /// </summary>
        /// <value>The storage device boot order.</value>
        [DataMember(Name="boot_order", EmitDefaultValue=false)]
        public BootOrderEnum? BootOrder { get; set; }
        /// <summary>
        /// The state of the server firewall rules.
        /// </summary>
        /// <value>The state of the server firewall rules.</value>
        [DataMember(Name="firewall", EmitDefaultValue=false)]
        public FirewallEnum? Firewall { get; set; }
        /// <summary>
        /// The model of the server&#39;s video interface.
        /// </summary>
        /// <value>The model of the server&#39;s video interface.</value>
        [DataMember(Name="video_model", EmitDefaultValue=false)]
        public VideoModelEnum? VideoModel { get; set; }
        /// <summary>
        /// The state of the VNC remote access service.
        /// </summary>
        /// <value>The state of the VNC remote access service.</value>
        [DataMember(Name="vnc", EmitDefaultValue=false)]
        public VncEnum? Vnc { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        /// <param name="BootOrder">The storage device boot order..</param>
        /// <param name="CoreNumber">The number of CPU cores dedicated to the server. See List server configurations..</param>
        /// <param name="Firewall">The state of the server firewall rules. (default to FirewallEnum.On).</param>
        /// <param name="Host">Host.</param>
        /// <param name="Hostname">A valid hostname, e.g. host.example.com. The maximum length is 128 characters..</param>
        /// <param name="IpAddresses">IpAddresses.</param>
        /// <param name="License">License.</param>
        /// <param name="MemoryAmount">The amount of main memory in megabytes. See List server configurations..</param>
        /// <param name="NicModel">The model of the server&#39;s network interfaces. (default to &quot;e1000&quot;).</param>
        /// <param name="Plan">The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present. (default to &quot;custom&quot;).</param>
        /// <param name="PlanIpv4Bytes">PlanIpv4Bytes.</param>
        /// <param name="PlanIpv6Bytes">PlanIpv6Bytes.</param>
        /// <param name="State">State.</param>
        /// <param name="StorageDevices">StorageDevices.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Timezone">A timezone identifier, e.g. Europe/Helsinki. See Timezones..</param>
        /// <param name="Title">A short description..</param>
        /// <param name="Uuid">Uuid.</param>
        /// <param name="VideoModel">The model of the server&#39;s video interface. (default to VideoModelEnum.Vga).</param>
        /// <param name="Vnc">The state of the VNC remote access service. (default to VncEnum.Off).</param>
        /// <param name="VncHost">VncHost.</param>
        /// <param name="VncPassword">The VNC remote access password..</param>
        /// <param name="VncPort">VncPort.</param>
        /// <param name="Zone">Zone.</param>
        public Server(BootOrderEnum? BootOrder = default(BootOrderEnum?), decimal? CoreNumber = default(decimal?), FirewallEnum? Firewall = FirewallEnum.On, decimal? Host = default(decimal?), string Hostname = default(string), IpAddressListResponseIpAddresses IpAddresses = default(IpAddressListResponseIpAddresses), decimal? License = default(decimal?), decimal? MemoryAmount = default(decimal?), string NicModel = "e1000", string Plan = "custom", decimal? PlanIpv4Bytes = default(decimal?), decimal? PlanIpv6Bytes = default(decimal?), ServerState State = default(ServerState), ServerStorageDevices StorageDevices = default(ServerStorageDevices), ServerTags Tags = default(ServerTags), Timezone Timezone = default(Timezone), string Title = default(string), Guid? Uuid = default(Guid?), VideoModelEnum? VideoModel = VideoModelEnum.Vga, VncEnum? Vnc = VncEnum.Off, string VncHost = default(string), string VncPassword = default(string), string VncPort = default(string), string Zone = default(string))
        {
            this.BootOrder = BootOrder;
            this.CoreNumber = CoreNumber;
            // use default value if no "Firewall" provided
            if (Firewall == null)
            {
                this.Firewall = FirewallEnum.On;
            }
            else
            {
                this.Firewall = Firewall;
            }
            this.Host = Host;
            this.Hostname = Hostname;
            this.IpAddresses = IpAddresses;
            this.License = License;
            this.MemoryAmount = MemoryAmount;
            // use default value if no "NicModel" provided
            if (NicModel == null)
            {
                this.NicModel = "e1000";
            }
            else
            {
                this.NicModel = NicModel;
            }
            // use default value if no "Plan" provided
            if (Plan == null)
            {
                this.Plan = "custom";
            }
            else
            {
                this.Plan = Plan;
            }
            this.PlanIpv4Bytes = PlanIpv4Bytes;
            this.PlanIpv6Bytes = PlanIpv6Bytes;
            this.State = State;
            this.StorageDevices = StorageDevices;
            this.Tags = Tags;
            this.Timezone = Timezone;
            this.Title = Title;
            this.Uuid = Uuid;
            // use default value if no "VideoModel" provided
            if (VideoModel == null)
            {
                this.VideoModel = VideoModelEnum.Vga;
            }
            else
            {
                this.VideoModel = VideoModel;
            }
            // use default value if no "Vnc" provided
            if (Vnc == null)
            {
                this.Vnc = VncEnum.Off;
            }
            else
            {
                this.Vnc = Vnc;
            }
            this.VncHost = VncHost;
            this.VncPassword = VncPassword;
            this.VncPort = VncPort;
            this.Zone = Zone;
        }
        

        /// <summary>
        /// The number of CPU cores dedicated to the server. See List server configurations.
        /// </summary>
        /// <value>The number of CPU cores dedicated to the server. See List server configurations.</value>
        [DataMember(Name="core_number", EmitDefaultValue=false)]
        public decimal? CoreNumber { get; set; }


        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public decimal? Host { get; set; }

        /// <summary>
        /// A valid hostname, e.g. host.example.com. The maximum length is 128 characters.
        /// </summary>
        /// <value>A valid hostname, e.g. host.example.com. The maximum length is 128 characters.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or Sets IpAddresses
        /// </summary>
        [DataMember(Name="ip_addresses", EmitDefaultValue=false)]
        public IpAddressListResponseIpAddresses IpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name="license", EmitDefaultValue=false)]
        public decimal? License { get; set; }

        /// <summary>
        /// The amount of main memory in megabytes. See List server configurations.
        /// </summary>
        /// <value>The amount of main memory in megabytes. See List server configurations.</value>
        [DataMember(Name="memory_amount", EmitDefaultValue=false)]
        public decimal? MemoryAmount { get; set; }

        /// <summary>
        /// The model of the server&#39;s network interfaces.
        /// </summary>
        /// <value>The model of the server&#39;s network interfaces.</value>
        [DataMember(Name="nic_model", EmitDefaultValue=false)]
        public string NicModel { get; set; }

        /// <summary>
        /// The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present.
        /// </summary>
        /// <value>The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present.</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }

        /// <summary>
        /// Gets or Sets PlanIpv4Bytes
        /// </summary>
        [DataMember(Name="plan_ipv4_bytes", EmitDefaultValue=false)]
        public decimal? PlanIpv4Bytes { get; set; }

        /// <summary>
        /// Gets or Sets PlanIpv6Bytes
        /// </summary>
        [DataMember(Name="plan_ipv6_bytes", EmitDefaultValue=false)]
        public decimal? PlanIpv6Bytes { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ServerState State { get; set; }

        /// <summary>
        /// Gets or Sets StorageDevices
        /// </summary>
        [DataMember(Name="storage_devices", EmitDefaultValue=false)]
        public ServerStorageDevices StorageDevices { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ServerTags Tags { get; set; }

        /// <summary>
        /// A timezone identifier, e.g. Europe/Helsinki. See Timezones.
        /// </summary>
        /// <value>A timezone identifier, e.g. Europe/Helsinki. See Timezones.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public Timezone Timezone { get; set; }

        /// <summary>
        /// A short description.
        /// </summary>
        /// <value>A short description.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }



        /// <summary>
        /// Gets or Sets VncHost
        /// </summary>
        [DataMember(Name="vnc_host", EmitDefaultValue=false)]
        public string VncHost { get; set; }

        /// <summary>
        /// The VNC remote access password.
        /// </summary>
        /// <value>The VNC remote access password.</value>
        [DataMember(Name="vnc_password", EmitDefaultValue=false)]
        public string VncPassword { get; set; }

        /// <summary>
        /// Gets or Sets VncPort
        /// </summary>
        [DataMember(Name="vnc_port", EmitDefaultValue=false)]
        public string VncPort { get; set; }

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
            sb.Append("class Server {\n");
            sb.Append("  BootOrder: ").Append(BootOrder).Append("\n");
            sb.Append("  CoreNumber: ").Append(CoreNumber).Append("\n");
            sb.Append("  Firewall: ").Append(Firewall).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  MemoryAmount: ").Append(MemoryAmount).Append("\n");
            sb.Append("  NicModel: ").Append(NicModel).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  PlanIpv4Bytes: ").Append(PlanIpv4Bytes).Append("\n");
            sb.Append("  PlanIpv6Bytes: ").Append(PlanIpv6Bytes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StorageDevices: ").Append(StorageDevices).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  VideoModel: ").Append(VideoModel).Append("\n");
            sb.Append("  Vnc: ").Append(Vnc).Append("\n");
            sb.Append("  VncHost: ").Append(VncHost).Append("\n");
            sb.Append("  VncPassword: ").Append(VncPassword).Append("\n");
            sb.Append("  VncPort: ").Append(VncPort).Append("\n");
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
            return this.Equals(input as Server);
        }

        /// <summary>
        /// Returns true if Server instances are equal
        /// </summary>
        /// <param name="input">Instance of Server to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Server input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BootOrder == input.BootOrder ||
                    (this.BootOrder != null &&
                    this.BootOrder.Equals(input.BootOrder))
                ) && 
                (
                    this.CoreNumber == input.CoreNumber ||
                    (this.CoreNumber != null &&
                    this.CoreNumber.Equals(input.CoreNumber))
                ) && 
                (
                    this.Firewall == input.Firewall ||
                    (this.Firewall != null &&
                    this.Firewall.Equals(input.Firewall))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    (this.IpAddresses != null &&
                    this.IpAddresses.Equals(input.IpAddresses))
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.MemoryAmount == input.MemoryAmount ||
                    (this.MemoryAmount != null &&
                    this.MemoryAmount.Equals(input.MemoryAmount))
                ) && 
                (
                    this.NicModel == input.NicModel ||
                    (this.NicModel != null &&
                    this.NicModel.Equals(input.NicModel))
                ) && 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
                ) && 
                (
                    this.PlanIpv4Bytes == input.PlanIpv4Bytes ||
                    (this.PlanIpv4Bytes != null &&
                    this.PlanIpv4Bytes.Equals(input.PlanIpv4Bytes))
                ) && 
                (
                    this.PlanIpv6Bytes == input.PlanIpv6Bytes ||
                    (this.PlanIpv6Bytes != null &&
                    this.PlanIpv6Bytes.Equals(input.PlanIpv6Bytes))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StorageDevices == input.StorageDevices ||
                    (this.StorageDevices != null &&
                    this.StorageDevices.Equals(input.StorageDevices))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VideoModel == input.VideoModel ||
                    (this.VideoModel != null &&
                    this.VideoModel.Equals(input.VideoModel))
                ) && 
                (
                    this.Vnc == input.Vnc ||
                    (this.Vnc != null &&
                    this.Vnc.Equals(input.Vnc))
                ) && 
                (
                    this.VncHost == input.VncHost ||
                    (this.VncHost != null &&
                    this.VncHost.Equals(input.VncHost))
                ) && 
                (
                    this.VncPassword == input.VncPassword ||
                    (this.VncPassword != null &&
                    this.VncPassword.Equals(input.VncPassword))
                ) && 
                (
                    this.VncPort == input.VncPort ||
                    (this.VncPort != null &&
                    this.VncPort.Equals(input.VncPort))
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
                if (this.BootOrder != null)
                    hashCode = hashCode * 59 + this.BootOrder.GetHashCode();
                if (this.CoreNumber != null)
                    hashCode = hashCode * 59 + this.CoreNumber.GetHashCode();
                if (this.Firewall != null)
                    hashCode = hashCode * 59 + this.Firewall.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.MemoryAmount != null)
                    hashCode = hashCode * 59 + this.MemoryAmount.GetHashCode();
                if (this.NicModel != null)
                    hashCode = hashCode * 59 + this.NicModel.GetHashCode();
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.PlanIpv4Bytes != null)
                    hashCode = hashCode * 59 + this.PlanIpv4Bytes.GetHashCode();
                if (this.PlanIpv6Bytes != null)
                    hashCode = hashCode * 59 + this.PlanIpv6Bytes.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StorageDevices != null)
                    hashCode = hashCode * 59 + this.StorageDevices.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.VideoModel != null)
                    hashCode = hashCode * 59 + this.VideoModel.GetHashCode();
                if (this.Vnc != null)
                    hashCode = hashCode * 59 + this.Vnc.GetHashCode();
                if (this.VncHost != null)
                    hashCode = hashCode * 59 + this.VncHost.GetHashCode();
                if (this.VncPassword != null)
                    hashCode = hashCode * 59 + this.VncPassword.GetHashCode();
                if (this.VncPort != null)
                    hashCode = hashCode * 59 + this.VncPort.GetHashCode();
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