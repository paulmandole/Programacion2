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


namespace Ejercicio_I01___La_lista_del_super
{
   
    public partial class Form1 : Form
    {
        public List<string> listaSupermercado;
        public string path;
        public Form1()
        {
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\listaSupermercado.xml";
            listaSupermercado = new List<string>();
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            try
            {
                
                listaSupermercado = Serializador.LeerXML(path);
                foreach (string item in listaSupermercado)
                {
                    this.lstObjetos.Items.Add(item);
                }

            }
            catch (Exception)
            {

                
            }

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnMas, "Agregar objeto");
            toolTip.SetToolTip(btnMenos, "Eliminar objeto");
            toolTip.SetToolTip(btnModificar, "Modificar objeto");

            
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAlta = new FrmAltaModificacion("Agregar","","agregar");
            
            frmAlta.ShowDialog();

            if (frmAlta.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAlta.Objeto);
                lstObjetos.DataSource = null;
                lstObjetos.DataSource = listaSupermercado;
                Serializador.GuargarXML(listaSupermercado, path);
            }
               
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedIndex != -1)
            {
                listaSupermercado.RemoveAt(lstObjetos.SelectedIndex);
                lstObjetos.DataSource = null;
                lstObjetos.DataSource = listaSupermercado;
                Serializador.GuargarXML(listaSupermercado,path);
            }
            else 
            {
                MessageBox.Show("Debe Selecionar un elemento para eliminar");
            }
            

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (this.lstObjetos.SelectedIndex != -1)
                {
                    FrmAltaModificacion frmModificacion = new FrmAltaModificacion("Modificar", this.lstObjetos.SelectedItem.ToString(), "agregar");

                    frmModificacion.ShowDialog();

                    if (frmModificacion.DialogResult == DialogResult.OK)
                    {
                        listaSupermercado.Remove(this.lstObjetos.SelectedItem.ToString());
                        listaSupermercado.Insert(this.lstObjetos.SelectedIndex, frmModificacion.Objeto);
                        lstObjetos.DataSource = null;
                        lstObjetos.DataSource = listaSupermercado;
                        Serializador.GuargarXML(listaSupermercado, path);
                    }
                }
                else 
                {
                    MessageBox.Show("Debe seleccionar un producto para modificar");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
