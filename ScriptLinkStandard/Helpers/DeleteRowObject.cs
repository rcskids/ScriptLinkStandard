using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject DeleteRowObject(IOptionObject optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowObject).ToOptionObject();
        }

        public static IOptionObject DeleteRowObject(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowId).ToOptionObject();
        }
        public static IOptionObject2 DeleteRowObject(IOptionObject2 optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowObject).ToOptionObject2();
        }

        public static IOptionObject2 DeleteRowObject(IOptionObject2 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowId).ToOptionObject2();
        }

        public static IOptionObject2015 DeleteRowObject(IOptionObject2015 optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject, rowObject.RowId);
        }

        public static IOptionObject2015 DeleteRowObject(IOptionObject2015 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new ArgumentException("There are no FormObjects in this OptionObject.");
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (IsRowPresent(optionObject.Forms[i], rowId))
                {
                    optionObject.Forms[i] = (FormObject)DeleteRowObject(optionObject.Forms[i], rowId);
                    return optionObject;
                }
            }
            throw new ArgumentException("No RowObjects were found in this OptionObject matching that RowId.");
        }

        public static IFormObject DeleteRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null.", "formObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(formObject, rowObject.RowId);
        }

        public static IFormObject DeleteRowObject(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            if (formObject.CurrentRow == null)
                throw new ArgumentException("The FormObject is missing a CurrentRow.");
            if (formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow.RowAction = "DELETE";
                return formObject;
            }
            if (formObject.MultipleIteration)
            {
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                    {
                        rowObject.RowAction = "DELETE";
                        return formObject;
                    }
                }
            }
            throw new ArgumentException("No RowObjects were found in this FormObject matching that RowId.");
        }
    }
}
