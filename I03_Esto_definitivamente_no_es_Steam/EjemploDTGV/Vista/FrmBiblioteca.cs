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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            List<Biblioteca> listBiblioteca = new List<Biblioteca>();
            listBiblioteca = JuegoDAO.Leer();

            dtgvBiblioteca.ClearSelection();
            dtgvBiblioteca.DataSource = listBiblioteca;


        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro decea salir?", "salir",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            { 
                Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca newBiblioteca = dtgvBiblioteca.CurrentRow.DataBoundItem as Biblioteca;
                    FrmAlta frmModificar = new FrmAlta(newBiblioteca.CodigoJuego);
                    if (newBiblioteca is not null)
                    {
                        
                        if (frmModificar.ShowDialog() == DialogResult.OK)
                        {
                            RefrescarBiblioteca();
                        }
                    }

                    
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar");
            }
          
        }

    }
}
