using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCentralita;

namespace Ejercicio_C01___La_centralita_Episodio_II
{
    public partial class FrmMenu : Form
    {
        private Centralita centralita;
        private TipoLlamada tipo;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Paul Central");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);

            frmLlamador.ShowDialog();
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            float gananciaTotal = centralita.GananciaPorTodas;
            FrmMostrar frmMostrar = new FrmMostrar(centralita);

            frmMostrar.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
              Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de salir?", "Salir?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            float gananciaLocal = centralita.GananciaPorLocal;

            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.ShowDialog();
        }

        private void btnFactProv_Click(object sender, EventArgs e)
        {
            float gananciaProv = centralita.GananciaPorProvincial;
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.ShowDialog();
        }
    }
}
