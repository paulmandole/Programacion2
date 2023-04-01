using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;


        public Producto(string marca, string codigoDeBarras, float precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder stringBuilder = new StringBuilder();

            return stringBuilder.AppendFormat($"Codigo de barras:{(string)p}\tMarca:{p.marca}\tPrecio:{p.precio}").ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }

        public static bool operator ==(Producto p, Producto p1)
        {
            return p.codigoDeBarras == p1.codigoDeBarras;
        }
        public static bool operator !=(Producto p, Producto p1)
        {
            return !(p == p1);
        }

        public static bool operator ==(Producto p, string s)
        {
            return string.Equals(p.marca, s);
        }
        public static bool operator !=(Producto p, string s)
        {
            return !(p == s);
        }
    }

}
