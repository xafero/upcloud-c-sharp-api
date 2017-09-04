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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The server state indicates the server&#39;s current status.
    /// </summary>
    /// <value>The server state indicates the server&#39;s current status.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServerState
    {
        
        /// <summary>
        /// Enum Started for "started"
        /// </summary>
        [EnumMember(Value = "started")]
        Started,
        
        /// <summary>
        /// Enum Stopped for "stopped"
        /// </summary>
        [EnumMember(Value = "stopped")]
        Stopped,
        
        /// <summary>
        /// Enum Maintenance for "maintenance"
        /// </summary>
        [EnumMember(Value = "maintenance")]
        Maintenance,
        
        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error
    }

}
