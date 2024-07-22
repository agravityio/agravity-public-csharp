/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.2.2
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
    /// SearchAdminIndexerLastRun
    /// </summary>
    [DataContract(Name = "searchAdminIndexerLastRun")]
    public partial class SearchAdminIndexerLastRun : IEquatable<SearchAdminIndexerLastRun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAdminIndexerLastRun" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="starttime">starttime.</param>
        /// <param name="endtime">endtime.</param>
        /// <param name="itemcount">itemcount.</param>
        /// <param name="faileditemcount">faileditemcount.</param>
        public SearchAdminIndexerLastRun(string status = default(string), DateTime? starttime = default(DateTime?), DateTime? endtime = default(DateTime?), long itemcount = default(long), long faileditemcount = default(long))
        {
            this.Status = status;
            this.Starttime = starttime;
            this.Endtime = endtime;
            this.Itemcount = itemcount;
            this.Faileditemcount = faileditemcount;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Starttime
        /// </summary>
        [DataMember(Name = "starttime", EmitDefaultValue = true)]
        public DateTime? Starttime { get; set; }

        /// <summary>
        /// Gets or Sets Endtime
        /// </summary>
        [DataMember(Name = "endtime", EmitDefaultValue = true)]
        public DateTime? Endtime { get; set; }

        /// <summary>
        /// Gets or Sets Itemcount
        /// </summary>
        [DataMember(Name = "itemcount", EmitDefaultValue = false)]
        public long Itemcount { get; set; }

        /// <summary>
        /// Gets or Sets Faileditemcount
        /// </summary>
        [DataMember(Name = "faileditemcount", EmitDefaultValue = false)]
        public long Faileditemcount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchAdminIndexerLastRun {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Starttime: ").Append(Starttime).Append("\n");
            sb.Append("  Endtime: ").Append(Endtime).Append("\n");
            sb.Append("  Itemcount: ").Append(Itemcount).Append("\n");
            sb.Append("  Faileditemcount: ").Append(Faileditemcount).Append("\n");
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
            return this.Equals(input as SearchAdminIndexerLastRun);
        }

        /// <summary>
        /// Returns true if SearchAdminIndexerLastRun instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchAdminIndexerLastRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchAdminIndexerLastRun input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Starttime == input.Starttime ||
                    (this.Starttime != null &&
                    this.Starttime.Equals(input.Starttime))
                ) && 
                (
                    this.Endtime == input.Endtime ||
                    (this.Endtime != null &&
                    this.Endtime.Equals(input.Endtime))
                ) && 
                (
                    this.Itemcount == input.Itemcount ||
                    this.Itemcount.Equals(input.Itemcount)
                ) && 
                (
                    this.Faileditemcount == input.Faileditemcount ||
                    this.Faileditemcount.Equals(input.Faileditemcount)
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Starttime != null)
                {
                    hashCode = (hashCode * 59) + this.Starttime.GetHashCode();
                }
                if (this.Endtime != null)
                {
                    hashCode = (hashCode * 59) + this.Endtime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Itemcount.GetHashCode();
                hashCode = (hashCode * 59) + this.Faileditemcount.GetHashCode();
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
