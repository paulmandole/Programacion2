using System;
using System.Security.Cryptography.X509Certificates;

namespace practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string palabra;

            Console.WriteLine("Escriba una plabra");
            palabra = Console.ReadLine();
          

            Console.WriteLine(VerificarSiPalabraEsCapicua(palabra));*/

            //hacer un factorial

            int numero;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());


            //Console.WriteLine($"El Factorial de {numero} es : {FactorialRecursivo(numero)}");

            //Console.WriteLine(VerificarNumeroPrimo(numero));
            Console.WriteLine(IsPar(numero));
        }

        public static string VerificarSiPalabraEsCapicua(string palabra) {
            int num = 0;

            string palabraCorta;
            int mitad;
            string respuesta = "La palabra es capicua";

            mitad = palabra.Length / 2;
            palabraCorta = palabra.Substring(0, mitad);

            for (int i = palabra.Length - 1; i > mitad; i--)
            {
                if (palabra[i] != palabraCorta[num])
                {
                    return ("La palabra no es capicua");
                }
                num++;
            }
            return respuesta;

        }


        public static int FactorialRecursivo(int numero)
        {
            int resultado = 1;

            if (numero > 0)
                resultado = numero * FactorialRecursivo(numero - 1);

            return resultado;
        }
        public static int Factorial(int numero) {
            int resultado = 1;

            for (int i = numero; i > 0; i--)
            {
                Console.WriteLine(resultado = resultado * i);

            }

            return resultado;
        }

        public static bool VerificarNumeroPrimo(int numero)
        {

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
        public static bool IsPar(int numero)
        {
            return numero % 2 == 0;
        }
        public static string prueba (int numero)
        {
            return numero > 0 ? "esMenor" : "esMayor";
        }
    }
}
