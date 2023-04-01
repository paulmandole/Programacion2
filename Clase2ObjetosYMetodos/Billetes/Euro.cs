using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Euro(double cantidad,double cotizacion)
        {
            this.cantidad = cantidad;
            cotzRespectoDolar = cotizacion;
        }

        public Euro(double cantidad) : this(cantidad, cotzRespectoDolar)
        { 
        }

        public Euro() : this(0, cotzRespectoDolar)
        {
            
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static void SetCotizacion(double cotizacion)
        {
             cotzRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        
        static Euro()
        {
            cotzRespectoDolar = 1 / 1.18;
        }

        public static implicit operator Euro(double monto)
        {
            return new Euro(monto);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad / Pesos.GetCotizacion());
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator !=(Euro e ,Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Euro e1)
        {
            return e.GetCantidad() == e1.GetCantidad();
        }

        public static bool operator !=(Euro e, Euro e1)
        {
            return !(e == e1);
        }
    }
}
