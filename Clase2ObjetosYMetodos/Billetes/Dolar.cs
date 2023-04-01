using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Dolar(double cantidad,double cotizacion)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = cotizacion;
        }

        public Dolar(double cantidad):this(cantidad,cotzRespectoDolar)
        {
            
        }
        public Dolar() : this(0, cotzRespectoDolar)
        {
            
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public static implicit operator Dolar(double monto)
        {
            return new Dolar(monto);
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad / Pesos.GetCotizacion());
        }

        public static bool operator ==(Dolar d, Euro e)
        {

            return d == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Dolar d1)
        {
            return d.GetCantidad() == d1.GetCantidad();
        }

        public static bool operator !=(Dolar d, Dolar d1)
        {
            return !(d == d1);
        }



    }
}
