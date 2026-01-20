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
    public interface IPublicAssetRelationManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetRelation</returns>
        AssetRelation HttpAssetRelationCreate(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetRelation</returns>
        ApiResponse<AssetRelation> HttpAssetRelationCreateWithHttpInfo(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void HttpAssetRelationDeleteById(string id, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> HttpAssetRelationDeleteByIdWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all asset relations in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;AssetRelation&gt;</returns>
        List<AssetRelation> HttpAssetRelationGetAll(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all asset relations in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;AssetRelation&gt;</returns>
        ApiResponse<List<AssetRelation>> HttpAssetRelationGetAllWithHttpInfo(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetRelation</returns>
        AssetRelation HttpAssetRelationGetById(string id, bool? translations = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetRelation</returns>
        ApiResponse<AssetRelation> HttpAssetRelationGetByIdWithHttpInfo(string id, bool? translations = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates an asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetRelation</returns>
        AssetRelation HttpAssetRelationUpdateById(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates an asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetRelation</returns>
        ApiResponse<AssetRelation> HttpAssetRelationUpdateByIdWithHttpInfo(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetRelationManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetRelation</returns>
        System.Threading.Tasks.Task<AssetRelation> HttpAssetRelationCreateAsync(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetRelation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetRelation>> HttpAssetRelationCreateWithHttpInfoAsync(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task HttpAssetRelationDeleteByIdAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HttpAssetRelationDeleteByIdWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all asset relations in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AssetRelation&gt;</returns>
        System.Threading.Tasks.Task<List<AssetRelation>> HttpAssetRelationGetAllAsync(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all asset relations in database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AssetRelation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AssetRelation>>> HttpAssetRelationGetAllWithHttpInfoAsync(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetRelation</returns>
        System.Threading.Tasks.Task<AssetRelation> HttpAssetRelationGetByIdAsync(string id, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint gets a single asset relation.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetRelation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetRelation>> HttpAssetRelationGetByIdWithHttpInfoAsync(string id, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates an asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetRelation</returns>
        System.Threading.Tasks.Task<AssetRelation> HttpAssetRelationUpdateByIdAsync(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates an asset relation entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetRelation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetRelation>> HttpAssetRelationUpdateByIdWithHttpInfoAsync(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetRelationManagementApi : IPublicAssetRelationManagementApiSync, IPublicAssetRelationManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicAssetRelationManagementApi : IPublicAssetRelationManagementApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetRelationManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetRelationManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetRelationManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetRelationManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicAssetRelationManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicAssetRelationManagementApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicAssetRelationManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicAssetRelationManagementApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  This endpoint creates one asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetRelation</returns>
        public AssetRelation HttpAssetRelationCreate(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetRelation> localVarResponse = HttpAssetRelationCreateWithHttpInfo(translations, acceptLanguage, assetrelationtypeid);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint creates one asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetRelation</returns>
        public Agravity.Public.Client.ApiResponse<AssetRelation> HttpAssetRelationCreateWithHttpInfo(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0)
        {
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

            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (assetrelationtypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "assetrelationtypeid", assetrelationtypeid));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AssetRelation>("/assetrelations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint creates one asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetRelation</returns>
        public async System.Threading.Tasks.Task<AssetRelation> HttpAssetRelationCreateAsync(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetRelation> localVarResponse = await HttpAssetRelationCreateWithHttpInfoAsync(translations, acceptLanguage, assetrelationtypeid, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint creates one asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetRelation)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetRelation>> HttpAssetRelationCreateWithHttpInfoAsync(bool? translations = default, string acceptLanguage = default, string assetrelationtypeid = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (assetrelationtypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "assetrelationtypeid", assetrelationtypeid));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AssetRelation>("/assetrelations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint deletes a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void HttpAssetRelationDeleteById(string id, int operationIndex = 0)
        {
            HttpAssetRelationDeleteByIdWithHttpInfo(id);
        }

        /// <summary>
        ///  This endpoint deletes a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Agravity.Public.Client.ApiResponse<Object> HttpAssetRelationDeleteByIdWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetRelationManagementApi->HttpAssetRelationDeleteById");
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

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationDeleteById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/assetrelations/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationDeleteById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint deletes a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task HttpAssetRelationDeleteByIdAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await HttpAssetRelationDeleteByIdWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  This endpoint deletes a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Object>> HttpAssetRelationDeleteByIdWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetRelationManagementApi->HttpAssetRelationDeleteById");
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

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationDeleteById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/assetrelations/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationDeleteById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all asset relations in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;AssetRelation&gt;</returns>
        public List<AssetRelation> HttpAssetRelationGetAll(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<List<AssetRelation>> localVarResponse = HttpAssetRelationGetAllWithHttpInfo(assetrelationtypeid, acceptLanguage, translations);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all asset relations in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;AssetRelation&gt;</returns>
        public Agravity.Public.Client.ApiResponse<List<AssetRelation>> HttpAssetRelationGetAllWithHttpInfo(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0)
        {
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

            if (assetrelationtypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "assetrelationtypeid", assetrelationtypeid));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationGetAll";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<AssetRelation>>("/assetrelations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationGetAll", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all asset relations in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;AssetRelation&gt;</returns>
        public async System.Threading.Tasks.Task<List<AssetRelation>> HttpAssetRelationGetAllAsync(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<List<AssetRelation>> localVarResponse = await HttpAssetRelationGetAllWithHttpInfoAsync(assetrelationtypeid, acceptLanguage, translations, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all asset relations in database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetrelationtypeid">The ID of the asset relation type, where these asset relations should come from. (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;AssetRelation&gt;)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<List<AssetRelation>>> HttpAssetRelationGetAllWithHttpInfoAsync(string assetrelationtypeid = default, string acceptLanguage = default, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            if (assetrelationtypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "assetrelationtypeid", assetrelationtypeid));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationGetAll";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<AssetRelation>>("/assetrelations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationGetAll", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint gets a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetRelation</returns>
        public AssetRelation HttpAssetRelationGetById(string id, bool? translations = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetRelation> localVarResponse = HttpAssetRelationGetByIdWithHttpInfo(id, translations);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint gets a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetRelation</returns>
        public Agravity.Public.Client.ApiResponse<AssetRelation> HttpAssetRelationGetByIdWithHttpInfo(string id, bool? translations = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetRelationManagementApi->HttpAssetRelationGetById");
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
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationGetById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetRelation>("/assetrelations/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint gets a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetRelation</returns>
        public async System.Threading.Tasks.Task<AssetRelation> HttpAssetRelationGetByIdAsync(string id, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetRelation> localVarResponse = await HttpAssetRelationGetByIdWithHttpInfoAsync(id, translations, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint gets a single asset relation.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetRelation)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetRelation>> HttpAssetRelationGetByIdWithHttpInfoAsync(string id, bool? translations = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetRelationManagementApi->HttpAssetRelationGetById");
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
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationGetById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetRelation>("/assetrelations/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint updates an asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetRelation</returns>
        public AssetRelation HttpAssetRelationUpdateById(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetRelation> localVarResponse = HttpAssetRelationUpdateByIdWithHttpInfo(id, assetRelation, translations, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint updates an asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetRelation</returns>
        public Agravity.Public.Client.ApiResponse<AssetRelation> HttpAssetRelationUpdateByIdWithHttpInfo(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetRelationManagementApi->HttpAssetRelationUpdateById");
            }

            // verify the required parameter 'assetRelation' is set
            if (assetRelation == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'assetRelation' when calling PublicAssetRelationManagementApi->HttpAssetRelationUpdateById");
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
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }
            localVarRequestOptions.Data = assetRelation;

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationUpdateById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AssetRelation>("/assetrelations/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationUpdateById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint updates an asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetRelation</returns>
        public async System.Threading.Tasks.Task<AssetRelation> HttpAssetRelationUpdateByIdAsync(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetRelation> localVarResponse = await HttpAssetRelationUpdateByIdWithHttpInfoAsync(id, assetRelation, translations, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint updates an asset relation entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset relation.</param>
        /// <param name="assetRelation">This endpoint updates an asset relation with ID in the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetRelation)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetRelation>> HttpAssetRelationUpdateByIdWithHttpInfoAsync(string id, AssetRelation assetRelation, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetRelationManagementApi->HttpAssetRelationUpdateById");
            }

            // verify the required parameter 'assetRelation' is set
            if (assetRelation == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'assetRelation' when calling PublicAssetRelationManagementApi->HttpAssetRelationUpdateById");
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
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }
            localVarRequestOptions.Data = assetRelation;

            localVarRequestOptions.Operation = "PublicAssetRelationManagementApi.HttpAssetRelationUpdateById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AssetRelation>("/assetrelations/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetRelationUpdateById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
