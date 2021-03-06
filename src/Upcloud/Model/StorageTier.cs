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
    /// Storage resources are divided into two tiers: * &#x60;hdd&#x60; (*HDD storages*) - Data is stored on hard disks resulting in lower costs than MaxIOPS. * &#x60;maxiops&#x60; (*MaxIOPS storages*) - Data is stored on MaxIOPS storage arrays resulting in highest throughput and lowest response times.  Storage tiers affect both the performance and price of the storage.
    /// </summary>
    /// <value>Storage resources are divided into two tiers: * &#x60;hdd&#x60; (*HDD storages*) - Data is stored on hard disks resulting in lower costs than MaxIOPS. * &#x60;maxiops&#x60; (*MaxIOPS storages*) - Data is stored on MaxIOPS storage arrays resulting in highest throughput and lowest response times.  Storage tiers affect both the performance and price of the storage.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageTier
    {
        
        /// <summary>
        /// Enum Hdd for "hdd"
        /// </summary>
        [EnumMember(Value = "hdd")]
        Hdd,
        
        /// <summary>
        /// Enum Maxiops for "maxiops"
        /// </summary>
        [EnumMember(Value = "maxiops")]
        Maxiops
    }

}
