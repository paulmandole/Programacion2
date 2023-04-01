using System;

namespace EjemploArrayDeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] persona = new Persona[10];

            persona [0] = new Persona("fede");
            //persona [2] = puedo hacer un metodo que pida al usuario que ingrese los datos de ua persona; agregar clase perosna para hacerlo o en program 
            persona [1] = new Persona("juan");

            Console.WriteLine("Hello World!");
        }
    }

    class Persona
    {
        public string name;
        Mascota [] mascotas;
        public Persona(string name)
        {
            this.name = name;
            mascotas = new Mascota[4];//lo iniciacializo con la cantidad que quiera
        }
        public string Name { get; set;}

        public void CargarMascota(Mascota mascota)
        {
            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] is null)
                {
                    mascotas [i] = mascota;
                }
            }
        }
    }

    class Mascota{ }

}
