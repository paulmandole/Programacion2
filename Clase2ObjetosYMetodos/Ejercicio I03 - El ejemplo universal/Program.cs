using System;
using Biblioteca;
namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Mandole", "100025", "Paul");
            Estudiante estudiante2 = new Estudiante("Taborda", "103625", "Leonel");
            Estudiante estudiante3 = new Estudiante("Insfran", "126984", "Rodrigo");

            estudiante1.SetNotaPrimerParcial(10);
            estudiante2.SetNotaPrimerParcial(6);
            estudiante3.SetNotaPrimerParcial(3);

            estudiante1.SetNotaSegundoParcial(10);
            estudiante2.SetNotaSegundoParcial(9);
            estudiante3.SetNotaSegundoParcial(2);


            Console.WriteLine("{0}{1}{2}",estudiante1.Mostrar(),estudiante2.Mostrar(),estudiante3.Mostrar());
        }
    }
}
