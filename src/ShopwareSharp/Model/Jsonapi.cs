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
    /// An object describing the server&#39;s implementation
    /// </summary>
    [DataContract(Name = "jsonapi")]
    public partial class Jsonapi : IEquatable<Jsonapi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jsonapi" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="meta">Non-standard meta-information that can not be represented as an attribute or relationship..</param>
        public Jsonapi(string version = default(string), Dictionary<string, Object> meta = default(Dictionary<string, Object>))
        {
            this.__Version = version;
            if (this._Version != null)
            {
                this._flag_Version = true;
            }
            this._Meta = meta;
            if (this.Meta != null)
            {
                this._flagMeta = true;
            }
        }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version
        {
            get{ return __Version;}
            set
            {
                __Version = value;
                _flag_Version = true;
            }
        }
        private string __Version;
        private bool _flag_Version;

        /// <summary>
        /// Returns false as _Version should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerialize_Version()
        {
            return _flag_Version;
        }
        /// <summary>
        /// Non-standard meta-information that can not be represented as an attribute or relationship.
        /// </summary>
        /// <value>Non-standard meta-information that can not be represented as an attribute or relationship.</value>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Dictionary<string, Object> Meta
        {
            get{ return _Meta;}
            set
            {
                _Meta = value;
                _flagMeta = true;
            }
        }
        private Dictionary<string, Object> _Meta;
        private bool _flagMeta;

        /// <summary>
        /// Returns false as Meta should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMeta()
        {
            return _flagMeta;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Jsonapi {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as Jsonapi);
        }

        /// <summary>
        /// Returns true if Jsonapi instances are equal
        /// </summary>
        /// <param name="input">Instance of Jsonapi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Jsonapi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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