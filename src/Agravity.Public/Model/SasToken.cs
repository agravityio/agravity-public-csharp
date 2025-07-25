/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.3.0
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
    /// SasToken
    /// </summary>
    [DataContract(Name = "sasToken")]
    public partial class SasToken : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SasToken" /> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="container">container.</param>
        /// <param name="blob">blob.</param>
        /// <param name="url">url.</param>
        /// <param name="fulltoken">fulltoken.</param>
        /// <param name="expires">expires.</param>
        public SasToken(string token = default(string), string container = default(string), string blob = default(string), string url = default(string), string fulltoken = default(string), DateTime? expires = default(DateTime?))
        {
            this.Token = token;
            this.Container = container;
            this.Blob = blob;
            this.Url = url;
            this.Fulltoken = fulltoken;
            this.Expires = expires;
        }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name = "container", EmitDefaultValue = true)]
        public string Container { get; set; }

        /// <summary>
        /// Gets or Sets Blob
        /// </summary>
        [DataMember(Name = "blob", EmitDefaultValue = true)]
        public string Blob { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Fulltoken
        /// </summary>
        [DataMember(Name = "fulltoken", EmitDefaultValue = true)]
        public string Fulltoken { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = true)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SasToken {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  Blob: ").Append(Blob).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Fulltoken: ").Append(Fulltoken).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
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
