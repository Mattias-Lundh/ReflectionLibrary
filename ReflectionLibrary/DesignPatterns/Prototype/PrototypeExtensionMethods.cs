namespace ReflectionLibrary.DesignPatterns.Prototype
{
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;

    public static class PrototypeExtensionMethods
    {
        /// <summary>
        /// this method requires T and all its containing members to be annotated serializable 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static T DeepCopy<T>(this T self)
            {
                var stream = new MemoryStream();
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                object copy = formatter.Deserialize(stream);
                stream.Close();
                return (T) copy;
            }

            public static T DeepCopyXml<T>(this T self)
            {
                using (var ms = new MemoryStream())
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(ms, self);
                    ms.Position = 0;
                    return (T) xmlSerializer.Deserialize(ms);
                }

            }
    }
}