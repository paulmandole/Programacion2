using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{


    public class Evento
    {
        public int idEvento;
        private int idCliente;
        private DateTime fechaEvento;
        private List<Producto> productos;
        private string tipoEvento;

        public Evento(int idCliente, DateTime fechaEvento, string tipoEvento)
        {
            this.idCliente = idCliente;
            this.fechaEvento = fechaEvento;
            productos = new List<Producto>();
            this.tipoEvento = tipoEvento;
        }

        public void agregarProducto(Producto nuevoProducto)
        {
            if (nuevoProducto is not null)
                productos.Add(nuevoProducto);
        }


    }
}
