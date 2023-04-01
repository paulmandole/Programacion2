using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random randon;
    
        static Estudiante()
        {   //instancio dentro del constructor statico
            randon = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private int PromediarNotas()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }
        public float ObtenerNotaFinal()
        {
            int ret = -1;

            if (this.notaPrimerParcial > 5 && this.notaSegundoParcial > 5)
                ret = randon.Next(6, 10);

            return ret;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat("Nombre:{0}\tApellido:{1}\tLegajo:{2}\nNota Primer Parcial:{3}\nNota Segundo Parcial:{4}\nPromedio:{5}\n", nombre, apellido, legajo.ToString(), notaPrimerParcial.ToString(), notaSegundoParcial.ToString(),PromediarNotas().ToString());
            if (ObtenerNotaFinal() != -1)
            {
                stringBuilder.AppendFormat("Nota Final:{0}\n\n", ObtenerNotaFinal().ToString());
            }
            else 
            {
                stringBuilder.Append("Alumno desaprobado\n\n");
            }

            return stringBuilder.ToString();
        }
    }
}
