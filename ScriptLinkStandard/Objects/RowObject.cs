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

        private bool AreBothEmpty(List<FieldObject> list1, List<FieldObject> list2)
        {
            return (!list1.Any() && !list2.Any());
        }

        private bool AreBothNull(List<FieldObject> list1, List<FieldObject> list2)
        {
            return (list1 == null && list2 == null);
        }

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
        /// Returns the value of a <see cref="FieldObject"/> in a <see cref="RowObject"/> 
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber)
        {
            return ScriptLinkHelpers.GetFieldValue(this, fieldNumber);
        }
        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is enabled in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldEnabled(this, fieldNumber);
        }
        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is locked in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldLocked(this, fieldNumber);
        }
        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is present in <see cref="RowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldPresent(this, fieldNumber);
        }
        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is required in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldRequired(this, fieldNumber);
        }
        /// <summary>
        /// Removes any unmodified <see cref="FieldObject"/> from the <see cref="RowObject"/>.
        /// </summary>
        public void RemoveUnmodifiedFieldObjects()
        {
            Fields.RemoveAll(f => f.IsModified() == false);
        }
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldNumber, string fieldValue)
        {
            this.Fields = ScriptLinkHelpers.SetFieldValue(this, fieldNumber, fieldValue).Fields;
        }
        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders)
        {
            return ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);
        }
    }
}