using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ejm9
{
    public partial class Form1 : Form
    {
        //para poder cancelar las tareas necesito eso
        CancellationTokenSource cts;
        //CancellationToken ct;

        public Form1()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
           // ct = cts.Token;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblInfo.Text = await GestorDatos.TraerRegistros2(cts.Token);
            }
            catch (TaskCanceledException ex)
            {

                lblInfo.Text = ex.Message;
            }
            catch (OperationCanceledException ex)
            {
                lblInfo.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }

        //aca asigno al boton para que cancelel cuando apreto el boton
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
