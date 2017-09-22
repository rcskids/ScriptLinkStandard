using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        public static RowObject RemoveFieldObject(IRowObject rowObject, IFieldObject fieldObject)
        {
            if (rowObject == null || fieldObject == null)
                return (RowObject)rowObject;
            rowObject.Fields.Remove((FieldObject)fieldObject);
            return (RowObject)rowObject;
        }

        public static RowObject RemoveFieldObject(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                return (RowObject)rowObject;
            FieldObject fieldObject = rowObject.Fields.Find(f => f.FieldNumber == fieldNumber);
            if (fieldObject == null)
                return (RowObject)rowObject;
            return RemoveFieldObject(rowObject, fieldObject);
        }
    }
}
