using ScriptLinkStandard.Interfaces;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns a list of FieldValues of a specified <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static List<string> GetFieldValues(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetFieldValues(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns a list of FieldValues of a specified <see cref="IFieldObject"/> in the <see cref="IOptionObject2"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static List<string> GetFieldValues(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetFieldValues(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns a list of FieldValues of a specified <see cref="IFieldObject"/> in the <see cref="IOptionObject2015"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static List<string> GetFieldValues(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new NullReferenceException("There are no FormObjects in this OptionObject");
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                {
                    return GetFieldValues(form, fieldNumber);
                }
            }
            return new List<string>();
        }
        /// <summary>
        /// Returns a list of FieldValues of a specified <see cref="IFieldObject"/> in the <see cref="IFormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static List<string> GetFieldValues(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not have a CurrentRow.");
            List<string> values = new List<string>();
            if (formObject.MultipleIteration == false && IsFieldPresent(formObject, fieldNumber))
            {
                values.Add(GetFieldValue(formObject.CurrentRow, fieldNumber));
                return values;
            }
            else if(formObject.MultipleIteration == true && IsFieldPresent(formObject, fieldNumber))
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
