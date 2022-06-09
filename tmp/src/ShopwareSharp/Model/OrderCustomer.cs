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
    public partial class OrderCustomer : IEquatable<OrderCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCustomer" /> class.
        /// </summary>
        /// <param name="email">email (required)</param>
        /// <param name="salutationId">salutationId (required)</param>
        /// <param name="firstName">firstName (required)</param>
        /// <param name="lastName">lastName (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="versionId">versionId</param>
        /// <param name="company">company</param>
        /// <param name="title">title</param>
        /// <param name="vatIds">vatIds</param>
        /// <param name="customerNumber">customerNumber</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="salutation">salutation</param>
        public OrderCustomer(string email, string salutationId, string firstName, string lastName, DateTime createdAt, string? id = default, string? versionId = default, string? company = default, string? title = default, List<string>? vatIds = default, string? customerNumber = default, Object? customFields = default, DateTime? updatedAt = default, Salutation? salutation = default)
        {
            if (email == null)
                throw new ArgumentNullException("email is a required property for OrderCustomer and cannot be null.");

            if (salutationId == null)
                throw new ArgumentNullException("salutationId is a required property for OrderCustomer and cannot be null.");

            if (firstName == null)
                throw new ArgumentNullException("firstName is a required property for OrderCustomer and cannot be null.");

            if (lastName == null)
                throw new ArgumentNullException("lastName is a required property for OrderCustomer and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for OrderCustomer and cannot be null.");

            Email = email;
            SalutationId = salutationId;
            FirstName = firstName;
            LastName = lastName;
            CreatedAt = createdAt;
            Id = id;
            VersionId = versionId;
            Company = company;
            Title = title;
            VatIds = vatIds;
            CustomerNumber = customerNumber;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Salutation = salutation;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets SalutationId
        /// </summary>
        [JsonPropertyName("salutationId")]
        public string SalutationId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

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
        /// Gets or Sets VersionId
        /// </summary>
        [JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or Sets VatIds
        /// </summary>
        [JsonPropertyName("vatIds")]
        public List<string>? VatIds { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNumber
        /// </summary>
        [JsonPropertyName("customerNumber")]
        public string? CustomerNumber { get; set; }

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
        /// Gets or Sets Salutation
        /// </summary>
        [JsonPropertyName("salutation")]
        public Salutation? Salutation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCustomer {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SalutationId: ").Append(SalutationId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VatIds: ").Append(VatIds).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
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
            return this.Equals(input as OrderCustomer);
        }

        /// <summary>
        /// Returns true if OrderCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCustomer? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SalutationId == input.SalutationId ||
                    (this.SalutationId != null &&
                    this.SalutationId.Equals(input.SalutationId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
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
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.VatIds == input.VatIds ||
                    this.VatIds != null &&
                    input.VatIds != null &&
                    this.VatIds.SequenceEqual(input.VatIds)
                ) && 
                (
                    this.CustomerNumber == input.CustomerNumber ||
                    (this.CustomerNumber != null &&
                    this.CustomerNumber.Equals(input.CustomerNumber))
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
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.SalutationId != null)
                {
                    hashCode = (hashCode * 59) + this.SalutationId.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.VatIds != null)
                {
                    hashCode = (hashCode * 59) + this.VatIds.GetHashCode();
                }
                if (this.CustomerNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerNumber.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Salutation != null)
                {
                    hashCode = (hashCode * 59) + this.Salutation.GetHashCode();
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
            // SalutationId (string) pattern
            Regex regexSalutationId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalutationId.Match(this.SalutationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalutationId, must match a pattern of " + regexSalutationId, new [] { "SalutationId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // VersionId (string) pattern
            Regex regexVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexVersionId.Match(this.VersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VersionId, must match a pattern of " + regexVersionId, new [] { "VersionId" });
            }

            yield break;
        }
    }

}
