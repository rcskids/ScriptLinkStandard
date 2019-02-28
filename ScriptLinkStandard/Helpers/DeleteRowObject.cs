using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Flags a <see cref="IRowObject"/> for deletion in specified <see cref="IOptionObject"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject DeleteRowObject(IOptionObject optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowObject).ToOptionObject();
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IOptionObject"/> by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IOptionObject DeleteRowObject(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowId).ToOptionObject();
        }
        /// <summary>
        /// Flags a <see cref="IRowObject"/> for deletion in specified <see cref="IOptionObject2"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject2 DeleteRowObject(IOptionObject2 optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowObject).ToOptionObject2();
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IOptionObject2"/> by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IOptionObject2 DeleteRowObject(IOptionObject2 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            return DeleteRowObject(optionObject.ToOptionObject2015(), rowId).ToOptionObject2();
        }
        /// <summary>
        /// Flags a <see cref="IRowObject"/> for deletion in specified <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 DeleteRowObject(IOptionObject2015 optionObject, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(optionObject, rowObject.RowId);
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IOptionObject2015"/> by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IOptionObject2015 DeleteRowObject(IOptionObject2015 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new NullReferenceException("There are no FormObjects in this OptionObject.");
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
        /// <summary>
        /// Flags a <see cref="IRowObject"/> for deletion in specified <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IFormObject DeleteRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return DeleteRowObject(formObject, rowObject.RowId);
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IFormObject"/> by RowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IFormObject DeleteRowObject(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject is missing a CurrentRow.");
            if (formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow.RowAction = RowAction.Delete;
                return formObject;
            }
            if (formObject.MultipleIteration)
            {
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                    {
                        rowObject.RowAction = RowAction.Delete;
                        return formObject;
                    }
                }
            }
            throw new ArgumentException("No RowObjects were found in this FormObject matching that RowId.");
        }
    }
}
