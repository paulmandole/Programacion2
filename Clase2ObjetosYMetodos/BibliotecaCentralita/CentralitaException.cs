using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombrMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
        }
        public string NombreMetodo
        {
            get { return this.nombrMetodo; }
        }
        public CentralitaException(string nombreClase, string nombrMetodo): this(nombreClase,nombrMetodo,null)
        { 
        }
        public CentralitaException(string nombreClase, string nombrMetodo, Exception inner):base(nombreClase, inner)
        {
            this.nombreClase = nombreClase;
            this.nombrMetodo = nombrMetodo;
        }
    }
}
