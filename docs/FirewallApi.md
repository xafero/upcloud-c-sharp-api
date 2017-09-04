# IO.Swagger.Api.FirewallApi

All URIs are relative to *http://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFirewallRule**](FirewallApi.md#createfirewallrule) | **POST** /server/{serverId}/firewall_rule | Create firewall rule
[**DeleteFirewallRule**](FirewallApi.md#deletefirewallrule) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
[**GetFirewallRule**](FirewallApi.md#getfirewallrule) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
[**ServerServerIdFirewallRuleGet**](FirewallApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules


<a name="createfirewallrule"></a>
# **CreateFirewallRule**
> void CreateFirewallRule (Guid? serverId, FirewallRule firewallRule)

Create firewall rule

Creates a new firewall rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFirewallRuleExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRule = new FirewallRule(); // FirewallRule | 

            try
            {
                // Create firewall rule
                apiInstance.CreateFirewallRule(serverId, firewallRule);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.CreateFirewallRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRule** | [**FirewallRule**](FirewallRule.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefirewallrule"></a>
# **DeleteFirewallRule**
> void DeleteFirewallRule (Guid? serverId, Guid? firewallRuleNumber)

Remove firewall rule

Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFirewallRuleExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = firewallRuleNumber_example;  // Guid? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Remove firewall rule
                apiInstance.DeleteFirewallRule(serverId, firewallRuleNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.DeleteFirewallRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRuleNumber** | **Guid?**| Denotes the index of the firewall rule in the server&#39;s firewall rule list | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirewallrule"></a>
# **GetFirewallRule**
> FirewallRuleDetailsResponse GetFirewallRule (Guid? serverId, Guid? firewallRuleNumber)

Get firewall rule details

Returns detailed information about a specific firewall rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFirewallRuleExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = firewallRuleNumber_example;  // Guid? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Get firewall rule details
                FirewallRuleDetailsResponse result = apiInstance.GetFirewallRule(serverId, firewallRuleNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.GetFirewallRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **firewallRuleNumber** | **Guid?**| Denotes the index of the firewall rule in the server&#39;s firewall rule list | 

### Return type

[**FirewallRuleDetailsResponse**](FirewallRuleDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallruleget"></a>
# **ServerServerIdFirewallRuleGet**
> FirewallRuleListResponse ServerServerIdFirewallRuleGet (Guid? serverId)

List firewall rules

Returns a list of firewall rules for a specific server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdFirewallRuleGetExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // List firewall rules
                FirewallRuleListResponse result = apiInstance.ServerServerIdFirewallRuleGet(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.ServerServerIdFirewallRuleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 

### Return type

[**FirewallRuleListResponse**](FirewallRuleListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

