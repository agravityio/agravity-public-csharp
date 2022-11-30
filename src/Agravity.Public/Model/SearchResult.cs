/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.9.0
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
        /// <param name="reasonResult">reasonResult.</param>
        /// <param name="dataResult">dataResult.</param>
        /// <param name="maxSumResults">maxSumResults.</param>
        /// <param name="options">options.</param>
        /// <param name="facets">facets.</param>
        /// <param name="count">count.</param>
        /// <param name="searchQuery">searchQuery.</param>
        /// <param name="searchFilter">searchFilter.</param>
        /// <param name="searchOrderBy">searchOrderBy.</param>
        /// <param name="searchMode">searchMode.</param>
        /// <param name="origin">origin.</param>
        public SearchResult(List<ReasonResult> reasonResult = default(List<ReasonResult>), DataResult dataResult = default(DataResult), int maxSumResults = default(int), AzSearchOptions options = default(AzSearchOptions), List<SearchFacet> facets = default(List<SearchFacet>), long? count = default(long?), string searchQuery = default(string), string searchFilter = default(string), string searchOrderBy = default(string), string searchMode = default(string), string origin = default(string))
        {
            this.ReasonResult = reasonResult;
            this.DataResult = dataResult;
            this.MaxSumResults = maxSumResults;
            this.Options = options;
            this.Facets = facets;
            this.Count = count;
            this.SearchQuery = searchQuery;
            this.SearchFilter = searchFilter;
            this.SearchOrderBy = searchOrderBy;
            this.SearchMode = searchMode;
            this.Origin = origin;
        }

        /// <summary>
        /// Gets or Sets ReasonResult
        /// </summary>
        [DataMember(Name = "reason_result", EmitDefaultValue = false)]
        public List<ReasonResult> ReasonResult { get; set; }

        /// <summary>
        /// Gets or Sets DataResult
        /// </summary>
        [DataMember(Name = "data_result", EmitDefaultValue = false)]
        public DataResult DataResult { get; set; }

        /// <summary>
        /// Gets or Sets MaxSumResults
        /// </summary>
        [DataMember(Name = "max_sum_results", EmitDefaultValue = false)]
        public int MaxSumResults { get; set; }

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
        /// Gets or Sets SearchQuery
        /// </summary>
        [DataMember(Name = "search_query", EmitDefaultValue = false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Gets or Sets SearchFilter
        /// </summary>
        [DataMember(Name = "search_filter", EmitDefaultValue = false)]
        public string SearchFilter { get; set; }

        /// <summary>
        /// Gets or Sets SearchOrderBy
        /// </summary>
        [DataMember(Name = "search_order_by", EmitDefaultValue = false)]
        public string SearchOrderBy { get; set; }

        /// <summary>
        /// Gets or Sets SearchMode
        /// </summary>
        [DataMember(Name = "search_mode", EmitDefaultValue = false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchResult {\n");
            sb.Append("  ReasonResult: ").Append(ReasonResult).Append("\n");
            sb.Append("  DataResult: ").Append(DataResult).Append("\n");
            sb.Append("  MaxSumResults: ").Append(MaxSumResults).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  SearchFilter: ").Append(SearchFilter).Append("\n");
            sb.Append("  SearchOrderBy: ").Append(SearchOrderBy).Append("\n");
            sb.Append("  SearchMode: ").Append(SearchMode).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
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
                    this.ReasonResult == input.ReasonResult ||
                    this.ReasonResult != null &&
                    input.ReasonResult != null &&
                    this.ReasonResult.SequenceEqual(input.ReasonResult)
                ) && 
                (
                    this.DataResult == input.DataResult ||
                    (this.DataResult != null &&
                    this.DataResult.Equals(input.DataResult))
                ) && 
                (
                    this.MaxSumResults == input.MaxSumResults ||
                    this.MaxSumResults.Equals(input.MaxSumResults)
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
                ) && 
                (
                    this.SearchQuery == input.SearchQuery ||
                    (this.SearchQuery != null &&
                    this.SearchQuery.Equals(input.SearchQuery))
                ) && 
                (
                    this.SearchFilter == input.SearchFilter ||
                    (this.SearchFilter != null &&
                    this.SearchFilter.Equals(input.SearchFilter))
                ) && 
                (
                    this.SearchOrderBy == input.SearchOrderBy ||
                    (this.SearchOrderBy != null &&
                    this.SearchOrderBy.Equals(input.SearchOrderBy))
                ) && 
                (
                    this.SearchMode == input.SearchMode ||
                    (this.SearchMode != null &&
                    this.SearchMode.Equals(input.SearchMode))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
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
                if (this.ReasonResult != null)
                {
                    hashCode = (hashCode * 59) + this.ReasonResult.GetHashCode();
                }
                if (this.DataResult != null)
                {
                    hashCode = (hashCode * 59) + this.DataResult.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxSumResults.GetHashCode();
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
                if (this.SearchQuery != null)
                {
                    hashCode = (hashCode * 59) + this.SearchQuery.GetHashCode();
                }
                if (this.SearchFilter != null)
                {
                    hashCode = (hashCode * 59) + this.SearchFilter.GetHashCode();
                }
                if (this.SearchOrderBy != null)
                {
                    hashCode = (hashCode * 59) + this.SearchOrderBy.GetHashCode();
                }
                if (this.SearchMode != null)
                {
                    hashCode = (hashCode * 59) + this.SearchMode.GetHashCode();
                }
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
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
