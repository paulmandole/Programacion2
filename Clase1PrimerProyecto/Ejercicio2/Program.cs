using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            string numeroString;
            int numero;
            double cuadrado;
            double cubo;
            
            Console.WriteLine("Ingrese un nuemro para calcular el cuadrado y Cubo del mismo:");
            numeroString = Console.ReadLine();
            int.TryParse(numeroString, out numero);

            while (numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numeroString = Console.ReadLine();
                int.TryParse(numeroString, out numero);
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El Cuadrado del nuemro ingresado es:{0}\nEl cubo del numero ingresado es:{1}", cuadrado, cubo);


            Console.ReadLine();


        }
    }
}
