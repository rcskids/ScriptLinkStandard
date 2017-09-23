using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static string GetFieldValue(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return GetFieldValue(optionObject.ToOptionObject2(), fieldNumber);
        }
        public static string GetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return GetFieldValue(optionObject.ToOptionObject2(), formId, rowId, fieldNumber);
        }

        public static string GetFieldValue(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            List<string> fieldValues = ScriptLinkHelpers.GetFieldValues(optionObject, fieldNumber);
            return fieldValues.Count > 0 ? fieldValues[0] : "";
        }

        public static string GetFieldValue(IOptionObject2 optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            foreach (var form in optionObject.Forms)
            {
                if (form.FormId == formId)
                    return GetFieldValue(form, rowId, fieldNumber);
            }
            throw new ArgumentException("FieldObject could not be found.");
        }

        public static string GetFieldValue(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            return GetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber);
        }

        public static string GetFieldValue(IFormObject formObject, string rowId, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            if (formObject.CurrentRow.RowId == rowId)
                return ScriptLinkHelpers.GetFieldValue(formObject.CurrentRow, fieldNumber);
            foreach (RowObject rowObject in formObject.OtherRows)
            {
                if (rowObject.RowId == rowId)
                    return ScriptLinkHelpers.GetFieldValue(rowObject, fieldNumber);
            }
            throw new ArgumentException("FieldObject could not be found.");
        }

        public static string GetFieldValue(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null", "rowObject");
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return GetFieldValue(field);
            }
            throw new ArgumentException("FieldObject could not be found.");
        }

        public static string GetFieldValue(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentException("Parameter cannot be null", "fieldObject");
            return fieldObject.FieldValue;
        }
    }
}
