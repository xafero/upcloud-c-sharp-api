# Upcloud.Api.TimezoneApi

All URIs are relative to *https://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListTimezones**](TimezoneApi.md#listtimezones) | **GET** /timezone | List timezones


<a name="listtimezones"></a>
# **ListTimezones**
> TimezoneListResponse ListTimezones ()

List timezones

Returns a list of available timezones. Timezones are used to set the hardware clock for servers.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListTimezonesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TimezoneApi();

            try
            {
                // List timezones
                TimezoneListResponse result = apiInstance.ListTimezones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimezoneApi.ListTimezones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TimezoneListResponse**](TimezoneListResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

