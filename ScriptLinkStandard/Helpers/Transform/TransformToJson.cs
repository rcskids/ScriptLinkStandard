using ScriptLinkStandard.Interfaces;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms an <see cref="IOptionObject"/> to a Json-formatted string.
        /// </summary>
        /// <param name="optionObject">The <see cref="IOptionObject"/> to transform to Json.</param>
        /// <returns>A Json-formatted string based on the provided <see cref="IOptionObject"/>.</returns>
        public static string TransformToJson(IOptionObject optionObject)
        {
            return SerializeObjectToJsonString(optionObject);
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2"/> to a Json-formatted string.
        /// </summary>
        /// <param name="optionObject2">The <see cref="IOptionObject2"/> to transform to Json.</param>
        /// <returns>A Json-formatted string based on the provided <see cref="IOptionObject2"/>.</returns>
        public static string TransformToJson(IOptionObject2 optionObject2)
        {
            return SerializeObjectToJsonString(optionObject2);
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2015"/> to a Json-formatted string.
        /// </summary>
        /// <param name="optionObject2015">The <see cref="IOptionObject2015"/> to transform to Json.</param>
        /// <returns>A Json-formatted string based on the provided <see cref="IOptionObject2015"/>.</returns>
        public static string TransformToJson(IOptionObject2015 optionObject2015)
        {
            return SerializeObjectToJsonString(optionObject2015);
        }
        /// <summary>
        /// Transforms an <see cref="IFormObject"/> to a Json-formatted string.
        /// </summary>
        /// <param name="formObject">The <see cref="IFormObject"/> to transform to Json.</param>
        /// <returns>A Json-formatted string based on the provided <see cref="IFormObject"/>.</returns>
        public static string TransformToJson(IFormObject formObject)
        {
            return SerializeObjectToJsonString(formObject);
        }
        /// <summary>
        /// Transforms an <see cref="IRowObject"/> to a Json-formatted string.
        /// </summary>
        /// <param name="rowObject">The <see cref="IRowObject"/> to transform to Json.</param>
        /// <returns>A Json-formatted string based on the provided <see cref="IRowObject"/>.</returns>
        public static string TransformToJson(IRowObject rowObject)
        {
            return SerializeObjectToJsonString(rowObject);
        }
        /// <summary>
        /// Transforms an <see cref="IFieldObject"/> to a Json-formatted string.
        /// </summary>
        /// <param name="fieldObject">The <see cref="IFieldObject"/> to transform to Json.</param>
        /// <returns>A Json-formatted string based on the provided <see cref="IFieldObject"/>.</returns>
        public static string TransformToJson(IFieldObject fieldObject)
        {
            return SerializeObjectToJsonString(fieldObject);
        }
    }
}
