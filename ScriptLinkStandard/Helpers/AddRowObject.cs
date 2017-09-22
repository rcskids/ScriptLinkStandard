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
            if (formObject == null || rowObject == null)
                return (FormObject)formObject;
            if ((formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowObject.RowId) ||
                (formObject.OtherRows != null && formObject.OtherRows.Exists(r => r.RowId == rowObject.RowId)))
                return (FormObject)formObject;
            if (!formObject.MultipleIteration && formObject.CurrentRow != null)
                return (FormObject)formObject;
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
                return (FormObject)formObject;
            return AddRowObject(formObject, rowId, parentRowId, "ADD");
        }

        public static FormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId, string rowAction)
        {
            if (formObject == null)
                return (FormObject)formObject;
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
