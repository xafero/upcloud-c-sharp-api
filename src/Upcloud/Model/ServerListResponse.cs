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
    /// ServerListResponse
    /// </summary>
    [DataContract]
    public partial class ServerListResponse :  IEquatable<ServerListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerListResponse" /> class.
        /// </summary>
        /// <param name="servers">servers.</param>
        public ServerListResponse(ServerListResponseServers servers = default(ServerListResponseServers))
        {
            this.servers = servers;
        }
        
        /// <summary>
        /// Gets or Sets servers
        /// </summary>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public ServerListResponseServers servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerListResponse {\n");
            sb.Append("  servers: ").Append(servers).Append("\n");
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
            return this.Equals(input as ServerListResponse);
        }

        /// <summary>
        /// Returns true if ServerListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.servers == input.servers ||
                    (this.servers != null &&
                    this.servers.Equals(input.servers))
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
                if (this.servers != null)
                    hashCode = hashCode * 59 + this.servers.GetHashCode();
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
