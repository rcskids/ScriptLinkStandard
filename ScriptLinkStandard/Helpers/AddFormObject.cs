using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject AddFormObject(IOptionObject optionObject, IFormObject formObject)
        {
            if (optionObject == null || formObject == null)
                return (OptionObject)optionObject;
            return AddFormObject(optionObject.ToOptionObject2(), formObject).ToOptionObject();
        }

        public static OptionObject AddFormObject(IOptionObject optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                return (OptionObject)optionObject;
            return AddFormObject(optionObject.ToOptionObject2(), formId, multipleIteration).ToOptionObject();
        }

        public static OptionObject2 AddFormObject(IOptionObject2 optionObject, IFormObject formObject)
        {
            if (optionObject == null || formObject == null)
                return (OptionObject2)optionObject;
            if (optionObject.Forms.Count == 0 && formObject.MultipleIteration)
                return (OptionObject2)optionObject;
            if (optionObject.Forms.Contains((FormObject)formObject) || optionObject.Forms.Exists(f => f.FormId == formObject.FormId))
                return (OptionObject2)optionObject;
            optionObject.Forms.Add((FormObject)formObject);
            return (OptionObject2)optionObject;
        }

        public static OptionObject2 AddFormObject(IOptionObject2 optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                return (OptionObject2)optionObject;
            FormObject formObject = new FormObject
            {
                FormId = formId,
                MultipleIteration = multipleIteration
            };
            return AddFormObject(optionObject, formObject);
        }
    }
}
