using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static List<string> GetFieldValues(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            return GetFieldValues(optionObject.ToOptionObject2(), fieldNumber);
        }

        public static List<string> GetFieldValues(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentException("Parameter cannot be null", "optionObject");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new ArgumentException("There are no FormObjects in this OptionObject", "optionObject");
            foreach (var form in optionObject.Forms)
            {
                if (ScriptLinkHelpers.IsFieldPresent(form, fieldNumber))
                {
                    return GetFieldValues(form, fieldNumber);
                }
            }
            return new List<string>();
        }

        public static List<string> GetFieldValues(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentException("Parameter cannot be null", "formObject");
            if (formObject.CurrentRow == null)
                throw new ArgumentException("The FormObject does not have a CurrentRow.", "formObject");
            List<string> values = new List<string>();
            if (formObject.MultipleIteration == false && ScriptLinkHelpers.IsFieldPresent(formObject, fieldNumber))
            {
                values.Add(GetFieldValue(formObject.CurrentRow, fieldNumber));
                return values;
            }
            else if(formObject.MultipleIteration == true && ScriptLinkHelpers.IsFieldPresent(formObject, fieldNumber))
            {
                values.Add(GetFieldValue(formObject.CurrentRow, fieldNumber));
                foreach (var row in formObject.OtherRows)
                {
                    values.Add(GetFieldValue(row, fieldNumber));
                }
                return values;
            }
            return values;
        }
    }
}
