using System;
using GestorDeArchivos;
using static System.Environment;//using static incuyo una clase para escribir menos
//using static System.Console;//static incluye la clase 
using System.Text;
using System.Collections.Generic;

namespace Clase14ArchivosYserializacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Alumno> list = new List<Alumno>()
            {
                new Alumno()
                {
                    Nombre = "pepe Rodriguez",
                    Edad = 54
                },
                 new Alumno()
                {
                    Nombre = "Maria Perez",
                    Edad = 50
                }
        };
            //SpecialFolder. para guardar en carpetas especiales ej escritorio para escribir una \ e un string tenes q usar \\
            //string path = GetFolderPath(SpecialFolder.Desktop)+@"\MiArchivo.txt";
            string path = GetFolderPath(SpecialFolder.Desktop) + @"\MiArchivo.json";
            //StringBuilder sb = new StringBuilder();

            ////sb.AppendLine("Habia una vez una vaca");
            ////sb.AppendLine("En la quebrada humahuaca");

            //sb.AppendLine("maria Elena Walsh");

            //try
            //{
            //    ManejadorArchivosTexto.Guardar(path, sb.ToString(),true);
            //    Console.ReadKey();

            //   Console.WriteLine(ManejadorArchivosTexto.LeerArchivo(path));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine("Hello World!");

            try
            {


                Serializadora<List<Alumno>>.GuardarJson(list, path);
                List<Alumno> listaLeida = Serializadora<List<Alumno>>.LeerJson(path);
                // Console.ReadKey();
                //Alumno alumno = new Alumno()
                //{ 
                //    Nombre = "pepe Rodriguez",
                //    Edad = 54
                //};
                //aca estoy casteando
                //Serializadora<List<Alumno>>.GuardarXml(list, path);
                //aca estoy casteando
                // List<Alumno> listaLeida = Serializadora<List<Alumno>>.LeerXml(path);

                foreach (Alumno item in listaLeida)
                {
                    Console.WriteLine(item.Nombre);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
