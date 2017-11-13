using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject SetRequiredFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldObjects);
        }
        public static IOptionObject SetRequiredFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        public static IOptionObject SetRequiredFields(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        public static IOptionObject2 SetRequiredFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldObjects);
        }
        public static IOptionObject2 SetRequiredFields(IOptionObject2 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        public static IOptionObject2 SetRequiredFields(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }

        public static IOptionObject2015 SetRequiredFields(IOptionObject2015 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldObjects);
        }
        public static IOptionObject2015 SetRequiredFields(IOptionObject2015 optionObject2, List<string> fieldNumbers)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            return SetFieldObjects(optionObject2, "REQUIRED", fieldNumbers);
        }
        public static IOptionObject2015 SetRequiredFields(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }

        public static IFormObject SetRequiredFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            return SetFieldObjects(formObject, "REQUIRED", fieldNumbers);
        }
        public static IFormObject SetRequiredFields(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, "REQUIRED", fieldNumbers);
        }

        public static IRowObject SetRequiredFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            return SetFieldObjects(rowObject, "REQUIRED", fieldNumbers);
        }
        public static IRowObject SetRequiredFields(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, "REQUIRED", fieldNumbers);
        }
    }
}
