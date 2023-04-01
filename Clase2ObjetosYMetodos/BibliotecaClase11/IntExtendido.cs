using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase11
{
    public static class IntExtendido
    {
        //puedo agrega parametros si quiero (this int i , string saludos)
        public static string FizzBuzz(this int i)
        {
            string respuesta = string.Empty;
            if (i % 3 == 0)
                respuesta = "Fizz";
            if (i % 5 == 0)
                respuesta += "Buzz";
            if(string.IsNullOrEmpty(respuesta))
                respuesta = i.ToString();

            return respuesta;
        }
    }
}
