using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsFieldEnabled(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return false;
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldEnabled(form, fieldNumber))
                    return true;
            }
            return false;
        }
        public static bool IsFieldEnabled(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return false;
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldEnabled(form, fieldNumber))
                    return true;
            }
            return false;
        }

        public static bool IsFieldEnabled(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                return false;
            return IsFieldEnabled(formObject.CurrentRow, fieldNumber);
        }

        public static bool IsFieldEnabled(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                return false;
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldEnabled(field);
            }
            return false;
        }

        public static bool IsFieldEnabled(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                return false;
            return fieldObject.Enabled == "1" ? true : false;
        }
    }
}
