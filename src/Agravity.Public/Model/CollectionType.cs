/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.0.1
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
    /// CollectionType
    /// </summary>
    [DataContract(Name = "collectionType")]
    public partial class CollectionType : IValidatableObject
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
        /// Initializes a new instance of the <see cref="CollectionType" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="name">name.</param>
        /// <param name="items">items.</param>
        /// <param name="translations">translations.</param>
        /// <param name="order">order.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="permissionless">permissionless.</param>
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
        public CollectionType(string id = default(string), string entityType = default(string), string name = default(string), List<CollTypeItem> items = default(List<CollTypeItem>), Dictionary<string, Dictionary<string, object>> translations = default(Dictionary<string, Dictionary<string, object>>), int? order = default(int?), List<PermissionEntity> permissions = default(List<PermissionEntity>), bool? permissionless = default(bool?), RoleEnum? role = RoleEnum.NONE, string description = default(string), Dictionary<string, object> addProperties = default(Dictionary<string, object>), string status = default(string), DateTime? createdDate = default(DateTime?), string createdBy = default(string), DateTime? modifiedDate = default(DateTime?), string modifiedBy = default(string), string pk = default(string), string etag = default(string))
        {
            this.Id = id;
            this.EntityType = entityType;
            this.Name = name;
            this.Items = items;
            this.Translations = translations;
            this.Order = order;
            this.Permissions = permissions;
            this.Permissionless = permissionless;
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
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<CollTypeItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name = "translations", EmitDefaultValue = true)]
        public Dictionary<string, Dictionary<string, object>> Translations { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<PermissionEntity> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets Permissionless
        /// </summary>
        [DataMember(Name = "permissionless", EmitDefaultValue = true)]
        public bool? Permissionless { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AddProperties
        /// </summary>
        [DataMember(Name = "add_properties", EmitDefaultValue = true)]
        public Dictionary<string, object> AddProperties { get; set; }

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
            sb.Append("class CollectionType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Permissionless: ").Append(Permissionless).Append("\n");
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
