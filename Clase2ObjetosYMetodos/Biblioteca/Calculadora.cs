using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Calculadora
    {

        public static float Calcular(float primerOperando, float segundoOperando, char operacion)
        {
            float resultado = 0;

            if (operacion == '*')
            {
                resultado = primerOperando * segundoOperando;
            }

            if (operacion == '-')
            {
                resultado = primerOperando - segundoOperando;
            }

            if (operacion == '+')
            {
                resultado = primerOperando + segundoOperando;
            }

            if (operacion == '/')
            {
                if (Validar(segundoOperando))
                {
                    resultado = primerOperando / segundoOperando;
                }  
            }

            return resultado;
        }

        private static bool Validar(float segundoOperando)
        {
            return segundoOperando != 0;
        }
    }
}
