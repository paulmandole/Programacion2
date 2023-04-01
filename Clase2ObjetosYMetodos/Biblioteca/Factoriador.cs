using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Factoriador
    {

        public static double Factoriar(int numero)
        {
            double numeroFactoriado = 1;

            for (int i = 1; i <= numero; i++)
            {
                numeroFactoriado = numeroFactoriado * i;
            }

            return numeroFactoriado;
        }
        
    }
}
