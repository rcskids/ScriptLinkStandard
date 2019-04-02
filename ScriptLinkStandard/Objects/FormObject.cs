using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Objects
{
    /// <summary>
    /// Represents a ScriptLink FormObject within an <see cref="OptionObject"/>.
    /// </summary>
    public class FormObject : IEquatable<FormObject>, IFormObject
    {
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the CurrentRow property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="RowObject"/> containing the current row.</value>
        public RowObject CurrentRow { get; set; }
        /// <summary>
        /// Gets or sets the FormId propery of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>.</value>
        public string FormId { get; set; }
        /// <summary>
        /// Gets or sets the MultipleIteration property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="bool"/> indicating whether the Option includes a multiple iteration table.</value>
        public bool MultipleIteration { get; set; }
        /// <summary>
        /// Gets or sets the OtherRows property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="RowObject"/> containing all of the rows of a multiple iteration table.</value>
        public List<RowObject> OtherRows { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        //
        // Constructor
        //

        /// <summary>
        /// Creates a new ScriptLink <see cref="FormObject"/>.
        /// </summary>
        public FormObject()
        {
            this.OtherRows = new List<RowObject>();
        }

        public FormObject(string formId)
        {
            if (formId == null || formId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "formId");
            this.CurrentRow = null;
            this.FormId = formId;
            this.MultipleIteration = false;
            this.OtherRows = new List<RowObject>();
        }

        public FormObject(string formId, RowObject currentRow)
        {
            if (formId == null || formId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "formId");
            this.CurrentRow = currentRow ?? throw new ArgumentException("Parameter cannot be null", "currentRow");
            this.FormId = formId;
            this.MultipleIteration = false;
            this.OtherRows = new List<RowObject>();
        }

        public FormObject(string formId, RowObject currentRow, bool multipleIteration)
        {
            if (formId == null || formId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "formId");
            this.CurrentRow = currentRow ?? throw new ArgumentException("Parameter cannot be null", "currentRow");
            this.FormId = formId;
            this.MultipleIteration = multipleIteration;
            this.OtherRows = new List<RowObject>();
        }

        public FormObject(string formId, RowObject currentRow, bool multipleIteration, List<RowObject> otherRows)
        {
            if (formId == null || formId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "formId");
            this.CurrentRow = currentRow ?? throw new ArgumentException("Parameter cannot be null", "currentRow");
            this.FormId = formId;
            this.MultipleIteration = multipleIteration;
            this.OtherRows = otherRows ?? throw new ArgumentException("Parameter cannot be null.", "otherRows");
        }

        //
        // Private Properties
        //

        //
        // IEquatable<FormObject> Methods
        //

        /// <summary>
        /// Used to compare two <see cref="FormObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="CustomFormObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="FormObject"/> are equal.</returns>
        public bool Equals(FormObject other)
        {
            if (other == null)
                return false;
            return this.FormId == other.FormId &&
                   this.MultipleIteration == other.MultipleIteration &&
                   ((this.CurrentRow == null && other.CurrentRow == null) ||
                   this.CurrentRow.Equals(other.CurrentRow)) &&
                   AreRowsEqual(this.OtherRows, other.OtherRows);
        }
        private bool AreRowsEqual(List<RowObject> list1, List<RowObject> list2)
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

        private bool AreBothEmpty(List<RowObject> list1, List<RowObject> list2) => (!list1.Any() && !list2.Any());

        private bool AreBothNull(List<RowObject> list1, List<RowObject> list2) => (list1 == null && list2 == null);

        /// <summary>
        /// Used to compare <see cref="FormObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FormObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            FormObject formObject = obj as FormObject;
            if (formObject == null)
                return false;
            return this.Equals(formObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FormObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FormObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            string hash = this.FormId
                + delimiter + this.MultipleIteration.ToString();
            hash += this.CurrentRow != null ? delimiter + this.CurrentRow.GetHashCode().ToString() : "";
            if (this.OtherRows != null)
            {
                foreach (RowObject rowObject in this.OtherRows)
                {
                    hash += delimiter + rowObject.GetHashCode();
                }
            }
            return hash.GetHashCode();
        }

        public static bool operator ==(FormObject formObject1, FormObject formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return Object.Equals(formObject1, formObject2);

            return formObject1.Equals(formObject2);
        }

        public static bool operator !=(FormObject formObject1, FormObject formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return !Object.Equals(formObject1, formObject2);

            return !(formObject1.Equals(formObject2));
        }

        //
        // IFormObject Methods
        //

        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowObject"></param>
        public void AddRowObject(RowObject rowObject)
        {
            if (rowObject == null)
                return;
            IFormObject tempFormObject = ScriptLinkHelpers.AddRowObject(this, rowObject);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to the <see cref="CurrentRow"/> of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        public void AddRowObject(string rowId, string parentRowId)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.AddRowObject(this, rowId, parentRowId);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public void AddRowObject(string rowId, string parentRowId, string rowAction)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.AddRowObject(this, rowId, parentRowId, rowAction);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }

        /// <summary>
        /// Returns a deep copy of the <see cref="FormObject"/>.
        /// </summary>
        /// <returns></returns>
        public FormObject Clone() => (FormObject)ScriptLinkHelpers.Clone(this);

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(RowObject rowObject)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.DeleteRowObject(this, rowObject);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string rowId)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.DeleteRowObject(this, rowId);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }

        /// <summary>
        /// Returns the RowId of the <see cref="CurrentRow"/>.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentRowId() => ScriptLinkHelpers.GetCurrentRowId(this);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> in the CurrentRow of the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => ScriptLinkHelpers.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> in the <see cref="RowObject"/> of the <see cref="FormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string rowId, string fieldNumber) => ScriptLinkHelpers.GetFieldValue(this, rowId, fieldNumber);

        /// <summary>
        /// Returns a <see cref="List{T}"/> of FieldValues in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber) => ScriptLinkHelpers.GetFieldValues(this, fieldNumber);

        /// <summary>
        /// Returns the next available RowId of the <see cref="FormObject"/>.
        /// </summary>
        /// <returns></returns>
        public string GetNextAvailableRowId() => ScriptLinkHelpers.GetNextAvailableRowId(this);

        /// <summary>
        /// Returns the ParentRowId of the <see cref="CurrentRow"/>.
        /// </summary>
        /// <returns></returns>
        public string GetParentRowId() => ScriptLinkHelpers.GetParentRowId(this);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is enabled in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => ScriptLinkHelpers.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is locked in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => ScriptLinkHelpers.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is present in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => ScriptLinkHelpers.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is required in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => ScriptLinkHelpers.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="RowObject"/> is marked for deletion in the <see cref="FormObject"/> by RowId.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId) => ScriptLinkHelpers.IsRowMarkedForDeletion(this, rowId);

        /// <summary>
        /// Determines whether the <see cref="RowObject"/> is present in the <see cref="FormObject"/> by RowId.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId) => ScriptLinkHelpers.IsRowPresent(this, rowId);

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetDisabledField(this, fieldNumber);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetDisabledFields(this, fieldNumbers);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="CurrentRow"/> of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetFieldValue(this, fieldNumber, fieldValue);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string rowId, string fieldNumber, string fieldValue)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetFieldValue(this, rowId, fieldNumber, fieldValue);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetLockedField(this, fieldNumber);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as locked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetLockedFields(this, fieldNumbers);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as enabled and not required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetOptionalField(this, fieldNumber);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as enabled and not required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetOptionalFields(this, fieldNumbers);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as enabled and required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetRequiredField(this, fieldNumber);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as enabled and required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetRequiredFields(this, fieldNumbers);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as unlocked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetUnlockedField(this, fieldNumber);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as unlocked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = ScriptLinkHelpers.SetUnlockedFields(this, fieldNumbers);
            this.CurrentRow = tempFormObject.CurrentRow;
            this.OtherRows = tempFormObject.OtherRows;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted in HTML.</returns>
        public string ToHtmlString() => ScriptLinkHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted as JSON.</returns>
        public string ToJson() => ScriptLinkHelpers.TransformToJson(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted as XML.</returns>
        public string ToXml() => ScriptLinkHelpers.TransformToXml(this);
    }
}