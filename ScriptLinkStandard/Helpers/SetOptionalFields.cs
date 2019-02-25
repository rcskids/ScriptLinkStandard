using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as optional.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetOptionalFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as optional by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetOptionalFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as optional by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetOptionalFields(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as optional.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject2 SetOptionalFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as optional by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject2 SetOptionalFields(IOptionObject2 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as optional by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject2 SetOptionalFields(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as optional.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetOptionalFields(IOptionObject2015 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as optional by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetOptionalFields(IOptionObject2015 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as optional by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetOptionalFields(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as optional by FieldNumbers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetOptionalFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            return SetFieldObjects(formObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as optional by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetOptionalFields(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as optional by FieldNumbers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetOptionalFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return SetFieldObjects(rowObject, "OPTIONAL", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as optional by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetOptionalFields(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, "OPTIONAL", fieldNumbers);
        }
    }
}