using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClase10;

namespace Ejercicio_I02___Atrapame_si_puedes
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.tbxLitros.Text == "" || this.tbxkilometros.Text == "")
                {
                    throw new ParametrosVaciosExeption("Alguno de los campos esta vacio");
                }

                this.rtxbResultado.Text = $"Km / hs {Calculador.Calcular(int.Parse(this.tbxkilometros.Text), int.Parse(this.tbxLitros.Text))}";
            }
            catch (ParametrosVaciosExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("El Formato de entrada no es el correcto");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
