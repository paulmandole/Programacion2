using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01____Hola__Windows_Forms_
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Se deben completar los siguientes campos:\n");
            //this.nombre del objeto.Text recive lo que puso el usuario
            if (!String.IsNullOrEmpty(this.textBoxNombre.Text) && !string.IsNullOrEmpty(this.textBoxApellido.Text))
            {
                Form form = new Form2(this.textBoxNombre.Text, this.textBoxApellido.Text, this.comboMaterias.Text);
                form.ShowDialog();
            }
            else 
            {
                if (string.IsNullOrEmpty(this.textBoxNombre.Text))
                {
                    stringBuilder.AppendLine("Nombre");   
                }

                if (string.IsNullOrEmpty(this.textBoxApellido.Text))
                {
                    stringBuilder.AppendLine("Apellido");
                }
                //mesangebox lo que hace es mostrar carteles de acuardo a lo que necesite el primer parametro es el mensaje a enviar luego el nombre de la ventana
                //luego los botones q tendra para cerrar o lo que necesite y por ultimo pu icono que puedo ponerle para q se vea como en este caso la x de error
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] materias = { "Programacion 1", "Programacion 2", "Laboratorio 1", "Laboratorio 2", "Ingles 1", "Ingles 2" };
            this.comboMaterias.Items.AddRange(materias);
        }

        private void comboMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
