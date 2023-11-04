/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.0.3
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
    /// VersionedAsset
    /// </summary>
    [DataContract(Name = "versionedAsset")]
    public partial class VersionedAsset : IEquatable<VersionedAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionedAsset" /> class.
        /// </summary>
        /// <param name="versionNr">versionNr.</param>
        /// <param name="untilDate">untilDate.</param>
        /// <param name="versionInfo">versionInfo.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="mimeType">mimeType.</param>
        public VersionedAsset(int versionNr = default(int), DateTime untilDate = default(DateTime), string versionInfo = default(string), string createdBy = default(string), string mimeType = default(string))
        {
            this.VersionNr = versionNr;
            this.UntilDate = untilDate;
            this.VersionInfo = versionInfo;
            this.CreatedBy = createdBy;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Gets or Sets VersionNr
        /// </summary>
        [DataMember(Name = "version_nr", EmitDefaultValue = false)]
        public int VersionNr { get; set; }

        /// <summary>
        /// Gets or Sets UntilDate
        /// </summary>
        [DataMember(Name = "until_date", EmitDefaultValue = false)]
        public DateTime UntilDate { get; set; }

        /// <summary>
        /// Gets or Sets VersionInfo
        /// </summary>
        [DataMember(Name = "version_info", EmitDefaultValue = false)]
        public string VersionInfo { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mime_type", EmitDefaultValue = false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VersionedAsset {\n");
            sb.Append("  VersionNr: ").Append(VersionNr).Append("\n");
            sb.Append("  UntilDate: ").Append(UntilDate).Append("\n");
            sb.Append("  VersionInfo: ").Append(VersionInfo).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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
            return this.Equals(input as VersionedAsset);
        }

        /// <summary>
        /// Returns true if VersionedAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionedAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionedAsset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VersionNr == input.VersionNr ||
                    this.VersionNr.Equals(input.VersionNr)
                ) && 
                (
                    this.UntilDate == input.UntilDate ||
                    (this.UntilDate != null &&
                    this.UntilDate.Equals(input.UntilDate))
                ) && 
                (
                    this.VersionInfo == input.VersionInfo ||
                    (this.VersionInfo != null &&
                    this.VersionInfo.Equals(input.VersionInfo))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
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
                hashCode = (hashCode * 59) + this.VersionNr.GetHashCode();
                if (this.UntilDate != null)
                {
                    hashCode = (hashCode * 59) + this.UntilDate.GetHashCode();
                }
                if (this.VersionInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VersionInfo.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.MimeType != null)
                {
                    hashCode = (hashCode * 59) + this.MimeType.GetHashCode();
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
