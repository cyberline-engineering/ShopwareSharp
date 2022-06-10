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
    public partial class CmsBlock : IEquatable<CmsBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CmsBlock" /> class.
        /// </summary>
        /// <param name="position">position (required)</param>
        /// <param name="type">type (required)</param>
        /// <param name="sectionId">sectionId (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="sectionPosition">sectionPosition</param>
        /// <param name="marginTop">marginTop</param>
        /// <param name="marginBottom">marginBottom</param>
        /// <param name="marginLeft">marginLeft</param>
        /// <param name="marginRight">marginRight</param>
        /// <param name="backgroundColor">backgroundColor</param>
        /// <param name="backgroundMediaId">backgroundMediaId</param>
        /// <param name="backgroundMediaMode">backgroundMediaMode</param>
        /// <param name="cssClass">cssClass</param>
        /// <param name="customFields">customFields</param>
        /// <param name="versionId">versionId</param>
        /// <param name="cmsSectionVersionId">cmsSectionVersionId</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="backgroundMedia">backgroundMedia</param>
        /// <param name="slots">slots</param>
        public CmsBlock(long position, string type, string sectionId, DateTime createdAt, string? id = default, string? name = default, string? sectionPosition = default, string? marginTop = default, string? marginBottom = default, string? marginLeft = default, string? marginRight = default, string? backgroundColor = default, string? backgroundMediaId = default, string? backgroundMediaMode = default, string? cssClass = default, Object? customFields = default, string? versionId = default, string? cmsSectionVersionId = default, DateTime? updatedAt = default, Media? backgroundMedia = default, CmsSlot? slots = default)
        {
            if (position == null)
                throw new ArgumentNullException("position is a required property for CmsBlock and cannot be null.");

            if (type == null)
                throw new ArgumentNullException("type is a required property for CmsBlock and cannot be null.");

            if (sectionId == null)
                throw new ArgumentNullException("sectionId is a required property for CmsBlock and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for CmsBlock and cannot be null.");

            Position = position;
            Type = type;
            SectionId = sectionId;
            CreatedAt = createdAt;
            Id = id;
            Name = name;
            SectionPosition = sectionPosition;
            MarginTop = marginTop;
            MarginBottom = marginBottom;
            MarginLeft = marginLeft;
            MarginRight = marginRight;
            BackgroundColor = backgroundColor;
            BackgroundMediaId = backgroundMediaId;
            BackgroundMediaMode = backgroundMediaMode;
            CssClass = cssClass;
            CustomFields = customFields;
            VersionId = versionId;
            CmsSectionVersionId = cmsSectionVersionId;
            UpdatedAt = updatedAt;
            BackgroundMedia = backgroundMedia;
            Slots = slots;
        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public long Position { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        [JsonPropertyName("sectionId")]
        public string SectionId { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets SectionPosition
        /// </summary>
        [JsonPropertyName("sectionPosition")]
        public string? SectionPosition { get; set; }

        /// <summary>
        /// Gets or Sets MarginTop
        /// </summary>
        [JsonPropertyName("marginTop")]
        public string? MarginTop { get; set; }

        /// <summary>
        /// Gets or Sets MarginBottom
        /// </summary>
        [JsonPropertyName("marginBottom")]
        public string? MarginBottom { get; set; }

        /// <summary>
        /// Gets or Sets MarginLeft
        /// </summary>
        [JsonPropertyName("marginLeft")]
        public string? MarginLeft { get; set; }

        /// <summary>
        /// Gets or Sets MarginRight
        /// </summary>
        [JsonPropertyName("marginRight")]
        public string? MarginRight { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundMediaId
        /// </summary>
        [JsonPropertyName("backgroundMediaId")]
        public string? BackgroundMediaId { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundMediaMode
        /// </summary>
        [JsonPropertyName("backgroundMediaMode")]
        public string? BackgroundMediaMode { get; set; }

        /// <summary>
        /// Gets or Sets CssClass
        /// </summary>
        [JsonPropertyName("cssClass")]
        public string? CssClass { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [JsonPropertyName("customFields")]
        public Object? CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Gets or Sets CmsSectionVersionId
        /// </summary>
        [JsonPropertyName("cmsSectionVersionId")]
        public string? CmsSectionVersionId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets BackgroundMedia
        /// </summary>
        [JsonPropertyName("backgroundMedia")]
        public Media? BackgroundMedia { get; set; }

        /// <summary>
        /// Gets or Sets Slots
        /// </summary>
        [JsonPropertyName("slots")]
        public CmsSlot? Slots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CmsBlock {\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SectionPosition: ").Append(SectionPosition).Append("\n");
            sb.Append("  MarginTop: ").Append(MarginTop).Append("\n");
            sb.Append("  MarginBottom: ").Append(MarginBottom).Append("\n");
            sb.Append("  MarginLeft: ").Append(MarginLeft).Append("\n");
            sb.Append("  MarginRight: ").Append(MarginRight).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  BackgroundMediaId: ").Append(BackgroundMediaId).Append("\n");
            sb.Append("  BackgroundMediaMode: ").Append(BackgroundMediaMode).Append("\n");
            sb.Append("  CssClass: ").Append(CssClass).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  CmsSectionVersionId: ").Append(CmsSectionVersionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  BackgroundMedia: ").Append(BackgroundMedia).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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
            return this.Equals(input as CmsBlock);
        }

        /// <summary>
        /// Returns true if CmsBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of CmsBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CmsBlock? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SectionPosition == input.SectionPosition ||
                    (this.SectionPosition != null &&
                    this.SectionPosition.Equals(input.SectionPosition))
                ) && 
                (
                    this.MarginTop == input.MarginTop ||
                    (this.MarginTop != null &&
                    this.MarginTop.Equals(input.MarginTop))
                ) && 
                (
                    this.MarginBottom == input.MarginBottom ||
                    (this.MarginBottom != null &&
                    this.MarginBottom.Equals(input.MarginBottom))
                ) && 
                (
                    this.MarginLeft == input.MarginLeft ||
                    (this.MarginLeft != null &&
                    this.MarginLeft.Equals(input.MarginLeft))
                ) && 
                (
                    this.MarginRight == input.MarginRight ||
                    (this.MarginRight != null &&
                    this.MarginRight.Equals(input.MarginRight))
                ) && 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    this.BackgroundMediaId == input.BackgroundMediaId ||
                    (this.BackgroundMediaId != null &&
                    this.BackgroundMediaId.Equals(input.BackgroundMediaId))
                ) && 
                (
                    this.BackgroundMediaMode == input.BackgroundMediaMode ||
                    (this.BackgroundMediaMode != null &&
                    this.BackgroundMediaMode.Equals(input.BackgroundMediaMode))
                ) && 
                (
                    this.CssClass == input.CssClass ||
                    (this.CssClass != null &&
                    this.CssClass.Equals(input.CssClass))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.CmsSectionVersionId == input.CmsSectionVersionId ||
                    (this.CmsSectionVersionId != null &&
                    this.CmsSectionVersionId.Equals(input.CmsSectionVersionId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.BackgroundMedia == input.BackgroundMedia ||
                    (this.BackgroundMedia != null &&
                    this.BackgroundMedia.Equals(input.BackgroundMedia))
                ) && 
                (
                    this.Slots == input.Slots ||
                    (this.Slots != null &&
                    this.Slots.Equals(input.Slots))
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
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SectionPosition != null)
                {
                    hashCode = (hashCode * 59) + this.SectionPosition.GetHashCode();
                }
                if (this.MarginTop != null)
                {
                    hashCode = (hashCode * 59) + this.MarginTop.GetHashCode();
                }
                if (this.MarginBottom != null)
                {
                    hashCode = (hashCode * 59) + this.MarginBottom.GetHashCode();
                }
                if (this.MarginLeft != null)
                {
                    hashCode = (hashCode * 59) + this.MarginLeft.GetHashCode();
                }
                if (this.MarginRight != null)
                {
                    hashCode = (hashCode * 59) + this.MarginRight.GetHashCode();
                }
                if (this.BackgroundColor != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundColor.GetHashCode();
                }
                if (this.BackgroundMediaId != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundMediaId.GetHashCode();
                }
                if (this.BackgroundMediaMode != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundMediaMode.GetHashCode();
                }
                if (this.CssClass != null)
                {
                    hashCode = (hashCode * 59) + this.CssClass.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                if (this.CmsSectionVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.CmsSectionVersionId.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.BackgroundMedia != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundMedia.GetHashCode();
                }
                if (this.Slots != null)
                {
                    hashCode = (hashCode * 59) + this.Slots.GetHashCode();
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
            // SectionId (string) pattern
            Regex regexSectionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSectionId.Match(this.SectionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionId, must match a pattern of " + regexSectionId, new [] { "SectionId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // BackgroundMediaId (string) pattern
            Regex regexBackgroundMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexBackgroundMediaId.Match(this.BackgroundMediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackgroundMediaId, must match a pattern of " + regexBackgroundMediaId, new [] { "BackgroundMediaId" });
            }

            // VersionId (string) pattern
            Regex regexVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexVersionId.Match(this.VersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VersionId, must match a pattern of " + regexVersionId, new [] { "VersionId" });
            }

            // CmsSectionVersionId (string) pattern
            Regex regexCmsSectionVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCmsSectionVersionId.Match(this.CmsSectionVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CmsSectionVersionId, must match a pattern of " + regexCmsSectionVersionId, new [] { "CmsSectionVersionId" });
            }

            yield break;
        }
    }

}