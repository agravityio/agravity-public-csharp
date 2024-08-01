/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.3.0
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
    /// GroupAllAppData
    /// </summary>
    [DataContract(Name = "groupAllAppData")]
    public partial class GroupAllAppData : IEquatable<GroupAllAppData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAllAppData" /> class.
        /// </summary>
        /// <param name="collectionType">collectionType.</param>
        /// <param name="collections">collections.</param>
        /// <param name="assets">assets.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="addInfo">addInfo.</param>
        /// <param name="dist">dist.</param>
        public GroupAllAppData(CollectionType collectionType = default(CollectionType), List<Collection> collections = default(List<Collection>), List<Asset> assets = default(List<Asset>), DateTime createdDate = default(DateTime), List<Dictionary<string, object>> addInfo = default(List<Dictionary<string, object>>), DistZipResponse dist = default(DistZipResponse))
        {
            this.CollectionType = collectionType;
            this.Collections = collections;
            this.Assets = assets;
            this.CreatedDate = createdDate;
            this.AddInfo = addInfo;
            this.Dist = dist;
        }

        /// <summary>
        /// Gets or Sets CollectionType
        /// </summary>
        [DataMember(Name = "collection_type", EmitDefaultValue = false)]
        public CollectionType CollectionType { get; set; }

        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name = "collections", EmitDefaultValue = false)]
        public List<Collection> Collections { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public List<Asset> Assets { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets AddInfo
        /// </summary>
        [DataMember(Name = "add_info", EmitDefaultValue = false)]
        public List<Dictionary<string, object>> AddInfo { get; set; }

        /// <summary>
        /// Gets or Sets Dist
        /// </summary>
        [DataMember(Name = "dist", EmitDefaultValue = false)]
        public DistZipResponse Dist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAllAppData {\n");
            sb.Append("  CollectionType: ").Append(CollectionType).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  AddInfo: ").Append(AddInfo).Append("\n");
            sb.Append("  Dist: ").Append(Dist).Append("\n");
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
            return this.Equals(input as GroupAllAppData);
        }

        /// <summary>
        /// Returns true if GroupAllAppData instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAllAppData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAllAppData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CollectionType == input.CollectionType ||
                    (this.CollectionType != null &&
                    this.CollectionType.Equals(input.CollectionType))
                ) && 
                (
                    this.Collections == input.Collections ||
                    this.Collections != null &&
                    input.Collections != null &&
                    this.Collections.SequenceEqual(input.Collections)
                ) && 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.AddInfo == input.AddInfo ||
                    this.AddInfo != null &&
                    input.AddInfo != null &&
                    this.AddInfo.SequenceEqual(input.AddInfo)
                ) && 
                (
                    this.Dist == input.Dist ||
                    (this.Dist != null &&
                    this.Dist.Equals(input.Dist))
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
                if (this.CollectionType != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionType.GetHashCode();
                }
                if (this.Collections != null)
                {
                    hashCode = (hashCode * 59) + this.Collections.GetHashCode();
                }
                if (this.Assets != null)
                {
                    hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.AddInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AddInfo.GetHashCode();
                }
                if (this.Dist != null)
                {
                    hashCode = (hashCode * 59) + this.Dist.GetHashCode();
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
