using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase9
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;


        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get;}


        public abstract string MiMetodo();

       
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            Sobreescrito strc = obj as Sobreescrito;
            if (strc is not null)
            {
                ret = true;
            }
            return ret;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
