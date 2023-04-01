using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ArchivoIncorrectoException : Exception
    {
        private string mensaje;
        private string nombrMetodo;

        public string NombreClase
        {
            get { return this.mensaje; }
        }
        public string NombreMetodo
        {
            get { return this.nombrMetodo; }
        }
        public ArchivoIncorrectoException(string mensaje, string nombrMetodo) : this(mensaje, nombrMetodo, null)
        {
        }
        public ArchivoIncorrectoException(string mensaje, string nombrMetodo, Exception inner) : base(mensaje, inner)
        {
            this.mensaje = mensaje;
            this.nombrMetodo = nombrMetodo;
        }
    }
}
