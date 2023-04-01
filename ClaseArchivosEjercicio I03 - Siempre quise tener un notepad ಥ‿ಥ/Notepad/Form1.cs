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
using System.IO;

namespace Notepad
{
    
    public partial class Form1 : Form
    {
        private string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.tssLabel.Text = this.richTextBox1.TextLength.ToString();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            try
            {
                file.ShowDialog();

                path = file.FileName;
                this.richTextBox1.Text = ManejadorArchivosTexto.leerArchivoTxt(path);
            }
            catch (ArgumentException)
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    ManejadorArchivosTexto.GuardarArchivotxt(path, this.richTextBox1.Text);
                }
                else 
                {
                    guardarArchivoDialog();
                }
            }
            catch (ArgumentException)
            {

            }
            catch (Exception)
            {

                MessageBox.Show("Error en Guardar el archivo");
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                guardarArchivoDialog();


            }
            catch (ArgumentException)
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guardarArchivoDialog()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivo de texto|.txt";
            saveFile.ShowDialog();
            path = saveFile.FileName;
            ManejadorArchivosTexto.GuardarArchivotxt(path, this.richTextBox1.Text);
        }
    }
}
