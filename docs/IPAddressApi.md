# IO.Swagger.Api.IPAddressApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IpAddressGet**](IPAddressApi.md#ipaddressget) | **GET** /ip_address | List IP addresses
[**IpAddressIpDelete**](IPAddressApi.md#ipaddressipdelete) | **DELETE** /ip_address/{ip} | Release IP address
[**IpAddressIpGet**](IPAddressApi.md#ipaddressipget) | **GET** /ip_address/{ip} | Get IP address details
[**IpAddressIpPut**](IPAddressApi.md#ipaddressipput) | **PUT** /ip_address/{ip} | Modify IP address
[**IpAddressPost**](IPAddressApi.md#ipaddresspost) | **POST** /ip_address | Assign IP address


<a name="ipaddressget"></a>
# **IpAddressGet**
> InlineResponse2006 IpAddressGet ()

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
    public class IpAddressGetExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();

            try
            {
                // List IP addresses
                InlineResponse2006 result = apiInstance.IpAddressGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.IpAddressGet: " + e.Message );
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

<a name="ipaddressipdelete"></a>
# **IpAddressIpDelete**
> void IpAddressIpDelete (string ip)

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
    public class IpAddressIpDeleteExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address

            try
            {
                // Release IP address
                apiInstance.IpAddressIpDelete(ip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.IpAddressIpDelete: " + e.Message );
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

<a name="ipaddressipget"></a>
# **IpAddressIpGet**
> InlineResponse2011 IpAddressIpGet (string ip)

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
    public class IpAddressIpGetExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address

            try
            {
                // Get IP address details
                InlineResponse2011 result = apiInstance.IpAddressIpGet(ip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.IpAddressIpGet: " + e.Message );
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

<a name="ipaddressipput"></a>
# **IpAddressIpPut**
> InlineResponse2011 IpAddressIpPut (string ip, IpAddress1 ipAddress = null)

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
    public class IpAddressIpPutExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ip = ip_example;  // string | Ip address
            var ipAddress = new IpAddress1(); // IpAddress1 |  (optional) 

            try
            {
                // Modify IP address
                InlineResponse2011 result = apiInstance.IpAddressIpPut(ip, ipAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.IpAddressIpPut: " + e.Message );
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

<a name="ipaddresspost"></a>
# **IpAddressPost**
> InlineResponse2011 IpAddressPost (IpAddress ipAddress = null)

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
    public class IpAddressPostExample
    {
        public void main()
        {
            var apiInstance = new IPAddressApi();
            var ipAddress = new IpAddress(); // IpAddress |  (optional) 

            try
            {
                // Assign IP address
                InlineResponse2011 result = apiInstance.IpAddressPost(ipAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPAddressApi.IpAddressPost: " + e.Message );
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

