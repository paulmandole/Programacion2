using System;
using System.Collections.Generic;

namespace Ejercicio_I01___Números_locos
{
    internal class Program
    {
        public static int SortNumbers(int a, int b)
        {
            return b - a;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numeros = new List<int>()
            {
               random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),
               random.Next(-100,100),random.Next(-100,100)
            };

            Console.WriteLine("-----------------");
            Console.WriteLine("orden generados");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Sort();

            Console.WriteLine("-----------------");
            Console.WriteLine("Negativos Ordenados Ascendiente");

            foreach (int numero in numeros)
            {
                if(numero < 0)
                    Console.WriteLine(numero);
            }


            Console.WriteLine("-----------------");
            Console.WriteLine("Positivos Ordenados Descendiente");
            numeros.Sort(SortNumbers);
            foreach (int numero in numeros)
            {
                if(numero > 0)
                    Console.WriteLine(numero);
            }


            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
