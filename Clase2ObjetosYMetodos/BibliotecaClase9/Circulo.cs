using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase9
{
    
    public sealed class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override double CalcularPerimetro()
        {
            return (this.radio * 2) * Math.PI;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(this.radio, 2);
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo...";
        }
    }
}
