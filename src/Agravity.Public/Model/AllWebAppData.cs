/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.0.2
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
    /// AllWebAppData
    /// </summary>
    [DataContract(Name = "allWebAppData")]
    public partial class AllWebAppData : IEquatable<AllWebAppData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllWebAppData" /> class.
        /// </summary>
        /// <param name="rootCollection">rootCollection.</param>
        /// <param name="subcollections">subcollections.</param>
        /// <param name="assets">assets.</param>
        /// <param name="pubAssets">pubAssets.</param>
        /// <param name="createdDate">createdDate.</param>
        public AllWebAppData(Collection rootCollection = default(Collection), List<Collection> subcollections = default(List<Collection>), List<Asset> assets = default(List<Asset>), List<PublishedAsset> pubAssets = default(List<PublishedAsset>), DateTime createdDate = default(DateTime))
        {
            this.RootCollection = rootCollection;
            this.Subcollections = subcollections;
            this.Assets = assets;
            this.PubAssets = pubAssets;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Gets or Sets RootCollection
        /// </summary>
        [DataMember(Name = "root_collection", EmitDefaultValue = false)]
        public Collection RootCollection { get; set; }

        /// <summary>
        /// Gets or Sets Subcollections
        /// </summary>
        [DataMember(Name = "subcollections", EmitDefaultValue = false)]
        public List<Collection> Subcollections { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public List<Asset> Assets { get; set; }

        /// <summary>
        /// Gets or Sets PubAssets
        /// </summary>
        [DataMember(Name = "pub_assets", EmitDefaultValue = false)]
        public List<PublishedAsset> PubAssets { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AllWebAppData {\n");
            sb.Append("  RootCollection: ").Append(RootCollection).Append("\n");
            sb.Append("  Subcollections: ").Append(Subcollections).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  PubAssets: ").Append(PubAssets).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(input as AllWebAppData);
        }

        /// <summary>
        /// Returns true if AllWebAppData instances are equal
        /// </summary>
        /// <param name="input">Instance of AllWebAppData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllWebAppData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RootCollection == input.RootCollection ||
                    (this.RootCollection != null &&
                    this.RootCollection.Equals(input.RootCollection))
                ) && 
                (
                    this.Subcollections == input.Subcollections ||
                    this.Subcollections != null &&
                    input.Subcollections != null &&
                    this.Subcollections.SequenceEqual(input.Subcollections)
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
                ) && 
                (
                    this.PubAssets == input.PubAssets ||
                    this.PubAssets != null &&
                    input.PubAssets != null &&
                    this.PubAssets.SequenceEqual(input.PubAssets)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                if (this.RootCollection != null)
                {
                    hashCode = (hashCode * 59) + this.RootCollection.GetHashCode();
                }
                if (this.Subcollections != null)
                {
                    hashCode = (hashCode * 59) + this.Subcollections.GetHashCode();
                }
                if (this.Assets != null)
                {
                    hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                }
                if (this.PubAssets != null)
                {
                    hashCode = (hashCode * 59) + this.PubAssets.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
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
