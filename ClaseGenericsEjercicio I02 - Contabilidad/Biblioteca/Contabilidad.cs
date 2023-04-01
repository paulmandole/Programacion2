using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad <T,U> 
        where T : Documento 
        where U : Documento, new()
    {
        public List<T> egresos;
        public List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        
        public static Contabilidad<T,U> operator +(Contabilidad<T, U> cont,T t)
        {

            if (t is not null && cont is not null)
            {
                cont.egresos.Add(t);
               
            }
            return cont;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> cont,U u)
        {
            
            if (u is not null && cont is not null)
            {
                cont.ingresos.Add(u);
                
            }
            return cont;
        }
    }
}
