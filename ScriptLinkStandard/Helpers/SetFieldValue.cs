using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject SetFieldValue(IOptionObject optionObject, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                return (OptionObject)optionObject;
            return SetFieldValue(optionObject.ToOptionObject2(), fieldNumber, fieldValue).ToOptionObject(); ;
        }

        public static OptionObject SetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                return (OptionObject)optionObject;
            return SetFieldValue(optionObject.ToOptionObject2(), formId, rowId, fieldNumber, fieldValue).ToOptionObject();
        }

        public static OptionObject2 SetFieldValue(IOptionObject2 optionObject, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                return (OptionObject2)optionObject;
            if (optionObject.Forms.Count > 0 && optionObject.Forms[0].MultipleIteration)
                return (OptionObject2)optionObject;
            string formId = optionObject.Forms.Count > 0 ? optionObject.Forms[0].FormId : null;
            string rowId = optionObject.Forms.Count > 0 ? optionObject.Forms[0].GetCurrentRowId() : null;
            return SetFieldValue(optionObject, formId, rowId, fieldNumber, fieldValue);
        }

        public static OptionObject2 SetFieldValue(IOptionObject2 optionObject, string formId, string rowId, string fieldNumber, string fieldValue)
        {
            if (optionObject == null || formId == null || rowId == null)
                return (OptionObject2)optionObject;
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].FormId == formId)
                    optionObject.Forms[i] = SetFieldValue(optionObject.Forms[i], rowId, fieldNumber, fieldValue);
            }
            return (OptionObject2)optionObject;
        }

        public static FormObject SetFieldValue(IFormObject formObject, string fieldNumber, string fieldValue)
        {
            if (formObject == null)
                return (FormObject)formObject;
            if (formObject.MultipleIteration)
                return (FormObject)formObject;
            return SetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber, fieldValue);
        }

        public static FormObject SetFieldValue(IFormObject formObject, string rowId, string fieldNumber, string fieldValue)
        {
            if (formObject == null)
                return (FormObject)formObject;
            if (!formObject.MultipleIteration || formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow = ScriptLinkHelpers.SetFieldValue(formObject.CurrentRow, fieldNumber, fieldValue);
            }
            else
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    if (formObject.OtherRows[i].RowId == rowId)
                        formObject.OtherRows[i] = ScriptLinkHelpers.SetFieldValue(formObject.OtherRows[i], fieldNumber, fieldValue);
                }
            }
            return (FormObject)formObject;
        }

        public static RowObject SetFieldValue(IRowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (rowObject == null)
                return (RowObject)rowObject;
            for (int i = 0; i < rowObject.Fields.Count; i++)
            {
                if (rowObject.Fields[i].FieldNumber == fieldNumber)
                {
                    rowObject.Fields[i] = SetFieldValue(rowObject.Fields[i], fieldValue);
                    rowObject.RowAction = "EDIT";
                    break;
                }
            }
            return (RowObject)rowObject;
        }

        public static FieldObject SetFieldValue(IFieldObject fieldObject, string fieldValue)
        {
            fieldObject.FieldValue = fieldValue;
            fieldObject.SetAsModified();
            return (FieldObject)fieldObject;
        }
    }
}
