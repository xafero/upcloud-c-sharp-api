# IO.Swagger.Api.PricesApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListPrices**](PricesApi.md#listprices) | **GET** /price | List prices


<a name="listprices"></a>
# **ListPrices**
> InlineResponse200 ListPrices ()

List prices

Returns a list resource prices.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
                InlineResponse200 result = apiInstance.ListPrices();
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

