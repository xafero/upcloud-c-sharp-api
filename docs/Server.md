# IO.Swagger.Model.Server
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BootOrder** | **string** | The storage device boot order. | [optional] 
**CoreNumber** | **decimal?** | The number of CPU cores dedicated to the server. See List server configurations. | [optional] 
**Firewall** | **string** | The state of the server firewall rules. | [optional] [default to FirewallEnum.On]
**Host** | **decimal?** |  | [optional] 
**Hostname** | **string** | A valid hostname, e.g. host.example.com. The maximum length is 128 characters. | [optional] 
**IpAddresses** | [**InlineResponse2006IpAddresses**](InlineResponse2006IpAddresses.md) |  | [optional] 
**License** | **decimal?** |  | [optional] 
**MemoryAmount** | **decimal?** | The amount of main memory in megabytes. See List server configurations. | [optional] 
**NicModel** | **string** | The model of the server&#39;s network interfaces. | [optional] [default to "e1000"]
**Plan** | **string** | The pricing plan used. If a plan is selected, the core_number and  memory_amount must match the plan if they are present. | [optional] [default to "custom"]
**PlanIpv4Bytes** | **decimal?** |  | [optional] 
**PlanIpv6Bytes** | **decimal?** |  | [optional] 
**State** | [**ServerState**](ServerState.md) |  | [optional] 
**StorageDevices** | [**ServerStorageDevices**](ServerStorageDevices.md) |  | [optional] 
**Tags** | [**ServerTags**](ServerTags.md) |  | [optional] 
**Timezone** | [**Timezone**](Timezone.md) | A timezone identifier, e.g. Europe/Helsinki. See Timezones. | [optional] 
**Title** | **string** | A short description. | [optional] 
**Uuid** | **Guid?** |  | [optional] 
**VideoModel** | **string** | The model of the server&#39;s video interface. | [optional] [default to VideoModelEnum.Vga]
**Vnc** | **string** | The state of the VNC remote access service. | [optional] [default to VncEnum.Off]
**VncHost** | **string** |  | [optional] 
**VncPassword** | **string** | The VNC remote access password. | [optional] 
**VncPort** | **string** |  | [optional] 
**Zone** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

