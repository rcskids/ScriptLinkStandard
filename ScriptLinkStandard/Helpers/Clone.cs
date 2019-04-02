using ScriptLinkStandard.Interfaces;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject Clone(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("The parameter cannot be null.", "optionObject");

            return TransformToOptionObject(optionObject.ToJson());
        }

        public static IOptionObject2 Clone(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("The parameter cannot be null.", "optionObject");

            return TransformToOptionObject2(optionObject.ToJson());
        }

        public static IOptionObject2015 Clone(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("The parameter cannot be null.", "optionObject");

            return TransformToOptionObject2015(optionObject.ToJson());
        }

        public static IFormObject Clone(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException("The parameter cannot be null.", "formObject");

            return TransformToFormObject(formObject.ToJson());
        }

        public static IRowObject Clone(IRowObject rowObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException("The parameter cannot be null.", "rowObject");

            return TransformToRowObject(rowObject.ToJson());
        }

        public static IFieldObject Clone(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException("The parameter cannot be null.", "fieldObject");

            return TransformToFieldObject(fieldObject.ToJson());
        }
    }
}
