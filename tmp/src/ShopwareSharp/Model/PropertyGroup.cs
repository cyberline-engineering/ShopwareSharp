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
    /// Added since version: 6.0.0.0
    /// </summary>
    public partial class PropertyGroup : IEquatable<PropertyGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGroup" /> class.
        /// </summary>
        /// <param name="name">name (required)</param>
        /// <param name="displayType">displayType (required)</param>
        /// <param name="sortingType">sortingType (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="description">description</param>
        /// <param name="filterable">filterable</param>
        /// <param name="visibleOnProductDetailPage">visibleOnProductDetailPage</param>
        /// <param name="position">position</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="translated">translated</param>
        /// <param name="options">options</param>
        public PropertyGroup(string name, string displayType, string sortingType, DateTime createdAt, string? id = default, string? description = default, bool? filterable = default, bool? visibleOnProductDetailPage = default, long? position = default, Object? customFields = default, DateTime? updatedAt = default, Object? translated = default, PropertyGroupOption? options = default)
        {
            if (name == null)
                throw new ArgumentNullException("name is a required property for PropertyGroup and cannot be null.");

            if (displayType == null)
                throw new ArgumentNullException("displayType is a required property for PropertyGroup and cannot be null.");

            if (sortingType == null)
                throw new ArgumentNullException("sortingType is a required property for PropertyGroup and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for PropertyGroup and cannot be null.");

            Name = name;
            DisplayType = displayType;
            SortingType = sortingType;
            CreatedAt = createdAt;
            Id = id;
            Description = description;
            Filterable = filterable;
            VisibleOnProductDetailPage = visibleOnProductDetailPage;
            Position = position;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Translated = translated;
            Options = options;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayType
        /// </summary>
        [JsonPropertyName("displayType")]
        public string DisplayType { get; set; }

        /// <summary>
        /// Gets or Sets SortingType
        /// </summary>
        [JsonPropertyName("sortingType")]
        public string SortingType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets Filterable
        /// </summary>
        [JsonPropertyName("filterable")]
        public bool? Filterable { get; set; }

        /// <summary>
        /// Gets or Sets VisibleOnProductDetailPage
        /// </summary>
        [JsonPropertyName("visibleOnProductDetailPage")]
        public bool? VisibleOnProductDetailPage { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public long? Position { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [JsonPropertyName("customFields")]
        public Object? CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Translated
        /// </summary>
        [JsonPropertyName("translated")]
        public Object? Translated { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [JsonPropertyName("options")]
        public PropertyGroupOption? Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  SortingType: ").Append(SortingType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Filterable: ").Append(Filterable).Append("\n");
            sb.Append("  VisibleOnProductDetailPage: ").Append(VisibleOnProductDetailPage).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as PropertyGroup);
        }

        /// <summary>
        /// Returns true if PropertyGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyGroup? input)
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
                    this.DisplayType == input.DisplayType ||
                    (this.DisplayType != null &&
                    this.DisplayType.Equals(input.DisplayType))
                ) && 
                (
                    this.SortingType == input.SortingType ||
                    (this.SortingType != null &&
                    this.SortingType.Equals(input.SortingType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Filterable == input.Filterable ||
                    this.Filterable.Equals(input.Filterable)
                ) && 
                (
                    this.VisibleOnProductDetailPage == input.VisibleOnProductDetailPage ||
                    this.VisibleOnProductDetailPage.Equals(input.VisibleOnProductDetailPage)
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Translated == input.Translated ||
                    (this.Translated != null &&
                    this.Translated.Equals(input.Translated))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.DisplayType != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayType.GetHashCode();
                }
                if (this.SortingType != null)
                {
                    hashCode = (hashCode * 59) + this.SortingType.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Filterable.GetHashCode();
                hashCode = (hashCode * 59) + this.VisibleOnProductDetailPage.GetHashCode();
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}