using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public CartucheraSimple(List<Boligrafo> boligrafos, List<Lapiz> lapices)
        {
            if (boligrafos is not null && lapices is not null)
            {
                this.boligrafos = boligrafos;
                this.lapices = lapices;
            }
            else 
            {
                this.boligrafos = new List<Boligrafo>();
                this.lapices = new List<Lapiz>();
            }
           
        }

        public bool RecorrerElementos()
        {
            bool ret = true;

            foreach (Boligrafo item in this.boligrafos)
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
            foreach (Lapiz item in this.lapices)
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
