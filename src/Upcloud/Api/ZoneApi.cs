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
    public interface IZoneApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List available zones
        /// </summary>
        /// <remarks>
        /// Returns a list of available zones.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ZoneListResponse</returns>
        ZoneListResponse ListZones ();

        /// <summary>
        /// List available zones
        /// </summary>
        /// <remarks>
        /// Returns a list of available zones.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ZoneListResponse</returns>
        ApiResponse<ZoneListResponse> ListZonesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List available zones
        /// </summary>
        /// <remarks>
        /// Returns a list of available zones.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ZoneListResponse</returns>
        System.Threading.Tasks.Task<ZoneListResponse> ListZonesAsync ();

        /// <summary>
        /// List available zones
        /// </summary>
        /// <remarks>
        /// Returns a list of available zones.
        /// </remarks>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ZoneListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZoneListResponse>> ListZonesAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZoneApi : IZoneApi
    {
        private Upcloud.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZoneApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Upcloud.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZoneApi(Configuration configuration = null)
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
        /// List available zones Returns a list of available zones.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ZoneListResponse</returns>
        public ZoneListResponse ListZones ()
        {
             ApiResponse<ZoneListResponse> localVarResponse = ListZonesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List available zones Returns a list of available zones.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ZoneListResponse</returns>
        public ApiResponse< ZoneListResponse > ListZonesWithHttpInfo ()
        {

            var localVarPath = "/zone";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListZones", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ZoneListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ZoneListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ZoneListResponse)));
        }

        /// <summary>
        /// List available zones Returns a list of available zones.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ZoneListResponse</returns>
        public async System.Threading.Tasks.Task<ZoneListResponse> ListZonesAsync ()
        {
             ApiResponse<ZoneListResponse> localVarResponse = await ListZonesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List available zones Returns a list of available zones.
        /// </summary>
        /// <exception cref="Upcloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ZoneListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ZoneListResponse>> ListZonesAsyncWithHttpInfo ()
        {

            var localVarPath = "/zone";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListZones", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ZoneListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ZoneListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ZoneListResponse)));
        }

    }
}
