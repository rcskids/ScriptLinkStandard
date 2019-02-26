using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms an Xml- or Json-formatted <see cref="System.String"/> to <see cref="RowObject"/>.
        /// </summary>
        /// <param name="serializedString">An Xml- or Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="RowObject"/>.</returns>
        public static IRowObject TransformToRowObject(string serializedString)
        {
            if (serializedString == null || serializedString == "")
                throw new ArgumentNullException("Parameter cannot be empty or null", "serializedString");
            try
            {
                return DeserializeObject<RowObject>(serializedString);
            }
            catch
            {
                throw new ArgumentException("Serialized string is not in a compatible format.", "serializedString");
            }
        }
    }
}
