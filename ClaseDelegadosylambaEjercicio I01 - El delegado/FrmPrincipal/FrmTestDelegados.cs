using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmTestDelegados : Form
    {
        // declaro una funcion delegata que va a recivir un string
        public delegate void ActualizarNombreDelegate(string nombre);

        // creo una valiable de la funcion a la q voy a asignar e; delegado q reciva por parametro
        private ActualizarNombreDelegate mDelegate;

        public FrmTestDelegados(ActualizarNombreDelegate mDelegate)
        {
            //asigno a la variable el puntero a funcion q me psaron
            this.mDelegate = mDelegate;
            InitializeComponent();
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            // invoco la funcion q me mandaron 
            mDelegate.Invoke(txtNombre.Text);
        }
    }
}
