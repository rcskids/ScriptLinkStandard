using ScriptLinkStandard.Interfaces;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static string GetCurrentRowId(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return GetCurrentRowId(optionObject.ToOptionObject2(), formId);
        }
        public static string GetCurrentRowId(IOptionObject2 optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return GetCurrentRowId(optionObject.ToOptionObject2015(), formId);
        }
        public static string GetCurrentRowId(IOptionObject2015 optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (formId == null || formId == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "formId");
            if (optionObject.Forms == null)
                throw new System.ArgumentException("The OptionObject does not contain any Forms.");
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetCurrentRowId(formObject);
                }
            }
            throw new System.ArgumentException("The FormObject with FormId " + formId + " does not exist in this OptionObject.");
        }
        public static string GetCurrentRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            if (formObject.CurrentRow == null)
                throw new System.ArgumentException("The FormObject does not contain a CurrentRow.");
            return formObject.CurrentRow.RowId;
        }
    }
}
