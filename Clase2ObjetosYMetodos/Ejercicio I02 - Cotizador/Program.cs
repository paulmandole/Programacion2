using System;
using Billetes;

namespace Ejercicio_I02___Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pesos ingreso1 = new Pesos(10265);
            Dolar ingreso2 = new Dolar(100*102.65);
            Euro ingreso3 = new Euro(118);

            Console.WriteLine($"El monto en pesos ingresado es:{ingreso1.GetCantidad()}");
            Console.WriteLine($"El monto en Dolar ingresado es:{ingreso2.GetCantidad()}");
            Console.WriteLine($"El monto en Euro ingresado es:{ingreso3.GetCantidad()}");

            Console.WriteLine($"Pesos igual Dolar:{ingreso1 == ingreso2}");
            Console.WriteLine($"Euro igual Dolar:{ingreso3 == ingreso2}");
            Console.WriteLine($"Dolar igual Euro:{ingreso2 == ingreso3}");
            Console.WriteLine($"Dolar igual Peso:{ingreso2 == ingreso1}");
            Console.WriteLine($"Peso igual Euro:{ingreso1 == ingreso3}");
        }

    }
}
