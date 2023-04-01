using System;
using Biblioteca;

namespace Ejercicio_I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador();
            Sumador sum2 = new Sumador(2);

            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)} Sumador {sum2.GetCantidadDeSumas()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Munjjjjjdo")} Sumador {sum.GetCantidadDeSumas()}");
            if (sum | sum2)
            {
                Console.WriteLine("ES true");
            }
            Console.WriteLine($"suma de objetos {sum + sum2}");

        }
    }
}
