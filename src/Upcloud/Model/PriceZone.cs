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
        /// <param name="Name">Name.</param>
        /// <param name="Firewall">Firewall.</param>
        /// <param name="IoRequestBackup">IoRequestBackup.</param>
        /// <param name="IoRequestHdd">IoRequestHdd.</param>
        /// <param name="IoRequestMaxiops">IoRequestMaxiops.</param>
        /// <param name="Ipv4Address">Ipv4Address.</param>
        /// <param name="Ipv6Address">Ipv6Address.</param>
        /// <param name="PublicIpv4BandwidthIn">PublicIpv4BandwidthIn.</param>
        /// <param name="PublicIpv4BandwidthOut">PublicIpv4BandwidthOut.</param>
        /// <param name="PublicIpv6BandwidthIn">PublicIpv6BandwidthIn.</param>
        /// <param name="PublicIpv6BandwidthOut">PublicIpv6BandwidthOut.</param>
        /// <param name="ServerCore">ServerCore.</param>
        /// <param name="ServerMemory">ServerMemory.</param>
        /// <param name="StorageBackup">StorageBackup.</param>
        /// <param name="StorageHdd">StorageHdd.</param>
        /// <param name="StorageMaxiops">StorageMaxiops.</param>
        /// <param name="ServerPlan1xCPU1GB">ServerPlan1xCPU1GB.</param>
        /// <param name="ServerPlan2xCPU2GB">ServerPlan2xCPU2GB.</param>
        public PriceZone(string Name = default(string), Price Firewall = default(Price), Price IoRequestBackup = default(Price), Price IoRequestHdd = default(Price), Price IoRequestMaxiops = default(Price), Price Ipv4Address = default(Price), Price Ipv6Address = default(Price), Price PublicIpv4BandwidthIn = default(Price), Price PublicIpv4BandwidthOut = default(Price), Price PublicIpv6BandwidthIn = default(Price), Price PublicIpv6BandwidthOut = default(Price), Price ServerCore = default(Price), Price ServerMemory = default(Price), Price StorageBackup = default(Price), Price StorageHdd = default(Price), Price StorageMaxiops = default(Price), Price ServerPlan1xCPU1GB = default(Price), Price ServerPlan2xCPU2GB = default(Price))
        {
            this.Name = Name;
            this.Firewall = Firewall;
            this.IoRequestBackup = IoRequestBackup;
            this.IoRequestHdd = IoRequestHdd;
            this.IoRequestMaxiops = IoRequestMaxiops;
            this.Ipv4Address = Ipv4Address;
            this.Ipv6Address = Ipv6Address;
            this.PublicIpv4BandwidthIn = PublicIpv4BandwidthIn;
            this.PublicIpv4BandwidthOut = PublicIpv4BandwidthOut;
            this.PublicIpv6BandwidthIn = PublicIpv6BandwidthIn;
            this.PublicIpv6BandwidthOut = PublicIpv6BandwidthOut;
            this.ServerCore = ServerCore;
            this.ServerMemory = ServerMemory;
            this.StorageBackup = StorageBackup;
            this.StorageHdd = StorageHdd;
            this.StorageMaxiops = StorageMaxiops;
            this.ServerPlan1xCPU1GB = ServerPlan1xCPU1GB;
            this.ServerPlan2xCPU2GB = ServerPlan2xCPU2GB;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Firewall
        /// </summary>
        [DataMember(Name="firewall", EmitDefaultValue=false)]
        public Price Firewall { get; set; }

        /// <summary>
        /// Gets or Sets IoRequestBackup
        /// </summary>
        [DataMember(Name="io_request_backup", EmitDefaultValue=false)]
        public Price IoRequestBackup { get; set; }

        /// <summary>
        /// Gets or Sets IoRequestHdd
        /// </summary>
        [DataMember(Name="io_request_hdd", EmitDefaultValue=false)]
        public Price IoRequestHdd { get; set; }

        /// <summary>
        /// Gets or Sets IoRequestMaxiops
        /// </summary>
        [DataMember(Name="io_request_maxiops", EmitDefaultValue=false)]
        public Price IoRequestMaxiops { get; set; }

        /// <summary>
        /// Gets or Sets Ipv4Address
        /// </summary>
        [DataMember(Name="ipv4_address", EmitDefaultValue=false)]
        public Price Ipv4Address { get; set; }

        /// <summary>
        /// Gets or Sets Ipv6Address
        /// </summary>
        [DataMember(Name="ipv6_address", EmitDefaultValue=false)]
        public Price Ipv6Address { get; set; }

        /// <summary>
        /// Gets or Sets PublicIpv4BandwidthIn
        /// </summary>
        [DataMember(Name="public_ipv4_bandwidth_in", EmitDefaultValue=false)]
        public Price PublicIpv4BandwidthIn { get; set; }

        /// <summary>
        /// Gets or Sets PublicIpv4BandwidthOut
        /// </summary>
        [DataMember(Name="public_ipv4_bandwidth_out", EmitDefaultValue=false)]
        public Price PublicIpv4BandwidthOut { get; set; }

        /// <summary>
        /// Gets or Sets PublicIpv6BandwidthIn
        /// </summary>
        [DataMember(Name="public_ipv6_bandwidth_in", EmitDefaultValue=false)]
        public Price PublicIpv6BandwidthIn { get; set; }

        /// <summary>
        /// Gets or Sets PublicIpv6BandwidthOut
        /// </summary>
        [DataMember(Name="public_ipv6_bandwidth_out", EmitDefaultValue=false)]
        public Price PublicIpv6BandwidthOut { get; set; }

        /// <summary>
        /// Gets or Sets ServerCore
        /// </summary>
        [DataMember(Name="server_core", EmitDefaultValue=false)]
        public Price ServerCore { get; set; }

        /// <summary>
        /// Gets or Sets ServerMemory
        /// </summary>
        [DataMember(Name="server_memory", EmitDefaultValue=false)]
        public Price ServerMemory { get; set; }

        /// <summary>
        /// Gets or Sets StorageBackup
        /// </summary>
        [DataMember(Name="storage_backup", EmitDefaultValue=false)]
        public Price StorageBackup { get; set; }

        /// <summary>
        /// Gets or Sets StorageHdd
        /// </summary>
        [DataMember(Name="storage_hdd", EmitDefaultValue=false)]
        public Price StorageHdd { get; set; }

        /// <summary>
        /// Gets or Sets StorageMaxiops
        /// </summary>
        [DataMember(Name="storage_maxiops", EmitDefaultValue=false)]
        public Price StorageMaxiops { get; set; }

        /// <summary>
        /// Gets or Sets ServerPlan1xCPU1GB
        /// </summary>
        [DataMember(Name="server_plan_1xCPU-1GB", EmitDefaultValue=false)]
        public Price ServerPlan1xCPU1GB { get; set; }

        /// <summary>
        /// Gets or Sets ServerPlan2xCPU2GB
        /// </summary>
        [DataMember(Name="server_plan_2xCPU-2GB", EmitDefaultValue=false)]
        public Price ServerPlan2xCPU2GB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceZone {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Firewall: ").Append(Firewall).Append("\n");
            sb.Append("  IoRequestBackup: ").Append(IoRequestBackup).Append("\n");
            sb.Append("  IoRequestHdd: ").Append(IoRequestHdd).Append("\n");
            sb.Append("  IoRequestMaxiops: ").Append(IoRequestMaxiops).Append("\n");
            sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
            sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  PublicIpv4BandwidthIn: ").Append(PublicIpv4BandwidthIn).Append("\n");
            sb.Append("  PublicIpv4BandwidthOut: ").Append(PublicIpv4BandwidthOut).Append("\n");
            sb.Append("  PublicIpv6BandwidthIn: ").Append(PublicIpv6BandwidthIn).Append("\n");
            sb.Append("  PublicIpv6BandwidthOut: ").Append(PublicIpv6BandwidthOut).Append("\n");
            sb.Append("  ServerCore: ").Append(ServerCore).Append("\n");
            sb.Append("  ServerMemory: ").Append(ServerMemory).Append("\n");
            sb.Append("  StorageBackup: ").Append(StorageBackup).Append("\n");
            sb.Append("  StorageHdd: ").Append(StorageHdd).Append("\n");
            sb.Append("  StorageMaxiops: ").Append(StorageMaxiops).Append("\n");
            sb.Append("  ServerPlan1xCPU1GB: ").Append(ServerPlan1xCPU1GB).Append("\n");
            sb.Append("  ServerPlan2xCPU2GB: ").Append(ServerPlan2xCPU2GB).Append("\n");
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Firewall == input.Firewall ||
                    (this.Firewall != null &&
                    this.Firewall.Equals(input.Firewall))
                ) && 
                (
                    this.IoRequestBackup == input.IoRequestBackup ||
                    (this.IoRequestBackup != null &&
                    this.IoRequestBackup.Equals(input.IoRequestBackup))
                ) && 
                (
                    this.IoRequestHdd == input.IoRequestHdd ||
                    (this.IoRequestHdd != null &&
                    this.IoRequestHdd.Equals(input.IoRequestHdd))
                ) && 
                (
                    this.IoRequestMaxiops == input.IoRequestMaxiops ||
                    (this.IoRequestMaxiops != null &&
                    this.IoRequestMaxiops.Equals(input.IoRequestMaxiops))
                ) && 
                (
                    this.Ipv4Address == input.Ipv4Address ||
                    (this.Ipv4Address != null &&
                    this.Ipv4Address.Equals(input.Ipv4Address))
                ) && 
                (
                    this.Ipv6Address == input.Ipv6Address ||
                    (this.Ipv6Address != null &&
                    this.Ipv6Address.Equals(input.Ipv6Address))
                ) && 
                (
                    this.PublicIpv4BandwidthIn == input.PublicIpv4BandwidthIn ||
                    (this.PublicIpv4BandwidthIn != null &&
                    this.PublicIpv4BandwidthIn.Equals(input.PublicIpv4BandwidthIn))
                ) && 
                (
                    this.PublicIpv4BandwidthOut == input.PublicIpv4BandwidthOut ||
                    (this.PublicIpv4BandwidthOut != null &&
                    this.PublicIpv4BandwidthOut.Equals(input.PublicIpv4BandwidthOut))
                ) && 
                (
                    this.PublicIpv6BandwidthIn == input.PublicIpv6BandwidthIn ||
                    (this.PublicIpv6BandwidthIn != null &&
                    this.PublicIpv6BandwidthIn.Equals(input.PublicIpv6BandwidthIn))
                ) && 
                (
                    this.PublicIpv6BandwidthOut == input.PublicIpv6BandwidthOut ||
                    (this.PublicIpv6BandwidthOut != null &&
                    this.PublicIpv6BandwidthOut.Equals(input.PublicIpv6BandwidthOut))
                ) && 
                (
                    this.ServerCore == input.ServerCore ||
                    (this.ServerCore != null &&
                    this.ServerCore.Equals(input.ServerCore))
                ) && 
                (
                    this.ServerMemory == input.ServerMemory ||
                    (this.ServerMemory != null &&
                    this.ServerMemory.Equals(input.ServerMemory))
                ) && 
                (
                    this.StorageBackup == input.StorageBackup ||
                    (this.StorageBackup != null &&
                    this.StorageBackup.Equals(input.StorageBackup))
                ) && 
                (
                    this.StorageHdd == input.StorageHdd ||
                    (this.StorageHdd != null &&
                    this.StorageHdd.Equals(input.StorageHdd))
                ) && 
                (
                    this.StorageMaxiops == input.StorageMaxiops ||
                    (this.StorageMaxiops != null &&
                    this.StorageMaxiops.Equals(input.StorageMaxiops))
                ) && 
                (
                    this.ServerPlan1xCPU1GB == input.ServerPlan1xCPU1GB ||
                    (this.ServerPlan1xCPU1GB != null &&
                    this.ServerPlan1xCPU1GB.Equals(input.ServerPlan1xCPU1GB))
                ) && 
                (
                    this.ServerPlan2xCPU2GB == input.ServerPlan2xCPU2GB ||
                    (this.ServerPlan2xCPU2GB != null &&
                    this.ServerPlan2xCPU2GB.Equals(input.ServerPlan2xCPU2GB))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Firewall != null)
                    hashCode = hashCode * 59 + this.Firewall.GetHashCode();
                if (this.IoRequestBackup != null)
                    hashCode = hashCode * 59 + this.IoRequestBackup.GetHashCode();
                if (this.IoRequestHdd != null)
                    hashCode = hashCode * 59 + this.IoRequestHdd.GetHashCode();
                if (this.IoRequestMaxiops != null)
                    hashCode = hashCode * 59 + this.IoRequestMaxiops.GetHashCode();
                if (this.Ipv4Address != null)
                    hashCode = hashCode * 59 + this.Ipv4Address.GetHashCode();
                if (this.Ipv6Address != null)
                    hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.PublicIpv4BandwidthIn != null)
                    hashCode = hashCode * 59 + this.PublicIpv4BandwidthIn.GetHashCode();
                if (this.PublicIpv4BandwidthOut != null)
                    hashCode = hashCode * 59 + this.PublicIpv4BandwidthOut.GetHashCode();
                if (this.PublicIpv6BandwidthIn != null)
                    hashCode = hashCode * 59 + this.PublicIpv6BandwidthIn.GetHashCode();
                if (this.PublicIpv6BandwidthOut != null)
                    hashCode = hashCode * 59 + this.PublicIpv6BandwidthOut.GetHashCode();
                if (this.ServerCore != null)
                    hashCode = hashCode * 59 + this.ServerCore.GetHashCode();
                if (this.ServerMemory != null)
                    hashCode = hashCode * 59 + this.ServerMemory.GetHashCode();
                if (this.StorageBackup != null)
                    hashCode = hashCode * 59 + this.StorageBackup.GetHashCode();
                if (this.StorageHdd != null)
                    hashCode = hashCode * 59 + this.StorageHdd.GetHashCode();
                if (this.StorageMaxiops != null)
                    hashCode = hashCode * 59 + this.StorageMaxiops.GetHashCode();
                if (this.ServerPlan1xCPU1GB != null)
                    hashCode = hashCode * 59 + this.ServerPlan1xCPU1GB.GetHashCode();
                if (this.ServerPlan2xCPU2GB != null)
                    hashCode = hashCode * 59 + this.ServerPlan2xCPU2GB.GetHashCode();
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
