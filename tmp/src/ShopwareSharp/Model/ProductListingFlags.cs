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
    /// Additional flags for product listings
    /// </summary>
    public partial class ProductListingFlags : IEquatable<ProductListingFlags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListingFlags" /> class.
        /// </summary>
        /// <param name="noAggregations">Resets all aggregations in the criteria. This parameter is a flag, the value has no effect.</param>
        /// <param name="onlyAggregations">If this flag is set, no products are fetched. Sorting and associations are also ignored. This parameter is a flag, the value has no effect.</param>
        public ProductListingFlags(string? noAggregations = default, string? onlyAggregations = default)
        {
            NoAggregations = noAggregations;
            OnlyAggregations = onlyAggregations;
        }

        /// <summary>
        /// Resets all aggregations in the criteria. This parameter is a flag, the value has no effect.
        /// </summary>
        /// <value>Resets all aggregations in the criteria. This parameter is a flag, the value has no effect.</value>
        [JsonPropertyName("no-aggregations")]
        public string? NoAggregations { get; set; }

        /// <summary>
        /// If this flag is set, no products are fetched. Sorting and associations are also ignored. This parameter is a flag, the value has no effect.
        /// </summary>
        /// <value>If this flag is set, no products are fetched. Sorting and associations are also ignored. This parameter is a flag, the value has no effect.</value>
        [JsonPropertyName("only-aggregations")]
        public string? OnlyAggregations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductListingFlags {\n");
            sb.Append("  NoAggregations: ").Append(NoAggregations).Append("\n");
            sb.Append("  OnlyAggregations: ").Append(OnlyAggregations).Append("\n");
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
            return this.Equals(input as ProductListingFlags);
        }

        /// <summary>
        /// Returns true if ProductListingFlags instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListingFlags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListingFlags? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoAggregations == input.NoAggregations ||
                    (this.NoAggregations != null &&
                    this.NoAggregations.Equals(input.NoAggregations))
                ) && 
                (
                    this.OnlyAggregations == input.OnlyAggregations ||
                    (this.OnlyAggregations != null &&
                    this.OnlyAggregations.Equals(input.OnlyAggregations))
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
                if (this.NoAggregations != null)
                {
                    hashCode = (hashCode * 59) + this.NoAggregations.GetHashCode();
                }
                if (this.OnlyAggregations != null)
                {
                    hashCode = (hashCode * 59) + this.OnlyAggregations.GetHashCode();
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
