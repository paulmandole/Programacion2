using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public class Publicacion
    {
        private string titulo;
        private DateTime fechaPublicacion;

        //propfull crea la propiedad de una solo remplazando
        public string Titulo { get => titulo; set => titulo = value; }
        //protected solo se pude accedes desde los hijos no desde otro lado 
        //si uso internal antes solo pude dentro de los hijos en el mismo proyecto
        protected DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }

        public Publicacion(string titulo, DateTime fechaPublicacion)
        {
            this.titulo = titulo;
            this.fechaPublicacion = fechaPublicacion;
        }


        public string MostrarDatos()
        {
            //getType() devuelve el tipo de la instancia es decier el nameSpace y el nombre de la clase . name muestra solo el nombre de la clase
            return $"{this.GetType().Name} Titulo: {this.titulo} - Publicacion: {this.fechaPublicacion.Date}";
        }
    }
}
