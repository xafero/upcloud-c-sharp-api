# Upcloud.Api.ZoneApi

All URIs are relative to *http://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListZones**](ZoneApi.md#listzones) | **GET** /zone | List available zones


<a name="listzones"></a>
# **ListZones**
> ZoneListResponse ListZones ()

List available zones

Returns a list of available zones.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListZonesExample
    {
        public void main()
        {
            var apiInstance = new ZoneApi();

            try
            {
                // List available zones
                ZoneListResponse result = apiInstance.ListZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZoneApi.ListZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ZoneListResponse**](ZoneListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

