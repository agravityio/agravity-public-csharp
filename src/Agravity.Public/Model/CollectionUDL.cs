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
    /// CollectionUDL
    /// </summary>
    [DataContract(Name = "collectionUDL")]
    public partial class CollectionUDL : IEquatable<CollectionUDL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionUDL" /> class.
        /// </summary>
        /// <param name="children">children.</param>
        /// <param name="name">name.</param>
        /// <param name="translations">translations.</param>
        /// <param name="id">id.</param>
        public CollectionUDL(List<EntityIdName> children = default(List<EntityIdName>), string name = default(string), Dictionary<string, Dictionary<string, object>> translations = default(Dictionary<string, Dictionary<string, object>>), string id = default(string))
        {
            this.Children = children;
            this.Name = name;
            this.Translations = translations;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<EntityIdName> Children { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Translations
        /// </summary>
        [DataMember(Name = "translations", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, object>> Translations { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionUDL {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CollectionUDL);
        }

        /// <summary>
        /// Returns true if CollectionUDL instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionUDL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionUDL input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Translations == input.Translations ||
                    this.Translations != null &&
                    input.Translations != null &&
                    this.Translations.SequenceEqual(input.Translations)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Translations != null)
                {
                    hashCode = (hashCode * 59) + this.Translations.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
