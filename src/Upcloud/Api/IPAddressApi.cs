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
    public interface IIPAddressApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assign IP address
        /// </summary>
        /// <remarks>
        /// Assigns a new IP address to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>AssignIpResponse</returns>
        AssignIpResponse AddIp (AddIpRequest ipAddress = null);

        /// <summary>
        /// Assign IP address
        /// </summary>
        /// <remarks>
        /// Assigns a new IP address to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>ApiResponse of AssignIpResponse</returns>
        ApiResponse<AssignIpResponse> AddIpWithHttpInfo (AddIpRequest ipAddress = null);
        /// <summary>
        /// Release IP address
        /// </summary>
        /// <remarks>
        /// Removes an IP address from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns></returns>
        void DeleteIp (string ip);

        /// <summary>
        /// Release IP address
        /// </summary>
        /// <remarks>
        /// Removes an IP address from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteIpWithHttpInfo (string ip);
        /// <summary>
        /// Get IP address details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>AssignIpResponse</returns>
        AssignIpResponse GetDetails (string ip);

        /// <summary>
        /// Get IP address details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>ApiResponse of AssignIpResponse</returns>
        ApiResponse<AssignIpResponse> GetDetailsWithHttpInfo (string ip);
        /// <summary>
        /// List IP addresses
        /// </summary>
        /// <remarks>
        /// Returns a list of all IP addresses assigned to servers on the current user account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IpAddressListResponse</returns>
        IpAddressListResponse ListIps ();

        /// <summary>
        /// List IP addresses
        /// </summary>
        /// <remarks>
        /// Returns a list of all IP addresses assigned to servers on the current user account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IpAddressListResponse</returns>
        ApiResponse<IpAddressListResponse> ListIpsWithHttpInfo ();
        /// <summary>
        /// Modify IP address
        /// </summary>
        /// <remarks>
        /// Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>AssignIpResponse</returns>
        AssignIpResponse ModifyIp (string ip, ModifyIpRequest ipAddress = null);

        /// <summary>
        /// Modify IP address
        /// </summary>
        /// <remarks>
        /// Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>ApiResponse of AssignIpResponse</returns>
        ApiResponse<AssignIpResponse> ModifyIpWithHttpInfo (string ip, ModifyIpRequest ipAddress = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Assign IP address
        /// </summary>
        /// <remarks>
        /// Assigns a new IP address to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of AssignIpResponse</returns>
        System.Threading.Tasks.Task<AssignIpResponse> AddIpAsync (AddIpRequest ipAddress = null);

        /// <summary>
        /// Assign IP address
        /// </summary>
        /// <remarks>
        /// Assigns a new IP address to a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of ApiResponse (AssignIpResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssignIpResponse>> AddIpAsyncWithHttpInfo (AddIpRequest ipAddress = null);
        /// <summary>
        /// Release IP address
        /// </summary>
        /// <remarks>
        /// Removes an IP address from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteIpAsync (string ip);

        /// <summary>
        /// Release IP address
        /// </summary>
        /// <remarks>
        /// Removes an IP address from a server.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIpAsyncWithHttpInfo (string ip);
        /// <summary>
        /// Get IP address details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of AssignIpResponse</returns>
        System.Threading.Tasks.Task<AssignIpResponse> GetDetailsAsync (string ip);

        /// <summary>
        /// Get IP address details
        /// </summary>
        /// <remarks>
        /// Returns detailed information about a specific IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of ApiResponse (AssignIpResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssignIpResponse>> GetDetailsAsyncWithHttpInfo (string ip);
        /// <summary>
        /// List IP addresses
        /// </summary>
        /// <remarks>
        /// Returns a list of all IP addresses assigned to servers on the current user account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IpAddressListResponse</returns>
        System.Threading.Tasks.Task<IpAddressListResponse> ListIpsAsync ();

        /// <summary>
        /// List IP addresses
        /// </summary>
        /// <remarks>
        /// Returns a list of all IP addresses assigned to servers on the current user account.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IpAddressListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IpAddressListResponse>> ListIpsAsyncWithHttpInfo ();
        /// <summary>
        /// Modify IP address
        /// </summary>
        /// <remarks>
        /// Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of AssignIpResponse</returns>
        System.Threading.Tasks.Task<AssignIpResponse> ModifyIpAsync (string ip, ModifyIpRequest ipAddress = null);

        /// <summary>
        /// Modify IP address
        /// </summary>
        /// <remarks>
        /// Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of ApiResponse (AssignIpResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssignIpResponse>> ModifyIpAsyncWithHttpInfo (string ip, ModifyIpRequest ipAddress = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IPAddressApi : IIPAddressApi
    {
        private Upcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IPAddressApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Upcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IPAddressApi(Configuration configuration = null)
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
        /// Assign IP address Assigns a new IP address to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>AssignIpResponse</returns>
        public AssignIpResponse AddIp (AddIpRequest ipAddress = null)
        {
             ApiResponse<AssignIpResponse> localVarResponse = AddIpWithHttpInfo(ipAddress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Assign IP address Assigns a new IP address to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>ApiResponse of AssignIpResponse</returns>
        public ApiResponse< AssignIpResponse > AddIpWithHttpInfo (AddIpRequest ipAddress = null)
        {

            var localVarPath = "/ip_address";
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

            if (ipAddress != null && ipAddress.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ipAddress); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ipAddress; // byte array
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
                Exception exception = ExceptionFactory("AddIp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssignIpResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AssignIpResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignIpResponse)));
        }

        /// <summary>
        /// Assign IP address Assigns a new IP address to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of AssignIpResponse</returns>
        public async System.Threading.Tasks.Task<AssignIpResponse> AddIpAsync (AddIpRequest ipAddress = null)
        {
             ApiResponse<AssignIpResponse> localVarResponse = await AddIpAsyncWithHttpInfo(ipAddress);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Assign IP address Assigns a new IP address to a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of ApiResponse (AssignIpResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AssignIpResponse>> AddIpAsyncWithHttpInfo (AddIpRequest ipAddress = null)
        {

            var localVarPath = "/ip_address";
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

            if (ipAddress != null && ipAddress.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ipAddress); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ipAddress; // byte array
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
                Exception exception = ExceptionFactory("AddIp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssignIpResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AssignIpResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignIpResponse)));
        }

        /// <summary>
        /// Release IP address Removes an IP address from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns></returns>
        public void DeleteIp (string ip)
        {
             DeleteIpWithHttpInfo(ip);
        }

        /// <summary>
        /// Release IP address Removes an IP address from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteIpWithHttpInfo (string ip)
        {
            // verify the required parameter 'ip' is set
            if (ip == null)
                throw new ApiException(400, "Missing required parameter 'ip' when calling IPAddressApi->DeleteIp");

            var localVarPath = "/ip_address/{ip}";
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

            if (ip != null) localVarPathParams.Add("ip", Configuration.ApiClient.ParameterToString(ip)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteIp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Release IP address Removes an IP address from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteIpAsync (string ip)
        {
             await DeleteIpAsyncWithHttpInfo(ip);

        }

        /// <summary>
        /// Release IP address Removes an IP address from a server.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteIpAsyncWithHttpInfo (string ip)
        {
            // verify the required parameter 'ip' is set
            if (ip == null)
                throw new ApiException(400, "Missing required parameter 'ip' when calling IPAddressApi->DeleteIp");

            var localVarPath = "/ip_address/{ip}";
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

            if (ip != null) localVarPathParams.Add("ip", Configuration.ApiClient.ParameterToString(ip)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteIp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get IP address details Returns detailed information about a specific IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>AssignIpResponse</returns>
        public AssignIpResponse GetDetails (string ip)
        {
             ApiResponse<AssignIpResponse> localVarResponse = GetDetailsWithHttpInfo(ip);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IP address details Returns detailed information about a specific IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>ApiResponse of AssignIpResponse</returns>
        public ApiResponse< AssignIpResponse > GetDetailsWithHttpInfo (string ip)
        {
            // verify the required parameter 'ip' is set
            if (ip == null)
                throw new ApiException(400, "Missing required parameter 'ip' when calling IPAddressApi->GetDetails");

            var localVarPath = "/ip_address/{ip}";
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

            if (ip != null) localVarPathParams.Add("ip", Configuration.ApiClient.ParameterToString(ip)); // path parameter

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
                Exception exception = ExceptionFactory("GetDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssignIpResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AssignIpResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignIpResponse)));
        }

        /// <summary>
        /// Get IP address details Returns detailed information about a specific IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of AssignIpResponse</returns>
        public async System.Threading.Tasks.Task<AssignIpResponse> GetDetailsAsync (string ip)
        {
             ApiResponse<AssignIpResponse> localVarResponse = await GetDetailsAsyncWithHttpInfo(ip);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IP address details Returns detailed information about a specific IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <returns>Task of ApiResponse (AssignIpResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AssignIpResponse>> GetDetailsAsyncWithHttpInfo (string ip)
        {
            // verify the required parameter 'ip' is set
            if (ip == null)
                throw new ApiException(400, "Missing required parameter 'ip' when calling IPAddressApi->GetDetails");

            var localVarPath = "/ip_address/{ip}";
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

            if (ip != null) localVarPathParams.Add("ip", Configuration.ApiClient.ParameterToString(ip)); // path parameter

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
                Exception exception = ExceptionFactory("GetDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssignIpResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AssignIpResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignIpResponse)));
        }

        /// <summary>
        /// List IP addresses Returns a list of all IP addresses assigned to servers on the current user account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>IpAddressListResponse</returns>
        public IpAddressListResponse ListIps ()
        {
             ApiResponse<IpAddressListResponse> localVarResponse = ListIpsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List IP addresses Returns a list of all IP addresses assigned to servers on the current user account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of IpAddressListResponse</returns>
        public ApiResponse< IpAddressListResponse > ListIpsWithHttpInfo ()
        {

            var localVarPath = "/ip_address";
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
                Exception exception = ExceptionFactory("ListIps", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IpAddressListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IpAddressListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IpAddressListResponse)));
        }

        /// <summary>
        /// List IP addresses Returns a list of all IP addresses assigned to servers on the current user account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of IpAddressListResponse</returns>
        public async System.Threading.Tasks.Task<IpAddressListResponse> ListIpsAsync ()
        {
             ApiResponse<IpAddressListResponse> localVarResponse = await ListIpsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List IP addresses Returns a list of all IP addresses assigned to servers on the current user account.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (IpAddressListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IpAddressListResponse>> ListIpsAsyncWithHttpInfo ()
        {

            var localVarPath = "/ip_address";
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
                Exception exception = ExceptionFactory("ListIps", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IpAddressListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IpAddressListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IpAddressListResponse)));
        }

        /// <summary>
        /// Modify IP address Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>AssignIpResponse</returns>
        public AssignIpResponse ModifyIp (string ip, ModifyIpRequest ipAddress = null)
        {
             ApiResponse<AssignIpResponse> localVarResponse = ModifyIpWithHttpInfo(ip, ipAddress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify IP address Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>ApiResponse of AssignIpResponse</returns>
        public ApiResponse< AssignIpResponse > ModifyIpWithHttpInfo (string ip, ModifyIpRequest ipAddress = null)
        {
            // verify the required parameter 'ip' is set
            if (ip == null)
                throw new ApiException(400, "Missing required parameter 'ip' when calling IPAddressApi->ModifyIp");

            var localVarPath = "/ip_address/{ip}";
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

            if (ip != null) localVarPathParams.Add("ip", Configuration.ApiClient.ParameterToString(ip)); // path parameter
            if (ipAddress != null && ipAddress.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ipAddress); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ipAddress; // byte array
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
                Exception exception = ExceptionFactory("ModifyIp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssignIpResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AssignIpResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignIpResponse)));
        }

        /// <summary>
        /// Modify IP address Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of AssignIpResponse</returns>
        public async System.Threading.Tasks.Task<AssignIpResponse> ModifyIpAsync (string ip, ModifyIpRequest ipAddress = null)
        {
             ApiResponse<AssignIpResponse> localVarResponse = await ModifyIpAsyncWithHttpInfo(ip, ipAddress);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify IP address Modifies the reverse DNS PTR record corresponding to an IP address. The PTR record can only be set to public IP address.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">Ip address</param>
        /// <param name="ipAddress"> (optional)</param>
        /// <returns>Task of ApiResponse (AssignIpResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AssignIpResponse>> ModifyIpAsyncWithHttpInfo (string ip, ModifyIpRequest ipAddress = null)
        {
            // verify the required parameter 'ip' is set
            if (ip == null)
                throw new ApiException(400, "Missing required parameter 'ip' when calling IPAddressApi->ModifyIp");

            var localVarPath = "/ip_address/{ip}";
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

            if (ip != null) localVarPathParams.Add("ip", Configuration.ApiClient.ParameterToString(ip)); // path parameter
            if (ipAddress != null && ipAddress.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(ipAddress); // http body (model) parameter
            }
            else
            {
                localVarPostBody = ipAddress; // byte array
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
                Exception exception = ExceptionFactory("ModifyIp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AssignIpResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AssignIpResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignIpResponse)));
        }

    }
}
