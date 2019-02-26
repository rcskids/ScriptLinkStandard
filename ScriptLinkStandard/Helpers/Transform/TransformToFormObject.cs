using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms an Xml- or Json-formatted <see cref="String"/> to <see cref="FormObject"/>.
        /// </summary>
        /// <param name="serializedString">An Xml- or Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="FormObject"/>.</returns>
        public static IFormObject TransformToFormObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new ArgumentNullException("Parameter cannot be empty or null", "serializedString");
            try
            {
                return DeserializeObject<FormObject>(serializedString);
            }
            catch
            {
                throw new ArgumentException("Serialized string is not in a compatible format.", "serializedString");
            }
        }
    }
}
