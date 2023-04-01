using System;
using System.Threading;
using System.Threading.Tasks;

namespace ejm4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task tarea1 = Task.Run(Tarea01);
            Task tarea2 = Task.Run(Tarea02);
            Task tarea3 = Task.Run(Tarea03);

            //se asegura q la terea 3 haya terminado no continua hasta q termine
            //el hilo principal
            tarea3.Wait();
            Console.WriteLine("Terminado todo)");
        }
        public static void Tarea01()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Tarea 1");
        }
        public static void Tarea02()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Tarea 2");
        }
        public static void Tarea03()
        {
            Thread.Sleep(8000);
            Console.WriteLine("Tarea 3");
        }
    }
}
