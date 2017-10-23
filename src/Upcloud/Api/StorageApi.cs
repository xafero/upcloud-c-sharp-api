/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Upcloud.Client;
using Upcloud.Model;

namespace Upcloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStorageApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse AttachStorage (Guid? serverId, AttachStorageDeviceRequest storageDevice);

        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> AttachStorageWithHttpInfo (Guid? serverId, AttachStorageDeviceRequest storageDevice);
        /// <summary>
        /// Create backup
        /// </summary>
        /// <remarks>
        /// Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        CreateStorageResponse BackupStorage (Guid? storageId, CreateBackupStorageRequest storage);

        /// <summary>
        /// Create backup
        /// </summary>
        /// <remarks>
        /// Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        ApiResponse<CreateStorageResponse> BackupStorageWithHttpInfo (Guid? storageId, CreateBackupStorageRequest storage);
        /// <summary>
        /// Cancel storage operation
        /// </summary>
        /// <remarks>
        /// Cancels a running cloning operation and deletes the incomplete copy.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns></returns>
        void CancelOperation (Guid? storageId);

        /// <summary>
        /// Cancel storage operation
        /// </summary>
        /// <remarks>
        /// Cancels a running cloning operation and deletes the incomplete copy.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CancelOperationWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Clone storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        CreateStorageResponse CloneStorage (Guid? storageId, CloneStorageRequest storage);

        /// <summary>
        /// Clone storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        ApiResponse<CreateStorageResponse> CloneStorageWithHttpInfo (Guid? storageId, CloneStorageRequest storage);
        /// <summary>
        /// Create storage
        /// </summary>
        /// <remarks>
        /// Creates a new storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        CreateStorageResponse CreateStorage (CreateStorageRequest storage);

        /// <summary>
        /// Create storage
        /// </summary>
        /// <remarks>
        /// Creates a new storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        ApiResponse<CreateStorageResponse> CreateStorageWithHttpInfo (CreateStorageRequest storage);
        /// <summary>
        /// Delete storage
        /// </summary>
        /// <remarks>
        /// Deleted an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns></returns>
        void DeleteStorage (Guid? storageId);

        /// <summary>
        /// Delete storage
        /// </summary>
        /// <remarks>
        /// Deleted an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteStorageWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse DetachStorage (Guid? serverId, StorageDeviceDetachRequest storageDevice);

        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> DetachStorageWithHttpInfo (Guid? serverId, StorageDeviceDetachRequest storageDevice);
        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns></returns>
        void EjectCdrom (Guid? serverId);

        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> EjectCdromWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Add storage to favorites
        /// </summary>
        /// <remarks>
        /// Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns></returns>
        void FavoriteStorage (Guid? storageId);

        /// <summary>
        /// Add storage to favorites
        /// </summary>
        /// <remarks>
        /// Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FavoriteStorageWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Get storage details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>CreateStorageResponse</returns>
        CreateStorageResponse GetStorageDetails (Guid? storageId);

        /// <summary>
        /// Get storage details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        ApiResponse<CreateStorageResponse> GetStorageDetailsWithHttpInfo (Guid? storageId);
        /// <summary>
        /// List of storages by type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>SuccessStoragesResponse</returns>
        SuccessStoragesResponse ListStorageTypes (string type);

        /// <summary>
        /// List of storages by type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>ApiResponse of SuccessStoragesResponse</returns>
        ApiResponse<SuccessStoragesResponse> ListStorageTypesWithHttpInfo (string type);
        /// <summary>
        /// List of storages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SuccessStoragesResponse</returns>
        SuccessStoragesResponse ListStorages ();

        /// <summary>
        /// List of storages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SuccessStoragesResponse</returns>
        ApiResponse<SuccessStoragesResponse> ListStoragesWithHttpInfo ();
        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse LoadCdrom (Guid? serverId, StorageDeviceLoadRequest storageDevice = null);

        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> LoadCdromWithHttpInfo (Guid? serverId, StorageDeviceLoadRequest storageDevice = null);
        /// <summary>
        /// Modify storage
        /// </summary>
        /// <remarks>
        /// Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        CreateStorageResponse ModifyStorage (Guid? storageId, ModifyStorageRequest storage);

        /// <summary>
        /// Modify storage
        /// </summary>
        /// <remarks>
        /// Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        ApiResponse<CreateStorageResponse> ModifyStorageWithHttpInfo (Guid? storageId, ModifyStorageRequest storage);
        /// <summary>
        /// Restore backup
        /// </summary>
        /// <remarks>
        /// Restores the origin storage with data from the specified backup storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns></returns>
        void RestoreStorage (Guid? storageId);

        /// <summary>
        /// Restore backup
        /// </summary>
        /// <remarks>
        /// Restores the origin storage with data from the specified backup storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RestoreStorageWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Templatize storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>CreateStorageResponse</returns>
        CreateStorageResponse TemplatizeStorage (Guid? storageId, TemplitizeStorageRequest storage = null);

        /// <summary>
        /// Templatize storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        ApiResponse<CreateStorageResponse> TemplatizeStorageWithHttpInfo (Guid? storageId, TemplitizeStorageRequest storage = null);
        /// <summary>
        /// Remove storage from favorites
        /// </summary>
        /// <remarks>
        /// Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns></returns>
        void UnfavoriteStorage (Guid? storageId);

        /// <summary>
        /// Remove storage from favorites
        /// </summary>
        /// <remarks>
        /// Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnfavoriteStorageWithHttpInfo (Guid? storageId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> AttachStorageAsync (Guid? serverId, AttachStorageDeviceRequest storageDevice);

        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> AttachStorageAsyncWithHttpInfo (Guid? serverId, AttachStorageDeviceRequest storageDevice);
        /// <summary>
        /// Create backup
        /// </summary>
        /// <remarks>
        /// Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        System.Threading.Tasks.Task<CreateStorageResponse> BackupStorageAsync (Guid? storageId, CreateBackupStorageRequest storage);

        /// <summary>
        /// Create backup
        /// </summary>
        /// <remarks>
        /// Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> BackupStorageAsyncWithHttpInfo (Guid? storageId, CreateBackupStorageRequest storage);
        /// <summary>
        /// Cancel storage operation
        /// </summary>
        /// <remarks>
        /// Cancels a running cloning operation and deletes the incomplete copy.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CancelOperationAsync (Guid? storageId);

        /// <summary>
        /// Cancel storage operation
        /// </summary>
        /// <remarks>
        /// Cancels a running cloning operation and deletes the incomplete copy.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CancelOperationAsyncWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Clone storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        System.Threading.Tasks.Task<CreateStorageResponse> CloneStorageAsync (Guid? storageId, CloneStorageRequest storage);

        /// <summary>
        /// Clone storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> CloneStorageAsyncWithHttpInfo (Guid? storageId, CloneStorageRequest storage);
        /// <summary>
        /// Create storage
        /// </summary>
        /// <remarks>
        /// Creates a new storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        System.Threading.Tasks.Task<CreateStorageResponse> CreateStorageAsync (CreateStorageRequest storage);

        /// <summary>
        /// Create storage
        /// </summary>
        /// <remarks>
        /// Creates a new storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> CreateStorageAsyncWithHttpInfo (CreateStorageRequest storage);
        /// <summary>
        /// Delete storage
        /// </summary>
        /// <remarks>
        /// Deleted an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteStorageAsync (Guid? storageId);

        /// <summary>
        /// Delete storage
        /// </summary>
        /// <remarks>
        /// Deleted an existing storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStorageAsyncWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> DetachStorageAsync (Guid? serverId, StorageDeviceDetachRequest storageDevice);

        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> DetachStorageAsyncWithHttpInfo (Guid? serverId, StorageDeviceDetachRequest storageDevice);
        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task EjectCdromAsync (Guid? serverId);

        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EjectCdromAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Add storage to favorites
        /// </summary>
        /// <remarks>
        /// Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FavoriteStorageAsync (Guid? storageId);

        /// <summary>
        /// Add storage to favorites
        /// </summary>
        /// <remarks>
        /// Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FavoriteStorageAsyncWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Get storage details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        System.Threading.Tasks.Task<CreateStorageResponse> GetStorageDetailsAsync (Guid? storageId);

        /// <summary>
        /// Get storage details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific storage resource.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> GetStorageDetailsAsyncWithHttpInfo (Guid? storageId);
        /// <summary>
        /// List of storages by type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>Task of SuccessStoragesResponse</returns>
        System.Threading.Tasks.Task<SuccessStoragesResponse> ListStorageTypesAsync (string type);

        /// <summary>
        /// List of storages by type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>Task of ApiResponse (SuccessStoragesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessStoragesResponse>> ListStorageTypesAsyncWithHttpInfo (string type);
        /// <summary>
        /// List of storages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SuccessStoragesResponse</returns>
        System.Threading.Tasks.Task<SuccessStoragesResponse> ListStoragesAsync ();

        /// <summary>
        /// List of storages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SuccessStoragesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessStoragesResponse>> ListStoragesAsyncWithHttpInfo ();
        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> LoadCdromAsync (Guid? serverId, StorageDeviceLoadRequest storageDevice = null);

        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> LoadCdromAsyncWithHttpInfo (Guid? serverId, StorageDeviceLoadRequest storageDevice = null);
        /// <summary>
        /// Modify storage
        /// </summary>
        /// <remarks>
        /// Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        System.Threading.Tasks.Task<CreateStorageResponse> ModifyStorageAsync (Guid? storageId, ModifyStorageRequest storage);

        /// <summary>
        /// Modify storage
        /// </summary>
        /// <remarks>
        /// Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> ModifyStorageAsyncWithHttpInfo (Guid? storageId, ModifyStorageRequest storage);
        /// <summary>
        /// Restore backup
        /// </summary>
        /// <remarks>
        /// Restores the origin storage with data from the specified backup storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RestoreStorageAsync (Guid? storageId);

        /// <summary>
        /// Restore backup
        /// </summary>
        /// <remarks>
        /// Restores the origin storage with data from the specified backup storage.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RestoreStorageAsyncWithHttpInfo (Guid? storageId);
        /// <summary>
        /// Templatize storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>Task of CreateStorageResponse</returns>
        System.Threading.Tasks.Task<CreateStorageResponse> TemplatizeStorageAsync (Guid? storageId, TemplitizeStorageRequest storage = null);

        /// <summary>
        /// Templatize storage
        /// </summary>
        /// <remarks>
        /// Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> TemplatizeStorageAsyncWithHttpInfo (Guid? storageId, TemplitizeStorageRequest storage = null);
        /// <summary>
        /// Remove storage from favorites
        /// </summary>
        /// <remarks>
        /// Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UnfavoriteStorageAsync (Guid? storageId);

        /// <summary>
        /// Remove storage from favorites
        /// </summary>
        /// <remarks>
        /// Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UnfavoriteStorageAsyncWithHttpInfo (Guid? storageId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StorageApi : IStorageApi
    {
        private Upcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StorageApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Upcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StorageApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Upcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Upcloud.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse AttachStorage (Guid? serverId, AttachStorageDeviceRequest storageDevice)
        {
             ApiResponse<CreateServerResponse> localVarResponse = AttachStorageWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > AttachStorageWithHttpInfo (Guid? serverId, AttachStorageDeviceRequest storageDevice)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->AttachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling StorageApi->AttachStorage");

            var localVarPath = "/server/{serverId}/storage/attach";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (storageDevice != null && storageDevice.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storageDevice); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storageDevice; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AttachStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> AttachStorageAsync (Guid? serverId, AttachStorageDeviceRequest storageDevice)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await AttachStorageAsyncWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> AttachStorageAsyncWithHttpInfo (Guid? serverId, AttachStorageDeviceRequest storageDevice)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->AttachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling StorageApi->AttachStorage");

            var localVarPath = "/server/{serverId}/storage/attach";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (storageDevice != null && storageDevice.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storageDevice); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storageDevice; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AttachStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Create backup Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        public CreateStorageResponse BackupStorage (Guid? storageId, CreateBackupStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = BackupStorageWithHttpInfo(storageId, storage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create backup Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        public ApiResponse< CreateStorageResponse > BackupStorageWithHttpInfo (Guid? storageId, CreateBackupStorageRequest storage)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->BackupStorage");
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->BackupStorage");

            var localVarPath = "/storage/{storageId}/backup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BackupStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Create backup Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        public async System.Threading.Tasks.Task<CreateStorageResponse> BackupStorageAsync (Guid? storageId, CreateBackupStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = await BackupStorageAsyncWithHttpInfo(storageId, storage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create backup Creates a point-in-time backup of a storage resource. For automatic, scheduled backups, see  &#x60;backup_rule&#x60; in Create storage or Modify storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> BackupStorageAsyncWithHttpInfo (Guid? storageId, CreateBackupStorageRequest storage)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->BackupStorage");
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->BackupStorage");

            var localVarPath = "/storage/{storageId}/backup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BackupStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Cancel storage operation Cancels a running cloning operation and deletes the incomplete copy.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns></returns>
        public void CancelOperation (Guid? storageId)
        {
             CancelOperationWithHttpInfo(storageId);
        }

        /// <summary>
        /// Cancel storage operation Cancels a running cloning operation and deletes the incomplete copy.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CancelOperationWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->CancelOperation");

            var localVarPath = "/storage/{storageId}/cancel";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelOperation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Cancel storage operation Cancels a running cloning operation and deletes the incomplete copy.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CancelOperationAsync (Guid? storageId)
        {
             await CancelOperationAsyncWithHttpInfo(storageId);

        }

        /// <summary>
        /// Cancel storage operation Cancels a running cloning operation and deletes the incomplete copy.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Strage id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CancelOperationAsyncWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->CancelOperation");

            var localVarPath = "/storage/{storageId}/cancel";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelOperation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Clone storage Creates an exact copy of an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        public CreateStorageResponse CloneStorage (Guid? storageId, CloneStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = CloneStorageWithHttpInfo(storageId, storage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clone storage Creates an exact copy of an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        public ApiResponse< CreateStorageResponse > CloneStorageWithHttpInfo (Guid? storageId, CloneStorageRequest storage)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->CloneStorage");
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->CloneStorage");

            var localVarPath = "/storage/{storageId}/clone";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CloneStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Clone storage Creates an exact copy of an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        public async System.Threading.Tasks.Task<CreateStorageResponse> CloneStorageAsync (Guid? storageId, CloneStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = await CloneStorageAsyncWithHttpInfo(storageId, storage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clone storage Creates an exact copy of an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> CloneStorageAsyncWithHttpInfo (Guid? storageId, CloneStorageRequest storage)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->CloneStorage");
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->CloneStorage");

            var localVarPath = "/storage/{storageId}/clone";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CloneStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Create storage Creates a new storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        public CreateStorageResponse CreateStorage (CreateStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = CreateStorageWithHttpInfo(storage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create storage Creates a new storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        public ApiResponse< CreateStorageResponse > CreateStorageWithHttpInfo (CreateStorageRequest storage)
        {
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->CreateStorage");

            var localVarPath = "/storage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Create storage Creates a new storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        public async System.Threading.Tasks.Task<CreateStorageResponse> CreateStorageAsync (CreateStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = await CreateStorageAsyncWithHttpInfo(storage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create storage Creates a new storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> CreateStorageAsyncWithHttpInfo (CreateStorageRequest storage)
        {
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->CreateStorage");

            var localVarPath = "/storage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Delete storage Deleted an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns></returns>
        public void DeleteStorage (Guid? storageId)
        {
             DeleteStorageWithHttpInfo(storageId);
        }

        /// <summary>
        /// Delete storage Deleted an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteStorageWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->DeleteStorage");

            var localVarPath = "/storage/{storageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete storage Deleted an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteStorageAsync (Guid? storageId)
        {
             await DeleteStorageAsyncWithHttpInfo(storageId);

        }

        /// <summary>
        /// Delete storage Deleted an existing storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStorageAsyncWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->DeleteStorage");

            var localVarPath = "/storage/{storageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse DetachStorage (Guid? serverId, StorageDeviceDetachRequest storageDevice)
        {
             ApiResponse<CreateServerResponse> localVarResponse = DetachStorageWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > DetachStorageWithHttpInfo (Guid? serverId, StorageDeviceDetachRequest storageDevice)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->DetachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling StorageApi->DetachStorage");

            var localVarPath = "/server/{serverId}/storage/detach";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (storageDevice != null && storageDevice.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storageDevice); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storageDevice; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DetachStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> DetachStorageAsync (Guid? serverId, StorageDeviceDetachRequest storageDevice)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await DetachStorageAsyncWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> DetachStorageAsyncWithHttpInfo (Guid? serverId, StorageDeviceDetachRequest storageDevice)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->DetachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling StorageApi->DetachStorage");

            var localVarPath = "/server/{serverId}/storage/detach";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (storageDevice != null && storageDevice.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storageDevice); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storageDevice; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DetachStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns></returns>
        public void EjectCdrom (Guid? serverId)
        {
             EjectCdromWithHttpInfo(serverId);
        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> EjectCdromWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->EjectCdrom");

            var localVarPath = "/server/{serverId}/cdrom/eject";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EjectCdrom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task EjectCdromAsync (Guid? serverId)
        {
             await EjectCdromAsyncWithHttpInfo(serverId);

        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EjectCdromAsyncWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->EjectCdrom");

            var localVarPath = "/server/{serverId}/cdrom/eject";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EjectCdrom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add storage to favorites Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns></returns>
        public void FavoriteStorage (Guid? storageId)
        {
             FavoriteStorageWithHttpInfo(storageId);
        }

        /// <summary>
        /// Add storage to favorites Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FavoriteStorageWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->FavoriteStorage");

            var localVarPath = "/storage/{storageId}/favorite";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FavoriteStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add storage to favorites Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task FavoriteStorageAsync (Guid? storageId)
        {
             await FavoriteStorageAsyncWithHttpInfo(storageId);

        }

        /// <summary>
        /// Add storage to favorites Adds a storage to the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> FavoriteStorageAsyncWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->FavoriteStorage");

            var localVarPath = "/storage/{storageId}/favorite";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FavoriteStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get storage details Returns detailed information about a specific storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>CreateStorageResponse</returns>
        public CreateStorageResponse GetStorageDetails (Guid? storageId)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = GetStorageDetailsWithHttpInfo(storageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get storage details Returns detailed information about a specific storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        public ApiResponse< CreateStorageResponse > GetStorageDetailsWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->GetStorageDetails");

            var localVarPath = "/storage/{storageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStorageDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Get storage details Returns detailed information about a specific storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        public async System.Threading.Tasks.Task<CreateStorageResponse> GetStorageDetailsAsync (Guid? storageId)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = await GetStorageDetailsAsyncWithHttpInfo(storageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get storage details Returns detailed information about a specific storage resource.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> GetStorageDetailsAsyncWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->GetStorageDetails");

            var localVarPath = "/storage/{storageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStorageDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// List of storages by type 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>SuccessStoragesResponse</returns>
        public SuccessStoragesResponse ListStorageTypes (string type)
        {
             ApiResponse<SuccessStoragesResponse> localVarResponse = ListStorageTypesWithHttpInfo(type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of storages by type 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>ApiResponse of SuccessStoragesResponse</returns>
        public ApiResponse< SuccessStoragesResponse > ListStorageTypesWithHttpInfo (string type)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling StorageApi->ListStorageTypes");

            var localVarPath = "/storage/{type}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (type != null) localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListStorageTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessStoragesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessStoragesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessStoragesResponse)));
        }

        /// <summary>
        /// List of storages by type 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>Task of SuccessStoragesResponse</returns>
        public async System.Threading.Tasks.Task<SuccessStoragesResponse> ListStorageTypesAsync (string type)
        {
             ApiResponse<SuccessStoragesResponse> localVarResponse = await ListStorageTypesAsyncWithHttpInfo(type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of storages by type 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Storage&#39;s access type (&#x60;public&#x60; or &#x60;private&#x60;) or storage type (&#x60;normal&#x60;, &#x60;backup&#x60;, &#x60;cdrom&#x60; or &#x60;template&#x60;) or &#x60;favorite&#x60; status</param>
        /// <returns>Task of ApiResponse (SuccessStoragesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessStoragesResponse>> ListStorageTypesAsyncWithHttpInfo (string type)
        {
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling StorageApi->ListStorageTypes");

            var localVarPath = "/storage/{type}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (type != null) localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListStorageTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessStoragesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessStoragesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessStoragesResponse)));
        }

        /// <summary>
        /// List of storages 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SuccessStoragesResponse</returns>
        public SuccessStoragesResponse ListStorages ()
        {
             ApiResponse<SuccessStoragesResponse> localVarResponse = ListStoragesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of storages 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SuccessStoragesResponse</returns>
        public ApiResponse< SuccessStoragesResponse > ListStoragesWithHttpInfo ()
        {

            var localVarPath = "/storage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListStorages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessStoragesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessStoragesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessStoragesResponse)));
        }

        /// <summary>
        /// List of storages 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SuccessStoragesResponse</returns>
        public async System.Threading.Tasks.Task<SuccessStoragesResponse> ListStoragesAsync ()
        {
             ApiResponse<SuccessStoragesResponse> localVarResponse = await ListStoragesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of storages 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SuccessStoragesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessStoragesResponse>> ListStoragesAsyncWithHttpInfo ()
        {

            var localVarPath = "/storage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListStorages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SuccessStoragesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessStoragesResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessStoragesResponse)));
        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse LoadCdrom (Guid? serverId, StorageDeviceLoadRequest storageDevice = null)
        {
             ApiResponse<CreateServerResponse> localVarResponse = LoadCdromWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > LoadCdromWithHttpInfo (Guid? serverId, StorageDeviceLoadRequest storageDevice = null)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->LoadCdrom");

            var localVarPath = "/server/{serverId}/storage/cdrom/load";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (storageDevice != null && storageDevice.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storageDevice); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storageDevice; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoadCdrom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> LoadCdromAsync (Guid? serverId, StorageDeviceLoadRequest storageDevice = null)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await LoadCdromAsyncWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> LoadCdromAsyncWithHttpInfo (Guid? serverId, StorageDeviceLoadRequest storageDevice = null)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling StorageApi->LoadCdrom");

            var localVarPath = "/server/{serverId}/storage/cdrom/load";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (storageDevice != null && storageDevice.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storageDevice); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storageDevice; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoadCdrom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Modify storage Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>CreateStorageResponse</returns>
        public CreateStorageResponse ModifyStorage (Guid? storageId, ModifyStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = ModifyStorageWithHttpInfo(storageId, storage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify storage Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        public ApiResponse< CreateStorageResponse > ModifyStorageWithHttpInfo (Guid? storageId, ModifyStorageRequest storage)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->ModifyStorage");
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->ModifyStorage");

            var localVarPath = "/storage/{storageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ModifyStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Modify storage Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>Task of CreateStorageResponse</returns>
        public async System.Threading.Tasks.Task<CreateStorageResponse> ModifyStorageAsync (Guid? storageId, ModifyStorageRequest storage)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = await ModifyStorageAsyncWithHttpInfo(storageId, storage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify storage Modifies an existing storage resource. This operation is used to rename or resize the storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId"></param>
        /// <param name="storage"></param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> ModifyStorageAsyncWithHttpInfo (Guid? storageId, ModifyStorageRequest storage)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->ModifyStorage");
            // verify the required parameter 'storage' is set
            if (storage == null)
                throw new ApiException(400, "Missing required parameter 'storage' when calling StorageApi->ModifyStorage");

            var localVarPath = "/storage/{storageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ModifyStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Restore backup Restores the origin storage with data from the specified backup storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns></returns>
        public void RestoreStorage (Guid? storageId)
        {
             RestoreStorageWithHttpInfo(storageId);
        }

        /// <summary>
        /// Restore backup Restores the origin storage with data from the specified backup storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RestoreStorageWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->RestoreStorage");

            var localVarPath = "/storage/{storageId}/restore";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RestoreStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Restore backup Restores the origin storage with data from the specified backup storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RestoreStorageAsync (Guid? storageId)
        {
             await RestoreStorageAsyncWithHttpInfo(storageId);

        }

        /// <summary>
        /// Restore backup Restores the origin storage with data from the specified backup storage.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RestoreStorageAsyncWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->RestoreStorage");

            var localVarPath = "/storage/{storageId}/restore";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RestoreStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Templatize storage Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>CreateStorageResponse</returns>
        public CreateStorageResponse TemplatizeStorage (Guid? storageId, TemplitizeStorageRequest storage = null)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = TemplatizeStorageWithHttpInfo(storageId, storage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Templatize storage Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>ApiResponse of CreateStorageResponse</returns>
        public ApiResponse< CreateStorageResponse > TemplatizeStorageWithHttpInfo (Guid? storageId, TemplitizeStorageRequest storage = null)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->TemplatizeStorage");

            var localVarPath = "/storage/{storageId}/templatize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TemplatizeStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Templatize storage Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>Task of CreateStorageResponse</returns>
        public async System.Threading.Tasks.Task<CreateStorageResponse> TemplatizeStorageAsync (Guid? storageId, TemplitizeStorageRequest storage = null)
        {
             ApiResponse<CreateStorageResponse> localVarResponse = await TemplatizeStorageAsyncWithHttpInfo(storageId, storage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Templatize storage Creates an exact copy of an existing storage resource which can be used as a template for creating new servers.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <param name="storage"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateStorageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateStorageResponse>> TemplatizeStorageAsyncWithHttpInfo (Guid? storageId, TemplitizeStorageRequest storage = null)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->TemplatizeStorage");

            var localVarPath = "/storage/{storageId}/templatize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter
            if (storage != null && storage.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(storage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = storage; // byte array
            }

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TemplatizeStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateStorageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateStorageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateStorageResponse)));
        }

        /// <summary>
        /// Remove storage from favorites Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns></returns>
        public void UnfavoriteStorage (Guid? storageId)
        {
             UnfavoriteStorageWithHttpInfo(storageId);
        }

        /// <summary>
        /// Remove storage from favorites Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnfavoriteStorageWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->UnfavoriteStorage");

            var localVarPath = "/storage/{storageId}/favorite";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnfavoriteStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Remove storage from favorites Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UnfavoriteStorageAsync (Guid? storageId)
        {
             await UnfavoriteStorageAsyncWithHttpInfo(storageId);

        }

        /// <summary>
        /// Remove storage from favorites Delete a storage from the list of favorite storages. To list favorite storages, see List storages. This operations succeeds even if the storage is already on the list of favorites.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageId">Storage id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UnfavoriteStorageAsyncWithHttpInfo (Guid? storageId)
        {
            // verify the required parameter 'storageId' is set
            if (storageId == null)
                throw new ApiException(400, "Missing required parameter 'storageId' when calling StorageApi->UnfavoriteStorage");

            var localVarPath = "/storage/{storageId}/favorite";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (storageId != null) localVarPathParams.Add("storageId", Configuration.ApiClient.ParameterToString(storageId)); // path parameter

            // authentication (baseAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnfavoriteStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
