using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseRepasoExcepciones
{
    public class ErrorDeDatosIngresadosException : Exception
    {
        public ErrorDeDatosIngresadosException() : base("Error de datos,revisar")
        {
        }

        public ErrorDeDatosIngresadosException(string message) : base(message)
        {
        }

        public ErrorDeDatosIngresadosException(string message, Exception innerException) : base(message, innerException)
        {
        }
        //puedo sobrcargar
        public override string StackTrace
        {
            get
            {
                return base.StackTrace + "  ";
            }
        }


    }
}
