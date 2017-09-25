# Upcloud - the C# library for the Upcloud api

The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.

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
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Upcloud.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

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
                Account result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://api.upcloud.com/1.2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**GetAccount**](docs/AccountApi.md#getaccount) | **GET** /account | Account information
*FirewallApi* | [**CreateFirewallRule**](docs/FirewallApi.md#createfirewallrule) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
*FirewallApi* | [**DeleteFirewallRule**](docs/FirewallApi.md#deletefirewallrule) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
*FirewallApi* | [**GetFirewallRule**](docs/FirewallApi.md#getfirewallrule) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
*FirewallApi* | [**ServerServerIdFirewallRuleGet**](docs/FirewallApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
*IPAddressApi* | [**AddIp**](docs/IPAddressApi.md#addip) | **POST** /ip_address | Assign IP address
*IPAddressApi* | [**DeleteIp**](docs/IPAddressApi.md#deleteip) | **DELETE** /ip_address/{ip} | Release IP address
*IPAddressApi* | [**GetDetails**](docs/IPAddressApi.md#getdetails) | **GET** /ip_address/{ip} | Get IP address details
*IPAddressApi* | [**ListIps**](docs/IPAddressApi.md#listips) | **GET** /ip_address | List IP addresses
*IPAddressApi* | [**ModifyIp**](docs/IPAddressApi.md#modifyip) | **PUT** /ip_address/{ip} | Modify IP address
*PlanApi* | [**ListPlans**](docs/PlanApi.md#listplans) | **GET** /plan | List available plans
*PricesApi* | [**ListPrices**](docs/PricesApi.md#listprices) | **GET** /price | List prices
*ServerApi* | [**AssignTag**](docs/ServerApi.md#assigntag) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
*ServerApi* | [**AttachStorage**](docs/ServerApi.md#attachstorage) | **POST** /server/{serverId}/storage/attach | Attach storage
*ServerApi* | [**CreateFirewallRule**](docs/ServerApi.md#createfirewallrule) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
*ServerApi* | [**CreateServer**](docs/ServerApi.md#createserver) | **POST** /server | Create server
*ServerApi* | [**DeleteFirewallRule**](docs/ServerApi.md#deletefirewallrule) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
*ServerApi* | [**DeleteServer**](docs/ServerApi.md#deleteserver) | **DELETE** /server/{serverId} | Delete server
*ServerApi* | [**DetachStorage**](docs/ServerApi.md#detachstorage) | **POST** /server/{serverId}/storage/detach | Detach storage
*ServerApi* | [**EjectCdrom**](docs/ServerApi.md#ejectcdrom) | **POST** /server/{serverId}/storage/cdrom/eject | Eject CD-ROM
*ServerApi* | [**GetFirewallRule**](docs/ServerApi.md#getfirewallrule) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
*ServerApi* | [**ListServerConfigurations**](docs/ServerApi.md#listserverconfigurations) | **GET** /server_size | List server configurations
*ServerApi* | [**ListServers**](docs/ServerApi.md#listservers) | **GET** /server | List of servers
*ServerApi* | [**LoadCdrom**](docs/ServerApi.md#loadcdrom) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
*ServerApi* | [**ModifyServer**](docs/ServerApi.md#modifyserver) | **PUT** /server/{serverId} | Modify server
*ServerApi* | [**RestartServer**](docs/ServerApi.md#restartserver) | **POST** /server/{serverId}/restart | Restart server
*ServerApi* | [**ServerDetails**](docs/ServerApi.md#serverdetails) | **GET** /server/{serverId} | Get server details
*ServerApi* | [**ServerServerIdFirewallRuleGet**](docs/ServerApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
*ServerApi* | [**StartServer**](docs/ServerApi.md#startserver) | **POST** /server/{serverId}/start | Start server
*ServerApi* | [**StopServer**](docs/ServerApi.md#stopserver) | **POST** /server/{serverId}/stop | Stop server
*ServerApi* | [**Untag**](docs/ServerApi.md#untag) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server
*StorageApi* | [**AttachStorage**](docs/StorageApi.md#attachstorage) | **POST** /server/{serverId}/storage/attach | Attach storage
*StorageApi* | [**BackupStorage**](docs/StorageApi.md#backupstorage) | **POST** /storage/{storageId}/backup | Create backup
*StorageApi* | [**CancelOperation**](docs/StorageApi.md#canceloperation) | **POST** /storage/{storageId}/cancel | Cancel storage operation
*StorageApi* | [**CloneStorage**](docs/StorageApi.md#clonestorage) | **POST** /storage/{storageId}/clone | Clone storage
*StorageApi* | [**CreateStorage**](docs/StorageApi.md#createstorage) | **POST** /storage | Create storage
*StorageApi* | [**DeleteStorage**](docs/StorageApi.md#deletestorage) | **DELETE** /storage/{storageId} | Delete storage
*StorageApi* | [**DetachStorage**](docs/StorageApi.md#detachstorage) | **POST** /server/{serverId}/storage/detach | Detach storage
*StorageApi* | [**EjectCdrom**](docs/StorageApi.md#ejectcdrom) | **POST** /server/{serverId}/storage/cdrom/eject | Eject CD-ROM
*StorageApi* | [**FavoriteStorage**](docs/StorageApi.md#favoritestorage) | **POST** /storage/{storageId}/favorite | Add storage to favorites
*StorageApi* | [**GetStorageDetails**](docs/StorageApi.md#getstoragedetails) | **GET** /storage/{storageId} | Get storage details
*StorageApi* | [**ListStorageTypes**](docs/StorageApi.md#liststoragetypes) | **GET** /storage/{type}/ | List of storages by type
*StorageApi* | [**ListStorages**](docs/StorageApi.md#liststorages) | **GET** /storage | List of storages
*StorageApi* | [**LoadCdrom**](docs/StorageApi.md#loadcdrom) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
*StorageApi* | [**ModifyStorage**](docs/StorageApi.md#modifystorage) | **PUT** /storage/{storageId} | Modify storage
*StorageApi* | [**RestoreStorage**](docs/StorageApi.md#restorestorage) | **POST** /storage/{storageId}/restore | Restore backup
*StorageApi* | [**TemplatizeStorage**](docs/StorageApi.md#templatizestorage) | **POST** /storage/{storageId}/templatize | Templatize storage
*StorageApi* | [**UnfavoriteStorage**](docs/StorageApi.md#unfavoritestorage) | **DELETE** /storage/{storageId}/favorite | Remove storage from favorites
*TagApi* | [**AssignTag**](docs/TagApi.md#assigntag) | **POST** /server/{serverId}/tag/{tagList} | Assign tag to a server
*TagApi* | [**CreateTag**](docs/TagApi.md#createtag) | **POST** /tag | Create a new tag
*TagApi* | [**DeleteTag**](docs/TagApi.md#deletetag) | **DELETE** /tag/{tagName} | Delete tag
*TagApi* | [**ListTags**](docs/TagApi.md#listtags) | **GET** /tag | List existing tags
*TagApi* | [**ModifyTag**](docs/TagApi.md#modifytag) | **PUT** /tag/{tagName} | Modify existing tag
*TagApi* | [**Untag**](docs/TagApi.md#untag) | **POST** /server/{serverId}/untag/{tagName} | Remove tag from server
*TimezoneApi* | [**ListTimezones**](docs/TimezoneApi.md#listtimezones) | **GET** /timezone | List timezones
*ZoneApi* | [**ListZones**](docs/ZoneApi.md#listzones) | **GET** /zone | List available zones


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Account](docs/Account.md)
 - [Model.AddressFamily](docs/AddressFamily.md)
 - [Model.AssignIpResponse](docs/AssignIpResponse.md)
 - [Model.AvailablePlanListResponse](docs/AvailablePlanListResponse.md)
 - [Model.AvailablePlanListResponsePlans](docs/AvailablePlanListResponsePlans.md)
 - [Model.BackupRule](docs/BackupRule.md)
 - [Model.ConfigurationListResponse](docs/ConfigurationListResponse.md)
 - [Model.ConfigurationListResponseServerSizes](docs/ConfigurationListResponseServerSizes.md)
 - [Model.CreateNewTagResponse](docs/CreateNewTagResponse.md)
 - [Model.CreateServerResponse](docs/CreateServerResponse.md)
 - [Model.CreateStorageResponse](docs/CreateStorageResponse.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorCode](docs/ErrorCode.md)
 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.ErrorStatus](docs/ErrorStatus.md)
 - [Model.FirewallRule](docs/FirewallRule.md)
 - [Model.FirewallRuleCreateResponse](docs/FirewallRuleCreateResponse.md)
 - [Model.FirewallRuleListResponse](docs/FirewallRuleListResponse.md)
 - [Model.FirewallRuleListResponseFirewallRules](docs/FirewallRuleListResponseFirewallRules.md)
 - [Model.FirewallRuleRequest](docs/FirewallRuleRequest.md)
 - [Model.IpAddress](docs/IpAddress.md)
 - [Model.IpAddress1](docs/IpAddress1.md)
 - [Model.IpAddressListResponse](docs/IpAddressListResponse.md)
 - [Model.IpAddressListResponseIpAddresses](docs/IpAddressListResponseIpAddresses.md)
 - [Model.Plan](docs/Plan.md)
 - [Model.Price](docs/Price.md)
 - [Model.PriceListResponse](docs/PriceListResponse.md)
 - [Model.PriceListResponsePrice](docs/PriceListResponsePrice.md)
 - [Model.PriceZone](docs/PriceZone.md)
 - [Model.RestartServer](docs/RestartServer.md)
 - [Model.Server](docs/Server.md)
 - [Model.ServerListResponse](docs/ServerListResponse.md)
 - [Model.ServerListResponseServers](docs/ServerListResponseServers.md)
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
 - [Model.TagListResponse](docs/TagListResponse.md)
 - [Model.TagListResponseTags](docs/TagListResponseTags.md)
 - [Model.TagServers](docs/TagServers.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.TimezoneListResponse](docs/TimezoneListResponse.md)
 - [Model.TimezoneListResponseTimezones](docs/TimezoneListResponseTimezones.md)
 - [Model.Zone](docs/Zone.md)
 - [Model.ZoneListResponse](docs/ZoneListResponse.md)
 - [Model.ZoneListResponseZones](docs/ZoneListResponseZones.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
