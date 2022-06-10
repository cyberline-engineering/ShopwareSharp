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
    /// CartAllOfPrice
    /// </summary>
    public partial class CartAllOfPrice : IEquatable<CartAllOfPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartAllOfPrice" /> class.
        /// </summary>
        /// <param name="netPrice">Net price of the cart</param>
        /// <param name="totalPrice">Total price of the cart, including shipping costs, discounts and taxes</param>
        /// <param name="positionPrice">Price for all line items in the cart</param>
        /// <param name="taxStatus">Tax calculation for the cart. One of &#x60;gross&#x60;, &#x60;net&#x60; or &#x60;tax-free&#x60;</param>
        public CartAllOfPrice(float? netPrice = default, float? totalPrice = default, float? positionPrice = default, string? taxStatus = default)
        {
            NetPrice = netPrice;
            TotalPrice = totalPrice;
            PositionPrice = positionPrice;
            TaxStatus = taxStatus;
        }

        /// <summary>
        /// Net price of the cart
        /// </summary>
        /// <value>Net price of the cart</value>
        [JsonPropertyName("netPrice")]
        public float? NetPrice { get; set; }

        /// <summary>
        /// Total price of the cart, including shipping costs, discounts and taxes
        /// </summary>
        /// <value>Total price of the cart, including shipping costs, discounts and taxes</value>
        [JsonPropertyName("totalPrice")]
        public float? TotalPrice { get; set; }

        /// <summary>
        /// Price for all line items in the cart
        /// </summary>
        /// <value>Price for all line items in the cart</value>
        [JsonPropertyName("positionPrice")]
        public float? PositionPrice { get; set; }

        /// <summary>
        /// Tax calculation for the cart. One of &#x60;gross&#x60;, &#x60;net&#x60; or &#x60;tax-free&#x60;
        /// </summary>
        /// <value>Tax calculation for the cart. One of &#x60;gross&#x60;, &#x60;net&#x60; or &#x60;tax-free&#x60;</value>
        [JsonPropertyName("taxStatus")]
        public string? TaxStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartAllOfPrice {\n");
            sb.Append("  NetPrice: ").Append(NetPrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  PositionPrice: ").Append(PositionPrice).Append("\n");
            sb.Append("  TaxStatus: ").Append(TaxStatus).Append("\n");
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
            return this.Equals(input as CartAllOfPrice);
        }

        /// <summary>
        /// Returns true if CartAllOfPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of CartAllOfPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartAllOfPrice? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NetPrice == input.NetPrice ||
                    this.NetPrice.Equals(input.NetPrice)
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    this.TotalPrice.Equals(input.TotalPrice)
                ) && 
                (
                    this.PositionPrice == input.PositionPrice ||
                    this.PositionPrice.Equals(input.PositionPrice)
                ) && 
                (
                    this.TaxStatus == input.TaxStatus ||
                    (this.TaxStatus != null &&
                    this.TaxStatus.Equals(input.TaxStatus))
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
                hashCode = (hashCode * 59) + this.NetPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.PositionPrice.GetHashCode();
                if (this.TaxStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TaxStatus.GetHashCode();
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