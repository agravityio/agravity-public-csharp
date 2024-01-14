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
    /// DataResult
    /// </summary>
    [DataContract(Name = "dataResult")]
    public partial class DataResult : IEquatable<DataResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataResult" /> class.
        /// </summary>
        /// <param name="asset">asset.</param>
        /// <param name="sumAssetResults">sumAssetResults.</param>
        /// <param name="collection">collection.</param>
        /// <param name="sumCollectionResults">sumCollectionResults.</param>
        public DataResult(List<Asset> asset = default(List<Asset>), int sumAssetResults = default(int), List<Collection> collection = default(List<Collection>), int sumCollectionResults = default(int))
        {
            this.Asset = asset;
            this.SumAssetResults = sumAssetResults;
            this.Collection = collection;
            this.SumCollectionResults = sumCollectionResults;
        }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public List<Asset> Asset { get; set; }

        /// <summary>
        /// Gets or Sets SumAssetResults
        /// </summary>
        [DataMember(Name = "sum_asset_results", EmitDefaultValue = false)]
        public int SumAssetResults { get; set; }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name = "collection", EmitDefaultValue = false)]
        public List<Collection> Collection { get; set; }

        /// <summary>
        /// Gets or Sets SumCollectionResults
        /// </summary>
        [DataMember(Name = "sum_collection_results", EmitDefaultValue = false)]
        public int SumCollectionResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataResult {\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  SumAssetResults: ").Append(SumAssetResults).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  SumCollectionResults: ").Append(SumCollectionResults).Append("\n");
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
            return this.Equals(input as DataResult);
        }

        /// <summary>
        /// Returns true if DataResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DataResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Asset == input.Asset ||
                    this.Asset != null &&
                    input.Asset != null &&
                    this.Asset.SequenceEqual(input.Asset)
                ) && 
                (
                    this.SumAssetResults == input.SumAssetResults ||
                    this.SumAssetResults.Equals(input.SumAssetResults)
                ) && 
                (
                    this.Collection == input.Collection ||
                    this.Collection != null &&
                    input.Collection != null &&
                    this.Collection.SequenceEqual(input.Collection)
                ) && 
                (
                    this.SumCollectionResults == input.SumCollectionResults ||
                    this.SumCollectionResults.Equals(input.SumCollectionResults)
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
                if (this.Asset != null)
                {
                    hashCode = (hashCode * 59) + this.Asset.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SumAssetResults.GetHashCode();
                if (this.Collection != null)
                {
                    hashCode = (hashCode * 59) + this.Collection.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SumCollectionResults.GetHashCode();
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
