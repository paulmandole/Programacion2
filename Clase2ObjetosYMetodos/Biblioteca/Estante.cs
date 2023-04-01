using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private  Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool ret = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if ((string)e.productos[i] == (string)p)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool ret = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null)
                {

                    e.productos[i] = p;
                    ret = true;
                    break;
    
                }

            }
            return ret;
        }

        public static Estante operator -(Estante e, Producto p)
        {

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < e.productos.Length; i++)
            {
                stringBuilder.AppendFormat($"{Producto.MostrarProducto(e.productos[i])}\n");
            }
            return stringBuilder.ToString();
        }
    }
}
