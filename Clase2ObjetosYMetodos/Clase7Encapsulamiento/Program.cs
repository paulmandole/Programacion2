using System;
using Biblioteca;
namespace Clase7Encapsulamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Fede", 10, 2);

            jugador1.PartidosJugados = 20;

            jugador1.color = EColor.rojo;
            jugador1.color = (EColor)0;// casteo para que me guarde el numero como el rojo  

            jugador1.color = (EColor)new Random().Next(0, 4);

            int num = (int)jugador1.color;

            //asi se usa el indexador me devolveria el equipo donde jugo
            string equipoDondeJugo = jugador1[0];
            //aca cambio el valor por uno nuevo en esa pocicion
            jugador1[0] = "banfield";

            Console.WriteLine($"El equipo donde jugo es :{equipoDondeJugo}");
            Console.WriteLine(jugador1.Nombre);
            Console.WriteLine(jugador1.PartidosJugados);
            Console.WriteLine(jugador1.PromedioDeGoles);

            
        }
    }
}
