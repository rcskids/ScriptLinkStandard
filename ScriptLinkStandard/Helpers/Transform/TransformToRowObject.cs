using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms a Json-formatted <see cref="System.String"/> to <see cref="RowObject"/>.
        /// </summary>
        /// <param name="serializedString">A Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="RowObject"/>.</returns>
        public static IRowObject TransformToRowObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                RowObject rowObject = JsonConvert.DeserializeObject<RowObject>(serializedString);
                return rowObject;
            }
            catch
            {
                // Not valid JSON or doesn't match the FieldObject specification
            }
            // Future implementation: XML?
            throw new System.ArgumentException("Serialized string is not in a compatible format.", "serializedString");
        }
    }
}
