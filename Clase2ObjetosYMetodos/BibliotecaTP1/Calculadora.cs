using System;

namespace BibliotecaTP1
{
    public static class Calculadora
    {

        private static char ValidarOperador(char operador)
        {
            char ret = '+';

            if (operador == '-' || operador == '+' || operador == '/' || operador == '*')
                ret = operador;

            return ret;
        }
        public static double Operar(Operando n1, Operando n2, char operador)
        {
            char operadorVal = ValidarOperador(operador);
            double resultado = 0;

            if (operadorVal == '+')
                resultado = n1 + n2;
            if (operadorVal == '-')
                resultado = n1 - n2;
            if (operadorVal == '*')
                resultado = n1 * n2;
            if (operadorVal == '/')
            {
                    resultado = n1 / n2;
            }  

            return resultado;
        }

}
}
