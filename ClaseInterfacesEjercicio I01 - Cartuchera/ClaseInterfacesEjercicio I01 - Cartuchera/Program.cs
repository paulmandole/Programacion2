using System;
using Biblioteca;
using System.Collections.Generic;

namespace ClaseInterfacesEjercicio_I01___Cartuchera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();

            List<IAcciones> lIAciones = new List<IAcciones>()
            { miLapiz, miBoligrafo, new Boligrafo(5, ConsoleColor.Red), new Lapiz(50)};

            List<Lapiz> lapices = new List<Lapiz>()
            { new Lapiz(50),new Lapiz(10),new Lapiz(5),new Lapiz(19)};
            List<Boligrafo> boligrafos = new List<Boligrafo>()
            { miBoligrafo ,new Boligrafo(5, ConsoleColor.Red),new Boligrafo(15, ConsoleColor.Yellow),new Boligrafo(12, ConsoleColor.Magenta)};

            CartucheraMultiuso cartuchera = new CartucheraMultiuso(lIAciones);
            CartucheraSimple cartucheraSimple = new CartucheraSimple(boligrafos,lapices);

            for(int i = 0; i < 6; i++)
                Console.WriteLine(cartuchera.RecorrerElementos());

           
        }
    }
}
