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
    /// ReadPaymentMethodRequest
    /// </summary>
    public partial class ReadPaymentMethodRequest : IEquatable<ReadPaymentMethodRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadPaymentMethodRequest" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="readPaymentMethodRequestAllOf"></param>
        public ReadPaymentMethodRequest(Criteria criteria, ReadPaymentMethodRequestAllOf readPaymentMethodRequestAllOf)
        {
            Criteria = criteria;
            ReadPaymentMethodRequestAllOf = readPaymentMethodRequestAllOf;
        }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Gets or Sets ReadPaymentMethodRequestAllOf
        /// </summary>
        public ReadPaymentMethodRequestAllOf ReadPaymentMethodRequestAllOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadPaymentMethodRequest {\n");
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
            return this.Equals(input as ReadPaymentMethodRequest);
        }

        /// <summary>
        /// Returns true if ReadPaymentMethodRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadPaymentMethodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadPaymentMethodRequest? input)
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
    /// A Json converter for type ReadPaymentMethodRequest
    /// </summary>
    public class ReadPaymentMethodRequestJsonConverter : JsonConverter<ReadPaymentMethodRequest>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(ReadPaymentMethodRequest).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ReadPaymentMethodRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader criteriaReader = reader;
            bool criteriaDeserialized = Client.ClientUtils.TryDeserialize<Criteria>(ref criteriaReader, options, out Criteria? criteria);

            Utf8JsonReader readPaymentMethodRequestAllOfReader = reader;
            bool readPaymentMethodRequestAllOfDeserialized = Client.ClientUtils.TryDeserialize<ReadPaymentMethodRequestAllOf>(ref readPaymentMethodRequestAllOfReader, options, out ReadPaymentMethodRequestAllOf? readPaymentMethodRequestAllOf);


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

            return new ReadPaymentMethodRequest(criteria, readPaymentMethodRequestAllOf);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="readPaymentMethodRequest"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ReadPaymentMethodRequest readPaymentMethodRequest, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}