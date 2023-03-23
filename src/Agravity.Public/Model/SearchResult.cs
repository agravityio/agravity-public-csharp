/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.1.1
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
    /// SearchResult
    /// </summary>
    [DataContract(Name = "searchResult")]
    public partial class SearchResult : IEquatable<SearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="dataResult">dataResult.</param>
        /// <param name="options">options.</param>
        /// <param name="facets">facets.</param>
        /// <param name="count">count.</param>
        public SearchResult(DataResult dataResult = default(DataResult), AzSearchOptions options = default(AzSearchOptions), List<SearchFacet> facets = default(List<SearchFacet>), long? count = default(long?))
        {
            this.DataResult = dataResult;
            this.Options = options;
            this.Facets = facets;
            this.Count = count;
        }

        /// <summary>
        /// Gets or Sets DataResult
        /// </summary>
        [DataMember(Name = "data_result", EmitDefaultValue = false)]
        public DataResult DataResult { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public AzSearchOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets Facets
        /// </summary>
        [DataMember(Name = "facets", EmitDefaultValue = false)]
        public List<SearchFacet> Facets { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchResult {\n");
            sb.Append("  DataResult: ").Append(DataResult).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as SearchResult);
        }

        /// <summary>
        /// Returns true if SearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataResult == input.DataResult ||
                    (this.DataResult != null &&
                    this.DataResult.Equals(input.DataResult))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Facets == input.Facets ||
                    this.Facets != null &&
                    input.Facets != null &&
                    this.Facets.SequenceEqual(input.Facets)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.DataResult != null)
                {
                    hashCode = (hashCode * 59) + this.DataResult.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.Facets != null)
                {
                    hashCode = (hashCode * 59) + this.Facets.GetHashCode();
                }
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
