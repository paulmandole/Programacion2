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

namespace Ejercicio_I02___Registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] paises = { "argentina", "paraguay", "brazil" };
            this.listBoxPaises.Items.AddRange(paises);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxNombre.Text) && !string.IsNullOrEmpty(this.textBoxDireccion.Text)
                 && this.numEdad.Value >= 17 
                 && (this.radioBtnMasculino.Checked || this.radioButtonFemenino.Checked || this.radioButtonNoBinario.Checked))
            {
                
                Ingresante persona = new Ingresante(ObtenerCursos(),this.textBoxDireccion.Text,(int)this.numEdad.Value,this.groupBoxSexo.Text,this.textBoxNombre.Text,"argentina");
                MessageBox.Show(persona.Mostrar().ToString());
            }
            
        }

        private string[] ObtenerCursos()
        {
            string[] cursos;
            cursos = new string[2];
            int i = 0;
            if (this.checkBoxC.Checked)
            {
                cursos[i] = "C#";
                i++;
            }
            if (this.checkBoxCmas.Checked)
            {
                cursos[i] = "C++";
                i++;
            }
            if (this.checkBoxJs.Checked)
            {
                cursos[i] = "JavaScript";
                i++;
            }
            return cursos;

        }
    }
}
