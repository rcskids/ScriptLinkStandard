using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="IFormObject"/> within provided <see cref="IOptionObject"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject AddRowObject(IOptionObject optionObject, string formId, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (formId == null || formId == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            return AddRowObject(optionObject.ToOptionObject2015(), formId, rowObject).ToOptionObject();
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="IFormObject"/> within provided <see cref="IOptionObject2"/>.
        /// </summary>
        /// <param name="optionObject2"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject2 AddRowObject(IOptionObject2 optionObject2, string formId, IRowObject rowObject)
        {
            if (optionObject2 == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "optionObject2");
            if (formId == null || formId == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            return AddRowObject(optionObject2.ToOptionObject2015(), formId, rowObject).ToOptionObject2();
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="IFormObject"/> within provided <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject2015"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 AddRowObject(IOptionObject2015 optionObject2015, string formId, IRowObject rowObject)
        {
            if (optionObject2015 == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "optionObject2015");
            if (formId == null || formId == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (optionObject2015.IsFormPresent(formId))
            {
                for (int i = 0; i < optionObject2015.Forms.Count; i++)
                {
                    if (optionObject2015.Forms[i].FormId == formId)
                    {
                        optionObject2015.Forms[i] = (FormObject)AddRowObject(optionObject2015.Forms[i], rowObject);
                        break;
                    }
                }
            }
            return optionObject2015;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IFormObject AddRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "formObject");
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (!formObject.MultipleIteration && formObject.CurrentRow != null)
                throw new System.ArgumentException("Cannot add another RowObject to this FormObject because it is not a Multiple Iteration form.");
            
            if ((formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowObject.RowId && rowObject.RowId != null && rowObject.RowId != "") ||
                (formObject.OtherRows != null && formObject.OtherRows.Exists(r => r.RowId == rowObject.RowId && rowObject.RowId != null && rowObject.RowId != "")))
                throw new System.ArgumentException("A RowObject with this RowId already exists in this FormObject.");

            if (formObject.CurrentRow == null)
            {
                rowObject.RowId = formObject.GetNextAvailableRowId();
                formObject.CurrentRow = (RowObject)rowObject;
            }
            else
            {
                if (rowObject.RowId == null || rowObject.RowId == "")
                    rowObject.RowId = formObject.GetNextAvailableRowId();
                formObject.OtherRows.Add((RowObject)rowObject);
            }
            return formObject;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="IFormObject"/> using provided RowId and ParentRowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <returns></returns>
        public static IFormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId)
        {
            if (formObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "formObject");
            return AddRowObject(formObject, rowId, parentRowId, RowAction.Add);
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="IFormObject"/> using provided RowId, ParentRowId, and RowAction.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static IFormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId, string rowAction)
        {
            if (formObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "formObject");
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
