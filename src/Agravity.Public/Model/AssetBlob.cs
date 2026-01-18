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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Agravity.Public.Client.OpenAPIDateConverter;

namespace Agravity.Public.Model
{
    /// <summary>
    /// AssetBlob
    /// </summary>
    [DataContract(Name = "assetBlob")]
    public partial class AssetBlob : IValidatableObject
    {
        /// <summary>
        /// Defines BlobType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlobTypeEnum
        {
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            [EnumMember(Value = "IMAGE")]
            IMAGE,

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            VIDEO,

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            [EnumMember(Value = "AUDIO")]
            AUDIO,

            /// <summary>
            /// Enum DOCUMENT for value: DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENT,

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            [EnumMember(Value = "TEXT")]
            TEXT,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }


        /// <summary>
        /// Gets or Sets BlobType
        /// </summary>
        [DataMember(Name = "blob_type", EmitDefaultValue = false)]
        public BlobTypeEnum? BlobType { get; set; }
        /// <summary>
        /// Defines Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            /// <summary>
            /// Enum PORTRAIT for value: PORTRAIT
            /// </summary>
            [EnumMember(Value = "PORTRAIT")]
            PORTRAIT = 1,

            /// <summary>
            /// Enum LANDSCAPE for value: LANDSCAPE
            /// </summary>
            [EnumMember(Value = "LANDSCAPE")]
            LANDSCAPE = 2,

