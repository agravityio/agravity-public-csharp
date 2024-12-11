/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.3.0
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
    /// SecureUploadEntity
    /// </summary>
    [DataContract(Name = "secureUploadEntity")]
    public partial class SecureUploadEntity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureUploadEntity" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="url">url.</param>
        /// <param name="validUntil">validUntil.</param>
        /// <param name="password">password.</param>
        /// <param name="assetTags">assetTags.</param>
        /// <param name="message">message.</param>
        /// <param name="sftpConnection">sftpConnection.</param>
        public SecureUploadEntity(string id = default(string), string collectionId = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), string url = default(string), DateTime? validUntil = default(DateTime?), string password = default(string), List<string> assetTags = default(List<string>), string message = default(string), CreateSftpUserResult sftpConnection = default(CreateSftpUserResult))
        {
            this.Id = id;
            this.CollectionId = collectionId;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.Url = url;
            this.ValidUntil = validUntil;
            this.Password = password;
            this.AssetTags = assetTags;
            this.Message = message;
            this.SftpConnection = sftpConnection;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collection_id", EmitDefaultValue = true)]
        public string CollectionId { get; set; }

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
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name = "valid_until", EmitDefaultValue = true)]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets AssetTags
        /// </summary>
        [DataMember(Name = "asset_tags", EmitDefaultValue = true)]
        public List<string> AssetTags { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SftpConnection
        /// </summary>
        [DataMember(Name = "sftp_connection", EmitDefaultValue = true)]
        public CreateSftpUserResult SftpConnection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecureUploadEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AssetTags: ").Append(AssetTags).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SftpConnection: ").Append(SftpConnection).Append("\n");
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
