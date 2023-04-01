using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Local : Llamada
    {

        protected float costo;

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada,float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino, costo)
        {
            
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"{base.Mostrar()}\nCosto: {this.CostoLlamada}");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            Local auxLocal = obj as Local;

            if (auxLocal is not null)
            {
                ret = true;
            }
            return ret;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
