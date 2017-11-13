using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject SetDisabledFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "DISABLED", fieldObjects);
        }
        public static IOptionObject SetDisabledFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "DISABLED", fieldNumbers);
        }
        public static IOptionObject SetDisabledFields(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "DISABLED", fieldNumbers);
        }
        public static IOptionObject2 SetDisabledFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "DISABLED", fieldObjects);
        }
        public static IOptionObject2 SetDisabledFields(IOptionObject2 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "DISABLED", fieldNumbers);
        }
        public static IOptionObject2 SetDisabledFields(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "DISABLED", fieldNumbers);
        }

        public static IOptionObject2015 SetDisabledFields(IOptionObject2015 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "DISABLED", fieldObjects);
        }
        public static IOptionObject2015 SetDisabledFields(IOptionObject2015 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            return SetFieldObjects(optionObject, "DISABLED", fieldNumbers);
        }
        public static IOptionObject2015 SetDisabledFields(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "DISABLED", fieldNumbers);
        }

        public static IFormObject SetDisabledFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            return SetFieldObjects(formObject, "DISABLED", fieldNumbers);
        }
        public static IFormObject SetDisabledFields(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, "DISABLED", fieldNumbers);
        }

        public static IRowObject SetDisabledFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            return SetFieldObjects(rowObject, "DISABLED", fieldNumbers);
        }
        public static IRowObject SetDisabledFields(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, "DISABLED", fieldNumbers);
        }
    }
}
