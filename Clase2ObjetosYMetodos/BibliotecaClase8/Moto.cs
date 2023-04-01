using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public class Moto : VehiculoTerrestre
    {

        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color, short cilindrada): base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
