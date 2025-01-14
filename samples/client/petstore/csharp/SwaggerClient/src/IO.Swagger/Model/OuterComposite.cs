/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OuterComposite
    /// </summary>
    [DataContract]
    public partial class OuterComposite :  IEquatable<OuterComposite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OuterComposite" /> class.
        /// </summary>
        /// <param name="myNumber">myNumber.</param>
        /// <param name="myString">myString.</param>
        /// <param name="myBoolean">myBoolean.</param>
        public OuterComposite(decimal? myNumber = default(decimal?), string myString = default(string), bool? myBoolean = default(bool?))
        {
            this.MyNumber = myNumber;
            this.MyString = myString;
            this.MyBoolean = myBoolean;
        }
        
        /// <summary>
        /// Gets or Sets MyNumber
        /// </summary>
        [DataMember(Name="my_number", EmitDefaultValue=false)]
        public decimal? MyNumber { get; set; }

        /// <summary>
        /// Gets or Sets MyString
        /// </summary>
        [DataMember(Name="my_string", EmitDefaultValue=false)]
        public string MyString { get; set; }

        /// <summary>
        /// Gets or Sets MyBoolean
        /// </summary>
        [DataMember(Name="my_boolean", EmitDefaultValue=false)]
        public bool? MyBoolean { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OuterComposite {\n");
            sb.Append("  MyNumber: ").Append(MyNumber).Append("\n");
            sb.Append("  MyString: ").Append(MyString).Append("\n");
            sb.Append("  MyBoolean: ").Append(MyBoolean).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Deserialize the JSON string into a <see cref="OuterComposite" /> object.
        /// </summary>
        /// <param name="json">JSON string.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public static OuterComposite FromJson(string json)
        {
            return JsonConvert.DeserializeObject<OuterComposite>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OuterComposite);
        }

        /// <summary>
        /// Returns true if OuterComposite instances are equal
        /// </summary>
        /// <param name="input">Instance of OuterComposite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OuterComposite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MyNumber == input.MyNumber ||
                    (this.MyNumber != null &&
                    this.MyNumber.Equals(input.MyNumber))
                ) && 
                (
                    this.MyString == input.MyString ||
                    (this.MyString != null &&
                    this.MyString.Equals(input.MyString))
                ) && 
                (
                    this.MyBoolean == input.MyBoolean ||
                    (this.MyBoolean != null &&
                    this.MyBoolean.Equals(input.MyBoolean))
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
                if (this.MyNumber != null)
                    hashCode = hashCode * 59 + this.MyNumber.GetHashCode();
                if (this.MyString != null)
                    hashCode = hashCode * 59 + this.MyString.GetHashCode();
                if (this.MyBoolean != null)
                    hashCode = hashCode * 59 + this.MyBoolean.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
