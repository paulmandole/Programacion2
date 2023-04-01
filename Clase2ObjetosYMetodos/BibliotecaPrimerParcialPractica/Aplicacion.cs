using System;
using System.Text;
using System.Collections.Generic;

namespace BibliotecaPrimerParcialPractica
{
    
    public  abstract class Aplicacion
    {

        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
            
           
        }



        protected abstract int  Tamanio { get; }

        public SistemaOperativo GetSistemaOperativo
        {
            get { return this.sistemaOperativo; }
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat($"NombreApp: {this.nombre}\nSistemaOperativo: {this.GetSistemaOperativo}\nTamanio en Mb: {this.tamanioMb}\n");

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{this.nombre}";
        }

        public static  implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int indexApp = 0;
            for (int i = 0; i < listaApp.Count -1; i++)
            {
                for (int j = i + 1; j < listaApp.Count; j++)
                {
                    if (listaApp[i].Tamanio > listaApp[j].Tamanio)
                    {
                        indexApp = i;
                    }
                }

            }
            return listaApp[indexApp];
        }

        public static bool operator ==(List<Aplicacion> listApp, Aplicacion app)
        {

            bool ret = false;
            if (listApp is not null && app is not null)
            {
                foreach (Aplicacion item in listApp)
                {
                    if (item.nombre == app.nombre)
                    {
                        ret = true;
                    }
                }

            }
            return ret;
        }
        public static bool operator !=(List<Aplicacion> listApp, Aplicacion app)
        {
            return !(listApp == app);
        }

        public static bool operator +(List<Aplicacion> listApp, Aplicacion app)
        {
            bool ret = false;

            if (listApp != app)
            {
                listApp.Add(app);
                ret = true;
            }

            return ret;
            
        }
    }
}
