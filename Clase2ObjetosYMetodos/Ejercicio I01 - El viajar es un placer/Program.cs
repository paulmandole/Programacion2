using System;
using BibliotecaClase8;

namespace Ejercicio_I01___El_viajar_es_un_placer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 4,EColores.negro, 7, 4);
            Moto moto = new Moto(2,0,EColores.gris,650);
            Camion camion = new Camion(8, 2,EColores.blanco, 6, 5000);

            Console.WriteLine($"{camion.GetType().Name} - cantidadRuedas:{camion.cantidadRuedas} cantidadPuertas:{camion.cantidadPuertas} carga:{camion.pesoCarga} color:{camion.color} marchas:{camion.cantidadMarchas}");
            Console.WriteLine($"{auto.GetType().Name} - cantidadRuedas:{auto.cantidadRuedas} cantidadPuertas:{auto.cantidadPuertas} cantidadPasajeros:{auto.cantidadPasajeros} color:{auto.color} marchas:{auto.cantidadMarchas}");
            Console.WriteLine($"{moto.GetType().Name} - cantidadRuedas:{moto.cantidadRuedas} cantidadPuertas:{moto.cantidadPuertas} cilindrada:{moto.cilindrada} color:{moto.color}");
        }
    }
}
