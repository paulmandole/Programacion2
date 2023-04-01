using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public int Add(string numeros)
        {
            char separador = numeros[2];
            string[] numSSeparador;
            int resultado = 0;
            numeros.Remove(0, 5);
            numSSeparador = numeros.Split(separador);
            for (int i = 1; i < numSSeparador.Length; i++)
            {
                resultado += int.Parse(numSSeparador[i]);
            }
            return resultado;
        }
    }
}
