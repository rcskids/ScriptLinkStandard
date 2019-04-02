using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Objects
{
    /// <summary>
    /// Represents a ScriptLink OptionObject2015.
    /// </summary>
    public class OptionObject2015 : IEquatable<OptionObject2015>, IOptionObject2015
    {
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the EntityID property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and can contain a myAvatar PATID, STAFFID, USERID, or INCID.</value>
        public string EntityID { get; set; }
        /// <summary>
        /// Gets or sets the Episode Number property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used with episodic, patient OptionObjects.</value>
        public double EpisodeNumber { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used upon return to myAvatar to determine prompted response. Possible values include 0, 1, 2, 3, 4, and 5 as string values.</value>
        public double ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMesg property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used to display a message to the user in myAvatar for ErrorCodes 1-4.</value>
        public string ErrorMesg { get; set; }
        /// <summary>
        /// Gets or sets the Facility property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. For most organizations, this value is 1, however more complex security configurations will utilize additional values.</value>
        public string Facility { get; set; }
        /// <summary>
        /// Gets or sets the Forms property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="FormObject"/> .</value>
        public List<FormObject> Forms { get; set; }
        /// <summary>
        /// Gets or sets the NamespaceName property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the namespace name of the Option in the myAvatar system.</value>
        public string NamespaceName { get; set; }
        /// <summary>
        /// Gets or sets the OptionId property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the unique identifier of the Option in the myAvatar system.</value>
        public string OptionId { get; set; }
        /// <summary>
        /// Gets or sets the OptionStaffId object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the staff Id of the current myAvatar user.</value>
        public string OptionStaffId { get; set; }
        /// <summary>
        /// Gets or sets the OptionUserId object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the user id of the current myAvatar user.</value>
        public string OptionUserId { get; set; }
        /// <summary>
        /// Gets or sets the ParentNamespace object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Parent Namespace.</value>
        public string ParentNamespace { get; set; }
        /// <summary>
        /// Gets or sets the ServerName object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Server Name.</value>
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the SystemCode object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the System Code. The value may be SBOX, BLD, UAT, or LIVE.</value>
        public string SystemCode { get; set; }
        /// <summary>
        /// Gets or sets the SessionToken object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the SessionToken.</value>
        public string SessionToken { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        //
        // Constructor
        //

        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        public OptionObject2015()
        {
            this.Forms = new List<FormObject>();
        }
        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="namespaceName"></param>
        /// <param name="parentNamespace"></param>
        /// <param name="serverName"></param>
        /// <param name="sessionToken"></param>
        public OptionObject2015(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken)
        {
            this.EntityID = entityId;
            this.EpisodeNumber = episodeNumber;
            this.Facility = facility;
            this.NamespaceName = namespaceName;
            this.OptionId = optionId;
            this.OptionStaffId = optionStaffId;
            this.OptionUserId = optionUserId;
            this.ParentNamespace = parentNamespace;
            this.ServerName = serverName;
            this.SessionToken = sessionToken;
            this.SystemCode = systemCode;

            this.Forms = new List<FormObject>();
        }
        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="namespaceName"></param>
        /// <param name="parentNamespace"></param>
        /// <param name="serverName"></param>
        /// <param name="sessionToken"></param>
        /// <param name="forms"></param>
        public OptionObject2015(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken
            , List<FormObject> forms)
        {
            this.EntityID = entityId;
            this.EpisodeNumber = episodeNumber;
            this.Facility = facility;
            this.NamespaceName = namespaceName;
            this.OptionId = optionId;
            this.OptionStaffId = optionStaffId;
            this.OptionUserId = optionUserId;
            this.ParentNamespace = parentNamespace;
            this.ServerName = serverName;
            this.SessionToken = sessionToken;
            this.SystemCode = systemCode;

            this.Forms = forms;
        }

        //
        // Private Properties
        //

        //
        // IEquatable<FormObject> Methods
        //

        /// <summary>
        /// Used to compare two <see cref="OptionObject2015"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="OptionObject2015"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="OptionObject2015"/> are equal.</returns>
        public bool Equals(OptionObject2015 other)
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

        private bool AreBothEmpty(List<FormObject> list1, List<FormObject> list2) => (!list1.Any() && !list2.Any());

        private bool AreBothNull(List<FormObject> list1, List<FormObject> list2) => (list1 == null && list2 == null);

        /// <summary>
        /// Used to compare <see cref="OptionObject2015"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="OptionObject2015"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            OptionObject2015 optionObject = obj as OptionObject2015;
            if (optionObject == null)
                return false;
            return this.Equals(optionObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="OptionObject2015"/>.
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
                + delimiter + this.SessionToken
                + delimiter + this.SystemCode;
            foreach (FormObject formObject in this.Forms)
            {
                hash += delimiter + formObject.GetHashCode();
            }
            return hash.GetHashCode();
        }

        public static bool operator ==(OptionObject2015 optionObject1, OptionObject2015 optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return Object.Equals(optionObject1, optionObject2);

            return optionObject1.Equals(optionObject2);
        }

        public static bool operator !=(OptionObject2015 optionObject1, OptionObject2015 optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return !Object.Equals(optionObject1, optionObject2);

            return !(optionObject1.Equals(optionObject2));
        }

        //
        // IOptionObject2015 Methods
        //

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObject formObject) => this.Forms = ScriptLinkHelpers.AddFormObject(this, formObject).Forms;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        public void AddFormObject(string formId, bool multipleIteration) => this.Forms = ScriptLinkHelpers.AddFormObject(this, formId, multipleIteration).Forms;

        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/> in this <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        public void AddRowObject(string formId, RowObject rowObject) => this.Forms = ScriptLinkHelpers.AddRowObject(this, formId, rowObject).Forms;

        /// <summary>
        /// Clones the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject2015 Clone() => (OptionObject2015)ScriptLinkHelpers.Clone(this);

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowObject"></param>
        public void DeleteRowObject(RowObject rowObject) => this.Forms = ScriptLinkHelpers.DeleteRowObject(this, rowObject).Forms;

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string rowId) => this.Forms = ScriptLinkHelpers.DeleteRowObject(this, rowId).Forms;

        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled.
        /// </summary>
        public void DisableAllFieldObjects() => this.Forms = ScriptLinkHelpers.DisableAllFieldObjects(this).Forms;

        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled except for any listed to be excluded.
        /// </summary>
        /// <param name="excludedFieldObjects"></param>
        public void DisableAllFieldObjects(List<string> excludedFieldObjects) => this.Forms = ScriptLinkHelpers.DisableAllFieldObjects(this, excludedFieldObjects).Forms;

        /// <summary>
        /// Returns the CurrentRow RowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetCurrentRowId(string formId) => ScriptLinkHelpers.GetCurrentRowId(this, formId);

        /// <summary>
        /// Returns the first value of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => ScriptLinkHelpers.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string formId, string rowId, string fieldNumber) => ScriptLinkHelpers.GetFieldValue(this, formId, rowId, fieldNumber);

        /// <summary>
        /// Returns the values of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber) => ScriptLinkHelpers.GetFieldValues(this, fieldNumber);

        /// <summary>
        /// Returns the Multiple Iteration Status of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool GetMultipleIterationStatus(string formId) => ScriptLinkHelpers.GetMultipleIterationStatus(this, formId);

        /// <summary>
        /// Returns the CurrentRow ParentRowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetParentRowId(string formId) => ScriptLinkHelpers.GetParentRowId(this, formId);

        /// <summary>
        /// Returns whether the specified field is enabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => ScriptLinkHelpers.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => ScriptLinkHelpers.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is present.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => ScriptLinkHelpers.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => ScriptLinkHelpers.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified <see cref="FormObject"/> is present.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool IsFormPresent(string formId) => ScriptLinkHelpers.IsFormPresent(this, formId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is marked for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId) => ScriptLinkHelpers.IsRowMarkedForDeletion(this, rowId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is present.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId) => ScriptLinkHelpers.IsRowPresent(this, rowId);

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber) => this.Forms = ScriptLinkHelpers.SetDisabledField(this, fieldNumber).Forms;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers) => this.Forms = ScriptLinkHelpers.SetDisabledFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject"/> on the first form CurrentRow.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue) => this.Forms = ScriptLinkHelpers.SetFieldValue(this, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject2015"/> 
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue) => this.Forms = ScriptLinkHelpers.SetFieldValue(this, formId, rowId, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Set the specified field as locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber) => this.Forms = ScriptLinkHelpers.SetLockedField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as locked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers) => this.Forms = ScriptLinkHelpers.SetLockedFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber) => this.Forms = ScriptLinkHelpers.SetOptionalField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers) => this.Forms = ScriptLinkHelpers.SetOptionalFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Sets the specified field as required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber) => this.Forms = ScriptLinkHelpers.SetRequiredField(this, fieldNumber).Forms;

        /// <summary>
        /// Sets the specified fields as required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers) => this.Forms = ScriptLinkHelpers.SetRequiredFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as unlocked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber) => this.Forms = ScriptLinkHelpers.SetUnlockedField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as unlocked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers) => this.Forms = ScriptLinkHelpers.SetUnlockedFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public string ToHtmlString() => ScriptLinkHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted as JSON.</returns>
        public string ToJson() => ScriptLinkHelpers.TransformToJson(this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2015"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject ToOptionObject() => (OptionObject)ScriptLinkHelpers.TransformToOptionObject(this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2015"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject2 ToOptionObject2() => (OptionObject2)ScriptLinkHelpers.TransformToOptionObject2(this);

        /// <summary>
        /// Creates an <see cref="OptionObject2015"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public OptionObject2015 ToReturnOptionObject() => (OptionObject2015)ScriptLinkHelpers.GetReturnOptionObject(this);

        /// <summary>
        /// Creates an <see cref="OptionObject2015"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public OptionObject2015 ToReturnOptionObject(int errorCode, string errorMessage) => (OptionObject2015)ScriptLinkHelpers.GetReturnOptionObject(this, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted as XML.</returns>
        public string ToXml() => ScriptLinkHelpers.TransformToXml(this);
    }
}
