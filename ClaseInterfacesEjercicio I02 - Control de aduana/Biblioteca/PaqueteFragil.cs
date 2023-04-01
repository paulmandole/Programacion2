using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PaqueteFragil : Paquete
    {
        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesokg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesokg)
        {
        }

        public override bool TienePrioridad
        {
            get { return true; }
        }

        
    }
}
