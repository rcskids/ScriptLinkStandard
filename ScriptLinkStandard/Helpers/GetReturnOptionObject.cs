using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Used to create the <see cref="IOptionObject"/> for return to myAvatar.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject GetReturnOptionObject(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetReturnOptionObject(optionObject.ToOptionObject2015(), 0, "").ToOptionObject();
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject"/> for return to myAvatar using provide Error Code and Error Message.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject GetReturnOptionObject(IOptionObject optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetReturnOptionObject(optionObject.ToOptionObject2015(), errorCode, errorMessage).ToOptionObject();
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2"/> for return to myAvatar.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2 GetReturnOptionObject(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetReturnOptionObject(optionObject, 0, "");
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2"/> for return to myAvatar using provide Error Code and Error Message.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject2 GetReturnOptionObject(IOptionObject2 optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetReturnOptionObject(optionObject.ToOptionObject2015(), errorCode, errorMessage).ToOptionObject2();
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2015"/> for return to myAvatar.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 GetReturnOptionObject(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetReturnOptionObject(optionObject, 0, "");
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2015"/> for return to myAvatar using provide Error Code and Error Message.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject2015 GetReturnOptionObject(IOptionObject2015 optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            IOptionObject2015 returnOptionObject = RemoveUneditedRows(optionObject);
            returnOptionObject = SetErrorCodeAndMessage(returnOptionObject, errorCode, errorMessage);
            return returnOptionObject;
        }

        #region HelperMethods
        private static IOptionObject2015 RemoveUneditedRows(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");

            List<FormObject> formsToRemove = new List<FormObject>();
            foreach (var formObject in optionObject.Forms)
            {
                // CurrentRow
                if (formObject.CurrentRow != null &&
                    (formObject.CurrentRow.RowAction == null ||
                    formObject.CurrentRow.RowAction == "" ||
                    !IsValidRowAction(formObject.CurrentRow.RowAction)))
                {
                    formObject.CurrentRow = null;
                }
                else if (formObject.CurrentRow != null && formObject.CurrentRow.RowAction == RowAction.Edit)
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
                        !IsValidRowAction(rowObject.RowAction))
                    {
                        rowsToRemove.Add(rowObject);
                    }
                    else if (rowObject.RowAction == RowAction.Edit)
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

            return optionObject;
        }

        private static IOptionObject2015 SetErrorCodeAndMessage(IOptionObject2015 optionObject, double errorCode = 0, string errorMessage = "")
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (!IsValidErrorCode(errorCode))
                throw new ArgumentException("Error Code is not valid.");
            if (errorCode == ErrorCode.OpenUrl && !IsValidUrl(errorMessage))
                throw new ArgumentException("Error Message is not a valid URL string.");
            if (errorCode == ErrorCode.OpenForm && !IsValidOpenFormString(errorMessage))
                throw new ArgumentException("Error Message is not a valid OpenForm string.");
            OptionObject2015 returnOptionObject = (OptionObject2015)optionObject;
            returnOptionObject.ErrorCode = errorCode;
            returnOptionObject.ErrorMesg = errorMessage;
            return returnOptionObject;
        }
        #endregion
    }
}
