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
    public partial class MediaTag : IEquatable<MediaTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaTag" /> class.
        /// </summary>
        /// <param name="mediaId">mediaId (required)</param>
        /// <param name="tagId">tagId (required)</param>
        /// <param name="id">id</param>
        /// <param name="media">media</param>
        /// <param name="tag">tag</param>
        public MediaTag(string mediaId, string tagId, string? id = default, Media? media = default, Tag? tag = default)
        {
            if (mediaId == null)
                throw new ArgumentNullException("mediaId is a required property for MediaTag and cannot be null.");

            if (tagId == null)
                throw new ArgumentNullException("tagId is a required property for MediaTag and cannot be null.");

            MediaId = mediaId;
            TagId = tagId;
            Id = id;
            Media = media;
            Tag = tag;
        }

        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [JsonPropertyName("mediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [JsonPropertyName("tagId")]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [JsonPropertyName("media")]
        public Media? Media { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public Tag? Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MediaTag {\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as MediaTag);
        }

        /// <summary>
        /// Returns true if MediaTag instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaTag? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.TagId != null)
                {
                    hashCode = (hashCode * 59) + this.TagId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
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
            // MediaId (string) pattern
            Regex regexMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexMediaId.Match(this.MediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, must match a pattern of " + regexMediaId, new [] { "MediaId" });
            }

            // TagId (string) pattern
            Regex regexTagId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexTagId.Match(this.TagId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TagId, must match a pattern of " + regexTagId, new [] { "TagId" });
            }

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