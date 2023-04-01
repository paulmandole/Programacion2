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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        
        public FrmMostrar(Centralita centralita)
        {
            
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.rtbxMostrarInfo.Text = centralita.ToString();
        }
    }
}
