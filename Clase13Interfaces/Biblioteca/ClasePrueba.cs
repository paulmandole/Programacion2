using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClasePrueba : IPrueba<Courrier>
    {
        //public static string Probar(IMensaje mensaje)
        //{
        //    return mensaje.EnviarMendaje();
        //}
        public Courrier MostrarPersona<U>(U nombre) where U : AnimalVolador
        {
            return new Courrier();
        }
    }
}
