/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <p>The Agravity Public API provides comprehensive access to digital asset management functionality for technical integrations, portals, and third-party applications. These endpoints are designed for programmatic access with API key authentication.</p><br/><h2>Access &amp; Security</h2><br/><b>API key is required to access these endpoints.</b><br/><ul><li>API Key Authentication - Each request requires a valid API key in headers or parameters</li><li>Portal-Aware - Many endpoints support portal context for multi-tenant scenarios</li><li>Service-to-Service Communication - Designed for backend-to-backend integrations</li><li>Stable &amp; Versioned - Public API versioning ensures backward compatibility</li></ul><h2>Core Features &amp; Operations</h2><ul><li><strong>Asset Management</strong> - Create, retrieve, update assets with full metadata support; manage versions and publish assets</li><li><strong>Collection Management</strong> - Create and organize collections hierarchically; retrieve collection type definitions and structures</li><li><strong>Asset Operations</strong> - Retrieve asset blobs (thumbnails, optimized, original); rotate and resize images; find similar assets using AI reverse search</li><li><strong>Image Editing</strong> - Apply transformations to images with advanced parameters (resize, crop, filter, color space, DPI, quality, depth)</li><li><strong>Asset Publishing</strong> - Publish assets to various targets (Vimeo, CDN); manage published asset information</li><li><strong>Asset Versioning</strong> - Create, restore, and manage asset versions; track version history with descriptions</li><li><strong>Asset Relations</strong> - Create and manage relationships between assets with hierarchical or standard relations</li><li><strong>Full-Text Search</strong> - Search assets and collections with advanced filtering, facets, and sorting capabilities</li><li><strong>Collection Sharing</strong> - Create shared collections with expiration dates, password protection, and download limits</li><li><strong>Quick Shares</strong> - Create quick share links for rapid asset sharing with expiration management</li><li><strong>Portals</strong> - Full portal management with authentication, custom theming, and asset filtering</li><li><strong>Secure Upload</strong> - Secure file upload endpoints with validation and SAS token generation</li><li><strong>Download Management</strong> - Create ZIP packages of assets with format specifications; track download progress</li><li><strong>Download Formats</strong> - Define and apply custom image transformations and optimizations for downloads</li><li><strong>Authentication</strong> - Generate SAS tokens for container write access; retrieve user information</li><li><strong>Configuration</strong> - Access frontend configuration values and system settings</li><li><strong>Helper Tools</strong> - Get searchable items, filterable items, user-defined lists, and static defined lists</li><li><strong>Translations</strong> - Retrieve translations for all entities in multiple languages</li><li><strong>Deleted Entities Tracking</strong> - Track deleted assets, collections, and other entities by date</li></ul><h2>Available Endpoints by Category</h2><ul><li><strong>Asset Management</strong> - /assets, /assets/{id}, /assetsupload, /assetrelations</li><li><strong>Asset Operations</strong> - /assets/{id}/blobs, /assets/{id}/collections, /assets/{id}/tocollection, /assets/{id}/download, /assets/{id}/resize, /assets/{id}/imageedit, /assets/{id}/availability</li><li><strong>Asset Publishing</strong> - /assets/{id}/publish, /assets/{id}/publish/{pid}</li><li><strong>Asset Versioning</strong> - /assets/{id}/versions, /assets/{id}/versionsupload, /assets/{id}/versions/{vNr}/restore</li><li><strong>AI Operations</strong> - /ai/reverseassetsearch (find similar assets using image)</li><li><strong>Collection Management</strong> - /collections, /collections/{id}, /collections/{id}/ancestors, /collections/{id}/descendants, /collections/{id}/previews, /collectionsbynames</li><li><strong>Collection Types</strong> - /collectiontypes, /collectiontypes/{id}, /collectiontypesitems</li><li><strong>Search</strong> - /search, /search/facette, /searchadmin/status</li><li><strong>Saved Searches</strong> - /savedsearches</li><li><strong>Collection Sharing</strong> - /shared/{id}, /shared/{id}/zip, /quickshares/{id}</li><li><strong>Secure Upload</strong> - /secureupload/{id}, /secureupload/{id}/upload</li><li><strong>Portal Management</strong> - /portals/{id}, /portals/{id}/config, /portals/{id}/zip, /portals/{id}/assetids, /portalsenhancetoken, /portalssaveuserattributes</li><li><strong>Authentication</strong> - /auth/containerwrite/{containerName}, /auth/inbox, /auth/users/{id}</li><li><strong>Download Formats</strong> - /downloadformats, /downloadformats-shared</li><li><strong>Configuration</strong> - /config/frontend</li><li><strong>Static Defined Lists</strong> - /staticdefinedlists, /staticdefinedlists/{id}</li><li><strong>User-Defined Lists</strong> - /helper/userdefinedlists</li><li><strong>Helper Tools</strong> - /helper/searchableitemnames, /helper/searchableitems, /helper/filterableitems</li><li><strong>Translations</strong> - /translations/{id}, /translations/{id}/{property}, /translations/{id}/custom/{customField}</li><li><strong>Web App Data</strong> - /webappdata/{id}, /data/collectiontype/{id}</li><li><strong>Workspace Management</strong> - /workspaces, /workspaces/{id}</li><li><strong>General</strong> - /version, /deleted, /durable/{instanceId}, /public/view, /signalr/negotiate</li></ul><h2>Typical Use Cases</h2><ul><li>E-commerce platforms - Product image management and dynamic optimization</li><li>Marketing automation - Asset distribution across channels with version control</li><li>Portal systems - Multi-tenant asset galleries with custom theming and permissions</li><li>Headless CMS integration - Content delivery with dynamic transformations</li><li>Mobile applications - Asset retrieval with mobile-optimized formats</li><li>AI-powered workflows - Reverse image search and automatic metadata generation</li><li>Asset sharing platforms - Secure sharing with expiration and password protection</li><li>Digital distribution - ZIP creation and bulk download management</li><li>Multi-language content - Translation management across all assets and collections</li><li>Real-time monitoring - Deletion tracking and version history auditing</li></ul><h2>Key Capabilities</h2><ul><li>Full CRUD operations on assets, collections, and related entities</li><li>Advanced image transformation with ImageMagick integration</li><li>AI-powered reverse image search for asset discovery</li><li>Multi-language support with translation dictionaries</li><li>Granular permission control and role-based access</li><li>Portal creation with custom authentication and theming</li><li>Hierarchical collection organization with dynamic filtering</li><li>Real-time search with faceted navigation and advanced filtering</li><li>Secure sharing with expiration and password protection</li><li>Blob storage integration with SAS token generation</li><li>Comprehensive asset versioning and restoration</li><li>SignalR support for real-time notifications</li></ul><h2>Authentication &amp; Authorization</h2><p>All endpoints (except public share endpoints) require API key authentication. The API key can be provided:</p><ul><li>As query parameter: ?code=YOUR_API_KEY</li><li>As header: x-functions-key: YOUR_API_KEY</li></ul><p>Portal endpoints may have additional authentication methods (OAuth, Azure AD, Auth0, password) depending on portal configuration.</p><h2>Support</h2><p>For technical support or integration questions, contact <a href=\"mailto:support@agravity.io\">support@agravity.io</a> or visit <a href=\"https://agravity.io\">https://agravity.io</a>.</p><br/><p>Copyright © Agravity GmbH 2026. All Rights Reserved</p>
 *
 * The version of the OpenAPI document: 10.2.3
 * Contact: support@agravity.io
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
    public interface IPublicSharingManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single quick share (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>QuickShareFull</returns>
        QuickShareFull HttpQuickShareGetById(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single quick share (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of QuickShareFull</returns>
        ApiResponse<QuickShareFull> HttpQuickShareGetByIdWithHttpInfo(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single shared collection (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SharedCollectionFull</returns>
        SharedCollectionFull HttpSharedCollectionsGetById(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single shared collection (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SharedCollectionFull</returns>
        ApiResponse<SharedCollectionFull> HttpSharedCollectionsGetByIdWithHttpInfo(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DownloadZipStatus</returns>
        DownloadZipStatus HttpSharedCollectionsGetStatusZipById(string id, string zipId, string ayPassword = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DownloadZipStatus</returns>
        ApiResponse<DownloadZipStatus> HttpSharedCollectionsGetStatusZipByIdWithHttpInfo(string id, string zipId, string ayPassword = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiates the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DownloadZipRequest</returns>
        DownloadZipRequest HttpSharedCollectionsRequestZipById(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiates the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DownloadZipRequest</returns>
        ApiResponse<DownloadZipRequest> HttpSharedCollectionsRequestZipByIdWithHttpInfo(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicSharingManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single quick share (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QuickShareFull</returns>
        System.Threading.Tasks.Task<QuickShareFull> HttpQuickShareGetByIdAsync(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single quick share (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QuickShareFull)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickShareFull>> HttpQuickShareGetByIdWithHttpInfoAsync(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single shared collection (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SharedCollectionFull</returns>
        System.Threading.Tasks.Task<SharedCollectionFull> HttpSharedCollectionsGetByIdAsync(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns one single shared collection (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SharedCollectionFull)</returns>
        System.Threading.Tasks.Task<ApiResponse<SharedCollectionFull>> HttpSharedCollectionsGetByIdWithHttpInfoAsync(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadZipStatus</returns>
        System.Threading.Tasks.Task<DownloadZipStatus> HttpSharedCollectionsGetStatusZipByIdAsync(string id, string zipId, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadZipStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadZipStatus>> HttpSharedCollectionsGetStatusZipByIdWithHttpInfoAsync(string id, string zipId, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiates the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadZipRequest</returns>
        System.Threading.Tasks.Task<DownloadZipRequest> HttpSharedCollectionsRequestZipByIdAsync(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiates the ZIP creation of a shared collection.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadZipRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<DownloadZipRequest>> HttpSharedCollectionsRequestZipByIdWithHttpInfoAsync(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicSharingManagementApi : IPublicSharingManagementApiSync, IPublicSharingManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicSharingManagementApi : IPublicSharingManagementApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSharingManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicSharingManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSharingManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicSharingManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicSharingManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicSharingManagementApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicSharingManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicSharingManagementApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  Returns one single quick share (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>QuickShareFull</returns>
        public QuickShareFull HttpQuickShareGetById(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<QuickShareFull> localVarResponse = HttpQuickShareGetByIdWithHttpInfo(id, continuationToken, limit, orderby);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns one single quick share (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of QuickShareFull</returns>
        public Agravity.Public.Client.ApiResponse<QuickShareFull> HttpQuickShareGetByIdWithHttpInfo(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpQuickShareGetById");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
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
            if (continuationToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "continuation_token", continuationToken));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpQuickShareGetById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<QuickShareFull>("/quickshares/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpQuickShareGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns one single quick share (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QuickShareFull</returns>
        public async System.Threading.Tasks.Task<QuickShareFull> HttpQuickShareGetByIdAsync(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<QuickShareFull> localVarResponse = await HttpQuickShareGetByIdWithHttpInfoAsync(id, continuationToken, limit, orderby, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns one single quick share (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the quick share.</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QuickShareFull)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<QuickShareFull>> HttpQuickShareGetByIdWithHttpInfoAsync(string id, string continuationToken = default, int? limit = default, string orderby = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpQuickShareGetById");
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
            if (continuationToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "continuation_token", continuationToken));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpQuickShareGetById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<QuickShareFull>("/quickshares/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpQuickShareGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns one single shared collection (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SharedCollectionFull</returns>
        public SharedCollectionFull HttpSharedCollectionsGetById(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<SharedCollectionFull> localVarResponse = HttpSharedCollectionsGetByIdWithHttpInfo(id, ayPassword, continuationToken, limit, orderby, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns one single shared collection (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SharedCollectionFull</returns>
        public Agravity.Public.Client.ApiResponse<SharedCollectionFull> HttpSharedCollectionsGetByIdWithHttpInfo(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpSharedCollectionsGetById");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
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
            if (continuationToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "continuation_token", continuationToken));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpSharedCollectionsGetById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<SharedCollectionFull>("/shared/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSharedCollectionsGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns one single shared collection (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SharedCollectionFull</returns>
        public async System.Threading.Tasks.Task<SharedCollectionFull> HttpSharedCollectionsGetByIdAsync(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<SharedCollectionFull> localVarResponse = await HttpSharedCollectionsGetByIdWithHttpInfoAsync(id, ayPassword, continuationToken, limit, orderby, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns one single shared collection (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: created_date (newest first). (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SharedCollectionFull)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<SharedCollectionFull>> HttpSharedCollectionsGetByIdWithHttpInfoAsync(string id, string ayPassword = default, string continuationToken = default, int? limit = default, string orderby = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpSharedCollectionsGetById");
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
            if (continuationToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "continuation_token", continuationToken));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (orderby != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "orderby", orderby));
            }
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpSharedCollectionsGetById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SharedCollectionFull>("/shared/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSharedCollectionsGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DownloadZipStatus</returns>
        public DownloadZipStatus HttpSharedCollectionsGetStatusZipById(string id, string zipId, string ayPassword = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<DownloadZipStatus> localVarResponse = HttpSharedCollectionsGetStatusZipByIdWithHttpInfo(id, zipId, ayPassword);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DownloadZipStatus</returns>
        public Agravity.Public.Client.ApiResponse<DownloadZipStatus> HttpSharedCollectionsGetStatusZipByIdWithHttpInfo(string id, string zipId, string ayPassword = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpSharedCollectionsGetStatusZipById");
            }

            // verify the required parameter 'zipId' is set
            if (zipId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'zipId' when calling PublicSharingManagementApi->HttpSharedCollectionsGetStatusZipById");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Agravity.Public.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
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
            localVarRequestOptions.PathParameters.Add("zipId", Agravity.Public.Client.ClientUtils.ParameterToString(zipId)); // path parameter
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpSharedCollectionsGetStatusZipById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<DownloadZipStatus>("/shared/{id}/zip/{zipId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSharedCollectionsGetStatusZipById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadZipStatus</returns>
        public async System.Threading.Tasks.Task<DownloadZipStatus> HttpSharedCollectionsGetStatusZipByIdAsync(string id, string zipId, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<DownloadZipStatus> localVarResponse = await HttpSharedCollectionsGetStatusZipByIdWithHttpInfoAsync(id, zipId, ayPassword, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint gets the progress/status of the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the zip request.</param>
        /// <param name="zipId">The ID of the requested zip.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 401 (Unauthorized) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadZipStatus)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<DownloadZipStatus>> HttpSharedCollectionsGetStatusZipByIdWithHttpInfoAsync(string id, string zipId, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpSharedCollectionsGetStatusZipById");
            }

            // verify the required parameter 'zipId' is set
            if (zipId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'zipId' when calling PublicSharingManagementApi->HttpSharedCollectionsGetStatusZipById");
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
            localVarRequestOptions.PathParameters.Add("zipId", Agravity.Public.Client.ClientUtils.ParameterToString(zipId)); // path parameter
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpSharedCollectionsGetStatusZipById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DownloadZipStatus>("/shared/{id}/zip/{zipId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSharedCollectionsGetStatusZipById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Initiates the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DownloadZipRequest</returns>
        public DownloadZipRequest HttpSharedCollectionsRequestZipById(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<DownloadZipRequest> localVarResponse = HttpSharedCollectionsRequestZipByIdWithHttpInfo(id, ayPassword, downloadZipRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Initiates the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DownloadZipRequest</returns>
        public Agravity.Public.Client.ApiResponse<DownloadZipRequest> HttpSharedCollectionsRequestZipByIdWithHttpInfo(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpSharedCollectionsRequestZipById");
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
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
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
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }
            localVarRequestOptions.Data = downloadZipRequest;

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpSharedCollectionsRequestZipById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<DownloadZipRequest>("/shared/{id}/zip", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSharedCollectionsRequestZipById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Initiates the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DownloadZipRequest</returns>
        public async System.Threading.Tasks.Task<DownloadZipRequest> HttpSharedCollectionsRequestZipByIdAsync(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<DownloadZipRequest> localVarResponse = await HttpSharedCollectionsRequestZipByIdWithHttpInfoAsync(id, ayPassword, downloadZipRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Initiates the ZIP creation of a shared collection.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the shared collection.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="downloadZipRequest">The request of which assets or download formats should be used.. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DownloadZipRequest)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<DownloadZipRequest>> HttpSharedCollectionsRequestZipByIdWithHttpInfoAsync(string id, string ayPassword = default, DownloadZipRequest downloadZipRequest = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicSharingManagementApi->HttpSharedCollectionsRequestZipById");
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
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }
            localVarRequestOptions.Data = downloadZipRequest;

            localVarRequestOptions.Operation = "PublicSharingManagementApi.HttpSharedCollectionsRequestZipById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DownloadZipRequest>("/shared/{id}/zip", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpSharedCollectionsRequestZipById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
