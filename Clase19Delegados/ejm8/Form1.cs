using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejm8
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
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    labelInfoText.Text = GestorDatos.TraerRegistros();
        //}

        private async void button1_Click(object sender, EventArgs e)
        {
            //espera a q se solucione lo de gestor de datos
            labelInfoText.Text = await GestorDatos.TraerRegistros2();
        }
    }
}
