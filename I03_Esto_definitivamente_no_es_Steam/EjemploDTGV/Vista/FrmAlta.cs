using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmAlta : Form
    {

        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            this.codigoJuego = codigoJuego;
            btnGuardar.Text = "Modificar";
            nupPrecio.Maximum = 10000;
            PintarForm();
            cmbUsuarios.Enabled = false;
            
            
        }

        private void PintarForm()
        {
            Juego juegoAModificar = JuegoDAO.LeerPorId(codigoJuego);
            nupPrecio.Value = (Decimal)juegoAModificar.Precio;
            txtNombre.Text = juegoAModificar.Nombre;
            txtGenero.Text = juegoAModificar.Genero;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDAO.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtGenero.Text))
                {
                    Usuario usuarioAux = cmbUsuarios.SelectedItem as Usuario;
                    if (btnGuardar.Text == "Modificar" && usuarioAux is not null)
                    {

                        Juego aModificar = new Juego(codigoJuego, usuarioAux.CodigoUsuario, txtGenero.Text, txtNombre.Text, (double)nupPrecio.Value);
                        JuegoDAO.Modificar(aModificar);
                    }
                    else if (usuarioAux is not null)
                    {

                        Juego nuevoJuego = new Juego(usuarioAux.CodigoUsuario, txtGenero.Text, txtNombre.Text, (double)nupPrecio.Value);
                        JuegoDAO.Guardar(nuevoJuego);
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Hay uno o mas campos vacios");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Error al guardar el juego");
            }

        }
    }
}
