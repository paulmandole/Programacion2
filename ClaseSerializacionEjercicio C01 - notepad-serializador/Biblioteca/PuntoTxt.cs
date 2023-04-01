using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca
{
    public class PuntoTxt : Archivo,IArchivo<string>
    {
        public override string Extencion
        {
            get { return ".txt"; }
        }

        public void Guardar(string path, string contenido)
        {
            if (ValidarSiExisteElArchivo(path))
            {
                using (StreamWriter stream = new StreamWriter(path))
                {
                    stream.WriteLine(contenido);
                }
            }
            
        }

        public void GuardarComo(string path, string contenido)
        {
            if (ValidarExtension(path))
            {
                Guardar(path, contenido);
            }
        }

        public string Leer(string path)
        {
            if (ValidarSiExisteElArchivo(path))
            {
                using (StreamReader stream = new StreamReader(path))
                {
                    return stream.ReadToEnd();
                }
            }
            return null;
        }
    }
}
