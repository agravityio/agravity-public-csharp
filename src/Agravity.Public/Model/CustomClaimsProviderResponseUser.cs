/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.3.0
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
    /// CustomClaimsProviderResponseUser
    /// </summary>
    [DataContract(Name = "customClaimsProviderResponseUser")]
    public partial class CustomClaimsProviderResponseUser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomClaimsProviderResponseUser" /> class.
        /// </summary>
        /// <param name="companyName">companyName.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="givenName">givenName.</param>
        /// <param name="id">id.</param>
        /// <param name="mail">mail.</param>
        /// <param name="onPremisesSamAccountName">onPremisesSamAccountName.</param>
        /// <param name="onPremisesSecurityIdentifier">onPremisesSecurityIdentifier.</param>
        /// <param name="onPremisesUserPrincipalName">onPremisesUserPrincipalName.</param>
        /// <param name="preferredLanguage">preferredLanguage.</param>
        /// <param name="surname">surname.</param>
        /// <param name="userPrincipalName">userPrincipalName.</param>
        /// <param name="userType">userType.</param>
        public CustomClaimsProviderResponseUser(string companyName = default(string), DateTime createdDateTime = default(DateTime), string displayName = default(string), string givenName = default(string), string id = default(string), string mail = default(string), string onPremisesSamAccountName = default(string), string onPremisesSecurityIdentifier = default(string), string onPremisesUserPrincipalName = default(string), string preferredLanguage = default(string), string surname = default(string), string userPrincipalName = default(string), string userType = default(string))
        {
            this.CompanyName = companyName;
            this.CreatedDateTime = createdDateTime;
            this.DisplayName = displayName;
            this.GivenName = givenName;
            this.Id = id;
            this.Mail = mail;
            this.OnPremisesSamAccountName = onPremisesSamAccountName;
            this.OnPremisesSecurityIdentifier = onPremisesSecurityIdentifier;
            this.OnPremisesUserPrincipalName = onPremisesUserPrincipalName;
            this.PreferredLanguage = preferredLanguage;
            this.Surname = surname;
            this.UserPrincipalName = userPrincipalName;
            this.UserType = userType;
        }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = false)]
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name = "givenName", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Mail
        /// </summary>
        [DataMember(Name = "mail", EmitDefaultValue = false)]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or Sets OnPremisesSamAccountName
        /// </summary>
        [DataMember(Name = "onPremisesSamAccountName", EmitDefaultValue = false)]
        public string OnPremisesSamAccountName { get; set; }

        /// <summary>
        /// Gets or Sets OnPremisesSecurityIdentifier
        /// </summary>
        [DataMember(Name = "onPremisesSecurityIdentifier", EmitDefaultValue = false)]
        public string OnPremisesSecurityIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets OnPremisesUserPrincipalName
        /// </summary>
        [DataMember(Name = "onPremisesUserPrincipalName", EmitDefaultValue = false)]
        public string OnPremisesUserPrincipalName { get; set; }

        /// <summary>
        /// Gets or Sets PreferredLanguage
        /// </summary>
        [DataMember(Name = "preferredLanguage", EmitDefaultValue = false)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name = "surname", EmitDefaultValue = false)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets UserPrincipalName
        /// </summary>
        [DataMember(Name = "userPrincipalName", EmitDefaultValue = false)]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name = "userType", EmitDefaultValue = false)]
        public string UserType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomClaimsProviderResponseUser {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  OnPremisesSamAccountName: ").Append(OnPremisesSamAccountName).Append("\n");
            sb.Append("  OnPremisesSecurityIdentifier: ").Append(OnPremisesSecurityIdentifier).Append("\n");
            sb.Append("  OnPremisesUserPrincipalName: ").Append(OnPremisesUserPrincipalName).Append("\n");
            sb.Append("  PreferredLanguage: ").Append(PreferredLanguage).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  UserPrincipalName: ").Append(UserPrincipalName).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
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
