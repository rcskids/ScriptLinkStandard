using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldValue(IOptionObject optionObject, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return SetFieldValue(optionObject.ToOptionObject2015(), fieldNumber, fieldValue).ToOptionObject(); ;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject"/> by FormId, RowID, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return SetFieldValue(optionObject.ToOptionObject2015(), formId, rowId, fieldNumber, fieldValue).ToOptionObject();
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject2"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject2 SetFieldValue(IOptionObject2 optionObject, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return SetFieldValue(optionObject.ToOptionObject2015(), fieldNumber, fieldValue).ToOptionObject2(); ;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject2"/> by FormId, RowID, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject2 SetFieldValue(IOptionObject2 optionObject, string formId, string rowId, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            return SetFieldValue(optionObject.ToOptionObject2015(), formId, rowId, fieldNumber, fieldValue).ToOptionObject2();
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject2015"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetFieldValue(IOptionObject2015 optionObject, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (optionObject.Forms == null)
                throw new NullReferenceException("There are no FormObjects in the OptionObject.");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (FormObject formObject in optionObject.Forms)
            {
                if (formObject.IsFieldPresent(fieldNumber))
                {
                    if (formObject.MultipleIteration && formObject.OtherRows.Count > 0)
                        throw new ArgumentException("Unable to determine which FieldObject to update. Please specify the FormId and RowId associated with the intended FieldObject.", "optionObject");

                    string formId = formObject.FormId;
                    string rowId = formObject.GetCurrentRowId();
                    return SetFieldValue(optionObject, formId, rowId, fieldNumber, fieldValue);
                }
            }
            throw new ArgumentException("The specified FieldObject was not found in this OptionObject.", "optionObject");
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject2015"/> by FormId, RowID, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject2015 SetFieldValue(IOptionObject2015 optionObject, string formId, string rowId, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "optionObject");
            if (formId == null || formId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "formId");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            if (optionObject.Forms == null)
                throw new NullReferenceException("There are no FormObjects in the provided OptionObject.");
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].FormId == formId)
                    optionObject.Forms[i] = (FormObject)SetFieldValue(optionObject.Forms[i], rowId, fieldNumber, fieldValue);
            }
            return optionObject;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IFormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IFormObject SetFieldValue(IFormObject formObject, string fieldNumber, string fieldValue)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject has no CurrentRow.");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            if (formObject.MultipleIteration && formObject.OtherRows.Count > 0)
                throw new ArgumentException("Unable to determine which FieldObject to update. Please specify the FormId and RowId associated with the intended FieldObject.", "optionObject");
            return SetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber, fieldValue);
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IFormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IFormObject SetFieldValue(IFormObject formObject, string rowId, string fieldNumber, string fieldValue)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not have a CurrentRow.");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            if (formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow = (RowObject)SetFieldValue(formObject.CurrentRow, fieldNumber, fieldValue);
                return formObject;
            }
            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    if (formObject.OtherRows[i].RowId == rowId)
                    {
                        formObject.OtherRows[i] = (RowObject)SetFieldValue(formObject.OtherRows[i], fieldNumber, fieldValue);
                        return formObject;
                    }
                }
            }
            throw new ArgumentException("The specified FieldObject was not found in this FormObject.", "formObject");
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IRowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IRowObject SetFieldValue(IRowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            for (int i = 0; i < rowObject.Fields.Count; i++)
            {
                if (rowObject.Fields[i].FieldNumber == fieldNumber)
                {
                    rowObject.Fields[i] = (FieldObject)SetFieldValue(rowObject.Fields[i], fieldValue);
                    rowObject.RowAction = RowAction.Edit;
                    break;
                }
            }
            return rowObject;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IFieldObject SetFieldValue(IFieldObject fieldObject, string fieldValue)
        {
            if (fieldObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "fieldObject");
            fieldObject.FieldValue = fieldValue;
            fieldObject.SetAsModified();
            return fieldObject;
        }
    }
}
