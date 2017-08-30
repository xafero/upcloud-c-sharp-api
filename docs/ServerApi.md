# IO.Swagger.Api.ServerApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateServer**](ServerApi.md#createserver) | **POST** /server | Create server
[**DeleteServer**](ServerApi.md#deleteserver) | **DELETE** /server/{serverId} | Delete server
[**ListServers**](ServerApi.md#listservers) | **GET** /server | List of servers
[**ServerDetails**](ServerApi.md#serverdetails) | **GET** /server/{serverId} | Get server details
[**ServerServerIdFirewallRuleFirewallRuleNumberDelete**](ServerApi.md#serverserveridfirewallrulefirewallrulenumberdelete) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
[**ServerServerIdFirewallRuleFirewallRuleNumberGet**](ServerApi.md#serverserveridfirewallrulefirewallrulenumberget) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
[**ServerServerIdFirewallRuleGet**](ServerApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
[**ServerServerIdFirewallRulePost**](ServerApi.md#serverserveridfirewallrulepost) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
[**ServerServerIdRestartPost**](ServerApi.md#serverserveridrestartpost) | **POST** /server/{serverId}/restart | Restart server
[**ServerServerIdStartPost**](ServerApi.md#serverserveridstartpost) | **POST** /server/{serverId}/start | Start server
[**ServerServerIdStopPost**](ServerApi.md#serverserveridstoppost) | **POST** /server/{serverId}/stop | Stop server
[**ServerServerIdStorageAttachPost**](ServerApi.md#serverserveridstorageattachpost) | **POST** /server/{serverId}/storage/attach | Attach storage
[**ServerServerIdStorageCdromEjectPost**](ServerApi.md#serverserveridstoragecdromejectpost) | **POST** /server/{serverId}/storage/cdrom/eject | Eject CD-ROM
[**ServerServerIdStorageCdromLoadPost**](ServerApi.md#serverserveridstoragecdromloadpost) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
[**ServerServerIdStorageDetachPost**](ServerApi.md#serverserveridstoragedetachpost) | **POST** /server/{serverId}/storage/detach | Detach storage
[**ServerServerIdTagTagListPost**](ServerApi.md#serverserveridtagtaglistpost) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
[**ServerServerIdUntagTagNamePost**](ServerApi.md#serverserveriduntagtagnamepost) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server
[**ServerSizeGet**](ServerApi.md#serversizeget) | **GET** /server_size | List server configurations
[**UpdateServer**](ServerApi.md#updateserver) | **PUT** /server/{serverId} | Modify server


<a name="createserver"></a>
# **CreateServer**
> ServerListResponse CreateServer (Server server = null)

Create server

Creates a new server instance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateServerExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var server = new Server(); // Server |  (optional) 

            try
            {
                // Create server
                ServerListResponse result = apiInstance.CreateServer(server);
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
 **server** | [**Server**](Server.md)|  | [optional] 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteServerExample
    {
        public void main()
        {
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listservers"></a>
# **ListServers**
> InlineResponse2005 ListServers ()

List of servers

Returns a list of all servers associated with the current account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListServersExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();

            try
            {
                // List of servers
                InlineResponse2005 result = apiInstance.ListServers();
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

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverdetails"></a>
# **ServerDetails**
> ServerListResponse ServerDetails (Guid? serverId)

Get server details

Returns detailed information about a specific server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerDetailsExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to return

            try
            {
                // Get server details
                ServerListResponse result = apiInstance.ServerDetails(serverId);
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallrulefirewallrulenumberdelete"></a>
# **ServerServerIdFirewallRuleFirewallRuleNumberDelete**
> void ServerServerIdFirewallRuleFirewallRuleNumberDelete (Guid? serverId, Guid? firewallRuleNumber)

Remove firewall rule

Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdFirewallRuleFirewallRuleNumberDeleteExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = firewallRuleNumber_example;  // Guid? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Remove firewall rule
                apiInstance.ServerServerIdFirewallRuleFirewallRuleNumberDelete(serverId, firewallRuleNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdFirewallRuleFirewallRuleNumberDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRuleNumber** | **Guid?**| Denotes the index of the firewall rule in the server&#39;s firewall rule list | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallrulefirewallrulenumberget"></a>
# **ServerServerIdFirewallRuleFirewallRuleNumberGet**
> InlineResponse2008 ServerServerIdFirewallRuleFirewallRuleNumberGet (Guid? serverId, Guid? firewallRuleNumber)

Get firewall rule details

Returns detailed information about a specific firewall rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdFirewallRuleFirewallRuleNumberGetExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = firewallRuleNumber_example;  // Guid? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Get firewall rule details
                InlineResponse2008 result = apiInstance.ServerServerIdFirewallRuleFirewallRuleNumberGet(serverId, firewallRuleNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdFirewallRuleFirewallRuleNumberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRuleNumber** | **Guid?**| Denotes the index of the firewall rule in the server&#39;s firewall rule list | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallruleget"></a>
# **ServerServerIdFirewallRuleGet**
> InlineResponse2007 ServerServerIdFirewallRuleGet (Guid? serverId)

List firewall rules

Returns a list of firewall rules for a specific server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdFirewallRuleGetExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // List firewall rules
                InlineResponse2007 result = apiInstance.ServerServerIdFirewallRuleGet(serverId);
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

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallrulepost"></a>
# **ServerServerIdFirewallRulePost**
> void ServerServerIdFirewallRulePost (Guid? serverId, FirewallRule firewallRule)

Create firewall rule

Creates a new firewall rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdFirewallRulePostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRule = new FirewallRule(); // FirewallRule | 

            try
            {
                // Create firewall rule
                apiInstance.ServerServerIdFirewallRulePost(serverId, firewallRule);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdFirewallRulePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRule** | [**FirewallRule**](FirewallRule.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridrestartpost"></a>
# **ServerServerIdRestartPost**
> ServerListResponse ServerServerIdRestartPost (Guid? serverId, RestartServer restartServer)

Restart server

Stops and starts a server. The server state must be `started`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdRestartPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to restart
            var restartServer = new RestartServer(); // RestartServer | 

            try
            {
                // Restart server
                ServerListResponse result = apiInstance.ServerServerIdRestartPost(serverId, restartServer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdRestartPost: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstartpost"></a>
# **ServerServerIdStartPost**
> ServerListResponse ServerServerIdStartPost (Guid? serverId)

Start server

Starts a stopped server. The server state must be `stopped`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStartPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to start

            try
            {
                // Start server
                ServerListResponse result = apiInstance.ServerServerIdStartPost(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdStartPost: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoppost"></a>
# **ServerServerIdStopPost**
> ServerListResponse ServerServerIdStopPost (Guid? serverId, StopServer stopServer)

Stop server

Stops a started server. The server state must be `started`.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStopPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to stop
            var stopServer = new StopServer(); // StopServer | 

            try
            {
                // Stop server
                ServerListResponse result = apiInstance.ServerServerIdStopPost(serverId, stopServer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdStopPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Id of server to stop | 
 **stopServer** | [**StopServer**](StopServer.md)|  | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstorageattachpost"></a>
# **ServerServerIdStorageAttachPost**
> ServerListResponse ServerServerIdStorageAttachPost (Guid? serverId, StorageDevice storageDevice)

Attach storage

Attaches a storage as a device to a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageAttachPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDevice(); // StorageDevice | 

            try
            {
                // Attach storage
                ServerListResponse result = apiInstance.ServerServerIdStorageAttachPost(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdStorageAttachPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDevice**](StorageDevice.md)|  | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoragecdromejectpost"></a>
# **ServerServerIdStorageCdromEjectPost**
> ServerListResponse ServerServerIdStorageCdromEjectPost (Guid? serverId)

Eject CD-ROM

Ejects the storage from the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageCdromEjectPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // Eject CD-ROM
                ServerListResponse result = apiInstance.ServerServerIdStorageCdromEjectPost(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdStorageCdromEjectPost: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoragecdromloadpost"></a>
# **ServerServerIdStorageCdromLoadPost**
> ServerListResponse ServerServerIdStorageCdromLoadPost (Guid? serverId, StorageDevice1 storageDevice = null)

Load CD-ROM

Loads a storage as a CD-ROM in the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageCdromLoadPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDevice1(); // StorageDevice1 |  (optional) 

            try
            {
                // Load CD-ROM
                ServerListResponse result = apiInstance.ServerServerIdStorageCdromLoadPost(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdStorageCdromLoadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDevice1**](StorageDevice1.md)|  | [optional] 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoragedetachpost"></a>
# **ServerServerIdStorageDetachPost**
> ServerListResponse ServerServerIdStorageDetachPost (Guid? serverId, StorageDevice storageDevice)

Detach storage

Detaches a storage resource from a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageDetachPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDevice(); // StorageDevice | 

            try
            {
                // Detach storage
                ServerListResponse result = apiInstance.ServerServerIdStorageDetachPost(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdStorageDetachPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDevice**](StorageDevice.md)|  | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridtagtaglistpost"></a>
# **ServerServerIdTagTagListPost**
> ServerListResponse ServerServerIdTagTagListPost (Guid? serverId, string tagList)

Assign tag to a server

Servers can be tagged with one or more tags. The tags used must exist

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdTagTagListPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagList = tagList_example;  // string | List of tags

            try
            {
                // Assign tag to a server
                ServerListResponse result = apiInstance.ServerServerIdTagTagListPost(serverId, tagList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdTagTagListPost: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveriduntagtagnamepost"></a>
# **ServerServerIdUntagTagNamePost**
> ServerListResponse ServerServerIdUntagTagNamePost (Guid? serverId, string tagName)

Remove tag from server

Untags tags from given server. The tag(s) must exist

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdUntagTagNamePostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Server id
            var tagName = tagName_example;  // string | Tag name

            try
            {
                // Remove tag from server
                ServerListResponse result = apiInstance.ServerServerIdUntagTagNamePost(serverId, tagName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdUntagTagNamePost: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serversizeget"></a>
# **ServerSizeGet**
> InlineResponse2004 ServerSizeGet ()

List server configurations

Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerSizeGetExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();

            try
            {
                // List server configurations
                InlineResponse2004 result = apiInstance.ServerSizeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerSizeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateserver"></a>
# **UpdateServer**
> ServerListResponse UpdateServer (Guid? serverId, Server server = null)

Modify server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateServerExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to modify
            var server = new Server(); // Server |  (optional) 

            try
            {
                // Modify server
                ServerListResponse result = apiInstance.UpdateServer(serverId, server);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.UpdateServer: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

