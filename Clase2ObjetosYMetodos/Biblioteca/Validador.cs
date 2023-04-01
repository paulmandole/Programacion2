using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validador
    {
        
        public static bool ValidarRango(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        public static bool ValidarRango(float valor, float min, float max)
        {
            return valor >= min && valor <= max;
        }
        public static bool ValidarRango(string valor, int min, int max)
        {
            return valor.Length >= min && valor.Length <= max;
        }
        public static bool ValidarRango(string valor, int max)
        {
            return valor.Length >= max;
        }

        public static bool ValidarRango(int min, string valor)
        {
            return valor.Length <= min;
        }
       

    }
}
