using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject SetDisabledFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            return SetDisabledFields(optionObject.ToOptionObject2(), fieldObjects).ToOptionObject();
        }
        public static OptionObject SetDisabledFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            return SetDisabledFields(optionObject.ToOptionObject2(), fieldNumbers).ToOptionObject();
        }

        public static OptionObject2 SetDisabledFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            List<string> fieldNumbers = GetFieldNumbersToDisable(fieldObjects);
            return SetDisabledFields(optionObject, fieldNumbers);
        }
        public static OptionObject2 SetDisabledFields(IOptionObject2 optionObject2, List<string> requiredFields)
        {
            int fieldsFound = 0;
            if (requiredFields.Count > 0)
            {
                foreach (var requiredField in requiredFields)
                {
                    if (optionObject2.Forms != null && optionObject2.Forms.Count > 0)
                    {
                        foreach (var formObject in optionObject2.Forms)
                        {
                            if (ScriptLinkHelpers.IsFieldPresent(formObject, requiredField))
                            {
                                if (ScriptLinkHelpers.IsFieldPresent(formObject.CurrentRow, requiredField))
                                {
                                    foreach (var fieldObject in formObject.CurrentRow.Fields)
                                    {
                                        if (fieldObject.FieldNumber == requiredField)
                                        {
                                            fieldObject.SetAsDisabled();
                                            fieldObject.SetAsOptional();
                                        }
                                    }
                                    formObject.CurrentRow.RowAction = "EDIT";
                                    fieldsFound++;
                                }
                                else
                                {
                                    foreach (var rowObject in formObject.OtherRows)
                                    {
                                        foreach (var fieldObject in rowObject.Fields)
                                        {
                                            if (fieldObject.FieldNumber == requiredField)
                                            {
                                                fieldObject.SetAsDisabled();
                                                fieldObject.SetAsOptional();
                                            }
                                        }
                                        rowObject.RowAction = "EDIT";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        optionObject2.ErrorCode = 3;
                        optionObject2.ErrorMesg = "There are no forms in this OptionObject.";
                    }
                }
            }
            else
            {
                optionObject2.ErrorCode = 3;
                optionObject2.ErrorMesg = "No required fields were identified for this form";
            }
            if (fieldsFound == 0)
            {
                optionObject2.ErrorCode = 3;
                optionObject2.ErrorMesg = "The required fields were not found on this form.";
            }
            return (OptionObject2)optionObject2;
        }

        private static List<string> GetFieldNumbersToDisable(List<FieldObject> fieldObjects)
        {
            List<string> fieldNumbers = new List<string>();
            foreach (var fieldObject in fieldObjects)
            {
                fieldNumbers.Add(fieldObject.FieldNumber);
            }
            return fieldNumbers;
        }
    }
}
