﻿using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static bool IsFieldEnabled(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldEnabled(optionObject.ToOptionObject2(), fieldNumber);
        }
        public static bool IsFieldEnabled(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "optionObject");
            if (optionObject.Forms == null)
                throw new System.ArgumentException("The OptionObject does not contain any Forms.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                {
                    return IsFieldEnabled(form, fieldNumber);
                }
            }
            throw new System.ArgumentException("The OptionObject does not contain the FieldObject " + fieldNumber + ".");
        }

        public static bool IsFieldEnabled(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "formObject");
            if (formObject.CurrentRow == null)
                throw new System.ArgumentException("The FormObject does not contain a CurrentRow.");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            return IsFieldEnabled(formObject.CurrentRow, fieldNumber);
        }

        public static bool IsFieldEnabled(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldEnabled(field);
            }
            throw new System.ArgumentException("The FieldObject with FieldNumber " + fieldNumber + " does not exist in this RowObject.");
        }

        public static bool IsFieldEnabled(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "fieldObject");
            return fieldObject.Enabled == "1" ? true : false;
        }
    }
}
