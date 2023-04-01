using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaTP1;

namespace Trabajo_Práctico_N_1
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.cmbOperaciones.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            this.textN1.Text = "";
            this.textN2.Text = "";
            this.cmbOperaciones.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            Operando numeroOp1 = new Operando(numero1);
            Operando numeroOp2 = new Operando(numero2);
            return Calculadora.Operar(numeroOp1, numeroOp2, char.Parse(operador));
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperaciones.Text != "" && this.textN1.Text != "" && this.textN2.Text != "")
                this.labResultado.Text = Operar(this.textN1.Text, this.textN2.Text, this.cmbOperaciones.Text).ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnConvBin_Click(object sender, EventArgs e)
        {
            
            if (this.labResultado.Text != "0")
            {
                this.labResultado.Text = Operando.DecimalBinario(this.labResultado.Text);
            }
            

        }
    }
}
