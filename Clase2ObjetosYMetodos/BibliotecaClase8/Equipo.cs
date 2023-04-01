using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
           jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre): this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool ret = false;

            if (!e.jugadores.Contains(j))
            {
                e.jugadores.Add(j);
                ret = true;
            }

            return ret;
        }

        public string MostrarListaJugadores()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Jugador item in jugadores) 
            {
                stringBuilder.AppendLine(item.MostrarDatos());
            }
            return stringBuilder.ToString();
        }
    }
}
