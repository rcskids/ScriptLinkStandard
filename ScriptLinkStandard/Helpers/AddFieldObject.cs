using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/>.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, IFieldObject fieldObject)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "fieldObject");
            if (rowObject.Fields.Contains((FieldObject)fieldObject))
                throw new System.ArgumentException("The RowObject already contains this FieldObject.");
            if (rowObject.Fields.Exists(f => f.FieldNumber == fieldObject.FieldNumber))
                throw new System.ArgumentException("The RowObject already contains a FieldObject with this FieldNumber.");
            rowObject.Fields.Add((FieldObject)fieldObject);
            return rowObject;
        }
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/> using supplied FieldNumber and FieldValue.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("The FieldNumber cannot be null or blank.");
            return AddFieldObject(rowObject, fieldNumber, fieldValue, false, false, false);
        }
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/> using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values (e.g., Y or N).
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabledValue"></param>
        /// <param name="lockedValue"></param>
        /// <param name="requiredValue"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue, string enabledValue, string lockedValue, string requiredValue)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("The FieldNumber cannot be null or blank.");
            bool enabled = enabledValue == "1" ? true : false;
            bool locked = lockedValue == "1" ? true : false;
            bool required = requiredValue == "1" ? true : false;
            return AddFieldObject(rowObject, fieldNumber, fieldValue, enabled, locked, required);
        }
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/> using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabled"></param>
        /// <param name="locked"></param>
        /// <param name="required"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue, bool enabled, bool locked, bool required)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException("Parameter cannot be null.", "rowObject");
            if (fieldNumber == null || fieldNumber == "")
                throw new System.ArgumentNullException("The FieldNumber cannot be null or blank.");
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
