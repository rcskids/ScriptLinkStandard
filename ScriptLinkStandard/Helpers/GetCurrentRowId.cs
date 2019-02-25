using ScriptLinkStandard.Interfaces;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Gets the CurrentRow.RowId of the <see cref="IFormObject"/> in the <see cref="IOptionObject"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetCurrentRowId(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetCurrentRowId(optionObject.ToOptionObject2(), formId);
        }
        /// <summary>
        /// Gets the CurrentRow.RowId of the <see cref="IFormObject"/> in the <see cref="IOptionObject2"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetCurrentRowId(IOptionObject2 optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetCurrentRowId(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Gets the CurrentRow.RowId of the <see cref="IFormObject"/> in the <see cref="IOptionObject2015"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetCurrentRowId(IOptionObject2015 optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (optionObject.Forms == null)
                throw new NullReferenceException("The OptionObject does not contain any Forms.");
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetCurrentRowId(formObject);
                }
            }
            throw new ArgumentException("The FormObject with FormId " + formId + " does not exist in this OptionObject.");
        }
        /// <summary>
        /// Gets the CurrentRow.RowId of the <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string GetCurrentRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not contain a CurrentRow.");
            return formObject.CurrentRow.RowId;
        }
    }
}
