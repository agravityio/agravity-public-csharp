/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.0.3
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
    /// PortalAuthentication
    /// </summary>
    [DataContract(Name = "portalAuthentication")]
    public partial class PortalAuthentication : IValidatableObject
    {
        /// <summary>
        /// Defines Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum UNDEFINED for value: UNDEFINED
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED = 1,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 2,

            /// <summary>
            /// Enum PASSWORD for value: PASSWORD
            /// </summary>
            [EnumMember(Value = "PASSWORD")]
            PASSWORD = 3,

            /// <summary>
            /// Enum EEID for value: EEID
            /// </summary>
            [EnumMember(Value = "EEID")]
            EEID = 4,

            /// <summary>
            /// Enum AUTH0 for value: AUTH0
            /// </summary>
            [EnumMember(Value = "AUTH0")]
            AUTH0 = 5
        }


        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalAuthentication" /> class.
        /// </summary>
        /// <param name="method">method (default to MethodEnum.UNDEFINED).</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="password">password.</param>
        public PortalAuthentication(MethodEnum? method = MethodEnum.UNDEFINED, string issuer = default(string), string clientId = default(string), string tenantId = default(string), string password = default(string))
        {
            this.Method = method;
            this.Issuer = issuer;
            this.ClientId = clientId;
            this.TenantId = tenantId;
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "issuer", EmitDefaultValue = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "client_id", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenant_id", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PortalAuthentication {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
