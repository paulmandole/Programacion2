using System;
using Biblioteca;

namespace Ejercicio_I06___Calculadora_de_áreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitudDelLadoDelCuadrado = 5;
            double baseDelTriangulo = 2;
            double alturaDelTriangulo = 3;
            double radio = 3;
            Console.WriteLine("El area de el cuadrado es:{0}", CalculadoraDeArea.CalcularAreaDelCuadrado(longitudDelLadoDelCuadrado));
            Console.WriteLine("El area de el triangulo es:{0}", CalculadoraDeArea.CalcularAreaDelTriangulo(baseDelTriangulo, alturaDelTriangulo));
            Console.WriteLine("El area de el circulo es:{0}", CalculadoraDeArea.CalcularAreaDelCirculo(radio));
        }
    }
}
