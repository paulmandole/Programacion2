using System;
using Biblioteca;

namespace ClaseGenericsEjercicio_I01___Torneo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Torneo<Equipo> torneoFutbol = new Torneo<Equipo>("Conmebol");
            Torneo<Equipo> torneoBast = new Torneo<Equipo>("Basquetsito");

            EquipoFutbol bocaF = new EquipoFutbol("Boca",new DateTime(1685,12,1));
            EquipoFutbol riverF = new EquipoFutbol("River", new DateTime(1668, 03, 15));
            EquipoFutbol rasinF = new EquipoFutbol("Rasin", new DateTime(1819, 9, 22));

            EquipoBasquet bocaB = new EquipoBasquet("Boca", new DateTime(1685, 12, 1));
            EquipoBasquet riverB = new EquipoBasquet("River", new DateTime(1668, 03, 15));
            EquipoBasquet rasinB = new EquipoBasquet("Rasin", new DateTime(1819, 9, 22));


            
            _ = torneoFutbol + bocaF;
            _ = torneoFutbol + riverF;
            _ = torneoFutbol + riverF;
            _ = torneoFutbol + rasinF;
            _ = torneoFutbol + bocaF;

            _ = torneoBast + bocaB;
            _ = torneoBast + riverB;
            _ = torneoBast + riverB;
            _ = torneoBast + rasinB;
            _ = torneoBast + bocaB;

            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine(torneoBast.Mostrar());
            Console.WriteLine(torneoBast.JugarPartido);
            Console.WriteLine(torneoBast.JugarPartido);
            Console.WriteLine(torneoBast.JugarPartido);





        }
    }
}
