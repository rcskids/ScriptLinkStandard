using ScriptLinkStandard.Interfaces;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns the ParentRowId of a <see cref="IFormObject"/> in the <see cref="IOptionObject"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetParentRowId(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new System.NullReferenceException("Parameter 'optionObject' cannot be null.");
            return GetParentRowId(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Returns the ParentRowId of a <see cref="IFormObject"/> in the <see cref="IOptionObject2"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetParentRowId(IOptionObject2 optionObject, string formId)
        {
            if (optionObject == null)
                throw new System.NullReferenceException("Parameter 'optionObject' cannot be null.");
            return GetParentRowId(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Returns the ParentRowId of a <see cref="IFormObject"/> in the <see cref="IOptionObject2015"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetParentRowId(IOptionObject2015 optionObject, string formId)
        {
            if (optionObject == null)
                throw new System.NullReferenceException("Parameter 'optionObject' cannot be null.");
            if (formId == null || formId == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "formId");
            if (optionObject.Forms == null)
                throw new System.ArgumentException("The OptionObject does not contain any Forms.");
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetParentRowId(formObject);
                }
            }
            throw new System.ArgumentException("The FormObject with FormId " + formId + " does not exist in this OptionObject.");
        }
        /// <summary>
        /// Returns the ParentRowId of a <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string GetParentRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new System.NullReferenceException("Parameter 'formObject' cannot be null.");
            if (formObject.CurrentRow == null)
                throw new System.ArgumentException("The FormObject does not contain a CurrentRow.");
            return formObject.CurrentRow.ParentRowId;
        }
    }
}
