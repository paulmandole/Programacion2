using System;
using BibliotecaClase9;

namespace Clase9polmorfismo
{
    internal class Program
    {
        ///polimorfismo me evita castear 
        static void Main(string[] args)
        {
            //Animal animal = new Animal("a");
            Perro perro = new Perro("a");
            Gato gato = new Gato("Salem");
            Gatito gatito = new Gatito("a");

            Animal gato3 = gato;

            Console.WriteLine(gato.Equals(gato3));
            Console.ReadKey();

            Animal gato2 = new Gato("Bola de nieve");
            Animal perro2 = new Perro("a");
            Animal gatito1 = new Gatito("a");

            Console.WriteLine("--------------------");
            Console.WriteLine("Herencia polimorfica (override)");
            Console.WriteLine("--------------------");
            //Console.WriteLine(animal.EmitirSonido());
            Console.WriteLine(perro.EmitirSonido());
            Console.WriteLine(gato.EmitirSonido());
            Console.WriteLine("--------------------");
            Console.WriteLine(perro2.EmitirSonido());
            Console.WriteLine(gato2.EmitirSonido());
            Console.WriteLine(gatito1.EmitirSonido());
            Console.WriteLine(gatito.EmitirSonido());

            Console.WriteLine("\n\n--------------------");
            Console.WriteLine("Herencia no polimorfica (new)");
            Console.WriteLine("--------------------");
            //Console.WriteLine(animal.Pensar());
            Console.WriteLine(perro.Pensar());
            Console.WriteLine(gato.Pensar());
            Console.WriteLine("--------------------");
            Console.WriteLine(perro2.Pensar());
            Console.WriteLine(gato2.Pensar());
            Console.WriteLine(gatito1.Pensar());
            Console.WriteLine(gatito.Pensar());


            Console.WriteLine("\n\nHerencia no polimorfica (new) casteado");
            Console.WriteLine(((Perro)perro2).Pensar());


        }
    }
}
