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
    /// There are four different storage types: * &#x60;disk&#x60; (*Normal storages*) - Normal storage resources are used to store operating system and application data. This is the only user writeable storage type. * &#x60;cdrom&#x60; (*CD-ROMs*) - CD-ROM resources are used as a read-only media, typically for server installations or crash recovery. * &#x60;template&#x60; (*Templates*) - Templates are special storage resources which are used to create new servers with a preconfigured operating system. * &#x60;backup&#x60; (*Backups*) - Backups are storages containing a point-in-time backup of a normal storage. Data on a normal storage can be restored from one of its backups. Backups can also be cloned to create a new normal storage resource. Backups can be created manually or automatically using backup rules.
    /// </summary>
    /// <value>There are four different storage types: * &#x60;disk&#x60; (*Normal storages*) - Normal storage resources are used to store operating system and application data. This is the only user writeable storage type. * &#x60;cdrom&#x60; (*CD-ROMs*) - CD-ROM resources are used as a read-only media, typically for server installations or crash recovery. * &#x60;template&#x60; (*Templates*) - Templates are special storage resources which are used to create new servers with a preconfigured operating system. * &#x60;backup&#x60; (*Backups*) - Backups are storages containing a point-in-time backup of a normal storage. Data on a normal storage can be restored from one of its backups. Backups can also be cloned to create a new normal storage resource. Backups can be created manually or automatically using backup rules.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageType
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
        /// Enum Template for "template"
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        
        /// <summary>
        /// Enum Backup for "backup"
        /// </summary>
        [EnumMember(Value = "backup")]
        Backup,
        
        /// <summary>
        /// Enum Normal for "normal"
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal
    }

}
