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
    /// Storage access types. * &#x60;public&#x60; (*Public storages*) are visible to all users. Public storages include CD-ROM images and templates. CD-ROM images can be used to install operating systems and to rescue unbootable systems. Templates are used to create servers with a preconfigured operating system. * &#x60;private&#x60; (*Private storages*) - visible only to the specific user account and sub-accounts. Users can only create private storages.
    /// </summary>
    /// <value>Storage access types. * &#x60;public&#x60; (*Public storages*) are visible to all users. Public storages include CD-ROM images and templates. CD-ROM images can be used to install operating systems and to rescue unbootable systems. Templates are used to create servers with a preconfigured operating system. * &#x60;private&#x60; (*Private storages*) - visible only to the specific user account and sub-accounts. Users can only create private storages.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageAccessType
    {
        
        /// <summary>
        /// Enum Public for "public"
        /// </summary>
        [EnumMember(Value = "public")]
        Public,
        
        /// <summary>
        /// Enum Private for "private"
        /// </summary>
        [EnumMember(Value = "private")]
        Private
    }

}
