using System;
using BibliotecaClase8;

namespace Ejercicio_C01___Herencia_deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("Tevez", 39666680, 50, 250);
            Jugador j2 = new Jugador("Messi", 35402368, 100, 100);
            Jugador j3 = new Jugador("Suarez", 40257895, 2, 30);
            DirectorTecnico d1 = new DirectorTecnico("roberto", new DateTime(1952, 10, 12));
            DirectorTecnico d2 = new DirectorTecnico("Juancho", new DateTime(1968, 05, 09));
            DirectorTecnico d3 = new DirectorTecnico("roberto", new DateTime(1952, 10, 12));
            Equipo e1 = new Equipo(22, "Boca");


            Console.WriteLine($"{j1.MostrarDatos()}");
            Console.WriteLine($"{d1.MostrarDatos()}");

            _ = e1 + j1;
            _ = e1 + j2;
            _ = e1 + j1;

            if (d1 == d3)
            {
                Console.WriteLine($"{d1.MostrarDatos()}");
            }

            Console.ReadKey();

            Console.WriteLine(e1.MostrarListaJugadores());

            



        }
    }
}
