using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;


namespace Vista
{
    public partial class AgregarModificarCliente : Form
    {
        public int idPrecargado = -1;

        public AgregarModificarCliente(int idPrecargado):this()
        {
            this.idPrecargado = idPrecargado;
        }

        public AgregarModificarCliente()
        {
            InitializeComponent();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro de Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
       

        private void AgregarModificarCliente_Load(object sender, EventArgs e)
        {
            if (idPrecargado != -1)
            {
                Cliente clienteAMod = GestorSQL.LeerDatosPorId(idPrecargado);
                this.txtNombre.Text = clienteAMod.Nombre;
                this.txtApellido.Text = clienteAMod.Apellido;
                this.txtMail.Text = clienteAMod.Email;
                this.txtTelefono.Text = clienteAMod.Telefono;
                this.dateTime.Value = clienteAMod.FechaEvento;
                this.button1.Text = "modificar";


            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPrecargado == -1)
                {
                    string nombre = this.txtNombre.Text;
                    string apellido = this.txtApellido.Text;
                    string mail = this.txtMail.Text;
                    string telefono = this.txtTelefono.Text;
                    DateTime fechaEvento = this.dateTime.Value;

                    Cliente cliente = new Cliente(nombre, apellido, mail, telefono, fechaEvento);

                    GestorSQL.Alta(cliente);
                    MessageBox.Show("Carga Exitosa");
                    this.Close();
                }
                else
                {
                    string nombre = this.txtNombre.Text;
                    string apellido = this.txtApellido.Text;
                    string mail = this.txtMail.Text;
                    string telefono = this.txtTelefono.Text;
                    DateTime fechaEvento = this.dateTime.Value;

                    Cliente cliente = new Cliente(nombre, apellido, mail, telefono, fechaEvento);
                    GestorSQL.Actualizar(cliente, idPrecargado);
                    MessageBox.Show("Modificacion Exitosa");
                    this.Close();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error en Base de Datos");
            }

            


        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
