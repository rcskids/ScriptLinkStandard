﻿using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Objects
{
    /// <summary>
    /// Represents a ScriptLink OptionObject.
    /// </summary>
    public class OptionObject : IEquatable<OptionObject>, IOptionObject
    {
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the EntityID property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and can contain a myAvatar PATID, STAFFID, USERID, or INCID.</value>
        public string EntityID { get; set; }
        /// <summary>
        /// Gets or sets the Episode Number property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used with episodic, patient OptionObjects.</value>
        public double EpisodeNumber { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used upon return to myAvatar to determine prompted response. Possible values include 0, 1, 2, 3, 4, and 5 as string values.</value>
        public double ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMesg property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used to display a message to the user in myAvatar for ErrorCodes 1-4.</value>
        public string ErrorMesg { get; set; }
        /// <summary>
        /// Gets or sets the Facility property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. For most organizations, this value is 1, however more complex security configurations will utilize additional values.</value>
        public string Facility { get; set; }
        /// <summary>
        /// Gets or sets the Forms property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="FormObject"/> .</value>
        public List<FormObject> Forms { get; set; }
        /// <summary>
        /// Gets or sets the OptionId property of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the unique identifier of the Option in the myAvatar system.</value>
        public string OptionId { get; set; }
        /// <summary>
        /// Gets or sets the OptionStaffId object of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the staff Id of the current myAvatar user.</value>
        public string OptionStaffId { get; set; }
        /// <summary>
        /// Gets or sets the OptionUserId object of the <see cref="OptionObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the user id of the current myAvatar user.</value>
        public string OptionUserId { get; set; }
        /// <summary>
        /// Gets or sets the SystemCode object of the <see cref="OptionObject"/>.
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
        /// Creates a new ScriptLink <see cref="OptionObject"/>.
        /// </summary>
        public OptionObject()
        {
            this.Forms = new List<FormObject>();
        }
        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        public OptionObject(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode)
        {
            this.EntityID = entityId;
            this.EpisodeNumber = episodeNumber;
            this.Facility = facility;
            this.OptionId = optionId;
            this.OptionStaffId = optionStaffId;
            this.OptionUserId = optionUserId;
            this.SystemCode = systemCode;

            this.Forms = new List<FormObject>();
        }
        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="forms"></param>
        public OptionObject(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode
            , List<FormObject> forms)
        {
            this.EntityID = entityId;
            this.EpisodeNumber = episodeNumber;
            this.Facility = facility;
            this.OptionId = optionId;
            this.OptionStaffId = optionStaffId;
            this.OptionUserId = optionUserId;
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
        /// Used to compare two <see cref="OptionObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="OptionObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="OptionObject"/> are equal.</returns>
        public bool Equals(OptionObject other)
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
        /// Used to compare <see cref="OptionObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="OptionObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            OptionObject optionObject = obj as OptionObject;
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
                + delimiter + this.OptionId
                + delimiter + this.OptionStaffId
                + delimiter + this.OptionUserId
                + delimiter + this.SystemCode;
            foreach (FormObject formObject in this.Forms)
            {
                hash += delimiter + formObject.GetHashCode();
            }
            return hash.GetHashCode();
        }

        public static bool operator ==(OptionObject optionObject1, OptionObject optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return Object.Equals(optionObject1, optionObject2);

            return optionObject1.Equals(optionObject2);
        }

        public static bool operator !=(OptionObject optionObject1, OptionObject optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return !Object.Equals(optionObject1, optionObject2);

            return !(optionObject1.Equals(optionObject2));
        }

        //
        // IOptionObject Methods
        //

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObject formObject)
        {
            if (formObject == null)
                return;
            this.Forms = ScriptLinkHelpers.AddFormObject(this, formObject).Forms;
        }
        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject"/>.
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
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/> in this <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        public void AddRowObject(string formId, RowObject rowObject)
        {
            if (formId == null || formId == "")
                return;
            this.Forms = ScriptLinkHelpers.AddRowObject(this, formId, rowObject).Forms;
        }
        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowObject"></param>
        public void DeleteRowObject(RowObject rowObject)
        {
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            this.Forms = ScriptLinkHelpers.DeleteRowObject(this, rowObject).Forms;
        }
        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string rowId)
        {
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            this.Forms = ScriptLinkHelpers.DeleteRowObject(this, rowId).Forms;
        }
        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled.
        /// </summary>
        public void DisableAllFieldObjects()
        {
            this.Forms = ScriptLinkHelpers.DisableAllFieldObjects(this).Forms;
        }
        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled except for any listed to be excluded.
        /// </summary>
        /// <param name="excludedFieldObjects"></param>
        public void DisableAllFieldObjects(List<string> excludedFieldObjects)
        {
            this.Forms = ScriptLinkHelpers.DisableAllFieldObjects(this, excludedFieldObjects).Forms;
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
        /// Returns whether the specified <see cref="FormObject"/> is present.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool IsFormPresent(string formId)
        {
            return ScriptLinkHelpers.IsFormPresent(this, formId);
        }
        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is marked for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId)
        {
            return ScriptLinkHelpers.IsRowMarkedForDeletion(this, rowId);
        }
        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is present.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId)
        {
            return ScriptLinkHelpers.IsRowPresent(this, rowId);
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
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledFields(string fieldNumber)
        {
            this.Forms = ScriptLinkHelpers.SetDisabledFields(this, fieldNumber).Forms;
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
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject"/> 
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
        /// Set the specified field as locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedFields(string fieldNumber)
        {
            this.Forms = ScriptLinkHelpers.SetLockedFields(this, fieldNumber).Forms;
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
        /// Set the specified field as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalFields(string fieldNumber)
        {
            this.Forms = ScriptLinkHelpers.SetOptionalFields(this, fieldNumber).Forms;
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
        /// Sets the specified field as required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredFields(string fieldNumber)
        {
            this.Forms = ScriptLinkHelpers.SetRequiredFields(this, fieldNumber).Forms;
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
        /// Set the specified field as unlocked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedFields(string fieldNumber)
        {
            this.Forms = ScriptLinkHelpers.SetUnlockedFields(this, fieldNumber).Forms;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders)
        {
            return ScriptLinkHelpers.TransformToHtmlString(this, includeHtmlHeaders);
        }
        /// <summary>
        /// Transforms the <see cref="OptionObject"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject2 ToOptionObject2()
        {
            return ScriptLinkHelpers.TransformToOptionObject2(this);
        }
        /// <summary>
        /// Transforms the <see cref="OptionObject"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject2015 ToOptionObject2015()
        {
            return ScriptLinkHelpers.TransformToOptionObject2015(this);
        }
        /// <summary>
        /// Creates an <see cref="OptionObject"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public OptionObject ToReturnOptionObject()
        {
            return (OptionObject)ScriptLinkHelpers.GetReturnOptionObject(this);
        }
        /// <summary>
        /// Creates an <see cref="OptionObject"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public OptionObject ToReturnOptionObject(int errorCode, string errorMessage)
        {
            return (OptionObject)ScriptLinkHelpers.GetReturnOptionObject(this, errorCode, errorMessage);
        }
    }
}
