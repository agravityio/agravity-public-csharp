/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.7.2
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using AgravityPublic.Client;
using AgravityPublic.Model;

namespace AgravityPublic.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicCollectionTypeManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List<CollectionType></returns>
        List<CollectionType> HttpCollectionTypesGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List<CollectionType></returns>
        ApiResponse<List<CollectionType>> HttpCollectionTypesGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single collection type (from ID).
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <returns>CollectionType</returns>
        CollectionType HttpCollectionTypesGetById(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single collection type (from ID).
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <returns>ApiResponse of CollectionType</returns>
        ApiResponse<CollectionType> HttpCollectionTypesGetByIdWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This method returns a list of collection types items.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <returns>List<CollTypeItem></returns>
        List<CollTypeItem> HttpGetCollectionTypeItems(bool? includeblueprint = default(bool?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This method returns a list of collection types items.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <returns>ApiResponse of List<CollTypeItem></returns>
        ApiResponse<List<CollTypeItem>> HttpGetCollectionTypeItemsWithHttpInfo(bool? includeblueprint = default(bool?));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<CollectionType></returns>
        System.Threading.Tasks.Task<List<CollectionType>> HttpCollectionTypesGetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;CollectionType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CollectionType>>> HttpCollectionTypesGetWithHttpInfoAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single collection type (from ID).
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CollectionType</returns>
        System.Threading.Tasks.Task<CollectionType> HttpCollectionTypesGetByIdAsync(string id, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single collection type (from ID).
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CollectionType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionType>> HttpCollectionTypesGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This method returns a list of collection types items.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<CollTypeItem></returns>
        System.Threading.Tasks.Task<List<CollTypeItem>> HttpGetCollectionTypeItemsAsync(bool? includeblueprint = default(bool?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This method returns a list of collection types items.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;CollTypeItem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CollTypeItem>>> HttpGetCollectionTypeItemsWithHttpInfoAsync(bool? includeblueprint = default(bool?), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicCollectionTypeManagementApi : IPublicCollectionTypeManagementApi
    {
        private AgravityPublic.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionTypeManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicCollectionTypeManagementApi(String basePath)
        {
            this.Configuration = new AgravityPublic.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AgravityPublic.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionTypeManagementApi"/> class
        /// </summary>
        /// <returns></returns>
        public PublicCollectionTypeManagementApi()
        {
            this.Configuration = AgravityPublic.Client.Configuration.Default;

            ExceptionFactory = AgravityPublic.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionTypeManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicCollectionTypeManagementApi(AgravityPublic.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AgravityPublic.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AgravityPublic.Client.Configuration.DefaultExceptionFactory;
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
        public AgravityPublic.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AgravityPublic.Client.ExceptionFactory ExceptionFactory
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
        ///  This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List<CollectionType></returns>
        public List<CollectionType> HttpCollectionTypesGet()
        {
            ApiResponse<List<CollectionType>> localVarResponse = HttpCollectionTypesGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List<CollectionType></returns>
        public ApiResponse<List<CollectionType>> HttpCollectionTypesGetWithHttpInfo()
        {

            var localVarPath = "/collectiontypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (function_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarHeaderParams["x-functions-key"] = this.Configuration.GetApiKeyWithPrefix("x-functions-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpCollectionTypesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CollectionType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<CollectionType>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CollectionType>)));
        }

        /// <summary>
        ///  This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<CollectionType></returns>
        public async System.Threading.Tasks.Task<List<CollectionType>> HttpCollectionTypesGetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<List<CollectionType>> localVarResponse = await HttpCollectionTypesGetWithHttpInfoAsync(cancellationToken);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  This lists all available collection types which are stored in the database and not deleted (status \"A\").
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;CollectionType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CollectionType>>> HttpCollectionTypesGetWithHttpInfoAsync(CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/collectiontypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (function_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarHeaderParams["x-functions-key"] = this.Configuration.GetApiKeyWithPrefix("x-functions-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpCollectionTypesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CollectionType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<CollectionType>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CollectionType>)));
        }

        /// <summary>
        ///  Returns one single collection type (from ID).
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <returns>CollectionType</returns>
        public CollectionType HttpCollectionTypesGetById(string id)
        {
            ApiResponse<CollectionType> localVarResponse = HttpCollectionTypesGetByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns one single collection type (from ID).
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <returns>ApiResponse of CollectionType</returns>
        public ApiResponse<CollectionType> HttpCollectionTypesGetByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicCollectionTypeManagementApi->HttpCollectionTypesGetById");

            var localVarPath = "/collectiontypes/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (function_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarHeaderParams["x-functions-key"] = this.Configuration.GetApiKeyWithPrefix("x-functions-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpCollectionTypesGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CollectionType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionType)));
        }

        /// <summary>
        ///  Returns one single collection type (from ID).
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CollectionType</returns>
        public async System.Threading.Tasks.Task<CollectionType> HttpCollectionTypesGetByIdAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<CollectionType> localVarResponse = await HttpCollectionTypesGetByIdWithHttpInfoAsync(id, cancellationToken);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns one single collection type (from ID).
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the collection type.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CollectionType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CollectionType>> HttpCollectionTypesGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicCollectionTypeManagementApi->HttpCollectionTypesGetById");

            var localVarPath = "/collectiontypes/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (function_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarHeaderParams["x-functions-key"] = this.Configuration.GetApiKeyWithPrefix("x-functions-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpCollectionTypesGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CollectionType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionType)));
        }

        /// <summary>
        ///  This method returns a list of collection types items.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <returns>List<CollTypeItem></returns>
        public List<CollTypeItem> HttpGetCollectionTypeItems(bool? includeblueprint = default(bool?))
        {
            ApiResponse<List<CollTypeItem>> localVarResponse = HttpGetCollectionTypeItemsWithHttpInfo(includeblueprint);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This method returns a list of collection types items.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <returns>ApiResponse of List<CollTypeItem></returns>
        public ApiResponse<List<CollTypeItem>> HttpGetCollectionTypeItemsWithHttpInfo(bool? includeblueprint = default(bool?))
        {

            var localVarPath = "/collectiontypesitems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeblueprint != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeblueprint", includeblueprint)); // query parameter

            // authentication (function_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarHeaderParams["x-functions-key"] = this.Configuration.GetApiKeyWithPrefix("x-functions-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpGetCollectionTypeItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CollTypeItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<CollTypeItem>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CollTypeItem>)));
        }

        /// <summary>
        ///  This method returns a list of collection types items.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<CollTypeItem></returns>
        public async System.Threading.Tasks.Task<List<CollTypeItem>> HttpGetCollectionTypeItemsAsync(bool? includeblueprint = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiResponse<List<CollTypeItem>> localVarResponse = await HttpGetCollectionTypeItemsWithHttpInfoAsync(includeblueprint, cancellationToken);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  This method returns a list of collection types items.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeblueprint">True if the blueprint items should be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;CollTypeItem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CollTypeItem>>> HttpGetCollectionTypeItemsWithHttpInfoAsync(bool? includeblueprint = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/collectiontypesitems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeblueprint != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeblueprint", includeblueprint)); // query parameter

            // authentication (function_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarHeaderParams["x-functions-key"] = this.Configuration.GetApiKeyWithPrefix("x-functions-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpGetCollectionTypeItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CollTypeItem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<CollTypeItem>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CollTypeItem>)));
        }

    }
}
