using System;
using BibliotecaClase11;

namespace Clase11TestUnitariosYMetodosDeExtencion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola Mundo";

            for (int i = 1; i < 100; i++)
            {
                
                Console.WriteLine(i.FizzBuzz());
            }

            
            int cantidadDePalabras = texto.ContarPalabras();
            //es un metodo estatico que te hace cree que se puede usar como si fuese parte de esa clase
            int cantidad = StringExtendido.ContarPalabras(texto);
            Console.WriteLine(cantidadDePalabras);
            



        }
    }
}
