using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class CalculadoraDeArea
    {

        public static double CalcularAreaDelCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);//calcular la potencia de 2 usando math
        }

        public static double CalcularAreaDelTriangulo(double baseDeltriangulo, double altura)
        {
            return (baseDeltriangulo * altura) / 2;
        }
        public static double CalcularAreaDelCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }
}
