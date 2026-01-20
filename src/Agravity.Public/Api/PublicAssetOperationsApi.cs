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
    public interface IPublicAssetOperationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream HttpAssetImageEdit(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> HttpAssetImageEditWithHttpInfo(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream HttpAssetResize(string id, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> HttpAssetResizeWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void HttpAssetToCollection(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> HttpAssetToCollectionWithHttpInfo(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        AssetBlob HttpGetAssetBlob(string id, string c, string portalId = default, string key = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        ApiResponse<AssetBlob> HttpGetAssetBlobWithHttpInfo(string id, string c, string portalId = default, string key = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all collections of a specific asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Collection&gt;</returns>
        List<Collection> HttpGetAssetCollectionsById(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all collections of a specific asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
        ApiResponse<List<Collection>> HttpGetAssetCollectionsByIdWithHttpInfo(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        AssetBlob HttpGetAssetDownload(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        ApiResponse<AssetBlob> HttpGetAssetDownloadWithHttpInfo(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        AssetBlob HttpGetSharedAssetBlob(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        ApiResponse<AssetBlob> HttpGetSharedAssetBlobWithHttpInfo(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream HttpImageDynamicEdit(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> HttpImageDynamicEditWithHttpInfo(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns an image with the requested download format applied.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream HttpImageDynamicGetFromDownloadId(string id, string downloadFormatId, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns an image with the requested download format applied.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> HttpImageDynamicGetFromDownloadIdWithHttpInfo(string id, string downloadFormatId, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetAvailability</returns>
        AssetAvailability HttpPutAssetAvailability(string id, AssetAvailability assetAvailability, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetAvailability</returns>
        ApiResponse<AssetAvailability> HttpPutAssetAvailabilityWithHttpInfo(string id, AssetAvailability assetAvailability, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetOperationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> HttpAssetImageEditAsync(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> HttpAssetImageEditWithHttpInfoAsync(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> HttpAssetResizeAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> HttpAssetResizeWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task HttpAssetToCollectionAsync(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HttpAssetToCollectionWithHttpInfoAsync(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        System.Threading.Tasks.Task<AssetBlob> HttpGetAssetBlobAsync(string id, string c, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetBlob>> HttpGetAssetBlobWithHttpInfoAsync(string id, string c, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all collections of a specific asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Collection&gt;</returns>
        System.Threading.Tasks.Task<List<Collection>> HttpGetAssetCollectionsByIdAsync(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all collections of a specific asset.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Collection>>> HttpGetAssetCollectionsByIdWithHttpInfoAsync(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        System.Threading.Tasks.Task<AssetBlob> HttpGetAssetDownloadAsync(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetBlob>> HttpGetAssetDownloadWithHttpInfoAsync(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        System.Threading.Tasks.Task<AssetBlob> HttpGetSharedAssetBlobAsync(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetBlob>> HttpGetSharedAssetBlobWithHttpInfoAsync(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> HttpImageDynamicEditAsync(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> HttpImageDynamicEditWithHttpInfoAsync(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns an image with the requested download format applied.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> HttpImageDynamicGetFromDownloadIdAsync(string id, string downloadFormatId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint returns an image with the requested download format applied.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> HttpImageDynamicGetFromDownloadIdWithHttpInfoAsync(string id, string downloadFormatId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetAvailability</returns>
        System.Threading.Tasks.Task<AssetAvailability> HttpPutAssetAvailabilityAsync(string id, AssetAvailability assetAvailability, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </remarks>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetAvailability)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetAvailability>> HttpPutAssetAvailabilityWithHttpInfoAsync(string id, AssetAvailability assetAvailability, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicAssetOperationsApi : IPublicAssetOperationsApiSync, IPublicAssetOperationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicAssetOperationsApi : IPublicAssetOperationsApi
    {
        private Agravity.Public.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetOperationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetOperationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssetOperationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicAssetOperationsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PublicAssetOperationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicAssetOperationsApi(Agravity.Public.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PublicAssetOperationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicAssetOperationsApi(Agravity.Public.Client.ISynchronousClient client, Agravity.Public.Client.IAsynchronousClient asyncClient, Agravity.Public.Client.IReadableConfiguration configuration)
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
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream HttpAssetImageEdit(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = HttpAssetImageEditWithHttpInfo(id, width, height, mode, target, bgcolor, dpi, depth, quality, colorspace, cropX, cropY, cropWidth, cropHeight, filter, original);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Agravity.Public.Client.ApiResponse<System.IO.Stream> HttpAssetImageEditWithHttpInfo(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpAssetImageEdit");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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
            if (width != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "width", width));
            }
            if (height != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "height", height));
            }
            if (mode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "mode", mode));
            }
            if (target != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "target", target));
            }
            if (bgcolor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "bgcolor", bgcolor));
            }
            if (dpi != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "dpi", dpi));
            }
            if (depth != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "depth", depth));
            }
            if (quality != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "quality", quality));
            }
            if (colorspace != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "colorspace", colorspace));
            }
            if (cropX != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_x", cropX));
            }
            if (cropY != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_y", cropY));
            }
            if (cropWidth != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_width", cropWidth));
            }
            if (cropHeight != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_height", cropHeight));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (original != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "original", original));
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpAssetImageEdit";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<System.IO.Stream>("/assets/{id}/imageedit", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetImageEdit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> HttpAssetImageEditAsync(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = await HttpAssetImageEditWithHttpInfoAsync(id, width, height, mode, target, bgcolor, dpi, depth, quality, colorspace, cropX, cropY, cropWidth, cropHeight, filter, original, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="width">The width of the final image. (optional)</param>
        /// <param name="height">The height of the final image. (optional)</param>
        /// <param name="mode">The supported modes: contain (default), cover, fill, crop, none (optional)</param>
        /// <param name="target">The file type which the image should be (i.e. webp, png, jpg, gif) (optional)</param>
        /// <param name="bgcolor">The color of the background color if background is visible (crop outside, png). RGB(A) in hex code (i.e. 00FFAA or with alpha channel: 44AABB77) and color names (i.e. lightgray) supported - default: transparent (optional)</param>
        /// <param name="dpi">The density (counts for X and Y) of the target image. (optional)</param>
        /// <param name="depth">The bit depth of the target image. (optional)</param>
        /// <param name="quality">The quality of the target image (1-100). (optional)</param>
        /// <param name="colorspace">The color space of the image (Default: sRGB). (optional)</param>
        /// <param name="cropX">If mode is crop: The x coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropY">If mode is crop: The y coordinate of the point (if image is extended (outside) it is negative) (optional)</param>
        /// <param name="cropWidth">If mode&#x3D;crop: The width of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="cropHeight">If mode&#x3D;crop: The height of the cropping rectangle (from original pixel) (optional)</param>
        /// <param name="filter">Which filter should be applied. To get all filters available use: /api/helper/imageeditfilters (optional)</param>
        /// <param name="original">If set to true the internal image is used instead of the default original (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<System.IO.Stream>> HttpAssetImageEditWithHttpInfoAsync(string id, int? width = default, int? height = default, string mode = default, string target = default, string bgcolor = default, int? dpi = default, int? depth = default, int? quality = default, string colorspace = default, int? cropX = default, int? cropY = default, int? cropWidth = default, int? cropHeight = default, string filter = default, bool? original = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpAssetImageEdit");
            }


            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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
            if (width != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "width", width));
            }
            if (height != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "height", height));
            }
            if (mode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "mode", mode));
            }
            if (target != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "target", target));
            }
            if (bgcolor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "bgcolor", bgcolor));
            }
            if (dpi != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "dpi", dpi));
            }
            if (depth != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "depth", depth));
            }
            if (quality != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "quality", quality));
            }
            if (colorspace != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "colorspace", colorspace));
            }
            if (cropX != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_x", cropX));
            }
            if (cropY != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_y", cropY));
            }
            if (cropWidth != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_width", cropWidth));
            }
            if (cropHeight != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "crop_height", cropHeight));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (original != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "original", original));
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpAssetImageEdit";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<System.IO.Stream>("/assets/{id}/imageedit", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetImageEdit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream HttpAssetResize(string id, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = HttpAssetResizeWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Agravity.Public.Client.ApiResponse<System.IO.Stream> HttpAssetResizeWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpAssetResize");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpAssetResize";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<System.IO.Stream>("/assets/{id}/resize", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetResize", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> HttpAssetResizeAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = await HttpAssetResizeWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lets you resize/modify the image asset according to the given parameter(s).
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<System.IO.Stream>> HttpAssetResizeWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpAssetResize");
            }


            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpAssetResize";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<System.IO.Stream>("/assets/{id}/resize", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetResize", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void HttpAssetToCollection(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0)
        {
            HttpAssetToCollectionWithHttpInfo(id, moveCollectionBody);
        }

        /// <summary>
        ///  This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Agravity.Public.Client.ApiResponse<Object> HttpAssetToCollectionWithHttpInfo(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpAssetToCollection");
            }

            // verify the required parameter 'moveCollectionBody' is set
            if (moveCollectionBody == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'moveCollectionBody' when calling PublicAssetOperationsApi->HttpAssetToCollection");
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
            localVarRequestOptions.Data = moveCollectionBody;

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpAssetToCollection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/assets/{id}/tocollection", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetToCollection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task HttpAssetToCollectionAsync(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            await HttpAssetToCollectionWithHttpInfoAsync(id, moveCollectionBody, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  This endpoint allows to move/assign from/to another collection with the given operation parameter.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="moveCollectionBody">Contains information about this operation.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<Object>> HttpAssetToCollectionWithHttpInfoAsync(string id, MoveCollectionBody moveCollectionBody, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpAssetToCollection");
            }

            // verify the required parameter 'moveCollectionBody' is set
            if (moveCollectionBody == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'moveCollectionBody' when calling PublicAssetOperationsApi->HttpAssetToCollection");
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
            localVarRequestOptions.Data = moveCollectionBody;

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpAssetToCollection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/assets/{id}/tocollection", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpAssetToCollection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        public AssetBlob HttpGetAssetBlob(string id, string c, string portalId = default, string key = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = HttpGetAssetBlobWithHttpInfo(id, c, portalId, key);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        public Agravity.Public.Client.ApiResponse<AssetBlob> HttpGetAssetBlobWithHttpInfo(string id, string c, string portalId = default, string key = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetAssetBlob");
            }

            // verify the required parameter 'c' is set
            if (c == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'c' when calling PublicAssetOperationsApi->HttpGetAssetBlob");
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
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "c", c));
            if (portalId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "portal_id", portalId));
            }
            if (key != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "key", key));
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetAssetBlob";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetBlob>("/assets/{id}/blobs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetAssetBlob", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        public async System.Threading.Tasks.Task<AssetBlob> HttpGetAssetBlobAsync(string id, string c, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = await HttpGetAssetBlobWithHttpInfoAsync(id, c, portalId, key, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists and returns the url for the requested blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original.</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. If used the \&quot;key\&quot; param becomes mandatory. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetBlob>> HttpGetAssetBlobWithHttpInfoAsync(string id, string c, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetAssetBlob");
            }

            // verify the required parameter 'c' is set
            if (c == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'c' when calling PublicAssetOperationsApi->HttpGetAssetBlob");
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
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "c", c));
            if (portalId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "portal_id", portalId));
            }
            if (key != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "key", key));
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetAssetBlob";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetBlob>("/assets/{id}/blobs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetAssetBlob", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns all collections of a specific asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Collection&gt;</returns>
        public List<Collection> HttpGetAssetCollectionsById(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<List<Collection>> localVarResponse = HttpGetAssetCollectionsByIdWithHttpInfo(id, fields, translations, acceptLanguage);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns all collections of a specific asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
        public Agravity.Public.Client.ApiResponse<List<Collection>> HttpGetAssetCollectionsByIdWithHttpInfo(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetAssetCollectionsById");
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
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetAssetCollectionsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Collection>>("/assets/{id}/collections", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetAssetCollectionsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Returns all collections of a specific asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Collection&gt;</returns>
        public async System.Threading.Tasks.Task<List<Collection>> HttpGetAssetCollectionsByIdAsync(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<List<Collection>> localVarResponse = await HttpGetAssetCollectionsByIdWithHttpInfoAsync(id, fields, translations, acceptLanguage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns all collections of a specific asset.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="fields">This limits the fields which are returned, separated by comma (&#39;,&#39;). (optional)</param>
        /// <param name="translations">When default language should be returned and the translation dictionary is delivered. (Ignores the \&quot;Accept-Language\&quot; header) (optional)</param>
        /// <param name="acceptLanguage">The requested language of the response. If not matching it falls back to default language. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<List<Collection>>> HttpGetAssetCollectionsByIdWithHttpInfoAsync(string id, string fields = default, bool? translations = default, string acceptLanguage = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetAssetCollectionsById");
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
            if (translations != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "translations", translations));
            }
            if (acceptLanguage != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept-Language", Agravity.Public.Client.ClientUtils.ParameterToString(acceptLanguage)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetAssetCollectionsById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Collection>>("/assets/{id}/collections", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetAssetCollectionsById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        public AssetBlob HttpGetAssetDownload(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = HttpGetAssetDownloadWithHttpInfo(id, c, f, portalId, key);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        public Agravity.Public.Client.ApiResponse<AssetBlob> HttpGetAssetDownloadWithHttpInfo(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetAssetDownload");
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
            if (c != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "c", c));
            }
            if (f != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "f", f));
            }
            if (portalId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "portal_id", portalId));
            }
            if (key != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "key", key));
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetAssetDownload";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetBlob>("/assets/{id}/download", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetAssetDownload", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        public async System.Threading.Tasks.Task<AssetBlob> HttpGetAssetDownloadAsync(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = await HttpGetAssetDownloadWithHttpInfoAsync(id, c, f, portalId, key, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint is similar to GetAssetBlob but with ContentDistribution and filename to let browser download the content.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="c">\&quot;t\&quot; for thumbnail (default); \&quot;op\&quot; for optimized; \&quot;os\&quot; for original size; \&quot;o\&quot; for original. (optional)</param>
        /// <param name="f">(optional) provide the id of any valid download format. (optional)</param>
        /// <param name="portalId">If the request comes from portal this is the indicator. It will be checked if the requested blob is valid for the portal. (optional)</param>
        /// <param name="key">The key is the MD5 hash of the original blob of the asset. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetBlob>> HttpGetAssetDownloadWithHttpInfoAsync(string id, string c = default, string f = default, string portalId = default, string key = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetAssetDownload");
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
            if (c != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "c", c));
            }
            if (f != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "f", f));
            }
            if (portalId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "portal_id", portalId));
            }
            if (key != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "key", key));
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetAssetDownload";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetBlob>("/assets/{id}/download", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetAssetDownload", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetBlob</returns>
        public AssetBlob HttpGetSharedAssetBlob(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = HttpGetSharedAssetBlobWithHttpInfo(shareId, id, format, ayPassword);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetBlob</returns>
        public Agravity.Public.Client.ApiResponse<AssetBlob> HttpGetSharedAssetBlobWithHttpInfo(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'shareId' when calling PublicAssetOperationsApi->HttpGetSharedAssetBlob");
            }

            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetSharedAssetBlob");
            }

            // verify the required parameter 'format' is set
            if (format == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'format' when calling PublicAssetOperationsApi->HttpGetSharedAssetBlob");
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
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "share_id", shareId));
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetSharedAssetBlob";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetBlob>("/assets/{id}/blob", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetSharedAssetBlob", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetBlob</returns>
        public async System.Threading.Tasks.Task<AssetBlob> HttpGetSharedAssetBlobAsync(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetBlob> localVarResponse = await HttpGetSharedAssetBlobWithHttpInfoAsync(shareId, id, format, ayPassword, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint checks, if an asset exists, is an image, has original blob, is status active, is part of the shared collection and returns the requested asset blob.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shareId">This share ID is like an API key. Check on validy (format, expire, collection still availabe). Otherwise StatusCode 403 (Forbidden) is returned.</param>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="format">Which download format the blob is requested.</param>
        /// <param name="ayPassword">If shared collection has a password, this header is mandatory. Otherwise StatusCode 403 (Forbidden) is returned. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetBlob)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetBlob>> HttpGetSharedAssetBlobWithHttpInfoAsync(string shareId, string id, string format, string ayPassword = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'shareId' is set
            if (shareId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'shareId' when calling PublicAssetOperationsApi->HttpGetSharedAssetBlob");
            }

            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpGetSharedAssetBlob");
            }

            // verify the required parameter 'format' is set
            if (format == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'format' when calling PublicAssetOperationsApi->HttpGetSharedAssetBlob");
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
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "share_id", shareId));
            localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            if (ayPassword != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ay-password", Agravity.Public.Client.ClientUtils.ParameterToString(ayPassword)); // header parameter
            }

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpGetSharedAssetBlob";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetBlob>("/assets/{id}/blob", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpGetSharedAssetBlob", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream HttpImageDynamicEdit(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = HttpImageDynamicEditWithHttpInfo(id, dynamicImageOperation, targetFilename);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Agravity.Public.Client.ApiResponse<System.IO.Stream> HttpImageDynamicEditWithHttpInfo(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpImageDynamicEdit");
            }

            // verify the required parameter 'dynamicImageOperation' is set
            if (dynamicImageOperation == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'dynamicImageOperation' when calling PublicAssetOperationsApi->HttpImageDynamicEdit");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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
            if (targetFilename != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "target_filename", targetFilename));
            }
            localVarRequestOptions.Data = dynamicImageOperation;

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpImageDynamicEdit";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<System.IO.Stream>("/assets/{id}/imageedit", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpImageDynamicEdit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> HttpImageDynamicEditAsync(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = await HttpImageDynamicEditWithHttpInfoAsync(id, dynamicImageOperation, targetFilename, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint lets you use the entire api of Imagemagick to edit the image.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="dynamicImageOperation">Operations to be performed on the image directly mapped to c# imagemagick sdk</param>
        /// <param name="targetFilename">If the file should have a specific naming. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<System.IO.Stream>> HttpImageDynamicEditWithHttpInfoAsync(string id, List<DynamicImageOperation> dynamicImageOperation, string targetFilename = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpImageDynamicEdit");
            }

            // verify the required parameter 'dynamicImageOperation' is set
            if (dynamicImageOperation == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'dynamicImageOperation' when calling PublicAssetOperationsApi->HttpImageDynamicEdit");
            }


            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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
            if (targetFilename != null)
            {
                localVarRequestOptions.QueryParameters.Add(Agravity.Public.Client.ClientUtils.ParameterToMultiMap("", "target_filename", targetFilename));
            }
            localVarRequestOptions.Data = dynamicImageOperation;

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpImageDynamicEdit";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<System.IO.Stream>("/assets/{id}/imageedit", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpImageDynamicEdit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint returns an image with the requested download format applied.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream HttpImageDynamicGetFromDownloadId(string id, string downloadFormatId, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = HttpImageDynamicGetFromDownloadIdWithHttpInfo(id, downloadFormatId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint returns an image with the requested download format applied.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Agravity.Public.Client.ApiResponse<System.IO.Stream> HttpImageDynamicGetFromDownloadIdWithHttpInfo(string id, string downloadFormatId, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpImageDynamicGetFromDownloadId");
            }

            // verify the required parameter 'downloadFormatId' is set
            if (downloadFormatId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'downloadFormatId' when calling PublicAssetOperationsApi->HttpImageDynamicGetFromDownloadId");
            }

            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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
            localVarRequestOptions.PathParameters.Add("download_format_id", Agravity.Public.Client.ClientUtils.ParameterToString(downloadFormatId)); // path parameter

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpImageDynamicGetFromDownloadId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<System.IO.Stream>("/assets/{id}/imageedit/{download_format_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpImageDynamicGetFromDownloadId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint returns an image with the requested download format applied.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> HttpImageDynamicGetFromDownloadIdAsync(string id, string downloadFormatId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<System.IO.Stream> localVarResponse = await HttpImageDynamicGetFromDownloadIdWithHttpInfoAsync(id, downloadFormatId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint returns an image with the requested download format applied.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="downloadFormatId">The ID of the download format.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<System.IO.Stream>> HttpImageDynamicGetFromDownloadIdWithHttpInfoAsync(string id, string downloadFormatId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpImageDynamicGetFromDownloadId");
            }

            // verify the required parameter 'downloadFormatId' is set
            if (downloadFormatId == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'downloadFormatId' when calling PublicAssetOperationsApi->HttpImageDynamicGetFromDownloadId");
            }


            Agravity.Public.Client.RequestOptions localVarRequestOptions = new Agravity.Public.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/xyz",
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
            localVarRequestOptions.PathParameters.Add("download_format_id", Agravity.Public.Client.ClientUtils.ParameterToString(downloadFormatId)); // path parameter

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpImageDynamicGetFromDownloadId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<System.IO.Stream>("/assets/{id}/imageedit/{download_format_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpImageDynamicGetFromDownloadId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AssetAvailability</returns>
        public AssetAvailability HttpPutAssetAvailability(string id, AssetAvailability assetAvailability, int operationIndex = 0)
        {
            Agravity.Public.Client.ApiResponse<AssetAvailability> localVarResponse = HttpPutAssetAvailabilityWithHttpInfo(id, assetAvailability);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AssetAvailability</returns>
        public Agravity.Public.Client.ApiResponse<AssetAvailability> HttpPutAssetAvailabilityWithHttpInfo(string id, AssetAvailability assetAvailability, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpPutAssetAvailability");
            }

            // verify the required parameter 'assetAvailability' is set
            if (assetAvailability == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'assetAvailability' when calling PublicAssetOperationsApi->HttpPutAssetAvailability");
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
            localVarRequestOptions.Data = assetAvailability;

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpPutAssetAvailability";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<AssetAvailability>("/assets/{id}/availability", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpPutAssetAvailability", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetAvailability</returns>
        public async System.Threading.Tasks.Task<AssetAvailability> HttpPutAssetAvailabilityAsync(string id, AssetAvailability assetAvailability, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            Agravity.Public.Client.ApiResponse<AssetAvailability> localVarResponse = await HttpPutAssetAvailabilityWithHttpInfoAsync(id, assetAvailability, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This endpoint sets the availability of the asset. All properties are put on the asset and replace previous values.To make an asset unavailable set the &#x60;availability&#x60; property to &#39;locked&#39; or set the &#x60;available_from&#x60; property below the current date. To make it available set empty string to &#x60;availability&#x60; property or &#x60;available_to&#x60; property into past.
        /// </summary>
        /// <exception cref="Agravity.Public.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset.</param>
        /// <param name="assetAvailability">The values are validated and put directly on the asset.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetAvailability)</returns>
        public async System.Threading.Tasks.Task<Agravity.Public.Client.ApiResponse<AssetAvailability>> HttpPutAssetAvailabilityWithHttpInfoAsync(string id, AssetAvailability assetAvailability, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'id' when calling PublicAssetOperationsApi->HttpPutAssetAvailability");
            }

            // verify the required parameter 'assetAvailability' is set
            if (assetAvailability == null)
            {
                throw new Agravity.Public.Client.ApiException(400, "Missing required parameter 'assetAvailability' when calling PublicAssetOperationsApi->HttpPutAssetAvailability");
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
            localVarRequestOptions.Data = assetAvailability;

            localVarRequestOptions.Operation = "PublicAssetOperationsApi.HttpPutAssetAvailability";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (function_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-functions-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-functions-key", this.Configuration.GetApiKeyWithPrefix("x-functions-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<AssetAvailability>("/assets/{id}/availability", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HttpPutAssetAvailability", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
