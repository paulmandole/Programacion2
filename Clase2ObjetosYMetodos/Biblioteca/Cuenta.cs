using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;


        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            return stringBuilder.AppendFormat("{0} {1}", GetTitular(), GetCantidad().ToString()).ToString();
        }

        public void IngresarCantidad(decimal monto)
        {
            if(monto > 1)
                this.cantidad += monto;
        }

        public void RetirarCantidad(decimal monto)
        {
            this.cantidad -= monto;
        }
    }
}
