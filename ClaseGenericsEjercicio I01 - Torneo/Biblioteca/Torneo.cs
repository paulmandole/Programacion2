using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Torneo <T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre):this()
        { 
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get 
            {
                Random r = new Random();
                if(this.equipos is not null)
                {
                    int length = this.equipos.Count;
                    return CalcularPartido(equipos[r.Next(0, length)], equipos[r.Next(0, length)]);
                }
                return "Error"; 
            }
        }
        private string CalcularPartido(T t1,T t2)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random r = new Random(); 
            if (t1 is not null && t2 is not null)
            {
                stringBuilder.AppendFormat($"{t1.Nombre} {r.Next(1, 10)} - {t2.Nombre} {r.Next(1, 10)}");
            }
            return stringBuilder.ToString();
        }

        public static bool operator ==(Torneo<T> T,Equipo equipo)
        {
            bool ret = false;
            foreach (Equipo item in T.equipos)
            {
                if(item.Nombre == equipo.Nombre && item.FechaCreacion == item.FechaCreacion)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        public static bool operator !=(Torneo<T> T, Equipo equipo)
        {
            return !(T == equipo);
        }

        public static List<T> operator +(Torneo<T> T, Equipo equipo)
        {
            if (T is not null && equipo is not null)
            {
                if (T != equipo)
                {
                    T.equipos.Add((T)equipo);
                }
            }
            return T.equipos;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Nombre del torneo: {this.nombre}\n\nLista de equipos:\n\n");
            foreach (Equipo item in this.equipos)
            {
                stringBuilder.AppendFormat($"{item.Ficha()}\n");
            }
            return stringBuilder.ToString();
        }
    }
}
