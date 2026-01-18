/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <p>The Agravity Public API provides comprehensive access to digital asset management functionality for technical integrations, portals, and third-party applications. These endpoints are designed for programmatic access with API key authentication.</p><br/><h2>Access &amp; Security</h2><br/><b>API key is required to access these endpoints.</b><br/><ul><li>API Key Authentication - Each request requires a valid API key in headers or parameters</li><li>Portal-Aware - Many endpoints support portal context for multi-tenant scenarios</li><li>Service-to-Service Communication - Designed for backend-to-backend integrations</li><li>Stable &amp; Versioned - Public API versioning ensures backward compatibility</li></ul><h2>Core Features &amp; Operations</h2><ul><li><strong>Asset Management</strong> - Create, retrieve, update assets with full metadata support; manage versions and publish assets</li><li><strong>Collection Management</strong> - Create and organize collections hierarchically; retrieve collection type definitions and structures</li><li><strong>Asset Operations</strong> - Retrieve asset blobs (thumbnails, optimized, original); rotate and resize images; find similar assets using AI reverse search</li><li><strong>Image Editing</strong> - Apply transformations to images with advanced parameters (resize, crop, filter, color space, DPI, quality, depth)</li><li><strong>Asset Publishing</strong> - Publish assets to various targets (Vimeo, CDN); manage published asset information</li><li><strong>Asset Versioning</strong> - Create, restore, and manage asset versions; track version history with descriptions</li><li><strong>Asset Relations</strong> - Create and manage relationships between assets with hierarchical or standard relations</li><li><strong>Full-Text Search</strong> - Search assets and collections with advanced filtering, facets, and sorting capabilities</li><li><strong>Collection Sharing</strong> - Create shared collections with expiration dates, password protection, and download limits</li><li><strong>Quick Shares</strong> - Create quick share links for rapid asset sharing with expiration management</li><li><strong>Portals</strong> - Full portal management with authentication, custom theming, and asset filtering</li><li><strong>Secure Upload</strong> - Secure file upload endpoints with validation and SAS token generation</li><li><strong>Download Management</strong> - Create ZIP packages of assets with format specifications; track download progress</li><li><strong>Download Formats</strong> - Define and apply custom image transformations and optimizations for downloads</li><li><strong>Authentication</strong> - Generate SAS tokens for container write access; retrieve user information</li><li><strong>Configuration</strong> - Access frontend configuration values and system settings</li><li><strong>Helper Tools</strong> - Get searchable items, filterable items, user-defined lists, and static defined lists</li><li><strong>Translations</strong> - Retrieve translations for all entities in multiple languages</li><li><strong>Deleted Entities Tracking</strong> - Track deleted assets, collections, and other entities by date</li></ul><h2>Available Endpoints by Category</h2><ul><li><strong>Asset Management</strong> - /assets, /assets/{id}, /assetsupload, /assetrelations</li><li><strong>Asset Operations</strong> - /assets/{id}/blobs, /assets/{id}/collections, /assets/{id}/tocollection, /assets/{id}/download, /assets/{id}/resize, /assets/{id}/imageedit, /assets/{id}/availability</li><li><strong>Asset Publishing</strong> - /assets/{id}/publish, /assets/{id}/publish/{pid}</li><li><strong>Asset Versioning</strong> - /assets/{id}/versions, /assets/{id}/versionsupload, /assets/{id}/versions/{vNr}/restore</li><li><strong>AI Operations</strong> - /ai/reverseassetsearch (find similar assets using image)</li><li><strong>Collection Management</strong> - /collections, /collections/{id}, /collections/{id}/ancestors, /collections/{id}/descendants, /collections/{id}/previews, /collectionsbynames</li><li><strong>Collection Types</strong> - /collectiontypes, /collectiontypes/{id}, /collectiontypesitems</li><li><strong>Search</strong> - /search, /search/facette, /searchadmin/status</li><li><strong>Saved Searches</strong> - /savedsearches</li><li><strong>Collection Sharing</strong> - /shared/{id}, /shared/{id}/zip, /quickshares/{id}</li><li><strong>Secure Upload</strong> - /secureupload/{id}, /secureupload/{id}/upload</li><li><strong>Portal Management</strong> - /portals/{id}, /portals/{id}/config, /portals/{id}/zip, /portals/{id}/assetids, /portalsenhancetoken, /portalssaveuserattributes</li><li><strong>Authentication</strong> - /auth/containerwrite/{containerName}, /auth/inbox, /auth/users/{id}</li><li><strong>Download Formats</strong> - /downloadformats, /downloadformats-shared</li><li><strong>Configuration</strong> - /config/frontend</li><li><strong>Static Defined Lists</strong> - /staticdefinedlists, /staticdefinedlists/{id}</li><li><strong>User-Defined Lists</strong> - /helper/userdefinedlists</li><li><strong>Helper Tools</strong> - /helper/searchableitemnames, /helper/searchableitems, /helper/filterableitems</li><li><strong>Translations</strong> - /translations/{id}, /translations/{id}/{property}, /translations/{id}/custom/{customField}</li><li><strong>Web App Data</strong> - /webappdata/{id}, /data/collectiontype/{id}</li><li><strong>Workspace Management</strong> - /workspaces, /workspaces/{id}</li><li><strong>General</strong> - /version, /deleted, /durable/{instanceId}, /public/view, /signalr/negotiate</li></ul><h2>Typical Use Cases</h2><ul><li>E-commerce platforms - Product image management and dynamic optimization</li><li>Marketing automation - Asset distribution across channels with version control</li><li>Portal systems - Multi-tenant asset galleries with custom theming and permissions</li><li>Headless CMS integration - Content delivery with dynamic transformations</li><li>Mobile applications - Asset retrieval with mobile-optimized formats</li><li>AI-powered workflows - Reverse image search and automatic metadata generation</li><li>Asset sharing platforms - Secure sharing with expiration and password protection</li><li>Digital distribution - ZIP creation and bulk download management</li><li>Multi-language content - Translation management across all assets and collections</li><li>Real-time monitoring - Deletion tracking and version history auditing</li></ul><h2>Key Capabilities</h2><ul><li>Full CRUD operations on assets, collections, and related entities</li><li>Advanced image transformation with ImageMagick integration</li><li>AI-powered reverse image search for asset discovery</li><li>Multi-language support with translation dictionaries</li><li>Granular permission control and role-based access</li><li>Portal creation with custom authentication and theming</li><li>Hierarchical collection organization with dynamic filtering</li><li>Real-time search with faceted navigation and advanced filtering</li><li>Secure sharing with expiration and password protection</li><li>Blob storage integration with SAS token generation</li><li>Comprehensive asset versioning and restoration</li><li>SignalR support for real-time notifications</li></ul><h2>Authentication &amp; Authorization</h2><p>All endpoints (except public share endpoints) require API key authentication. The API key can be provided:</p><ul><li>As query parameter: ?code=YOUR_API_KEY</li><li>As header: x-functions-key: YOUR_API_KEY</li></ul><p>Portal endpoints may have additional authentication methods (OAuth, Azure AD, Auth0, password) depending on portal configuration.</p><h2>Support</h2><p>For technical support or integration questions, contact <a href=\"mailto:support@agravity.io\">support@agravity.io</a> or visit <a href=\"https://agravity.io\">https://agravity.io</a>.</p><br/><p>Copyright © Agravity GmbH 2026. All Rights Reserved</p>
 *
 * The version of the OpenAPI document: 10.2.1
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
    public interface IPublicAssetManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        Asset HttpAssetUploadFile(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> HttpAssetUploadFileWithHttpInfo(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        Asset HttpAssetsCreate(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> HttpAssetsCreateWithHttpInfo(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetPageResult</returns>
        AssetPageResult HttpAssetsGet(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetPageResult</returns>
        ApiResponse<AssetPageResult> HttpAssetsGetWithHttpInfo(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        Asset HttpAssetsGetById(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> HttpAssetsGetByIdWithHttpInfo(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates one single asset (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        Asset HttpPublicAssetsUpdateById(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates one single asset (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> HttpPublicAssetsUpdateByIdWithHttpInfo(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> HttpAssetUploadFileAsync(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> HttpAssetUploadFileWithHttpInfoAsync(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> HttpAssetsCreateAsync(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint creates one asset entry in the database.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> HttpAssetsCreateWithHttpInfoAsync(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetPageResult</returns>
        System.Threading.Tasks.Task<AssetPageResult> HttpAssetsGetAsync(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetPageResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetPageResult>> HttpAssetsGetWithHttpInfoAsync(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> HttpAssetsGetByIdAsync(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> HttpAssetsGetByIdWithHttpInfoAsync(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates one single asset (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> HttpPublicAssetsUpdateByIdAsync(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates one single asset (from ID)
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> HttpPublicAssetsUpdateByIdWithHttpInfoAsync(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetManagementApi : IPublicAssetManagementApiSync, IPublicAssetManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicAssetManagementApi : IPublicAssetManagementApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicAssetManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicAssetManagementApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicAssetManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicAssetManagementApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        public Asset HttpAssetUploadFile(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = HttpAssetUploadFileWithHttpInfo(acceptLanguage, name, collectionid, file, filename, previewof);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        public Agravity.Public.Client.ApiResponse<Asset> HttpAssetUploadFileWithHttpInfo(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0)
        {
            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
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

            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }
            if (name != null)
            {
                localVarRequestOptions.FormParameters.Add("name", Agravity.Public.Client.ClientUtils.ParameterToString(name)); // form parameter
            }
            if (collectionid != null)
            {
                localVarRequestOptions.FormParameters.Add("collectionid", Agravity.Public.Client.ClientUtils.ParameterToString(collectionid)); // form parameter
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("file", file);
            }
            if (filename != null)
            {
                localVarRequestOptions.FormParameters.Add("filename", Agravity.Public.Client.ClientUtils.ParameterToString(filename)); // form parameter
            }
            if (previewof != null)
            {
                localVarRequestOptions.FormParameters.Add("previewof", Agravity.Public.Client.ClientUtils.ParameterToString(previewof)); // form parameter
            }

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetUploadFile";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Asset>("/assetsupload", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetUploadFile", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> HttpAssetUploadFileAsync(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = await HttpAssetUploadFileWithHttpInfoAsync(acceptLanguage, name, collectionid, file, filename, previewof, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Asset>> HttpAssetUploadFileWithHttpInfoAsync(string acceptLanguage = default, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
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

            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }
            if (name != null)
            {
                localVarRequestOptions.FormParameters.Add("name", Agravity.Public.Client.ClientUtils.ParameterToString(name)); // form parameter
            }
            if (collectionid != null)
            {
                localVarRequestOptions.FormParameters.Add("collectionid", Agravity.Public.Client.ClientUtils.ParameterToString(collectionid)); // form parameter
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("file", file);
            }
            if (filename != null)
            {
                localVarRequestOptions.FormParameters.Add("filename", Agravity.Public.Client.ClientUtils.ParameterToString(filename)); // form parameter
            }
            if (previewof != null)
            {
                localVarRequestOptions.FormParameters.Add("previewof", Agravity.Public.Client.ClientUtils.ParameterToString(previewof)); // form parameter
            }

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetUploadFile";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Asset>("/assetsupload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetUploadFile", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint creates one asset entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        public Asset HttpAssetsCreate(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = HttpAssetsCreateWithHttpInfo(collectionid, asset, translations, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint creates one asset entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        public Agravity.Public.Client.ApiResponse<Asset> HttpAssetsCreateWithHttpInfo(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            // verify the required parameter 'collectionid' is set
            if (collectionid == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'collectionid' when calling PublicAssetManagementApi->HttpAssetsCreate");
            }

            // verify the required parameter 'asset' is set
            if (asset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'asset' when calling PublicAssetManagementApi->HttpAssetsCreate");
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

            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectionid", collectionid));
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }
            localVarRequestOptions.Data = asset;

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Asset>("/assets", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint creates one asset entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> HttpAssetsCreateAsync(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = await HttpAssetsCreateWithHttpInfoAsync(collectionid, asset, translations, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint creates one asset entry in the database.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where this assets should be assigned.</param>
        /// <param name="asset">This endpoint creates an unique asset ID and adds the information to the database.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Asset>> HttpAssetsCreateWithHttpInfoAsync(string collectionid, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'collectionid' is set
            if (collectionid == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'collectionid' when calling PublicAssetManagementApi->HttpAssetsCreate");
            }

            // verify the required parameter 'asset' is set
            if (asset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'asset' when calling PublicAssetManagementApi->HttpAssetsCreate");
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

            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectionid", collectionid));
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }
            localVarRequestOptions.Data = asset;

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetsCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Asset>("/assets", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetsCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetPageResult</returns>
        public AssetPageResult HttpAssetsGet(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetPageResult> localVarResponse = HttpAssetsGetWithHttpInfo(collectionid, collectiontypeid, fields, expose, continuationToken, limit, orderby, filter, items, translations, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetPageResult</returns>
        public Agravity.Public.Client.ApiResponse<AssetPageResult> HttpAssetsGetWithHttpInfo(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
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

            if (collectionid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectionid", collectionid));
            }
            if (collectiontypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectiontypeid", collectiontypeid));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "fields", fields));
            }
            if (expose != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "expose", expose));
            }
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
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (items != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "items", items));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetPageResult>("/assets", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetPageResult</returns>
        public async System.Threading.Tasks.Task<AssetPageResult> HttpAssetsGetAsync(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetPageResult> localVarResponse = await HttpAssetsGetWithHttpInfoAsync(collectionid, collectiontypeid, fields, expose, continuationToken, limit, orderby, filter, items, translations, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all the assets, which are stored in the database and not deleted (status \&quot;A\&quot;)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionid">The ID of the collection where these assets should come from. (Is not required when &#39;collectiontypeid&#39; is set.) (optional)</param>
        /// <param name="collectiontypeid">The ID of the collection type where these assets should come from. (Is not required when &#39;collectionid&#39; is set.) CAUTION: The assets returned are not distinct &#x3D;&gt; Duplicates are possible if assets are in multiple collections in this collection type! (optional)</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). Blobs can be limited with &#39;.&#39; on their container. (i.e. fields&#x3D;blobs.thumbnails). Only if &#39;thumbnails&#39; is set, the placeholder of this asset type are returned if no thumbnail blob is found. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. (If not limited through &#39;fields&#39; parameter it will expose all URLs of all blobs.) (optional)</param>
        /// <param name="continuationToken">Each result returns the continous token if more results are available than requested. With this token, the next page could be fetched. (URL encoded!) (optional)</param>
        /// <param name="limit">This number limits the page result of assets. (optional)</param>
        /// <param name="orderby">How the return assets are sorted. Default is property: modified_date (newest first). (optional)</param>
        /// <param name="filter">This will limit the output on specific parameters which are separated by &#39;:&#39;, &#39;!:&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39; (optional)</param>
        /// <param name="items">The items can be extended to fully filled items. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetPageResult)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetPageResult>> HttpAssetsGetWithHttpInfoAsync(string collectionid = default, string collectiontypeid = default, string fields = default, bool? expose = default, string continuationToken = default, int? limit = default, string orderby = default, string filter = default, bool? items = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            if (collectionid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectionid", collectionid));
            }
            if (collectiontypeid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "collectiontypeid", collectiontypeid));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "fields", fields));
            }
            if (expose != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "expose", expose));
            }
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
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (items != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "items", items));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetPageResult>("/assets", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        public Asset HttpAssetsGetById(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = HttpAssetsGetByIdWithHttpInfo(id, fields, expose, translations, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        public Agravity.Public.Client.ApiResponse<Asset> HttpAssetsGetByIdWithHttpInfo(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetManagementApi->HttpAssetsGetById");
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
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "fields", fields));
            }
            if (expose != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "expose", expose));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetsGetById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Asset>("/assets/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetsGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> HttpAssetsGetByIdAsync(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = await HttpAssetsGetByIdWithHttpInfoAsync(id, fields, expose, translations, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint returns one single asset (from ID). If the returned asset is from a special asset type (e.g. \&quot;AssetImage\&quot;) it returns the full entity.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">Which fields are need to be filled out with comma separated. If one is set all non mandatory fields are left out. No validation if field exist. (optional)</param>
        /// <param name="expose">This indicates if the given blobs should have URLs where these can be requested. It will expose placeholder blobs if no &#39;thumbnail&#39; is found. (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Asset>> HttpAssetsGetByIdWithHttpInfoAsync(string id, string fields = default, bool? expose = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetManagementApi->HttpAssetsGetById");
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
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "fields", fields));
            }
            if (expose != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "expose", expose));
            }
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpAssetsGetById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Asset>("/assets/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetsGetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint updates one single asset (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Asset</returns>
        public Asset HttpPublicAssetsUpdateById(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = HttpPublicAssetsUpdateByIdWithHttpInfo(id, asset, translations, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint updates one single asset (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Asset</returns>
        public Agravity.Public.Client.ApiResponse<Asset> HttpPublicAssetsUpdateByIdWithHttpInfo(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetManagementApi->HttpPublicAssetsUpdateById");
            }

            // verify the required parameter 'asset' is set
            if (asset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'asset' when calling PublicAssetManagementApi->HttpPublicAssetsUpdateById");
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
            localVarRequestOptions.Data = asset;

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpPublicAssetsUpdateById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Asset>("/assets/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpPublicAssetsUpdateById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint updates one single asset (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> HttpPublicAssetsUpdateByIdAsync(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<Asset> localVarResponse = await HttpPublicAssetsUpdateByIdWithHttpInfoAsync(id, asset, translations, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint updates one single asset (from ID)
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="asset">The body has to contain one of the mentioned elements and a valid json. Not fitting properties are ignored.</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Asset>> HttpPublicAssetsUpdateByIdWithHttpInfoAsync(string id, Asset asset, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetManagementApi->HttpPublicAssetsUpdateById");
            }

            // verify the required parameter 'asset' is set
            if (asset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'asset' when calling PublicAssetManagementApi->HttpPublicAssetsUpdateById");
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
            localVarRequestOptions.Data = asset;

            localVarRequestOptions.Operation = "PublicAssetManagementApi.HttpPublicAssetsUpdateById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Asset>("/assets/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpPublicAssetsUpdateById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
