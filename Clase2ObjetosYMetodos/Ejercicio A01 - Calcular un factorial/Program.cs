using System;
using Biblioteca;

namespace Ejercicio_A01___Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double respuesta;
            respuesta = Factoriador.Factoriar(5);

            Console.WriteLine(respuesta);   
        }
    }
}
