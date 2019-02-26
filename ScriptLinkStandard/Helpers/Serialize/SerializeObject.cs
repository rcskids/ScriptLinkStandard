using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Attempts to serialize an object to Xml. If fails, attempts to serialize as Json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <returns></returns>
        public static string SerializeObject<T>(T objectToSerialize)
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException("Parameter cannot be null", "objectToSerialize");

            try { return SerializeObjectToXmlString<T>(objectToSerialize); }
            catch { /* Could not serialize as XML */ }
            try { return SerializeObjectToJsonString<T>(objectToSerialize); }
            catch { /* Could not serialize as JSON */ }

            throw new ArgumentException("Object could not be serialized as XML or JSON.", "objectToSerialize");
        }
        /// <summary>
        /// Serializes an object as Json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <returns></returns>
        public static string SerializeObjectToJsonString<T>(T objectToSerialize)
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException("Parameter cannot be null", "objectToSerialize");

            try
            {
                return JsonConvert.SerializeObject(objectToSerialize);
            }
            catch
            {
                throw new ArgumentException("Object could not be serialized as JSON.", "objectToSerialize");
            }
        }
        /// <summary>
        /// Serializes an object as Xml.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialize">The object to be serialized.</param>
        /// <returns></returns>
        public static string SerializeObjectToXmlString<T>(T objectToSerialize)
        {
            if (objectToSerialize == null)
                throw new ArgumentNullException("Parameter cannot be null", "objectToSerialize");

            try
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(stringWriter, objectToSerialize);
                    return stringWriter.ToString();
                }
            }
            catch
            {
                throw new ArgumentException("Object could not be serialized as XML.", "objectToSerialize");
            }
        }
    }
}
