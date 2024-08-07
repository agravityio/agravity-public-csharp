/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.3.0
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
    /// PortalZipRequest
    /// </summary>
    [DataContract(Name = "portalZipRequest")]
    public partial class PortalZipRequest : IEquatable<PortalZipRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalZipRequest" /> class.
        /// </summary>
        /// <param name="zipType">zipType.</param>
        /// <param name="portalId">portalId.</param>
        /// <param name="assetIds">assetIds.</param>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="url">url.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="validUntil">validUntil.</param>
        /// <param name="allowedFormats">allowedFormats.</param>
        /// <param name="error">error.</param>
        /// <param name="status">status.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="pk">pk.</param>
        /// <param name="etag">etag.</param>
        public PortalZipRequest(string zipType = default(string), string portalId = default(string), List<string> assetIds = default(List<string>), string id = default(string), string entityType = default(string), string url = default(string), string instanceId = default(string), DateTime validUntil = default(DateTime), List<SharedAllowedFormat> allowedFormats = default(List<SharedAllowedFormat>), AgravityErrorResponse error = default(AgravityErrorResponse), string status = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), DateTime? modifiedDate = default(DateTime?), string modifiedBy = default(string), string pk = default(string), string etag = default(string))
        {
            this.ZipType = zipType;
            this.PortalId = portalId;
            this.AssetIds = assetIds;
            this.Id = id;
            this.EntityType = entityType;
            this.Url = url;
            this.InstanceId = instanceId;
            this.ValidUntil = validUntil;
            this.AllowedFormats = allowedFormats;
            this.Error = error;
            this.Status = status;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.ModifiedDate = modifiedDate;
            this.ModifiedBy = modifiedBy;
            this.Pk = pk;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets ZipType
        /// </summary>
        [DataMember(Name = "zip_type", EmitDefaultValue = false)]
        public string ZipType { get; set; }

        /// <summary>
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name = "portal_id", EmitDefaultValue = false)]
        public string PortalId { get; set; }

        /// <summary>
        /// Gets or Sets AssetIds
        /// </summary>
        [DataMember(Name = "asset_ids", EmitDefaultValue = false)]
        public List<string> AssetIds { get; set; }

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
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instance_id", EmitDefaultValue = false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name = "valid_until", EmitDefaultValue = false)]
        public DateTime ValidUntil { get; set; }

        /// <summary>
        /// Gets or Sets AllowedFormats
        /// </summary>
        [DataMember(Name = "allowed_formats", EmitDefaultValue = false)]
        public List<SharedAllowedFormat> AllowedFormats { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public AgravityErrorResponse Error { get; set; }

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
            sb.Append("class PortalZipRequest {\n");
            sb.Append("  ZipType: ").Append(ZipType).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  AssetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  AllowedFormats: ").Append(AllowedFormats).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as PortalZipRequest);
        }

        /// <summary>
        /// Returns true if PortalZipRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PortalZipRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortalZipRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ZipType == input.ZipType ||
                    (this.ZipType != null &&
                    this.ZipType.Equals(input.ZipType))
                ) && 
                (
                    this.PortalId == input.PortalId ||
                    (this.PortalId != null &&
                    this.PortalId.Equals(input.PortalId))
                ) && 
                (
                    this.AssetIds == input.AssetIds ||
                    this.AssetIds != null &&
                    input.AssetIds != null &&
                    this.AssetIds.SequenceEqual(input.AssetIds)
                ) && 
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
                ) && 
                (
                    this.AllowedFormats == input.AllowedFormats ||
                    this.AllowedFormats != null &&
                    input.AllowedFormats != null &&
                    this.AllowedFormats.SequenceEqual(input.AllowedFormats)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.ZipType != null)
                {
                    hashCode = (hashCode * 59) + this.ZipType.GetHashCode();
                }
                if (this.PortalId != null)
                {
                    hashCode = (hashCode * 59) + this.PortalId.GetHashCode();
                }
                if (this.AssetIds != null)
                {
                    hashCode = (hashCode * 59) + this.AssetIds.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                if (this.ValidUntil != null)
                {
                    hashCode = (hashCode * 59) + this.ValidUntil.GetHashCode();
                }
                if (this.AllowedFormats != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedFormats.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
