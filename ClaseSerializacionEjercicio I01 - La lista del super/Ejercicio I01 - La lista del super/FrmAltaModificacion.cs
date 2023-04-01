using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio_I01___La_lista_del_super
{
    public partial class FrmAltaModificacion : Form
    {
        public string titulo;
        public string textoObjeto;
        public string textoBton;


        public FrmAltaModificacion(string titulo, string textoObjeto, string textoBton):this()
        {
            this.titulo = titulo;
            this.textoObjeto = textoObjeto;
            this.textoBton = textoBton;
            Text = titulo;

        }
        public string Objeto
        {
            get { return this.txtObjeto.Text; }
        }
        public FrmAltaModificacion()
        {
            InitializeComponent();
        }

        private void txtObjeto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13 || e.KeyChar == (char)27)
            {
                if (string.IsNullOrEmpty(this.txtObjeto.Text))
                {
                    MessageBox.Show("El contenido no puede estar vacio");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                    
                
            }
            
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            this.txtObjeto.Text = textoObjeto;
            this.btnConfirmar.Text = textoBton;
            
            
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtObjeto.Text))
            {
                MessageBox.Show("El contenido no puede estar vacio");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
