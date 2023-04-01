using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Temporizador temporizador = new Temporizador();
            temporizador.OnTiempoFinalizado += MostarTiempoCumplido;
            temporizador.OnTiempoRestante += MostrarTiempoRestante;

            temporizador.Ejecutar(int.Parse(textBox1.Text));
        }

        public  void MostrarTiempoRestante(int segundos)
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

        //metodo q quiero que reaccione al evento tiene q tener la misma firma que el delegado
        public static void MostarTiempoCumplido()
        {
            MessageBox.Show("Se cumplio el tiempo");
        }
    }
}
