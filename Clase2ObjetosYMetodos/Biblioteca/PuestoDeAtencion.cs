using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoDeAtencion
    {
        public enum EPuesto
        {
            caja1, caja2
        }

        private EPuesto puesto;
        private static int numeroActual;



        public static int NumeroActual
        {
            get { return numeroActual++; }
        }
        static PuestoDeAtencion()
        {
            numeroActual = 0;
        }

        public PuestoDeAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            bool ret = false;
            if(cli is not null)
            {
                Thread.Sleep(2000);
                ret = true;
            }

            return ret;
        }

    }
}
