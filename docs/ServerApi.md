# IO.Swagger.Api.ServerApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateServer**](ServerApi.md#createserver) | **POST** /server | Create server
[**DeleteServer**](ServerApi.md#deleteserver) | **DELETE** /server/{serverId} | Delete server
[**ListServers**](ServerApi.md#listservers) | **GET** /server | List of servers
[**ServerDetails**](ServerApi.md#serverdetails) | **GET** /server/{serverId} | Server details
[**UpdateServer**](ServerApi.md#updateserver) | **PUT** /server/{serverId} | Modify server


<a name="createserver"></a>
# **CreateServer**
> ServerListResponse CreateServer (Server server = null)

Create server

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
> InlineResponse200 ListServers ()

List of servers

List servers

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
                InlineResponse200 result = apiInstance.ListServers();
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverdetails"></a>
# **ServerDetails**
> ServerListResponse ServerDetails (Guid? serverId)

Server details

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
                // Server details
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

