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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vistaInv = new vistaInventario();
            vistaInv.ShowDialog();
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form Clientes = new Clientes();
            Clientes.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
