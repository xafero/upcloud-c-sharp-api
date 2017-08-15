# IO.Swagger - the C# library for the Upcloud api

Upcloud api specification

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
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

            var apiInstance = new ServerApi();

            try
            {
                // List of servers
                InlineResponse200 result = apiInstance.ServerGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerGet: " + e.Message );
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
*ServerApi* | [**ServerGet**](docs/ServerApi.md#serverget) | **GET** /server | List of servers
*ServerApi* | [**ServerPost**](docs/ServerApi.md#serverpost) | **POST** /server | Create server
*ServerApi* | [**ServerServerIdDelete**](docs/ServerApi.md#serverserveriddelete) | **DELETE** /server/{serverId} | Delete server
*ServerApi* | [**ServerServerIdGet**](docs/ServerApi.md#serverserveridget) | **GET** /server/{serverId} | Server details
*ServerApi* | [**ServerServerIdPut**](docs/ServerApi.md#serverserveridput) | **PUT** /server/{serverId} | Modify server
*StorageApi* | [**StorageGet**](docs/StorageApi.md#storageget) | **GET** /storage | List of storages


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BackupRule](docs/BackupRule.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorCode](docs/ErrorCode.md)
 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.ErrorStatus](docs/ErrorStatus.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2002Storages](docs/InlineResponse2002Storages.md)
 - [Model.InlineResponse200Servers](docs/InlineResponse200Servers.md)
 - [Model.IpAddress](docs/IpAddress.md)
 - [Model.Server](docs/Server.md)
 - [Model.ServerIpAddresses](docs/ServerIpAddresses.md)
 - [Model.ServerStorageDevices](docs/ServerStorageDevices.md)
 - [Model.ServerTags](docs/ServerTags.md)
 - [Model.Storage](docs/Storage.md)
 - [Model.StorageBackups](docs/StorageBackups.md)
 - [Model.StorageDevice](docs/StorageDevice.md)
 - [Model.StorageServers](docs/StorageServers.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
