using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public class Automovil : VehiculoTerrestre
    {

        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
