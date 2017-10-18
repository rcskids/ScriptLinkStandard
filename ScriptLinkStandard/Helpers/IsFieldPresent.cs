using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsFieldPresent(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldPresent(optionObject.ToOptionObject2015(), fieldNumber);
        }
        public static bool IsFieldPresent(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldPresent(optionObject.ToOptionObject2015(), fieldNumber);
        }
        public static bool IsFieldPresent(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (optionObject.Forms == null)
                throw new System.ArgumentException("The OptionObject does not contain any Forms.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
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
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            if (formObject.CurrentRow == null)
                return false;
            return IsFieldPresent(formObject.CurrentRow, fieldNumber);
        }

        public static bool IsFieldPresent(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (rowObject.Fields == null)
                throw new System.ArgumentException("The RowObject does not contain any FieldObjects.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return true;
            }
            return false;
        }
    }
}
