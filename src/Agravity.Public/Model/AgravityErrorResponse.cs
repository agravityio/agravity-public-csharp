/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.0.0
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
    /// AgravityErrorResponse
    /// </summary>
    [DataContract(Name = "agravityErrorResponse")]
    public partial class AgravityErrorResponse : IEquatable<AgravityErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgravityErrorResponse" /> class.
        /// </summary>
        /// <param name="errorId">errorId.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="exception">exception.</param>
        public AgravityErrorResponse(string errorId = default(string), string errorMessage = default(string), string exception = default(string))
        {
            this.ErrorId = errorId;
            this.ErrorMessage = errorMessage;
            this.Exception = exception;
        }

        /// <summary>
        /// Gets or Sets ErrorId
        /// </summary>
        [DataMember(Name = "error_id", EmitDefaultValue = false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "error_message", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [DataMember(Name = "exception", EmitDefaultValue = false)]
        public string Exception { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgravityErrorResponse {\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
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
            return this.Equals(input as AgravityErrorResponse);
        }

        /// <summary>
        /// Returns true if AgravityErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AgravityErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgravityErrorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
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
                if (this.ErrorId != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorId.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.Exception != null)
                {
                    hashCode = (hashCode * 59) + this.Exception.GetHashCode();
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
