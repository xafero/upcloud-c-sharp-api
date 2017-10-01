# Upcloud.Api.IPAddressApi

All URIs are relative to *https://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddIp**](IPAddressApi.md#addip) | **POST** /ip_address | Assign IP address
[**DeleteIp**](IPAddressApi.md#deleteip) | **DELETE** /ip_address/{ip} | Release IP address
[**GetDetails**](IPAddressApi.md#getdetails) | **GET** /ip_address/{ip} | Get IP address details
[**ListIps**](IPAddressApi.md#listips) | **GET** /ip_address | List IP addresses
[**ModifyIp**](IPAddressApi.md#modifyip) | **PUT** /ip_address/{ip} | Modify IP address


<a name="addip"></a>
# **AddIp**
> AssignIpResponse AddIp (AddIpRequest ipAddress = null)

Assign IP address

Assigns a new IP address to a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class AddIpExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IPAddressApi();
            var ipAddress = new AddIpRequest(); // AddIpRequest |  (optional) 

            try
            {
                // Assign IP address
                AssignIpResponse result = apiInstance.AddIp(ipAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.AddIp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ipAddress** | [**AddIpRequest**](AddIpRequest.md)|  | [optional] 

### Return type

[**AssignIpResponse**](AssignIpResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteip"></a>
# **DeleteIp**
> void DeleteIp (string ip)

Release IP address

Removes an IP address from a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DeleteIpExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address

            try
            {
                // Release IP address
                apiInstance.DeleteIp(ip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.DeleteIp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ip** | **string**| Ip address | 

### Return type

void (empty response body)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdetails"></a>
# **GetDetails**
> AssignIpResponse GetDetails (string ip)

Get IP address details

Returns detailed information about a specific IP address.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class GetDetailsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address

            try
            {
                // Get IP address details
                AssignIpResponse result = apiInstance.GetDetails(ip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.GetDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ip** | **string**| Ip address | 

### Return type

[**AssignIpResponse**](AssignIpResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listips"></a>
# **ListIps**
> IpAddressListResponse ListIps ()

List IP addresses

Returns a list of all IP addresses assigned to servers on the current user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListIpsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IPAddressApi();

            try
            {
                // List IP addresses
                IpAddressListResponse result = apiInstance.ListIps();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.ListIps: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IpAddressListResponse**](IpAddressListResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyip"></a>
# **ModifyIp**
> AssignIpResponse ModifyIp (string ip, ModifyIpRequest ipAddress = null)

Modify IP address

Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ModifyIpExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address
            var ipAddress = new ModifyIpRequest(); // ModifyIpRequest |  (optional) 

            try
            {
                // Modify IP address
                AssignIpResponse result = apiInstance.ModifyIp(ip, ipAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.ModifyIp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ip** | **string**| Ip address | 
 **ipAddress** | [**ModifyIpRequest**](ModifyIpRequest.md)|  | [optional] 

### Return type

[**AssignIpResponse**](AssignIpResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

