using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Tariki.CompanyHouse.Api
{
    public static class XmlHelper<T>
    {
        public static string Serialize(T toSerialise)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(memoryStream, toSerialise);
                memoryStream.Seek(0, SeekOrigin.Begin);
                using (var streamReader = new StreamReader(memoryStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        public static T Deserialize(string xml)
        {
            using (var stringReader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(T));
                return ((T)(serializer.Deserialize(XmlReader.Create(stringReader))));
            }
        }
    }
}