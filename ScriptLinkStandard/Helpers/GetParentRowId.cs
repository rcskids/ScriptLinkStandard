using ScriptLinkStandard.Interfaces;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static string GetParentRowId(IOptionObject optionObject, string formId)
        {
            return GetParentRowId(optionObject.ToOptionObject2(), formId);
        }
        public static string GetParentRowId(IOptionObject2 optionObject, string formId)
        {
            if (optionObject.Forms != null)
            {
                foreach (var formObject in optionObject.Forms)
                {
                    if (formObject.FormId == formId)
                    {
                        return GetParentRowId(formObject);
                    }
                }
            }
            return null;
        }
        public static string GetParentRowId(IFormObject formObject)
        {
            if (formObject != null && formObject.CurrentRow != null)
            {
                return formObject.CurrentRow.ParentRowId;
            }
            return null;
        }
    }
}
