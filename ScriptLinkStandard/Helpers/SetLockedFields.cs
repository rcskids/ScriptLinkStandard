using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject SetLockedFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetLockedFields(optionObject.ToOptionObject2(), fieldObjects).ToOptionObject();
        }
        public static OptionObject SetLockedFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetLockedFields(optionObject.ToOptionObject2(), fieldNumbers).ToOptionObject();
        }

        public static OptionObject2 SetLockedFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = GetFieldNumbersToLock(fieldObjects);
            return SetLockedFields(optionObject, fieldNumbers);
        }
        public static OptionObject2 SetLockedFields(IOptionObject2 optionObject2, List<string> fieldNumbers)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            if (optionObject2.Forms == null || optionObject2.Forms.Count == 0)
                throw new System.ArgumentException("There are no FormObjects in this OptionObject.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("No FieldObjects have been identified to disable.");

            List<string> fieldsToLock = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(optionObject2, fieldNumber))
                    fieldsToLock.Add(fieldNumber);
            }
            if (fieldsToLock.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObject were found in this OptionObject.");

            int formErrors = 0;
            for (int i = 0; i < optionObject2.Forms.Count; i++)
            {
                try
                {
                    optionObject2.Forms[i] = SetLockedFields(optionObject2.Forms[i], fieldsToLock);
                }
                catch (ArgumentException)
                {
                    // The FieldObjects to disable may not be present on each FormObject
                    formErrors++;
                }
            }
            if (formErrors == optionObject2.Forms.Count)
                throw new System.ArgumentException("None of the identified FieldsObject were able to be disabled in " + optionObject2.Forms.Count.ToString() + " FormObjects");

            return (OptionObject2)optionObject2;
        }

        public static FormObject SetLockedFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new System.ArgumentException("The FormObject does not contain a CurrentRow.", "formObject");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToLock = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(formObject, fieldNumber))
                    fieldsToLock.Add(fieldNumber);
            }
            if (fieldsToLock.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObject were found in this FormObject.");

            formObject.CurrentRow = SetLockedFields(formObject.CurrentRow, fieldsToLock);

            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    formObject.OtherRows[i] = SetLockedFields(formObject.OtherRows[i], fieldsToLock);
                }
            }
            return (FormObject)formObject;
        }

        public static RowObject SetLockedFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToLock = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(rowObject, fieldNumber))
                    fieldsToLock.Add(fieldNumber);
            }
            if (fieldsToLock.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObject were found in this RowObject.");

            foreach (var fieldObject in rowObject.Fields)
            {
                if (fieldsToLock.Contains(fieldObject.FieldNumber))
                {
                    fieldObject.SetAsLocked();
                    rowObject.RowAction = "EDIT";
                }
            }
            return (RowObject)rowObject;
        }

        private static List<string> GetFieldNumbersToLock(List<FieldObject> fieldObjects)
        {
            if (fieldObjects == null || fieldObjects.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldObjects");
            List<string> fieldNumbers = new List<string>();
            foreach (var fieldObject in fieldObjects)
            {
                fieldNumbers.Add(fieldObject.FieldNumber);
            }
            return fieldNumbers;
        }
    }
}
