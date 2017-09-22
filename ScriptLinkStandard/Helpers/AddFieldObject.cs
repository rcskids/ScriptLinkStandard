using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static RowObject AddFieldObject(IRowObject rowObject, IFieldObject fieldObject)
        {
            if (rowObject == null || fieldObject == null)
                return (RowObject)rowObject;                 // This should probably throw an exception
            if (rowObject.Fields.Contains((FieldObject)fieldObject))
                return (RowObject)rowObject;                 // This should probably throw an exception
            rowObject.Fields.Add((FieldObject)fieldObject);
            return (RowObject)rowObject;
        }

        public static RowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (rowObject == null)
                return (RowObject)rowObject;                 // This should probably throw an exception
            if (fieldNumber == null || fieldNumber == "")
                return (RowObject)rowObject;                 // This should probably throw an exception
            return AddFieldObject(rowObject, fieldNumber, fieldValue, false, false, false);
        }

        public static RowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue, string enabledValue, string lockedValue, string requiredValue)
        {
            if (rowObject == null)
                return (RowObject)rowObject;                 // This should probably throw an exception
            if (fieldNumber == null || fieldNumber == "")
                return (RowObject)rowObject;                 // This should probably throw an exception
            bool enabled = enabledValue == "1" ? true : false;
            bool locked = lockedValue == "1" ? true : false;
            bool required = requiredValue == "1" ? true : false;
            return AddFieldObject(rowObject, fieldNumber, fieldValue, enabled, locked, required);
        }

        public static RowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue, bool enabled, bool locked, bool required)
        {
            if (rowObject == null)
                return (RowObject)rowObject;                 // This should probably throw an exception
            if (fieldNumber == null || fieldNumber == "")
                return (RowObject)rowObject;                 // This should probably throw an exception
            FieldObject fieldObject = new FieldObject
            {
                Enabled = enabled ? "1" : "0",
                FieldNumber = fieldNumber,
                FieldValue = fieldValue,
                Lock = locked ? "1" : "0",
                Required = required ? "1" : "0"
            };
            return AddFieldObject(rowObject, fieldObject);
        }
    }
}
