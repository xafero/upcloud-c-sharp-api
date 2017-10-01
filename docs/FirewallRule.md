# Upcloud.Model.FirewallRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Direction** | **string** | The direction of network traffic this rule will be applied to. | 
**Action** | **string** | Action to take if the rule conditions are met. | 
**Position** | **decimal?** | Add the firewall rule to this position in the server&#39;s firewall list. | [optional] 
**Family** | [**AddressFamily**](AddressFamily.md) | if protocol is set The address family of new firewall rule | 
**Protocol** | **string** | The protocol this rule will be applied to. | [optional] 
**IcmpType** | **string** | The ICMP type. | [optional] 
**DestinationAddressStart** | **string** | The destination address range starts from this address. | [optional] 
**DestinationAddressEnd** | **string** | The destination address range ends to this address. | [optional] 
**DestinationPortStart** | **decimal?** | The destination port range starts from this port number. | [optional] 
**DestinationPortEnd** | **decimal?** | The destination port range ends to this port number. | [optional] 
**SourceAddressStart** | **string** | The source address range starts from this address. | [optional] 
**SourceAddressEnd** | **string** | The source address range ends to this address. | [optional] 
**SourcePortStart** | **decimal?** | The source port range starts from this port number. | [optional] 
**SourcePortEnd** | **decimal?** | The source port range ends to this port number. | [optional] 
**Comment** | **string** | Freeform comment string for the rule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

