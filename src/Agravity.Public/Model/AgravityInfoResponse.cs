/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.1.2
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
    /// AgravityInfoResponse
    /// </summary>
    [DataContract(Name = "agravityInfoResponse")]
    public partial class AgravityInfoResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgravityInfoResponse" /> class.
        /// </summary>
        /// <param name="infoId">infoId.</param>
        /// <param name="infoMessage">infoMessage.</param>
        /// <param name="infoObject">infoObject.</param>
        public AgravityInfoResponse(string infoId = default(string), string infoMessage = default(string), Object infoObject = default(Object))
        {
            this.InfoId = infoId;
            this.InfoMessage = infoMessage;
            this.InfoObject = infoObject;
        }

        /// <summary>
        /// Gets or Sets InfoId
        /// </summary>
        [DataMember(Name = "info_id", EmitDefaultValue = true)]
        public string InfoId { get; set; }

        /// <summary>
        /// Gets or Sets InfoMessage
        /// </summary>
        [DataMember(Name = "info_message", EmitDefaultValue = true)]
        public string InfoMessage { get; set; }

        /// <summary>
        /// Gets or Sets InfoObject
        /// </summary>
        [DataMember(Name = "info_object", EmitDefaultValue = true)]
        public Object InfoObject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgravityInfoResponse {\n");
            sb.Append("  InfoId: ").Append(InfoId).Append("\n");
            sb.Append("  InfoMessage: ").Append(InfoMessage).Append("\n");
            sb.Append("  InfoObject: ").Append(InfoObject).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
