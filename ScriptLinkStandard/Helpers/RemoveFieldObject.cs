using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Removes a <see cref="IFieldObject"/> from a <see cref="IRowObject"/>.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static IRowObject RemoveFieldObject(IRowObject rowObject, IFieldObject fieldObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "fieldObject");
            rowObject.Fields.Remove((FieldObject)fieldObject);
            return (RowObject)rowObject;
        }
        /// <summary>
        /// Removes a <see cref="IFieldObject"/> from a <see cref="IRowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject RemoveFieldObject(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "fieldNumber");
            FieldObject fieldObject = rowObject.Fields.Find(f => f.FieldNumber == fieldNumber);
            if (fieldObject == null)
                throw new NullReferenceException("The RowObject does not contain this FieldObject.");
            return RemoveFieldObject(rowObject, fieldObject);
        }
    }
}
