using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IOptionObject"/> is enabled by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            return IsRowPresent(optionObject.ToOptionObject2015(), rowId);
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IOptionObject2"/> is enabled by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IOptionObject2 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            return IsRowPresent(optionObject.ToOptionObject2015(), rowId);
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IOptionObject2015"/> is enabled by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IOptionObject2015 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new NullReferenceException("The OptionObject does not contain any FormObjects.");
            foreach (FormObject formObject in optionObject.Forms)
            {
                if (IsRowPresent(formObject, rowId))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IFormObject"/> is enabled by RowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not contain a CurrentRow.");
            if (formObject.CurrentRow.RowId == rowId)
                return true;
            if (formObject.MultipleIteration)
                return formObject.OtherRows.Exists(r => r.RowId == rowId);
            return false;
        }
    }
}
