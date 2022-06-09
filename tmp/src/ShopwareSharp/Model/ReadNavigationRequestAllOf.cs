// <auto-generated>
/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// ReadNavigationRequestAllOf
    /// </summary>
    public partial class ReadNavigationRequestAllOf : IEquatable<ReadNavigationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadNavigationRequestAllOf" /> class.
        /// </summary>
        /// <param name="depth">Determines the depth of fetched navigation levels.</param>
        /// <param name="buildTree">Return the categories as a tree or as a flat list.</param>
        public ReadNavigationRequestAllOf(Object? depth = default, Object? buildTree = default)
        {
            Depth = depth;
            BuildTree = buildTree;
        }

        /// <summary>
        /// Determines the depth of fetched navigation levels.
        /// </summary>
        /// <value>Determines the depth of fetched navigation levels.</value>
        [JsonPropertyName("depth")]
        public Object? Depth { get; set; }

        /// <summary>
        /// Return the categories as a tree or as a flat list.
        /// </summary>
        /// <value>Return the categories as a tree or as a flat list.</value>
        [JsonPropertyName("buildTree")]
        public Object? BuildTree { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadNavigationRequestAllOf {\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  BuildTree: ").Append(BuildTree).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return this.Equals(input as ReadNavigationRequestAllOf);
        }

        /// <summary>
        /// Returns true if ReadNavigationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadNavigationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadNavigationRequestAllOf? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.BuildTree == input.BuildTree ||
                    (this.BuildTree != null &&
                    this.BuildTree.Equals(input.BuildTree))
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
                if (this.Depth != null)
                {
                    hashCode = (hashCode * 59) + this.Depth.GetHashCode();
                }
                if (this.BuildTree != null)
                {
                    hashCode = (hashCode * 59) + this.BuildTree.GetHashCode();
                }
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
