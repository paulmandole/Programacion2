using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class PuntoXml<T> : Archivo, IArchivo<T> where T : class
    {
        public override string Extencion
        {
            get { return ".xml"; }
        }

        public void Guardar(string path, T contenido)
        {
            if (ValidarSiExisteElArchivo(path))
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(streamWriter, contenido);
                }
            }

        }

        public void GuardarComo(string path, T contenido)
        {
            if (ValidarExtension(path))
            {
                Guardar(path, contenido);
            }
        }

        public T Leer(string path)
        {
            
            if (ValidarSiExisteElArchivo(path))
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return serializer.Deserialize(streamReader) as T;
                }
            }

            return null;
        }
    }
}
