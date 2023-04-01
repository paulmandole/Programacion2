using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaCentralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancias(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancias(TipoLlamada.Provincial);
            }
        }
        public float GananciaPorTodas
        {
            get
            {
                return CalcularGanancias(TipoLlamada.Todas);
            }
        }

        public IList<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        private float CalcularGanancias(TipoLlamada tipo)
        {
            float ganancias = 0;
            if (tipo == TipoLlamada.Local)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Local)
                    {
                        ganancias += ((Local)item).CostoLlamada;
                    }
                }
            }
            if(tipo == TipoLlamada.Provincial)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Provincial)
                    {
                        ganancias += ((Provincial)item).CostoLlamada;
                    }
                }

            }
            if (tipo == TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Provincial)
                    {
                        ganancias += ((Provincial)item).CostoLlamada;
                    }

                    if (item is Provincial)
                    {
                        ganancias += ((Provincial)item).CostoLlamada;
                    }
                }
            }
            return ganancias;
        }

        private string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            
            foreach (Llamada item in listaDeLlamadas)
            {
                stringBuilder.AppendFormat($"{item.ToString()}");
            }
            stringBuilder.AppendFormat($"\nGanancia Total: {this.GananciaPorTodas}\nGanancia Local: {this.GananciaPorLocal}\nGanancia Provincial:{this.GananciaPorProvincial}");
            return stringBuilder.ToString();
        }

        public void OrdenarLlamadas()
        {

            listaDeLlamadas.Sort(listaDeLlamadas[0].OrdenarPorDuracion);

        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada is not null)
                listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool ret = false;
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if (item == llamada)
                {
                    ret = true;
                    break;
                }

            }
            return ret;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
            }
            else 
            {
                throw new CentralitaException("la llamada se encuentra registrada en el sistema", "operador +");
            }
            return c;

        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
