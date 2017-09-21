using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsFieldRequired(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return false;
            foreach (var form in optionObject.Forms)
            {
                return IsFieldRequired(form, fieldNumber);
            }
            return false;
        }
        public static bool IsFieldRequired(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return false;
            foreach (var form in optionObject.Forms)
            {
                return IsFieldRequired(form, fieldNumber);
            }
            return false;
        }

        public static bool IsFieldRequired(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                return false;
            return IsFieldRequired(formObject.CurrentRow, fieldNumber);
        }

        public static bool IsFieldRequired(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                return false;
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldRequired(field);
            }
            return false;
        }

        public static bool IsFieldRequired(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                return false;
            return fieldObject.Required == "1" ? true : false;
        }
    }
}
