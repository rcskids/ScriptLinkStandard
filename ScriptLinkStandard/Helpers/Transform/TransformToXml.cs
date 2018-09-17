using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;
using System.IO;
using System.Xml.Serialization;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Transforms an <see cref="IOptionObject"/> to a Xml-formatted string.
        /// </summary>
        /// <param name="optionObject">The <see cref="IOptionObject"/> to transform to Xml.</param>
        /// <returns>A Xml-formatted string based on the provided <see cref="IOptionObject"/>.</returns>
        public static string TransformToXml(IOptionObject optionObject)
        {
            return SerializeObject((OptionObject)optionObject);
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2"/> to a Xml-formatted string.
        /// </summary>
        /// <param name="optionObject2">The <see cref="IOptionObject2"/> to transform to Xml.</param>
        /// <returns>A Xml-formatted string based on the provided <see cref="IOptionObject2"/>.</returns>
        public static string TransformToXml(IOptionObject2 optionObject2)
        {
            return SerializeObject((OptionObject2)optionObject2);
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2015"/> to a Xml-formatted string.
        /// </summary>
        /// <param name="optionObject2015">The <see cref="IOptionObject2015"/> to transform to Xml.</param>
        /// <returns>A Xml-formatted string based on the provided <see cref="IOptionObject2015"/>.</returns>
        public static string TransformToXml(IOptionObject2015 optionObject2015)
        {
            return SerializeObject((OptionObject2015)optionObject2015);
        }
        /// <summary>
        /// Transforms an <see cref="IFormObject"/> to a Xml-formatted string.
        /// </summary>
        /// <param name="formObject">The <see cref="IFormObject"/> to transform to Xml.</param>
        /// <returns>A Xml-formatted string based on the provided <see cref="IFormObject"/>.</returns>
        public static string TransformToXml(IFormObject formObject)
        {
            return SerializeObject((FormObject)formObject);
        }
        /// <summary>
        /// Transforms an <see cref="IRowObject"/> to a Xml-formatted string.
        /// </summary>
        /// <param name="rowObject">The <see cref="IRowObject"/> to transform to Xml.</param>
        /// <returns>A Xml-formatted string based on the provided <see cref="IRowObject"/>.</returns>
        public static string TransformToXml(IRowObject rowObject)
        {
            return SerializeObject((RowObject)rowObject);
        }
        /// <summary>
        /// Transforms an <see cref="IFieldObject"/> to a Xml-formatted string.
        /// </summary>
        /// <param name="fieldObject">The <see cref="IFieldObject"/> to transform to Xml.</param>
        /// <returns>A Xml-formatted string based on the provided <see cref="IFieldObject"/>.</returns>
        public static string TransformToXml(IFieldObject fieldObject)
        {
            return SerializeObject((FieldObject)fieldObject);
        }


        private static string SerializeObject<T>(T objectToSerialize)
        {
            try
            {
                StringWriter stringWriter = new StringWriter();
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringWriter, objectToSerialize);
                return stringWriter.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
