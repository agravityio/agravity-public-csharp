/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.0.0-preview.1
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
    /// PublishedAsset
    /// </summary>
    [DataContract(Name = "publishedAsset")]
    public partial class PublishedAsset : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedAsset" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="target">target.</param>
        /// <param name="description">description.</param>
        /// <param name="usecases">usecases.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="url">url.</param>
        /// <param name="cdn">cdn.</param>
        /// <param name="statusTableId">statusTableId.</param>
        /// <param name="format">format.</param>
        /// <param name="properties">properties.</param>
        public PublishedAsset(string id = default(string), string name = default(string), string target = default(string), string description = default(string), List<string> usecases = default(List<string>), DateTime? createdDate = default(DateTime?), string createdBy = default(string), string url = default(string), string cdn = default(string), string statusTableId = default(string), string format = default(string), Dictionary<string, object> properties = default(Dictionary<string, object>))
        {
            this.Id = id;
            this.Name = name;
            this.Target = target;
            this.Description = description;
            this.Usecases = usecases;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.Url = url;
            this.Cdn = cdn;
            this.StatusTableId = statusTableId;
            this.Format = format;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Usecases
        /// </summary>
        [DataMember(Name = "usecases", EmitDefaultValue = true)]
        public List<string> Usecases { get; set; }

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
        /// Gets or Sets Cdn
        /// </summary>
        [DataMember(Name = "cdn", EmitDefaultValue = true)]
        public string Cdn { get; set; }

        /// <summary>
        /// Gets or Sets StatusTableId
        /// </summary>
        [DataMember(Name = "status_table_id", EmitDefaultValue = true)]
        public string StatusTableId { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishedAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Usecases: ").Append(Usecases).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Cdn: ").Append(Cdn).Append("\n");
            sb.Append("  StatusTableId: ").Append(StatusTableId).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
