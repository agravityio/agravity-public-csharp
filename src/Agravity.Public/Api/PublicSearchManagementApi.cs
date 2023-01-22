/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.0.1-RC1
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
    public interface IPublicSearchManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns a configured max amount of results for search terms.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SearchResult</returns>
        SearchResult HttpGlobalSearch(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns a configured max amount of results for search terms.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SearchResult</returns>
        ApiResponse<SearchResult> HttpGlobalSearchWithHttpInfo(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicSearchManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns a configured max amount of results for search terms.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SearchResult</returns>
        System.Threading.Tasks.Task<SearchResult> HttpGlobalSearchAsync(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns a configured max amount of results for search terms.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchResult>> HttpGlobalSearchWithHttpInfoAsync(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicSearchManagementApi : IPublicSearchManagementApiSync, IPublicSearchManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicSearchManagementApi : IPublicSearchManagementApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSearchManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicSearchManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSearchManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicSearchManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicSearchManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicSearchManagementApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicSearchManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicSearchManagementApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  This endpoint returns a configured max amount of results for search terms.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SearchResult</returns>
        public SearchResult HttpGlobalSearch(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<SearchResult> localVarResponse = HttpGlobalSearchWithHttpInfo(s, limit, skip, collectiontypeid, collectionid, mode, expose, filter, orderby, ids, translations);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint returns a configured max amount of results for search terms.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SearchResult</returns>
        public Agravity.Public.Client.ApiResponse<SearchResult> HttpGlobalSearchWithHttpInfo(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0)
        {
            // verify the required parameter 's' is set
            if (s == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 's' when calling PublicSearchManagementApi->HttpGlobalSearch");
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

            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "s", s));
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "skip", skip));
            }
            if (collectiontypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectiontypeid", collectiontypeid));
            }
            if (collectionid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectionid", collectionid));
            }
            if (mode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "mode", mode));
            }
            if (expose != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "expose", expose));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }
            if (ids != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "ids", ids));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }

            localVarRequestOptions.Operation = "PublicSearchManagementApi.HttpGlobalSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SearchResult>("/search", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGlobalSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint returns a configured max amount of results for search terms.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SearchResult</returns>
        public async System.Threading.Tasks.Task<SearchResult> HttpGlobalSearchAsync(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Agravity.Public.Client.ApiResponse<SearchResult> localVarResponse = await HttpGlobalSearchWithHttpInfoAsync(s, limit, skip, collectiontypeid, collectionid, mode, expose, filter, orderby, ids, translations, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint returns a configured max amount of results for search terms.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="s">The search string which should be found.</param>
        /// <param name="limit">How many results should be returend. 0 is backend configuration limit. (optional)</param>
        /// <param name="skip">(default: 0) - Used for paging - how many items should be skipped before next limit results will be fetched. (optional)</param>
        /// <param name="collectiontypeid">Limits the result on all collections from the given collectiontypeid parameter. (optional)</param>
        /// <param name="collectionid">Limits the result on collection id (and siblings). Will be overwritten by collectiontypeid parameter. (optional)</param>
        /// <param name="mode">Two modes supported: \&quot;any\&quot; or \&quot;all\&quot; search terms should be applied. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="expose">This will expose the thumbnail asset blob incl. URL with SAS Token. (optional)</param>
        /// <param name="filter">Colon separated key value filter for filterable strings and string collections. For date or numbers \&quot;&lt;\&quot;, \&quot;&#x3D;\&quot; and \&quot;&gt;\&quot; are possible. Mode influences AND (all) and OR (any) of all filters. Multiple filters are separated by semicolons. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="orderby">Sortable fields can be used. For descendant sorting use leading \&quot;!\&quot;. (Only if Azure Search is enabled) (optional)</param>
        /// <param name="ids">Comma separated values list with all ids which should be returned. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SearchResult)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<SearchResult>> HttpGlobalSearchWithHttpInfoAsync(string s, int? limit = default(int?), int? skip = default(int?), string collectiontypeid = default(string), string collectionid = default(string), string mode = default(string), bool? expose = default(bool?), string filter = default(string), string orderby = default(string), string ids = default(string), bool? translations = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 's' is set
            if (s == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 's' when calling PublicSearchManagementApi->HttpGlobalSearch");
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

            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "s", s));
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "skip", skip));
            }
            if (collectiontypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectiontypeid", collectiontypeid));
            }
            if (collectionid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectionid", collectionid));
            }
            if (mode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "mode", mode));
            }
            if (expose != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "expose", expose));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }
            if (ids != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "ids", ids));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }

            localVarRequestOptions.Operation = "PublicSearchManagementApi.HttpGlobalSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SearchResult>("/search", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGlobalSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
