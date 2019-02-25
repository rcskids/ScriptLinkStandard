using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldLocked(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject2"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldLocked(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject2015"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IOptionObject2015 optionObject, string fieldNumber)
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
                    return IsFieldLocked(form, fieldNumber);
            }
            throw new ArgumentException("The OptionObject does not contain the FieldObject " + fieldNumber + ".");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not contain a CurrentRow.");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldLocked(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IRowObject rowObject, string fieldNumber)
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
                    return IsFieldLocked(field);
            }
            throw new ArgumentException("The FieldObject with FieldNumber " + fieldNumber + " does not exist in this RowObject.");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> is locked.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "fieldObject");
            return fieldObject.Lock == "1" ? true : false;
        }
    }
}
