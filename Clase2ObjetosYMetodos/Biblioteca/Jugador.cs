using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum ENacionalidad
    {
        Argentina,Peru,Brazil
    }

    //va afuera no de pende de jugadores si lo pongo adentro depende de jugadores jugador.EColor.
    public enum EColor
    {
        rojo, azul, verde ,amarrillo
    }
    public class Jugador
    {
        //enumerado

        private string[] equipos;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private EColor colorCamiseta;



        //indexador devuelve el equipo que este en la pocicion del array que le paso
        // Se puede sobrcargar
        //hay q validar todo si o si
        //uint es una entero pero no puede ser negativo
        public string this[uint index]
        {
            get 
            {
                return equipos[index];
            }
            set 
            {
                equipos[index] = value;
            }
        }


        public EColor color
        {
            get { return this.colorCamiseta; }
            set { this.colorCamiseta = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int PartidosJugados
        {
            //se valida aka
            get { return this.partidosJugados; }
            set
            {
                if(this.ValidarPartidos(value))
                    this.partidosJugados = value;
            }
        }
        public Jugador(string nombre, int partidosJugados, int totalGoles)
        {
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
            this.equipos = new string[3];
            this.equipos[0] = "Boca";
            this.equipos[1] = "River";
            this.equipos[2] = "Racing";
        }

        private bool ValidarPartidos(int partidosJugados)
        {
            return partidosJugados >= 0;
        }

        //devuelvo algo q no esta guardado como atributo
        public float PromedioDeGoles
        {
            get 
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }
    }
}
