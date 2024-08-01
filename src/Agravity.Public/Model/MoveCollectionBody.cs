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
    /// MoveCollectionBody
    /// </summary>
    [DataContract(Name = "moveCollectionBody")]
    public partial class MoveCollectionBody : IEquatable<MoveCollectionBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveCollectionBody" /> class.
        /// </summary>
        /// <param name="fromCollectionId">fromCollectionId.</param>
        /// <param name="toCollectionId">toCollectionId.</param>
        /// <param name="operation">operation.</param>
        public MoveCollectionBody(string fromCollectionId = default(string), string toCollectionId = default(string), string operation = default(string))
        {
            this.FromCollectionId = fromCollectionId;
            this.ToCollectionId = toCollectionId;
            this.Operation = operation;
        }

        /// <summary>
        /// Gets or Sets FromCollectionId
        /// </summary>
        [DataMember(Name = "from_collection_id", EmitDefaultValue = false)]
        public string FromCollectionId { get; set; }

        /// <summary>
        /// Gets or Sets ToCollectionId
        /// </summary>
        [DataMember(Name = "to_collection_id", EmitDefaultValue = false)]
        public string ToCollectionId { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MoveCollectionBody {\n");
            sb.Append("  FromCollectionId: ").Append(FromCollectionId).Append("\n");
            sb.Append("  ToCollectionId: ").Append(ToCollectionId).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
            return this.Equals(input as MoveCollectionBody);
        }

        /// <summary>
        /// Returns true if MoveCollectionBody instances are equal
        /// </summary>
        /// <param name="input">Instance of MoveCollectionBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoveCollectionBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FromCollectionId == input.FromCollectionId ||
                    (this.FromCollectionId != null &&
                    this.FromCollectionId.Equals(input.FromCollectionId))
                ) && 
                (
                    this.ToCollectionId == input.ToCollectionId ||
                    (this.ToCollectionId != null &&
                    this.ToCollectionId.Equals(input.ToCollectionId))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                if (this.FromCollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.FromCollectionId.GetHashCode();
                }
                if (this.ToCollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.ToCollectionId.GetHashCode();
                }
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
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
