using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static IOptionObject SetLockedFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "LOCKED", fieldObjects);
        }
        public static IOptionObject SetLockedFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "LOCKED", fieldNumbers);
        }
        public static IOptionObject SetLockedFields(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "LOCKED", fieldNumbers);
        }
        public static IOptionObject2 SetLockedFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "LOCKED", fieldObjects);
        }
        public static IOptionObject2 SetLockedFields(IOptionObject2 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "LOCKED", fieldNumbers);
        }
        public static IOptionObject2 SetLockedFields(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "LOCKED", fieldNumbers);
        }

        public static IOptionObject2015 SetLockedFields(IOptionObject2015 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "LOCKED", fieldObjects);
        }
        public static IOptionObject2015 SetLockedFields(IOptionObject2015 optionObject2, List<string> fieldNumbers)
        {
            if (optionObject2 == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject2");
            return SetFieldObjects(optionObject2, "LOCKED", fieldNumbers);
        }
        public static IOptionObject2015 SetLockedFields(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "LOCKED", fieldNumbers);
        }

        public static IFormObject SetLockedFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            return SetFieldObjects(formObject, "LOCKED", fieldNumbers);
        }
        public static IFormObject SetLockedFields(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, "LOCKED", fieldNumbers);
        }

        public static IRowObject SetLockedFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            return SetFieldObjects(rowObject, "LOCKED", fieldNumbers);
        }
        public static IRowObject SetLockedFields(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, "LOCKED", fieldNumbers);
        }
    }
}
