using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ejm6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken ct = cancelTokenSource.Token;

            Task tarea1 = Task.Run(Tarea01);
            //Task tarea2 = Task.Run(() => Tarea02(cancelToken.Token));
            Task tarea2 = Task.Run(() => Tarea02(ct));
            Task tarea3 = Task.Run(Tarea03);

            Thread.Sleep(3000);

            //se cancela
  
            cancelTokenSource.Cancel();

            Task.WaitAll(tarea1, tarea2, tarea3);
        }
        public static void Tarea02(CancellationToken cancelToken)
        {
            int i = 1;

            while (true)
            {
                if (!cancelToken.IsCancellationRequested)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"Tarea 2: {i}");
                    i++;
                }
                else
                {
                    Console.WriteLine($"Tarea 2 Cancelada");
                    break;
                }
                
            }
          
        }
        public static void Tarea01()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Tarea 1");
        }
        public static void Tarea03()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Tarea 3");
        }
    }
}
