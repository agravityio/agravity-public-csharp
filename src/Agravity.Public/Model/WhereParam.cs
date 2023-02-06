/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.0.2
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
    /// WhereParam
    /// </summary>
    [DataContract(Name = "whereParam")]
    public partial class WhereParam : IEquatable<WhereParam>, IValidatableObject
    {
        /// <summary>
        /// Defines Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum Equals for value: Equals
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals = 1,

            /// <summary>
            /// Enum NotEquals for value: NotEquals
            /// </summary>
            [EnumMember(Value = "NotEquals")]
            NotEquals = 2,

            /// <summary>
            /// Enum GreaterThan for value: GreaterThan
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            GreaterThan = 3,

            /// <summary>
            /// Enum LessThan for value: LessThan
            /// </summary>
            [EnumMember(Value = "LessThan")]
            LessThan = 4,

            /// <summary>
            /// Enum GreaterThanOrEqual for value: GreaterThanOrEqual
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqual")]
            GreaterThanOrEqual = 5,

            /// <summary>
            /// Enum LessThanOrEqual for value: LessThanOrEqual
            /// </summary>
            [EnumMember(Value = "LessThanOrEqual")]
            LessThanOrEqual = 6,

            /// <summary>
            /// Enum Contains for value: Contains
            /// </summary>
            [EnumMember(Value = "Contains")]
            Contains = 7,

            /// <summary>
            /// Enum StartsWith for value: StartsWith
            /// </summary>
            [EnumMember(Value = "StartsWith")]
            StartsWith = 8,

            /// <summary>
            /// Enum ArrayContains for value: ArrayContains
            /// </summary>
            [EnumMember(Value = "ArrayContains")]
            ArrayContains = 9,

            /// <summary>
            /// Enum ArrayContainsPartial for value: ArrayContainsPartial
            /// </summary>
            [EnumMember(Value = "ArrayContainsPartial")]
            ArrayContainsPartial = 10

        }


        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Defines ValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 1,

            /// <summary>
            /// Enum Bool for value: Bool
            /// </summary>
            [EnumMember(Value = "Bool")]
            Bool = 2,

            /// <summary>
            /// Enum Number for value: Number
            /// </summary>
            [EnumMember(Value = "Number")]
            Number = 3

        }


        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhereParam" /> class.
        /// </summary>
        /// <param name="_operator">_operator (default to OperatorEnum.Equals).</param>
        /// <param name="field">field.</param>
        /// <param name="value">value.</param>
        /// <param name="notPrefix">notPrefix.</param>
        /// <param name="valueType">valueType (default to ValueTypeEnum.String).</param>
        public WhereParam(OperatorEnum? _operator = OperatorEnum.Equals, string field = default(string), Object value = default(Object), bool notPrefix = default(bool), ValueTypeEnum? valueType = ValueTypeEnum.String)
        {
            this.Operator = _operator;
            this.Field = field;
            this.Value = value;
            this.NotPrefix = notPrefix;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets NotPrefix
        /// </summary>
        [DataMember(Name = "notPrefix", EmitDefaultValue = true)]
        public bool NotPrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WhereParam {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NotPrefix: ").Append(NotPrefix).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(input as WhereParam);
        }

        /// <summary>
        /// Returns true if WhereParam instances are equal
        /// </summary>
        /// <param name="input">Instance of WhereParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhereParam input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.NotPrefix == input.NotPrefix ||
                    this.NotPrefix.Equals(input.NotPrefix)
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
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
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NotPrefix.GetHashCode();
                hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
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
