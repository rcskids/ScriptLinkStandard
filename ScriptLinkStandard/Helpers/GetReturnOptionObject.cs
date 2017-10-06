using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Used to create the returning optionObject.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static OptionObject GetReturnOptionObject(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return GetReturnOptionObject(optionObject.ToOptionObject2(), 0, "").ToOptionObject();
        }
        public static OptionObject GetReturnOptionObject(IOptionObject optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (!IsValidErrorCode(errorCode))
                throw new System.ArgumentException("Error Code is not valid.");
            return GetReturnOptionObject(optionObject.ToOptionObject2(), errorCode, errorMessage).ToOptionObject();
        }
        public static OptionObject2 GetReturnOptionObject(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            return GetReturnOptionObject(optionObject, 0, "");
        }
        public static OptionObject2 GetReturnOptionObject(IOptionObject2 optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (!IsValidErrorCode(errorCode))
                throw new System.ArgumentException("Error Code is not valid.");
            OptionObject2 returnOptionObject = RemoveUneditedRows(optionObject);
            returnOptionObject = SetErrorCodeAndMessage(returnOptionObject, errorCode, errorMessage);
            return returnOptionObject;
        }

        private static OptionObject2 RemoveUneditedRows(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");

            List<FormObject> formsToRemove = new List<FormObject>();
            foreach (var formObject in optionObject.Forms)
            {
                // CurrentRow
                if (formObject.CurrentRow != null && 
                    (formObject.CurrentRow.RowAction == null || 
                    formObject.CurrentRow.RowAction == "" ||
                    !ScriptLinkHelpers.IsValidRowAction(formObject.CurrentRow.RowAction)))
                {
                    formObject.CurrentRow = null;
                }
                else if (formObject.CurrentRow != null && formObject.CurrentRow.RowAction == "EDIT")
                {
                    List<FieldObject> fieldsToRemove = new List<FieldObject>();
                    foreach (FieldObject fieldObject in formObject.CurrentRow.Fields)
                    {
                        if (!fieldObject.IsModified())
                            fieldsToRemove.Add(fieldObject);
                    }
                    foreach (var fieldObject in fieldsToRemove)
                    {
                        formObject.CurrentRow.Fields.Remove(fieldObject);
                    }
                }

                // OtherRows
                List<RowObject> rowsToRemove = new List<RowObject>();
                foreach (var rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowAction == null || 
                        rowObject.RowAction == "" ||
                        !ScriptLinkHelpers.IsValidRowAction(rowObject.RowAction))
                    {
                        rowsToRemove.Add(rowObject);
                    }
                    else if (rowObject.RowAction == "EDIT")
                    {
                        List<FieldObject> fieldsToRemove = new List<FieldObject>();
                        foreach (FieldObject fieldObject in rowObject.Fields)
                        {
                            if (!fieldObject.IsModified())
                                fieldsToRemove.Add(fieldObject);
                        }
                        foreach (var fieldObject in fieldsToRemove)
                        {
                            rowObject.Fields.Remove(fieldObject);
                        }
                    }
                }
                foreach (var rowObject in rowsToRemove)
                {
                    formObject.OtherRows.Remove(rowObject);
                }
                if (formObject.CurrentRow == null && formObject.OtherRows.Count == 0)
                {
                    formsToRemove.Add(formObject);
                }
                else if (formObject.OtherRows.Count == 0)
                {
                    formObject.OtherRows = null;
                }
            }
            foreach (var formObject in formsToRemove)
            {
                optionObject.Forms.Remove(formObject);
            }

            return (OptionObject2)optionObject;
        }
        
        private static OptionObject2 SetErrorCodeAndMessage(IOptionObject2 optionObject, double errorCode = 0, string errorMessage = "")
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (!IsValidErrorCode(errorCode))
                throw new System.ArgumentException("Error Code is not valid.");
            OptionObject2 returnOptionObject = new OptionObject2();
            returnOptionObject = (OptionObject2)optionObject;
            returnOptionObject.ErrorCode = errorCode;
            returnOptionObject.ErrorMesg = errorMessage;
            return returnOptionObject;
        }
    }
}
