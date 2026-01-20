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
    public interface IPublicAssetVersioningApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        VersionedAsset HttpAssetCreateUploadVersion(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        ApiResponse<VersionedAsset> HttpAssetCreateUploadVersionWithHttpInfo(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        VersionedAsset HttpAssetCreateVersion(string id, VersionedAsset versionedAsset, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        ApiResponse<VersionedAsset> HttpAssetCreateVersionWithHttpInfo(string id, VersionedAsset versionedAsset, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void HttpDeleteVersionedAssetsById(string id, string vNr, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> HttpDeleteVersionedAssetsByIdWithHttpInfo(string id, string vNr, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        AssetBlob HttpGetVersionedAssetBlobById(string id, int vNr, string c = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        ApiResponse<AssetBlob> HttpGetVersionedAssetBlobByIdWithHttpInfo(string id, int vNr, string c = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        VersionedAsset HttpRestoreVersionedAssetsById(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        ApiResponse<VersionedAsset> HttpRestoreVersionedAssetsByIdWithHttpInfo(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        VersionedAsset HttpUpdateVersionedAssetsById(string id, string vNr, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        ApiResponse<VersionedAsset> HttpUpdateVersionedAssetsByIdWithHttpInfo(string id, string vNr, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionEntity</returns>
        VersionEntity HttpVersionedAssetsGet(string id, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionEntity</returns>
        ApiResponse<VersionEntity> HttpVersionedAssetsGetWithHttpInfo(string id, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetVersioningApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        System.Threading.Tasks.Task<VersionedAsset> HttpAssetCreateUploadVersionAsync(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedAsset>> HttpAssetCreateUploadVersionWithHttpInfoAsync(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        System.Threading.Tasks.Task<VersionedAsset> HttpAssetCreateVersionAsync(string id, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedAsset>> HttpAssetCreateVersionWithHttpInfoAsync(string id, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task HttpDeleteVersionedAssetsByIdAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint deletes a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HttpDeleteVersionedAssetsByIdWithHttpInfoAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        System.Threading.Tasks.Task<AssetBlob> HttpGetVersionedAssetBlobByIdAsync(string id, int vNr, string c = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetBlob>> HttpGetVersionedAssetBlobByIdWithHttpInfoAsync(string id, int vNr, string c = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        System.Threading.Tasks.Task<VersionedAsset> HttpRestoreVersionedAssetsByIdAsync(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedAsset>> HttpRestoreVersionedAssetsByIdWithHttpInfoAsync(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        System.Threading.Tasks.Task<VersionedAsset> HttpUpdateVersionedAssetsByIdAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint updates a version of an asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionedAsset>> HttpUpdateVersionedAssetsByIdWithHttpInfoAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionEntity</returns>
        System.Threading.Tasks.Task<VersionEntity> HttpVersionedAssetsGetAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionEntity>> HttpVersionedAssetsGetWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetVersioningApi : IPublicAssetVersioningApiSync, IPublicAssetVersioningApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicAssetVersioningApi : IPublicAssetVersioningApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetVersioningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetVersioningApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetVersioningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetVersioningApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicAssetVersioningApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicAssetVersioningApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicAssetVersioningApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicAssetVersioningApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        public VersionedAsset HttpAssetCreateUploadVersion(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = HttpAssetCreateUploadVersionWithHttpInfo(id, name, collectionid, file, filename, previewof);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        public Agravity.Public.Client.ApiResponse<VersionedAsset> HttpAssetCreateUploadVersionWithHttpInfo(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpAssetCreateUploadVersion");
            }

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

            localVarRequestOptions.PathParameters.Add("id", Agravity.Public.Client.ClientUtils.ParameterToString(id)); // path parameter
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

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpAssetCreateUploadVersion";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<VersionedAsset>("/assets/{id}/versionsupload", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetCreateUploadVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        public async System.Threading.Tasks.Task<VersionedAsset> HttpAssetCreateUploadVersionAsync(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = await HttpAssetCreateUploadVersionWithHttpInfoAsync(id, name, collectionid, file, filename, previewof, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint allows to upload one asset which replaces the asset with given id and creates a version which is returned.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="name"> (optional)</param>
        /// <param name="collectionid"> (optional)</param>
        /// <param name="file"> (optional)</param>
        /// <param name="filename"> (optional)</param>
        /// <param name="previewof"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<VersionedAsset>> HttpAssetCreateUploadVersionWithHttpInfoAsync(string id, string name = default, string collectionid = default, System.IO.Stream file = default, string filename = default, string previewof = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpAssetCreateUploadVersion");
            }


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

            localVarRequestOptions.PathParameters.Add("id", Agravity.Public.Client.ClientUtils.ParameterToString(id)); // path parameter
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

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpAssetCreateUploadVersion";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<VersionedAsset>("/assets/{id}/versionsupload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetCreateUploadVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        public VersionedAsset HttpAssetCreateVersion(string id, VersionedAsset versionedAsset, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = HttpAssetCreateVersionWithHttpInfo(id, versionedAsset);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        public Agravity.Public.Client.ApiResponse<VersionedAsset> HttpAssetCreateVersionWithHttpInfo(string id, VersionedAsset versionedAsset, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpAssetCreateVersion");
            }

            // verify the required parameter 'versionedAsset' is set
            if (versionedAsset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'versionedAsset' when calling PublicAssetVersioningApi->HttpAssetCreateVersion");
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
            localVarRequestOptions.Data = versionedAsset;

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpAssetCreateVersion";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<VersionedAsset>("/assets/{id}/versions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetCreateVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        public async System.Threading.Tasks.Task<VersionedAsset> HttpAssetCreateVersionAsync(string id, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = await HttpAssetCreateVersionWithHttpInfoAsync(id, versionedAsset, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint allows to create empty version or upload one asset which replaces the asset with given id and creates version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="versionedAsset">This VersionedAsset to create empty version (need to upload file with metadata to blob storage)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<VersionedAsset>> HttpAssetCreateVersionWithHttpInfoAsync(string id, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpAssetCreateVersion");
            }

            // verify the required parameter 'versionedAsset' is set
            if (versionedAsset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'versionedAsset' when calling PublicAssetVersioningApi->HttpAssetCreateVersion");
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
            localVarRequestOptions.Data = versionedAsset;

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpAssetCreateVersion";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<VersionedAsset>("/assets/{id}/versions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetCreateVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint deletes a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void HttpDeleteVersionedAssetsById(string id, string vNr, int operationIndex = 0)
        {
            HttpDeleteVersionedAssetsByIdWithHttpInfo(id, vNr);
        }

        /// <summary>
        ///  This endpoint deletes a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Agravity.Public.Client.ApiResponse<Object> HttpDeleteVersionedAssetsByIdWithHttpInfo(string id, string vNr, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpDeleteVersionedAssetsById");
            }

            // verify the required parameter 'vNr' is set
            if (vNr == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'vNr' when calling PublicAssetVersioningApi->HttpDeleteVersionedAssetsById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpDeleteVersionedAssetsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/assets/{id}/versions/{vNr}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpDeleteVersionedAssetsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint deletes a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task HttpDeleteVersionedAssetsByIdAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await HttpDeleteVersionedAssetsByIdWithHttpInfoAsync(id, vNr, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  This endpoint deletes a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Object>> HttpDeleteVersionedAssetsByIdWithHttpInfoAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpDeleteVersionedAssetsById");
            }

            // verify the required parameter 'vNr' is set
            if (vNr == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'vNr' when calling PublicAssetVersioningApi->HttpDeleteVersionedAssetsById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpDeleteVersionedAssetsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/assets/{id}/versions/{vNr}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpDeleteVersionedAssetsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        public AssetBlob HttpGetVersionedAssetBlobById(string id, int vNr, string c = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = HttpGetVersionedAssetBlobByIdWithHttpInfo(id, vNr, c);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        public Agravity.Public.Client.ApiResponse<AssetBlob> HttpGetVersionedAssetBlobByIdWithHttpInfo(string id, int vNr, string c = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpGetVersionedAssetBlobById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter
            if (c != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "c", c));
            }

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpGetVersionedAssetBlobById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetBlob>("/assets/{id}/versions/{vNr}/blobs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetVersionedAssetBlobById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        public async System.Threading.Tasks.Task<AssetBlob> HttpGetVersionedAssetBlobByIdAsync(string id, int vNr, string c = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = await HttpGetVersionedAssetBlobByIdWithHttpInfoAsync(id, vNr, c, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint checks if assets and version exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;o\&quot; for optimized (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetBlob>> HttpGetVersionedAssetBlobByIdWithHttpInfoAsync(string id, int vNr, string c = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpGetVersionedAssetBlobById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter
            if (c != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "c", c));
            }

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpGetVersionedAssetBlobById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetBlob>("/assets/{id}/versions/{vNr}/blobs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetVersionedAssetBlobById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        public VersionedAsset HttpRestoreVersionedAssetsById(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = HttpRestoreVersionedAssetsByIdWithHttpInfo(id, vNr, versionedAsset);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        public Agravity.Public.Client.ApiResponse<VersionedAsset> HttpRestoreVersionedAssetsByIdWithHttpInfo(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpRestoreVersionedAssetsById");
            }

            // verify the required parameter 'vNr' is set
            if (vNr == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'vNr' when calling PublicAssetVersioningApi->HttpRestoreVersionedAssetsById");
            }

            // verify the required parameter 'versionedAsset' is set
            if (versionedAsset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'versionedAsset' when calling PublicAssetVersioningApi->HttpRestoreVersionedAssetsById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter
            localVarRequestOptions.Data = versionedAsset;

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpRestoreVersionedAssetsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<VersionedAsset>("/assets/{id}/versions/{vNr}/restore", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpRestoreVersionedAssetsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        public async System.Threading.Tasks.Task<VersionedAsset> HttpRestoreVersionedAssetsByIdAsync(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = await HttpRestoreVersionedAssetsByIdWithHttpInfoAsync(id, vNr, versionedAsset, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint restores a version nr to be the current version and saves the current asset as version.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="versionedAsset">Only the version_info is used and will be added to the current version which is archived (before the old version is restored).</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<VersionedAsset>> HttpRestoreVersionedAssetsByIdWithHttpInfoAsync(string id, string vNr, VersionedAsset versionedAsset, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpRestoreVersionedAssetsById");
            }

            // verify the required parameter 'vNr' is set
            if (vNr == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'vNr' when calling PublicAssetVersioningApi->HttpRestoreVersionedAssetsById");
            }

            // verify the required parameter 'versionedAsset' is set
            if (versionedAsset == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'versionedAsset' when calling PublicAssetVersioningApi->HttpRestoreVersionedAssetsById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter
            localVarRequestOptions.Data = versionedAsset;

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpRestoreVersionedAssetsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<VersionedAsset>("/assets/{id}/versions/{vNr}/restore", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpRestoreVersionedAssetsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint updates a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionedAsset</returns>
        public VersionedAsset HttpUpdateVersionedAssetsById(string id, string vNr, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = HttpUpdateVersionedAssetsByIdWithHttpInfo(id, vNr);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint updates a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionedAsset</returns>
        public Agravity.Public.Client.ApiResponse<VersionedAsset> HttpUpdateVersionedAssetsByIdWithHttpInfo(string id, string vNr, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpUpdateVersionedAssetsById");
            }

            // verify the required parameter 'vNr' is set
            if (vNr == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'vNr' when calling PublicAssetVersioningApi->HttpUpdateVersionedAssetsById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpUpdateVersionedAssetsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<VersionedAsset>("/assets/{id}/versions/{vNr}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpUpdateVersionedAssetsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint updates a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionedAsset</returns>
        public async System.Threading.Tasks.Task<VersionedAsset> HttpUpdateVersionedAssetsByIdAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<VersionedAsset> localVarResponse = await HttpUpdateVersionedAssetsByIdWithHttpInfoAsync(id, vNr, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint updates a version of an asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="vNr">The version number of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionedAsset)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<VersionedAsset>> HttpUpdateVersionedAssetsByIdWithHttpInfoAsync(string id, string vNr, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpUpdateVersionedAssetsById");
            }

            // verify the required parameter 'vNr' is set
            if (vNr == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'vNr' when calling PublicAssetVersioningApi->HttpUpdateVersionedAssetsById");
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
            localVarRequestOptions.PathParameters.Add("vNr", Agravity.Public.Client.ClientUtils.ParameterToString(vNr)); // path parameter

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpUpdateVersionedAssetsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<VersionedAsset>("/assets/{id}/versions/{vNr}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpUpdateVersionedAssetsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VersionEntity</returns>
        public VersionEntity HttpVersionedAssetsGet(string id, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<VersionEntity> localVarResponse = HttpVersionedAssetsGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VersionEntity</returns>
        public Agravity.Public.Client.ApiResponse<VersionEntity> HttpVersionedAssetsGetWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpVersionedAssetsGet");
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

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpVersionedAssetsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<VersionEntity>("/assets/{id}/versions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpVersionedAssetsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VersionEntity</returns>
        public async System.Threading.Tasks.Task<VersionEntity> HttpVersionedAssetsGetAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<VersionEntity> localVarResponse = await HttpVersionedAssetsGetWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lists all the versioned assets which are stored in the database if asset is still valid.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VersionEntity)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<VersionEntity>> HttpVersionedAssetsGetWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetVersioningApi->HttpVersionedAssetsGet");
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

            localVarRequestOptions.Operation = "PublicAssetVersioningApi.HttpVersionedAssetsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<VersionEntity>("/assets/{id}/versions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpVersionedAssetsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
