using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;


namespace Vista
{
    public partial class Clientes : Form
    {
        
        public Clientes()
        {
            InitializeComponent();
        }

        private void txbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form agregarCliente = new AgregarModificarCliente();
            agregarCliente.ShowDialog();
            CargarClientes();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.dGVClientes.SelectedRows[0].Index;
            if ( indice != -1)
            {

                string? id =  this.dGVClientes.SelectedRows[0].Cells[0].Value.ToString();
                int idEntero =  int.Parse(id);
                Form agregarCliente = new AgregarModificarCliente(idEntero);
                //agregarCliente

                agregarCliente.ShowDialog();
                CargarClientes();

            }
            else
            {
                MessageBox.Show("debe seleccionar un cliente para modificar");
            }
            
        }
        public void CargarClientes()
        {
            List<Cliente> clientes = GestorSQL.LeerDatos();
            int n = 0;
            this.dGVClientes.Rows.Clear();
            foreach (var cliente in clientes)
            {
                this.dGVClientes.Rows.Add();
                this.dGVClientes.Rows[n].Cells[0].Value = cliente.Id;
                this.dGVClientes.Rows[n].Cells[1].Value = cliente.Nombre;
                this.dGVClientes.Rows[n].Cells[2].Value = cliente.Apellido;
                this.dGVClientes.Rows[n].Cells[3].Value = cliente.Email;
                this.dGVClientes.Rows[n].Cells[4].Value = cliente.Telefono;
                this.dGVClientes.Rows[n].Cells[5].Value = cliente.FechaEvento;
                n++;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.dGVClientes.SelectedRows[0].Index;
            if (indice != -1)
            { 
                string? id = this.dGVClientes.SelectedRows[0].Cells[0].Value.ToString();
                int idEntero = int.Parse(id);

                if (MessageBox.Show("Seguro de Eliminar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    GestorSQL.Borrar(idEntero);
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("debe seleccionar un cliente para Eliminar");
            }

        }

        private void dGVClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
