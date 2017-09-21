using ScriptLinkStandard.Interfaces;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool GetMultipleIterationStatus(IOptionObject optionObject, string formId)
        {
            return GetMultipleIterationStatus(optionObject.ToOptionObject2(), formId);
        }
        public static bool GetMultipleIterationStatus(IOptionObject2 optionObject, string formId)
        {
            if (optionObject.Forms != null)
            {
                foreach (var formObject in optionObject.Forms)
                {
                    if (formObject.FormId == formId)
                    {
                        return GetMultipleIterationStatus(formObject);
                    }
                }
            }
            return false;
        }
        public static bool GetMultipleIterationStatus(IFormObject formObject)
        {
            if (formObject != null)
            {
                return formObject.MultipleIteration;
            }
            return false;
        }
    }
}
