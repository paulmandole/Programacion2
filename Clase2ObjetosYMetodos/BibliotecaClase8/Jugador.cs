using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public class Jugador : Persona
    {

        private int partidosJugados;
        private int golesTotales;

        public int GolesTotales
        {
            get { return golesTotales; }
            set { golesTotales = value; }
        }

        public int PartidoJugados
        {
            get { return partidosJugados; }
            set { partidosJugados = value; }
        }

        public float PromedioGoles
        {
            get { return this.golesTotales / this.partidosJugados; }
        }

        public Jugador(string nombre, long dni): base(dni,nombre)
        { 
        }
        public Jugador(string nombre,long dni, int totalGoles, int totalPartidos) : this(nombre,dni)
        {
            this.partidosJugados = totalPartidos;
            this.golesTotales = totalGoles;
            
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()}Partidos Jugados:{this.PartidoJugados} Total Goles:{this.GolesTotales} Promedio De Goles:{this.PromedioGoles}";
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
