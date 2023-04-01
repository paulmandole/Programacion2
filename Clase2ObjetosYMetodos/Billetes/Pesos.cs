using System;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;


        public Pesos(Double monto,double cotizacion)
        {
            this.cantidad = monto;
            cotzRespectoDolar = cotizacion;
        }

        public Pesos(double monto) : this(monto,cotzRespectoDolar)
        {
        }

        public Pesos() : this(0, cotzRespectoDolar)
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

        static Pesos()
        {
            cotzRespectoDolar =  1 /102.65;
        }

        public static implicit operator Pesos(double monto)
        { 
            return new Pesos(monto);
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Pesos.GetCotizacion());
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {

            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Pesos p1)
        {
            return !(p.GetCantidad() == p1.GetCantidad());
        }

        public static bool operator !=(Pesos p, Pesos p1)
        {
            return !(p == p1);
        }
    }
}
