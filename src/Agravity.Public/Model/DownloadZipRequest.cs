/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.0.2
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
    /// DownloadZipRequest
    /// </summary>
    [DataContract(Name = "downloadZipRequest")]
    public partial class DownloadZipRequest : IValidatableObject
    {
        /// <summary>
        /// Defines ZipType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ZipTypeEnum
        {
            /// <summary>
            /// Enum DOWNLOAD for value: DOWNLOAD
            /// </summary>
            [EnumMember(Value = "DOWNLOAD")]
            DOWNLOAD = 1,

            /// <summary>
            /// Enum SHARED for value: SHARED
            /// </summary>
            [EnumMember(Value = "SHARED")]
            SHARED = 2,

            /// <summary>
            /// Enum QUICKSHARE for value: QUICKSHARE
            /// </summary>
            [EnumMember(Value = "QUICKSHARE")]
            QUICKSHARE = 3,

            /// <summary>
            /// Enum PORTAL for value: PORTAL
            /// </summary>
            [EnumMember(Value = "PORTAL")]
            PORTAL = 4
        }


        /// <summary>
        /// Gets or Sets ZipType
        /// </summary>
        [DataMember(Name = "zip_type", EmitDefaultValue = false)]
        public ZipTypeEnum? ZipType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadZipRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="zipType">zipType (default to ZipTypeEnum.DOWNLOAD).</param>
        /// <param name="assetIds">assetIds.</param>
        /// <param name="allowedFormats">allowedFormats.</param>
        /// <param name="zipname">zipname.</param>
        /// <param name="emailTo">emailTo.</param>
        /// <param name="message">message.</param>
        /// <param name="validUntil">validUntil.</param>
        public DownloadZipRequest(string id = default(string), ZipTypeEnum? zipType = ZipTypeEnum.DOWNLOAD, List<string> assetIds = default(List<string>), List<SharedAllowedFormat> allowedFormats = default(List<SharedAllowedFormat>), string zipname = default(string), List<string> emailTo = default(List<string>), string message = default(string), DateTime? validUntil = default(DateTime?))
        {
            this.Id = id;
            this.ZipType = zipType;
            this.AssetIds = assetIds;
            this.AllowedFormats = allowedFormats;
            this.Zipname = zipname;
            this.EmailTo = emailTo;
            this.Message = message;
            this.ValidUntil = validUntil;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetIds
        /// </summary>
        [DataMember(Name = "asset_ids", EmitDefaultValue = true)]
        public List<string> AssetIds { get; set; }

        /// <summary>
        /// Gets or Sets AllowedFormats
        /// </summary>
        [DataMember(Name = "allowed_formats", EmitDefaultValue = true)]
        public List<SharedAllowedFormat> AllowedFormats { get; set; }

        /// <summary>
        /// Gets or Sets Zipname
        /// </summary>
        [DataMember(Name = "zipname", EmitDefaultValue = true)]
        public string Zipname { get; set; }

        /// <summary>
        /// Gets or Sets EmailTo
        /// </summary>
        [DataMember(Name = "email_to", EmitDefaultValue = true)]
        public List<string> EmailTo { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidUntil
        /// </summary>
        [DataMember(Name = "valid_until", EmitDefaultValue = true)]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DownloadZipRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ZipType: ").Append(ZipType).Append("\n");
            sb.Append("  AssetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  AllowedFormats: ").Append(AllowedFormats).Append("\n");
            sb.Append("  Zipname: ").Append(Zipname).Append("\n");
            sb.Append("  EmailTo: ").Append(EmailTo).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
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
