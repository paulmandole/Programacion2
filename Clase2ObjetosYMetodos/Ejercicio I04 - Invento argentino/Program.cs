using System;
using Biblioteca;

namespace Ejercicio_I04___Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo boligrafo1 = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            

            boligrafo1.Pintar(-20,out dibujo);

            Console.WriteLine(dibujo);
            Console.WriteLine(boligrafo1.GetTinta());

            boligrafo2.Pintar(-50, out dibujo);
            Console.WriteLine(dibujo);
            




        }
    }
}
