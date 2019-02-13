using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

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
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (fieldObject == null)
                throw new System.ArgumentException("Parameter cannot be null.", "fieldObject");
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
                throw new System.ArgumentException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentException("Parameter cannot be null or blank.", "fieldNumber");
            FieldObject fieldObject = rowObject.Fields.Find(f => f.FieldNumber == fieldNumber);
            if (fieldObject == null)
                throw new System.ArgumentException("The RowObject does not contain this FieldObject.", "fieldNumber");
            return RemoveFieldObject(rowObject, fieldObject);
        }
    }
}
