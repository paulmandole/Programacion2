using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Ejm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> listaTareas = new List<Task>()
            {
                new Task(Tarea01),
                new Task(Tarea02),
                new Task(Tarea03),

            };

            //x es por defecto
            listaTareas.ForEach((x) => x.Start());
            //es igual
            //foreach (Task tarea in listaTareas)
            //{
            //    tarea.Start();
            //}
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
