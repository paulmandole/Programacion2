using System;
using Biblioteca;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Amesos", 2500005.5m);
            Cuenta cuenta2 = new Cuenta("Perritos S.A", 35000m);

            Console.WriteLine("datos de la cuenta1:{0}\nDatos de la cuenta2:{1}",cuenta1.Mostrar(),cuenta2.Mostrar());
            cuenta1.RetirarCantidad(1000000);//retiro de amesos
            cuenta2.IngresarCantidad(1000000);//ingreso en perritos sa
            Console.WriteLine("datos de la cuenta1:{0}\nDatos de la cuenta2:{1}", cuenta1.Mostrar(), cuenta2.Mostrar());
            
        }
    }
}
