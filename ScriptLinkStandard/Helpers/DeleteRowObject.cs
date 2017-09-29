using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject DeleteRowObject(IOptionObject optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject.ToOptionObject2(), rowObject).ToOptionObject();
        }

        public static OptionObject DeleteRowObject(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "rowId");
            return DeleteRowObject(optionObject.ToOptionObject2(), rowId).ToOptionObject();
        }

        public static OptionObject2 DeleteRowObject(IOptionObject2 optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject, rowObject.RowId);
        }

        public static OptionObject2 DeleteRowObject(IOptionObject2 optionObject, string rowId)
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
                    optionObject.Forms[i] = DeleteRowObject(optionObject.Forms[i], rowId);
                    return (OptionObject2)optionObject;
                }
            }
            throw new ArgumentException("No RowObjects were found in this OptionObject matching that RowId.");
        }

        public static FormObject DeleteRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null.", "formObject");
            if (rowObject == null)
                throw new ArgumentException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(formObject, rowObject.RowId);
        }

        public static FormObject DeleteRowObject(IFormObject formObject, string rowId)
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
                return (FormObject)formObject;
            }
            if (formObject.MultipleIteration)
            {
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                    {
                        rowObject.RowAction = "DELETE";
                        return (FormObject)formObject;
                    }
                }
            }
            throw new ArgumentException("No RowObjects were found in this FormObject matching that RowId.");
        }
    }
}
