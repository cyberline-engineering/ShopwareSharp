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
    /// Added since version: 6.0.0.0
    /// </summary>
    [DataContract(Name = "PropertyGroup")]
    public partial class PropertyGroup : IEquatable<PropertyGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGroup" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="displayType">displayType (required).</param>
        /// <param name="sortingType">sortingType (required).</param>
        /// <param name="filterable">filterable.</param>
        /// <param name="visibleOnProductDetailPage">visibleOnProductDetailPage.</param>
        /// <param name="position">position.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="translated">translated.</param>
        /// <param name="options">options.</param>
        public PropertyGroup(string id = default(string), string name = default(string), string description = default(string), string displayType = default(string), string sortingType = default(string), bool filterable = default(bool), bool visibleOnProductDetailPage = default(bool), long position = default(long), Object customFields = default(Object), Object translated = default(Object), PropertyGroupOption options = default(PropertyGroupOption))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PropertyGroup and cannot be null");
            }
            this._Name = name;
            // to ensure "displayType" is required (not null)
            if (displayType == null)
            {
                throw new ArgumentNullException("displayType is a required property for PropertyGroup and cannot be null");
            }
            this._DisplayType = displayType;
            // to ensure "sortingType" is required (not null)
            if (sortingType == null)
            {
                throw new ArgumentNullException("sortingType is a required property for PropertyGroup and cannot be null");
            }
            this._SortingType = sortingType;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Description = description;
            if (this.Description != null)
            {
                this._flagDescription = true;
            }
            this._Filterable = filterable;
            if (this.Filterable != null)
            {
                this._flagFilterable = true;
            }
            this._VisibleOnProductDetailPage = visibleOnProductDetailPage;
            if (this.VisibleOnProductDetailPage != null)
            {
                this._flagVisibleOnProductDetailPage = true;
            }
            this._Position = position;
            if (this.Position != null)
            {
                this._flagPosition = true;
            }
            this._CustomFields = customFields;
            if (this.CustomFields != null)
            {
                this._flagCustomFields = true;
            }
            this._Translated = translated;
            if (this.Translated != null)
            {
                this._flagTranslated = true;
            }
            this._Options = options;
            if (this.Options != null)
            {
                this._flagOptions = true;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description
        {
            get{ return _Description;}
            set
            {
                _Description = value;
                _flagDescription = true;
            }
        }
        private string _Description;
        private bool _flagDescription;

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return _flagDescription;
        }
        /// <summary>
        /// Gets or Sets DisplayType
        /// </summary>
        [DataMember(Name = "displayType", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayType
        {
            get{ return _DisplayType;}
            set
            {
                _DisplayType = value;
                _flagDisplayType = true;
            }
        }
        private string _DisplayType;
        private bool _flagDisplayType;

        /// <summary>
        /// Returns false as DisplayType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayType()
        {
            return _flagDisplayType;
        }
        /// <summary>
        /// Gets or Sets SortingType
        /// </summary>
        [DataMember(Name = "sortingType", IsRequired = true, EmitDefaultValue = false)]
        public string SortingType
        {
            get{ return _SortingType;}
            set
            {
                _SortingType = value;
                _flagSortingType = true;
            }
        }
        private string _SortingType;
        private bool _flagSortingType;

        /// <summary>
        /// Returns false as SortingType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortingType()
        {
            return _flagSortingType;
        }
        /// <summary>
        /// Gets or Sets Filterable
        /// </summary>
        [DataMember(Name = "filterable", EmitDefaultValue = true)]
        public bool Filterable
        {
            get{ return _Filterable;}
            set
            {
                _Filterable = value;
                _flagFilterable = true;
            }
        }
        private bool _Filterable;
        private bool _flagFilterable;

        /// <summary>
        /// Returns false as Filterable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFilterable()
        {
            return _flagFilterable;
        }
        /// <summary>
        /// Gets or Sets VisibleOnProductDetailPage
        /// </summary>
        [DataMember(Name = "visibleOnProductDetailPage", EmitDefaultValue = true)]
        public bool VisibleOnProductDetailPage
        {
            get{ return _VisibleOnProductDetailPage;}
            set
            {
                _VisibleOnProductDetailPage = value;
                _flagVisibleOnProductDetailPage = true;
            }
        }
        private bool _VisibleOnProductDetailPage;
        private bool _flagVisibleOnProductDetailPage;

        /// <summary>
        /// Returns false as VisibleOnProductDetailPage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVisibleOnProductDetailPage()
        {
            return _flagVisibleOnProductDetailPage;
        }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
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
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "customFields", EmitDefaultValue = false)]
        public Object CustomFields
        {
            get{ return _CustomFields;}
            set
            {
                _CustomFields = value;
                _flagCustomFields = true;
            }
        }
        private Object _CustomFields;
        private bool _flagCustomFields;

        /// <summary>
        /// Returns false as CustomFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomFields()
        {
            return _flagCustomFields;
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
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public PropertyGroupOption Options
        {
            get{ return _Options;}
            set
            {
                _Options = value;
                _flagOptions = true;
            }
        }
        private PropertyGroupOption _Options;
        private bool _flagOptions;

        /// <summary>
        /// Returns false as Options should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOptions()
        {
            return _flagOptions;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  SortingType: ").Append(SortingType).Append("\n");
            sb.Append("  Filterable: ").Append(Filterable).Append("\n");
            sb.Append("  VisibleOnProductDetailPage: ").Append(VisibleOnProductDetailPage).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as PropertyGroup);
        }

        /// <summary>
        /// Returns true if PropertyGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyGroup input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DisplayType != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayType.GetHashCode();
                }
                if (this.SortingType != null)
                {
                    hashCode = (hashCode * 59) + this.SortingType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Filterable.GetHashCode();
                hashCode = (hashCode * 59) + this.VisibleOnProductDetailPage.GetHashCode();
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
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