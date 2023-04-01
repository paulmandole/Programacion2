using System;
using System.Threading;
using System.Threading.Tasks;

namespace Clase19Task
{
    internal class TaskEjm1
    {
        static void Main(string[] args)
        {
            Task tarea = new Task( () =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Primera Tarea");
                }
            );

            tarea.Start();
            Console.WriteLine("segunda tarea");
            Console.WriteLine("tercera tarea");
            Thread.Sleep(5000);
        }
    }
}
