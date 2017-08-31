# IO.Swagger.Api.PlanApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListPlans**](PlanApi.md#listplans) | **GET** /plan | List available plans


<a name="listplans"></a>
# **ListPlans**
> AvailablePlanListResponse ListPlans ()

List available plans

Returns a list of available plans.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPlansExample
    {
        public void main()
        {
            var apiInstance = new PlanApi();

            try
            {
                // List available plans
                AvailablePlanListResponse result = apiInstance.ListPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanApi.ListPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AvailablePlanListResponse**](AvailablePlanListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

