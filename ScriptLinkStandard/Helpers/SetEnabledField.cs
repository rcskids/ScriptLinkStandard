using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledField(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObject(optionObject, FieldAction.Enable, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject2 SetEnabledField(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObject(optionObject, FieldAction.Enable, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetEnabledField(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject2");
            return SetFieldObject(optionObject, FieldAction.Enable, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetEnabledField(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            return SetFieldObject(formObject, FieldAction.Enable, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetEnabledField(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return SetFieldObject(rowObject, FieldAction.Enable, fieldNumber);
        }
    }
}
