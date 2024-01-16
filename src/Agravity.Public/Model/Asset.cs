/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.1.4
 * Contact: office@agravity.io
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
    /// Asset
    /// </summary>
    [DataContract(Name = "asset")]
    public partial class Asset : IEquatable<Asset>, IValidatableObject
    {
        /// <summary>
        /// Defines Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,

            /// <summary>
            /// Enum VIEWER for value: VIEWER
            /// </summary>
            [EnumMember(Value = "VIEWER")]
            VIEWER = 2,

            /// <summary>
            /// Enum EDITOR for value: EDITOR
            /// </summary>
            [EnumMember(Value = "EDITOR")]
            EDITOR = 3

        }


        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="name">name.</param>
        /// <param name="assetType">assetType.</param>
        /// <param name="duplicates">duplicates.</param>
        /// <param name="textContent">textContent.</param>
        /// <param name="aiGroups">aiGroups.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="origBlob">origBlob.</param>
        /// <param name="blobs">blobs.</param>
        /// <param name="collections">collections.</param>
        /// <param name="failedReason">failedReason.</param>
        /// <param name="regionOfOrigin">regionOfOrigin.</param>
        /// <param name="availability">availability.</param>
        /// <param name="availableFrom">availableFrom.</param>
        /// <param name="availableTo">availableTo.</param>
        /// <param name="custom">custom.</param>
        /// <param name="items">items.</param>
        /// <param name="translations">translations.</param>
        /// <param name="role">role (default to RoleEnum.NONE).</param>
        /// <param name="description">description.</param>
        /// <param name="addProperties">addProperties.</param>
        /// <param name="status">status.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="pk">pk.</param>
        /// <param name="etag">etag.</param>
        public Asset(string id = default(string), string entityType = default(string), string name = default(string), string assetType = default(string), List<string> duplicates = default(List<string>), string textContent = default(string), List<ArtificialIntelligenceGroup> aiGroups = default(List<ArtificialIntelligenceGroup>), List<string> keywords = default(List<string>), AssetBlob origBlob = default(AssetBlob), List<AssetBlob> blobs = default(List<AssetBlob>), List<string> collections = default(List<string>), string failedReason = default(string), string regionOfOrigin = default(string), string availability = default(string), DateTime? availableFrom = default(DateTime?), DateTime? availableTo = default(DateTime?), Dictionary<string, object> custom = default(Dictionary<string, object>), List<CollTypeItem> items = default(List<CollTypeItem>), Dictionary<string, Dictionary<string, object>> translations = default(Dictionary<string, Dictionary<string, object>>), RoleEnum? role = RoleEnum.NONE, string description = default(string), Dictionary<string, object> addProperties = default(Dictionary<string, object>), string status = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), DateTime? modifiedDate = default(DateTime?), string modifiedBy = default(string), string pk = default(string), string etag = default(string))
        {
            this.Id = id;
            this.EntityType = entityType;
            this.Name = name;
            this.AssetType = assetType;
            this.Duplicates = duplicates;
            this.TextContent = textContent;
            this.AiGroups = aiGroups;
            this.Keywords = keywords;
            this.OrigBlob = origBlob;
            this.Blobs = blobs;
            this.Collections = collections;
            this.FailedReason = failedReason;
            this.RegionOfOrigin = regionOfOrigin;
            this.Availability = availability;
            this.AvailableFrom = availableFrom;
            this.AvailableTo = availableTo;
            this.Custom = custom;
            this.Items = items;
            this.Translations = translations;
            this.Role = role;
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entity_type", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AssetType
        /// </summary>
        [DataMember(Name = "asset_type", EmitDefaultValue = false)]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or Sets Duplicates
        /// </summary>
        [DataMember(Name = "duplicates", EmitDefaultValue = false)]
        public List<string> Duplicates { get; set; }

        /// <summary>
        /// Gets or Sets TextContent
        /// </summary>
        [DataMember(Name = "text_content", EmitDefaultValue = false)]
        public string TextContent { get; set; }

        /// <summary>
        /// Gets or Sets AiGroups
        /// </summary>
        [DataMember(Name = "ai_groups", EmitDefaultValue = false)]
        public List<ArtificialIntelligenceGroup> AiGroups { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets OrigBlob
        /// </summary>
        [DataMember(Name = "orig_blob", EmitDefaultValue = false)]
        public AssetBlob OrigBlob { get; set; }

        /// <summary>
        /// Gets or Sets Blobs
        /// </summary>
        [DataMember(Name = "blobs", EmitDefaultValue = false)]
        public List<AssetBlob> Blobs { get; set; }

        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name = "collections", EmitDefaultValue = false)]
        public List<string> Collections { get; set; }

        /// <summary>
        /// Gets or Sets FailedReason
        /// </summary>
        [DataMember(Name = "failed_reason", EmitDefaultValue = false)]
        public string FailedReason { get; set; }

        /// <summary>
        /// Gets or Sets RegionOfOrigin
        /// </summary>
        [DataMember(Name = "region_of_origin", EmitDefaultValue = false)]
        public string RegionOfOrigin { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name = "availability", EmitDefaultValue = false)]
        public string Availability { get; set; }

        /// <summary>
        /// Gets or Sets AvailableFrom
        /// </summary>
        [DataMember(Name = "available_from", EmitDefaultValue = true)]
        public DateTime? AvailableFrom { get; set; }

        /// <summary>
        /// Gets or Sets AvailableTo
        /// </summary>
        [DataMember(Name = "available_to", EmitDefaultValue = true)]
        public DateTime? AvailableTo { get; set; }

        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [DataMember(Name = "custom", EmitDefaultValue = false)]
        public Dictionary<string, object> Custom { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<CollTypeItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name = "translations", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, object>> Translations { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AddProperties
        /// </summary>
        [DataMember(Name = "add_properties", EmitDefaultValue = false)]
        public Dictionary<string, object> AddProperties { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "created_date", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modified_date", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modified_by", EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name = "pk", EmitDefaultValue = false)]
        public string Pk { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  Duplicates: ").Append(Duplicates).Append("\n");
            sb.Append("  TextContent: ").Append(TextContent).Append("\n");
            sb.Append("  AiGroups: ").Append(AiGroups).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  OrigBlob: ").Append(OrigBlob).Append("\n");
            sb.Append("  Blobs: ").Append(Blobs).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
            sb.Append("  FailedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  RegionOfOrigin: ").Append(RegionOfOrigin).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  AvailableTo: ").Append(AvailableTo).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.Duplicates == input.Duplicates ||
                    this.Duplicates != null &&
                    input.Duplicates != null &&
                    this.Duplicates.SequenceEqual(input.Duplicates)
                ) && 
                (
                    this.TextContent == input.TextContent ||
                    (this.TextContent != null &&
                    this.TextContent.Equals(input.TextContent))
                ) && 
                (
                    this.AiGroups == input.AiGroups ||
                    this.AiGroups != null &&
                    input.AiGroups != null &&
                    this.AiGroups.SequenceEqual(input.AiGroups)
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.OrigBlob == input.OrigBlob ||
                    (this.OrigBlob != null &&
                    this.OrigBlob.Equals(input.OrigBlob))
                ) && 
                (
                    this.Blobs == input.Blobs ||
                    this.Blobs != null &&
                    input.Blobs != null &&
                    this.Blobs.SequenceEqual(input.Blobs)
                ) && 
                (
                    this.Collections == input.Collections ||
                    this.Collections != null &&
                    input.Collections != null &&
                    this.Collections.SequenceEqual(input.Collections)
                ) && 
                (
                    this.FailedReason == input.FailedReason ||
                    (this.FailedReason != null &&
                    this.FailedReason.Equals(input.FailedReason))
                ) && 
                (
                    this.RegionOfOrigin == input.RegionOfOrigin ||
                    (this.RegionOfOrigin != null &&
                    this.RegionOfOrigin.Equals(input.RegionOfOrigin))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.AvailableFrom == input.AvailableFrom ||
                    (this.AvailableFrom != null &&
                    this.AvailableFrom.Equals(input.AvailableFrom))
                ) && 
                (
                    this.AvailableTo == input.AvailableTo ||
                    (this.AvailableTo != null &&
                    this.AvailableTo.Equals(input.AvailableTo))
                ) && 
                (
                    this.Custom == input.Custom ||
                    this.Custom != null &&
                    input.Custom != null &&
                    this.Custom.SequenceEqual(input.Custom)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Translations == input.Translations ||
                    this.Translations != null &&
                    input.Translations != null &&
                    this.Translations.SequenceEqual(input.Translations)
                ) && 
                (
                    this.Role == input.Role ||
                    this.Role.Equals(input.Role)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AddProperties == input.AddProperties ||
                    this.AddProperties != null &&
                    input.AddProperties != null &&
                    this.AddProperties.SequenceEqual(input.AddProperties)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.Pk == input.Pk ||
                    (this.Pk != null &&
                    this.Pk.Equals(input.Pk))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                }
                if (this.Duplicates != null)
                {
                    hashCode = (hashCode * 59) + this.Duplicates.GetHashCode();
                }
                if (this.TextContent != null)
                {
                    hashCode = (hashCode * 59) + this.TextContent.GetHashCode();
                }
                if (this.AiGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AiGroups.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                if (this.OrigBlob != null)
                {
                    hashCode = (hashCode * 59) + this.OrigBlob.GetHashCode();
                }
                if (this.Blobs != null)
                {
                    hashCode = (hashCode * 59) + this.Blobs.GetHashCode();
                }
                if (this.Collections != null)
                {
                    hashCode = (hashCode * 59) + this.Collections.GetHashCode();
                }
                if (this.FailedReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailedReason.GetHashCode();
                }
                if (this.RegionOfOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.RegionOfOrigin.GetHashCode();
                }
                if (this.Availability != null)
                {
                    hashCode = (hashCode * 59) + this.Availability.GetHashCode();
                }
                if (this.AvailableFrom != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableFrom.GetHashCode();
                }
                if (this.AvailableTo != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableTo.GetHashCode();
                }
                if (this.Custom != null)
                {
                    hashCode = (hashCode * 59) + this.Custom.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.Translations != null)
                {
                    hashCode = (hashCode * 59) + this.Translations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Role.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AddProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AddProperties.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.ModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedBy.GetHashCode();
                }
                if (this.Pk != null)
                {
                    hashCode = (hashCode * 59) + this.Pk.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
