using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a <see cref="FormObject"/> exists in an <see cref="OptionObject"/> by <see cref="FormObject.FormId"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool IsFormPresent(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            return IsFormPresent(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Returns whether a <see cref="FormObject"/> exists in an <see cref="OptionObject2"/> by <see cref="FormObject.FormId"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool IsFormPresent(IOptionObject2 optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            return IsFormPresent(optionObject.ToOptionObject2015(), formId);
        }
        /// <summary>
        /// Returns whether a <see cref="FormObject"/> exists in an <see cref="OptionObject2015"/> by <see cref="FormObject.FormId"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool IsFormPresent(IOptionObject2015 optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                return false;
            return optionObject.Forms.Exists(f => f.FormId == formId);
        }
    }
}
