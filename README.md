# IO.Swagger - the C# library for the Upcloud api

The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.2.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new AccountApi();

            try
            {
                // Account information
                Account result = apiInstance.AccountGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountGet: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost/1.2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**AccountGet**](docs/AccountApi.md#accountget) | **GET** /account | Account information
*FirewallApi* | [**ServerServerIdFirewallRuleFirewallRuleNumberDelete**](docs/FirewallApi.md#serverserveridfirewallrulefirewallrulenumberdelete) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
*FirewallApi* | [**ServerServerIdFirewallRuleFirewallRuleNumberGet**](docs/FirewallApi.md#serverserveridfirewallrulefirewallrulenumberget) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
*FirewallApi* | [**ServerServerIdFirewallRuleGet**](docs/FirewallApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
*FirewallApi* | [**ServerServerIdFirewallRulePost**](docs/FirewallApi.md#serverserveridfirewallrulepost) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
*IPAddressApi* | [**IpAddressGet**](docs/IPAddressApi.md#ipaddressget) | **GET** /ip_address | List IP addresses
*IPAddressApi* | [**IpAddressIpDelete**](docs/IPAddressApi.md#ipaddressipdelete) | **DELETE** /ip_address/{ip} | Release IP address
*IPAddressApi* | [**IpAddressIpGet**](docs/IPAddressApi.md#ipaddressipget) | **GET** /ip_address/{ip} | Get IP address details
*IPAddressApi* | [**IpAddressIpPut**](docs/IPAddressApi.md#ipaddressipput) | **PUT** /ip_address/{ip} | Modify IP address
*IPAddressApi* | [**IpAddressPost**](docs/IPAddressApi.md#ipaddresspost) | **POST** /ip_address | Assign IP address
*PlanApi* | [**PlanGet**](docs/PlanApi.md#planget) | **GET** /plan | List available plans
*PricesApi* | [**PriceGet**](docs/PricesApi.md#priceget) | **GET** /price | List prices
*ServerApi* | [**CreateServer**](docs/ServerApi.md#createserver) | **POST** /server | Create server
*ServerApi* | [**DeleteServer**](docs/ServerApi.md#deleteserver) | **DELETE** /server/{serverId} | Delete server
*ServerApi* | [**ListServers**](docs/ServerApi.md#listservers) | **GET** /server | List of servers
*ServerApi* | [**ServerDetails**](docs/ServerApi.md#serverdetails) | **GET** /server/{serverId} | Get server details
*ServerApi* | [**ServerServerIdFirewallRuleFirewallRuleNumberDelete**](docs/ServerApi.md#serverserveridfirewallrulefirewallrulenumberdelete) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
*ServerApi* | [**ServerServerIdFirewallRuleFirewallRuleNumberGet**](docs/ServerApi.md#serverserveridfirewallrulefirewallrulenumberget) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
*ServerApi* | [**ServerServerIdFirewallRuleGet**](docs/ServerApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
*ServerApi* | [**ServerServerIdFirewallRulePost**](docs/ServerApi.md#serverserveridfirewallrulepost) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
*ServerApi* | [**ServerServerIdRestartPost**](docs/ServerApi.md#serverserveridrestartpost) | **POST** /server/{serverId}/restart | Restart server
*ServerApi* | [**ServerServerIdStartPost**](docs/ServerApi.md#serverserveridstartpost) | **POST** /server/{serverId}/start | Start server
*ServerApi* | [**ServerServerIdStopPost**](docs/ServerApi.md#serverserveridstoppost) | **POST** /server/{serverId}/stop | Stop server
*ServerApi* | [**ServerServerIdStorageAttachPost**](docs/ServerApi.md#serverserveridstorageattachpost) | **POST** /server/{serverId}/storage/attach | Attach storage
*ServerApi* | [**ServerServerIdStorageCdromEjectPost**](docs/ServerApi.md#serverserveridstoragecdromejectpost) | **POST** /server/{serverId}/storage/cdrom/eject | Eject CD-ROM
*ServerApi* | [**ServerServerIdStorageCdromLoadPost**](docs/ServerApi.md#serverserveridstoragecdromloadpost) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
*ServerApi* | [**ServerServerIdStorageDetachPost**](docs/ServerApi.md#serverserveridstoragedetachpost) | **POST** /server/{serverId}/storage/detach | Detach storage
*ServerApi* | [**ServerServerIdTagTagListPost**](docs/ServerApi.md#serverserveridtagtaglistpost) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
*ServerApi* | [**ServerServerIdUntagTagNamePost**](docs/ServerApi.md#serverserveriduntagtagnamepost) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server
*ServerApi* | [**ServerSizeGet**](docs/ServerApi.md#serversizeget) | **GET** /server_size | List server configurations
*ServerApi* | [**UpdateServer**](docs/ServerApi.md#updateserver) | **PUT** /server/{serverId} | Modify server
*StorageApi* | [**ListStorages**](docs/StorageApi.md#liststorages) | **GET** /storage | List of storages
*StorageApi* | [**ListStorages_0**](docs/StorageApi.md#liststorages_0) | **GET** /storage/{type} | List of storages by type
*StorageApi* | [**ServerServerIdStorageAttachPost**](docs/StorageApi.md#serverserveridstorageattachpost) | **POST** /server/{serverId}/storage/attach | Attach storage
*StorageApi* | [**ServerServerIdStorageCdromEjectPost**](docs/StorageApi.md#serverserveridstoragecdromejectpost) | **POST** /server/{serverId}/storage/cdrom/eject | Eject CD-ROM
*StorageApi* | [**ServerServerIdStorageCdromLoadPost**](docs/StorageApi.md#serverserveridstoragecdromloadpost) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
*StorageApi* | [**ServerServerIdStorageDetachPost**](docs/StorageApi.md#serverserveridstoragedetachpost) | **POST** /server/{serverId}/storage/detach | Detach storage
*StorageApi* | [**StoragePost**](docs/StorageApi.md#storagepost) | **POST** /storage | Create storage
*StorageApi* | [**StorageStorageIdBackupPost**](docs/StorageApi.md#storagestorageidbackuppost) | **POST** /storage/{storageId}/backup | Create backup
*StorageApi* | [**StorageStorageIdCancelPost**](docs/StorageApi.md#storagestorageidcancelpost) | **POST** /storage/{storageId}/cancel | Cancel storage operation
*StorageApi* | [**StorageStorageIdClonePost**](docs/StorageApi.md#storagestorageidclonepost) | **POST** /storage/{storageId}/clone | Clone storage
*StorageApi* | [**StorageStorageIdDelete**](docs/StorageApi.md#storagestorageiddelete) | **DELETE** /storage/{storageId} | Delete storage
*StorageApi* | [**StorageStorageIdFavoriteDelete**](docs/StorageApi.md#storagestorageidfavoritedelete) | **DELETE** /storage/{storageId}/favorite | Remove storage from favorites
*StorageApi* | [**StorageStorageIdFavoritePost**](docs/StorageApi.md#storagestorageidfavoritepost) | **POST** /storage/{storageId}/favorite | Add storage to favorites
*StorageApi* | [**StorageStorageIdGet**](docs/StorageApi.md#storagestorageidget) | **GET** /storage/{storageId} | Get storage details
*StorageApi* | [**StorageStorageIdPut**](docs/StorageApi.md#storagestorageidput) | **PUT** /storage/{storageId} | Modify storage
*StorageApi* | [**StorageStorageIdRestorePost**](docs/StorageApi.md#storagestorageidrestorepost) | **POST** /storage/{storageId}/restore | Restore backup
*StorageApi* | [**StorageStorageIdTemplatizePost**](docs/StorageApi.md#storagestorageidtemplatizepost) | **POST** /storage/{storageId}/templatize | Templatize storage
*TagApi* | [**ServerServerIdTagTagListPost**](docs/TagApi.md#serverserveridtagtaglistpost) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
*TagApi* | [**ServerServerIdUntagTagNamePost**](docs/TagApi.md#serverserveriduntagtagnamepost) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server
*TagApi* | [**TagGet**](docs/TagApi.md#tagget) | **GET** /tag | List existing tags
*TagApi* | [**TagPost**](docs/TagApi.md#tagpost) | **POST** /tag | Create a new tag
*TagApi* | [**TagTagNameDelete**](docs/TagApi.md#tagtagnamedelete) | **DELETE** /tag/{tagName} | Delete tag
*TagApi* | [**TagTagNamePut**](docs/TagApi.md#tagtagnameput) | **PUT** /tag/{tagName} | Modify existing tag
*TimezoneApi* | [**TimezoneGet**](docs/TimezoneApi.md#timezoneget) | **GET** /timezone | List timezones
*ZoneApi* | [**ZoneGet**](docs/ZoneApi.md#zoneget) | **GET** /zone | List available zones


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Account](docs/Account.md)
 - [Model.AddressFamily](docs/AddressFamily.md)
 - [Model.BackupRule](docs/BackupRule.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorCode](docs/ErrorCode.md)
 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.ErrorStatus](docs/ErrorStatus.md)
 - [Model.FirewallRule](docs/FirewallRule.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse20010](docs/InlineResponse20010.md)
 - [Model.InlineResponse2001Zones](docs/InlineResponse2001Zones.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2002Timezones](docs/InlineResponse2002Timezones.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2003Plans](docs/InlineResponse2003Plans.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2004ServerSizes](docs/InlineResponse2004ServerSizes.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2005Servers](docs/InlineResponse2005Servers.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2006IpAddresses](docs/InlineResponse2006IpAddresses.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2007FirewallRules](docs/InlineResponse2007FirewallRules.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.InlineResponse2009Tags](docs/InlineResponse2009Tags.md)
 - [Model.InlineResponse200Price](docs/InlineResponse200Price.md)
 - [Model.InlineResponse201](docs/InlineResponse201.md)
 - [Model.InlineResponse2011](docs/InlineResponse2011.md)
 - [Model.IpAddress](docs/IpAddress.md)
 - [Model.IpAddress1](docs/IpAddress1.md)
 - [Model.Plan](docs/Plan.md)
 - [Model.Price](docs/Price.md)
 - [Model.PriceZone](docs/PriceZone.md)
 - [Model.RestartServer](docs/RestartServer.md)
 - [Model.Server](docs/Server.md)
 - [Model.ServerListResponse](docs/ServerListResponse.md)
 - [Model.ServerSize](docs/ServerSize.md)
 - [Model.ServerState](docs/ServerState.md)
 - [Model.ServerStorageDevices](docs/ServerStorageDevices.md)
 - [Model.ServerTags](docs/ServerTags.md)
 - [Model.StopServer](docs/StopServer.md)
 - [Model.Storage](docs/Storage.md)
 - [Model.Storage1](docs/Storage1.md)
 - [Model.Storage2](docs/Storage2.md)
 - [Model.Storage3](docs/Storage3.md)
 - [Model.Storage4](docs/Storage4.md)
 - [Model.StorageAccessType](docs/StorageAccessType.md)
 - [Model.StorageBackups](docs/StorageBackups.md)
 - [Model.StorageDevice](docs/StorageDevice.md)
 - [Model.StorageDevice1](docs/StorageDevice1.md)
 - [Model.StorageServers](docs/StorageServers.md)
 - [Model.StorageState](docs/StorageState.md)
 - [Model.StorageTier](docs/StorageTier.md)
 - [Model.StorageType](docs/StorageType.md)
 - [Model.SuccessStoragesResponse](docs/SuccessStoragesResponse.md)
 - [Model.SuccessStoragesResponseStorages](docs/SuccessStoragesResponseStorages.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.Tag1](docs/Tag1.md)
 - [Model.TagServers](docs/TagServers.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.Zone](docs/Zone.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
