using System;

namespace Biblioteca
{

    public class Producto

    {
        private int idProducto;
        private int cantidad;
        private string nombre;

        public Producto(string nombre, int cantidad)
        {
            this.cantidad = cantidad;
            this.nombre = nombre;
        }
        public Producto(int idProducto, int cantidad, string nombre):this(nombre, cantidad)
        {
            this.idProducto = idProducto;
        }


        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return  this.Nombre ;
        }


    }
}
