using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsFieldPresent(IOptionObject optionObject, string fieldNumber)
        {
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsFieldPresent(IOptionObject2 optionObject, string fieldNumber)
        {
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsFieldPresent(IFormObject formObject, string fieldNumber)
        {
            if (formObject.MultipleIteration == false)
            {
                return IsFieldPresent(formObject.CurrentRow, fieldNumber);
            }
            else
            {
                foreach (var row in formObject.OtherRows)
                {
                    if (IsFieldPresent(row, fieldNumber))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsFieldPresent(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject != null)
            {
                foreach (FieldObject field in rowObject.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
