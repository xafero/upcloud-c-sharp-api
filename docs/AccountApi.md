# Upcloud.Api.AccountApi

All URIs are relative to *http://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccount**](AccountApi.md#getaccount) | **GET** /account | Account information


<a name="getaccount"></a>
# **GetAccount**
> Account GetAccount ()

Account information

Returns information on the user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();

            try
            {
                // Account information
                Account result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

