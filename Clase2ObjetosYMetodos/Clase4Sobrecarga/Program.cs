using System;
using Biblioteca;

namespace Clase4Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entero = 5;
            //convercion implicita
            float flotante = entero;
            //convercion explicita
            entero = (int)flotante;

            //Uso biblioteca Validador sobrecarga llamo a la misma funcion pero cada una puede tener distintos tipos de datos
            Validador.ValidarRango(4, 0, 10);
            Validador.ValidarRango(4.5f, 0.1f, 12.2f);
            Validador.ValidarRango("hola", 0, 10);
            Tiempo tiempo = new Tiempo(15, 25, 35);
            Tiempo tiempo1 = new Tiempo(15,25,35);
            Tiempo tiempo2 = new Tiempo(19,30);
            Tiempo tiempo3 = new Tiempo(10);
            Console.WriteLine($"La hora es:{tiempo1.Mostrar()}");
            Console.WriteLine($"La hora es:{tiempo2.Mostrar()}");
            Console.WriteLine($"La hora es:{tiempo3.Mostrar()}");
            Console.WriteLine($"conparacion de tiempo con == sobrecargado: {tiempo == tiempo1}");//compara que todos los campos son iguales por q asi lo decidi 
            Console.WriteLine($"conparacion de tiempo con Equals: {Object.ReferenceEquals(tiempo1,tiempo)}");//compara direciones de memoria se usa cuando sobrecargue el ==

            Console.WriteLine($"Sobrecarga convercion implicita");
            Tiempo t = "20:27:14";
            Console.WriteLine(t.Mostrar());

            Console.WriteLine($"Sobrecarga convercion explicita");
            int tiempoEnSegundos = (int)t;
            Console.WriteLine(tiempoEnSegundos);



        }
    }
}
