using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;
using System.Linq;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static string GetFieldValue(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return null;
            return GetFieldValue(optionObject.ToOptionObject2(), fieldNumber);
        }
        public static string GetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                return null;
            return GetFieldValue(optionObject.ToOptionObject2(), formId, rowId, fieldNumber);
        }

        public static string GetFieldValue(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return null;
            List<string> fieldValues = ScriptLinkHelpers.GetFieldValues(optionObject, fieldNumber);
            return fieldValues.Count > 0 ? fieldValues[0] : "";
        }

        public static string GetFieldValue(IOptionObject2 optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                return null;
            foreach (var form in optionObject.Forms)
            {
                if (form.FormId == formId)
                    return GetFieldValue(form, rowId, fieldNumber);
            }
            return null;
        }

        public static string GetFieldValue(IFormObject formObject, string fieldNumber)
        {
            return GetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber);
        }

        public static string GetFieldValue(IFormObject formObject, string rowId, string fieldNumber)
        {
            if (formObject == null)
                return null;
            if (formObject.CurrentRow.RowId == rowId)
                return ScriptLinkHelpers.GetFieldValue(formObject.CurrentRow, fieldNumber);
            foreach (RowObject rowObject in formObject.OtherRows)
            {
                if (rowObject.RowId == rowId)
                    return ScriptLinkHelpers.GetFieldValue(rowObject, fieldNumber);
            }
            return null;
        }

        public static string GetFieldValue(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                return null;
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return GetFieldValue(field);
            }
            return null;
        }

        public static string GetFieldValue(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                return null;
            return fieldObject.FieldValue;
        }
    }
}
