# IO.Swagger.Api.ZoneApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ZoneGet**](ZoneApi.md#zoneget) | **GET** /zone | List available zones


<a name="zoneget"></a>
# **ZoneGet**
> InlineResponse2001 ZoneGet ()

List available zones

Returns a list of available zones.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ZoneGetExample
    {
        public void main()
        {
            var apiInstance = new ZoneApi();

            try
            {
                // List available zones
                InlineResponse2001 result = apiInstance.ZoneGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.ZoneGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

