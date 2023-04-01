using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuervo : AnimalVolador, IMensaje,IEncriptado
    {
        public Cuervo(string nombre) : base(nombre)
        {
        }

        public string EnviarMendaje()
        {
            return "llego el invierno";
        }
        string IEncriptado.EnviarMendaje()
        {
            return "Jon Snow es el verdadero rey";
        }
    }
}
