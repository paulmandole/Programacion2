using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
    public enum EColores
    {
        rojo, blanco, azul, gris, negro
    }
    public class VehiculoTerrestre
    {
      
        public short cantidadRuedas;
        public short cantidadPuertas;
        public EColores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
