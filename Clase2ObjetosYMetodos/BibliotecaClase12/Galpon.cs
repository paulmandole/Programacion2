using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase12
{
    public class Galpon <T>
    {
        int idGalpon;
       
        List<T> listDeElementos;

        public Galpon()
        {
            listDeElementos = new List<T>();
        }
        public int CantidadElementos
        {
            get { return listDeElementos.Count; }
        }
        public T PrimerElemento()
        {
            return listDeElementos[0];
        }
        public bool GuardarObjeto(T objetoAGuardar)
        {
            return true;
        }
    }
}
