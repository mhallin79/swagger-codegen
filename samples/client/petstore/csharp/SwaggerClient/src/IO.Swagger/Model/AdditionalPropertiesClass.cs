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
    /// AdditionalPropertiesClass
    /// </summary>
    [DataContract]
    public partial class AdditionalPropertiesClass :  IEquatable<AdditionalPropertiesClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="mapProperty">mapProperty.</param>
        /// <param name="mapOfMapProperty">mapOfMapProperty.</param>
        public AdditionalPropertiesClass(Dictionary<string, string> mapProperty = default(Dictionary<string, string>), Dictionary<string, Dictionary<string, string>> mapOfMapProperty = default(Dictionary<string, Dictionary<string, string>>))
        {
            this.MapProperty = mapProperty;
            this.MapOfMapProperty = mapOfMapProperty;
        }
        
        /// <summary>
        /// Gets or Sets MapProperty
        /// </summary>
        [DataMember(Name="map_property", EmitDefaultValue=false)]
        public Dictionary<string, string> MapProperty { get; set; }

        /// <summary>
        /// Gets or Sets MapOfMapProperty
        /// </summary>
        [DataMember(Name="map_of_map_property", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> MapOfMapProperty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  MapProperty: ").Append(MapProperty).Append("\n");
            sb.Append("  MapOfMapProperty: ").Append(MapOfMapProperty).Append("\n");
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
        /// Deserialize the JSON string into a <see cref="AdditionalPropertiesClass" /> object.
        /// </summary>
        /// <param name="json">JSON string.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public static AdditionalPropertiesClass FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AdditionalPropertiesClass>(json);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdditionalPropertiesClass);
        }

        /// <summary>
        /// Returns true if AdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalPropertiesClass input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MapProperty == input.MapProperty ||
                    this.MapProperty != null &&
                    this.MapProperty.SequenceEqual(input.MapProperty)
                ) && 
                (
                    this.MapOfMapProperty == input.MapOfMapProperty ||
                    this.MapOfMapProperty != null &&
                    this.MapOfMapProperty.SequenceEqual(input.MapOfMapProperty)
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
                if (this.MapProperty != null)
                    hashCode = hashCode * 59 + this.MapProperty.GetHashCode();
                if (this.MapOfMapProperty != null)
                    hashCode = hashCode * 59 + this.MapOfMapProperty.GetHashCode();
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
