using System;
using System.Collections.Generic;


namespace Ejercicio_I02___Números_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numeros = new List<int>()
            {
               random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),random.Next(-100,100),
               random.Next(-100,100),random.Next(-100,100)
            };

            Queue<int> numerosCola = new Queue<int>();

            for (int i = 0; i < 8; i++)
            {
                numerosCola.Enqueue(random.Next(-100, 100));
            }


            Stack<int> numerosStack = new Stack<int>();

            for (int i = 0; i < 8; i++)
            {
                numerosStack.Push(random.Next(-100, 100));
            }


            Console.WriteLine("------------------");
            Console.WriteLine("List numeros");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            Console.WriteLine("------------------");
            Console.WriteLine("Queue numeros");

            foreach (int numero in numerosCola)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            Console.WriteLine("------------------");
            Console.WriteLine("Stack numeros");

            foreach (int numero in numerosStack)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();



            Console.WriteLine("Hello World!");
        }
    }
}
