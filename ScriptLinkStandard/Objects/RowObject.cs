using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Objects
{
    /// <summary>
    /// Represents a ScriptLink RowObject contained within a <see cref="FormObject"/>.
    /// </summary>
    public class RowObject : IEquatable<RowObject>, IRowObject
    {
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the Fields property of the <see cref="RowObject"/> 
        /// </summary>
        /// <value>This value is a <see cref="List{T}"/> of <see cref="FieldObject"/>.</value>
        public List<FieldObject> Fields { get; set; }
        /// <summary>
        /// Gets or sets the ParentRowId property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and references the <see cref="RowId"/> of the <see cref="FormObject.CurrentRow"/> of the enclosing <see cref="FormObject"/>.</value>
        public string ParentRowId { get; set; }
        /// <summary>
        /// Gets or sets the RowAction property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing ADD, EDIT, or DELETE. Other values are invalid.</value>
        public string RowAction { get; set; }
        /// <summary>
        /// Gets or sets the RowId property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing the unique Id for the row.</value>
        public string RowId { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        //
        // Constructor
        //

        /// <summary>
        /// Creates a new <see cref="RowObject"/>. 
        /// </summary>
        public RowObject()
        {
            this.Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        public RowObject(string rowId)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            this.RowAction = "";
            this.ParentRowId = "";
            this.RowId = rowId;
            this.Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="ParentRowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        public RowObject(string rowId, string parentRowId)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (parentRowId == null || parentRowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "parentRowId");
            this.RowAction = "";
            this.ParentRowId = parentRowId;
            this.RowId = rowId;
            this.Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>, <see cref="ParentRowId"/>, and <see cref="RowAction"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public RowObject(string rowId, string parentRowId, string rowAction)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (parentRowId == null || parentRowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "parentRowId");
            if (!ScriptLinkHelpers.IsValidRowAction(rowAction))
                throw new ArgumentException("Parameter is not valid.", "rowAction");
            this.RowAction = rowAction;
            this.ParentRowId = parentRowId;
            this.RowId = rowId;
            this.Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            this.RowAction = "";
            this.ParentRowId = "";
            this.RowId = rowId;
            this.Fields = fieldObjects ?? throw new ArgumentException("Parameter cannot be null.", "fieldObjects");
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects, string parentRowId)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (parentRowId == null || parentRowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "parentRowId");
            this.RowAction = "";
            this.ParentRowId = parentRowId;
            this.RowId = rowId;
            this.Fields = fieldObjects ?? throw new ArgumentException("Parameter cannot be null.", "fieldObjects");
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects, string parentRowId, string rowAction)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (parentRowId == null || parentRowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "parentRowId");
            if (!ScriptLinkHelpers.IsValidRowAction(rowAction))
                throw new ArgumentException("Parameter is not valid.", "rowAction");
            this.RowAction = rowAction;
            this.ParentRowId = parentRowId;
            this.RowId = rowId;
            this.Fields = fieldObjects ?? throw new ArgumentException("Parameter cannot be null.", "fieldObjects");
        }

        //
        // Private Properties
        //

        //
        // IEquatable<RowObject> Methods
        //

        /// <summary>
        /// Used to compare two <see cref="RowObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="RowObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="RowObject"/> are equal.</returns>
        public bool Equals(RowObject other)
        {
            if (other == null)
                return false;
            return this.ParentRowId == other.ParentRowId &&
                ((this.RowAction == null && other.RowAction == null) ||
                this.RowAction == other.RowAction) &&
                this.RowId == other.RowId &&
                AreFieldsEqual(this.Fields, other.Fields);
        }

        private bool AreFieldsEqual(List<FieldObject> list1, List<FieldObject> list2)
        {
            if (!AreBothNull(list1, list2) && AreBothEmpty(list1, list2))
                return true;
            if (list1.Count != list2.Count)
                return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool AreBothEmpty(List<FieldObject> list1, List<FieldObject> list2) => (!list1.Any() && !list2.Any());

        private bool AreBothNull(List<FieldObject> list1, List<FieldObject> list2) => (list1 == null && list2 == null);

        /// <summary>
        /// Used to compare <see cref="RowObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="RowObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            RowObject rowObject = obj as RowObject;
            if (rowObject == null)
                return false;
            return this.Equals(rowObject);
        }
        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="RowObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="RowObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            string hash = this.ParentRowId
                + delimiter + this.RowAction
                + delimiter + this.RowId;
            foreach (FieldObject fieldObject in this.Fields)
            {
                hash += delimiter + fieldObject.GetHashCode();
            }
            return hash.GetHashCode();
        }

        public static bool operator ==(RowObject rowObject1, RowObject rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return Object.Equals(rowObject1, rowObject2);

            return rowObject1.Equals(rowObject2);
        }

        public static bool operator !=(RowObject rowObject1, RowObject rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return !Object.Equals(rowObject1, rowObject2);

            return !(rowObject1.Equals(rowObject2));
        }


        //
        // IRowObject Methods
        //

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        public void AddFieldObject(FieldObject fieldObject) => this.Fields = ScriptLinkHelpers.AddFieldObject(this, fieldObject).Fields;

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/> with the provided <see cref="FieldObject.FieldNumber"/> and <see cref="FieldObject.FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="fieldValue">A <see cref="string"/> containing the <see cref="FieldObject.FieldValue"/> of the <see cref="FieldObject"/>.</param>
        public void AddFieldObject(string fieldNumber, string fieldValue) => this.Fields = ScriptLinkHelpers.AddFieldObject(this, fieldNumber, fieldValue).Fields;

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/> with the provided property values.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="fieldValue">A <see cref="string"/> containing the <see cref="FieldObject.FieldValue"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="enabledValue">A <see cref="string"/> containing the <see cref="FieldObject.Enabled"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="lockedValue">A <see cref="string"/> containing the <see cref="FieldObject.Lock"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="requiredValue">A <see cref="string"/> containing the <see cref="FieldObject.Required"/> of the <see cref="FieldObject"/>.</param>
        public void AddFieldObject(string fieldNumber, string fieldValue, string enabledValue, string lockedValue, string requiredValue) => this.Fields = ScriptLinkHelpers.AddFieldObject(this, fieldNumber, fieldValue, enabledValue, lockedValue, requiredValue).Fields;

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/> with the provided property values.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="fieldValue">A <see cref="string"/> containing the <see cref="FieldObject.FieldValue"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="enabled">A <see cref="bool"/> containing the <see cref="FieldObject.Enabled"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="locked">A <see cref="bool"/> containing the <see cref="FieldObject.Lock"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="required">A <see cref="bool"/> containing the <see cref="FieldObject.Required"/> of the <see cref="FieldObject"/>.</param>
        public void AddFieldObject(string fieldNumber, string fieldValue, bool enabled, bool locked, bool required) => this.Fields = ScriptLinkHelpers.AddFieldObject(this, fieldNumber, fieldValue, enabled, locked, required).Fields;

        /// <summary>
        /// Returns a deep copy of the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public RowObject Clone() => (RowObject)ScriptLinkHelpers.Clone(this);

        /// <summary>
        /// Returns the value of a <see cref="FieldObject"/> in a <see cref="RowObject"/> 
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => ScriptLinkHelpers.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is enabled in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => ScriptLinkHelpers.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is locked in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => ScriptLinkHelpers.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is present in <see cref="RowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => ScriptLinkHelpers.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is required in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => ScriptLinkHelpers.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Removes a <see cref="FieldObject"/> from a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldObject">The <see cref="FieldObject"/> to remove.</param>
        public void RemoveFieldObject(FieldObject fieldObject) => this.Fields = ScriptLinkHelpers.RemoveFieldObject(this, fieldObject).Fields;

        /// <summary>
        /// Removes a <see cref="FieldObject"/> from a <see cref="RowObject"/> by <see cref="FieldObject.FieldNumber"/>.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> to remove.</param>
        public void RemoveFieldObject(string fieldNumber) => this.Fields = ScriptLinkHelpers.RemoveFieldObject(this, fieldNumber).Fields;

        /// <summary>
        /// Removes any unmodified <see cref="FieldObject"/> from the <see cref="RowObject"/>.
        /// </summary>
        public void RemoveUnmodifiedFieldObjects() => Fields.RemoveAll(f => f.IsModified() == false);

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber) => this.Fields = ScriptLinkHelpers.SetDisabledField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers) => this.Fields = ScriptLinkHelpers.SetDisabledFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldNumber, string fieldValue) => this.Fields = ScriptLinkHelpers.SetFieldValue(this, fieldNumber, fieldValue).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber) => this.Fields = ScriptLinkHelpers.SetLockedField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers) => this.Fields = ScriptLinkHelpers.SetLockedFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber) => this.Fields = ScriptLinkHelpers.SetOptionalField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers) => this.Fields = ScriptLinkHelpers.SetOptionalFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber) => this.Fields = ScriptLinkHelpers.SetRequiredField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers) => this.Fields = ScriptLinkHelpers.SetRequiredFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber) => this.Fields = ScriptLinkHelpers.SetUnlockedField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers) => this.Fields = ScriptLinkHelpers.SetUnlockedFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted in HTML.</returns>
        public string ToHtmlString() => ScriptLinkHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted as JSON.</returns>
        public string ToJson() => ScriptLinkHelpers.TransformToJson(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted as XML.</returns>
        public string ToXml() => ScriptLinkHelpers.TransformToXml(this);
    }
}