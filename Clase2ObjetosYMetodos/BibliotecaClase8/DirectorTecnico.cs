using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {
            
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} Fecha De Nacimiento: {this.fechaNacimiento}";
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento;   
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
