/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.6.0
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
    public interface IPublicStaticDefinedListManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all static defined lists in database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List<StaticDefinedList></returns>
        List<StaticDefinedList> HttpStaticDefinedListsGetAll ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all static defined lists in database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List<StaticDefinedList></returns>
        ApiResponse<List<StaticDefinedList>> HttpStaticDefinedListsGetAllWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a static defined list from database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <returns>List<StaticDefinedList></returns>
        List<StaticDefinedList> HttpStaticDefinedListsGetById (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a static defined list from database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <returns>ApiResponse of List<StaticDefinedList></returns>
        ApiResponse<List<StaticDefinedList>> HttpStaticDefinedListsGetByIdWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all static defined lists in database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<StaticDefinedList></returns>
        System.Threading.Tasks.Task<List<StaticDefinedList>> HttpStaticDefinedListsGetAllAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all static defined lists in database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;StaticDefinedList&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StaticDefinedList>>> HttpStaticDefinedListsGetAllWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a static defined list from database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<StaticDefinedList></returns>
        System.Threading.Tasks.Task<List<StaticDefinedList>> HttpStaticDefinedListsGetByIdAsync (string id, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a static defined list from database.
        /// </remarks>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;StaticDefinedList&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StaticDefinedList>>> HttpStaticDefinedListsGetByIdWithHttpInfoAsync (string id, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicStaticDefinedListManagementApi : IPublicStaticDefinedListManagementApi
    {
        private AgravityPublic.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicStaticDefinedListManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicStaticDefinedListManagementApi(String basePath)
        {
            this.Configuration = new AgravityPublic.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AgravityPublic.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicStaticDefinedListManagementApi"/> class
        /// </summary>
        /// <returns></returns>
        public PublicStaticDefinedListManagementApi()
        {
            this.Configuration = AgravityPublic.Client.Configuration.Default;

            ExceptionFactory = AgravityPublic.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicStaticDefinedListManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicStaticDefinedListManagementApi(AgravityPublic.Client.Configuration configuration = null)
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
        public AgravityPublic.Client.Configuration Configuration {get; set;}

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
        ///  This endpoint lists all static defined lists in database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List<StaticDefinedList></returns>
        public List<StaticDefinedList> HttpStaticDefinedListsGetAll ()
        {
             ApiResponse<List<StaticDefinedList>> localVarResponse = HttpStaticDefinedListsGetAllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all static defined lists in database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List<StaticDefinedList></returns>
        public ApiResponse<List<StaticDefinedList>> HttpStaticDefinedListsGetAllWithHttpInfo ()
        {

            var localVarPath = "/staticdefinedlists";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpStaticDefinedListsGetAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StaticDefinedList>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<StaticDefinedList>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StaticDefinedList>)));
        }

        /// <summary>
        ///  This endpoint lists all static defined lists in database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<StaticDefinedList></returns>
        public async System.Threading.Tasks.Task<List<StaticDefinedList>> HttpStaticDefinedListsGetAllAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<StaticDefinedList>> localVarResponse = await HttpStaticDefinedListsGetAllWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  This endpoint lists all static defined lists in database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;StaticDefinedList&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StaticDefinedList>>> HttpStaticDefinedListsGetAllWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/staticdefinedlists";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpStaticDefinedListsGetAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StaticDefinedList>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<StaticDefinedList>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StaticDefinedList>)));
        }

        /// <summary>
        ///  This endpoint gets a static defined list from database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <returns>List<StaticDefinedList></returns>
        public List<StaticDefinedList> HttpStaticDefinedListsGetById (string id)
        {
             ApiResponse<List<StaticDefinedList>> localVarResponse = HttpStaticDefinedListsGetByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint gets a static defined list from database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <returns>ApiResponse of List<StaticDefinedList></returns>
        public ApiResponse<List<StaticDefinedList>> HttpStaticDefinedListsGetByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicStaticDefinedListManagementApi->HttpStaticDefinedListsGetById");

            var localVarPath = "/staticdefinedlists/{id}";
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
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpStaticDefinedListsGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StaticDefinedList>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<StaticDefinedList>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StaticDefinedList>)));
        }

        /// <summary>
        ///  This endpoint gets a static defined list from database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<StaticDefinedList></returns>
        public async System.Threading.Tasks.Task<List<StaticDefinedList>> HttpStaticDefinedListsGetByIdAsync (string id, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<StaticDefinedList>> localVarResponse = await HttpStaticDefinedListsGetByIdWithHttpInfoAsync(id, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  This endpoint gets a static defined list from database.
        /// </summary>
        /// <exception cref="AgravityPublic.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the static defined list.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;StaticDefinedList&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StaticDefinedList>>> HttpStaticDefinedListsGetByIdWithHttpInfoAsync (string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicStaticDefinedListManagementApi->HttpStaticDefinedListsGetById");

            var localVarPath = "/staticdefinedlists/{id}";
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
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HttpStaticDefinedListsGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StaticDefinedList>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<StaticDefinedList>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StaticDefinedList>)));
        }

    }
}
