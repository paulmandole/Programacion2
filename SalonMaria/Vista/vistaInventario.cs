using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Vista
{
    public partial class vistaInventario : Form
    {
        public vistaInventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vistaInventario_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        public void cargarProductos()
        {

            List<Producto> productos = GestorSQLProductos.LeerDatos();
            
            int n = 0;
            this.dGVProductos.Rows.Clear();
            foreach (var producto in productos)
            {
                this.dGVProductos.Rows.Add();
                this.dGVProductos.Rows[n].Cells[0].Value = producto.IdProducto;
                this.dGVProductos.Rows[n].Cells[1].Value = producto.Nombre;
                this.dGVProductos.Rows[n].Cells[2].Value = producto.Cantidad;
                n++;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //validar con validaciones 
            if (this.txbNombre.Text is not null && this.txbCantidad.Text is not null)
            {
                _ = int.TryParse(this.txbCantidad.Text, out int cantidad);
                
                Producto nuevoProducto = new Producto(this.txbNombre.Text,cantidad);

                GestorSQLProductos.Alta(nuevoProducto);
                cargarProductos();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = this.dGVProductos.SelectedRows[0].Index;
            if (indice != -1)
            {
                string? id = this.dGVProductos.SelectedRows[0].Cells[0].Value.ToString();
                int idEntero = int.Parse(id);

                if (MessageBox.Show("Seguro de Eliminar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    GestorSQLProductos.Borrar(idEntero);
                    cargarProductos();
                }
            }
            else
            {
                MessageBox.Show("debe seleccionar un cliente para Eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.dGVProductos.SelectedRows[0].Index;
            if (indice != -1)
            {
                string? id = this.dGVProductos.SelectedRows[0].Cells[0].Value.ToString();
                int idEntero = int.Parse(id);

                if (MessageBox.Show("Seguro de Modificar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Producto productoModif = new Producto(this.txbNombre.Text, int.Parse(this.txbCantidad.Text));
                    GestorSQLProductos.Actualizar(productoModif,idEntero);
                    cargarProductos();
                }
            }
            else
            {
                MessageBox.Show("debe seleccionar un cliente para Eliminar");
            }
        }
    }
}
