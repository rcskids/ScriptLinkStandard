using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Attempts to deserialize a string to specified object as Xml or Json (if Xml fails).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedString">The <see cref="System.String"/> to deserialize.</param>
        /// <returns></returns>
        public static T DeserializeObject<T>(string serializedString) where T : new()
        {
            if (string.IsNullOrEmpty(serializedString))
                throw new ArgumentNullException("Parameter cannot be empty or null", "serializedString");

            try { return DeserializeObjectFromXmlString<T>(serializedString); }
            catch { /* Not valid XML or doesn't match the object specification */ }
            try { return DeserializeObjectFromJsonString<T>(serializedString); }
            catch { /* Not valid JSON or doesn't match the object specification */ }

            throw new ArgumentException("Serialized string is not in a compatible format.", "serializedString");
        }
        /// <summary>
        /// Deserializes a Json string as specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The Json <see cref="System.String"/> to deserialize.</param>
        /// <returns></returns>
        public static T DeserializeObjectFromJsonString<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
                throw new ArgumentNullException("Parameter cannot be empty or null", "json");

            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                throw new ArgumentException("JSON string could not be deserialized to desired object.", "json");
            }
        }
        /// <summary>
        /// Deserializes an Xml string as specified object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml">The Xml <see cref="System.String"/> to deserialize.</param>
        /// <returns></returns>
        public static T DeserializeObjectFromXmlString<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                throw new ArgumentNullException("Parameter cannot be empty or null", "xml");

            try
            {
                using (var stringReader = new StringReader(xml))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(stringReader);
                }
            }
            catch
            {
                throw new ArgumentException("XML string could not be deserialized to desired object.", "json");
            }
        }
    }
}
