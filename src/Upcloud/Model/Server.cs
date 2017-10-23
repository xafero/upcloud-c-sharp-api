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
        public BootOrderEnum? bootOrder { get; set; }
        /// <summary>
        /// The state of the server firewall rules.
        /// </summary>
        /// <value>The state of the server firewall rules.</value>
        [DataMember(Name="firewall", EmitDefaultValue=false)]
        public FirewallEnum? firewall { get; set; }
        /// <summary>
        /// The model of the server&#39;s video interface.
        /// </summary>
        /// <value>The model of the server&#39;s video interface.</value>
        [DataMember(Name="video_model", EmitDefaultValue=false)]
        public VideoModelEnum? videoModel { get; set; }
        /// <summary>
        /// The state of the VNC remote access service.
        /// </summary>
        /// <value>The state of the VNC remote access service.</value>
        [DataMember(Name="vnc", EmitDefaultValue=false)]
        public VncEnum? vnc { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        /// <param name="bootOrder">The storage device boot order..</param>
        /// <param name="coreNumber">The number of CPU cores dedicated to the server. See List server configurations..</param>
        /// <param name="firewall">The state of the server firewall rules. (default to FirewallEnum.On).</param>
        /// <param name="host">host.</param>
        /// <param name="hostname">A valid hostname, e.g. host.example.com. The maximum length is 128 characters..</param>
        /// <param name="ipAddresses">ipAddresses.</param>
        /// <param name="license">license.</param>
        /// <param name="memoryAmount">The amount of main memory in megabytes. See List server configurations..</param>
        /// <param name="nicModel">The model of the server&#39;s network interfaces. (default to &quot;e1000&quot;).</param>
        /// <param name="plan">The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present. (default to &quot;custom&quot;).</param>
        /// <param name="planIpv4Bytes">planIpv4Bytes.</param>
        /// <param name="planIpv6Bytes">planIpv6Bytes.</param>
        /// <param name="state">state.</param>
        /// <param name="storageDevices">storageDevices.</param>
        /// <param name="tags">tags.</param>
        /// <param name="timezone">A timezone identifier, e.g. Europe/Helsinki. See Timezones..</param>
        /// <param name="title">A short description..</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="videoModel">The model of the server&#39;s video interface. (default to VideoModelEnum.Vga).</param>
        /// <param name="vnc">The state of the VNC remote access service. (default to VncEnum.Off).</param>
        /// <param name="vncHost">vncHost.</param>
        /// <param name="vncPassword">The VNC remote access password..</param>
        /// <param name="vncPort">vncPort.</param>
        /// <param name="zone">zone.</param>
        public Server(BootOrderEnum? bootOrder = default(BootOrderEnum?), decimal? coreNumber = default(decimal?), FirewallEnum? firewall = FirewallEnum.On, decimal? host = default(decimal?), string hostname = default(string), IpAddresses ipAddresses = default(IpAddresses), decimal? license = default(decimal?), decimal? memoryAmount = default(decimal?), string nicModel = "e1000", string plan = "custom", decimal? planIpv4Bytes = default(decimal?), decimal? planIpv6Bytes = default(decimal?), ServerState state = default(ServerState), ServerStorageDevices storageDevices = default(ServerStorageDevices), ServerTags tags = default(ServerTags), string timezone = default(string), string title = default(string), Guid? uuid = default(Guid?), VideoModelEnum? videoModel = VideoModelEnum.Vga, VncEnum? vnc = VncEnum.Off, string vncHost = default(string), string vncPassword = default(string), string vncPort = default(string), string zone = default(string))
        {
            this.bootOrder = bootOrder;
            this.coreNumber = coreNumber;
            // use default value if no "firewall" provided
            if (firewall == null)
            {
                this.firewall = FirewallEnum.On;
            }
            else
            {
                this.firewall = firewall;
            }
            this.host = host;
            this.hostname = hostname;
            this.ipAddresses = ipAddresses;
            this.license = license;
            this.memoryAmount = memoryAmount;
            // use default value if no "nicModel" provided
            if (nicModel == null)
            {
                this.nicModel = "e1000";
            }
            else
            {
                this.nicModel = nicModel;
            }
            // use default value if no "plan" provided
            if (plan == null)
            {
                this.plan = "custom";
            }
            else
            {
                this.plan = plan;
            }
            this.planIpv4Bytes = planIpv4Bytes;
            this.planIpv6Bytes = planIpv6Bytes;
            this.state = state;
            this.storageDevices = storageDevices;
            this.tags = tags;
            this.timezone = timezone;
            this.title = title;
            this.uuid = uuid;
            // use default value if no "videoModel" provided
            if (videoModel == null)
            {
                this.videoModel = VideoModelEnum.Vga;
            }
            else
            {
                this.videoModel = videoModel;
            }
            // use default value if no "vnc" provided
            if (vnc == null)
            {
                this.vnc = VncEnum.Off;
            }
            else
            {
                this.vnc = vnc;
            }
            this.vncHost = vncHost;
            this.vncPassword = vncPassword;
            this.vncPort = vncPort;
            this.zone = zone;
        }
        

        /// <summary>
        /// The number of CPU cores dedicated to the server. See List server configurations.
        /// </summary>
        /// <value>The number of CPU cores dedicated to the server. See List server configurations.</value>
        [DataMember(Name="core_number", EmitDefaultValue=false)]
        public decimal? coreNumber { get; set; }


        /// <summary>
        /// Gets or Sets host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public decimal? host { get; set; }

        /// <summary>
        /// A valid hostname, e.g. host.example.com. The maximum length is 128 characters.
        /// </summary>
        /// <value>A valid hostname, e.g. host.example.com. The maximum length is 128 characters.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string hostname { get; set; }

        /// <summary>
        /// Gets or Sets ipAddresses
        /// </summary>
        [DataMember(Name="ip_addresses", EmitDefaultValue=false)]
        public IpAddresses ipAddresses { get; set; }

        /// <summary>
        /// Gets or Sets license
        /// </summary>
        [DataMember(Name="license", EmitDefaultValue=false)]
        public decimal? license { get; set; }

        /// <summary>
        /// The amount of main memory in megabytes. See List server configurations.
        /// </summary>
        /// <value>The amount of main memory in megabytes. See List server configurations.</value>
        [DataMember(Name="memory_amount", EmitDefaultValue=false)]
        public decimal? memoryAmount { get; set; }

        /// <summary>
        /// The model of the server&#39;s network interfaces.
        /// </summary>
        /// <value>The model of the server&#39;s network interfaces.</value>
        [DataMember(Name="nic_model", EmitDefaultValue=false)]
        public string nicModel { get; set; }

        /// <summary>
        /// The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present.
        /// </summary>
        /// <value>The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present.</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string plan { get; set; }

        /// <summary>
        /// Gets or Sets planIpv4Bytes
        /// </summary>
        [DataMember(Name="plan_ipv4_bytes", EmitDefaultValue=false)]
        public decimal? planIpv4Bytes { get; set; }

        /// <summary>
        /// Gets or Sets planIpv6Bytes
        /// </summary>
        [DataMember(Name="plan_ipv6_bytes", EmitDefaultValue=false)]
        public decimal? planIpv6Bytes { get; set; }

        /// <summary>
        /// Gets or Sets state
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ServerState state { get; set; }

        /// <summary>
        /// Gets or Sets storageDevices
        /// </summary>
        [DataMember(Name="storage_devices", EmitDefaultValue=false)]
        public ServerStorageDevices storageDevices { get; set; }

        /// <summary>
        /// Gets or Sets tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public ServerTags tags { get; set; }

        /// <summary>
        /// A timezone identifier, e.g. Europe/Helsinki. See Timezones.
        /// </summary>
        /// <value>A timezone identifier, e.g. Europe/Helsinki. See Timezones.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string timezone { get; set; }

        /// <summary>
        /// A short description.
        /// </summary>
        /// <value>A short description.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string title { get; set; }

        /// <summary>
        /// Gets or Sets uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? uuid { get; set; }



        /// <summary>
        /// Gets or Sets vncHost
        /// </summary>
        [DataMember(Name="vnc_host", EmitDefaultValue=false)]
        public string vncHost { get; set; }

        /// <summary>
        /// The VNC remote access password.
        /// </summary>
        /// <value>The VNC remote access password.</value>
        [DataMember(Name="vnc_password", EmitDefaultValue=false)]
        public string vncPassword { get; set; }

        /// <summary>
        /// Gets or Sets vncPort
        /// </summary>
        [DataMember(Name="vnc_port", EmitDefaultValue=false)]
        public string vncPort { get; set; }

        /// <summary>
        /// Gets or Sets zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string zone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Server {\n");
            sb.Append("  bootOrder: ").Append(bootOrder).Append("\n");
            sb.Append("  coreNumber: ").Append(coreNumber).Append("\n");
            sb.Append("  firewall: ").Append(firewall).Append("\n");
            sb.Append("  host: ").Append(host).Append("\n");
            sb.Append("  hostname: ").Append(hostname).Append("\n");
            sb.Append("  ipAddresses: ").Append(ipAddresses).Append("\n");
            sb.Append("  license: ").Append(license).Append("\n");
            sb.Append("  memoryAmount: ").Append(memoryAmount).Append("\n");
            sb.Append("  nicModel: ").Append(nicModel).Append("\n");
            sb.Append("  plan: ").Append(plan).Append("\n");
            sb.Append("  planIpv4Bytes: ").Append(planIpv4Bytes).Append("\n");
            sb.Append("  planIpv6Bytes: ").Append(planIpv6Bytes).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  storageDevices: ").Append(storageDevices).Append("\n");
            sb.Append("  tags: ").Append(tags).Append("\n");
            sb.Append("  timezone: ").Append(timezone).Append("\n");
            sb.Append("  title: ").Append(title).Append("\n");
            sb.Append("  uuid: ").Append(uuid).Append("\n");
            sb.Append("  videoModel: ").Append(videoModel).Append("\n");
            sb.Append("  vnc: ").Append(vnc).Append("\n");
            sb.Append("  vncHost: ").Append(vncHost).Append("\n");
            sb.Append("  vncPassword: ").Append(vncPassword).Append("\n");
            sb.Append("  vncPort: ").Append(vncPort).Append("\n");
            sb.Append("  zone: ").Append(zone).Append("\n");
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
                    this.bootOrder == input.bootOrder ||
                    (this.bootOrder != null &&
                    this.bootOrder.Equals(input.bootOrder))
                ) && 
                (
                    this.coreNumber == input.coreNumber ||
                    (this.coreNumber != null &&
                    this.coreNumber.Equals(input.coreNumber))
                ) && 
                (
                    this.firewall == input.firewall ||
                    (this.firewall != null &&
                    this.firewall.Equals(input.firewall))
                ) && 
                (
                    this.host == input.host ||
                    (this.host != null &&
                    this.host.Equals(input.host))
                ) && 
                (
                    this.hostname == input.hostname ||
                    (this.hostname != null &&
                    this.hostname.Equals(input.hostname))
                ) && 
                (
                    this.ipAddresses == input.ipAddresses ||
                    (this.ipAddresses != null &&
                    this.ipAddresses.Equals(input.ipAddresses))
                ) && 
                (
                    this.license == input.license ||
                    (this.license != null &&
                    this.license.Equals(input.license))
                ) && 
                (
                    this.memoryAmount == input.memoryAmount ||
                    (this.memoryAmount != null &&
                    this.memoryAmount.Equals(input.memoryAmount))
                ) && 
                (
                    this.nicModel == input.nicModel ||
                    (this.nicModel != null &&
                    this.nicModel.Equals(input.nicModel))
                ) && 
                (
                    this.plan == input.plan ||
                    (this.plan != null &&
                    this.plan.Equals(input.plan))
                ) && 
                (
                    this.planIpv4Bytes == input.planIpv4Bytes ||
                    (this.planIpv4Bytes != null &&
                    this.planIpv4Bytes.Equals(input.planIpv4Bytes))
                ) && 
                (
                    this.planIpv6Bytes == input.planIpv6Bytes ||
                    (this.planIpv6Bytes != null &&
                    this.planIpv6Bytes.Equals(input.planIpv6Bytes))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.storageDevices == input.storageDevices ||
                    (this.storageDevices != null &&
                    this.storageDevices.Equals(input.storageDevices))
                ) && 
                (
                    this.tags == input.tags ||
                    (this.tags != null &&
                    this.tags.Equals(input.tags))
                ) && 
                (
                    this.timezone == input.timezone ||
                    (this.timezone != null &&
                    this.timezone.Equals(input.timezone))
                ) && 
                (
                    this.title == input.title ||
                    (this.title != null &&
                    this.title.Equals(input.title))
                ) && 
                (
                    this.uuid == input.uuid ||
                    (this.uuid != null &&
                    this.uuid.Equals(input.uuid))
                ) && 
                (
                    this.videoModel == input.videoModel ||
                    (this.videoModel != null &&
                    this.videoModel.Equals(input.videoModel))
                ) && 
                (
                    this.vnc == input.vnc ||
                    (this.vnc != null &&
                    this.vnc.Equals(input.vnc))
                ) && 
                (
                    this.vncHost == input.vncHost ||
                    (this.vncHost != null &&
                    this.vncHost.Equals(input.vncHost))
                ) && 
                (
                    this.vncPassword == input.vncPassword ||
                    (this.vncPassword != null &&
                    this.vncPassword.Equals(input.vncPassword))
                ) && 
                (
                    this.vncPort == input.vncPort ||
                    (this.vncPort != null &&
                    this.vncPort.Equals(input.vncPort))
                ) && 
                (
                    this.zone == input.zone ||
                    (this.zone != null &&
                    this.zone.Equals(input.zone))
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
                if (this.bootOrder != null)
                    hashCode = hashCode * 59 + this.bootOrder.GetHashCode();
                if (this.coreNumber != null)
                    hashCode = hashCode * 59 + this.coreNumber.GetHashCode();
                if (this.firewall != null)
                    hashCode = hashCode * 59 + this.firewall.GetHashCode();
                if (this.host != null)
                    hashCode = hashCode * 59 + this.host.GetHashCode();
                if (this.hostname != null)
                    hashCode = hashCode * 59 + this.hostname.GetHashCode();
                if (this.ipAddresses != null)
                    hashCode = hashCode * 59 + this.ipAddresses.GetHashCode();
                if (this.license != null)
                    hashCode = hashCode * 59 + this.license.GetHashCode();
                if (this.memoryAmount != null)
                    hashCode = hashCode * 59 + this.memoryAmount.GetHashCode();
                if (this.nicModel != null)
                    hashCode = hashCode * 59 + this.nicModel.GetHashCode();
                if (this.plan != null)
                    hashCode = hashCode * 59 + this.plan.GetHashCode();
                if (this.planIpv4Bytes != null)
                    hashCode = hashCode * 59 + this.planIpv4Bytes.GetHashCode();
                if (this.planIpv6Bytes != null)
                    hashCode = hashCode * 59 + this.planIpv6Bytes.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.storageDevices != null)
                    hashCode = hashCode * 59 + this.storageDevices.GetHashCode();
                if (this.tags != null)
                    hashCode = hashCode * 59 + this.tags.GetHashCode();
                if (this.timezone != null)
                    hashCode = hashCode * 59 + this.timezone.GetHashCode();
                if (this.title != null)
                    hashCode = hashCode * 59 + this.title.GetHashCode();
                if (this.uuid != null)
                    hashCode = hashCode * 59 + this.uuid.GetHashCode();
                if (this.videoModel != null)
                    hashCode = hashCode * 59 + this.videoModel.GetHashCode();
                if (this.vnc != null)
                    hashCode = hashCode * 59 + this.vnc.GetHashCode();
                if (this.vncHost != null)
                    hashCode = hashCode * 59 + this.vncHost.GetHashCode();
                if (this.vncPassword != null)
                    hashCode = hashCode * 59 + this.vncPassword.GetHashCode();
                if (this.vncPort != null)
                    hashCode = hashCode * 59 + this.vncPort.GetHashCode();
                if (this.zone != null)
                    hashCode = hashCode * 59 + this.zone.GetHashCode();
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
