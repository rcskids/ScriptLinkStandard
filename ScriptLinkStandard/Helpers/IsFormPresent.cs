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
        /// Returns whether a <see cref="FormObject"/> exists in an <see cref="OptionObject"/> by <see cref="FormObject.FormId"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool IsFormPresent(IOptionObject optionObject, string formId)
        {
            return IsFormPresent(optionObject.ToOptionObject2(), formId);
        }
        /// <summary>
        /// Returns whether a <see cref="FormObject"/> exists in an <see cref="OptionObject2"/> by <see cref="FormObject.FormId"/>.
        /// </summary>
        /// <param name="optionObject2"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static bool IsFormPresent(IOptionObject2 optionObject2, string formId)
        {
            if (optionObject2 == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentException("Parameter cannot be null or blank.", "formId");
            if (optionObject2.Forms == null || optionObject2.Forms.Count == 0)
                return false;
            return optionObject2.Forms.Exists(f => f.FormId == formId);
        }
    }
}
