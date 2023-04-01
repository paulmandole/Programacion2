using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Courrier : Persona, IMensaje
    {
        public Courrier()
        { 
        }

        public Courrier(string nombre, string apellido, string dni) : base(nombre, apellido, dni)
        {
        }

        public string EnviarMendaje()
        {
            return "La ficha se encuentra en el Lucky33";
        }
    }
}
