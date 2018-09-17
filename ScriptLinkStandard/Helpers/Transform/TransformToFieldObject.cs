using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms an Xml- or Json-formatted <see cref="System.String"/> to <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="serializedString">An Xml- or Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="FieldObject"/>.</returns>
        public static IFieldObject TransformToFieldObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new System.ArgumentException("Parameter cannot be empty or null", "serializedString");
            try
            {
                return DeserializeObject<FieldObject>(serializedString);
            }
            catch
            {
                throw new System.ArgumentException("Serialized string is not in a compatible format.", "serializedString");
            }
        }
    }
}
