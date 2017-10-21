using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject AddFormObject(IOptionObject optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formObject).ToOptionObject();
        }

        public static OptionObject AddFormObject(IOptionObject optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formId, multipleIteration).ToOptionObject();
        }
        public static OptionObject2 AddFormObject(IOptionObject2 optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formObject).ToOptionObject2();
        }

        public static OptionObject2 AddFormObject(IOptionObject2 optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return AddFormObject(optionObject.ToOptionObject2015(), formId, multipleIteration).ToOptionObject2();
        }

        public static OptionObject2015 AddFormObject(IOptionObject2015 optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            if (optionObject.Forms.Count == 0 && formObject.MultipleIteration)
                throw new ArgumentException("The first FormObject cannot be a Multiple Iteration form.");
            if (optionObject.Forms.Contains((FormObject)formObject) || optionObject.Forms.Exists(f => f.FormId == formObject.FormId))
                throw new ArgumentException("A FormObject with this FormId already exists.");
            optionObject.Forms.Add((FormObject)formObject);
            return (OptionObject2015)optionObject;
        }

        public static OptionObject2015 AddFormObject(IOptionObject2015 optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            FormObject formObject = new FormObject
            {
                FormId = formId,
                MultipleIteration = multipleIteration
            };
            return AddFormObject(optionObject, formObject);
        }
    }
}
