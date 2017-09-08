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
    public interface IFirewallApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateFirewallRuleWithHttpInfo (Guid? serverId, FirewallRule firewallRule);
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
        void DeleteFirewallRule (Guid? serverId, Guid? firewallRuleNumber);

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
        ApiResponse<Object> DeleteFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of FirewallRuleDetailsResponse</returns>
        ApiResponse<FirewallRuleDetailsResponse> GetFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
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
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create firewall rule
        /// </summary>
        /// <remarks>
        /// Creates a new firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateFirewallRuleAsyncWithHttpInfo (Guid? serverId, FirewallRule firewallRule);
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
        System.Threading.Tasks.Task DeleteFirewallRuleAsync (Guid? serverId, Guid? firewallRuleNumber);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
        /// <summary>
        /// Get firewall rule details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific firewall rule
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse (FirewallRuleDetailsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FirewallRuleDetailsResponse>> GetFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber);
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
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FirewallApi : IFirewallApi
    {
        private Upcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FirewallApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Upcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FirewallApi(Configuration configuration = null)
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
        /// Create firewall rule Creates a new firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateFirewallRuleWithHttpInfo (Guid? serverId, FirewallRule firewallRule)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->CreateFirewallRule");
            // verify the required parameter 'firewallRule' is set
            if (firewallRule == null)
                throw new ApiException(400, "Missing required parameter 'firewallRule' when calling FirewallApi->CreateFirewallRule");

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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRule"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateFirewallRuleAsyncWithHttpInfo (Guid? serverId, FirewallRule firewallRule)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->CreateFirewallRule");
            // verify the required parameter 'firewallRule' is set
            if (firewallRule == null)
                throw new ApiException(400, "Missing required parameter 'firewallRule' when calling FirewallApi->CreateFirewallRule");

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
        /// Remove firewall rule Removes a firewall rule from a server. Firewall rules must be removed individually. The positions of remaining firewall rules will be adjusted after a rule is removed.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->DeleteFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling FirewallApi->DeleteFirewallRule");

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
        public async System.Threading.Tasks.Task DeleteFirewallRuleAsync (Guid? serverId, Guid? firewallRuleNumber)
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
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->DeleteFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling FirewallApi->DeleteFirewallRule");

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
        /// Get firewall rule details Returns detailed information about a specific firewall rule
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>ApiResponse of FirewallRuleDetailsResponse</returns>
        public ApiResponse< FirewallRuleDetailsResponse > GetFirewallRuleWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->GetFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling FirewallApi->GetFirewallRule");

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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverId">Server id</param>
        /// <param name="firewallRuleNumber">Denotes the index of the firewall rule in the server&#39;s firewall rule list</param>
        /// <returns>Task of ApiResponse (FirewallRuleDetailsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FirewallRuleDetailsResponse>> GetFirewallRuleAsyncWithHttpInfo (Guid? serverId, Guid? firewallRuleNumber)
        {
            // verify the required parameter 'serverId' is set
            if (serverId == null)
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->GetFirewallRule");
            // verify the required parameter 'firewallRuleNumber' is set
            if (firewallRuleNumber == null)
                throw new ApiException(400, "Missing required parameter 'firewallRuleNumber' when calling FirewallApi->GetFirewallRule");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->ServerServerIdFirewallRuleGet");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling FirewallApi->ServerServerIdFirewallRuleGet");

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

    }
}
