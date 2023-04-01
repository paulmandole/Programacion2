using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadDeSumas;

        public Sumador (int cantidadDeSumas)
        {
            this.cantidadDeSumas = cantidadDeSumas;
        }

        public Sumador () : this(0)
        {
            
        }

        public long Sumar(long a, long b)
        {
            this.cantidadDeSumas++;
            return a + b;
        }

        public string Sumar(string a,string b)
        {
            this.cantidadDeSumas++;
            return string.Format($"{a}{b}");
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadDeSumas;
        }

        public static long operator +(Sumador a,Sumador b)
        {
            return (int)a + (int)b;
        }
        public static bool operator |(Sumador a, Sumador b)
        {
            return a.cantidadDeSumas == b.cantidadDeSumas;
        }

        public int GetCantidadDeSumas()
        {
            return this.cantidadDeSumas;
        }
    }
}
