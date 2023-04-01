using System;
using Biblioteca;

namespace Ejercicio_I01___Validador_de_rangos
{
    internal class Program
    {
        static int minimo;
        static int maximo;
        static void Main(string[] args)
        {
            //Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
            //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
            string numeroString;
            int numero;
            int length = 3;
            
            int promedio;
            int acumulador = 0;
            

            for (int i = 0; i < length; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un Numero:");
                    numeroString = Console.ReadLine();
                    int.TryParse(numeroString, out numero);

                } while (!Validador.Validar(numero, -100, 100));

                
                ObtenerMinimo(numero);
                ObtenerMaximo(numero);
                    

                acumulador += numero;
            }

            promedio = acumulador / length;


            Console.WriteLine("El maximo numero ingresado es:{0}\nEl minimo numeor ingresado es:{1}\nEl promedio de los numeros ingresados es:{2}", maximo, minimo, promedio);



           

        }
        public static void ObtenerMinimo(int valor)
        {
            if (valor < minimo)
            {
                minimo = valor;
            }
        }

        public static void ObtenerMaximo(int valor)
        {
            if (valor > maximo)
            {
                maximo = valor;
            }
        }

    }
}
