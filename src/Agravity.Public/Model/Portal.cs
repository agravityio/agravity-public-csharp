/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.2.1
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
    /// Portal
    /// </summary>
    [DataContract(Name = "portal")]
    public partial class Portal : IEquatable<Portal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Portal" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="filter">filter.</param>
        /// <param name="languages">languages.</param>
        /// <param name="theme">theme.</param>
        /// <param name="links">links.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="facettes">facettes.</param>
        /// <param name="allowedFormats">allowedFormats.</param>
        /// <param name="limitIds">limitIds.</param>
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
        public Portal(string id = default(string), string entityType = default(string), string filter = default(string), PortalLanguages languages = default(PortalLanguages), PortalTheme theme = default(PortalTheme), PortalLinks links = default(PortalLinks), List<string> metadata = default(List<string>), List<string> facettes = default(List<string>), List<SharedAllowedFormat> allowedFormats = default(List<SharedAllowedFormat>), List<string> limitIds = default(List<string>), string name = default(string), string description = default(string), Dictionary<string, object> addProperties = default(Dictionary<string, object>), string status = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), DateTime? modifiedDate = default(DateTime?), string modifiedBy = default(string), string pk = default(string), string etag = default(string))
        {
            this.Id = id;
            this.EntityType = entityType;
            this.Filter = filter;
            this.Languages = languages;
            this.Theme = theme;
            this.Links = links;
            this.Metadata = metadata;
            this.Facettes = facettes;
            this.AllowedFormats = allowedFormats;
            this.LimitIds = limitIds;
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
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public PortalLanguages Languages { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public PortalTheme Theme { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public PortalLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Facettes
        /// </summary>
        [DataMember(Name = "facettes", EmitDefaultValue = false)]
        public List<string> Facettes { get; set; }

        /// <summary>
        /// Gets or Sets AllowedFormats
        /// </summary>
        [DataMember(Name = "allowed_formats", EmitDefaultValue = false)]
        public List<SharedAllowedFormat> AllowedFormats { get; set; }

        /// <summary>
        /// Gets or Sets LimitIds
        /// </summary>
        [DataMember(Name = "limit_ids", EmitDefaultValue = false)]
        public List<string> LimitIds { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

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
            sb.Append("class Portal {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Facettes: ").Append(Facettes).Append("\n");
            sb.Append("  AllowedFormats: ").Append(AllowedFormats).Append("\n");
            sb.Append("  LimitIds: ").Append(LimitIds).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Portal);
        }

        /// <summary>
        /// Returns true if Portal instances are equal
        /// </summary>
        /// <param name="input">Instance of Portal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Portal input)
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
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Languages == input.Languages ||
                    (this.Languages != null &&
                    this.Languages.Equals(input.Languages))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Facettes == input.Facettes ||
                    this.Facettes != null &&
                    input.Facettes != null &&
                    this.Facettes.SequenceEqual(input.Facettes)
                ) && 
                (
                    this.AllowedFormats == input.AllowedFormats ||
                    this.AllowedFormats != null &&
                    input.AllowedFormats != null &&
                    this.AllowedFormats.SequenceEqual(input.AllowedFormats)
                ) && 
                (
                    this.LimitIds == input.LimitIds ||
                    this.LimitIds != null &&
                    input.LimitIds != null &&
                    this.LimitIds.SequenceEqual(input.LimitIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.Theme != null)
                {
                    hashCode = (hashCode * 59) + this.Theme.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Facettes != null)
                {
                    hashCode = (hashCode * 59) + this.Facettes.GetHashCode();
                }
                if (this.AllowedFormats != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedFormats.GetHashCode();
                }
                if (this.LimitIds != null)
                {
                    hashCode = (hashCode * 59) + this.LimitIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
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
