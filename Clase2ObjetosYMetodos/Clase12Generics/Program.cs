using System;
using BibliotecaClase12;

namespace Clase12Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Primera version
            Galpon<string> galponPalabras = new Galpon<string>();
            Galpon<Juguete> jugueteria = new Galpon<Juguete>();
            Galpon<Lacteo> lacteo = new Galpon<Lacteo>();
            Galpon<Avion> hangar = new Galpon<Avion>();

            hangar.PrimerElemento();
            lacteo.PrimerElemento();
            galponPalabras.GuardarObjeto("pepe");
            Console.WriteLine("Hello World!");
            #endregion

            Inventario<Juguete, Avion, string> inventario1 = new Inventario<Juguete, Avion, string>();

        }
    }
}
