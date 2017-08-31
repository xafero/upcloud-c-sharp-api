# IO.Swagger.Api.IPAddressApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddIp**](IPAddressApi.md#addip) | **POST** /ip_address | Assign IP address
[**DeleteIp**](IPAddressApi.md#deleteip) | **DELETE** /ip_address/{ip} | Release IP address
[**GetDetails**](IPAddressApi.md#getdetails) | **GET** /ip_address/{ip} | Get IP address details
[**ListIps**](IPAddressApi.md#listips) | **GET** /ip_address | List IP addresses
[**ModifyIp**](IPAddressApi.md#modifyip) | **PUT** /ip_address/{ip} | Modify IP address


<a name="addip"></a>
# **AddIp**
> InlineResponse2011 AddIp (IpAddress ipAddress = null)

Assign IP address

Assigns a new IP address to a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddIpExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ipAddress = new IpAddress(); // IpAddress |  (optional) 

            try
            {
                // Assign IP address
                InlineResponse2011 result = apiInstance.AddIp(ipAddress);
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
 **ipAddress** | [**IpAddress**](IpAddress.md)|  | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteIpExample
    {
        public void main()
        {
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdetails"></a>
# **GetDetails**
> InlineResponse2011 GetDetails (string ip)

Get IP address details

Returns detailed information about a specific IP address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDetailsExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address

            try
            {
                // Get IP address details
                InlineResponse2011 result = apiInstance.GetDetails(ip);
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

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listips"></a>
# **ListIps**
> InlineResponse2006 ListIps ()

List IP addresses

Returns a list of all IP addresses assigned to servers on the current user account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListIpsExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();

            try
            {
                // List IP addresses
                InlineResponse2006 result = apiInstance.ListIps();
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyip"></a>
# **ModifyIp**
> InlineResponse2011 ModifyIp (string ip, IpAddress1 ipAddress = null)

Modify IP address

Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyIpExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address
            var ipAddress = new IpAddress1(); // IpAddress1 |  (optional) 

            try
            {
                // Modify IP address
                InlineResponse2011 result = apiInstance.ModifyIp(ip, ipAddress);
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
 **ipAddress** | [**IpAddress1**](IpAddress1.md)|  | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

