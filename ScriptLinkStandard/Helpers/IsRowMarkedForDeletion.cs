using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsRowMarkedForDeletion(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            return IsRowMarkedForDeletion(optionObject.ToOptionObject2015(), rowId);
        }
        public static bool IsRowMarkedForDeletion(IOptionObject2 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            return IsRowMarkedForDeletion(optionObject.ToOptionObject2015(), rowId);
        }

        public static bool IsRowMarkedForDeletion(IOptionObject2015 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new ArgumentException("The OptionObject does not contain any FormObjects.");
            foreach (FormObject formObject in optionObject.Forms)
            {
                if (IsRowMarkedForDeletion(formObject, rowId))
                    return true;
            }
            return false;
        }

        public static bool IsRowMarkedForDeletion(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (formObject.CurrentRow == null)
                throw new ArgumentException("The FormObject does not contain a CurrentRow.");
            if (formObject.CurrentRow.RowId == rowId)
                return formObject.CurrentRow.RowAction == "DELETE";
            if (formObject.MultipleIteration)
                return formObject.OtherRows.Exists(r => r.RowId == rowId && r.RowAction == "DELETE");
            return false;
        }
    }
}
