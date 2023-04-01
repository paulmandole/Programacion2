using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PaquetePesado : Paquete,IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesokg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesokg)
        {
        }

        Decimal IAfip.Impuestos
        {
            get { return costoEnvio * 0.25m; }
        }

        public override bool TienePrioridad
        {
            get { return false; }
        }

        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio + base.AplicarImpuestos() + Impuestos;
        }

        
    }
}
