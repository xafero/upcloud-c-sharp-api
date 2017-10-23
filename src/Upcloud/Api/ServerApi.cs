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
    public interface IServerApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse AssignTag (Guid? serverId, string tagList);

        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> AssignTagWithHttpInfo (Guid? serverId, string tagList);
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
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>FirewallRuleCreateResponse</returns>
        FirewallRuleCreateResponse CreateFirewallRule (Guid? serverId, FirewallRuleRequest firewallRule);

        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>ApiResponse of FirewallRuleCreateResponse</returns>
        ApiResponse<FirewallRuleCreateResponse> CreateFirewallRuleWithHttpInfo (Guid? serverId, FirewallRuleRequest firewallRule);
        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse CreateServer (CreateServerRequest server = null);

        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> CreateServerWithHttpInfo (CreateServerRequest server = null);
        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns></returns>
        void DeleteFirewallRule (Guid? serverId, decimal? firewallRuleNumber);

        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFirewallRuleWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber);
        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns></returns>
        void DeleteServer (Guid? serverId);

        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteServerWithHttpInfo (Guid? serverId);
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
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>FirewallRuleCreateResponse</returns>
        FirewallRuleCreateResponse GetFirewallRule (Guid? serverId, decimal? firewallRuleNumber);

        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of FirewallRuleCreateResponse</returns>
        ApiResponse<FirewallRuleCreateResponse> GetFirewallRuleWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber);
        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigurationListResponse</returns>
        ConfigurationListResponse ListServerConfigurations ();

        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigurationListResponse</returns>
        ApiResponse<ConfigurationListResponse> ListServerConfigurationsWithHttpInfo ();
        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerListResponse</returns>
        ServerListResponse ListServers ();

        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> ListServersWithHttpInfo ();
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
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse ModifyServer (Guid? serverId, Server server = null);

        /// <summary>
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> ModifyServerWithHttpInfo (Guid? serverId, Server server = null);
        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse RestartServer (Guid? serverId, RestartServer restartServer);

        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> RestartServerWithHttpInfo (Guid? serverId, RestartServer restartServer);
        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse ServerDetails (Guid? serverId);

        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> ServerDetailsWithHttpInfo (Guid? serverId);
        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>FirewallRuleListResponse</returns>
        FirewallRuleListResponse ServerServerIdFirewallRuleGet (Guid? serverId);

        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of FirewallRuleListResponse</returns>
        ApiResponse<FirewallRuleListResponse> ServerServerIdFirewallRuleGetWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse StartServer (Guid? serverId);

        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> StartServerWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse StopServer (Guid? serverId, StopServer stopServerRequest);

        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> StopServerWithHttpInfo (Guid? serverId, StopServer stopServerRequest);
        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>CreateServerResponse</returns>
        CreateServerResponse Untag (Guid? serverId, string tagName);

        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        ApiResponse<CreateServerResponse> UntagWithHttpInfo (Guid? serverId, string tagName);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> AssignTagAsync (Guid? serverId, string tagList);

        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> AssignTagAsyncWithHttpInfo (Guid? serverId, string tagList);
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
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of FirewallRuleCreateResponse</returns>
        System.Threading.Tasks.Task<FirewallRuleCreateResponse> CreateFirewallRuleAsync (Guid? serverId, FirewallRuleRequest firewallRule);

        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of ApiResponse (FirewallRuleCreateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRuleCreateResponse>> CreateFirewallRuleAsyncWithHttpInfo (Guid? serverId, FirewallRuleRequest firewallRule);
        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> CreateServerAsync (CreateServerRequest server = null);

        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> CreateServerAsyncWithHttpInfo (CreateServerRequest server = null);
        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFirewallRuleAsync (Guid? serverId, decimal? firewallRuleNumber);

        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFirewallRuleAsyncWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber);
        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteServerAsync (Guid? serverId);

        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteServerAsyncWithHttpInfo (Guid? serverId);
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
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of FirewallRuleCreateResponse</returns>
        System.Threading.Tasks.Task<FirewallRuleCreateResponse> GetFirewallRuleAsync (Guid? serverId, decimal? firewallRuleNumber);

        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse (FirewallRuleCreateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRuleCreateResponse>> GetFirewallRuleAsyncWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber);
        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigurationListResponse</returns>
        System.Threading.Tasks.Task<ConfigurationListResponse> ListServerConfigurationsAsync ();

        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigurationListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationListResponse>> ListServerConfigurationsAsyncWithHttpInfo ();
        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> ListServersAsync ();

        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ListServersAsyncWithHttpInfo ();
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
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> ModifyServerAsync (Guid? serverId, Server server = null);

        /// <summary>
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> ModifyServerAsyncWithHttpInfo (Guid? serverId, Server server = null);
        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> RestartServerAsync (Guid? serverId, RestartServer restartServer);

        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> RestartServerAsyncWithHttpInfo (Guid? serverId, RestartServer restartServer);
        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> ServerDetailsAsync (Guid? serverId);

        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> ServerDetailsAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of FirewallRuleListResponse</returns>
        System.Threading.Tasks.Task<FirewallRuleListResponse> ServerServerIdFirewallRuleGetAsync (Guid? serverId);

        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse (FirewallRuleListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRuleListResponse>> ServerServerIdFirewallRuleGetAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> StartServerAsync (Guid? serverId);

        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> StartServerAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> StopServerAsync (Guid? serverId, StopServer stopServerRequest);

        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> StopServerAsyncWithHttpInfo (Guid? serverId, StopServer stopServerRequest);
        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of CreateServerResponse</returns>
        System.Threading.Tasks.Task<CreateServerResponse> UntagAsync (Guid? serverId, string tagName);

        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> UntagAsyncWithHttpInfo (Guid? serverId, string tagName);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServerApi : IServerApi
    {
        private Upcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServerApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Upcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServerApi(Configuration configuration = null)
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
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse AssignTag (Guid? serverId, string tagList)
        {
             ApiResponse<CreateServerResponse> localVarResponse = AssignTagWithHttpInfo(serverId, tagList);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > AssignTagWithHttpInfo (Guid? serverId, string tagList)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->AssignTag");
            // verify the required parameter 'tagList' is set
            if (tagList == null)
                throw new ApiException(400, "Missing required parameter 'tagList' when calling ServerApi->AssignTag");

            var localVarPath = "/server/{serverId}/tag/{tagList}";
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
            if (tagList != null) localVarPathParams.Add("tagList", Configuration.ApiClient.ParameterToString(tagList)); // path parameter

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
                Exception exception = ExceptionFactory("AssignTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> AssignTagAsync (Guid? serverId, string tagList)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await AssignTagAsyncWithHttpInfo(serverId, tagList);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> AssignTagAsyncWithHttpInfo (Guid? serverId, string tagList)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->AssignTag");
            // verify the required parameter 'tagList' is set
            if (tagList == null)
                throw new ApiException(400, "Missing required parameter 'tagList' when calling ServerApi->AssignTag");

            var localVarPath = "/server/{serverId}/tag/{tagList}";
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
            if (tagList != null) localVarPathParams.Add("tagList", Configuration.ApiClient.ParameterToString(tagList)); // path parameter

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
                Exception exception = ExceptionFactory("AssignTag", localVarResponse);
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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->AttachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling ServerApi->AttachStorage");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->AttachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling ServerApi->AttachStorage");

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
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>FirewallRuleCreateResponse</returns>
        public FirewallRuleCreateResponse CreateFirewallRule (Guid? serverId, FirewallRuleRequest firewallRule)
        {
             ApiResponse<FirewallRuleCreateResponse> localVarResponse = CreateFirewallRuleWithHttpInfo(serverId, firewallRule);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>ApiResponse of FirewallRuleCreateResponse</returns>
        public ApiResponse< FirewallRuleCreateResponse > CreateFirewallRuleWithHttpInfo (Guid? serverId, FirewallRuleRequest firewallRule)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->CreateFirewallRule");
            // verify the required parameter 'firewallRule' is set
            if (firewallRule == null)
                throw new ApiException(400, "Missing required parameter 'firewallRule' when calling ServerApi->CreateFirewallRule");

            var localVarPath = "/server/{serverId}/firewall_rule";
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
            if (firewallRule != null && firewallRule.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(firewallRule); // http body (model) parameter
            }
            else
            {
                localVarPostBody = firewallRule; // byte array
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
                Exception exception = ExceptionFactory("CreateFirewallRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FirewallRuleCreateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleCreateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleCreateResponse)));
        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of FirewallRuleCreateResponse</returns>
        public async System.Threading.Tasks.Task<FirewallRuleCreateResponse> CreateFirewallRuleAsync (Guid? serverId, FirewallRuleRequest firewallRule)
        {
             ApiResponse<FirewallRuleCreateResponse> localVarResponse = await CreateFirewallRuleAsyncWithHttpInfo(serverId, firewallRule);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of ApiResponse (FirewallRuleCreateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRuleCreateResponse>> CreateFirewallRuleAsyncWithHttpInfo (Guid? serverId, FirewallRuleRequest firewallRule)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->CreateFirewallRule");
            // verify the required parameter 'firewallRule' is set
            if (firewallRule == null)
                throw new ApiException(400, "Missing required parameter 'firewallRule' when calling ServerApi->CreateFirewallRule");

            var localVarPath = "/server/{serverId}/firewall_rule";
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
            if (firewallRule != null && firewallRule.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(firewallRule); // http body (model) parameter
            }
            else
            {
                localVarPostBody = firewallRule; // byte array
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
                Exception exception = ExceptionFactory("CreateFirewallRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FirewallRuleCreateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleCreateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleCreateResponse)));
        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse CreateServer (CreateServerRequest server = null)
        {
             ApiResponse<CreateServerResponse> localVarResponse = CreateServerWithHttpInfo(server);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > CreateServerWithHttpInfo (CreateServerRequest server = null)
        {

            var localVarPath = "/server";
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

            if (server != null && server.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(server); // http body (model) parameter
            }
            else
            {
                localVarPostBody = server; // byte array
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
                Exception exception = ExceptionFactory("CreateServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> CreateServerAsync (CreateServerRequest server = null)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await CreateServerAsyncWithHttpInfo(server);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> CreateServerAsyncWithHttpInfo (CreateServerRequest server = null)
        {

            var localVarPath = "/server";
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

            if (server != null && server.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(server); // http body (model) parameter
            }
            else
            {
                localVarPostBody = server; // byte array
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
                Exception exception = ExceptionFactory("CreateServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns></returns>
        public void DeleteFirewallRule (Guid? serverId, decimal? firewallRuleNumber)
        {
             DeleteFirewallRuleWithHttpInfo(serverId, firewallRuleNumber);
        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFirewallRuleWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->DeleteFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling ServerApi->DeleteFirewallRule");

            var localVarPath = "/server/{serverId}/firewall_rule/{firewallRuleNumber}";
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
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteFirewallRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFirewallRuleAsync (Guid? serverId, decimal? firewallRuleNumber)
        {
             await DeleteFirewallRuleAsyncWithHttpInfo(serverId, firewallRuleNumber);

        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFirewallRuleAsyncWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->DeleteFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling ServerApi->DeleteFirewallRule");

            var localVarPath = "/server/{serverId}/firewall_rule/{firewallRuleNumber}";
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
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteFirewallRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns></returns>
        public void DeleteServer (Guid? serverId)
        {
             DeleteServerWithHttpInfo(serverId);
        }

        /// <summary>
        /// Delete server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteServerWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->DeleteServer");

            var localVarPath = "/server/{serverId}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteServerAsync (Guid? serverId)
        {
             await DeleteServerAsyncWithHttpInfo(serverId);

        }

        /// <summary>
        /// Delete server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteServerAsyncWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->DeleteServer");

            var localVarPath = "/server/{serverId}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteServer", localVarResponse);
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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->DetachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling ServerApi->DetachStorage");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->DetachStorage");
            // verify the required parameter 'storageDevice' is set
            if (storageDevice == null)
                throw new ApiException(400, "Missing required parameter 'storageDevice' when calling ServerApi->DetachStorage");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->EjectCdrom");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->EjectCdrom");

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
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>FirewallRuleCreateResponse</returns>
        public FirewallRuleCreateResponse GetFirewallRule (Guid? serverId, decimal? firewallRuleNumber)
        {
             ApiResponse<FirewallRuleCreateResponse> localVarResponse = GetFirewallRuleWithHttpInfo(serverId, firewallRuleNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of FirewallRuleCreateResponse</returns>
        public ApiResponse< FirewallRuleCreateResponse > GetFirewallRuleWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->GetFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling ServerApi->GetFirewallRule");

            var localVarPath = "/server/{serverId}/firewall_rule/{firewallRuleNumber}";
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
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter

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
                Exception exception = ExceptionFactory("GetFirewallRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FirewallRuleCreateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleCreateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleCreateResponse)));
        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of FirewallRuleCreateResponse</returns>
        public async System.Threading.Tasks.Task<FirewallRuleCreateResponse> GetFirewallRuleAsync (Guid? serverId, decimal? firewallRuleNumber)
        {
             ApiResponse<FirewallRuleCreateResponse> localVarResponse = await GetFirewallRuleAsyncWithHttpInfo(serverId, firewallRuleNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse (FirewallRuleCreateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRuleCreateResponse>> GetFirewallRuleAsyncWithHttpInfo (Guid? serverId, decimal? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->GetFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling ServerApi->GetFirewallRule");

            var localVarPath = "/server/{serverId}/firewall_rule/{firewallRuleNumber}";
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
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter

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
                Exception exception = ExceptionFactory("GetFirewallRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FirewallRuleCreateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleCreateResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleCreateResponse)));
        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigurationListResponse</returns>
        public ConfigurationListResponse ListServerConfigurations ()
        {
             ApiResponse<ConfigurationListResponse> localVarResponse = ListServerConfigurationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigurationListResponse</returns>
        public ApiResponse< ConfigurationListResponse > ListServerConfigurationsWithHttpInfo ()
        {

            var localVarPath = "/server_size";
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
                Exception exception = ExceptionFactory("ListServerConfigurations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConfigurationListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationListResponse)));
        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigurationListResponse</returns>
        public async System.Threading.Tasks.Task<ConfigurationListResponse> ListServerConfigurationsAsync ()
        {
             ApiResponse<ConfigurationListResponse> localVarResponse = await ListServerConfigurationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigurationListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationListResponse>> ListServerConfigurationsAsyncWithHttpInfo ()
        {

            var localVarPath = "/server_size";
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
                Exception exception = ExceptionFactory("ListServerConfigurations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConfigurationListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConfigurationListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConfigurationListResponse)));
        }

        /// <summary>
        /// List of servers Returns a list of all servers associated with the current account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse ListServers ()
        {
             ApiResponse<ServerListResponse> localVarResponse = ListServersWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of servers Returns a list of all servers associated with the current account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > ListServersWithHttpInfo ()
        {

            var localVarPath = "/server";
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
                Exception exception = ExceptionFactory("ListServers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// List of servers Returns a list of all servers associated with the current account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> ListServersAsync ()
        {
             ApiResponse<ServerListResponse> localVarResponse = await ListServersAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of servers Returns a list of all servers associated with the current account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ListServersAsyncWithHttpInfo ()
        {

            var localVarPath = "/server";
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
                Exception exception = ExceptionFactory("ListServers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->LoadCdrom");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->LoadCdrom");

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
        /// Modify server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse ModifyServer (Guid? serverId, Server server = null)
        {
             ApiResponse<CreateServerResponse> localVarResponse = ModifyServerWithHttpInfo(serverId, server);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > ModifyServerWithHttpInfo (Guid? serverId, Server server = null)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->ModifyServer");

            var localVarPath = "/server/{serverId}";
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
            if (server != null && server.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(server); // http body (model) parameter
            }
            else
            {
                localVarPostBody = server; // byte array
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
                Exception exception = ExceptionFactory("ModifyServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> ModifyServerAsync (Guid? serverId, Server server = null)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await ModifyServerAsyncWithHttpInfo(serverId, server);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> ModifyServerAsyncWithHttpInfo (Guid? serverId, Server server = null)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->ModifyServer");

            var localVarPath = "/server/{serverId}";
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
            if (server != null && server.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(server); // http body (model) parameter
            }
            else
            {
                localVarPostBody = server; // byte array
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
                Exception exception = ExceptionFactory("ModifyServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse RestartServer (Guid? serverId, RestartServer restartServer)
        {
             ApiResponse<CreateServerResponse> localVarResponse = RestartServerWithHttpInfo(serverId, restartServer);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > RestartServerWithHttpInfo (Guid? serverId, RestartServer restartServer)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->RestartServer");
            // verify the required parameter 'restartServer' is set
            if (restartServer == null)
                throw new ApiException(400, "Missing required parameter 'restartServer' when calling ServerApi->RestartServer");

            var localVarPath = "/server/{serverId}/restart";
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
            if (restartServer != null && restartServer.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(restartServer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = restartServer; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RestartServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> RestartServerAsync (Guid? serverId, RestartServer restartServer)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await RestartServerAsyncWithHttpInfo(serverId, restartServer);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> RestartServerAsyncWithHttpInfo (Guid? serverId, RestartServer restartServer)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->RestartServer");
            // verify the required parameter 'restartServer' is set
            if (restartServer == null)
                throw new ApiException(400, "Missing required parameter 'restartServer' when calling ServerApi->RestartServer");

            var localVarPath = "/server/{serverId}/restart";
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
            if (restartServer != null && restartServer.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(restartServer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = restartServer; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RestartServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse ServerDetails (Guid? serverId)
        {
             ApiResponse<CreateServerResponse> localVarResponse = ServerDetailsWithHttpInfo(serverId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > ServerDetailsWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->ServerDetails");

            var localVarPath = "/server/{serverId}";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServerDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> ServerDetailsAsync (Guid? serverId)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await ServerDetailsAsyncWithHttpInfo(serverId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> ServerDetailsAsyncWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->ServerDetails");

            var localVarPath = "/server/{serverId}";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServerDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// List firewall rules Returns a list of firewall rules for a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>FirewallRuleListResponse</returns>
        public FirewallRuleListResponse ServerServerIdFirewallRuleGet (Guid? serverId)
        {
             ApiResponse<FirewallRuleListResponse> localVarResponse = ServerServerIdFirewallRuleGetWithHttpInfo(serverId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List firewall rules Returns a list of firewall rules for a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of FirewallRuleListResponse</returns>
        public ApiResponse< FirewallRuleListResponse > ServerServerIdFirewallRuleGetWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->ServerServerIdFirewallRuleGet");

            var localVarPath = "/server/{serverId}/firewall_rule";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServerServerIdFirewallRuleGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FirewallRuleListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleListResponse)));
        }

        /// <summary>
        /// List firewall rules Returns a list of firewall rules for a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of FirewallRuleListResponse</returns>
        public async System.Threading.Tasks.Task<FirewallRuleListResponse> ServerServerIdFirewallRuleGetAsync (Guid? serverId)
        {
             ApiResponse<FirewallRuleListResponse> localVarResponse = await ServerServerIdFirewallRuleGetAsyncWithHttpInfo(serverId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List firewall rules Returns a list of firewall rules for a specific server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse (FirewallRuleListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRuleListResponse>> ServerServerIdFirewallRuleGetAsyncWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->ServerServerIdFirewallRuleGet");

            var localVarPath = "/server/{serverId}/firewall_rule";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServerServerIdFirewallRuleGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FirewallRuleListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleListResponse)));
        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse StartServer (Guid? serverId)
        {
             ApiResponse<CreateServerResponse> localVarResponse = StartServerWithHttpInfo(serverId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > StartServerWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->StartServer");

            var localVarPath = "/server/{serverId}/start";
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
                Exception exception = ExceptionFactory("StartServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> StartServerAsync (Guid? serverId)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await StartServerAsyncWithHttpInfo(serverId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> StartServerAsyncWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->StartServer");

            var localVarPath = "/server/{serverId}/start";
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
                Exception exception = ExceptionFactory("StartServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse StopServer (Guid? serverId, StopServer stopServerRequest)
        {
             ApiResponse<CreateServerResponse> localVarResponse = StopServerWithHttpInfo(serverId, stopServerRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > StopServerWithHttpInfo (Guid? serverId, StopServer stopServerRequest)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->StopServer");
            // verify the required parameter 'stopServerRequest' is set
            if (stopServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'stopServerRequest' when calling ServerApi->StopServer");

            var localVarPath = "/server/{serverId}/stop";
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
            if (stopServerRequest != null && stopServerRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(stopServerRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stopServerRequest; // byte array
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
                Exception exception = ExceptionFactory("StopServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> StopServerAsync (Guid? serverId, StopServer stopServerRequest)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await StopServerAsyncWithHttpInfo(serverId, stopServerRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServerRequest"></param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> StopServerAsyncWithHttpInfo (Guid? serverId, StopServer stopServerRequest)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->StopServer");
            // verify the required parameter 'stopServerRequest' is set
            if (stopServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'stopServerRequest' when calling ServerApi->StopServer");

            var localVarPath = "/server/{serverId}/stop";
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
            if (stopServerRequest != null && stopServerRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(stopServerRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stopServerRequest; // byte array
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
                Exception exception = ExceptionFactory("StopServer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>CreateServerResponse</returns>
        public CreateServerResponse Untag (Guid? serverId, string tagName)
        {
             ApiResponse<CreateServerResponse> localVarResponse = UntagWithHttpInfo(serverId, tagName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>ApiResponse of CreateServerResponse</returns>
        public ApiResponse< CreateServerResponse > UntagWithHttpInfo (Guid? serverId, string tagName)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->Untag");
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling ServerApi->Untag");

            var localVarPath = "/server/{serverId}/untag/{tagName}";
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
            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter

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
                Exception exception = ExceptionFactory("Untag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of CreateServerResponse</returns>
        public async System.Threading.Tasks.Task<CreateServerResponse> UntagAsync (Guid? serverId, string tagName)
        {
             ApiResponse<CreateServerResponse> localVarResponse = await UntagAsyncWithHttpInfo(serverId, tagName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ApiResponse (CreateServerResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateServerResponse>> UntagAsyncWithHttpInfo (Guid? serverId, string tagName)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->Untag");
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling ServerApi->Untag");

            var localVarPath = "/server/{serverId}/untag/{tagName}";
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
            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter

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
                Exception exception = ExceptionFactory("Untag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateServerResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateServerResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateServerResponse)));
        }

    }
}
