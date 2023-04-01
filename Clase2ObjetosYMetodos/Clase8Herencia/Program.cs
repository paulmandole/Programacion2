using System;
using System.Collections.Generic;
using BibliotecaClase8;


namespace Clase8Herencia
{
    internal class Program
    {

        //para que no puedan heredar se usa la palabra sealed
        static void Main(string[] args)
        {
            Publicacion publicacion = new Publicacion("Guia de C#",DateTime.Now);
            Publicacion libro = new Libro("Rayuela","Roberto", new DateTime(1966, 04, 12));
            Publicacion revista = new Revista("noticias", new DateTime(2022, 04, 26));

            List<Publicacion> listaDeLibros = new List<Publicacion>();
            listaDeLibros.Add(libro);
            listaDeLibros.Add(revista);
            listaDeLibros.Add(publicacion);
            //necesito castearlo por q es un libro q esta incluido en publicacion
            ((Libro)libro).Precio = 15;
            foreach (Publicacion item in listaDeLibros)
            {

                Console.WriteLine(item.MostrarDatos());
                if(item is Libro)
                    Console.WriteLine($"El precio es:{((Libro)item).Precio}");
            }

            //Console.WriteLine(publicacion.MostrarDatos());
            //Console.WriteLine(libro.MostrarDatos());
            //Console.WriteLine(revista.MostrarDatos());

            //puedo hacer con los hijos todo lo que se puede hacer con el padre
            Imprimir(libro);
        }
        static void Imprimir(Publicacion p)
        {
            Console.WriteLine(p.MostrarDatos());
        }

    }
    
}
