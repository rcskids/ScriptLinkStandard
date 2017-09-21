using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsFieldLocked(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return false;
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldLocked(form, fieldNumber))
                    return true;
            }
            return false;
        }
        public static bool IsFieldLocked(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                return false;
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldLocked(form, fieldNumber))
                    return true;
            }
            return false;
        }

        public static bool IsFieldLocked(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                return false;
            return IsFieldLocked(formObject.CurrentRow, fieldNumber);
        }

        public static bool IsFieldLocked(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                return false;
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldLocked(field);
            }
            return false;
        }

        public static bool IsFieldLocked(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                return false;
            return fieldObject.Lock == "1" ? true : false;
        }
    }
}
