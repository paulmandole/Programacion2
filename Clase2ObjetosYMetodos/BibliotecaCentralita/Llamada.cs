using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public enum TipoLlamada
    {
        Local, Provincial, Todas
    };
    public abstract class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;


        public abstract float CostoLlamada{get;}
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            try
            {   int num = int.Parse(nroOrigen);

                if (!string.IsNullOrEmpty(nroOrigen) && !string.IsNullOrEmpty(nroDestino))
                {
                    this.duracion = duracion;
                    this.nroDestino = nroDestino;
                    this.nroOrigen = nroOrigen;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Datos Invalidos",ex);
            }
           
           

            
        }

        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"\nDuracion: {this.Duracion}\nNumero de Destino:{this.NroDestino}\nNumero de origen: {this.NroOrigen}");
            return stringBuilder.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int result = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                result = 1;
            }
            else
            {
                result = -1;
            }
            return result; 
        }

        
        public static bool operator ==(Llamada l1,Llamada l2)
        {

            return l1.Equals(l2) && l1.nroOrigen == l2.nroOrigen && l1.nroDestino == l2.nroDestino;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }




    }
}
