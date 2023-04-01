using System;
using System.IO;

namespace Ejercicio_I03___Siempre_quise_tener_un_notepad_ಥ‿ಥ
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

    }
}
