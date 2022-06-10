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
    /// ShippingMethodPageRouteResponseInnerTranslationsInner
    /// </summary>
    public partial class ShippingMethodPageRouteResponseInnerTranslationsInner : IEquatable<ShippingMethodPageRouteResponseInnerTranslationsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethodPageRouteResponseInnerTranslationsInner" /> class.
        /// </summary>
        /// <param name="shippingMethodId">shippingMethodId</param>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        public ShippingMethodPageRouteResponseInnerTranslationsInner(string? shippingMethodId = default, string? name = default, string? description = default)
        {
            ShippingMethodId = shippingMethodId;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Gets or Sets ShippingMethodId
        /// </summary>
        [JsonPropertyName("shippingMethodId")]
        public string? ShippingMethodId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingMethodPageRouteResponseInnerTranslationsInner {\n");
            sb.Append("  ShippingMethodId: ").Append(ShippingMethodId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ShippingMethodPageRouteResponseInnerTranslationsInner);
        }

        /// <summary>
        /// Returns true if ShippingMethodPageRouteResponseInnerTranslationsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingMethodPageRouteResponseInnerTranslationsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingMethodPageRouteResponseInnerTranslationsInner? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShippingMethodId == input.ShippingMethodId ||
                    (this.ShippingMethodId != null &&
                    this.ShippingMethodId.Equals(input.ShippingMethodId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ShippingMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingMethodId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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