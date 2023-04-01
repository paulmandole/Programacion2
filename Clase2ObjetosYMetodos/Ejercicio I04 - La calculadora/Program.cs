using System;
using Biblioteca;

namespace Ejercicio_I04___La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float primeroOperando = 0;
            float segundoOperando = 0;
            char operacion = '+';
            float resultado;
            int opcion;
            int flag = 0;
            int flag1 = 0;
            int flag2 = 0;


            do
            {
                Console.WriteLine("MENU\n1-Ingresar Primer Operando.\n2-Ingresar Segundo Operando.\n3-Ingresar Operacion (+,-,* o /).\n4-Realizar Calculos\n5-Salir\nIngrese una opcion:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el operando");
                        primeroOperando = int.Parse(Console.ReadLine());//para tomar numeros y transformarlosdesde string
                        flag = 1;
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el operando");
                        segundoOperando = int.Parse(Console.ReadLine());//para tomar numeros y transformarlosdesde string
                        flag1 = 1;
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la operacion");
                        operacion = char.Parse(Console.ReadLine());
                        flag2 = 1;
                        Console.Clear();
                        break;
                    case 4:
                        if (flag1 == 0 || flag == 0 || flag2 == 0)
                        {
                            Console.WriteLine("Debe pasar por las primeras opciones antes de calcular");
                        }
                        else 
                        {
                            resultado = Calculadora.Calcular(primeroOperando, segundoOperando, operacion);
                            Console.WriteLine("El resultado de la operacion ingresada es:{0}", resultado);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                    default:
                        Console.WriteLine("ERROR. La Opcion ingresada no es Valida");
                        break;
                }


            } while (opcion != 5);
 
        }
    }
}
