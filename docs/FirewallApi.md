# IO.Swagger.Api.FirewallApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerServerIdFirewallRuleFirewallRuleNumberDelete**](FirewallApi.md#serverserveridfirewallrulefirewallrulenumberdelete) | **DELETE** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Remove firewall rule
[**ServerServerIdFirewallRuleFirewallRuleNumberGet**](FirewallApi.md#serverserveridfirewallrulefirewallrulenumberget) | **GET** /server/{serverId}/firewall_rule/{firewallRuleNumber} | Get firewall rule details
[**ServerServerIdFirewallRuleGet**](FirewallApi.md#serverserveridfirewallruleget) | **GET** /server/{serverId}/firewall_rule | List firewall rules
[**ServerServerIdFirewallRulePost**](FirewallApi.md#serverserveridfirewallrulepost) | **POST** /server/{serverId}/firewall_rule | Create firewall rule


<a name="serverserveridfirewallrulefirewallrulenumberdelete"></a>
# **ServerServerIdFirewallRuleFirewallRuleNumberDelete**
> void ServerServerIdFirewallRuleFirewallRuleNumberDelete (Guid? serverId, Guid? firewallRuleNumber)

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
    public class ServerServerIdFirewallRuleFirewallRuleNumberDeleteExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = firewallRuleNumber_example;  // Guid? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Remove firewall rule
                apiInstance.ServerServerIdFirewallRuleFirewallRuleNumberDelete(serverId, firewallRuleNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.ServerServerIdFirewallRuleFirewallRuleNumberDelete: " + e.Message );
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

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallrulefirewallrulenumberget"></a>
# **ServerServerIdFirewallRuleFirewallRuleNumberGet**
> InlineResponse2008 ServerServerIdFirewallRuleFirewallRuleNumberGet (Guid? serverId, Guid? firewallRuleNumber)

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
    public class ServerServerIdFirewallRuleFirewallRuleNumberGetExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRuleNumber = firewallRuleNumber_example;  // Guid? | Denotes the index of the firewall rule in the server's firewall rule list

            try
            {
                // Get firewall rule details
                InlineResponse2008 result = apiInstance.ServerServerIdFirewallRuleFirewallRuleNumberGet(serverId, firewallRuleNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.ServerServerIdFirewallRuleFirewallRuleNumberGet: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallruleget"></a>
# **ServerServerIdFirewallRuleGet**
> InlineResponse2007 ServerServerIdFirewallRuleGet (Guid? serverId)

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
                InlineResponse2007 result = apiInstance.ServerServerIdFirewallRuleGet(serverId);
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

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridfirewallrulepost"></a>
# **ServerServerIdFirewallRulePost**
> void ServerServerIdFirewallRulePost (Guid? serverId, FirewallRule firewallRule)

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
    public class ServerServerIdFirewallRulePostExample
    {
        public void main()
        {
            var apiInstance = new FirewallApi();
            var serverId = serverId_example;  // Guid? | Server id
            var firewallRule = new FirewallRule(); // FirewallRule | 

            try
            {
                // Create firewall rule
                apiInstance.ServerServerIdFirewallRulePost(serverId, firewallRule);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FirewallApi.ServerServerIdFirewallRulePost: " + e.Message );
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

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

