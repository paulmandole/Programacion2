using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ejm5
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

            //espera a toda la lista de tareas
            Task.WaitAll(listaTareas.ToArray());
            //Task.WaitAll(listaTareas[0],listaTareas[1],listatareas[2]);
            Console.WriteLine("Terminado todo)");
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
