using System;
using Biblioteca;

namespace Ejercicio_I02___Consultaste_el_índice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            libro libro = new libro();

            libro[0] = "HolaBEBE";

            libro[3] = "que haces"; 
            Console.WriteLine($"Lo que tiene libro en la posicion 0{libro[0]}");
            Console.WriteLine($"Lo que tiene libro en la posicion 2{libro[2]}");
            Console.WriteLine($"Lo que tiene libro en la posicion 3{libro[3]}");

            Console.WriteLine("Hello World!");
        }
    }
}
