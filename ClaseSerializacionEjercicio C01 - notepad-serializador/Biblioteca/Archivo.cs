using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca
{
    public abstract class Archivo
    {
        public abstract string Extencion { get;}
        

        public bool ValidarExtension(string path)
        {
            if (Path.GetExtension(path) != Extencion)
            {
                throw new ArchivoIncorrectoException("Extencion Incorrecta", "Metodo:ValidarExtension");
            }
            return true;
        }

        public bool ValidarSiExisteElArchivo(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArchivoIncorrectoException("El archivo no se encontró", "Metodo:ValidarSiExisteElarchivo");
            }
            return true;
        }

      
    }
}
