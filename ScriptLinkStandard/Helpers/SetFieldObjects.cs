using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldObjects(IOptionObject optionObject, string fieldAction, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject.ToOptionObject2015(), fieldAction, fieldObjects).ToOptionObject();
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldObjects(IOptionObject optionObject, string fieldAction, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject.ToOptionObject2015(), fieldAction, fieldNumbers).ToOptionObject();
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject2"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject2 SetFieldObjects(IOptionObject2 optionObject, string fieldAction, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject.ToOptionObject2015(), fieldAction, fieldObjects).ToOptionObject2();
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject2"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject2 SetFieldObjects(IOptionObject2 optionObject, string fieldAction, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject.ToOptionObject2015(), fieldAction, fieldNumbers).ToOptionObject2();
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject2015"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetFieldObjects(IOptionObject2015 optionObject, string fieldAction, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = GetFieldNumbersToSet(fieldObjects);
            return SetFieldObjects(optionObject, fieldAction, fieldNumbers);
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject2015"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject2015"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetFieldObjects(IOptionObject2015 optionObject2015, string fieldAction, List<string> fieldNumbers)
        {
            if (optionObject2015 == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject2015");
            if (optionObject2015.Forms == null || optionObject2015.Forms.Count == 0)
                throw new NullReferenceException("There are no FormObjects in this OptionObject.");
            if (fieldAction == null || fieldAction == "")
                throw new ArgumentNullException("No FieldAction has been identified.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new ArgumentNullException("No FieldObjects have been identified to disable.");

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(optionObject2015, fieldNumber))
                    fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new ArgumentException("None of the identified FieldsObjects were found in this OptionObject.");

            int formErrors = 0;
            for (int i = 0; i < optionObject2015.Forms.Count; i++)
            {
                try
                {
                    optionObject2015.Forms[i] = (FormObject)SetFieldObjects(optionObject2015.Forms[i], fieldAction, fieldsToSet);
                }
                catch (Exception)
                {
                    // The FieldObjects to set may not be present on each FormObject
                    formErrors++;
                }
            }
            if (formErrors == optionObject2015.Forms.Count)
                throw new ArgumentException("None of the identified FieldsObjects were able to be set in " + optionObject2015.Forms.Count.ToString() + " FormObjects");

            return optionObject2015;
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IFormObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetFieldObjects(IFormObject formObject, string fieldAction, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not contain a CurrentRow.");
            if (fieldAction == null || fieldAction == "")
                throw new ArgumentNullException("No FieldAction has been identified.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new ArgumentNullException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(formObject, fieldNumber))
                    fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new ArgumentException("None of the identified FieldsObjects were found in this FormObject.");

            formObject.CurrentRow = (RowObject)SetFieldObjects(formObject.CurrentRow, fieldAction, fieldsToSet);

            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    formObject.OtherRows[i] = (RowObject)SetFieldObjects(formObject.OtherRows[i], fieldAction, fieldsToSet);
                }
            }
            return formObject;
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IRowObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetFieldObjects(IRowObject rowObject, string fieldAction, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldAction == null || fieldAction == "")
                throw new ArgumentNullException("No FieldAction has been identified.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new ArgumentNullException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(rowObject, fieldNumber))
                    fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new ArgumentException("None of the identified FieldsObjects were found in this RowObject.");

            foreach (var fieldObject in rowObject.Fields)
            {
                if (fieldsToSet.Contains(fieldObject.FieldNumber))
                {
                    switch (fieldAction)
                    {
                        case FieldAction.Disable:
                            fieldObject.SetAsDisabled();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        case FieldAction.Enable:
                            fieldObject.SetAsEnabled();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        case FieldAction.Lock:
                            fieldObject.SetAsLocked();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        case FieldAction.Modify:
                            fieldObject.SetAsModified();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        case FieldAction.Optional:
                            fieldObject.SetAsOptional();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        case FieldAction.Require:
                            fieldObject.SetAsRequired();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        case FieldAction.Unlock:
                            fieldObject.SetAsUnlocked();
                            rowObject.RowAction = RowAction.Edit;
                            break;
                        default:
                            break;
                    }
                }
            }
            return rowObject;
        }

        #region HelperMethods
        private static List<string> GetFieldNumbersToSet(List<FieldObject> fieldObjects)
        {
            if (fieldObjects == null || fieldObjects.Count == 0)
                throw new ArgumentNullException("Parameter cannot be null or empty.", "fieldObjects");
            List<string> fieldNumbers = new List<string>();
            foreach (var fieldObject in fieldObjects)
            {
                fieldNumbers.Add(fieldObject.FieldNumber);
            }
            return fieldNumbers;
        }
        #endregion
    }
}
