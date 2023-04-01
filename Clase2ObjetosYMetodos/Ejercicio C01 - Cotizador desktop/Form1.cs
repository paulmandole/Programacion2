using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_C01___Cotizador_desktop
{
    public partial class FormConversor : Form
    {
        private Euro montoEuro;
        private Pesos montoPesos;
        private Dolar montoDolar;
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            TextBox[] texBoxCotizacion = new TextBox[2];
            texBoxCotizacion[0] = this.textBCotzEuro;
            texBoxCotizacion[1] = this.textBCotzPeso;

            for (int i = 0; i < texBoxCotizacion.Length; i++)
            {
                if (texBoxCotizacion[i].Enabled)
                {
                    texBoxCotizacion [i].Enabled = false;
                    this.btnCandado.Image = Image.FromFile(@"F:\practica de clases hechas por mi\Imagenes\candadoCerrado.png");
                }
                else
                {
                    texBoxCotizacion[i].Enabled = true;
                    this.btnCandado.Image = Image.FromFile(@"F:\practica de clases hechas por mi\Imagenes\candadoAbierto.png");
                    
                }
            }
           

        }

        private void FormConversor_Load(object sender, EventArgs e)
        {
            this.textBCotzDolar.Text = 1.ToString();
            this.textBCotzEuro.Text = Math.Round(Euro.GetCotizacion(),2).ToString();
            this.textBCotzPeso.Text = Math.Round(Pesos.GetCotizacion(),4).ToString();

        }

        private void textBCotzEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBCotzEuro_Leave(object sender, EventArgs e)
        {
            Euro.SetCotizacion(double.Parse(this.textBCotzEuro.Text));
            Pesos.SetCotizacion(double.Parse(this.textBCotzPeso.Text));



        }

       

        private void btnConvertir1_Click(object sender, EventArgs e)
        {
            Pesos peso = (Pesos)montoEuro;
            Dolar dolar = (Dolar)montoEuro;

            this.textBEuroEuro.Text = this.montoEuro.GetCantidad().ToString();
            this.textBEuroPeso.Text = Math.Round(peso.GetCantidad(),2).ToString();
            this.textBEuroDolar.Text = Math.Round(dolar.GetCantidad(),2).ToString();
            
                
        }

        private void textBmontoEuro_Leave(object sender, EventArgs e)
        {
            if (this.textBmontoEuro.Text != "")
                this.montoEuro = double.Parse(this.textBmontoEuro.Text);
        }

        private void textBmontoDolar_Leave(object sender, EventArgs e)
        {

            if (this.textBmontoDolar.Text != "")
                this.montoDolar = double.Parse(this.textBmontoDolar.Text);
        }

        private void btnConvertir2_Click(object sender, EventArgs e)
        {
            Pesos peso = (Pesos)montoDolar;
            Euro euro = (Euro)montoDolar;

            this.textBDolarDolar.Text = this.montoDolar.GetCantidad().ToString();
            this.textBDolarEuro.Text = Math.Round(euro.GetCantidad(),2).ToString();
            this.textBDolarPeso.Text = Math.Round(peso.GetCantidad(), 2).ToString();
        }

        private void textBmontoPeso_Leave(object sender, EventArgs e)
        {
            if (this.textBmontoPeso.Text != "")
                this.montoPesos = double.Parse(this.textBmontoPeso.Text);
            
        }

        private void btnConvetir3_Click(object sender, EventArgs e)
        {
            Dolar dolar = (Dolar)montoPesos;
            Euro euro = (Euro)montoPesos;

            this.textBPesoDolar.Text = Math.Round(dolar.GetCantidad(), 2).ToString();
;           this.textBPesoEuro.Text = Math.Round(euro.GetCantidad(), 2).ToString();
            this.textBPesoPeso.Text = montoPesos.GetCantidad().ToString();
        }
    }
}
