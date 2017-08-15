# IO.Swagger.Api.ServerApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerGet**](ServerApi.md#serverget) | **GET** /server | List of servers
[**ServerPost**](ServerApi.md#serverpost) | **POST** /server | Create server
[**ServerServerIdDelete**](ServerApi.md#serverserveriddelete) | **DELETE** /server/{serverId} | Delete server
[**ServerServerIdGet**](ServerApi.md#serverserveridget) | **GET** /server/{serverId} | Server details
[**ServerServerIdPut**](ServerApi.md#serverserveridput) | **PUT** /server/{serverId} | Modify server


<a name="serverget"></a>
# **ServerGet**
> InlineResponse200 ServerGet ()

List of servers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerGetExample
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

<a name="serverpost"></a>
# **ServerPost**
> InlineResponse2001 ServerPost (Server server = null)

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
    public class ServerPostExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var server = new Server(); // Server |  (optional) 

            try
            {
                // Create server
                InlineResponse2001 result = apiInstance.ServerPost(server);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerPost: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveriddelete"></a>
# **ServerServerIdDelete**
> void ServerServerIdDelete (Guid? serverId)

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
    public class ServerServerIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to delete

            try
            {
                // Delete server
                apiInstance.ServerServerIdDelete(serverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdDelete: " + e.Message );
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

<a name="serverserveridget"></a>
# **ServerServerIdGet**
> InlineResponse2001 ServerServerIdGet (Guid? serverId)

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
    public class ServerServerIdGetExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to return

            try
            {
                // Server details
                InlineResponse2001 result = apiInstance.ServerServerIdGet(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridput"></a>
# **ServerServerIdPut**
> InlineResponse2001 ServerServerIdPut (Guid? serverId, Server server = null)

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
    public class ServerServerIdPutExample
    {
        public void main()
        {
            var apiInstance = new ServerApi();
            var serverId = serverId_example;  // Guid? | Id of server to modify
            var server = new Server(); // Server |  (optional) 

            try
            {
                // Modify server
                InlineResponse2001 result = apiInstance.ServerServerIdPut(serverId, server);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerApi.ServerServerIdPut: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

