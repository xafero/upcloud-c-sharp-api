# Upcloud.Model.FirewallRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**direction** | **string** | The direction of network traffic this rule will be applied to. | 
**action** | **string** | Action to take if the rule conditions are met. | 
**position** | **decimal?** | Add the firewall rule to this position in the server&#39;s firewall list. | [optional] 
**family** | [**AddressFamily**](AddressFamily.md) | if protocol is set The address family of new firewall rule | 
**protocol** | **string** | The protocol this rule will be applied to. | [optional] 
**icmpType** | **string** | The ICMP type. | [optional] 
**destinationAddressStart** | **string** | The destination address range starts from this address. | [optional] 
**destinationAddressEnd** | **string** | The destination address range ends to this address. | [optional] 
**destinationPortStart** | **decimal?** | The destination port range starts from this port number. | [optional] 
**destinationPortEnd** | **decimal?** | The destination port range ends to this port number. | [optional] 
**sourceAddressStart** | **string** | The source address range starts from this address. | [optional] 
**sourceAddressEnd** | **string** | The source address range ends to this address. | [optional] 
**sourcePortStart** | **decimal?** | The source port range starts from this port number. | [optional] 
**sourcePortEnd** | **decimal?** | The source port range ends to this port number. | [optional] 
**comment** | **string** | Freeform comment string for the rule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

