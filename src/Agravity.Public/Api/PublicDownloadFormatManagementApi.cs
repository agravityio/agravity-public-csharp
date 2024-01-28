/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.1.5
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
    public interface IPublicDownloadFormatManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;DownloadFormat&gt;</returns>
        List<DownloadFormat> HttpDownloadFormatsGetAll(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;DownloadFormat&gt;</returns>
        ApiResponse<List<DownloadFormat>> HttpDownloadFormatsGetAllWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;DownloadFormat&gt;</returns>
        List<DownloadFormat> HttpDownloadFormatsGetAllFromShared(string shareId, string ayPassword = default(string), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;DownloadFormat&gt;</returns>
        ApiResponse<List<DownloadFormat>> HttpDownloadFormatsGetAllFromSharedWithHttpInfo(string shareId, string ayPassword = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicDownloadFormatManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;DownloadFormat&gt;</returns>
        System.Threading.Tasks.Task<List<DownloadFormat>> HttpDownloadFormatsGetAllAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;DownloadFormat&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DownloadFormat>>> HttpDownloadFormatsGetAllWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;DownloadFormat&gt;</returns>
        System.Threading.Tasks.Task<List<DownloadFormat>> HttpDownloadFormatsGetAllFromSharedAsync(string shareId, string ayPassword = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;DownloadFormat&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DownloadFormat>>> HttpDownloadFormatsGetAllFromSharedWithHttpInfoAsync(string shareId, string ayPassword = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicDownloadFormatManagementApi : IPublicDownloadFormatManagementApiSync, IPublicDownloadFormatManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicDownloadFormatManagementApi : IPublicDownloadFormatManagementApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDownloadFormatManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicDownloadFormatManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDownloadFormatManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicDownloadFormatManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicDownloadFormatManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicDownloadFormatManagementApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicDownloadFormatManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicDownloadFormatManagementApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  This endpoint lists all download formats in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;DownloadFormat&gt;</returns>
        public List<DownloadFormat> HttpDownloadFormatsGetAll(int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<List<DownloadFormat>> localVarResponse = HttpDownloadFormatsGetAllWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all download formats in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;DownloadFormat&gt;</returns>
        public Agravity.Public.Client.ApiResponse<List<DownloadFormat>> HttpDownloadFormatsGetAllWithHttpInfo(int operationIndex = 0)
        {
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


            localVarRequestOptions.Operation = "PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAll";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<DownloadFormat>>("/downloadformats", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpDownloadFormatsGetAll", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all download formats in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;DownloadFormat&gt;</returns>
        public async System.Threading.Tasks.Task<List<DownloadFormat>> HttpDownloadFormatsGetAllAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Agravity.Public.Client.ApiResponse<List<DownloadFormat>> localVarResponse = await HttpDownloadFormatsGetAllWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all download formats in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;DownloadFormat&gt;)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<List<DownloadFormat>>> HttpDownloadFormatsGetAllWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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


            localVarRequestOptions.Operation = "PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAll";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<DownloadFormat>>("/downloadformats", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpDownloadFormatsGetAll", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;DownloadFormat&gt;</returns>
        public List<DownloadFormat> HttpDownloadFormatsGetAllFromShared(string shareId, string ayPassword = default(string), int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<List<DownloadFormat>> localVarResponse = HttpDownloadFormatsGetAllFromSharedWithHttpInfo(shareId, ayPassword);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;DownloadFormat&gt;</returns>
        public Agravity.Public.Client.ApiResponse<List<DownloadFormat>> HttpDownloadFormatsGetAllFromSharedWithHttpInfo(string shareId, string ayPassword = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'shareId' when calling PublicDownloadFormatManagementApi->HttpDownloadFormatsGetAllFromShared");
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

            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "share-id", shareId));
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAllFromShared";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<DownloadFormat>>("/downloadformats-shared", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpDownloadFormatsGetAllFromShared", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;DownloadFormat&gt;</returns>
        public async System.Threading.Tasks.Task<List<DownloadFormat>> HttpDownloadFormatsGetAllFromSharedAsync(string shareId, string ayPassword = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Agravity.Public.Client.ApiResponse<List<DownloadFormat>> localVarResponse = await HttpDownloadFormatsGetAllFromSharedWithHttpInfoAsync(shareId, ayPassword, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all download formats for a specific shared collections in database.Needs a valid shared collection ID to be authenticated.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;DownloadFormat&gt;)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<List<DownloadFormat>>> HttpDownloadFormatsGetAllFromSharedWithHttpInfoAsync(string shareId, string ayPassword = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'shareId' when calling PublicDownloadFormatManagementApi->HttpDownloadFormatsGetAllFromShared");
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

            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "share-id", shareId));
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicDownloadFormatManagementApi.HttpDownloadFormatsGetAllFromShared";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<DownloadFormat>>("/downloadformats-shared", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpDownloadFormatsGetAllFromShared", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
