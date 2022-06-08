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
    /// Added since version: 6.1.0.0
    /// </summary>
    [DataContract(Name = "ProductCrossSelling")]
    public partial class ProductCrossSelling : IEquatable<ProductCrossSelling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCrossSelling" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductCrossSelling() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCrossSelling" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="sortDirection">sortDirection.</param>
        /// <param name="type">type (required).</param>
        /// <param name="active">active.</param>
        /// <param name="limit">limit.</param>
        /// <param name="translated">translated.</param>
        public ProductCrossSelling(string id = default(string), string name = default(string), long position = default(long), string sortBy = default(string), string sortDirection = default(string), string type = default(string), bool active = default(bool), long limit = default(long), Object translated = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProductCrossSelling and cannot be null");
            }
            this._Name = name;
            this._Position = position;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ProductCrossSelling and cannot be null");
            }
            this._Type = type;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._SortBy = sortBy;
            if (this.SortBy != null)
            {
                this._flagSortBy = true;
            }
            this._SortDirection = sortDirection;
            if (this.SortDirection != null)
            {
                this._flagSortDirection = true;
            }
            this._Active = active;
            if (this.Active != null)
            {
                this._flagActive = true;
            }
            this._Limit = limit;
            if (this.Limit != null)
            {
                this._flagLimit = true;
            }
            this._Translated = translated;
            if (this.Translated != null)
            {
                this._flagTranslated = true;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id
        {
            get{ return _Id;}
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name
        {
            get{ return _Name;}
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", IsRequired = true, EmitDefaultValue = false)]
        public long Position
        {
            get{ return _Position;}
            set
            {
                _Position = value;
                _flagPosition = true;
            }
        }
        private long _Position;
        private bool _flagPosition;

        /// <summary>
        /// Returns false as Position should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePosition()
        {
            return _flagPosition;
        }
        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name = "sortBy", EmitDefaultValue = false)]
        public string SortBy
        {
            get{ return _SortBy;}
            set
            {
                _SortBy = value;
                _flagSortBy = true;
            }
        }
        private string _SortBy;
        private bool _flagSortBy;

        /// <summary>
        /// Returns false as SortBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortBy()
        {
            return _flagSortBy;
        }
        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public string SortDirection
        {
            get{ return _SortDirection;}
            set
            {
                _SortDirection = value;
                _flagSortDirection = true;
            }
        }
        private string _SortDirection;
        private bool _flagSortDirection;

        /// <summary>
        /// Returns false as SortDirection should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortDirection()
        {
            return _flagSortDirection;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type
        {
            get{ return _Type;}
            set
            {
                _Type = value;
                _flagType = true;
            }
        }
        private string _Type;
        private bool _flagType;

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return _flagType;
        }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active
        {
            get{ return _Active;}
            set
            {
                _Active = value;
                _flagActive = true;
            }
        }
        private bool _Active;
        private bool _flagActive;

        /// <summary>
        /// Returns false as Active should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActive()
        {
            return _flagActive;
        }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public long Limit
        {
            get{ return _Limit;}
            set
            {
                _Limit = value;
                _flagLimit = true;
            }
        }
        private long _Limit;
        private bool _flagLimit;

        /// <summary>
        /// Returns false as Limit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLimit()
        {
            return _flagLimit;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Translated
        /// </summary>
        [DataMember(Name = "translated", EmitDefaultValue = false)]
        public Object Translated
        {
            get{ return _Translated;}
            set
            {
                _Translated = value;
                _flagTranslated = true;
            }
        }
        private Object _Translated;
        private bool _flagTranslated;

        /// <summary>
        /// Returns false as Translated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTranslated()
        {
            return _flagTranslated;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductCrossSelling {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
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
            return this.Equals(input as ProductCrossSelling);
        }

        /// <summary>
        /// Returns true if ProductCrossSelling instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductCrossSelling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductCrossSelling input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.SortDirection == input.SortDirection ||
                    (this.SortDirection != null &&
                    this.SortDirection.Equals(input.SortDirection))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.SortBy != null)
                {
                    hashCode = (hashCode * 59) + this.SortBy.GetHashCode();
                }
                if (this.SortDirection != null)
                {
                    hashCode = (hashCode * 59) + this.SortDirection.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
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