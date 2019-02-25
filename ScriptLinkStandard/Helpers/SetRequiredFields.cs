using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as required.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetRequiredFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as required by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetRequiredFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as required by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetRequiredFields(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as required.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject2 SetRequiredFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as required by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject2 SetRequiredFields(IOptionObject2 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2"/> as required by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject2 SetRequiredFields(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as required.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetRequiredFields(IOptionObject2015 optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as required by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetRequiredFields(IOptionObject2015 optionObject, List<string> fieldNumbers)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject2015"/> as required by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetRequiredFields(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as required by FieldNumbers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetRequiredFields(IFormObject formObject, List<string> fieldNumbers)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            return SetFieldObjects(formObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as required by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetRequiredFields(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as required by FieldNumbers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetRequiredFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            return SetFieldObjects(rowObject, "REQUIRED", fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as required by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetRequiredFields(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, "REQUIRED", fieldNumbers);
        }
    }
}
