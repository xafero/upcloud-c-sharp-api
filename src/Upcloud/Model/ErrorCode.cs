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
    /// Defines ErrorCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorCode
    {
        
        /// <summary>
        /// Enum ACTIONINVALID for "ACTION_INVALID"
        /// </summary>
        [EnumMember(Value = "ACTION_INVALID")]
        ACTIONINVALID,
        
        /// <summary>
        /// Enum ACTIONMISSING for "ACTION_MISSING"
        /// </summary>
        [EnumMember(Value = "ACTION_MISSING")]
        ACTIONMISSING,
        
        /// <summary>
        /// Enum BOOTORDERINVALID for "BOOT_ORDER_INVALID"
        /// </summary>
        [EnumMember(Value = "BOOT_ORDER_INVALID")]
        BOOTORDERINVALID,
        
        /// <summary>
        /// Enum COREMEMORYUNSUPPORTED for "CORE_MEMORY_UNSUPPORTED"
        /// </summary>
        [EnumMember(Value = "CORE_MEMORY_UNSUPPORTED")]
        COREMEMORYUNSUPPORTED,
        
        /// <summary>
        /// Enum FIREWALLINVALID for "FIREWALL_INVALID"
        /// </summary>
        [EnumMember(Value = "FIREWALL_INVALID")]
        FIREWALLINVALID,
        
        /// <summary>
        /// Enum CORENUMBERINVALID for "CORE_NUMBER_INVALID"
        /// </summary>
        [EnumMember(Value = "CORE_NUMBER_INVALID")]
        CORENUMBERINVALID,
        
        /// <summary>
        /// Enum HOSTNAMEINVALID for "HOSTNAME_INVALID"
        /// </summary>
        [EnumMember(Value = "HOSTNAME_INVALID")]
        HOSTNAMEINVALID,
        
        /// <summary>
        /// Enum HOSTNAMEMISSING for "HOSTNAME_MISSING"
        /// </summary>
        [EnumMember(Value = "HOSTNAME_MISSING")]
        HOSTNAMEMISSING,
        
        /// <summary>
        /// Enum MEMORYAMOUNTINVALID for "MEMORY_AMOUNT_INVALID"
        /// </summary>
        [EnumMember(Value = "MEMORY_AMOUNT_INVALID")]
        MEMORYAMOUNTINVALID,
        
        /// <summary>
        /// Enum NICMODELINVALID for "NIC_MODEL_INVALID"
        /// </summary>
        [EnumMember(Value = "NIC_MODEL_INVALID")]
        NICMODELINVALID,
        
        /// <summary>
        /// Enum PASSWORDDELIVERYINVALID for "PASSWORD_DELIVERY_INVALID"
        /// </summary>
        [EnumMember(Value = "PASSWORD_DELIVERY_INVALID")]
        PASSWORDDELIVERYINVALID,
        
        /// <summary>
        /// Enum SERVERTITLEINVALID for "SERVER_TITLE_INVALID"
        /// </summary>
        [EnumMember(Value = "SERVER_TITLE_INVALID")]
        SERVERTITLEINVALID,
        
        /// <summary>
        /// Enum SERVERTITLEMISSING for "SERVER_TITLE_MISSING"
        /// </summary>
        [EnumMember(Value = "SERVER_TITLE_MISSING")]
        SERVERTITLEMISSING,
        
        /// <summary>
        /// Enum SIZEINVALID for "SIZE_INVALID"
        /// </summary>
        [EnumMember(Value = "SIZE_INVALID")]
        SIZEINVALID,
        
        /// <summary>
        /// Enum SIZEMISSING for "SIZE_MISSING"
        /// </summary>
        [EnumMember(Value = "SIZE_MISSING")]
        SIZEMISSING,
        
        /// <summary>
        /// Enum STORAGEDEVICEINVALID for "STORAGE_DEVICE_INVALID"
        /// </summary>
        [EnumMember(Value = "STORAGE_DEVICE_INVALID")]
        STORAGEDEVICEINVALID,
        
        /// <summary>
        /// Enum STORAGEDEVICEMISSING for "STORAGE_DEVICE_MISSING"
        /// </summary>
        [EnumMember(Value = "STORAGE_DEVICE_MISSING")]
        STORAGEDEVICEMISSING,
        
        /// <summary>
        /// Enum STORAGEDEVICESINVALID for "STORAGE_DEVICES_INVALID"
        /// </summary>
        [EnumMember(Value = "STORAGE_DEVICES_INVALID")]
        STORAGEDEVICESINVALID,
        
        /// <summary>
        /// Enum STORAGEDEVICESMISSING for "STORAGE_DEVICES_MISSING"
        /// </summary>
        [EnumMember(Value = "STORAGE_DEVICES_MISSING")]
        STORAGEDEVICESMISSING,
        
        /// <summary>
        /// Enum STORAGEINVALID for "STORAGE_INVALID"
        /// </summary>
        [EnumMember(Value = "STORAGE_INVALID")]
        STORAGEINVALID,
        
        /// <summary>
        /// Enum STORAGEMISSING for "STORAGE_MISSING"
        /// </summary>
        [EnumMember(Value = "STORAGE_MISSING")]
        STORAGEMISSING,
        
        /// <summary>
        /// Enum STORAGETITLEINVALID for "STORAGE_TITLE_INVALID"
        /// </summary>
        [EnumMember(Value = "STORAGE_TITLE_INVALID")]
        STORAGETITLEINVALID,
        
        /// <summary>
        /// Enum STORAGETITLEMISSING for "STORAGE_TITLE_MISSING"
        /// </summary>
        [EnumMember(Value = "STORAGE_TITLE_MISSING")]
        STORAGETITLEMISSING,
        
        /// <summary>
        /// Enum TIMEZONEINVALID for "TIMEZONE_INVALID"
        /// </summary>
        [EnumMember(Value = "TIMEZONE_INVALID")]
        TIMEZONEINVALID,
        
        /// <summary>
        /// Enum TYPEINVALID for "TYPE_INVALID"
        /// </summary>
        [EnumMember(Value = "TYPE_INVALID")]
        TYPEINVALID,
        
        /// <summary>
        /// Enum TIERINVALID for "TIER_INVALID"
        /// </summary>
        [EnumMember(Value = "TIER_INVALID")]
        TIERINVALID,
        
        /// <summary>
        /// Enum VIDEOMODELINVALID for "VIDEO_MODEL_INVALID"
        /// </summary>
        [EnumMember(Value = "VIDEO_MODEL_INVALID")]
        VIDEOMODELINVALID,
        
        /// <summary>
        /// Enum VNCINVALID for "VNC_INVALID"
        /// </summary>
        [EnumMember(Value = "VNC_INVALID")]
        VNCINVALID,
        
        /// <summary>
        /// Enum VNCPASSWORDINVALID for "VNC_PASSWORD_INVALID"
        /// </summary>
        [EnumMember(Value = "VNC_PASSWORD_INVALID")]
        VNCPASSWORDINVALID,
        
        /// <summary>
        /// Enum ZONEINVALID for "ZONE_INVALID"
        /// </summary>
        [EnumMember(Value = "ZONE_INVALID")]
        ZONEINVALID,
        
        /// <summary>
        /// Enum ZONEMISSING for "ZONE_MISSING"
        /// </summary>
        [EnumMember(Value = "ZONE_MISSING")]
        ZONEMISSING,
        
        /// <summary>
        /// Enum USERDATAINVALID for "USER_DATA_INVALID"
        /// </summary>
        [EnumMember(Value = "USER_DATA_INVALID")]
        USERDATAINVALID,
        
        /// <summary>
        /// Enum INSUFFICIENTCREDITS for "INSUFFICIENT_CREDITS"
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_CREDITS")]
        INSUFFICIENTCREDITS,
        
        /// <summary>
        /// Enum STORAGEFORBIDDEN for "STORAGE_FORBIDDEN"
        /// </summary>
        [EnumMember(Value = "STORAGE_FORBIDDEN")]
        STORAGEFORBIDDEN,
        
        /// <summary>
        /// Enum PLANCORENUMBERILLEGAL for "PLAN_CORE_NUMBER_ILLEGAL"
        /// </summary>
        [EnumMember(Value = "PLAN_CORE_NUMBER_ILLEGAL")]
        PLANCORENUMBERILLEGAL,
        
        /// <summary>
        /// Enum PLANMEMORYAMOUNTILLEGAL for "PLAN_MEMORY_AMOUNT_ILLEGAL"
        /// </summary>
        [EnumMember(Value = "PLAN_MEMORY_AMOUNT_ILLEGAL")]
        PLANMEMORYAMOUNTILLEGAL,
        
        /// <summary>
        /// Enum TRIALPLAN for "TRIAL_PLAN"
        /// </summary>
        [EnumMember(Value = "TRIAL_PLAN")]
        TRIALPLAN,
        
        /// <summary>
        /// Enum STORAGENOTFOUND for "STORAGE_NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "STORAGE_NOT_FOUND")]
        STORAGENOTFOUND,
        
        /// <summary>
        /// Enum ZONENOTFOUND for "ZONE_NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "ZONE_NOT_FOUND")]
        ZONENOTFOUND,
        
        /// <summary>
        /// Enum CDROMDEVICEINUSE for "CDROM_DEVICE_IN_USE"
        /// </summary>
        [EnumMember(Value = "CDROM_DEVICE_IN_USE")]
        CDROMDEVICEINUSE,
        
        /// <summary>
        /// Enum DEVICEADDRESSINUSE for "DEVICE_ADDRESS_IN_USE"
        /// </summary>
        [EnumMember(Value = "DEVICE_ADDRESS_IN_USE")]
        DEVICEADDRESSINUSE,
        
        /// <summary>
        /// Enum IPADDRESSRESOURCESUNAVAILABLE for "IP_ADDRESS_RESOURCES_UNAVAILABLE"
        /// </summary>
        [EnumMember(Value = "IP_ADDRESS_RESOURCES_UNAVAILABLE")]
        IPADDRESSRESOURCESUNAVAILABLE,
        
        /// <summary>
        /// Enum MULTIPLETEMPLATES for "MULTIPLE_TEMPLATES"
        /// </summary>
        [EnumMember(Value = "MULTIPLE_TEMPLATES")]
        MULTIPLETEMPLATES,
        
        /// <summary>
        /// Enum PUBLICSTORAGEATTACH for "PUBLIC_STORAGE_ATTACH"
        /// </summary>
        [EnumMember(Value = "PUBLIC_STORAGE_ATTACH")]
        PUBLICSTORAGEATTACH,
        
        /// <summary>
        /// Enum SERVERRESOURCESUNAVAILABLE for "SERVER_RESOURCES_UNAVAILABLE"
        /// </summary>
        [EnumMember(Value = "SERVER_RESOURCES_UNAVAILABLE")]
        SERVERRESOURCESUNAVAILABLE,
        
        /// <summary>
        /// Enum STORAGEATTACHEDASCDROM for "STORAGE_ATTACHED_AS_CDROM"
        /// </summary>
        [EnumMember(Value = "STORAGE_ATTACHED_AS_CDROM")]
        STORAGEATTACHEDASCDROM,
        
        /// <summary>
        /// Enum STORAGEATTACHEDASDISK for "STORAGE_ATTACHED_AS_DISK"
        /// </summary>
        [EnumMember(Value = "STORAGE_ATTACHED_AS_DISK")]
        STORAGEATTACHEDASDISK,
        
        /// <summary>
        /// Enum STORAGEDEVICELIMITREACHED for "STORAGE_DEVICE_LIMIT_REACHED"
        /// </summary>
        [EnumMember(Value = "STORAGE_DEVICE_LIMIT_REACHED")]
        STORAGEDEVICELIMITREACHED,
        
        /// <summary>
        /// Enum STORAGEINUSE for "STORAGE_IN_USE"
        /// </summary>
        [EnumMember(Value = "STORAGE_IN_USE")]
        STORAGEINUSE,
        
        /// <summary>
        /// Enum STORAGERESOURCESUNAVAILABLE for "STORAGE_RESOURCES_UNAVAILABLE"
        /// </summary>
        [EnumMember(Value = "STORAGE_RESOURCES_UNAVAILABLE")]
        STORAGERESOURCESUNAVAILABLE,
        
        /// <summary>
        /// Enum STORAGESTATEILLEGAL for "STORAGE_STATE_ILLEGAL"
        /// </summary>
        [EnumMember(Value = "STORAGE_STATE_ILLEGAL")]
        STORAGESTATEILLEGAL,
        
        /// <summary>
        /// Enum STORAGETYPEILLEGAL for "STORAGE_TYPE_ILLEGAL"
        /// </summary>
        [EnumMember(Value = "STORAGE_TYPE_ILLEGAL")]
        STORAGETYPEILLEGAL,
        
        /// <summary>
        /// Enum ZONEMISMATCH for "ZONE_MISMATCH"
        /// </summary>
        [EnumMember(Value = "ZONE_MISMATCH")]
        ZONEMISMATCH,
        
        /// <summary>
        /// Enum INVALIDUSERNAME for "INVALID_USERNAME"
        /// </summary>
        [EnumMember(Value = "INVALID_USERNAME")]
        INVALIDUSERNAME
    }

}
