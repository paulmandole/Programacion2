using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Biblioteca
{
    public class PuntoJson<T> : Archivo,IArchivo<T> where T : class
    {
        public override string Extencion
        {
            get { return ".json"; }
        }

        public void Guardar(string path, T contenido)
        {
            if (ValidarSiExisteElArchivo(path))
            {
                JsonSerializerOptions option = new JsonSerializerOptions();
                option.WriteIndented = true;
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    string json = JsonSerializer.Serialize(contenido, option);
                    PuntoTxt puntoTxt = new PuntoTxt();
                    puntoTxt.Guardar(path, json);

                }

            }
            
        }

        public void GuardarComo(string path, T contenido)
        {
           if(ValidarExtension(path))
           {
                Guardar(path, contenido);
           }
        }

        public T Leer(string path)
        {
            PuntoTxt puntoTxt = new PuntoTxt();
            string json = puntoTxt.Leer(path);

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
