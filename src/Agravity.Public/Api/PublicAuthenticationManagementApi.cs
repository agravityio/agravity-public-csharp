/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.3.3
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
    public interface IPublicAuthenticationManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SasToken</returns>
        SasToken HttpAuthGetInboxContainerWriteSasToken(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SasToken</returns>
        ApiResponse<SasToken> HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAuthenticationManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SasToken</returns>
        System.Threading.Tasks.Task<SasToken> HttpAuthGetInboxContainerWriteSasTokenAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SasToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<SasToken>> HttpAuthGetInboxContainerWriteSasTokenWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAuthenticationManagementApi : IPublicAuthenticationManagementApiSync, IPublicAuthenticationManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicAuthenticationManagementApi : IPublicAuthenticationManagementApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuthenticationManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAuthenticationManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuthenticationManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAuthenticationManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicAuthenticationManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicAuthenticationManagementApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicAuthenticationManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicAuthenticationManagementApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SasToken</returns>
        public SasToken HttpAuthGetInboxContainerWriteSasToken(int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<SasToken> localVarResponse = HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SasToken</returns>
        public Agravity.Public.Client.ApiResponse<SasToken> HttpAuthGetInboxContainerWriteSasTokenWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "PublicAuthenticationManagementApi.HttpAuthGetInboxContainerWriteSasToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SasToken>("/auth/inbox", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAuthGetInboxContainerWriteSasToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SasToken</returns>
        public async System.Threading.Tasks.Task<SasToken> HttpAuthGetInboxContainerWriteSasTokenAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Agravity.Public.Client.ApiResponse<SasToken> localVarResponse = await HttpAuthGetInboxContainerWriteSasTokenWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint creates and returns a SAS-Token with write access for the inbox container
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SasToken)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<SasToken>> HttpAuthGetInboxContainerWriteSasTokenWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "PublicAuthenticationManagementApi.HttpAuthGetInboxContainerWriteSasToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SasToken>("/auth/inbox", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAuthGetInboxContainerWriteSasToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
