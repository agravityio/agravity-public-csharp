/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.1.0
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Agravity.Public.Client;
using Agravity.Public.Model;

namespace Agravity.Public.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicCollectionSecureUploadApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SecureUploadEntity</returns>
        SecureUploadEntity HttpSecureUploadEntityCheckById(string id, string code, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SecureUploadEntity</returns>
        ApiResponse<SecureUploadEntity> HttpSecureUploadEntityCheckByIdWithHttpInfo(string id, string code, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        Asset HttpSecureUploadFileById(string id, string code, Object body, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> HttpSecureUploadFileByIdWithHttpInfo(string id, string code, Object body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicCollectionSecureUploadApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SecureUploadEntity</returns>
        System.Threading.Tasks.Task<SecureUploadEntity> HttpSecureUploadEntityCheckByIdAsync(string id, string code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SecureUploadEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecureUploadEntity>> HttpSecureUploadEntityCheckByIdWithHttpInfoAsync(string id, string code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> HttpSecureUploadFileByIdAsync(string id, string code, Object body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> HttpSecureUploadFileByIdWithHttpInfoAsync(string id, string code, Object body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicCollectionSecureUploadApi : IPublicCollectionSecureUploadApiSync, IPublicCollectionSecureUploadApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicCollectionSecureUploadApi : IPublicCollectionSecureUploadApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionSecureUploadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicCollectionSecureUploadApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionSecureUploadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicCollectionSecureUploadApi(string basePath)
        {
            this.Configuration = Agravity.Public.Client.Configuration.MergeConfigurations(
                Agravity.Public.Client.GlobalConfiguration.Instance,
                new Agravity.Public.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Agravity.Public.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Agravity.Public.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Agravity.Public.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionSecureUploadApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicCollectionSecureUploadApi(Agravity.Public.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Agravity.Public.Client.Configuration.MergeConfigurations(
                Agravity.Public.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Agravity.Public.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Agravity.Public.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Agravity.Public.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCollectionSecureUploadApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicCollectionSecureUploadApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Agravity.Public.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Agravity.Public.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Agravity.Public.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Agravity.Public.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Agravity.Public.Client.ExceptionFactory ExceptionFactory
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
        ///  Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SecureUploadEntity</returns>
        public SecureUploadEntity HttpSecureUploadEntityCheckById(string id, string code, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<SecureUploadEntity> localVarResponse = HttpSecureUploadEntityCheckByIdWithHttpInfo(id, code);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SecureUploadEntity</returns>
        public Agravity.Public.Client.ApiResponse<SecureUploadEntity> HttpSecureUploadEntityCheckByIdWithHttpInfo(string id, string code, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicCollectionSecureUploadApi->HttpSecureUploadEntityCheckById");
            }

            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'code' when calling PublicCollectionSecureUploadApi->HttpSecureUploadEntityCheckById");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Agravity.Public.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Agravity.Public.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "code", code));

            localVarRequestOptions.Operation = "PublicCollectionSecureUploadApi.HttpSecureUploadEntityCheckById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SecureUploadEntity>("/secureupload/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSecureUploadEntityCheckById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SecureUploadEntity</returns>
        public async System.Threading.Tasks.Task<SecureUploadEntity> HttpSecureUploadEntityCheckByIdAsync(string id, string code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Agravity.Public.Client.ApiResponse<SecureUploadEntity> localVarResponse = await HttpSecureUploadEntityCheckByIdWithHttpInfoAsync(id, code, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Searchs for one single secure upload entity of an user and returns simple OK if found.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SecureUploadEntity)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<SecureUploadEntity>> HttpSecureUploadEntityCheckByIdWithHttpInfoAsync(string id, string code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicCollectionSecureUploadApi->HttpSecureUploadEntityCheckById");
            }

            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'code' when calling PublicCollectionSecureUploadApi->HttpSecureUploadEntityCheckById");
            }


            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Agravity.Public.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Agravity.Public.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "code", code));

            localVarRequestOptions.Operation = "PublicCollectionSecureUploadApi.HttpSecureUploadEntityCheckById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SecureUploadEntity>("/secureupload/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSecureUploadEntityCheckById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        public Asset HttpSecureUploadFileById(string id, string code, Object body, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = HttpSecureUploadFileByIdWithHttpInfo(id, code, body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        public Agravity.Public.Client.ApiResponse<Asset> HttpSecureUploadFileByIdWithHttpInfo(string id, string code, Object body, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicCollectionSecureUploadApi->HttpSecureUploadFileById");
            }

            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'code' when calling PublicCollectionSecureUploadApi->HttpSecureUploadFileById");
            }

            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'body' when calling PublicCollectionSecureUploadApi->HttpSecureUploadFileById");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Agravity.Public.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Agravity.Public.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "code", code));
            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "PublicCollectionSecureUploadApi.HttpSecureUploadFileById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Asset>("/secureupload/{id}/upload", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSecureUploadFileById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> HttpSecureUploadFileByIdAsync(string id, string code, Object body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = await HttpSecureUploadFileByIdWithHttpInfoAsync(id, code, body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint allows to securly upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the secure upload collection.</param>
        /// <param name="code">The API key to access this endpoint. (Alternative using header x-function-keys with same value)</param>
        /// <param name="body">This endpoint allows to upload one asset which is put onto the storage (INBOX). Object has to be FormData (Add file).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Asset>> HttpSecureUploadFileByIdWithHttpInfoAsync(string id, string code, Object body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicCollectionSecureUploadApi->HttpSecureUploadFileById");
            }

            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'code' when calling PublicCollectionSecureUploadApi->HttpSecureUploadFileById");
            }

            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'body' when calling PublicCollectionSecureUploadApi->HttpSecureUploadFileById");
            }


            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Agravity.Public.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Agravity.Public.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "code", code));
            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "PublicCollectionSecureUploadApi.HttpSecureUploadFileById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Asset>("/secureupload/{id}/upload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSecureUploadFileById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
