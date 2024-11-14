/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.3.0-usercontext
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
    /// PortalTheme
    /// </summary>
    [DataContract(Name = "portalTheme")]
    public partial class PortalTheme : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalTheme" /> class.
        /// </summary>
        /// <param name="backgroundUrl">backgroundUrl.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="colors">colors.</param>
        /// <param name="topbarColor">topbarColor.</param>
        /// <param name="iconEmpty">iconEmpty.</param>
        /// <param name="iconActive">iconActive.</param>
        public PortalTheme(string backgroundUrl = default(string), string logoUrl = default(string), Dictionary<string, object> colors = default(Dictionary<string, object>), string topbarColor = default(string), string iconEmpty = default(string), string iconActive = default(string))
        {
            this.BackgroundUrl = backgroundUrl;
            this.LogoUrl = logoUrl;
            this.Colors = colors;
            this.TopbarColor = topbarColor;
            this.IconEmpty = iconEmpty;
            this.IconActive = iconActive;
        }

        /// <summary>
        /// Gets or Sets BackgroundUrl
        /// </summary>
        [DataMember(Name = "background_url", EmitDefaultValue = true)]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logo_url", EmitDefaultValue = true)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Colors
        /// </summary>
        [DataMember(Name = "colors", EmitDefaultValue = true)]
        public Dictionary<string, object> Colors { get; set; }

        /// <summary>
        /// Gets or Sets TopbarColor
        /// </summary>
        [DataMember(Name = "topbar_color", EmitDefaultValue = true)]
        public string TopbarColor { get; set; }

        /// <summary>
        /// Gets or Sets IconEmpty
        /// </summary>
        [DataMember(Name = "icon_empty", EmitDefaultValue = true)]
        public string IconEmpty { get; set; }

        /// <summary>
        /// Gets or Sets IconActive
        /// </summary>
        [DataMember(Name = "icon_active", EmitDefaultValue = true)]
        public string IconActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PortalTheme {\n");
            sb.Append("  BackgroundUrl: ").Append(BackgroundUrl).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  TopbarColor: ").Append(TopbarColor).Append("\n");
            sb.Append("  IconEmpty: ").Append(IconEmpty).Append("\n");
            sb.Append("  IconActive: ").Append(IconActive).Append("\n");
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
