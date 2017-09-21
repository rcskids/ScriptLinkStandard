using ScriptLinkStandard.Interfaces;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static string GetCurrentRowId(IOptionObject optionObject, string formId)
        {
            return GetCurrentRowId(optionObject.ToOptionObject2(), formId);
        }
        public static string GetCurrentRowId(IOptionObject2 optionObject, string formId)
        {
            if (optionObject.Forms != null)
            {
                foreach (var formObject in optionObject.Forms)
                {
                    if (formObject.FormId == formId)
                    {
                        return GetCurrentRowId(formObject);
                    }
                }
            }
            return null;
        }
        public static string GetCurrentRowId(IFormObject formObject)
        {
            if (formObject != null && formObject.CurrentRow != null)
            {
                return formObject.CurrentRow.RowId;
            }
            return null;
        }
    }
}
