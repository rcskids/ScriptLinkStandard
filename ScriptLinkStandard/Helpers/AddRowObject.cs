using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static FormObject AddRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if ((formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowObject.RowId) ||
                (formObject.OtherRows != null && formObject.OtherRows.Exists(r => r.RowId == rowObject.RowId)))
                throw new System.ArgumentException("A RowObject with this RowId already exists in this FormObject.");
            if (!formObject.MultipleIteration && formObject.CurrentRow != null)
                throw new System.ArgumentException("Cannot add another RowObject to this FormObject becuase it is not a Multiple Iteration form.");
            if (formObject.CurrentRow == null)
            {
                formObject.CurrentRow = (RowObject)rowObject;
            }
            else
            {
                formObject.OtherRows.Add((RowObject)rowObject);
            }
            return (FormObject)formObject;
        }

        public static FormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            return AddRowObject(formObject, rowId, parentRowId, "ADD");
        }

        public static FormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId, string rowAction)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            RowObject rowObject = new RowObject
            {
                ParentRowId = parentRowId,
                RowAction = rowAction,
                RowId = rowId
            };
            return AddRowObject(formObject, rowObject);
        }
    }
}
