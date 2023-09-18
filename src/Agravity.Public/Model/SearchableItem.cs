/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.3.6
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
    /// SearchableItem
    /// </summary>
    [DataContract(Name = "searchableItem")]
    public partial class SearchableItem : IEquatable<SearchableItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchableItem" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="isKey">isKey.</param>
        /// <param name="filterable">filterable.</param>
        /// <param name="hidden">hidden.</param>
        /// <param name="searchable">searchable.</param>
        /// <param name="facetable">facetable.</param>
        /// <param name="sortable">sortable.</param>
        /// <param name="isCollection">isCollection.</param>
        /// <param name="searchtype">searchtype.</param>
        /// <param name="fields">fields.</param>
        public SearchableItem(string name = default(string), bool? isKey = default(bool?), bool? filterable = default(bool?), bool? hidden = default(bool?), bool? searchable = default(bool?), bool? facetable = default(bool?), bool? sortable = default(bool?), bool? isCollection = default(bool?), string searchtype = default(string), List<SearchableItem> fields = default(List<SearchableItem>))
        {
            this.Name = name;
            this.IsKey = isKey;
            this.Filterable = filterable;
            this.Hidden = hidden;
            this.Searchable = searchable;
            this.Facetable = facetable;
            this.Sortable = sortable;
            this.IsCollection = isCollection;
            this.Searchtype = searchtype;
            this.Fields = fields;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsKey
        /// </summary>
        [DataMember(Name = "is_key", EmitDefaultValue = true)]
        public bool? IsKey { get; set; }

        /// <summary>
        /// Gets or Sets Filterable
        /// </summary>
        [DataMember(Name = "filterable", EmitDefaultValue = true)]
        public bool? Filterable { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name = "hidden", EmitDefaultValue = true)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Searchable
        /// </summary>
        [DataMember(Name = "searchable", EmitDefaultValue = true)]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Gets or Sets Facetable
        /// </summary>
        [DataMember(Name = "facetable", EmitDefaultValue = true)]
        public bool? Facetable { get; set; }

        /// <summary>
        /// Gets or Sets Sortable
        /// </summary>
        [DataMember(Name = "sortable", EmitDefaultValue = true)]
        public bool? Sortable { get; set; }

        /// <summary>
        /// Gets or Sets IsCollection
        /// </summary>
        [DataMember(Name = "is_collection", EmitDefaultValue = true)]
        public bool? IsCollection { get; set; }

        /// <summary>
        /// Gets or Sets Searchtype
        /// </summary>
        [DataMember(Name = "searchtype", EmitDefaultValue = false)]
        public string Searchtype { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<SearchableItem> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchableItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsKey: ").Append(IsKey).Append("\n");
            sb.Append("  Filterable: ").Append(Filterable).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Searchable: ").Append(Searchable).Append("\n");
            sb.Append("  Facetable: ").Append(Facetable).Append("\n");
            sb.Append("  Sortable: ").Append(Sortable).Append("\n");
            sb.Append("  IsCollection: ").Append(IsCollection).Append("\n");
            sb.Append("  Searchtype: ").Append(Searchtype).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as SearchableItem);
        }

        /// <summary>
        /// Returns true if SearchableItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchableItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchableItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsKey == input.IsKey ||
                    (this.IsKey != null &&
                    this.IsKey.Equals(input.IsKey))
                ) && 
                (
                    this.Filterable == input.Filterable ||
                    (this.Filterable != null &&
                    this.Filterable.Equals(input.Filterable))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Searchable == input.Searchable ||
                    (this.Searchable != null &&
                    this.Searchable.Equals(input.Searchable))
                ) && 
                (
                    this.Facetable == input.Facetable ||
                    (this.Facetable != null &&
                    this.Facetable.Equals(input.Facetable))
                ) && 
                (
                    this.Sortable == input.Sortable ||
                    (this.Sortable != null &&
                    this.Sortable.Equals(input.Sortable))
                ) && 
                (
                    this.IsCollection == input.IsCollection ||
                    (this.IsCollection != null &&
                    this.IsCollection.Equals(input.IsCollection))
                ) && 
                (
                    this.Searchtype == input.Searchtype ||
                    (this.Searchtype != null &&
                    this.Searchtype.Equals(input.Searchtype))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.IsKey != null)
                {
                    hashCode = (hashCode * 59) + this.IsKey.GetHashCode();
                }
                if (this.Filterable != null)
                {
                    hashCode = (hashCode * 59) + this.Filterable.GetHashCode();
                }
                if (this.Hidden != null)
                {
                    hashCode = (hashCode * 59) + this.Hidden.GetHashCode();
                }
                if (this.Searchable != null)
                {
                    hashCode = (hashCode * 59) + this.Searchable.GetHashCode();
                }
                if (this.Facetable != null)
                {
                    hashCode = (hashCode * 59) + this.Facetable.GetHashCode();
                }
                if (this.Sortable != null)
                {
                    hashCode = (hashCode * 59) + this.Sortable.GetHashCode();
                }
                if (this.IsCollection != null)
                {
                    hashCode = (hashCode * 59) + this.IsCollection.GetHashCode();
                }
                if (this.Searchtype != null)
                {
                    hashCode = (hashCode * 59) + this.Searchtype.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
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
