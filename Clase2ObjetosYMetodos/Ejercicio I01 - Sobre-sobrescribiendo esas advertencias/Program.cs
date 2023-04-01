using System;
using BibliotecaClase9;

namespace Ejercicio_I01___Sobre_sobrescribiendo_esas_advertencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobreescrito objetoSobrescrito = new SobreSobrescrito();

            string obtenido = objetoSobrescrito.MiPropiedad;

            Console.WriteLine(obtenido);
            Console.WriteLine($"mi metodo tiene {objetoSobrescrito.MiMetodo()}");

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();
        }
    }
}
