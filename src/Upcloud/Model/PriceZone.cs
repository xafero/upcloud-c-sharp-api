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
    /// PriceZone
    /// </summary>
    [DataContract]
    public partial class PriceZone :  IEquatable<PriceZone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceZone" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="firewall">firewall.</param>
        /// <param name="ioRequestBackup">ioRequestBackup.</param>
        /// <param name="ioRequestHdd">ioRequestHdd.</param>
        /// <param name="ioRequestMaxiops">ioRequestMaxiops.</param>
        /// <param name="ipv4Address">ipv4Address.</param>
        /// <param name="ipv6Address">ipv6Address.</param>
        /// <param name="publicIpv4BandwidthIn">publicIpv4BandwidthIn.</param>
        /// <param name="publicIpv4BandwidthOut">publicIpv4BandwidthOut.</param>
        /// <param name="publicIpv6BandwidthIn">publicIpv6BandwidthIn.</param>
        /// <param name="publicIpv6BandwidthOut">publicIpv6BandwidthOut.</param>
        /// <param name="serverCore">serverCore.</param>
        /// <param name="serverMemory">serverMemory.</param>
        /// <param name="storageBackup">storageBackup.</param>
        /// <param name="storageHdd">storageHdd.</param>
        /// <param name="storageMaxiops">storageMaxiops.</param>
        /// <param name="serverPlan1xCPU1GB">serverPlan1xCPU1GB.</param>
        /// <param name="serverPlan2xCPU2GB">serverPlan2xCPU2GB.</param>
        public PriceZone(string name = default(string), Price firewall = default(Price), Price ioRequestBackup = default(Price), Price ioRequestHdd = default(Price), Price ioRequestMaxiops = default(Price), Price ipv4Address = default(Price), Price ipv6Address = default(Price), Price publicIpv4BandwidthIn = default(Price), Price publicIpv4BandwidthOut = default(Price), Price publicIpv6BandwidthIn = default(Price), Price publicIpv6BandwidthOut = default(Price), Price serverCore = default(Price), Price serverMemory = default(Price), Price storageBackup = default(Price), Price storageHdd = default(Price), Price storageMaxiops = default(Price), Price serverPlan1xCPU1GB = default(Price), Price serverPlan2xCPU2GB = default(Price))
        {
            this.name = name;
            this.firewall = firewall;
            this.ioRequestBackup = ioRequestBackup;
            this.ioRequestHdd = ioRequestHdd;
            this.ioRequestMaxiops = ioRequestMaxiops;
            this.ipv4Address = ipv4Address;
            this.ipv6Address = ipv6Address;
            this.publicIpv4BandwidthIn = publicIpv4BandwidthIn;
            this.publicIpv4BandwidthOut = publicIpv4BandwidthOut;
            this.publicIpv6BandwidthIn = publicIpv6BandwidthIn;
            this.publicIpv6BandwidthOut = publicIpv6BandwidthOut;
            this.serverCore = serverCore;
            this.serverMemory = serverMemory;
            this.storageBackup = storageBackup;
            this.storageHdd = storageHdd;
            this.storageMaxiops = storageMaxiops;
            this.serverPlan1xCPU1GB = serverPlan1xCPU1GB;
            this.serverPlan2xCPU2GB = serverPlan2xCPU2GB;
        }
        
        /// <summary>
        /// Gets or Sets name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Gets or Sets firewall
        /// </summary>
        [DataMember(Name="firewall", EmitDefaultValue=false)]
        public Price firewall { get; set; }

        /// <summary>
        /// Gets or Sets ioRequestBackup
        /// </summary>
        [DataMember(Name="io_request_backup", EmitDefaultValue=false)]
        public Price ioRequestBackup { get; set; }

        /// <summary>
        /// Gets or Sets ioRequestHdd
        /// </summary>
        [DataMember(Name="io_request_hdd", EmitDefaultValue=false)]
        public Price ioRequestHdd { get; set; }

        /// <summary>
        /// Gets or Sets ioRequestMaxiops
        /// </summary>
        [DataMember(Name="io_request_maxiops", EmitDefaultValue=false)]
        public Price ioRequestMaxiops { get; set; }

        /// <summary>
        /// Gets or Sets ipv4Address
        /// </summary>
        [DataMember(Name="ipv4_address", EmitDefaultValue=false)]
        public Price ipv4Address { get; set; }

        /// <summary>
        /// Gets or Sets ipv6Address
        /// </summary>
        [DataMember(Name="ipv6_address", EmitDefaultValue=false)]
        public Price ipv6Address { get; set; }

        /// <summary>
        /// Gets or Sets publicIpv4BandwidthIn
        /// </summary>
        [DataMember(Name="public_ipv4_bandwidth_in", EmitDefaultValue=false)]
        public Price publicIpv4BandwidthIn { get; set; }

        /// <summary>
        /// Gets or Sets publicIpv4BandwidthOut
        /// </summary>
        [DataMember(Name="public_ipv4_bandwidth_out", EmitDefaultValue=false)]
        public Price publicIpv4BandwidthOut { get; set; }

        /// <summary>
        /// Gets or Sets publicIpv6BandwidthIn
        /// </summary>
        [DataMember(Name="public_ipv6_bandwidth_in", EmitDefaultValue=false)]
        public Price publicIpv6BandwidthIn { get; set; }

        /// <summary>
        /// Gets or Sets publicIpv6BandwidthOut
        /// </summary>
        [DataMember(Name="public_ipv6_bandwidth_out", EmitDefaultValue=false)]
        public Price publicIpv6BandwidthOut { get; set; }

        /// <summary>
        /// Gets or Sets serverCore
        /// </summary>
        [DataMember(Name="server_core", EmitDefaultValue=false)]
        public Price serverCore { get; set; }

        /// <summary>
        /// Gets or Sets serverMemory
        /// </summary>
        [DataMember(Name="server_memory", EmitDefaultValue=false)]
        public Price serverMemory { get; set; }

        /// <summary>
        /// Gets or Sets storageBackup
        /// </summary>
        [DataMember(Name="storage_backup", EmitDefaultValue=false)]
        public Price storageBackup { get; set; }

        /// <summary>
        /// Gets or Sets storageHdd
        /// </summary>
        [DataMember(Name="storage_hdd", EmitDefaultValue=false)]
        public Price storageHdd { get; set; }

        /// <summary>
        /// Gets or Sets storageMaxiops
        /// </summary>
        [DataMember(Name="storage_maxiops", EmitDefaultValue=false)]
        public Price storageMaxiops { get; set; }

        /// <summary>
        /// Gets or Sets serverPlan1xCPU1GB
        /// </summary>
        [DataMember(Name="server_plan_1xCPU-1GB", EmitDefaultValue=false)]
        public Price serverPlan1xCPU1GB { get; set; }

        /// <summary>
        /// Gets or Sets serverPlan2xCPU2GB
        /// </summary>
        [DataMember(Name="server_plan_2xCPU-2GB", EmitDefaultValue=false)]
        public Price serverPlan2xCPU2GB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceZone {\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  firewall: ").Append(firewall).Append("\n");
            sb.Append("  ioRequestBackup: ").Append(ioRequestBackup).Append("\n");
            sb.Append("  ioRequestHdd: ").Append(ioRequestHdd).Append("\n");
            sb.Append("  ioRequestMaxiops: ").Append(ioRequestMaxiops).Append("\n");
            sb.Append("  ipv4Address: ").Append(ipv4Address).Append("\n");
            sb.Append("  ipv6Address: ").Append(ipv6Address).Append("\n");
            sb.Append("  publicIpv4BandwidthIn: ").Append(publicIpv4BandwidthIn).Append("\n");
            sb.Append("  publicIpv4BandwidthOut: ").Append(publicIpv4BandwidthOut).Append("\n");
            sb.Append("  publicIpv6BandwidthIn: ").Append(publicIpv6BandwidthIn).Append("\n");
            sb.Append("  publicIpv6BandwidthOut: ").Append(publicIpv6BandwidthOut).Append("\n");
            sb.Append("  serverCore: ").Append(serverCore).Append("\n");
            sb.Append("  serverMemory: ").Append(serverMemory).Append("\n");
            sb.Append("  storageBackup: ").Append(storageBackup).Append("\n");
            sb.Append("  storageHdd: ").Append(storageHdd).Append("\n");
            sb.Append("  storageMaxiops: ").Append(storageMaxiops).Append("\n");
            sb.Append("  serverPlan1xCPU1GB: ").Append(serverPlan1xCPU1GB).Append("\n");
            sb.Append("  serverPlan2xCPU2GB: ").Append(serverPlan2xCPU2GB).Append("\n");
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
            return this.Equals(input as PriceZone);
        }

        /// <summary>
        /// Returns true if PriceZone instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.firewall == input.firewall ||
                    (this.firewall != null &&
                    this.firewall.Equals(input.firewall))
                ) && 
                (
                    this.ioRequestBackup == input.ioRequestBackup ||
                    (this.ioRequestBackup != null &&
                    this.ioRequestBackup.Equals(input.ioRequestBackup))
                ) && 
                (
                    this.ioRequestHdd == input.ioRequestHdd ||
                    (this.ioRequestHdd != null &&
                    this.ioRequestHdd.Equals(input.ioRequestHdd))
                ) && 
                (
                    this.ioRequestMaxiops == input.ioRequestMaxiops ||
                    (this.ioRequestMaxiops != null &&
                    this.ioRequestMaxiops.Equals(input.ioRequestMaxiops))
                ) && 
                (
                    this.ipv4Address == input.ipv4Address ||
                    (this.ipv4Address != null &&
                    this.ipv4Address.Equals(input.ipv4Address))
                ) && 
                (
                    this.ipv6Address == input.ipv6Address ||
                    (this.ipv6Address != null &&
                    this.ipv6Address.Equals(input.ipv6Address))
                ) && 
                (
                    this.publicIpv4BandwidthIn == input.publicIpv4BandwidthIn ||
                    (this.publicIpv4BandwidthIn != null &&
                    this.publicIpv4BandwidthIn.Equals(input.publicIpv4BandwidthIn))
                ) && 
                (
                    this.publicIpv4BandwidthOut == input.publicIpv4BandwidthOut ||
                    (this.publicIpv4BandwidthOut != null &&
                    this.publicIpv4BandwidthOut.Equals(input.publicIpv4BandwidthOut))
                ) && 
                (
                    this.publicIpv6BandwidthIn == input.publicIpv6BandwidthIn ||
                    (this.publicIpv6BandwidthIn != null &&
                    this.publicIpv6BandwidthIn.Equals(input.publicIpv6BandwidthIn))
                ) && 
                (
                    this.publicIpv6BandwidthOut == input.publicIpv6BandwidthOut ||
                    (this.publicIpv6BandwidthOut != null &&
                    this.publicIpv6BandwidthOut.Equals(input.publicIpv6BandwidthOut))
                ) && 
                (
                    this.serverCore == input.serverCore ||
                    (this.serverCore != null &&
                    this.serverCore.Equals(input.serverCore))
                ) && 
                (
                    this.serverMemory == input.serverMemory ||
                    (this.serverMemory != null &&
                    this.serverMemory.Equals(input.serverMemory))
                ) && 
                (
                    this.storageBackup == input.storageBackup ||
                    (this.storageBackup != null &&
                    this.storageBackup.Equals(input.storageBackup))
                ) && 
                (
                    this.storageHdd == input.storageHdd ||
                    (this.storageHdd != null &&
                    this.storageHdd.Equals(input.storageHdd))
                ) && 
                (
                    this.storageMaxiops == input.storageMaxiops ||
                    (this.storageMaxiops != null &&
                    this.storageMaxiops.Equals(input.storageMaxiops))
                ) && 
                (
                    this.serverPlan1xCPU1GB == input.serverPlan1xCPU1GB ||
                    (this.serverPlan1xCPU1GB != null &&
                    this.serverPlan1xCPU1GB.Equals(input.serverPlan1xCPU1GB))
                ) && 
                (
                    this.serverPlan2xCPU2GB == input.serverPlan2xCPU2GB ||
                    (this.serverPlan2xCPU2GB != null &&
                    this.serverPlan2xCPU2GB.Equals(input.serverPlan2xCPU2GB))
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
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.firewall != null)
                    hashCode = hashCode * 59 + this.firewall.GetHashCode();
                if (this.ioRequestBackup != null)
                    hashCode = hashCode * 59 + this.ioRequestBackup.GetHashCode();
                if (this.ioRequestHdd != null)
                    hashCode = hashCode * 59 + this.ioRequestHdd.GetHashCode();
                if (this.ioRequestMaxiops != null)
                    hashCode = hashCode * 59 + this.ioRequestMaxiops.GetHashCode();
                if (this.ipv4Address != null)
                    hashCode = hashCode * 59 + this.ipv4Address.GetHashCode();
                if (this.ipv6Address != null)
                    hashCode = hashCode * 59 + this.ipv6Address.GetHashCode();
                if (this.publicIpv4BandwidthIn != null)
                    hashCode = hashCode * 59 + this.publicIpv4BandwidthIn.GetHashCode();
                if (this.publicIpv4BandwidthOut != null)
                    hashCode = hashCode * 59 + this.publicIpv4BandwidthOut.GetHashCode();
                if (this.publicIpv6BandwidthIn != null)
                    hashCode = hashCode * 59 + this.publicIpv6BandwidthIn.GetHashCode();
                if (this.publicIpv6BandwidthOut != null)
                    hashCode = hashCode * 59 + this.publicIpv6BandwidthOut.GetHashCode();
                if (this.serverCore != null)
                    hashCode = hashCode * 59 + this.serverCore.GetHashCode();
                if (this.serverMemory != null)
                    hashCode = hashCode * 59 + this.serverMemory.GetHashCode();
                if (this.storageBackup != null)
                    hashCode = hashCode * 59 + this.storageBackup.GetHashCode();
                if (this.storageHdd != null)
                    hashCode = hashCode * 59 + this.storageHdd.GetHashCode();
                if (this.storageMaxiops != null)
                    hashCode = hashCode * 59 + this.storageMaxiops.GetHashCode();
                if (this.serverPlan1xCPU1GB != null)
                    hashCode = hashCode * 59 + this.serverPlan1xCPU1GB.GetHashCode();
                if (this.serverPlan2xCPU2GB != null)
                    hashCode = hashCode * 59 + this.serverPlan2xCPU2GB.GetHashCode();
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
