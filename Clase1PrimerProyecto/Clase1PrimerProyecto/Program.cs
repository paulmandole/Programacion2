using System;

namespace Clase1PrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            string numText;
            int i;
            int tam = 5;
            int numero;
            int flag = 0;
            int min = 0;
            int max = 0;
            float promedio;
            int acumulador = 0;

            for (i = 0; i < tam; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero:");
                    numText = Console.ReadLine();
                } while (!int.TryParse(numText, out numero));
               

                
                if (flag == 0)
                {
                    max = numero;
                    min = numero;
                    flag = 1;
                }

                if (max < numero)
                {
                    max = numero;
                }

                if(min > numero)
                {
                    min = numero;
                }

                acumulador += numero;
                
            }
            promedio = acumulador / tam;

            Console.WriteLine("El numero maximo ingresado es: {0}\n El numero minimo ingresado es:{1}\nEl promedio de los numeros ingresados es:{2}", max, min, promedio);

            


            Console.ReadLine();
        }
    }
}
