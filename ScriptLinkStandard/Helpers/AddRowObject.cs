using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="FormObject"/> within provided <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static OptionObject AddRowObject(IOptionObject optionObject, string formId, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (formId == null || formId == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "formId");
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            return AddRowObject(optionObject.ToOptionObject2015(), formId, rowObject).ToOptionObject();
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="FormObject"/> within provided <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject2"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static OptionObject2 AddRowObject(IOptionObject2 optionObject2, string formId, IRowObject rowObject)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            if (formId == null || formId == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "formId");
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            return AddRowObject(optionObject2.ToOptionObject2015(), formId, rowObject).ToOptionObject2();
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="FormObject"/> within provided <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject2015"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static OptionObject2015 AddRowObject(IOptionObject2015 optionObject2015, string formId, IRowObject rowObject)
        {
            if (optionObject2015 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2015");
            if (formId == null || formId == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "formId");
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (optionObject2015.IsFormPresent(formId))
            {
                for (int i = 0; i < optionObject2015.Forms.Count; i++)
                {
                    if (optionObject2015.Forms[i].FormId == formId)
                    {
                        optionObject2015.Forms[i] = AddRowObject(optionObject2015.Forms[i], rowObject);
                        break;
                    }
                }
            }
            return (OptionObject2015)optionObject2015;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static FormObject AddRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (!formObject.MultipleIteration && formObject.CurrentRow != null)
                throw new System.ArgumentException("Cannot add another RowObject to this FormObject because it is not a Multiple Iteration form.");
            
            if ((formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowObject.RowId && rowObject.RowId != null && rowObject.RowId != "") ||
                (formObject.OtherRows != null && formObject.OtherRows.Exists(r => r.RowId == rowObject.RowId && rowObject.RowId != null && rowObject.RowId != "")))
                throw new System.ArgumentException("A RowObject with this RowId already exists in this FormObject.");

            if (formObject.CurrentRow == null)
            {
                rowObject.RowId = GetNextRowId(formObject);
                formObject.CurrentRow = (RowObject)rowObject;
            }
            else
            {
                if (rowObject.RowId == null || rowObject.RowId == "")
                    rowObject.RowId = GetNextRowId(formObject);
                formObject.OtherRows.Add((RowObject)rowObject);
            }
            return (FormObject)formObject;
        }

        private static string GetNextRowId(IFormObject formObject)
        {
            int maximumNumberOfMultipleIterationRows = 15;
            for (int i = 1; i < maximumNumberOfMultipleIterationRows; i++)
            {
                string tempRowId = formObject.FormId + "||" + i.ToString();
                if (formObject.CurrentRow == null)
                    return tempRowId;
                if (formObject.CurrentRow.RowId != tempRowId
                    && !formObject.OtherRows.Exists(r => r.RowId == tempRowId))
                    return tempRowId;
            }
            return formObject.FormId + "||99";
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
