using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldEnabled(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldEnabled(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject2"/> is enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldEnabled(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldEnabled(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject2015"/> is enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldEnabled(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (optionObject.Forms == null)
                throw new System.NullReferenceException("The OptionObject does not contain any Forms.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                    return IsFieldEnabled(form, fieldNumber);
            }
            throw new System.ArgumentException("The OptionObject does not contain the FieldObject " + fieldNumber + ".");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is enabled by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldEnabled(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new System.NullReferenceException("The FormObject does not contain a CurrentRow.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldEnabled(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is enabled by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldEnabled(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (rowObject.Fields == null)
                throw new System.NullReferenceException("The RowObject does not contain any FieldObjects.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldEnabled(field);
            }
            throw new System.ArgumentException("The FieldObject with FieldNumber " + fieldNumber + " does not exist in this RowObject.");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> is enabled.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static bool IsFieldEnabled(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "fieldObject");
            return fieldObject.Enabled == "1" ? true : false;
        }
    }
}
