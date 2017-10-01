# Upcloud.Api.StorageApi

All URIs are relative to *https://api.upcloud.com/1.2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachStorage**](StorageApi.md#attachstorage) | **POST** /server/{serverId}/storage/attach | Attach storage
[**BackupStorage**](StorageApi.md#backupstorage) | **POST** /storage/{storageId}/backup | Create backup
[**CancelOperation**](StorageApi.md#canceloperation) | **POST** /storage/{storageId}/cancel | Cancel storage operation
[**CloneStorage**](StorageApi.md#clonestorage) | **POST** /storage/{storageId}/clone | Clone storage
[**CreateStorage**](StorageApi.md#createstorage) | **POST** /storage | Create storage
[**DeleteStorage**](StorageApi.md#deletestorage) | **DELETE** /storage/{storageId} | Delete storage
[**DetachStorage**](StorageApi.md#detachstorage) | **POST** /server/{serverId}/storage/detach | Detach storage
[**EjectCdrom**](StorageApi.md#ejectcdrom) | **POST** /server/{serverId}/cdrom/eject | Eject CD-ROM
[**FavoriteStorage**](StorageApi.md#favoritestorage) | **POST** /storage/{storageId}/favorite | Add storage to favorites
[**GetStorageDetails**](StorageApi.md#getstoragedetails) | **GET** /storage/{storageId} | Get storage details
[**ListStorageTypes**](StorageApi.md#liststoragetypes) | **GET** /storage/{type}/ | List of storages by type
[**ListStorages**](StorageApi.md#liststorages) | **GET** /storage | List of storages
[**LoadCdrom**](StorageApi.md#loadcdrom) | **POST** /server/{serverId}/storage/cdrom/load | Load CD-ROM
[**ModifyStorage**](StorageApi.md#modifystorage) | **PUT** /storage/{storageId} | Modify storage
[**RestoreStorage**](StorageApi.md#restorestorage) | **POST** /storage/{storageId}/restore | Restore backup
[**TemplatizeStorage**](StorageApi.md#templatizestorage) | **POST** /storage/{storageId}/templatize | Templatize storage
[**UnfavoriteStorage**](StorageApi.md#unfavoritestorage) | **DELETE** /storage/{storageId}/favorite | Remove storage from favorites


<a name="attachstorage"></a>
# **AttachStorage**
> CreateServerResponse AttachStorage (Guid? serverId, AttachStorageDeviceRequest storageDevice)

Attach storage

Attaches a storage as a device to a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class AttachStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new AttachStorageDeviceRequest(); // AttachStorageDeviceRequest | 

            try
            {
                // Attach storage
                CreateServerResponse result = apiInstance.AttachStorage(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.AttachStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**AttachStorageDeviceRequest**](AttachStorageDeviceRequest.md)|  | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="backupstorage"></a>
# **BackupStorage**
> CreateStorageResponse BackupStorage (Guid? storageId, CreateBackupStorageRequest storage = null)

Create backup

Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  `backup_rule` in Create storage or Modify storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class BackupStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id
            var storage = new CreateBackupStorageRequest(); // CreateBackupStorageRequest |  (optional) 

            try
            {
                // Create backup
                CreateStorageResponse result = apiInstance.BackupStorage(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.BackupStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 
 **storage** | [**CreateBackupStorageRequest**](CreateBackupStorageRequest.md)|  | [optional] 

### Return type

[**CreateStorageResponse**](CreateStorageResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceloperation"></a>
# **CancelOperation**
> void CancelOperation (Guid? storageId)

Cancel storage operation

Cancels a running cloning operation and deletes the incomplete copy.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class CancelOperationExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Strage id

            try
            {
                // Cancel storage operation
                apiInstance.CancelOperation(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CancelOperation: " + e.Message );
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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clonestorage"></a>
# **CloneStorage**
> CreateStorageResponse CloneStorage (Guid? storageId, CloneStorageRequest storage = null)

Clone storage

Creates an exact copy of an existing storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class CloneStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id
            var storage = new CloneStorageRequest(); // CloneStorageRequest |  (optional) 

            try
            {
                // Clone storage
                CreateStorageResponse result = apiInstance.CloneStorage(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CloneStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 
 **storage** | [**CloneStorageRequest**](CloneStorageRequest.md)|  | [optional] 

### Return type

[**CreateStorageResponse**](CreateStorageResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstorage"></a>
# **CreateStorage**
> CreateStorageResponse CreateStorage (CreateStorageRequest storage)

Create storage

Creates a new storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class CreateStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storage = new CreateStorageRequest(); // CreateStorageRequest | 

            try
            {
                // Create storage
                CreateStorageResponse result = apiInstance.CreateStorage(storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CreateStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storage** | [**CreateStorageRequest**](CreateStorageRequest.md)|  | 

### Return type

[**CreateStorageResponse**](CreateStorageResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestorage"></a>
# **DeleteStorage**
> void DeleteStorage (Guid? storageId)

Delete storage

Deleted an existing storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DeleteStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | 

            try
            {
                // Delete storage
                apiInstance.DeleteStorage(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteStorage: " + e.Message );
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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachstorage"></a>
# **DetachStorage**
> CreateServerResponse DetachStorage (Guid? serverId, StorageDeviceDetachRequest storageDevice)

Detach storage

Detaches a storage resource from a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class DetachStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDeviceDetachRequest(); // StorageDeviceDetachRequest | 

            try
            {
                // Detach storage
                CreateServerResponse result = apiInstance.DetachStorage(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DetachStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDeviceDetachRequest**](StorageDeviceDetachRequest.md)|  | 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ejectcdrom"></a>
# **EjectCdrom**
> void EjectCdrom (Guid? serverId)

Eject CD-ROM

Ejects the storage from the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class EjectCdromExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id

            try
            {
                // Eject CD-ROM
                apiInstance.EjectCdrom(serverId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.EjectCdrom: " + e.Message );
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

void (empty response body)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="favoritestorage"></a>
# **FavoriteStorage**
> void FavoriteStorage (Guid? storageId)

Add storage to favorites

Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class FavoriteStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id

            try
            {
                // Add storage to favorites
                apiInstance.FavoriteStorage(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.FavoriteStorage: " + e.Message );
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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoragedetails"></a>
# **GetStorageDetails**
> CreateStorageResponse GetStorageDetails (Guid? storageId)

Get storage details

Returns detailed information about a specific storage resource.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class GetStorageDetailsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | 

            try
            {
                // Get storage details
                CreateStorageResponse result = apiInstance.GetStorageDetails(storageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetStorageDetails: " + e.Message );
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

[**CreateStorageResponse**](CreateStorageResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststoragetypes"></a>
# **ListStorageTypes**
> SuccessStoragesResponse ListStorageTypes (string type)

List of storages by type

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListStorageTypesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var type = type_example;  // string | Storage's access type (`public` or `private`) or storage type (`normal`, `backup`, `cdrom` or `template`) or `favorite` status

            try
            {
                // List of storages by type
                SuccessStoragesResponse result = apiInstance.ListStorageTypes(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListStorageTypes: " + e.Message );
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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststorages"></a>
# **ListStorages**
> SuccessStoragesResponse ListStorages ()

List of storages

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ListStoragesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loadcdrom"></a>
# **LoadCdrom**
> CreateServerResponse LoadCdrom (Guid? serverId, StorageDeviceLoadRequest storageDevice = null)

Load CD-ROM

Loads a storage as a CD-ROM in the CD-ROM device of a server.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class LoadCdromExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var serverId = serverId_example;  // Guid? | Server id
            var storageDevice = new StorageDeviceLoadRequest(); // StorageDeviceLoadRequest |  (optional) 

            try
            {
                // Load CD-ROM
                CreateServerResponse result = apiInstance.LoadCdrom(serverId, storageDevice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.LoadCdrom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serverId** | **Guid?**| Server id | 
 **storageDevice** | [**StorageDeviceLoadRequest**](StorageDeviceLoadRequest.md)|  | [optional] 

### Return type

[**CreateServerResponse**](CreateServerResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifystorage"></a>
# **ModifyStorage**
> CreateStorageResponse ModifyStorage (Guid? storageId, ModifyStorageRequest storage)

Modify storage

Modifies an existing storage resource. This operation is used to rename or resize the storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class ModifyStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | 
            var storage = new ModifyStorageRequest(); // ModifyStorageRequest | 

            try
            {
                // Modify storage
                CreateStorageResponse result = apiInstance.ModifyStorage(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ModifyStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**|  | 
 **storage** | [**ModifyStorageRequest**](ModifyStorageRequest.md)|  | 

### Return type

[**CreateStorageResponse**](CreateStorageResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restorestorage"></a>
# **RestoreStorage**
> void RestoreStorage (Guid? storageId)

Restore backup

Restores the origin storage with data from the specified backup storage.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class RestoreStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id

            try
            {
                // Restore backup
                apiInstance.RestoreStorage(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.RestoreStorage: " + e.Message );
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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatizestorage"></a>
# **TemplatizeStorage**
> CreateStorageResponse TemplatizeStorage (Guid? storageId, TemplitizeStorageRequest storage = null)

Templatize storage

Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class TemplatizeStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id
            var storage = new TemplitizeStorageRequest(); // TemplitizeStorageRequest |  (optional) 

            try
            {
                // Templatize storage
                CreateStorageResponse result = apiInstance.TemplatizeStorage(storageId, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.TemplatizeStorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageId** | **Guid?**| Storage id | 
 **storage** | [**TemplitizeStorageRequest**](TemplitizeStorageRequest.md)|  | [optional] 

### Return type

[**CreateStorageResponse**](CreateStorageResponse.md)

### Authorization

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unfavoritestorage"></a>
# **UnfavoriteStorage**
> void UnfavoriteStorage (Guid? storageId)

Remove storage from favorites

Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.

### Example
```csharp
using System;
using System.Diagnostics;
using Upcloud.Api;
using Upcloud.Client;
using Upcloud.Model;

namespace Example
{
    public class UnfavoriteStorageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: baseAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StorageApi();
            var storageId = storageId_example;  // Guid? | Storage id

            try
            {
                // Remove storage from favorites
                apiInstance.UnfavoriteStorage(storageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.UnfavoriteStorage: " + e.Message );
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

[baseAuth](../README.md#baseAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

