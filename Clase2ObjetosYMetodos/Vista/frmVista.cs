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
    public partial class frmVista : Form
    {
        public frmVista()
        {
            InitializeComponent();
        }

        private void abrirFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVista frmVista = new FrmVista();
            frmVista.MdiParent = this; 
            frmVista.ShowDialog();
        }

       
    }
}
