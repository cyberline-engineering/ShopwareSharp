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
    /// SearchSuggestRequest
    /// </summary>
    public partial class SearchSuggestRequest : IEquatable<SearchSuggestRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSuggestRequest" /> class.
        /// </summary>
        /// <param name="productListingFlags"></param>
        /// <param name="searchPageRequestAllOf"></param>
        public SearchSuggestRequest(ProductListingFlags productListingFlags, SearchPageRequestAllOf searchPageRequestAllOf)
        {
            ProductListingFlags = productListingFlags;
            SearchPageRequestAllOf = searchPageRequestAllOf;
        }

        /// <summary>
        /// Gets or Sets ProductListingFlags
        /// </summary>
        public ProductListingFlags ProductListingFlags { get; set; }

        /// <summary>
        /// Gets or Sets SearchPageRequestAllOf
        /// </summary>
        public SearchPageRequestAllOf SearchPageRequestAllOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchSuggestRequest {\n");
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
            return this.Equals(input as SearchSuggestRequest);
        }

        /// <summary>
        /// Returns true if SearchSuggestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchSuggestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSuggestRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return false;
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

    /// <summary>
    /// A Json converter for type SearchSuggestRequest
    /// </summary>
    public class SearchSuggestRequestJsonConverter : JsonConverter<SearchSuggestRequest>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(SearchSuggestRequest).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SearchSuggestRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader productListingFlagsReader = reader;
            bool productListingFlagsDeserialized = Client.ClientUtils.TryDeserialize<ProductListingFlags>(ref productListingFlagsReader, options, out ProductListingFlags? productListingFlags);

            Utf8JsonReader searchPageRequestAllOfReader = reader;
            bool searchPageRequestAllOfDeserialized = Client.ClientUtils.TryDeserialize<SearchPageRequestAllOf>(ref searchPageRequestAllOfReader, options, out SearchPageRequestAllOf? searchPageRequestAllOf);


            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                    }
                }
            }

            return new SearchSuggestRequest(productListingFlags, searchPageRequestAllOf);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="searchSuggestRequest"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SearchSuggestRequest searchSuggestRequest, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}