using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase12
{
    public class Inventario<T,U> 
        
        where U : MedioTransporte
        
    {
        List<U> listaMedioTransporte;
       

        public void SumarCantidadDeCombustible()
        {
            foreach (U item in listaMedioTransporte)
            {
                item.nombre = "";
            }
        }

       

    }
}
