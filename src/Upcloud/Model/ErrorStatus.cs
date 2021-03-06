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
    /// Defines ErrorStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorStatus
    {
        
        /// <summary>
        /// Enum _400 for "400"
        /// </summary>
        [EnumMember(Value = "400")]
        _400,
        
        /// <summary>
        /// Enum _402 for "402"
        /// </summary>
        [EnumMember(Value = "402")]
        _402,
        
        /// <summary>
        /// Enum _403 for "403"
        /// </summary>
        [EnumMember(Value = "403")]
        _403,
        
        /// <summary>
        /// Enum _404 for "404"
        /// </summary>
        [EnumMember(Value = "404")]
        _404,
        
        /// <summary>
        /// Enum _409 for "409"
        /// </summary>
        [EnumMember(Value = "409")]
        _409
    }

}
