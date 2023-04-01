using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCentralita;

namespace Ejercicio_C01___La_centralita_Episodio_II
{

    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        private string numero;
        public FrmLlamador(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public Centralita DevolverCentralita
        {
            get { return this.centralita;}
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

 


        private void CargarNrOrigen(string numero)
        {
            this.txtNumeroDestino.Text += numero;
        }

        private void btnPanelNumerio_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
                
            if (btn != null)
            {
                if (this.txtNumeroDestino.Text == "" && btn.Name == this.btnNumeral.Name)
                {
                    this.cmbFranja.Enabled = true;
                }
                CargarNrOrigen(btn.Text);
                
            }

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

            Random r =  new Random();

            try
            {
                if (this.txtNumeroDestino.Text[0] != '#')
                {

                    try
                    {
                        Local llamada = new Local(this.txtNroOrigen.Text, (float)(r.Next(1, 50)), this.txtNumeroDestino.Text, (float)(r.Next(0, 6)));
                        _ = centralita + llamada;
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show("La llamada ya fue registrada");
                    }

                }
                else
                {
                    Provincial llamada = new Provincial(this.txtNroOrigen.Text, (Provincial.Franja)Enum.Parse(typeof(Provincial.Franja), this.cmbFranja.Text), (float)(r.Next(1, 50)), this.txtNumeroDestino.Text);
                    _ = centralita + llamada;
                }

            }
            catch(FormatException ex)
            {
                MessageBox.Show("El formato ingresado no es un numero");
            }
            catch (IndexOutOfRangeException ex)
            {

                MessageBox.Show("No ingreso un numero valido para realizar la llamada");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Datos invalidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
            
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.Text = "";
            this.txtNroOrigen.Text = "";
            this.cmbFranja.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de salir?", "Salir?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
