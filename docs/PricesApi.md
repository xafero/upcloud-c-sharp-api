# Upcloud.Api.PricesApi

All URIs are relative to *http://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListPrices**](PricesApi.md#listprices) | **GET** /price | List prices


<a name="listprices"></a>
# **ListPrices**
> PriceListResponse ListPrices ()

List prices

Returns a list resource prices.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListPricesExample
    {
        public void main()
        {
            var apiInstance = new PricesApi();

            try
            {
                // List prices
                PriceListResponse result = apiInstance.ListPrices();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.ListPrices: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PriceListResponse**](PriceListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

