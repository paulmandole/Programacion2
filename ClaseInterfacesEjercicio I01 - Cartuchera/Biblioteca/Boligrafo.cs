using System;

namespace Biblioteca
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo( float tinta, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }

        public ConsoleColor Color 
        {
            get
            {
                return colorTinta;
            }
            set
            {
                colorTinta = value;
            }
        }
        public float UnidadesDeEscritura 
        {
            get
            {
                return this.tinta;
            }
            set 
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(this.Color, texto);
            this.UnidadesDeEscritura -= 0.3f;
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            bool ret = false;
            if(unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                ret = true;
            }
            return ret;
        }

        public override string ToString()
        {
            return $"{this.GetType()} - {this.Color} - {this.UnidadesDeEscritura}";
        }
    }
}
