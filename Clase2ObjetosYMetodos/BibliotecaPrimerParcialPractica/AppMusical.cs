using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPrimerParcialPractica
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial): base(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = new List<string>();
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> strings) :this(nombre,sistemaOperativo,tamanioInicial)
        {
            if (strings is not null)
            {
                this.listaCanciones = strings;
            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }


        protected override int Tamanio
        {
            get 
            {
                this.tamanioMb += (listaCanciones.Count * 2);
                return  this.tamanioMb;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ObtenerInformacionApp());
            stringBuilder.AppendLine("Lista de canciones:\n");

            foreach (string item in listaCanciones)
            {
                stringBuilder.AppendFormat($"{item}");
            }

            return stringBuilder.ToString();
            
        }
    }
}
