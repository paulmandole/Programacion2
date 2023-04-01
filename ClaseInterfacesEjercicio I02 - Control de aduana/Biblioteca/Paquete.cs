using System;

namespace Biblioteca
{
    public abstract class Paquete:IAduana
    {
        private string codigoSeguimiento;
        protected Decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesokg;

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get { return this.costoEnvio * 0.35m; }
        }

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesokg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesokg = pesokg;
        }

        public string ObtenerInformacionDePaquete()
        {
            return $"Codigo seguimiento:{this.codigoSeguimiento}\nCosto de envio:{this.costoEnvio}\nDestino:{this.destino}\nOrigen:{this.origen}\nPeso:{this.pesokg}\nTiene prioridad{this.TienePrioridad}";
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + Impuestos;
        }
    }
}
