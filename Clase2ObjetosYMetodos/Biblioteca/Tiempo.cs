using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tiempo
    {
        private int hora;
        private int minutos;
        private int segundos;

        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        public Tiempo(int hora, int minutos) : this(hora, minutos, 59)
        {

        }

        public Tiempo(int hora) : this(hora, 59)
        {

        }

        public string Mostrar()
        {
            return $"{this.hora} {this.minutos} {this.segundos}";
        }

        /// <summary>
        /// Sobrecarga de == para objetos tipo tiempo
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }

        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);//reutilizo el == que sobrecargue antes para hacer lo contrario
        }
        //Tiempo tiempo = "21:15:45"
        public static implicit operator Tiempo(string s)
        {
            //split separa un string a partir de un caracter que yo le pase y devuelve un array de strings
            string[] tiempoStr = s.Split(':');
            //devuelvo un objeto tiempo con el parce de lo que converti ejm 21 15 45
            return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        }

        //convierte un objeto tiempo a segundos castenadolo
        public static explicit operator int(Tiempo t)
        {
            return ((t.hora * 60) + t.minutos) *60 + t.segundos;
        }

        

    }
}
