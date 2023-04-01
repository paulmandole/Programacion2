using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void NotificarTiempoCumplido()
        {
            MessageBox.Show("Se Cumplio el tiempo");
        }
        private void MostrarTiempoRestante(int segundos)
        {
            if (this.InvokeRequired)
            {
                Action<int> delegado = MostrarTiempoRestante;
                Invoke(delegado, segundos);
            }
            else 
            {
                label1.Text = $"Quedan {segundos} segundos";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Temporizador temporizador = new Temporizador();
            temporizador.Ejecutar(int.Parse(textBox1.Text));
            temporizador.OnTiempoFinalizado += NotificarTiempoCumplido;
            temporizador.OnTiempoRestante += MostrarTiempoRestante;
        }
    }
}
