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
    /// PortalConfiguration
    /// </summary>
    [DataContract(Name = "portalConfiguration")]
    public partial class PortalConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalConfiguration" /> class.
        /// </summary>
        /// <param name="downloadFormats">downloadFormats.</param>
        /// <param name="sdls">sdls.</param>
        /// <param name="udls">udls.</param>
        /// <param name="items">items.</param>
        /// <param name="configs">configs.</param>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="languages">languages.</param>
        /// <param name="fields">fields.</param>
        /// <param name="filter">filter.</param>
        /// <param name="limitIds">limitIds.</param>
        /// <param name="allowedFormats">allowedFormats.</param>
        /// <param name="assetIconRules">assetIconRules.</param>
        /// <param name="allowedOrigins">allowedOrigins.</param>
        /// <param name="links">links.</param>
        /// <param name="theme">theme.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="addProperties">addProperties.</param>
        /// <param name="status">status.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="pk">pk.</param>
        /// <param name="etag">etag.</param>
        public PortalConfiguration(List<DownloadFormat> downloadFormats = default, List<StaticDefinedList> sdls = default, List<CollectionUDL> udls = default, List<CollTypeItem> items = default, List<FrontendAppConfig> configs = default, string id = default, string entityType = default, PortalAuthentication authentication = default, string languages = default, List<PortalFields> fields = default, string filter = default, List<string> limitIds = default, List<SharedAllowedFormat> allowedFormats = default, List<AssetIconRule> assetIconRules = default, List<string> allowedOrigins = default, PortalLinks links = default, PortalTheme theme = default, string name = default, string description = default, Dictionary<string, object> addProperties = default, string status = default, DateTime? createdDate = default, string createdBy = default, DateTime? modifiedDate = default, string modifiedBy = default, string pk = default, string etag = default)
        {
            this.DownloadFormats = downloadFormats;
            this.Sdls = sdls;
            this.Udls = udls;
            this.Items = items;
            this.Configs = configs;
            this.Id = id;
            this.EntityType = entityType;
            this.Authentication = authentication;
            this.Languages = languages;
            this.Fields = fields;
            this.Filter = filter;
            this.LimitIds = limitIds;
            this.AllowedFormats = allowedFormats;
            this.AssetIconRules = assetIconRules;
            this.AllowedOrigins = allowedOrigins;
            this.Links = links;
            this.Theme = theme;
            this.Name = name;
            this.Description = description;
            this.AddProperties = addProperties;
            this.Status = status;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.ModifiedDate = modifiedDate;
            this.ModifiedBy = modifiedBy;
            this.Pk = pk;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets DownloadFormats
        /// </summary>
        [DataMember(Name = "download_formats", EmitDefaultValue = true)]
        public List<DownloadFormat> DownloadFormats { get; set; }

        /// <summary>
        /// Gets or Sets Sdls
        /// </summary>
        [DataMember(Name = "sdls", EmitDefaultValue = true)]
        public List<StaticDefinedList> Sdls { get; set; }

        /// <summary>
        /// Gets or Sets Udls
        /// </summary>
        [DataMember(Name = "udls", EmitDefaultValue = true)]
        public List<CollectionUDL> Udls { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<CollTypeItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Configs
        /// </summary>
        [DataMember(Name = "configs", EmitDefaultValue = true)]
        public List<FrontendAppConfig> Configs { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entity_type", EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", EmitDefaultValue = true)]
        public PortalAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = true)]
        public string Languages { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<PortalFields> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets LimitIds
        /// </summary>
        [DataMember(Name = "limit_ids", EmitDefaultValue = true)]
        public List<string> LimitIds { get; set; }

        /// <summary>
        /// Gets or Sets AllowedFormats
        /// </summary>
        [DataMember(Name = "allowed_formats", EmitDefaultValue = true)]
        public List<SharedAllowedFormat> AllowedFormats { get; set; }

        /// <summary>
        /// Gets or Sets AssetIconRules
        /// </summary>
        [DataMember(Name = "asset_icon_rules", EmitDefaultValue = true)]
        public List<AssetIconRule> AssetIconRules { get; set; }

        /// <summary>
        /// Gets or Sets AllowedOrigins
        /// </summary>
        [DataMember(Name = "allowed_origins", EmitDefaultValue = true)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public PortalLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = true)]
        public PortalTheme Theme { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AddProperties
        /// </summary>
        [DataMember(Name = "add_properties", EmitDefaultValue = true)]
        public Dictionary<string, object> AddProperties { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "created_date", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modified_date", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modified_by", EmitDefaultValue = true)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name = "pk", EmitDefaultValue = true)]
        public string Pk { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name = "_etag", EmitDefaultValue = true)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PortalConfiguration {\n");
            sb.Append("  DownloadFormats: ").Append(DownloadFormats).Append("\n");
            sb.Append("  Sdls: ").Append(Sdls).Append("\n");
            sb.Append("  Udls: ").Append(Udls).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Configs: ").Append(Configs).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  LimitIds: ").Append(LimitIds).Append("\n");
            sb.Append("  AllowedFormats: ").Append(AllowedFormats).Append("\n");
            sb.Append("  AssetIconRules: ").Append(AssetIconRules).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AddProperties: ").Append(AddProperties).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
