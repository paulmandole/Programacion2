using System;
using System.IO;

namespace Biblioteca
{
    public class ManejadorArchivosTexto
    {

        public static string leerArchivoTxt(string path)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    return streamReader.ReadToEnd();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void GuardarArchivotxt(string path, string contenido)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(contenido);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}