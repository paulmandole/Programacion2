using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        /// <summary>
        /// Constructor Inicializa todos los Atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="fechaDeNacimiento"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;  
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento.ToShortDateString();
        }

        public int GetDni()
        {
            return this.dni;
        }

        private int ObtenerEdad()
        {
            DateTime fechaActual = DateTime.Today;

            return fechaActual.Year - fechaDeNacimiento.Year;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("NOMBRE: {0} FECHA DE NACIMIENTO: {1} DNI: {2} EDAD: {3}", GetNombre(),GetFechaDeNacimiento(),GetDni().ToString(),ObtenerEdad());
            return stringBuilder.ToString();
        }

        public string EsMayorDeEdad()
        {
            string respuesta = "Es menor de EDAD";
            if (ObtenerEdad() > 19)
            {
                respuesta =  "Es mayor de EDAD";
            }
            return respuesta;     
        }
    }
}
