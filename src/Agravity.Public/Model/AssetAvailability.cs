/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.2.1
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
    /// AssetAvailability
    /// </summary>
    [DataContract(Name = "assetAvailability")]
    public partial class AssetAvailability : IEquatable<AssetAvailability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAvailability" /> class.
        /// </summary>
        /// <param name="availability">availability.</param>
        /// <param name="availableFrom">availableFrom.</param>
        /// <param name="availableTo">availableTo.</param>
        public AssetAvailability(string availability = default(string), DateTime? availableFrom = default(DateTime?), DateTime? availableTo = default(DateTime?))
        {
            this.Availability = availability;
            this.AvailableFrom = availableFrom;
            this.AvailableTo = availableTo;
        }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name = "availability", EmitDefaultValue = false)]
        public string Availability { get; set; }

        /// <summary>
        /// Gets or Sets AvailableFrom
        /// </summary>
        [DataMember(Name = "available_from", EmitDefaultValue = true)]
        public DateTime? AvailableFrom { get; set; }

        /// <summary>
        /// Gets or Sets AvailableTo
        /// </summary>
        [DataMember(Name = "available_to", EmitDefaultValue = true)]
        public DateTime? AvailableTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetAvailability {\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  AvailableTo: ").Append(AvailableTo).Append("\n");
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
            return this.Equals(input as AssetAvailability);
        }

        /// <summary>
        /// Returns true if AssetAvailability instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetAvailability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetAvailability input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.AvailableFrom == input.AvailableFrom ||
                    (this.AvailableFrom != null &&
                    this.AvailableFrom.Equals(input.AvailableFrom))
                ) && 
                (
                    this.AvailableTo == input.AvailableTo ||
                    (this.AvailableTo != null &&
                    this.AvailableTo.Equals(input.AvailableTo))
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
                if (this.Availability != null)
                {
                    hashCode = (hashCode * 59) + this.Availability.GetHashCode();
                }
                if (this.AvailableFrom != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableFrom.GetHashCode();
                }
                if (this.AvailableTo != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableTo.GetHashCode();
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
