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
            OptionObject2 returnOptionObject = GetReturnOptionObject(optionObject.ToOptionObject2(), 0, "");
            return returnOptionObject.ToOptionObject();
        }
        public static OptionObject GetReturnOptionObject(IOptionObject optionObject, double errorCode, string errorMessage)
        {
            OptionObject2 returnOptionObject = GetReturnOptionObject(optionObject.ToOptionObject2(), errorCode, errorMessage);
            return returnOptionObject.ToOptionObject();
        }
        public static OptionObject2 GetReturnOptionObject(IOptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = GetReturnOptionObject(optionObject, 0, "");
            return returnOptionObject;
        }
        public static OptionObject2 GetReturnOptionObject(IOptionObject2 optionObject, double errorCode, string errorMessage)
        {
            OptionObject2 returnOptionObject = RemoveUneditedRows(optionObject);
            returnOptionObject = SetErrorCodeAndMessage(returnOptionObject, errorCode, errorMessage);
            return returnOptionObject;
        }

        private static OptionObject2 RemoveUneditedRows(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                return (OptionObject2)optionObject;

            List<FormObject> formsToRemove = new List<FormObject>();
            foreach (var formObject in optionObject.Forms)
            {
                // CurrentRow
                if (formObject.CurrentRow != null && (formObject.CurrentRow.RowAction == null || formObject.CurrentRow.RowAction == ""))
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
                    if (rowObject.RowAction == null || rowObject.RowAction == "")
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
            }
            foreach (var formObject in formsToRemove)
            {
                optionObject.Forms.Remove(formObject);
            }

            return (OptionObject2)optionObject;
        }

        private static OptionObject2 CreateOptionObjectHeader(IOptionObject2 optionObject)
        {
            OptionObject2 returnOptionObject = new OptionObject2();
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            returnOptionObject.NamespaceName = optionObject.NamespaceName;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
            returnOptionObject.ServerName = optionObject.ServerName;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            return returnOptionObject;
        }
        
        private static OptionObject2 SetErrorCodeAndMessage(IOptionObject2 optionObject, double errorCode = 0, string errorMessage = "")
        {
            OptionObject2 returnOptionObject = new OptionObject2();
            returnOptionObject = (OptionObject2)optionObject;
            if (errorCode >= 0 && errorCode <= 5)
            {
                returnOptionObject.ErrorCode = errorCode;
                returnOptionObject.ErrorMesg = errorMessage;
            }
            else
            {
                returnOptionObject.ErrorCode = 1;
                returnOptionObject.ErrorMesg = "Invalid error code selected (" + errorCode.ToString() + "). Please contact your myAvatar administrator.";
            }
            return returnOptionObject;
        }
    }
}
