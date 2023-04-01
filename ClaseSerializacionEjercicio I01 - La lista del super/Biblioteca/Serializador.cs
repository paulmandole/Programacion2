using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace Biblioteca
{
    public  static class Serializador
    {

        public static void GuargarXML(List<string> strings, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

                    xmlSerializer.Serialize(streamWriter, strings);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static List<string> LeerXML(string path)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<string>));

                    return xml.Deserialize(streamReader) as List<string>;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
