using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        public ConsoleColor Color 
        {   
            get{ return ConsoleColor.Gray; } 
            set => throw new NotImplementedException(); 
        }
        public float UnidadesDeEscritura 
        {
            get 
            {
                return this.tamanioMina;
            }
            set
            {
                tamanioMina = value;
            } 
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(this.Color,texto);
            this.tamanioMina -= 0.1f;
            return escritura;
            
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.GetType()} - {this.Color} - {this.UnidadesDeEscritura}";
        }

    }
}
