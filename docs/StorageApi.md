# IO.Swagger.Api.StorageApi

All URIs are relative to *http://localhost/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListStorages**](StorageApi.md#liststorages) | **GET** /storage | List of storages
[**ListStorages_0**](StorageApi.md#liststorages_0) | **GET** /storage/{type} | List of storages by type
[**ServerServerIdStorageAttachPost**](StorageApi.md#serverserveridstorageattachpost) | **POST** /server/{serverId}/storage/attach | Attach storage
[**ServerServerIdStorageCdromEjectPost**](StorageApi.md#serverserveridstoragecdromejectpost) | **POST** /server/{serverId}/storage/cdrom/eject | Eject CD-ROM
[**ServerServerIdStorageCdromLoadPost**](StorageApi.md#serverserveridstoragecdromloadpost) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
[**ServerServerIdStorageDetachPost**](StorageApi.md#serverserveridstoragedetachpost) | **POST** /server/{serverId}/storage/detach | Detach storage
[**StoragePost**](StorageApi.md#storagepost) | **POST** /storage | Create storage
[**StorageStorageIdBackupPost**](StorageApi.md#storagestorageidbackuppost) | **POST** /storage/{storageId}/backup | Create backup
[**StorageStorageIdCancelPost**](StorageApi.md#storagestorageidcancelpost) | **POST** /storage/{storageId}/cancel | Cancel storage operation
[**StorageStorageIdClonePost**](StorageApi.md#storagestorageidclonepost) | **POST** /storage/{storageId}/clone | Clone storage
[**StorageStorageIdDelete**](StorageApi.md#storagestorageiddelete) | **DELETE** /storage/{storageId} | Delete storage
[**StorageStorageIdFavoriteDelete**](StorageApi.md#storagestorageidfavoritedelete) | **DELETE** /storage/{storageId}/favorite | Remove storage from favorites
[**StorageStorageIdFavoritePost**](StorageApi.md#storagestorageidfavoritepost) | **POST** /storage/{storageId}/favorite | Add storage to favorites
[**StorageStorageIdGet**](StorageApi.md#storagestorageidget) | **GET** /storage/{storageId} | Get storage details
[**StorageStorageIdPut**](StorageApi.md#storagestorageidput) | **PUT** /storage/{storageId} | Modify storage
[**StorageStorageIdRestorePost**](StorageApi.md#storagestorageidrestorepost) | **POST** /storage/{storageId}/restore | Restore backup
[**StorageStorageIdTemplatizePost**](StorageApi.md#storagestorageidtemplatizepost) | **POST** /storage/{storageId}/templatize | Templatize storage


<a name="liststorages"></a>
# **ListStorages**
> SuccessStoragesResponse ListStorages ()

List of storages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListStoragesExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();

            try
            {
                // List of storages
                SuccessStoragesResponse result = apiInstance.ListStorages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListStorages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SuccessStoragesResponse**](SuccessStoragesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststorages_0"></a>
# **ListStorages_0**
> SuccessStoragesResponse ListStorages_0 (string type)

List of storages by type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListStorages_0Example
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var type = type_example;  // string | Storage's access type (`public` or `private`) or storage type (`normal`, `backup`, `cdrom` or `template`) or `favorite` status

            try
            {
                // List of storages by type
                SuccessStoragesResponse result = apiInstance.ListStorages_0(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListStorages_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status | 

### Return type

[**SuccessStoragesResponse**](SuccessStoragesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstorageattachpost"></a>
# **ServerServerIdStorageAttachPost**
> ServerListResponse ServerServerIdStorageAttachPost (Guid? serverId, StorageDevice storageDevice)

Attach storage

Attaches a storage as a device to a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageAttachPostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDevice(); // StorageDevice | 

            try
            {
                // Attach storage
                ServerListResponse result = apiInstance.ServerServerIdStorageAttachPost(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ServerServerIdStorageAttachPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDevice**](StorageDevice.md)|  | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoragecdromejectpost"></a>
# **ServerServerIdStorageCdromEjectPost**
> ServerListResponse ServerServerIdStorageCdromEjectPost (Guid? serverId)

Eject CD-ROM

Ejects the storage from the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageCdromEjectPostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // Eject CD-ROM
                ServerListResponse result = apiInstance.ServerServerIdStorageCdromEjectPost(serverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ServerServerIdStorageCdromEjectPost: " + e.Message );
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

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoragecdromloadpost"></a>
# **ServerServerIdStorageCdromLoadPost**
> ServerListResponse ServerServerIdStorageCdromLoadPost (Guid? serverId, StorageDevice1 storageDevice = null)

Load CD-ROM

Loads a storage as a CD-ROM in the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageCdromLoadPostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDevice1(); // StorageDevice1 |  (optional) 

            try
            {
                // Load CD-ROM
                ServerListResponse result = apiInstance.ServerServerIdStorageCdromLoadPost(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ServerServerIdStorageCdromLoadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDevice1**](StorageDevice1.md)|  | [optional] 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverserveridstoragedetachpost"></a>
# **ServerServerIdStorageDetachPost**
> ServerListResponse ServerServerIdStorageDetachPost (Guid? serverId, StorageDevice storageDevice)

Detach storage

Detaches a storage resource from a server.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerServerIdStorageDetachPostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDevice(); // StorageDevice | 

            try
            {
                // Detach storage
                ServerListResponse result = apiInstance.ServerServerIdStorageDetachPost(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ServerServerIdStorageDetachPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDevice**](StorageDevice.md)|  | 

### Return type

[**ServerListResponse**](ServerListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagepost"></a>
# **StoragePost**
> InlineResponse201 StoragePost (Storage storage)

Create storage

Creates a new storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoragePostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storage = new Storage(); // Storage | 

            try
            {
                // Create storage
                InlineResponse201 result = apiInstance.StoragePost(storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StoragePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storage** | [**Storage**](Storage.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidbackuppost"></a>
# **StorageStorageIdBackupPost**
> InlineResponse201 StorageStorageIdBackupPost (Guid? storageId, Storage4 storage = null)

Create backup

Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  `backup_rule` in Create storage or Modify storage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdBackupPostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id
            var storage = new Storage4(); // Storage4 |  (optional) 

            try
            {
                // Create backup
                InlineResponse201 result = apiInstance.StorageStorageIdBackupPost(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdBackupPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 
 **storage** | [**Storage4**](Storage4.md)|  | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidcancelpost"></a>
# **StorageStorageIdCancelPost**
> void StorageStorageIdCancelPost (Guid? storageId)

Cancel storage operation

Cancels a running cloning operation and deletes the incomplete copy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdCancelPostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Strage id

            try
            {
                // Cancel storage operation
                apiInstance.StorageStorageIdCancelPost(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Strage id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidclonepost"></a>
# **StorageStorageIdClonePost**
> InlineResponse201 StorageStorageIdClonePost (Guid? storageId, Storage2 storage = null)

Clone storage

Creates an exact copy of an existing storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdClonePostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id
            var storage = new Storage2(); // Storage2 |  (optional) 

            try
            {
                // Clone storage
                InlineResponse201 result = apiInstance.StorageStorageIdClonePost(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdClonePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 
 **storage** | [**Storage2**](Storage2.md)|  | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageiddelete"></a>
# **StorageStorageIdDelete**
> void StorageStorageIdDelete (Guid? storageId)

Delete storage

Deleted an existing storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | 

            try
            {
                // Delete storage
                apiInstance.StorageStorageIdDelete(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidfavoritedelete"></a>
# **StorageStorageIdFavoriteDelete**
> void StorageStorageIdFavoriteDelete (Guid? storageId)

Remove storage from favorites

Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdFavoriteDeleteExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id

            try
            {
                // Remove storage from favorites
                apiInstance.StorageStorageIdFavoriteDelete(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdFavoriteDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidfavoritepost"></a>
# **StorageStorageIdFavoritePost**
> void StorageStorageIdFavoritePost (Guid? storageId)

Add storage to favorites

Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdFavoritePostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id

            try
            {
                // Add storage to favorites
                apiInstance.StorageStorageIdFavoritePost(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdFavoritePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidget"></a>
# **StorageStorageIdGet**
> InlineResponse201 StorageStorageIdGet (Guid? storageId)

Get storage details

Returns detailed information about a specific storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdGetExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | 

            try
            {
                // Get storage details
                InlineResponse201 result = apiInstance.StorageStorageIdGet(storageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidput"></a>
# **StorageStorageIdPut**
> InlineResponse201 StorageStorageIdPut (Guid? storageId, Storage1 storage)

Modify storage

Modifies an existing storage resource. This operation is used to rename or resize the storage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdPutExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | 
            var storage = new Storage1(); // Storage1 | 

            try
            {
                // Modify storage
                InlineResponse201 result = apiInstance.StorageStorageIdPut(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**|  | 
 **storage** | [**Storage1**](Storage1.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidrestorepost"></a>
# **StorageStorageIdRestorePost**
> void StorageStorageIdRestorePost (Guid? storageId)

Restore backup

Restores the origin storage with data from the specified backup storage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdRestorePostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id

            try
            {
                // Restore backup
                apiInstance.StorageStorageIdRestorePost(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdRestorePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storagestorageidtemplatizepost"></a>
# **StorageStorageIdTemplatizePost**
> InlineResponse201 StorageStorageIdTemplatizePost (Guid? storageId, Storage3 storage = null)

Templatize storage

Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorageStorageIdTemplatizePostExample
    {
        public void main()
        {
            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id
            var storage = new Storage3(); // Storage3 |  (optional) 

            try
            {
                // Templatize storage
                InlineResponse201 result = apiInstance.StorageStorageIdTemplatizePost(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStorageIdTemplatizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 
 **storage** | [**Storage3**](Storage3.md)|  | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

