/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.1.5
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
        /// <param name="collectionId">collectionId.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="url">url.</param>
        /// <param name="validUntil">validUntil.</param>
        /// <param name="validFor">validFor.</param>
        /// <param name="message">message.</param>
        /// <param name="global">global.</param>
        public SharedCollectionFull(List<SharedAsset> page = default(List<SharedAsset>), int pageSize = default(int), int? size = default(int?), string continuationToken = default(string), string id = default(string), string collectionId = default(string), DateTime createdDate = default(DateTime), string url = default(string), DateTime validUntil = default(DateTime), string validFor = default(string), string message = default(string), bool global = default(bool))
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.Size = size;
            this.ContinuationToken = continuationToken;
            this.Id = id;
            this.CollectionId = collectionId;
            this.CreatedDate = createdDate;
            this.Url = url;
            this.ValidUntil = validUntil;
            this.ValidFor = validFor;
            this.Message = message;
            this.Global = global;
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
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collection_id", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

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
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  ValidFor: ").Append(ValidFor).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
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
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
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
