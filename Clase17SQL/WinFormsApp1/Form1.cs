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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ClienteDAO clienteDAO;
        public Form1()
        {
            clienteDAO = new ClienteDAO();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(this.txbNombre.Text, this.txbDireccion.Text);

                ClienteDAO clienteDAO = new ClienteDAO();

                clienteDAO.Guardar(cliente);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.ActualizarLstCliente();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            
            listClientes.DataSource = clienteDAO.Leer();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbNombre.Text) && !string.IsNullOrEmpty(txbDireccion.Text))
            {
                Cliente nuevoCliente = new Cliente(txbNombre.Text, txbDireccion.Text);
                Cliente clienteSeleccionado = listClientes.SelectedItem as Cliente;
                if (clienteSeleccionado is not null)
                {
                    clienteDAO.Modificar(clienteSeleccionado.Id, nuevoCliente);
                }
                this.ActualizarLstCliente();

            }
        }

        private void listClientes_DoubleClick(object sender, EventArgs e)
        {
            Cliente cliente = listClientes.SelectedItem as Cliente;
            if (cliente is not null)
            {
                txbNombre.Text = cliente.Nombre;
                txbDireccion.Text = cliente.Direccion;

                
            }
            this.ActualizarLstCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = listClientes.SelectedItem as Cliente;
            if (clienteSeleccionado is not null)
            {
                clienteDAO.Eliminar(clienteSeleccionado.Id);
            }
            this.ActualizarLstCliente();
        }

        private void ActualizarLstCliente()
        {
            listClientes.DataSource = null;
            listClientes.DataSource = clienteDAO.Leer();

        }
    }
}
