/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.1.3
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
    /// SharedCollectionFull
    /// </summary>
    [DataContract(Name = "sharedCollectionFull")]
    public partial class SharedCollectionFull : IEquatable<SharedCollectionFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedCollectionFull" /> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="size">size.</param>
        /// <param name="continuationToken">continuationToken.</param>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="url">url.</param>
        /// <param name="validUntil">validUntil.</param>
        /// <param name="validFor">validFor.</param>
        /// <param name="message">message.</param>
        /// <param name="global">global.</param>
        /// <param name="allowedFormats">allowedFormats.</param>
        /// <param name="password">password.</param>
        /// <param name="status">status.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="pk">pk.</param>
        /// <param name="etag">etag.</param>
        public SharedCollectionFull(List<SharedAsset> page = default(List<SharedAsset>), int pageSize = default(int), int? size = default(int?), string continuationToken = default(string), string id = default(string), string entityType = default(string), string collectionId = default(string), string url = default(string), DateTime validUntil = default(DateTime), string validFor = default(string), string message = default(string), bool global = default(bool), List<SharedAllowedFormat> allowedFormats = default(List<SharedAllowedFormat>), string password = default(string), string status = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), DateTime? modifiedDate = default(DateTime?), string modifiedBy = default(string), string pk = default(string), string etag = default(string))
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.Size = size;
            this.ContinuationToken = continuationToken;
            this.Id = id;
            this.EntityType = entityType;
            this.CollectionId = collectionId;
            this.Url = url;
            this.ValidUntil = validUntil;
            this.ValidFor = validFor;
            this.Message = message;
            this.Global = global;
            this.AllowedFormats = allowedFormats;
            this.Password = password;
            this.Status = status;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.ModifiedDate = modifiedDate;
            this.ModifiedBy = modifiedBy;
            this.Pk = pk;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public List<SharedAsset> Page { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets ContinuationToken
        /// </summary>
        [DataMember(Name = "continuation_token", EmitDefaultValue = false)]
        public string ContinuationToken { get; set; }

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
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collection_id", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name = "valid_until", EmitDefaultValue = false)]
        public DateTime ValidUntil { get; set; }

        /// <summary>
        /// Gets or Sets ValidFor
        /// </summary>
        [DataMember(Name = "valid_for", EmitDefaultValue = false)]
        public string ValidFor { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name = "global", EmitDefaultValue = true)]
        public bool Global { get; set; }

        /// <summary>
        /// Gets or Sets AllowedFormats
        /// </summary>
        [DataMember(Name = "allowed_formats", EmitDefaultValue = false)]
        public List<SharedAllowedFormat> AllowedFormats { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

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
            sb.Append("class SharedCollectionFull {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ContinuationToken: ").Append(ContinuationToken).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  ValidFor: ").Append(ValidFor).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  AllowedFormats: ").Append(AllowedFormats).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as SharedCollectionFull);
        }

        /// <summary>
        /// Returns true if SharedCollectionFull instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedCollectionFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedCollectionFull input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Page == input.Page ||
                    this.Page != null &&
                    input.Page != null &&
                    this.Page.SequenceEqual(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ContinuationToken == input.ContinuationToken ||
                    (this.ContinuationToken != null &&
                    this.ContinuationToken.Equals(input.ContinuationToken))
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
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
                ) && 
                (
                    this.ValidFor == input.ValidFor ||
                    (this.ValidFor != null &&
                    this.ValidFor.Equals(input.ValidFor))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Global == input.Global ||
                    this.Global.Equals(input.Global)
                ) && 
                (
                    this.AllowedFormats == input.AllowedFormats ||
                    this.AllowedFormats != null &&
                    input.AllowedFormats != null &&
                    this.AllowedFormats.SequenceEqual(input.AllowedFormats)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Page != null)
                {
                    hashCode = (hashCode * 59) + this.Page.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.ContinuationToken != null)
                {
                    hashCode = (hashCode * 59) + this.ContinuationToken.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.ValidUntil != null)
                {
                    hashCode = (hashCode * 59) + this.ValidUntil.GetHashCode();
                }
                if (this.ValidFor != null)
                {
                    hashCode = (hashCode * 59) + this.ValidFor.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Global.GetHashCode();
                if (this.AllowedFormats != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedFormats.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
