using System;
using Biblioteca;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("juan", "perez");


            try
            {
                Persona.GuardarXml(p1);


                Persona p2 = Persona.LeerXml();

                Console.WriteLine(p2.ToString());

                Console.ReadKey();
                Console.WriteLine("-------------------------------------\n\n\n");

                Persona.GuardarJson(p1);


                Persona p3 = Persona.LeerJson();

                Console.WriteLine(p3.ToString());
                Console.ReadKey();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("La ruta de lectura o escritura es invalida");
            }
            catch (IOException ex)
            {
                Console.WriteLine("el nombre o la ruta del path no son correctos");
            }
            catch (JsonException)
            {
                Console.WriteLine("La ruta del json deve iniciar con path:");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("La persona no puede ser construida por q no posee un constructor publico");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Acceso a la rruta denegado");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("argumento de Ruta invalida");
            }
            
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
        }
    }
}
