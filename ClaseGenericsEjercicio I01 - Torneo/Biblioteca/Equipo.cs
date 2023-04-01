using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
        }

        public string Ficha()
        {
            return $"{this.Nombre} fundado el: {this.FechaCreacion.ToShortDateString()}";
        }
    }
}
