using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;
//using System.Xml.Serialization;

namespace ScriptLinkStandard.Objects
{
    /// <summary>
    /// Represents a ScriptLink FieldObject within a <see cref="RowObject"/>.
    /// </summary>
    public class FieldObject : IEquatable<FieldObject>, IFieldObject
    {
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the Enabled property of a <see cref="FieldObject"/>. Use with <see cref="SetAsModified"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Disabled. 1 = Enabled.</value>
        public string Enabled { get; set; }
        /// <summary>
        /// Gets or sets the FieldNumber property of a <see cref="FieldObject"/>. Use with <see cref="SetAsModified"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the field number. This is typically a value like 12345.6 or 12345.67.</value>
        public string FieldNumber { get; set; }
        /// <summary>
        /// Gets or sets the FieldValue property of a <see cref="FieldObject"/>. Use with <see cref="SetAsModified"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing the value entered (or to be entered) in the field.</value>
        public string FieldValue { get; set; }
        /// <summary>
        /// Gets or sets the Lock property of a <see cref="FieldObject"/>. Use with <see cref="SetAsModified"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Unlocked. 1 = Locked.</value>
        public string Lock { get; set; }
        /// <summary>
        /// Gets or sets the Required property of a <see cref="FieldObject"/>. Use with <see cref="SetAsModified"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Not required. 1 = Required.</value>
        public string Required { get; set; }

        //
        // Begin Test Customizations (public properties requiring [XmlIgnore])
        // Requires .NET Standard 2.0 or greater
        //

        /*
        [XmlIgnore]
        public bool IsModified
        {
            get
            {
                return _isModified;
            }
        }
        */

        //
        // Begin Customizations (only methods and private properties)
        //

        //
        // Constructors
        //

        /// <summary>
        /// Creates an empty <see cref="FieldObject"/>.
        /// </summary>
        public FieldObject()
        {
            Enabled = "0";
            FieldNumber = "";
            FieldValue = "";
            Lock = "0";
            Required = "0";
        }
        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public FieldObject(string fieldNumber)
        {
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentException("Parameter cannot be null or blank", "fieldNumber");
            Enabled = "0";
            FieldNumber = fieldNumber;
            FieldValue = "";
            Lock = "0";
            Required = "0";
        }
        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/> and <see cref="FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public FieldObject(string fieldNumber, string fieldValue)
        {
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentException("Parameter cannot be null or blank", "fieldNumber");
            Enabled = "0";
            FieldNumber = fieldNumber;
            FieldValue = fieldValue;
            Lock = "0";
            Required = "0";
        }
        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/> and <see cref="FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabled"></param>
        /// <param name="locked"></param>
        /// <param name="required"></param>
        public FieldObject(string fieldNumber, string fieldValue, bool enabled, bool locked, bool required)
        {
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentException("Parameter cannot be null or blank", "fieldNumber");
            Enabled = enabled ? "1" : "0";
            FieldNumber = fieldNumber;
            FieldValue = fieldValue;
            Lock = locked ? "1" : "0";
            Required = required ? "1" : "0";
        }

        //
        // Private Properties
        //
        private bool _isModified { get; set; }

        //
        // IEquatable<FieldObject> Methods
        //

        /// <summary>
        /// Used to compare two <see cref="FieldObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="FieldObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether two <see cref="FieldObject"/> are equal.</returns>
        public bool Equals(FieldObject other)
        {
            if (other == null)
                return false;
            return this.FieldValue == other.FieldValue &&
                this.Required == other.Required &&
                this.Enabled == other.Enabled &&
                this.FieldNumber == other.FieldNumber &&
                this.Lock == other.Lock;
        }
        /// <summary>
        /// Used to compare <see cref="FieldObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FieldObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            FieldObject fieldObject = obj as FieldObject;
            if (fieldObject == null)
                return false;
            return this.Equals(fieldObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FieldObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FieldObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            string hash = this.FieldNumber
                + delimiter + this.FieldValue
                + delimiter + this.Enabled
                + delimiter + this.Lock
                + delimiter + this.Required;
            return hash.GetHashCode();
        }

        public static bool operator ==(FieldObject fieldObject1, FieldObject fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return Object.Equals(fieldObject1, fieldObject2);

            return fieldObject1.Equals(fieldObject2);
        }

        public static bool operator !=(FieldObject fieldObject1, FieldObject fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return !Object.Equals(fieldObject1, fieldObject2);

            return !(fieldObject1.Equals(fieldObject2));
        }

        //
        // IFieldObject Methods
        //

        /// <summary>
        /// Returns a copy of the <see cref="FieldObject"/>.
        /// </summary>
        /// <returns></returns>
        public FieldObject Clone() => (FieldObject)ScriptLinkHelpers.Clone(this);

        /// <summary>
        /// Returns the <see cref="FieldValue"/> of a <see cref="FieldObject"/>
        /// </summary>
        /// <returns></returns>
        public string GetFieldValue() => this.FieldValue;

        /// <summary>
        /// Determines whether <see cref="FieldObject"/> is enabled.
        /// </summary>
        /// <returns></returns>
        public bool IsEnabled() => this.Enabled == "1" ? true : false;

        /// <summary>
        /// Determines whether <see cref="FieldObject"/> is enabled.
        /// </summary>
        /// <returns></returns>
        public bool IsLocked() => this.Lock == "1" ? true : false;

        /// <summary>
        /// Returns whether the <see cref="FieldObject"/> has been modified.
        /// </summary>
        /// <returns></returns>
        public bool IsModified() => _isModified;

        /// <summary>
        /// Determines whether <see cref="FieldObject"/> is enabled.
        /// </summary>
        /// <returns></returns>
        public bool IsRequired() => this.Required == "1" ? true : false;

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as disabled and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsDisabled()
        {
            _isModified = true;
            this.Enabled = "0";
            this.Required = "0";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as enabled and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsEnabled()
        {
            _isModified = true;
            this.Enabled = "1";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as locked and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsLocked()
        {
            _isModified = true;
            this.Lock = "1";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsModified() => _isModified = true;

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as optional and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsOptional()
        {
            _isModified = true;
            this.Enabled = "1";
            this.Required = "0";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as required and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsRequired()
        {
            _isModified = true;
            this.Enabled = "1";
            this.Required = "1";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as unlocked and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsUnlocked()
        {
            _isModified = true;
            this.Lock = "0";
        }

        /// <summary>
        /// Sets the <see cref="FieldValue"/> of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldValue)
        {
            _isModified = true;
            this.FieldValue = fieldValue;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted in HTML.</returns>
        public string ToHtmlString() => ScriptLinkHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted as JSON.</returns>
        public string ToJson() => ScriptLinkHelpers.TransformToJson(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted as XML.</returns>
        public string ToXml() => ScriptLinkHelpers.TransformToXml(this);
    }
}
