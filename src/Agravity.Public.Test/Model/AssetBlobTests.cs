/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <p>The Agravity Public API provides comprehensive access to digital asset management functionality for technical integrations, portals, and third-party applications. These endpoints are designed for programmatic access with API key authentication.</p><br/><h2>Access &amp; Security</h2><br/><b>API key is required to access these endpoints.</b><br/><ul><li>API Key Authentication - Each request requires a valid API key in headers or parameters</li><li>Portal-Aware - Many endpoints support portal context for multi-tenant scenarios</li><li>Service-to-Service Communication - Designed for backend-to-backend integrations</li><li>Stable &amp; Versioned - Public API versioning ensures backward compatibility</li></ul><h2>Core Features &amp; Operations</h2><ul><li><strong>Asset Management</strong> - Create, retrieve, update assets with full metadata support; manage versions and publish assets</li><li><strong>Collection Management</strong> - Create and organize collections hierarchically; retrieve collection type definitions and structures</li><li><strong>Asset Operations</strong> - Retrieve asset blobs (thumbnails, optimized, original); rotate and resize images; find similar assets using AI reverse search</li><li><strong>Image Editing</strong> - Apply transformations to images with advanced parameters (resize, crop, filter, color space, DPI, quality, depth)</li><li><strong>Asset Publishing</strong> - Publish assets to various targets (Vimeo, CDN); manage published asset information</li><li><strong>Asset Versioning</strong> - Create, restore, and manage asset versions; track version history with descriptions</li><li><strong>Asset Relations</strong> - Create and manage relationships between assets with hierarchical or standard relations</li><li><strong>Full-Text Search</strong> - Search assets and collections with advanced filtering, facets, and sorting capabilities</li><li><strong>Collection Sharing</strong> - Create shared collections with expiration dates, password protection, and download limits</li><li><strong>Quick Shares</strong> - Create quick share links for rapid asset sharing with expiration management</li><li><strong>Portals</strong> - Full portal management with authentication, custom theming, and asset filtering</li><li><strong>Secure Upload</strong> - Secure file upload endpoints with validation and SAS token generation</li><li><strong>Download Management</strong> - Create ZIP packages of assets with format specifications; track download progress</li><li><strong>Download Formats</strong> - Define and apply custom image transformations and optimizations for downloads</li><li><strong>Authentication</strong> - Generate SAS tokens for container write access; retrieve user information</li><li><strong>Configuration</strong> - Access frontend configuration values and system settings</li><li><strong>Helper Tools</strong> - Get searchable items, filterable items, user-defined lists, and static defined lists</li><li><strong>Translations</strong> - Retrieve translations for all entities in multiple languages</li><li><strong>Deleted Entities Tracking</strong> - Track deleted assets, collections, and other entities by date</li></ul><h2>Available Endpoints by Category</h2><ul><li><strong>Asset Management</strong> - /assets, /assets/{id}, /assetsupload, /assetrelations</li><li><strong>Asset Operations</strong> - /assets/{id}/blobs, /assets/{id}/collections, /assets/{id}/tocollection, /assets/{id}/download, /assets/{id}/resize, /assets/{id}/imageedit, /assets/{id}/availability</li><li><strong>Asset Publishing</strong> - /assets/{id}/publish, /assets/{id}/publish/{pid}</li><li><strong>Asset Versioning</strong> - /assets/{id}/versions, /assets/{id}/versionsupload, /assets/{id}/versions/{vNr}/restore</li><li><strong>AI Operations</strong> - /ai/reverseassetsearch (find similar assets using image)</li><li><strong>Collection Management</strong> - /collections, /collections/{id}, /collections/{id}/ancestors, /collections/{id}/descendants, /collections/{id}/previews, /collectionsbynames</li><li><strong>Collection Types</strong> - /collectiontypes, /collectiontypes/{id}, /collectiontypesitems</li><li><strong>Search</strong> - /search, /search/facette, /searchadmin/status</li><li><strong>Saved Searches</strong> - /savedsearches</li><li><strong>Collection Sharing</strong> - /shared/{id}, /shared/{id}/zip, /quickshares/{id}</li><li><strong>Secure Upload</strong> - /secureupload/{id}, /secureupload/{id}/upload</li><li><strong>Portal Management</strong> - /portals/{id}, /portals/{id}/config, /portals/{id}/zip, /portals/{id}/assetids, /portalsenhancetoken, /portalssaveuserattributes</li><li><strong>Authentication</strong> - /auth/containerwrite/{containerName}, /auth/inbox, /auth/users/{id}</li><li><strong>Download Formats</strong> - /downloadformats, /downloadformats-shared</li><li><strong>Configuration</strong> - /config/frontend</li><li><strong>Static Defined Lists</strong> - /staticdefinedlists, /staticdefinedlists/{id}</li><li><strong>User-Defined Lists</strong> - /helper/userdefinedlists</li><li><strong>Helper Tools</strong> - /helper/searchableitemnames, /helper/searchableitems, /helper/filterableitems</li><li><strong>Translations</strong> - /translations/{id}, /translations/{id}/{property}, /translations/{id}/custom/{customField}</li><li><strong>Web App Data</strong> - /webappdata/{id}, /data/collectiontype/{id}</li><li><strong>Workspace Management</strong> - /workspaces, /workspaces/{id}</li><li><strong>General</strong> - /version, /deleted, /durable/{instanceId}, /public/view, /signalr/negotiate</li></ul><h2>Typical Use Cases</h2><ul><li>E-commerce platforms - Product image management and dynamic optimization</li><li>Marketing automation - Asset distribution across channels with version control</li><li>Portal systems - Multi-tenant asset galleries with custom theming and permissions</li><li>Headless CMS integration - Content delivery with dynamic transformations</li><li>Mobile applications - Asset retrieval with mobile-optimized formats</li><li>AI-powered workflows - Reverse image search and automatic metadata generation</li><li>Asset sharing platforms - Secure sharing with expiration and password protection</li><li>Digital distribution - ZIP creation and bulk download management</li><li>Multi-language content - Translation management across all assets and collections</li><li>Real-time monitoring - Deletion tracking and version history auditing</li></ul><h2>Key Capabilities</h2><ul><li>Full CRUD operations on assets, collections, and related entities</li><li>Advanced image transformation with ImageMagick integration</li><li>AI-powered reverse image search for asset discovery</li><li>Multi-language support with translation dictionaries</li><li>Granular permission control and role-based access</li><li>Portal creation with custom authentication and theming</li><li>Hierarchical collection organization with dynamic filtering</li><li>Real-time search with faceted navigation and advanced filtering</li><li>Secure sharing with expiration and password protection</li><li>Blob storage integration with SAS token generation</li><li>Comprehensive asset versioning and restoration</li><li>SignalR support for real-time notifications</li></ul><h2>Authentication &amp; Authorization</h2><p>All endpoints (except public share endpoints) require API key authentication. The API key can be provided:</p><ul><li>As query parameter: ?code=YOUR_API_KEY</li><li>As header: x-functions-key: YOUR_API_KEY</li></ul><p>Portal endpoints may have additional authentication methods (OAuth, Azure AD, Auth0, password) depending on portal configuration.</p><h2>Support</h2><p>For technical support or integration questions, contact <a href=\"mailto:support@agravity.io\">support@agravity.io</a> or visit <a href=\"https://agravity.io\">https://agravity.io</a>.</p><br/><p>Copyright © Agravity GmbH 2026. All Rights Reserved</p>
 *
 * The version of the OpenAPI document: 10.2.5
 * Contact: support@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agravity.Public.Model;
