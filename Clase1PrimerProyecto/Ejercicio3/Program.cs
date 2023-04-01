using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
            Utilizar sentencias de iteración, selectivas y el operador módulo (%).
            */
            string numeroString;
            int numero;
            bool isNumber;

            


            do
            {
                Console.WriteLine("Ingrese un numero para calcular los numeros primos hasta el mismo:");
                numeroString = Console.ReadLine();
                isNumber = int.TryParse(numeroString, out numero);

                while (String.Compare(numeroString, "Salir") != 0 && (!isNumber || numero < 0))
                {
                    Console.WriteLine("ERROR El numero ingresado debe ser mayor a '0' .Reingrese el numero o Ingrese Salir para terminar:");
                    numeroString = Console.ReadLine();
                    isNumber = int.TryParse(numeroString, out numero);
                }

                
                
                

                Console.WriteLine("Si no decea continuar ingrese Salir para terminar:");
                numeroString = Console.ReadLine();

            } while (String.Compare(numeroString, "Salir") != 0);
            






            Console.ReadLine();
        }
    }
}
