using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms a Json-formatted <see cref="System.String"/> to <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="serializedString">A Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="FieldObject"/>.</returns>
        public static IFieldObject TransformToFieldObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                FieldObject fieldObject = DeserializeObject<FieldObject>(serializedString);
                return fieldObject;
            }
            catch
            {
                // Not valid XML or doesn't match the FieldObject specification
            }
            try
            {
                FieldObject fieldObject = JsonConvert.DeserializeObject<FieldObject>(serializedString);
                return fieldObject;
            }
            catch
            {
                // Not valid JSON or doesn't match the FieldObject specification
            }
            throw new System.ArgumentException("Serialized string is not in a compatible format.", "serializedString");
        }
    }
}
