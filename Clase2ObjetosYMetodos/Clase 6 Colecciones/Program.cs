using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
namespace Clase_6_Colecciones
{
    internal class Program
    {

        //tiene q devolver un positivo un negativo o 0
        public static int Comparar(int a, int b)
        {
            //aca ba la logica para ordenar si fuese perona cambia
            return b - a;
        }
        static void Main(string[] args)
        {

            /*COLECCIONES*/
            #region Ordenar Listas

            List<int> numeros = new List<int>()
            {
                4,7,48,1,52,6,35
            };

            Console.WriteLine("Mustro en el orden que fue creada");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //metodo que ordena por defecto ascendente
            numeros.Sort();

            Console.WriteLine("\n\nMustro ordenada ascendente");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //metodo que ordena por defecto descendente
            //Le paso un puntero a la funcion va sin parentesis
            numeros.Sort(Comparar);

            Console.WriteLine("\n\nMustro ordenada ascendente");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            #endregion

            #region Stack devuelve siempre el ultimo(como un lugar donde se sacan hamburguesas) LIFO
            Stack<char> letras = new Stack<char>();

            letras.Push('h');
            letras.Push('o');
            letras.Push('l');
            letras.Push('a');
            letras.Push(' ');
            letras.Push('m');
            letras.Push('u');
            letras.Push('n');
            letras.Push('d');
            letras.Push('o');
            letras.Push('!');

            foreach (char letra in letras)
            {
                Console.WriteLine(letra);
            }
            // borra el primero q sale 
            letras.Pop();
            //retorna sin eliminar
            Console.WriteLine(letras.Peek());

            Console.ReadKey();

            #endregion

            #region Queue  devuelve siempre el primero (como una fila de super) FIFO

            Queue<Persona> colaDeAtencion = new Queue<Persona>();

            colaDeAtencion.Enqueue(new Persona("roberto"));
            colaDeAtencion.Enqueue(new Persona("Soledad"));
            colaDeAtencion.Enqueue(new Persona("Agustin"));
            colaDeAtencion.Enqueue(new Persona("juan"));
            Console.WriteLine("----------------\nMuestro en orden FIFO");
            foreach (Persona p in colaDeAtencion)
            {
                Console.WriteLine(p.nombre);
            }
            Console.WriteLine($"----------------\n");
            //peek muetra pero no elimina
            Console.WriteLine($"{colaDeAtencion.Peek().nombre}");
            Console.WriteLine($"----------------\n");
            while (colaDeAtencion.Count > 0)
            {
                //dequeeu lo elimina
                Console.WriteLine($"Atendiendo a:{colaDeAtencion.Dequeue().nombre}");
                Thread.Sleep(2000);
            }



            #endregion

            #region dictionary (key, value)

            Dictionary<string, string> ComidadLatinoAmericanas = new Dictionary<string, string>();

            ComidadLatinoAmericanas.Add("taco", "Mexico");
            ComidadLatinoAmericanas.Add("mole poblano", "Mexico");
            ComidadLatinoAmericanas.Add("ceviche", "peru");
            ComidadLatinoAmericanas.Add("causa limenia", "peru");
            ComidadLatinoAmericanas.Add("choripan", "Argentina");

            foreach (KeyValuePair<string,string> item in ComidadLatinoAmericanas)
            {
                Console.WriteLine($"El plato {item.Key} pertenece a {item.Value}");

            }
            Console.WriteLine("\n\nRecorro las key");
            foreach (string item in ComidadLatinoAmericanas.Keys)
            {
                Console.WriteLine($"El plato {item}");

            }

            Console.WriteLine("\n\nRecorro los value");
            foreach (string item in ComidadLatinoAmericanas.Values)
            {
                Console.WriteLine($"El pais{item}");

            }
            Console.WriteLine($"\n\n-----------\n\nAcedo a la key\t mole pertenece a:{ComidadLatinoAmericanas["mole poblano"]}\n\n");

            Console.WriteLine($"Contiene empanadas? : {ComidadLatinoAmericanas.ContainsKey("empanadas")}");
            Console.WriteLine($"Contiene Mexico? : {ComidadLatinoAmericanas.ContainsValue("Mexico")}");

            #endregion

            #region List
            //<aka va el tipo de dato que quiera>

            //List<Persona> personas = new List<Persona>()
            //{
            //    new Persona("Leandro"),new Persona("norberto")
            //};
            List<string> mascotas = new List<string>();
            //{
            //    "pepe","juan","alberto"
            //};
            mascotas.Add("firulais");
            mascotas.Add("Salem");
            mascotas.Add("bola de nieve");
            mascotas.Add("Gaturro");

            Console.Write($"la mascota de la pocicion 3 es:{mascotas[3]}\n\n");

            Console.WriteLine("Recorro con el foreach");
            foreach (string item in mascotas)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("\nRecorro con el For\n");
            //.coount te devuelve la cantidad de elementos
            for (int i = 0; i < mascotas.Count; i++)
            {
                Console.WriteLine(mascotas[i]);
            }

            mascotas.Insert(1, "procer");
            Console.WriteLine("\nRecorro con el foreach\n");
            foreach (string item in mascotas)
            {

                Console.WriteLine(item);
            }
            //devuelve la pocicion de lo primero que encuentra con ese nombre
            Console.WriteLine($"La pocicion de salem es {mascotas.IndexOf("Salem")}");
            //borra 
            mascotas.Remove("Salem");
            //removeAt()este para borra de acuerdo a un indice
            Console.ReadKey();

            
            #endregion

            #region ArrayList esta no se usa es - NO GENERICA - 
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add(new Persona("Esteban"));
            arrayList.Add(false);


            #endregion

            Console.WriteLine("Hello World!");
        }

        class Persona
        {
            public string nombre;

            public Persona(string nombre)
            {
                this.nombre = nombre;
            }
        }
    }
}
