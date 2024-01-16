/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.1.4
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
    /// AzSearchOptions
    /// </summary>
    [DataContract(Name = "azSearchOptions")]
    public partial class AzSearchOptions : IEquatable<AzSearchOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzSearchOptions" /> class.
        /// </summary>
        /// <param name="searchString">searchString.</param>
        /// <param name="limit">limit.</param>
        /// <param name="skip">skip.</param>
        /// <param name="collectiontypeid">collectiontypeid.</param>
        /// <param name="collectionid">collectionid.</param>
        /// <param name="filter">filter.</param>
        /// <param name="orderby">orderby.</param>
        /// <param name="mode">mode.</param>
        /// <param name="ids">ids.</param>
        public AzSearchOptions(string searchString = default(string), int? limit = default(int?), int skip = default(int), string collectiontypeid = default(string), string collectionid = default(string), string filter = default(string), string orderby = default(string), string mode = default(string), string ids = default(string))
        {
            this.SearchString = searchString;
            this.Limit = limit;
            this.Skip = skip;
            this.Collectiontypeid = collectiontypeid;
            this.Collectionid = collectionid;
            this.Filter = filter;
            this.Orderby = orderby;
            this.Mode = mode;
            this.Ids = ids;
        }

        /// <summary>
        /// Gets or Sets SearchString
        /// </summary>
        [DataMember(Name = "searchString", EmitDefaultValue = false)]
        public string SearchString { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Skip
        /// </summary>
        [DataMember(Name = "skip", EmitDefaultValue = false)]
        public int Skip { get; set; }

        /// <summary>
        /// Gets or Sets Collectiontypeid
        /// </summary>
        [DataMember(Name = "collectiontypeid", EmitDefaultValue = false)]
        public string Collectiontypeid { get; set; }

        /// <summary>
        /// Gets or Sets Collectionid
        /// </summary>
        [DataMember(Name = "collectionid", EmitDefaultValue = false)]
        public string Collectionid { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets Orderby
        /// </summary>
        [DataMember(Name = "orderby", EmitDefaultValue = false)]
        public string Orderby { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", EmitDefaultValue = false)]
        public string Ids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzSearchOptions {\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Collectiontypeid: ").Append(Collectiontypeid).Append("\n");
            sb.Append("  Collectionid: ").Append(Collectionid).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Orderby: ").Append(Orderby).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(input as AzSearchOptions);
        }

        /// <summary>
        /// Returns true if AzSearchOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of AzSearchOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzSearchOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SearchString == input.SearchString ||
                    (this.SearchString != null &&
                    this.SearchString.Equals(input.SearchString))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Skip == input.Skip ||
                    this.Skip.Equals(input.Skip)
                ) && 
                (
                    this.Collectiontypeid == input.Collectiontypeid ||
                    (this.Collectiontypeid != null &&
                    this.Collectiontypeid.Equals(input.Collectiontypeid))
                ) && 
                (
                    this.Collectionid == input.Collectionid ||
                    (this.Collectionid != null &&
                    this.Collectionid.Equals(input.Collectionid))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Orderby == input.Orderby ||
                    (this.Orderby != null &&
                    this.Orderby.Equals(input.Orderby))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Ids == input.Ids ||
                    (this.Ids != null &&
                    this.Ids.Equals(input.Ids))
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
                if (this.SearchString != null)
                {
                    hashCode = (hashCode * 59) + this.SearchString.GetHashCode();
                }
                if (this.Limit != null)
                {
                    hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Skip.GetHashCode();
                if (this.Collectiontypeid != null)
                {
                    hashCode = (hashCode * 59) + this.Collectiontypeid.GetHashCode();
                }
                if (this.Collectionid != null)
                {
                    hashCode = (hashCode * 59) + this.Collectionid.GetHashCode();
                }
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Orderby != null)
                {
                    hashCode = (hashCode * 59) + this.Orderby.GetHashCode();
                }
                if (this.Mode != null)
                {
                    hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                }
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
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
