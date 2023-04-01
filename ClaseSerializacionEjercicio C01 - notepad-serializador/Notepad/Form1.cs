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
        private PuntoJson<string> puntoJson;
        private PuntoXml<string> puntoXml;
        private PuntoTxt puntoTxt;
        public Form1()
        {
            puntoTxt = new PuntoTxt();
            puntoJson = new PuntoJson<string>();
            puntoXml = new PuntoXml<string>();
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.tssLabel.Text = this.richTextBox1.TextLength.ToString();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo Texto|*.txt|Archivo XML|*.xml|Archivo Json|*.Json";

            try
            {

                
                file.ShowDialog();
                path = file.FileName;
                if (Path.GetExtension(path) == ".json")
                {
                    this.richTextBox1.Text = puntoJson.Leer(path);
                }
                if (Path.GetExtension(path) == ".xml")
                {
                    this.richTextBox1.Text = puntoXml.Leer(path);
                }
                if(Path.GetExtension(path) == ".txt")
                {
                    this.richTextBox1.Text = puntoTxt.Leer(path);
                }
                
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
                    if (Path.GetExtension(path) == ".json")
                    {
                        puntoJson.Guardar(path, this.richTextBox1.Text);
                    }
                    if (Path.GetExtension(path) == ".xml")
                    {
                        puntoXml.Guardar(path, this.richTextBox1.Text);
                    }
                    if (Path.GetExtension(path) == ".txt")
                    {
                        puntoTxt.Guardar(path, this.richTextBox1.Text);
                    }
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
            saveFile.Filter = "Archivo Texto|*.txt|Archivo XML|*.xml|Archivo Json|*.Json";
            saveFile.ShowDialog();
            path = saveFile.FileName;
            if (Path.GetExtension(path) == ".json")
            {
                puntoJson.Guardar(path, this.richTextBox1.Text);
            }
            if (Path.GetExtension(path) == ".xml")
            {
                puntoXml.Guardar(path, this.richTextBox1.Text);
            }
            if (Path.GetExtension(path) == ".txt")
            {
               puntoTxt.Guardar(path, this.richTextBox1.Text);
            }
            
        }
    }
}
