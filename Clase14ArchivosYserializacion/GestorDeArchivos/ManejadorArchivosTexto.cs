using System;
using System.IO;

namespace GestorDeArchivos
{
    public static class ManejadorArchivosTexto
    {
        public static void Guardar(string path, string texto)
        {
            //le paso la ruta
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(path);
                //agrego el texto al archivo
                //Sobre escribe
                streamWriter.WriteLine(texto);

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                //cerrar el archivo
                if (streamWriter is not null)
                    streamWriter.Close();
            }
           
        }
                //si es true lo agrega al final si es false sobreescribe
        public static void Guardar(string path, string texto, bool agregar)
        {
            try
            {
                using(  StreamWriter streamWriter =  new StreamWriter(path,agregar))
                {
                    streamWriter.WriteLine(texto);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string LeerArchivo(string path)
        {
            try
            {
                //using no tengo q cerrarlo
                using (StreamReader streamReader = new StreamReader(path))
                {
                    //lee todo lo del archivo
                    return streamReader.ReadToEnd();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
