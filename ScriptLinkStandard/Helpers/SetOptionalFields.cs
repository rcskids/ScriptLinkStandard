using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject SetOptionalFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldObjects);
        }
        public static IOptionObject SetOptionalFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        public static IOptionObject SetOptionalFields(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        public static IOptionObject2 SetOptionalFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldObjects);
        }
        public static IOptionObject2 SetOptionalFields(IOptionObject2 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        public static IOptionObject2 SetOptionalFields(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }

        public static IOptionObject2015 SetOptionalFields(IOptionObject2015 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldObjects);
        }
        public static IOptionObject2015 SetOptionalFields(IOptionObject2015 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        public static IOptionObject2015 SetOptionalFields(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }

        public static IFormObject SetOptionalFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            return SetFieldObjects(formObject, "OPTIONAL", fieldNumbers);
        }
        public static IFormObject SetOptionalFields(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, "OPTIONAL", fieldNumbers);
        }

        public static IRowObject SetOptionalFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            return SetFieldObjects(rowObject, "OPTIONAL", fieldNumbers);
        }
        public static IRowObject SetOptionalFields(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, "OPTIONAL", fieldNumbers);
        }
    }
}