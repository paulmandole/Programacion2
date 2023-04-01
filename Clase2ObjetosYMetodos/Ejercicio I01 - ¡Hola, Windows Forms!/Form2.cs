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
    public partial class Form2 : Form
    {
        private string nombre;
        private string apellido;
        private static string mensaje;
        private string materiaFavorita;


        static Form2()
        {
            mensaje = "¡Hola, Windows Forms!";
        }
        public Form2(string nombre, string apellido, string materiaFavorita)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.materiaFavorita = materiaFavorita;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.labelMensaje.Text = mensaje;
            this.labelNombre.Text = String.Format($"Hola {nombre} {apellido} y mi materia favorita es {materiaFavorita}");
        }
    }
}
