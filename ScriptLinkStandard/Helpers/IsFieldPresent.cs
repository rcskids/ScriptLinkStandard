using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is present by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldPresent(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject2"/> is present by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldPresent(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject2015"/> is present by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (optionObject.Forms == null)
                throw new NullReferenceException("The OptionObject does not contain any Forms.");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is present by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            if (formObject.CurrentRow == null)
                return false;
            return IsFieldPresent(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is present by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (rowObject.Fields == null)
                throw new NullReferenceException("The RowObject does not contain any FieldObjects.");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return true;
            }
            return false;
        }
    }
}
