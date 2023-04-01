using System;
using System.Collections.Generic;
using Biblioteca;

namespace Clase13Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paloma paloma = new Paloma("Azir", "Shurima");
            Courrier courier6 = new Courrier("Vault", "Dweller", "33445566");
            Carta carta = new Carta("A4", 1);
            Email mail = new Email("jefe@gmail.com", "Programado@gmail.com");
            Cuervo cuervo = new Cuervo("Bonsdasr");



            ClasePrueba clasePrueba = new ClasePrueba();

            Courrier courier = clasePrueba.MostrarPersona<Paloma>(paloma);


            Console.WriteLine(cuervo.EnviarMendaje());
            //casteo apra motrar el metodo de la interfas con el mismo nombre
            Console.WriteLine(((IEncriptado)cuervo).EnviarMendaje());

            List<IMensaje> mensajes = new List<IMensaje>();
            mensajes.Add(mail);
            mensajes.Add(courier6);
            mensajes.Add(carta);
            mensajes.Add(paloma);


            //ClasePrueba.Probar(mail);
            foreach (IMensaje item in mensajes)
            {
                Console.WriteLine(item.EnviarMendaje());

            }
        }
    }
}
