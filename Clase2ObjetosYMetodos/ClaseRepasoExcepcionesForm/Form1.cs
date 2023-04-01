using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClaseRepasoExcepciones;


namespace ClaseRepasoExcepcionesForm
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nomb = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
              
                string resultado = LogicaNegocio.CargarUsuario(nomb, edad);

                MessageBox.Show(resultado);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"El dato edad no es correcto, {ex.Message}");
            }
            catch (Exception ex)
            {
                //para mostrar todos los mensajes que traje
                string mensaje = "";
                while(ex.InnerException != null)
                {
                    mensaje +=ex.Message + "\n";
                    ex = ex.InnerException;
                }
                mensaje += ex.Message + "\n";
                MessageBox.Show(mensaje);
                //MessageBox.Show(ex.Message);

                //MessageBox.Show(ex.InnerException.Message);
            }
            

        }
    }
}
