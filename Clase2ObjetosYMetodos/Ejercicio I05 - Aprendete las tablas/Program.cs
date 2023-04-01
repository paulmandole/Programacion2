using System;
using System.Text;

namespace Ejercicio_I05___Aprendete_las_tablas
{
    internal class Program
    {
        static StringBuilder stringBuilder = new StringBuilder();

        static void Main(string[] args)
        {
            
            Console.Title = "Ejercicio_I05___Aprendete_las_tablas";
            int numero;

            Console.WriteLine("ingrese un numero:");
            numero = int.Parse(Console.ReadLine());


            Console.WriteLine("Tabla de multiplicar del número {0}:\n{1}",numero , CreadorDeTablas(numero));

            Console.ReadKey();
        }

        public static string CreadorDeTablas(int numero)
        {
            for (int i = 0; i <= 10; i++)
            {
                stringBuilder.AppendFormat("{0} * {1} = {2}\n",numero,i,(numero*i));
            }
            return stringBuilder.ToString();
        }
    }
}
