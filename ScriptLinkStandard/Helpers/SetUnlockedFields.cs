using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject SetUnlockedFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetUnlockedFields(optionObject.ToOptionObject2(), fieldObjects).ToOptionObject();
        }
        public static OptionObject SetUnlockedFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetUnlockedFields(optionObject.ToOptionObject2(), fieldNumbers).ToOptionObject();
        }

        public static OptionObject2 SetUnlockedFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = GetFieldNumbersToUnlock(fieldObjects);
            return SetUnlockedFields(optionObject, fieldNumbers);
        }
        public static OptionObject2 SetUnlockedFields(IOptionObject2 optionObject2, List<string> fieldNumbers)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            if (optionObject2.Forms == null || optionObject2.Forms.Count == 0)
                throw new System.ArgumentException("There are no FormObjects in this OptionObject.");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("No FieldObjects have been identified to disable.");

            List<string> fieldsToUnlock = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(optionObject2, fieldNumber))
                    fieldsToUnlock.Add(fieldNumber);
            }
            if (fieldsToUnlock.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObject were found in this OptionObject.");

            int formErrors = 0;
            for (int i = 0; i < optionObject2.Forms.Count; i++)
            {
                try
                {
                    optionObject2.Forms[i] = SetUnlockedFields(optionObject2.Forms[i], fieldsToUnlock);
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

        public static FormObject SetUnlockedFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new System.ArgumentException("The FormObject does not contain a CurrentRow.", "formObject");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToUnlock = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(formObject, fieldNumber))
                    fieldsToUnlock.Add(fieldNumber);
            }
            if (fieldsToUnlock.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObject were found in this FormObject.");

            formObject.CurrentRow = SetUnlockedFields(formObject.CurrentRow, fieldsToUnlock);

            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    formObject.OtherRows[i] = SetUnlockedFields(formObject.OtherRows[i], fieldsToUnlock);
                }
            }
            return (FormObject)formObject;
        }

        public static RowObject SetUnlockedFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (fieldNumbers == null || fieldNumbers.Count == 0)
                throw new System.ArgumentException("Parameter cannot be null or empty.", "fieldNumbers");

            List<string> fieldsToUnlock = new List<string>();
            foreach (string fieldNumber in fieldNumbers)
            {
                if (IsFieldPresent(rowObject, fieldNumber))
                    fieldsToUnlock.Add(fieldNumber);
            }
            if (fieldsToUnlock.Count == 0)
                throw new System.ArgumentException("None of the identified FieldsObject were found in this RowObject.");

            foreach (var fieldObject in rowObject.Fields)
            {
                if (fieldsToUnlock.Contains(fieldObject.FieldNumber))
                {
                    fieldObject.SetAsUnlocked();
                    rowObject.RowAction = "EDIT";
                }
            }
            return (RowObject)rowObject;
        }

        private static List<string> GetFieldNumbersToUnlock(List<FieldObject> fieldObjects)
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
