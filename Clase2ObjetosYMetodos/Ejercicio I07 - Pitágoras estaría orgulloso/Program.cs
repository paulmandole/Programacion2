using System;

namespace Ejercicio_I07___Pitágoras_estaría_orgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseT;
            double altura;
            Console.WriteLine("Ingrese la base en cm de el triangulo:");
            baseT = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura en cm de el triangulo:");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("La hipotenusa del triangulo mide:{0}cm",CalculadorDeHipotenusa(baseT,altura));

        }

        public static double CalculadorDeHipotenusa(double baseT, double altura)
        {

            return Math.Sqrt((Math.Pow(baseT, 2) + Math.Pow(altura, 2)));
                
        }
    }
}
