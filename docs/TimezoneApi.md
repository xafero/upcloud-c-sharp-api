# IO.Swagger.Api.TimezoneApi

All URIs are relative to *http://localhost/1.2*

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
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTimezonesExample
    {
        public void main()
        {
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

