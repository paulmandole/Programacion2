using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
   
    public class Provincial : Llamada
    {

        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        };
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get { return CalcularCosto();}
        }

        public Provincial(Franja miFranja,Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float resultado = 0;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                resultado = this.duracion * 0.99f;
            }
            if(this.franjaHoraria == Franja.Franja_2)
            {
                resultado = this.duracion * 1.25f;
            }
            if (this.franjaHoraria == Franja.Franja_3)
            {
                resultado = this.duracion * 0.66f;
            }
            return resultado;
        }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"{base.Mostrar()}\nCosto: {this.CostoLlamada}\nFranja Horaria: {this.franjaHoraria}");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            Provincial auxProvincial = obj as Provincial;
            if (auxProvincial is not null)
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
