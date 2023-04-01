using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase9
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado1) : base(lado1, lado1)
        { 
        }

        public override string Dibujar()
        {
            return "Dibujando cuadrado...";
        }
    }
}
