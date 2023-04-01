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
    public partial class FrmVista : Form
    {
        public FrmVista()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmVista_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarInfo_Click(object sender, EventArgs e)
        {
            //agregar por codigo items a un combo box
            this.comboBox2.Items.Add("Juancho");
            //agregar por codigo items a un ListBox en este caso lo que escrivo con un text box
            this.listBox2.Items.Add(this.textBox2.Text);
            //para la barra de carga le asigno un valor y va cargando
            //this.progressBar1.Value++;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.listBox2.SelectedItem.ToString());
        }

        private void FrmVista_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FrmVista_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Cerrar?", "Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmVista_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
