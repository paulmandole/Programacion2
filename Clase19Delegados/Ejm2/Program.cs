using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ejm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //las pongo a correr en el momento q las creo psandole un metodo
            Task tarea1 = Task.Run(Tarea01);
            Task tarea2 = Task.Run(Tarea02);
            Task tarea3 = Task.Run(Tarea03);
            Thread.Sleep(10000);
        }

        public static void Tarea01()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Tarea 1");
        }
        public static void Tarea02()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Tarea 2");
        }
        public static void Tarea03()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Tarea 3");
        }
    }
}
