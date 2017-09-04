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
    public interface ITagApi : IApiAccessor
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
        /// Create a new tag
        /// </summary>
        /// <remarks>
        /// Creates a new tag. Existing servers can be tagged in same request
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>CreateNewTagResponse</returns>
        CreateNewTagResponse CreateTag (Tag tag);

        /// <summary>
        /// Create a new tag
        /// </summary>
        /// <remarks>
        /// Creates a new tag. Existing servers can be tagged in same request
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>ApiResponse of CreateNewTagResponse</returns>
        ApiResponse<CreateNewTagResponse> CreateTagWithHttpInfo (Tag tag);
        /// <summary>
        /// Delete tag
        /// </summary>
        /// <remarks>
        /// Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns></returns>
        void DeleteTag (string tagName);

        /// <summary>
        /// Delete tag
        /// </summary>
        /// <remarks>
        /// Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTagWithHttpInfo (string tagName);
        /// <summary>
        /// List existing tags
        /// </summary>
        /// <remarks>
        /// Returns all existing tags with their properties and servers tagged
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TagListResponse</returns>
        TagListResponse ListTags ();

        /// <summary>
        /// List existing tags
        /// </summary>
        /// <remarks>
        /// Returns all existing tags with their properties and servers tagged
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TagListResponse</returns>
        ApiResponse<TagListResponse> ListTagsWithHttpInfo ();
        /// <summary>
        /// Modify existing tag
        /// </summary>
        /// <remarks>
        /// Changes attributes of an existing tag
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>CreateNewTagResponse</returns>
        CreateNewTagResponse ModifyTag (string tagName, Tag1 tag);

        /// <summary>
        /// Modify existing tag
        /// </summary>
        /// <remarks>
        /// Changes attributes of an existing tag
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>ApiResponse of CreateNewTagResponse</returns>
        ApiResponse<CreateNewTagResponse> ModifyTagWithHttpInfo (string tagName, Tag1 tag);
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
        /// Create a new tag
        /// </summary>
        /// <remarks>
        /// Creates a new tag. Existing servers can be tagged in same request
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>Task of CreateNewTagResponse</returns>
        System.Threading.Tasks.Task<CreateNewTagResponse> CreateTagAsync (Tag tag);

        /// <summary>
        /// Create a new tag
        /// </summary>
        /// <remarks>
        /// Creates a new tag. Existing servers can be tagged in same request
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>Task of ApiResponse (CreateNewTagResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateNewTagResponse>> CreateTagAsyncWithHttpInfo (Tag tag);
        /// <summary>
        /// Delete tag
        /// </summary>
        /// <remarks>
        /// Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteTagAsync (string tagName);

        /// <summary>
        /// Delete tag
        /// </summary>
        /// <remarks>
        /// Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTagAsyncWithHttpInfo (string tagName);
        /// <summary>
        /// List existing tags
        /// </summary>
        /// <remarks>
        /// Returns all existing tags with their properties and servers tagged
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TagListResponse</returns>
        System.Threading.Tasks.Task<TagListResponse> ListTagsAsync ();

        /// <summary>
        /// List existing tags
        /// </summary>
        /// <remarks>
        /// Returns all existing tags with their properties and servers tagged
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TagListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TagListResponse>> ListTagsAsyncWithHttpInfo ();
        /// <summary>
        /// Modify existing tag
        /// </summary>
        /// <remarks>
        /// Changes attributes of an existing tag
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>Task of CreateNewTagResponse</returns>
        System.Threading.Tasks.Task<CreateNewTagResponse> ModifyTagAsync (string tagName, Tag1 tag);

        /// <summary>
        /// Modify existing tag
        /// </summary>
        /// <remarks>
        /// Changes attributes of an existing tag
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>Task of ApiResponse (CreateNewTagResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateNewTagResponse>> ModifyTagAsyncWithHttpInfo (string tagName, Tag1 tag);
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
    public partial class TagApi : ITagApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TagApi(Configuration configuration = null)
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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling TagApi->AssignTag");
            // verify the required parameter 'tagList' is set
            if (tagList == null)
                throw new ApiException(400, "Missing required parameter 'tagList' when calling TagApi->AssignTag");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling TagApi->AssignTag");
            // verify the required parameter 'tagList' is set
            if (tagList == null)
                throw new ApiException(400, "Missing required parameter 'tagList' when calling TagApi->AssignTag");

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
        /// Create a new tag Creates a new tag. Existing servers can be tagged in same request
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>CreateNewTagResponse</returns>
        public CreateNewTagResponse CreateTag (Tag tag)
        {
             ApiResponse<CreateNewTagResponse> localVarResponse = CreateTagWithHttpInfo(tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new tag Creates a new tag. Existing servers can be tagged in same request
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>ApiResponse of CreateNewTagResponse</returns>
        public ApiResponse< CreateNewTagResponse > CreateTagWithHttpInfo (Tag tag)
        {
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling TagApi->CreateTag");

            var localVarPath = "/tag";
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

            if (tag != null && tag.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tag); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tag; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateNewTagResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateNewTagResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateNewTagResponse)));
        }

        /// <summary>
        /// Create a new tag Creates a new tag. Existing servers can be tagged in same request
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>Task of CreateNewTagResponse</returns>
        public async System.Threading.Tasks.Task<CreateNewTagResponse> CreateTagAsync (Tag tag)
        {
             ApiResponse<CreateNewTagResponse> localVarResponse = await CreateTagAsyncWithHttpInfo(tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new tag Creates a new tag. Existing servers can be tagged in same request
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag"></param>
        /// <returns>Task of ApiResponse (CreateNewTagResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateNewTagResponse>> CreateTagAsyncWithHttpInfo (Tag tag)
        {
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling TagApi->CreateTag");

            var localVarPath = "/tag";
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

            if (tag != null && tag.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tag); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tag; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateNewTagResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateNewTagResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateNewTagResponse)));
        }

        /// <summary>
        /// Delete tag Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns></returns>
        public void DeleteTag (string tagName)
        {
             DeleteTagWithHttpInfo(tagName);
        }

        /// <summary>
        /// Delete tag Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteTagWithHttpInfo (string tagName)
        {
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling TagApi->DeleteTag");

            var localVarPath = "/tag/{tagName}";
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

            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete tag Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteTagAsync (string tagName)
        {
             await DeleteTagAsyncWithHttpInfo(tagName);

        }

        /// <summary>
        /// Delete tag Deleting existing tag untags all servers from specified tag and deletes tag definition
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTagAsyncWithHttpInfo (string tagName)
        {
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling TagApi->DeleteTag");

            var localVarPath = "/tag/{tagName}";
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

            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// List existing tags Returns all existing tags with their properties and servers tagged
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TagListResponse</returns>
        public TagListResponse ListTags ()
        {
             ApiResponse<TagListResponse> localVarResponse = ListTagsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List existing tags Returns all existing tags with their properties and servers tagged
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TagListResponse</returns>
        public ApiResponse< TagListResponse > ListTagsWithHttpInfo ()
        {

            var localVarPath = "/tag";
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
                Exception exception = ExceptionFactory("ListTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TagListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagListResponse)));
        }

        /// <summary>
        /// List existing tags Returns all existing tags with their properties and servers tagged
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TagListResponse</returns>
        public async System.Threading.Tasks.Task<TagListResponse> ListTagsAsync ()
        {
             ApiResponse<TagListResponse> localVarResponse = await ListTagsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List existing tags Returns all existing tags with their properties and servers tagged
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TagListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TagListResponse>> ListTagsAsyncWithHttpInfo ()
        {

            var localVarPath = "/tag";
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
                Exception exception = ExceptionFactory("ListTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TagListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TagListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TagListResponse)));
        }

        /// <summary>
        /// Modify existing tag Changes attributes of an existing tag
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>CreateNewTagResponse</returns>
        public CreateNewTagResponse ModifyTag (string tagName, Tag1 tag)
        {
             ApiResponse<CreateNewTagResponse> localVarResponse = ModifyTagWithHttpInfo(tagName, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify existing tag Changes attributes of an existing tag
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>ApiResponse of CreateNewTagResponse</returns>
        public ApiResponse< CreateNewTagResponse > ModifyTagWithHttpInfo (string tagName, Tag1 tag)
        {
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling TagApi->ModifyTag");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling TagApi->ModifyTag");

            var localVarPath = "/tag/{tagName}";
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

            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter
            if (tag != null && tag.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tag); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tag; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ModifyTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateNewTagResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateNewTagResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateNewTagResponse)));
        }

        /// <summary>
        /// Modify existing tag Changes attributes of an existing tag
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>Task of CreateNewTagResponse</returns>
        public async System.Threading.Tasks.Task<CreateNewTagResponse> ModifyTagAsync (string tagName, Tag1 tag)
        {
             ApiResponse<CreateNewTagResponse> localVarResponse = await ModifyTagAsyncWithHttpInfo(tagName, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify existing tag Changes attributes of an existing tag
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Tag name</param>
        /// <param name="tag"></param>
        /// <returns>Task of ApiResponse (CreateNewTagResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateNewTagResponse>> ModifyTagAsyncWithHttpInfo (string tagName, Tag1 tag)
        {
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling TagApi->ModifyTag");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling TagApi->ModifyTag");

            var localVarPath = "/tag/{tagName}";
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

            if (tagName != null) localVarPathParams.Add("tagName", Configuration.ApiClient.ParameterToString(tagName)); // path parameter
            if (tag != null && tag.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(tag); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tag; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ModifyTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateNewTagResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateNewTagResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateNewTagResponse)));
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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling TagApi->Untag");
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling TagApi->Untag");

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
                throw new ApiException(400, "Missing required parameter 'serverId' when calling TagApi->Untag");
            // verify the required parameter 'tagName' is set
            if (tagName == null)
                throw new ApiException(400, "Missing required parameter 'tagName' when calling TagApi->Untag");

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
