using System;
using Biblioteca;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("paul", new DateTime(1996,05,09), 39666680); //usar el DateTime para pasar fechas instanciando
            Persona persona2 = new Persona("Juan", new DateTime(2010, 03, 09), 50365852);
            Persona persona3 = new Persona("Rene", new DateTime(1952, 05, 24), 10406382);

           Console.WriteLine("Persona1: {0} {1}\nPersona2: {2} {3}\nPersona3: {4} {5}", persona1.Mostrar(),persona1.EsMayorDeEdad(), persona2.Mostrar(), persona2.EsMayorDeEdad(), persona3.Mostrar(), persona3.EsMayorDeEdad());
        }
    }
}
