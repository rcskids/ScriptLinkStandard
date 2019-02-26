using ScriptLinkStandard.Interfaces;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns the next available RowId for an <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string GetNextAvailableRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow != null && !formObject.MultipleIteration)
                throw new ArgumentOutOfRangeException("FormObject has maximum number of rows because it not a multiple iteration form.");
            int maximumNumberOfMultipleIterationRows = 9999;
            if (formObject.CurrentRow != null && formObject.OtherRows.Count + 1 >= maximumNumberOfMultipleIterationRows)
                throw new ArgumentOutOfRangeException("FormObject has maximum number of rows (" + (formObject.OtherRows.Count + 1) + ").");
            for (int i = 1; i <= maximumNumberOfMultipleIterationRows; i++)
            {
                string tempRowId = formObject.FormId + "||" + i.ToString();
                if (formObject.CurrentRow == null)
                    return tempRowId;
                if (formObject.CurrentRow.RowId != tempRowId
                    && !formObject.OtherRows.Exists(r => r.RowId == tempRowId))
                    return tempRowId;
            }
            throw new ArgumentException("Could not determine next available RowId in this FormObject.");    // This should never be thrown.
        }
    }
}
