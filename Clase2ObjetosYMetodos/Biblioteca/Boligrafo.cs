using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {
        private const short cantidadDeTinta = 100;
        private short tinta;
        private ConsoleColor color;


        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if ((cantidadDeTinta + tinta) >= 0 || (cantidadDeTinta + tinta) <= 0)
            {
                this.tinta = (short)(this.tinta - tinta);
            }
        }

        public void CargadorDeTinta()
        {
            SetTinta(cantidadDeTinta);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int cantidad;
            bool ret = false;
            Console.ForegroundColor = GetColor();
            if (GetTinta() >= 10)
            {   
                cantidad = GetTinta() / 10;
                for (int i = 0; i < cantidad; i++)
                {
                    
                    stringBuilder.Append("*");
                }
                dibujo = stringBuilder.ToString();
                ret = true;
                SetTinta((short)-(gasto));
            }
            else 
            {
                dibujo = "";
            }
            
            return ret;
        }
    }
}
