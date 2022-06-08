/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ShopwareSharp.Client.FileParameter;
using OpenAPIDateConverter = ShopwareSharp.Client.OpenAPIDateConverter;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// UnsubscribeToNewsletterRequest
    /// </summary>
    [DataContract(Name = "unsubscribeToNewsletter_request")]
    public partial class UnsubscribeToNewsletterRequest : IEquatable<UnsubscribeToNewsletterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribeToNewsletterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnsubscribeToNewsletterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribeToNewsletterRequest" /> class.
        /// </summary>
        /// <param name="email">Email address that should be removed from the mailing lists. (required).</param>
        public UnsubscribeToNewsletterRequest(string email = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for UnsubscribeToNewsletterRequest and cannot be null");
            }
            this._Email = email;
        }

        /// <summary>
        /// Email address that should be removed from the mailing lists.
        /// </summary>
        /// <value>Email address that should be removed from the mailing lists.</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email
        {
            get{ return _Email;}
            set
            {
                _Email = value;
                _flagEmail = true;
            }
        }
        private string _Email;
        private bool _flagEmail;

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return _flagEmail;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnsubscribeToNewsletterRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnsubscribeToNewsletterRequest);
        }

        /// <summary>
        /// Returns true if UnsubscribeToNewsletterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnsubscribeToNewsletterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsubscribeToNewsletterRequest input)
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