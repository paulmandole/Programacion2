using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarNombre(string nombre) => lblNombre.Text = nombre;


       
    }
}