            /// <summary>
            /// Enum SQUARE for value: SQUARE
            /// </summary>
            [EnumMember(Value = "SQUARE")]
            SQUARE = 3
        }


        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name = "orientation", EmitDefaultValue = true)]
        public OrientationEnum? Orientation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetBlob" /> class.
        /// </summary>
        /// <param name="blobType">blobType (default to BlobTypeEnum.UNKNOWN).</param>
        /// <param name="name">name.</param>
        /// <param name="container">container.</param>
        /// <param name="size">size.</param>
        /// <param name="extension">extension.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="md5">md5.</param>
        /// <param name="addData">addData.</param>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        /// <param name="maxwidthheight">maxwidthheight.</param>
        /// <param name="quality">quality.</param>
        /// <param name="orientation">orientation (default to OrientationEnum.PORTRAIT).</param>
        /// <param name="colorspace">colorspace.</param>
        /// <param name="profile">profile.</param>
        /// <param name="transparency">transparency.</param>
        /// <param name="mode">mode.</param>
        /// <param name="target">target.</param>
        /// <param name="filter">filter.</param>
        /// <param name="dpiX">dpiX.</param>
        /// <param name="dpiY">dpiY.</param>
        /// <param name="perhash">perhash.</param>
        /// <param name="dominantcolor">dominantcolor.</param>
        /// <param name="depth">depth.</param>
        /// <param name="animated">animated.</param>
        /// <param name="duration">duration.</param>
        /// <param name="videocodec">videocodec.</param>
        /// <param name="videobitrate">videobitrate.</param>
        /// <param name="fps">fps.</param>
        /// <param name="colormode">colormode.</param>
        /// <param name="audiocodec">audiocodec.</param>
        /// <param name="audiosamplerate">audiosamplerate.</param>
        /// <param name="audiochanneloutput">audiochanneloutput.</param>
        /// <param name="audiobitrate">audiobitrate.</param>
        /// <param name="author">author.</param>
        /// <param name="title">title.</param>
        /// <param name="language">language.</param>
        /// <param name="wordcount">wordcount.</param>
        /// <param name="pages">pages.</param>
        /// <param name="encodingName">encodingName.</param>
        /// <param name="encodingCode">encodingCode.</param>
        /// <param name="url">url.</param>
        /// <param name="sizeReadable">sizeReadable.</param>
        /// <param name="downloadable">downloadable.</param>
        /// <param name="expires">expires.</param>
        /// <param name="uploadedDate">uploadedDate.</param>
        /// <param name="uploadedBy">uploadedBy.</param>
        public AssetBlob(BlobTypeEnum? blobType = BlobTypeEnum.UNKNOWN, string name = default, string container = default, long? size = default, string extension = default, string contentType = default, string md5 = default, Dictionary<string, object> addData = default, int? width = default, int? height = default, int? maxwidthheight = default, double? quality = default, OrientationEnum? orientation = OrientationEnum.PORTRAIT, string colorspace = default, string profile = default, bool? transparency = default, string mode = default, string target = default, string filter = default, double? dpiX = default, double? dpiY = default, string perhash = default, string dominantcolor = default, int? depth = default, bool? animated = default, int? duration = default, string videocodec = default, int? videobitrate = default, double? fps = default, string colormode = default, string audiocodec = default, string audiosamplerate = default, string audiochanneloutput = default, int? audiobitrate = default, string author = default, string title = default, string language = default, int? wordcount = default, int? pages = default, string encodingName = default, string encodingCode = default, string url = default, string sizeReadable = default, bool? downloadable = default, DateTime? expires = default, DateTime? uploadedDate = default, string uploadedBy = default)
        {
            this.BlobType = blobType;
            this.Name = name;
            this.Container = container;
            this.Size = size;
            this.Extension = extension;
            this.ContentType = contentType;
            this.Md5 = md5;
            this.AddData = addData;
            this.Width = width;
            this.Height = height;
            this.Maxwidthheight = maxwidthheight;
            this.Quality = quality;
            this.Orientation = orientation;
            this.Colorspace = colorspace;
            this.Profile = profile;
            this.Transparency = transparency;
            this.Mode = mode;
            this.Target = target;
            this.Filter = filter;
            this.DpiX = dpiX;
            this.DpiY = dpiY;
            this.Perhash = perhash;
            this.Dominantcolor = dominantcolor;
            this.Depth = depth;
            this.Animated = animated;
            this.Duration = duration;
            this.Videocodec = videocodec;
            this.Videobitrate = videobitrate;
            this.Fps = fps;
            this.Colormode = colormode;
            this.Audiocodec = audiocodec;
            this.Audiosamplerate = audiosamplerate;
            this.Audiochanneloutput = audiochanneloutput;
            this.Audiobitrate = audiobitrate;
            this.Author = author;
            this.Title = title;
            this.Language = language;
            this.Wordcount = wordcount;
            this.Pages = pages;
            this.EncodingName = encodingName;
            this.EncodingCode = encodingCode;
            this.Url = url;
            this.SizeReadable = sizeReadable;
            this.Downloadable = downloadable;
            this.Expires = expires;
            this.UploadedDate = uploadedDate;
            this.UploadedBy = uploadedBy;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name = "container", EmitDefaultValue = true)]
        public string Container { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "content_type", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name = "md5", EmitDefaultValue = true)]
        public string Md5 { get; set; }

        /// <summary>
        /// Gets or Sets AddData
        /// </summary>
        [DataMember(Name = "add_data", EmitDefaultValue = true)]
        public Dictionary<string, object> AddData { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = true)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = true)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Maxwidthheight
        /// </summary>
        [DataMember(Name = "maxwidthheight", EmitDefaultValue = true)]
        public int? Maxwidthheight { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = true)]
        public double? Quality { get; set; }

        /// <summary>
        /// Gets or Sets Colorspace
        /// </summary>
        [DataMember(Name = "colorspace", EmitDefaultValue = true)]
        public string Colorspace { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = true)]
        public string Profile { get; set; }

        /// <summary>
        /// Gets or Sets Transparency
        /// </summary>
        [DataMember(Name = "transparency", EmitDefaultValue = true)]
        public bool? Transparency { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = true)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets DpiX
        /// </summary>
        [DataMember(Name = "dpi_x", EmitDefaultValue = true)]
        public double? DpiX { get; set; }

        /// <summary>
        /// Gets or Sets DpiY
        /// </summary>
        [DataMember(Name = "dpi_y", EmitDefaultValue = true)]
        public double? DpiY { get; set; }

        /// <summary>
        /// Gets or Sets Perhash
        /// </summary>
        [DataMember(Name = "perhash", EmitDefaultValue = true)]
        public string Perhash { get; set; }

        /// <summary>
        /// Gets or Sets Dominantcolor
        /// </summary>
        [DataMember(Name = "dominantcolor", EmitDefaultValue = true)]
        public string Dominantcolor { get; set; }

        /// <summary>
        /// Gets or Sets Depth
        /// </summary>
        [DataMember(Name = "depth", EmitDefaultValue = true)]
        public int? Depth { get; set; }

        /// <summary>
        /// Gets or Sets Animated
        /// </summary>
        [DataMember(Name = "animated", EmitDefaultValue = true)]
        public bool? Animated { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets Videocodec
        /// </summary>
        [DataMember(Name = "videocodec", EmitDefaultValue = true)]
        public string Videocodec { get; set; }

        /// <summary>
        /// Gets or Sets Videobitrate
        /// </summary>
        [DataMember(Name = "videobitrate", EmitDefaultValue = true)]
        public int? Videobitrate { get; set; }

        /// <summary>
        /// Gets or Sets Fps
        /// </summary>
        [DataMember(Name = "fps", EmitDefaultValue = true)]
        public double? Fps { get; set; }

        /// <summary>
        /// Gets or Sets Colormode
        /// </summary>
        [DataMember(Name = "colormode", EmitDefaultValue = true)]
        public string Colormode { get; set; }

        /// <summary>
        /// Gets or Sets Audiocodec
        /// </summary>
        [DataMember(Name = "audiocodec", EmitDefaultValue = true)]
        public string Audiocodec { get; set; }

        /// <summary>
        /// Gets or Sets Audiosamplerate
        /// </summary>
        [DataMember(Name = "audiosamplerate", EmitDefaultValue = true)]
        public string Audiosamplerate { get; set; }

        /// <summary>
        /// Gets or Sets Audiochanneloutput
        /// </summary>
        [DataMember(Name = "audiochanneloutput", EmitDefaultValue = true)]
        public string Audiochanneloutput { get; set; }

        /// <summary>
        /// Gets or Sets Audiobitrate
        /// </summary>
        [DataMember(Name = "audiobitrate", EmitDefaultValue = true)]
        public int? Audiobitrate { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Wordcount
        /// </summary>
        [DataMember(Name = "wordcount", EmitDefaultValue = true)]
        public int? Wordcount { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name = "pages", EmitDefaultValue = true)]
        public int? Pages { get; set; }

        /// <summary>
        /// Gets or Sets EncodingName
        /// </summary>
        [DataMember(Name = "encoding_name", EmitDefaultValue = true)]
        public string EncodingName { get; set; }

        /// <summary>
        /// Gets or Sets EncodingCode
        /// </summary>
        [DataMember(Name = "encoding_code", EmitDefaultValue = true)]
        public string EncodingCode { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SizeReadable
        /// </summary>
        [DataMember(Name = "size_readable", EmitDefaultValue = true)]
        public string SizeReadable { get; set; }

        /// <summary>
        /// Gets or Sets Downloadable
        /// </summary>
        [DataMember(Name = "downloadable", EmitDefaultValue = true)]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = true)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or Sets UploadedDate
        /// </summary>
        [DataMember(Name = "uploaded_date", EmitDefaultValue = true)]
        public DateTime? UploadedDate { get; set; }

        /// <summary>
        /// Gets or Sets UploadedBy
        /// </summary>
        [DataMember(Name = "uploaded_by", EmitDefaultValue = true)]
        public string UploadedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetBlob {\n");
            sb.Append("  BlobType: ").Append(BlobType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  AddData: ").Append(AddData).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Maxwidthheight: ").Append(Maxwidthheight).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Colorspace: ").Append(Colorspace).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Transparency: ").Append(Transparency).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  DpiX: ").Append(DpiX).Append("\n");
            sb.Append("  DpiY: ").Append(DpiY).Append("\n");
            sb.Append("  Perhash: ").Append(Perhash).Append("\n");
            sb.Append("  Dominantcolor: ").Append(Dominantcolor).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Animated: ").Append(Animated).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Videocodec: ").Append(Videocodec).Append("\n");
            sb.Append("  Videobitrate: ").Append(Videobitrate).Append("\n");
            sb.Append("  Fps: ").Append(Fps).Append("\n");
            sb.Append("  Colormode: ").Append(Colormode).Append("\n");
            sb.Append("  Audiocodec: ").Append(Audiocodec).Append("\n");
            sb.Append("  Audiosamplerate: ").Append(Audiosamplerate).Append("\n");
            sb.Append("  Audiochanneloutput: ").Append(Audiochanneloutput).Append("\n");
            sb.Append("  Audiobitrate: ").Append(Audiobitrate).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Wordcount: ").Append(Wordcount).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  EncodingName: ").Append(EncodingName).Append("\n");
            sb.Append("  EncodingCode: ").Append(EncodingCode).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SizeReadable: ").Append(SizeReadable).Append("\n");
            sb.Append("  Downloadable: ").Append(Downloadable).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  UploadedDate: ").Append(UploadedDate).Append("\n");
            sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
