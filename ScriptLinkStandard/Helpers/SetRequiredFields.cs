using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static OptionObject SetRequiredFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            return SetRequiredFields(optionObject.ToOptionObject2(), fieldObjects).ToOptionObject();
        }
        public static OptionObject SetRequiredFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            return SetRequiredFields(optionObject.ToOptionObject2(), fieldNumbers).ToOptionObject();
        }

        public static OptionObject2 SetRequiredFields(IOptionObject2 optionObject, List<FieldObject> fieldObjects)
        {
            List<string> fieldNumbers = GetFieldNumbersToRequire(fieldObjects);
            return SetRequiredFields(optionObject, fieldNumbers);
        }
        public static OptionObject2 SetRequiredFields(IOptionObject2 optionObject2, List<string> requiredFields)
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
                                            fieldObject.SetAsEnabled();
                                            fieldObject.SetAsRequired();
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
                                                fieldObject.SetAsEnabled();
                                                fieldObject.SetAsRequired();
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

        private static List<string> GetFieldNumbersToRequire(List<FieldObject> fieldObjects)
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
