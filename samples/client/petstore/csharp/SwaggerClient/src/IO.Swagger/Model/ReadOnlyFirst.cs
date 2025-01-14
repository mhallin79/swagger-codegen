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
    /// ReadOnlyFirst
    /// </summary>
    [DataContract]
    public partial class ReadOnlyFirst :  IEquatable<ReadOnlyFirst>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyFirst" /> class.
        /// </summary>
        /// <param name="baz">baz.</param>
        public ReadOnlyFirst(string baz = default(string))
        {
            this.Baz = baz;
        }
        
        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [DataMember(Name="bar", EmitDefaultValue=false)]
        public string Bar { get; private set; }

        /// <summary>
        /// Gets or Sets Baz
        /// </summary>
        [DataMember(Name="baz", EmitDefaultValue=false)]
        public string Baz { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReadOnlyFirst {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Baz: ").Append(Baz).Append("\n");
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
        /// Deserialize the JSON string into a <see cref="ReadOnlyFirst" /> object.
        /// </summary>
        /// <param name="json">JSON string.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public static ReadOnlyFirst FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ReadOnlyFirst>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadOnlyFirst);
        }

        /// <summary>
        /// Returns true if ReadOnlyFirst instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadOnlyFirst to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadOnlyFirst input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bar == input.Bar ||
                    (this.Bar != null &&
                    this.Bar.Equals(input.Bar))
                ) && 
                (
                    this.Baz == input.Baz ||
                    (this.Baz != null &&
                    this.Baz.Equals(input.Baz))
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
                if (this.Bar != null)
                    hashCode = hashCode * 59 + this.Bar.GetHashCode();
                if (this.Baz != null)
                    hashCode = hashCode * 59 + this.Baz.GetHashCode();
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
