# Upcloud.Api.ServerApi

All URIs are relative to *https://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignTag**](ServerApi.md#assigntag) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
[**AttachStorage**](ServerApi.md#attachstorage) | **POST** /server/{serverId}/storage/attach | Attach storage
[**CreateFirewallRule**](ServerApi.md#createfirewallrule) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
[**CreateServer**](ServerApi.md#createserver) | **POST** /server | Create server
[**DeleteFirewallRule**](ServerApi.md#deletefirewallrule) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
[**DeleteServer**](ServerApi.md#deleteserver) | **DELETE** /server/{serverId} | Delete server
[**DetachStorage**](ServerApi.md#detachstorage) | **POST** /server/{serverId}/storage/detach | Detach storage
[**EjectCdrom**](ServerApi.md#ejectcdrom) | **POST** /server/{serverId}/cdrom/eject | Eject CD-ROM
[**GetFirewallRule**](ServerApi.md#getfirewallrule) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
[**ListServerConfigurations**](ServerApi.md#listserverconfigurations) | **GET** /server_size | List server configurations
[**ListServers**](ServerApi.md#listservers) | **GET** /server | List of servers
[**LoadCdrom**](ServerApi.md#loadcdrom) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
[**ModifyServer**](ServerApi.md#modifyserver) | **PUT** /server/{serverId} | Modify server
[**RestartServer**](ServerApi.md#restartserver) | **POST** /server/{serverId}/restart | Restart server
[**ServerDetails**](ServerApi.md#serverdetails) | **GET** /server/{serverId} | Get server details
[**ServerServerIdFirewallRuleGet**](ServerApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
[**StartServer**](ServerApi.md#startserver) | **POST** /server/{serverId}/start | Start server
[**StopServer**](ServerApi.md#stopserver) | **POST** /server/{serverId}/stop | Stop server
[**Untag**](ServerApi.md#untag) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server


<a name="assigntag"></a>
# **AssignTag**
> CreateServerResponse AssignTag (Guid? serverId, string tagList)

Assign tag to a server

Servers can be tagged with one or more tags. The tags used must exist

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class AssignTagExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagList = tagList_example;  // string | List of tags

            try
            {
                // Assign tag to a server
                CreateServerResponse result = apiInstance.AssignTag(serverId, tagList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.AssignTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **tagList** | **string**| List of tags | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachstorage"></a>
# **AttachStorage**
> CreateServerResponse AttachStorage (Guid? serverId, AttachStorageDeviceRequest storageDevice)

Attach storage

Attaches a storage as a device to a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class AttachStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new AttachStorageDeviceRequest(); // AttachStorageDeviceRequest | 

            try
            {
                // Attach storage
                CreateServerResponse result = apiInstance.AttachStorage(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.AttachStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**AttachStorageDeviceRequest**](AttachStorageDeviceRequest.md)|  | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfirewallrule"></a>
# **CreateFirewallRule**
> FirewallRuleCreateResponse CreateFirewallRule (Guid? serverId, FirewallRuleRequest firewallRule)

Create firewall rule

Creates a new firewall rule

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class CreateFirewallRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRule = new FirewallRuleRequest(); // FirewallRuleRequest | 

            try
            {
                // Create firewall rule
                FirewallRuleCreateResponse result = apiInstance.CreateFirewallRule(serverId, firewallRule);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.CreateFirewallRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRule** | [**FirewallRuleRequest**](FirewallRuleRequest.md)|  | 

### Return type

[**FirewallRuleCreateResponse**](FirewallRuleCreateResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createserver"></a>
# **CreateServer**
> CreateServerResponse CreateServer (CreateServerRequest server = null)

Create server

Creates a new server instance.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class CreateServerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var server = new CreateServerRequest(); // CreateServerRequest |  (optional) 

            try
            {
                // Create server
                CreateServerResponse result = apiInstance.CreateServer(server);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.CreateServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **server** | [**CreateServerRequest**](CreateServerRequest.md)|  | [optional] 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefirewallrule"></a>
# **DeleteFirewallRule**
> void DeleteFirewallRule (Guid? serverId, decimal? firewallRuleNumber)

Remove firewall rule

Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DeleteFirewallRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = 3.4;  // decimal? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Remove firewall rule
                apiInstance.DeleteFirewallRule(serverId, firewallRuleNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.DeleteFirewallRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRuleNumber** | **decimal?**| Denotes the index of the firewall rule in the server&#39;s firewall rule list | 

### Return type

void (empty response body)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserver"></a>
# **DeleteServer**
> void DeleteServer (Guid? serverId)

Delete server

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DeleteServerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to delete

            try
            {
                // Delete server
                apiInstance.DeleteServer(serverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.DeleteServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to delete | 

### Return type

void (empty response body)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachstorage"></a>
# **DetachStorage**
> CreateServerResponse DetachStorage (Guid? serverId, StorageDeviceDetachRequest storageDevice)

Detach storage

Detaches a storage resource from a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DetachStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDeviceDetachRequest(); // StorageDeviceDetachRequest | 

            try
            {
                // Detach storage
                CreateServerResponse result = apiInstance.DetachStorage(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.DetachStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDeviceDetachRequest**](StorageDeviceDetachRequest.md)|  | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ejectcdrom"></a>
# **EjectCdrom**
> void EjectCdrom (Guid? serverId)

Eject CD-ROM

Ejects the storage from the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class EjectCdromExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // Eject CD-ROM
                apiInstance.EjectCdrom(serverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.EjectCdrom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 

### Return type

void (empty response body)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirewallrule"></a>
# **GetFirewallRule**
> FirewallRuleCreateResponse GetFirewallRule (Guid? serverId, decimal? firewallRuleNumber)

Get firewall rule details

Returns detailed information about a specific firewall rule

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class GetFirewallRuleExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = 3.4;  // decimal? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Get firewall rule details
                FirewallRuleCreateResponse result = apiInstance.GetFirewallRule(serverId, firewallRuleNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.GetFirewallRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRuleNumber** | **decimal?**| Denotes the index of the firewall rule in the server&#39;s firewall rule list | 

### Return type

[**FirewallRuleCreateResponse**](FirewallRuleCreateResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listserverconfigurations"></a>
# **ListServerConfigurations**
> ConfigurationListResponse ListServerConfigurations ()

List server configurations

Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListServerConfigurationsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();

            try
            {
                // List server configurations
                ConfigurationListResponse result = apiInstance.ListServerConfigurations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ListServerConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ConfigurationListResponse**](ConfigurationListResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listservers"></a>
# **ListServers**
> ServerListResponse ListServers ()

List of servers

Returns a list of all servers associated with the current account.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListServersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();

            try
            {
                // List of servers
                ServerListResponse result = apiInstance.ListServers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ListServers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loadcdrom"></a>
# **LoadCdrom**
> CreateServerResponse LoadCdrom (Guid? serverId, StorageDeviceLoadRequest storageDevice = null)

Load CD-ROM

Loads a storage as a CD-ROM in the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class LoadCdromExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDeviceLoadRequest(); // StorageDeviceLoadRequest |  (optional) 

            try
            {
                // Load CD-ROM
                CreateServerResponse result = apiInstance.LoadCdrom(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.LoadCdrom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDeviceLoadRequest**](StorageDeviceLoadRequest.md)|  | [optional] 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyserver"></a>
# **ModifyServer**
> CreateServerResponse ModifyServer (Guid? serverId, Server server = null)

Modify server

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ModifyServerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to modify
            var server = new Server(); // Server |  (optional) 

            try
            {
                // Modify server
                CreateServerResponse result = apiInstance.ModifyServer(serverId, server);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ModifyServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to modify | 
 **server** | [**Server**](Server.md)|  | [optional] 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restartserver"></a>
# **RestartServer**
> CreateServerResponse RestartServer (Guid? serverId, RestartServer restartServer)

Restart server

Stops and starts a server. The server state must be `started`.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class RestartServerExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to restart
            var restartServer = new RestartServer(); // RestartServer | 

            try
            {
                // Restart server
                CreateServerResponse result = apiInstance.RestartServer(serverId, restartServer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.RestartServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to restart | 
 **restartServer** | [**RestartServer**](RestartServer.md)|  | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverdetails"></a>
# **ServerDetails**
> CreateServerResponse ServerDetails (Guid? serverId)

Get server details

Returns detailed information about a specific server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ServerDetailsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to return

            try
            {
                // Get server details
                CreateServerResponse result = apiInstance.ServerDetails(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to return | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallruleget"></a>
# **ServerServerIdFirewallRuleGet**
> FirewallRuleListResponse ServerServerIdFirewallRuleGet (Guid? serverId)

List firewall rules

Returns a list of firewall rules for a specific server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ServerServerIdFirewallRuleGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // List firewall rules
                FirewallRuleListResponse result = apiInstance.ServerServerIdFirewallRuleGet(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdFirewallRuleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 

### Return type

[**FirewallRuleListResponse**](FirewallRuleListResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startserver"></a>
# **StartServer**
> CreateServerResponse StartServer (Guid? serverId)

Start server

Starts a stopped server. The server state must be `stopped`.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class StartServerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to start

            try
            {
                // Start server
                CreateServerResponse result = apiInstance.StartServer(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.StartServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to start | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stopserver"></a>
# **StopServer**
> CreateServerResponse StopServer (Guid? serverId, StopServer stopServerRequest)

Stop server

Stops a started server. The server state must be `started`.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class StopServerExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to stop
            var stopServerRequest = new StopServer(); // StopServer | 

            try
            {
                // Stop server
                CreateServerResponse result = apiInstance.StopServer(serverId, stopServerRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.StopServer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to stop | 
 **stopServerRequest** | [**StopServer**](StopServer.md)|  | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="untag"></a>
# **Untag**
> CreateServerResponse Untag (Guid? serverId, string tagName)

Remove tag from server

Untags tags from given server. The tag(s) must exist

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class UntagExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagName = tagName_example;  // string | Tag name

            try
            {
                // Remove tag from server
                CreateServerResponse result = apiInstance.Untag(serverId, tagName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.Untag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **tagName** | **string**| Tag name | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

