using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {

            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
            }


        }
        public void RegistrarImpuestos(Paquete paquete)
        {

            this.impuestosAduana.Add(paquete);
            if (paquete is IAfip)
            {
                this.impuestosAfip.Add((IAfip)paquete);
            }



        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;
            foreach (IAduana item in impuestosAduana)
            {
                total += item.Impuestos; 
            }
            return total;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;
            foreach (IAduana item in impuestosAfip)
            {
                total += ((IAfip)item).Impuestos;
            }
            return total;
        }
    }
}
