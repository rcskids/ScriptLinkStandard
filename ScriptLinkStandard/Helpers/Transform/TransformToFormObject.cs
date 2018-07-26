using Newtonsoft.Json;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms a Json-formatted <see cref="System.String"/> to <see cref="FormObject"/>.
        /// </summary>
        /// <param name="serializedString">A Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="FormObject"/>.</returns>
        public static IFormObject TransformToFormObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                FormObject formObject = JsonConvert.DeserializeObject<FormObject>(serializedString);
                return formObject;
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
