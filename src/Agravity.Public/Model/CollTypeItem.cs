/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.4.2
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
    /// CollTypeItem
    /// </summary>
    [DataContract(Name = "collTypeItem")]
    public partial class CollTypeItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollTypeItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="name">name.</param>
        /// <param name="itemType">itemType.</param>
        /// <param name="format">format.</param>
        /// <param name="label">label.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="mandatory">mandatory.</param>
        /// <param name="searchable">searchable.</param>
        /// <param name="onlyasset">onlyasset.</param>
        /// <param name="multi">multi.</param>
        /// <param name="md5">md5.</param>
        /// <param name="group">group.</param>
        /// <param name="order">order.</param>
        /// <param name="translations">translations.</param>
        /// <param name="status">status.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        /// <param name="pk">pk.</param>
        /// <param name="etag">etag.</param>
        public CollTypeItem(string id = default(string), string entityType = default(string), string name = default(string), string itemType = default(string), string format = default(string), string label = default(string), Object defaultValue = default(Object), bool? mandatory = default(bool?), bool? searchable = default(bool?), bool? onlyasset = default(bool?), bool? multi = default(bool?), string md5 = default(string), string group = default(string), int? order = default(int?), Dictionary<string, Dictionary<string, object>> translations = default(Dictionary<string, Dictionary<string, object>>), string status = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), DateTime? modifiedDate = default(DateTime?), string modifiedBy = default(string), string pk = default(string), string etag = default(string))
        {
            this.Id = id;
            this.EntityType = entityType;
            this.Name = name;
            this.ItemType = itemType;
            this.Format = format;
            this.Label = label;
            this.DefaultValue = defaultValue;
            this.Mandatory = mandatory;
            this.Searchable = searchable;
            this.Onlyasset = onlyasset;
            this.Multi = multi;
            this.Md5 = md5;
            this.Group = group;
            this.Order = order;
            this.Translations = translations;
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
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entity_type", EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name = "item_type", EmitDefaultValue = true)]
        public string ItemType { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "default_value", EmitDefaultValue = true)]
        public Object DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets Mandatory
        /// </summary>
        [DataMember(Name = "mandatory", EmitDefaultValue = true)]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// Gets or Sets Searchable
        /// </summary>
        [DataMember(Name = "searchable", EmitDefaultValue = true)]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Gets or Sets Onlyasset
        /// </summary>
        [DataMember(Name = "onlyasset", EmitDefaultValue = true)]
        public bool? Onlyasset { get; set; }

        /// <summary>
        /// Gets or Sets Multi
        /// </summary>
        [DataMember(Name = "multi", EmitDefaultValue = true)]
        public bool? Multi { get; set; }

        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name = "md5", EmitDefaultValue = true)]
        public string Md5 { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name = "translations", EmitDefaultValue = true)]
        public Dictionary<string, Dictionary<string, object>> Translations { get; set; }

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
            sb.Append("class CollTypeItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Mandatory: ").Append(Mandatory).Append("\n");
            sb.Append("  Searchable: ").Append(Searchable).Append("\n");
            sb.Append("  Onlyasset: ").Append(Onlyasset).Append("\n");
            sb.Append("  Multi: ").Append(Multi).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
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
