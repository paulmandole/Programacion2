using System;
using BibliotecaClase9;
using System.Collections.Generic;

namespace Ejercicio_I02___Calculadora_de_formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>()
            {
                new Cuadrado(4),new Rectangulo(8,4),new Circulo(19) 
            };


            foreach (Figura item in figuras)
            {
                //figuras.indexof() devuelve el indice del item
                Console.WriteLine($"================= Figura {figuras.IndexOf(item)} ===================");
                Console.WriteLine($"Tipo:{item.GetType().Name}\n{item.Dibujar()}\nArea:{Math.Round(item.CalcularSuperficie(),2)}\nPerimetro:{Math.Round(item.CalcularPerimetro(),2)}");
            }
            
        }
    }
}
