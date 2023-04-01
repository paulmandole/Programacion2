using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaTP1
{
    public class Operando
    {
        private double numero;


        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando() : this(0)
        {
            
        }

        public Operando(string strNumero) :this (double.Parse(strNumero)) 
        {

        }





        //nueva foram de set y get
        public string Numero
        {
            set 
            {
                this.numero = ValidarOperando(value);
            }
        }

        //revisar si esta bien lo que devuelve
        private double ValidarOperando(string strNumero)
        {
            double numVal = 0;

            if(double.TryParse(strNumero, out numVal))
                double.TryParse(strNumero, out numVal);

            return numVal;
        }

        private bool EsBinario(string binario)
        {
            List<char> letras = new List<char>();
            bool ret = true;

            letras = binario.ToList();

            foreach (char letra in letras)
            {
                if (letra != '1' || letra != '0')
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }

        public string BinarioDecimal(string binario)
        {
            string ret = "Valor Invalido";

            if (EsBinario(binario))
                ret = decimal.Parse(binario).ToString();

            return ret;
        }
        public static string DecimalBinario(string numero)
        {
            string ret = "Valor Invalido";
            int[] binario;
            StringBuilder binarioString =  new StringBuilder();

            if (numero.All(char.IsDigit))
            {
                binario = Decimal.GetBits(decimal.Parse(numero));

                for (int i = 0; i < binario.Length; i++)
                {
                    binarioString.Append(binario[i].ToString());

                }

                ret = binarioString.ToString();
            }
               

            return ret;
        }

        public  static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }


        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;

            if (n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            { 
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

    }
}
