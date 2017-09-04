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
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse AssignTag (Guid? serverId, string tagList);

        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> AssignTagWithHttpInfo (Guid? serverId, string tagList);
        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse AttachStorage (Guid? serverId, StorageDevice storageDevice);

        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> AttachStorageWithHttpInfo (Guid? serverId, StorageDevice storageDevice);
        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns></returns>
        void CreateFirewallRule (Guid? serverId, FirewallRule firewallRule);

        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateFirewallRuleWithHttpInfo (Guid? serverId, FirewallRule firewallRule);
        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse CreateServer (Server server = null);

        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> CreateServerWithHttpInfo (Server server = null);
        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns></returns>
        void DeleteFirewallRule (Guid? serverId, Guid? firewallRuleNumber);

        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns></returns>
        void DeleteServer (Guid? serverId);

        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteServerWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse DetachStorage (Guid? serverId, StorageDevice storageDevice);

        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> DetachStorageWithHttpInfo (Guid? serverId, StorageDevice storageDevice);
        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse EjectCdrom (Guid? serverId);

        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> EjectCdromWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>FirewallRuleDetailsResponse</returns>
        FirewallRuleDetailsResponse GetFirewallRule (Guid? serverId, Guid? firewallRuleNumber);

        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of FirewallRuleDetailsResponse</returns>
        ApiResponse<FirewallRuleDetailsResponse> GetFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigurationListResponse</returns>
        ConfigurationListResponse ListServerConfigurations ();

        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigurationListResponse</returns>
        ApiResponse<ConfigurationListResponse> ListServerConfigurationsWithHttpInfo ();
        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerListResponse</returns>
        ServerListResponse ListServers ();

        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> ListServersWithHttpInfo ();
        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse LoadCdrom (Guid? serverId, StorageDevice1 storageDevice = null);

        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> LoadCdromWithHttpInfo (Guid? serverId, StorageDevice1 storageDevice = null);
        /// <summary>
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse ModifyServer (Guid? serverId, Server server = null);

        /// <summary>
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> ModifyServerWithHttpInfo (Guid? serverId, Server server = null);
        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse RestartServer (Guid? serverId, RestartServer restartServer);

        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> RestartServerWithHttpInfo (Guid? serverId, RestartServer restartServer);
        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse ServerDetails (Guid? serverId);

        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> ServerDetailsWithHttpInfo (Guid? serverId);
        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>FirewallRuleListResponse</returns>
        FirewallRuleListResponse ServerServerIdFirewallRuleGet (Guid? serverId);

        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of FirewallRuleListResponse</returns>
        ApiResponse<FirewallRuleListResponse> ServerServerIdFirewallRuleGetWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse StartServer (Guid? serverId);

        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> StartServerWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse StopServer (Guid? serverId, StopServer stopServer);

        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> StopServerWithHttpInfo (Guid? serverId, StopServer stopServer);
        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>ServerListResponse</returns>
        ServerListResponse Untag (Guid? serverId, string tagName);

        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        ApiResponse<ServerListResponse> UntagWithHttpInfo (Guid? serverId, string tagName);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> AssignTagAsync (Guid? serverId, string tagList);

        /// <summary>
        /// Assign tag to a server
        /// </summary>
        /// <remarks>
        /// Servers can be tagged with one or more tags. The tags used must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> AssignTagAsyncWithHttpInfo (Guid? serverId, string tagList);
        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> AttachStorageAsync (Guid? serverId, StorageDevice storageDevice);

        /// <summary>
        /// Attach storage
        /// </summary>
        /// <remarks>
        /// Attaches a storage as a device to a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> AttachStorageAsyncWithHttpInfo (Guid? serverId, StorageDevice storageDevice);
        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateFirewallRuleAsync (Guid? serverId, FirewallRule firewallRule);

        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateFirewallRuleAsyncWithHttpInfo (Guid? serverId, FirewallRule firewallRule);
        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> CreateServerAsync (Server server = null);

        /// <summary>
        /// Create server
        /// </summary>
        /// <remarks>
        /// Creates a new server instance.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> CreateServerAsyncWithHttpInfo (Server server = null);
        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFirewallRuleAsync (Guid? serverId, Guid? firewallRuleNumber);

        /// <summary>
        /// Remove firewall rule
        /// </summary>
        /// <remarks>
        /// Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteServerAsync (Guid? serverId);

        /// <summary>
        /// Delete server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteServerAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> DetachStorageAsync (Guid? serverId, StorageDevice storageDevice);

        /// <summary>
        /// Detach storage
        /// </summary>
        /// <remarks>
        /// Detaches a storage resource from a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> DetachStorageAsyncWithHttpInfo (Guid? serverId, StorageDevice storageDevice);
        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> EjectCdromAsync (Guid? serverId);

        /// <summary>
        /// Eject CD-ROM
        /// </summary>
        /// <remarks>
        /// Ejects the storage from the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> EjectCdromAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of FirewallRuleDetailsResponse</returns>
        System.Threading.Tasks.Task<FirewallRuleDetailsResponse> GetFirewallRuleAsync (Guid? serverId, Guid? firewallRuleNumber);

        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse (FirewallRuleDetailsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRuleDetailsResponse>> GetFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigurationListResponse</returns>
        System.Threading.Tasks.Task<ConfigurationListResponse> ListServerConfigurationsAsync ();

        /// <summary>
        /// List server configurations
        /// </summary>
        /// <remarks>
        /// Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigurationListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationListResponse>> ListServerConfigurationsAsyncWithHttpInfo ();
        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> ListServersAsync ();

        /// <summary>
        /// List of servers
        /// </summary>
        /// <remarks>
        /// Returns a list of all servers associated with the current account.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ListServersAsyncWithHttpInfo ();
        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> LoadCdromAsync (Guid? serverId, StorageDevice1 storageDevice = null);

        /// <summary>
        /// Load CD-ROM
        /// </summary>
        /// <remarks>
        /// Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> LoadCdromAsyncWithHttpInfo (Guid? serverId, StorageDevice1 storageDevice = null);
        /// <summary>
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> ModifyServerAsync (Guid? serverId, Server server = null);

        /// <summary>
        /// Modify server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ModifyServerAsyncWithHttpInfo (Guid? serverId, Server server = null);
        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> RestartServerAsync (Guid? serverId, RestartServer restartServer);

        /// <summary>
        /// Restart server
        /// </summary>
        /// <remarks>
        /// Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> RestartServerAsyncWithHttpInfo (Guid? serverId, RestartServer restartServer);
        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> ServerDetailsAsync (Guid? serverId);

        /// <summary>
        /// Get server details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ServerDetailsAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of FirewallRuleListResponse</returns>
        System.Threading.Tasks.Task<FirewallRuleListResponse> ServerServerIdFirewallRuleGetAsync (Guid? serverId);

        /// <summary>
        /// List firewall rules
        /// </summary>
        /// <remarks>
        /// Returns a list of firewall rules for a specific server.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse (FirewallRuleListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRuleListResponse>> ServerServerIdFirewallRuleGetAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> StartServerAsync (Guid? serverId);

        /// <summary>
        /// Start server
        /// </summary>
        /// <remarks>
        /// Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> StartServerAsyncWithHttpInfo (Guid? serverId);
        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> StopServerAsync (Guid? serverId, StopServer stopServer);

        /// <summary>
        /// Stop server
        /// </summary>
        /// <remarks>
        /// Stops a started server. The server state must be &#x60;started&#x60;.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> StopServerAsyncWithHttpInfo (Guid? serverId, StopServer stopServer);
        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ServerListResponse</returns>
        System.Threading.Tasks.Task<ServerListResponse> UntagAsync (Guid? serverId, string tagName);

        /// <summary>
        /// Remove tag from server
        /// </summary>
        /// <remarks>
        /// Untags tags from given server. The tag(s) must exist
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> UntagAsyncWithHttpInfo (Guid? serverId, string tagName);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServerApi : IServerApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServerApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse AssignTag (Guid? serverId, string tagList)
        {
             ApiResponse<ServerListResponse> localVarResponse = AssignTagWithHttpInfo(serverId, tagList);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > AssignTagWithHttpInfo (Guid? serverId, string tagList)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (tagList != null) localVarPathParams.Add("tagList", Configuration.ApiClient.ParameterToString(tagList)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> AssignTagAsync (Guid? serverId, string tagList)
        {
             ApiResponse<ServerListResponse> localVarResponse = await AssignTagAsyncWithHttpInfo(serverId, tagList);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Assign tag to a server Servers can be tagged with one or more tags. The tags used must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagList">List of tags</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> AssignTagAsyncWithHttpInfo (Guid? serverId, string tagList)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (tagList != null) localVarPathParams.Add("tagList", Configuration.ApiClient.ParameterToString(tagList)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse AttachStorage (Guid? serverId, StorageDevice storageDevice)
        {
             ApiResponse<ServerListResponse> localVarResponse = AttachStorageWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > AttachStorageWithHttpInfo (Guid? serverId, StorageDevice storageDevice)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> AttachStorageAsync (Guid? serverId, StorageDevice storageDevice)
        {
             ApiResponse<ServerListResponse> localVarResponse = await AttachStorageAsyncWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attach storage Attaches a storage as a device to a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> AttachStorageAsyncWithHttpInfo (Guid? serverId, StorageDevice storageDevice)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns></returns>
        public void CreateFirewallRule (Guid? serverId, FirewallRule firewallRule)
        {
             CreateFirewallRuleWithHttpInfo(serverId, firewallRule);
        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateFirewallRuleWithHttpInfo (Guid? serverId, FirewallRule firewallRule)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateFirewallRuleAsync (Guid? serverId, FirewallRule firewallRule)
        {
             await CreateFirewallRuleAsyncWithHttpInfo(serverId, firewallRule);

        }

        /// <summary>
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateFirewallRuleAsyncWithHttpInfo (Guid? serverId, FirewallRule firewallRule)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse CreateServer (Server server = null)
        {
             ApiResponse<ServerListResponse> localVarResponse = CreateServerWithHttpInfo(server);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > CreateServerWithHttpInfo (Server server = null)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> CreateServerAsync (Server server = null)
        {
             ApiResponse<ServerListResponse> localVarResponse = await CreateServerAsyncWithHttpInfo(server);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create server Creates a new server instance.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> CreateServerAsyncWithHttpInfo (Server server = null)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns></returns>
        public void DeleteFirewallRule (Guid? serverId, Guid? firewallRuleNumber)
        {
             DeleteFirewallRuleWithHttpInfo(serverId, firewallRuleNumber);
        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter


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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFirewallRuleAsync (Guid? serverId, Guid? firewallRuleNumber)
        {
             await DeleteFirewallRuleAsyncWithHttpInfo(serverId, firewallRuleNumber);

        }

        /// <summary>
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter


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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns></returns>
        public void DeleteServer (Guid? serverId)
        {
             DeleteServerWithHttpInfo(serverId);
        }

        /// <summary>
        /// Delete server 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteServerAsync (Guid? serverId)
        {
             await DeleteServerAsyncWithHttpInfo(serverId);

        }

        /// <summary>
        /// Delete server 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse DetachStorage (Guid? serverId, StorageDevice storageDevice)
        {
             ApiResponse<ServerListResponse> localVarResponse = DetachStorageWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > DetachStorageWithHttpInfo (Guid? serverId, StorageDevice storageDevice)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> DetachStorageAsync (Guid? serverId, StorageDevice storageDevice)
        {
             ApiResponse<ServerListResponse> localVarResponse = await DetachStorageAsyncWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detach storage Detaches a storage resource from a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> DetachStorageAsyncWithHttpInfo (Guid? serverId, StorageDevice storageDevice)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse EjectCdrom (Guid? serverId)
        {
             ApiResponse<ServerListResponse> localVarResponse = EjectCdromWithHttpInfo(serverId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > EjectCdromWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->EjectCdrom");

            var localVarPath = "/server/{serverId}/storage/cdrom/eject";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> EjectCdromAsync (Guid? serverId)
        {
             ApiResponse<ServerListResponse> localVarResponse = await EjectCdromAsyncWithHttpInfo(serverId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Eject CD-ROM Ejects the storage from the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> EjectCdromAsyncWithHttpInfo (Guid? serverId)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->EjectCdrom");

            var localVarPath = "/server/{serverId}/storage/cdrom/eject";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>FirewallRuleDetailsResponse</returns>
        public FirewallRuleDetailsResponse GetFirewallRule (Guid? serverId, Guid? firewallRuleNumber)
        {
             ApiResponse<FirewallRuleDetailsResponse> localVarResponse = GetFirewallRuleWithHttpInfo(serverId, firewallRuleNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of FirewallRuleDetailsResponse</returns>
        public ApiResponse< FirewallRuleDetailsResponse > GetFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter


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

            return new ApiResponse<FirewallRuleDetailsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleDetailsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleDetailsResponse)));
        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of FirewallRuleDetailsResponse</returns>
        public async System.Threading.Tasks.Task<FirewallRuleDetailsResponse> GetFirewallRuleAsync (Guid? serverId, Guid? firewallRuleNumber)
        {
             ApiResponse<FirewallRuleDetailsResponse> localVarResponse = await GetFirewallRuleAsyncWithHttpInfo(serverId, firewallRuleNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse (FirewallRuleDetailsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRuleDetailsResponse>> GetFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (firewallRuleNumber != null) localVarPathParams.Add("firewallRuleNumber", Configuration.ApiClient.ParameterToString(firewallRuleNumber)); // path parameter


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

            return new ApiResponse<FirewallRuleDetailsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FirewallRuleDetailsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FirewallRuleDetailsResponse)));
        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigurationListResponse</returns>
        public ConfigurationListResponse ListServerConfigurations ()
        {
             ApiResponse<ConfigurationListResponse> localVarResponse = ListServerConfigurationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigurationListResponse</returns>
        public async System.Threading.Tasks.Task<ConfigurationListResponse> ListServerConfigurationsAsync ()
        {
             ApiResponse<ConfigurationListResponse> localVarResponse = await ListServerConfigurationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List server configurations Returns a list of available server configurations. A server configuration consists of a combination of CPU core count and main memory amount. All servers are created using these configurations.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse ListServers ()
        {
             ApiResponse<ServerListResponse> localVarResponse = ListServersWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of servers Returns a list of all servers associated with the current account.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> ListServersAsync ()
        {
             ApiResponse<ServerListResponse> localVarResponse = await ListServersAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of servers Returns a list of all servers associated with the current account.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse LoadCdrom (Guid? serverId, StorageDevice1 storageDevice = null)
        {
             ApiResponse<ServerListResponse> localVarResponse = LoadCdromWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > LoadCdromWithHttpInfo (Guid? serverId, StorageDevice1 storageDevice = null)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> LoadCdromAsync (Guid? serverId, StorageDevice1 storageDevice = null)
        {
             ApiResponse<ServerListResponse> localVarResponse = await LoadCdromAsyncWithHttpInfo(serverId, storageDevice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Load CD-ROM Loads a storage as a CD-ROM in the CD-ROM device of a server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="storageDevice"> (optional)</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> LoadCdromAsyncWithHttpInfo (Guid? serverId, StorageDevice1 storageDevice = null)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse ModifyServer (Guid? serverId, Server server = null)
        {
             ApiResponse<ServerListResponse> localVarResponse = ModifyServerWithHttpInfo(serverId, server);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > ModifyServerWithHttpInfo (Guid? serverId, Server server = null)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> ModifyServerAsync (Guid? serverId, Server server = null)
        {
             ApiResponse<ServerListResponse> localVarResponse = await ModifyServerAsyncWithHttpInfo(serverId, server);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify server 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to modify</param>
        /// <param name="server"> (optional)</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ModifyServerAsyncWithHttpInfo (Guid? serverId, Server server = null)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse RestartServer (Guid? serverId, RestartServer restartServer)
        {
             ApiResponse<ServerListResponse> localVarResponse = RestartServerWithHttpInfo(serverId, restartServer);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > RestartServerWithHttpInfo (Guid? serverId, RestartServer restartServer)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> RestartServerAsync (Guid? serverId, RestartServer restartServer)
        {
             ApiResponse<ServerListResponse> localVarResponse = await RestartServerAsyncWithHttpInfo(serverId, restartServer);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Restart server Stops and starts a server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to restart</param>
        /// <param name="restartServer"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> RestartServerAsyncWithHttpInfo (Guid? serverId, RestartServer restartServer)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse ServerDetails (Guid? serverId)
        {
             ApiResponse<ServerListResponse> localVarResponse = ServerDetailsWithHttpInfo(serverId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > ServerDetailsWithHttpInfo (Guid? serverId)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> ServerDetailsAsync (Guid? serverId)
        {
             ApiResponse<ServerListResponse> localVarResponse = await ServerDetailsAsyncWithHttpInfo(serverId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get server details Returns detailed information about a specific server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to return</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> ServerDetailsAsyncWithHttpInfo (Guid? serverId)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// List firewall rules Returns a list of firewall rules for a specific server.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter


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
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse StartServer (Guid? serverId)
        {
             ApiResponse<ServerListResponse> localVarResponse = StartServerWithHttpInfo(serverId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > StartServerWithHttpInfo (Guid? serverId)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> StartServerAsync (Guid? serverId)
        {
             ApiResponse<ServerListResponse> localVarResponse = await StartServerAsyncWithHttpInfo(serverId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start server Starts a stopped server. The server state must be &#x60;stopped&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to start</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> StartServerAsyncWithHttpInfo (Guid? serverId)
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse StopServer (Guid? serverId, StopServer stopServer)
        {
             ApiResponse<ServerListResponse> localVarResponse = StopServerWithHttpInfo(serverId, stopServer);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > StopServerWithHttpInfo (Guid? serverId, StopServer stopServer)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->StopServer");
            // verify the required parameter 'stopServer' is set
            if (stopServer == null)
                throw new ApiException(400, "Missing required parameter 'stopServer' when calling ServerApi->StopServer");

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
            if (stopServer != null && stopServer.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(stopServer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stopServer; // byte array
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> StopServerAsync (Guid? serverId, StopServer stopServer)
        {
             ApiResponse<ServerListResponse> localVarResponse = await StopServerAsyncWithHttpInfo(serverId, stopServer);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stop server Stops a started server. The server state must be &#x60;started&#x60;.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Id of server to stop</param>
        /// <param name="stopServer"></param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> StopServerAsyncWithHttpInfo (Guid? serverId, StopServer stopServer)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling ServerApi->StopServer");
            // verify the required parameter 'stopServer' is set
            if (stopServer == null)
                throw new ApiException(400, "Missing required parameter 'stopServer' when calling ServerApi->StopServer");

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
            if (stopServer != null && stopServer.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(stopServer); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stopServer; // byte array
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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>ServerListResponse</returns>
        public ServerListResponse Untag (Guid? serverId, string tagName)
        {
             ApiResponse<ServerListResponse> localVarResponse = UntagWithHttpInfo(serverId, tagName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>ApiResponse of ServerListResponse</returns>
        public ApiResponse< ServerListResponse > UntagWithHttpInfo (Guid? serverId, string tagName)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ServerListResponse</returns>
        public async System.Threading.Tasks.Task<ServerListResponse> UntagAsync (Guid? serverId, string tagName)
        {
             ApiResponse<ServerListResponse> localVarResponse = await UntagAsyncWithHttpInfo(serverId, tagName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove tag from server Untags tags from given server. The tag(s) must exist
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ApiResponse (ServerListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerListResponse>> UntagAsyncWithHttpInfo (Guid? serverId, string tagName)
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
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (serverId != null) localVarPathParams.Add("serverId", Configuration.ApiClient.ParameterToString(serverId)); // path parameter
            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter


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

            return new ApiResponse<ServerListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerListResponse)));
        }

    }
}
