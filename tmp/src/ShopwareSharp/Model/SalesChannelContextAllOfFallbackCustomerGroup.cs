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
    /// Fallback group if the default customer group is not applicable
    /// </summary>
    public partial class SalesChannelContextAllOfFallbackCustomerGroup : IEquatable<SalesChannelContextAllOfFallbackCustomerGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfFallbackCustomerGroup" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="displayGross">displayGross</param>
        public SalesChannelContextAllOfFallbackCustomerGroup(string? name = default, bool? displayGross = default)
        {
            Name = name;
            DisplayGross = displayGross;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayGross
        /// </summary>
        [JsonPropertyName("displayGross")]
        public bool? DisplayGross { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfFallbackCustomerGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayGross: ").Append(DisplayGross).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfFallbackCustomerGroup);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfFallbackCustomerGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfFallbackCustomerGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfFallbackCustomerGroup? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayGross == input.DisplayGross ||
                    this.DisplayGross.Equals(input.DisplayGross)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayGross.GetHashCode();
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
