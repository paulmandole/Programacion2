using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> iAcciones;

        public CartucheraMultiuso(List<IAcciones> lista)
        {
            if (lista is null)
            {
                this.iAcciones = new List<IAcciones>();
            }
            else 
            {
                this.iAcciones = lista;
            }
            
        }
        public bool RecorrerElementos()
        {
            bool ret = true;

            foreach (IAcciones item in this.iAcciones)
            {
                if (item.UnidadesDeEscritura > 1)
                {
                    item.UnidadesDeEscritura -= 1;
                }
                else
                {
                    item.UnidadesDeEscritura += 20;
                    ret = false;
                }
                    
            }

            return ret;
        }
    }
}