using Agravity.Public.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agravity.Public.Test.Model
{
    /// <summary>
    ///  Class for testing AssetBlob
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AssetBlobTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AssetBlob
        //private AssetBlob instance;

        public AssetBlobTests()
        {
            // TODO uncomment below to create an instance of AssetBlob
            //instance = new AssetBlob();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssetBlob
        /// </summary>
        [Fact]
        public void AssetBlobInstanceTest()
        {
            // TODO uncomment below to test "IsType" AssetBlob
            //Assert.IsType<AssetBlob>(instance);
        }

        /// <summary>
        /// Test the property 'BlobType'
        /// </summary>
        [Fact]
        public void BlobTypeTest()
        {
            // TODO unit test for the property 'BlobType'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Container'
        /// </summary>
        [Fact]
        public void ContainerTest()
        {
            // TODO unit test for the property 'Container'
        }

        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }

        /// <summary>
        /// Test the property 'Extension'
        /// </summary>
        [Fact]
        public void ExtensionTest()
        {
            // TODO unit test for the property 'Extension'
        }

        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }

        /// <summary>
        /// Test the property 'Md5'
        /// </summary>
        [Fact]
        public void Md5Test()
        {
            // TODO unit test for the property 'Md5'
        }

        /// <summary>
        /// Test the property 'AddData'
        /// </summary>
        [Fact]
        public void AddDataTest()
        {
            // TODO unit test for the property 'AddData'
        }

        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Fact]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }

        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Fact]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }

        /// <summary>
        /// Test the property 'Maxwidthheight'
        /// </summary>
        [Fact]
        public void MaxwidthheightTest()
        {
            // TODO unit test for the property 'Maxwidthheight'
        }

        /// <summary>
        /// Test the property 'Quality'
        /// </summary>
        [Fact]
        public void QualityTest()
        {
            // TODO unit test for the property 'Quality'
        }

        /// <summary>
        /// Test the property 'Orientation'
        /// </summary>
        [Fact]
        public void OrientationTest()
        {
            // TODO unit test for the property 'Orientation'
        }

        /// <summary>
        /// Test the property 'Colorspace'
        /// </summary>
        [Fact]
        public void ColorspaceTest()
        {
            // TODO unit test for the property 'Colorspace'
        }

        /// <summary>
        /// Test the property 'Profile'
        /// </summary>
        [Fact]
        public void ProfileTest()
        {
            // TODO unit test for the property 'Profile'
        }

        /// <summary>
        /// Test the property 'Transparency'
        /// </summary>
        [Fact]
        public void TransparencyTest()
        {
            // TODO unit test for the property 'Transparency'
        }

        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }

        /// <summary>
        /// Test the property 'Target'
        /// </summary>
        [Fact]
        public void TargetTest()
        {
            // TODO unit test for the property 'Target'
        }

        /// <summary>
        /// Test the property 'Filter'
        /// </summary>
        [Fact]
        public void FilterTest()
        {
            // TODO unit test for the property 'Filter'
        }

        /// <summary>
        /// Test the property 'DpiX'
        /// </summary>
        [Fact]
        public void DpiXTest()
        {
            // TODO unit test for the property 'DpiX'
        }

        /// <summary>
        /// Test the property 'DpiY'
        /// </summary>
        [Fact]
        public void DpiYTest()
        {
            // TODO unit test for the property 'DpiY'
        }

        /// <summary>
        /// Test the property 'Perhash'
        /// </summary>
        [Fact]
        public void PerhashTest()
        {
            // TODO unit test for the property 'Perhash'
        }

        /// <summary>
        /// Test the property 'Dominantcolor'
        /// </summary>
        [Fact]
        public void DominantcolorTest()
        {
            // TODO unit test for the property 'Dominantcolor'
        }

        /// <summary>
        /// Test the property 'Depth'
        /// </summary>
        [Fact]
        public void DepthTest()
        {
            // TODO unit test for the property 'Depth'
        }

        /// <summary>
        /// Test the property 'Animated'
        /// </summary>
        [Fact]
        public void AnimatedTest()
        {
            // TODO unit test for the property 'Animated'
        }

        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Fact]
        public void DurationTest()
        {
            // TODO unit test for the property 'Duration'
        }

        /// <summary>
        /// Test the property 'Videocodec'
        /// </summary>
        [Fact]
        public void VideocodecTest()
        {
            // TODO unit test for the property 'Videocodec'
        }

        /// <summary>
        /// Test the property 'Videobitrate'
        /// </summary>
        [Fact]
        public void VideobitrateTest()
        {
            // TODO unit test for the property 'Videobitrate'
        }

        /// <summary>
        /// Test the property 'Fps'
        /// </summary>
        [Fact]
        public void FpsTest()
        {
            // TODO unit test for the property 'Fps'
        }

        /// <summary>
        /// Test the property 'Colormode'
        /// </summary>
        [Fact]
        public void ColormodeTest()
        {
            // TODO unit test for the property 'Colormode'
        }

        /// <summary>
        /// Test the property 'Audiocodec'
        /// </summary>
        [Fact]
        public void AudiocodecTest()
        {
            // TODO unit test for the property 'Audiocodec'
        }

        /// <summary>
        /// Test the property 'Audiosamplerate'
        /// </summary>
        [Fact]
        public void AudiosamplerateTest()
        {
            // TODO unit test for the property 'Audiosamplerate'
        }

        /// <summary>
        /// Test the property 'Audiochanneloutput'
        /// </summary>
        [Fact]
        public void AudiochanneloutputTest()
        {
            // TODO unit test for the property 'Audiochanneloutput'
        }

        /// <summary>
        /// Test the property 'Audiobitrate'
        /// </summary>
        [Fact]
        public void AudiobitrateTest()
        {
            // TODO unit test for the property 'Audiobitrate'
        }

        /// <summary>
        /// Test the property 'Author'
        /// </summary>
        [Fact]
        public void AuthorTest()
        {
            // TODO unit test for the property 'Author'
        }

        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }

        /// <summary>
        /// Test the property 'Wordcount'
        /// </summary>
        [Fact]
        public void WordcountTest()
        {
            // TODO unit test for the property 'Wordcount'
        }

        /// <summary>
        /// Test the property 'Pages'
        /// </summary>
        [Fact]
        public void PagesTest()
        {
            // TODO unit test for the property 'Pages'
        }

        /// <summary>
        /// Test the property 'EncodingName'
        /// </summary>
        [Fact]
        public void EncodingNameTest()
        {
            // TODO unit test for the property 'EncodingName'
        }

        /// <summary>
        /// Test the property 'EncodingCode'
        /// </summary>
        [Fact]
        public void EncodingCodeTest()
        {
            // TODO unit test for the property 'EncodingCode'
        }

        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }

        /// <summary>
        /// Test the property 'SizeReadable'
        /// </summary>
        [Fact]
        public void SizeReadableTest()
        {
            // TODO unit test for the property 'SizeReadable'
        }

        /// <summary>
        /// Test the property 'Downloadable'
        /// </summary>
        [Fact]
        public void DownloadableTest()
        {
            // TODO unit test for the property 'Downloadable'
        }

        /// <summary>
        /// Test the property 'Expires'
        /// </summary>
        [Fact]
        public void ExpiresTest()
        {
            // TODO unit test for the property 'Expires'
        }

        /// <summary>
        /// Test the property 'UploadedDate'
        /// </summary>
        [Fact]
        public void UploadedDateTest()
        {
            // TODO unit test for the property 'UploadedDate'
        }

        /// <summary>
        /// Test the property 'UploadedBy'
        /// </summary>
        [Fact]
        public void UploadedByTest()
        {
            // TODO unit test for the property 'UploadedBy'
        }
    }
}
