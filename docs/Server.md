# Upcloud.Model.Server
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bootOrder** | **string** | The storage device boot order. | [optional] 
**coreNumber** | **decimal?** | The number of CPU cores dedicated to the server. See List server configurations. | [optional] 
**firewall** | **string** | The state of the server firewall rules. | [optional] [default to FirewallEnum.On]
**host** | **decimal?** |  | [optional] 
**hostname** | **string** | A valid hostname, e.g. host.example.com. The maximum length is 128 characters. | [optional] 
**ipAddresses** | [**IpAddresses**](IpAddresses.md) |  | [optional] 
**license** | **decimal?** |  | [optional] 
**memoryAmount** | **decimal?** | The amount of main memory in megabytes. See List server configurations. | [optional] 
**nicModel** | **string** | The model of the server&#39;s network interfaces. | [optional] [default to "e1000"]
**plan** | **string** | The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present. | [optional] [default to "custom"]
**planIpv4Bytes** | **decimal?** |  | [optional] 
**planIpv6Bytes** | **decimal?** |  | [optional] 
**state** | [**ServerState**](ServerState.md) |  | [optional] 
**storageDevices** | [**ServerStorageDevices**](ServerStorageDevices.md) |  | [optional] 
**tags** | [**ServerTags**](ServerTags.md) |  | [optional] 
**timezone** | **string** | A timezone identifier, e.g. Europe/Helsinki. See Timezones. | [optional] 
**title** | **string** | A short description. | [optional] 
**uuid** | **Guid?** |  | [optional] 
**videoModel** | **string** | The model of the server&#39;s video interface. | [optional] [default to VideoModelEnum.Vga]
**vnc** | **string** | The state of the VNC remote access service. | [optional] [default to VncEnum.Off]
**vncHost** | **string** |  | [optional] 
**vncPassword** | **string** | The VNC remote access password. | [optional] 
**vncPort** | **string** |  | [optional] 
**zone** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

