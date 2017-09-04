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
    /// Defines AddressFamily
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressFamily
    {
        
        /// <summary>
        /// Enum IPv4 for "IPv4"
        /// </summary>
        [EnumMember(Value = "IPv4")]
        IPv4,
        
        /// <summary>
        /// Enum IPv6 for "IPv6"
        /// </summary>
        [EnumMember(Value = "IPv6")]
        IPv6
    }

}
