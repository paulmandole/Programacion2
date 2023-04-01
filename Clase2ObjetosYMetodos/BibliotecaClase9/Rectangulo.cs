using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase9
{
    public class Rectangulo : Figura
    {
        private double longitud;
        private double longitudAltura;


        public Rectangulo(double longitud, double longitudAltura)
        {
            this.longitud = longitud;
            this.longitudAltura = longitudAltura;
        }

        public override double CalcularPerimetro()
        {
            return (this.longitud + this.longitudAltura)*2;
        }

        public override double CalcularSuperficie()
        {
            return this.longitud * this.longitudAltura; 
        }

        public override string Dibujar()
        {
            return "Dibujando rectángulo...";
        }
    }
}
