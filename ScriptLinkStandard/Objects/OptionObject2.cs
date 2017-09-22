using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Objects
{
    /// <summary>
    /// Represents a ScriptLink OptionObject2.
    /// </summary>
    public class OptionObject2 : IEquatable<OptionObject2>, IOptionObject2
    {
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the EntityID property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and can contain a myAvatar PATID, STAFFID, USERID, or INCID.</value>
        public string EntityID { get; set; }
        /// <summary>
        /// Gets or sets the Episode Number property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used with episodic, patient OptionObjects.</value>
        public double EpisodeNumber { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used upon return to myAvatar to determine prompted response. Possible values include 0, 1, 2, 3, 4, and 5 as string values.</value>
        public double ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMesg property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used to display a message to the user in myAvatar for ErrorCodes 1-4.</value>
        public string ErrorMesg { get; set; }
        /// <summary>
        /// Gets or sets the Facility property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. For most organizations, this value is 1, however more complex security configurations will utilize additional values.</value>
        public string Facility { get; set; }
        /// <summary>
        /// Gets or sets the Forms property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="FormObject"/> .</value>
        public List<FormObject> Forms { get; set; }
        /// <summary>
        /// Gets or sets the NamespaceName property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the namespace name of the Option in the myAvatar system.</value>
        public string NamespaceName { get; set; }
        /// <summary>
        /// Gets or sets the OptionId property of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the unique identifier of the Option in the myAvatar system.</value>
        public string OptionId { get; set; }
        /// <summary>
        /// Gets or sets the OptionStaffId object of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the staff Id of the current myAvatar user.</value>
        public string OptionStaffId { get; set; }
        /// <summary>
        /// Gets or sets the OptionUserId object of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the user id of the current myAvatar user.</value>
        public string OptionUserId { get; set; }
        /// <summary>
        /// Gets or sets the ParentNamespace object of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Parent Namespace.</value>
        public string ParentNamespace { get; set; }
        /// <summary>
        /// Gets or sets the ServerName object of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Server Name.</value>
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the SystemCode object of the <see cref="OptionObject2"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the System Code. The value may be SBOX, BLD, UAT, or LIVE.</value>
        public string SystemCode { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        //
        // Constructor
        //

        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject2"/>.
        /// </summary>
        public OptionObject2()
        {
            this.Forms = new List<FormObject>();
        }

        //
        // Private Properties
        //

        //
        // IEquatable<FormObject> Methods
        //

        /// <summary>
        /// Used to compare two <see cref="OptionObject2"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="OptionObject2"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="OptionObject2"/> are equal.</returns>
        public bool Equals(OptionObject2 other)
        {
            if (other == null)
                return false;
            return this.EntityID == other.EntityID &&
                this.EpisodeNumber == other.EpisodeNumber &&
                this.ErrorCode == other.ErrorCode &&
                this.ErrorMesg == other.ErrorMesg &&
                this.Facility == other.Facility &&
                this.OptionId == other.OptionId &&
                this.OptionStaffId == other.OptionStaffId &&
                this.OptionUserId == other.OptionUserId &&
                this.SystemCode == other.SystemCode &&
                AreFormsEqual(this.Forms, other.Forms);

        }

        private bool AreFormsEqual(List<FormObject> list1, List<FormObject> list2)
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

        private bool AreBothEmpty(List<FormObject> list1, List<FormObject> list2)
        {
            return (!list1.Any() && !list2.Any());
        }

        private bool AreBothNull(List<FormObject> list1, List<FormObject> list2)
        {
            return (list1 == null && list2 == null);
        }

        /// <summary>
        /// Used to compare <see cref="OptionObject2"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="OptionObject2"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            OptionObject2 optionObject = obj as OptionObject2;
            if (optionObject == null)
                return false;
            return this.Equals(optionObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="OptionObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="OptionObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            string hash = this.EntityID
                + delimiter + this.EpisodeNumber.ToString()
                + delimiter + this.ErrorCode.ToString()
                + delimiter + this.ErrorMesg
                + delimiter + this.Facility
                + delimiter + this.NamespaceName
                + delimiter + this.OptionId
                + delimiter + this.OptionStaffId
                + delimiter + this.OptionUserId
                + delimiter + this.ParentNamespace
                + delimiter + this.ServerName
                + delimiter + this.SystemCode;
            foreach (FormObject formObject in this.Forms)
            {
                hash += delimiter + formObject.GetHashCode();
            }
            return hash.GetHashCode();
        }

        public static bool operator ==(OptionObject2 optionObject1, OptionObject2 optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return Object.Equals(optionObject1, optionObject2);

            return optionObject1.Equals(optionObject2);
        }

        public static bool operator !=(OptionObject2 optionObject1, OptionObject2 optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return !Object.Equals(optionObject1, optionObject2);

            return !(optionObject1.Equals(optionObject2));
        }

        //
        // IOptionObject2 Methods
        //

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObject formObject)
        {
            if (formObject == null)
                return;
            this.Forms = ScriptLinkHelpers.AddFormObject(this, formObject).Forms;
        }
        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        public void AddFormObject(string formId, bool multipleIteration)
        {
            if (formId == null || formId == "")
                return;
            this.Forms = ScriptLinkHelpers.AddFormObject(this, formId, multipleIteration).Forms;
        }
        /// <summary>
        /// Returns the CurrentRow RowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetCurrentRowId(string formId)
        {
            return ScriptLinkHelpers.GetCurrentRowId(this, formId);
        }
        /// <summary>
        /// Returns the first value of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber)
        {
            return ScriptLinkHelpers.GetFieldValue(this, fieldNumber);
        }
        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string formId, string rowId, string fieldNumber)
        {
            return ScriptLinkHelpers.GetFieldValue(this, formId, rowId, fieldNumber);
        }
        /// <summary>
        /// Returns the values of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber)
        {
            return ScriptLinkHelpers.GetFieldValues(this, fieldNumber);
        }
        /// <summary>
        /// Returns the Multiple Iteration Status of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool GetMultipleIterationStatus(string formId)
        {
            return ScriptLinkHelpers.GetMultipleIterationStatus(this, formId);
        }
        /// <summary>
        /// Returns the CurrentRow ParentRowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetParentRowId(string formId)
        {
            return ScriptLinkHelpers.GetParentRowId(this, formId);
        }
        
        /// <summary>
        /// Returns whether the specified field is enabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldEnabled(this, fieldNumber);
        }
        /// <summary>
        /// Returns whether the specified field is locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldLocked(this, fieldNumber);
        }
        /// <summary>
        /// Returns whether the specified field is present.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldPresent(this, fieldNumber);
        }
        /// <summary>
        /// Returns whether the specified field is required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber)
        {
            return ScriptLinkHelpers.IsFieldRequired(this, fieldNumber);
        }

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers)
        {
            this.Forms = ScriptLinkHelpers.SetDisabledFields(this, fieldNumbers).Forms;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject"/> on the first form CurrentRow.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue)
        {
            this.Forms = ScriptLinkHelpers.SetFieldValue(this, fieldNumber, fieldValue).Forms;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject2"/> 
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue)
        {
            this.Forms = ScriptLinkHelpers.SetFieldValue(this, formId, rowId, fieldNumber, fieldValue).Forms;
        }
        /// <summary>
        /// Set the specified fields as locked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers)
        {
            this.Forms = ScriptLinkHelpers.SetLockedFields(this, fieldNumbers).Forms;
        }
        /// <summary>
        /// Set the specified fields as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers)
        {
            this.Forms = ScriptLinkHelpers.SetOptionalFields(this, fieldNumbers).Forms;
        }
        /// <summary>
        /// Sets the specified fields as required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers)
        {
            this.Forms = ScriptLinkHelpers.SetRequiredFields(this, fieldNumbers).Forms;
        }
        /// <summary>
        /// Set the specified fields as unlocked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers)
        {
            this.Forms = ScriptLinkHelpers.SetUnlockedFields(this, fieldNumbers).Forms;
        }
        
        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders)
        {
            return ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);
        }
        /// <summary>
        /// Transforms the <see cref="OptionObject2"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject ToOptionObject()
        {
            return ScriptLinkHelpers.TransformToOptionObject(this);
        }
        /// <summary>
        /// Creates an <see cref="OptionObject2"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public OptionObject2 ToReturnOptionObject()
        {
            return ScriptLinkHelpers.GetReturnOptionObject(this);
        }
        /// <summary>
        /// Creates an <see cref="OptionObject2"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public OptionObject2 ToReturnOptionObject(int errorCode, string errorMessage)
        {
            return ScriptLinkHelpers.GetReturnOptionObject(this, errorCode, errorMessage);
        }
    }
}