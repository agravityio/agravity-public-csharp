/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.2.1
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
    /// ArtificialIntelligenceGroup
    /// </summary>
    [DataContract(Name = "artificialIntelligenceGroup")]
    public partial class ArtificialIntelligenceGroup : IEquatable<ArtificialIntelligenceGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtificialIntelligenceGroup" /> class.
        /// </summary>
        /// <param name="origin">origin.</param>
        /// <param name="url">url.</param>
        /// <param name="minConfidence">minConfidence.</param>
        /// <param name="values">values.</param>
        public ArtificialIntelligenceGroup(string origin = default(string), string url = default(string), double? minConfidence = default(double?), List<Dictionary<string, object>> values = default(List<Dictionary<string, object>>))
        {
            this.Origin = origin;
            this.Url = url;
            this.MinConfidence = minConfidence;
            this.Values = values;
        }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets MinConfidence
        /// </summary>
        [DataMember(Name = "min_confidence", EmitDefaultValue = true)]
        public double? MinConfidence { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<Dictionary<string, object>> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArtificialIntelligenceGroup {\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MinConfidence: ").Append(MinConfidence).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as ArtificialIntelligenceGroup);
        }

        /// <summary>
        /// Returns true if ArtificialIntelligenceGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ArtificialIntelligenceGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArtificialIntelligenceGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.MinConfidence == input.MinConfidence ||
                    (this.MinConfidence != null &&
                    this.MinConfidence.Equals(input.MinConfidence))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.MinConfidence != null)
                {
                    hashCode = (hashCode * 59) + this.MinConfidence.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
