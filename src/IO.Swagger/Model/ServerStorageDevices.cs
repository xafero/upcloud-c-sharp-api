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
    /// ServerStorageDevices
    /// </summary>
    [DataContract]
    public partial class ServerStorageDevices :  IEquatable<ServerStorageDevices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStorageDevices" /> class.
        /// </summary>
        /// <param name="StorageDevice">StorageDevice.</param>
        public ServerStorageDevices(List<StorageDevice> StorageDevice = default(List<StorageDevice>))
        {
            this.StorageDevice = StorageDevice;
        }
        
        /// <summary>
        /// Gets or Sets StorageDevice
        /// </summary>
        [DataMember(Name="storage_device", EmitDefaultValue=false)]
        public List<StorageDevice> StorageDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerStorageDevices {\n");
            sb.Append("  StorageDevice: ").Append(StorageDevice).Append("\n");
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
            return this.Equals(input as ServerStorageDevices);
        }

        /// <summary>
        /// Returns true if ServerStorageDevices instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerStorageDevices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerStorageDevices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageDevice == input.StorageDevice ||
                    (this.StorageDevice != null &&
                    this.StorageDevice.SequenceEqual(input.StorageDevice))
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
                if (this.StorageDevice != null)
                    hashCode = hashCode * 59 + this.StorageDevice.GetHashCode();
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