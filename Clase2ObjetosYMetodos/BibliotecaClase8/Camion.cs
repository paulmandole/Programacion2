﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase8
{
   
    public class Camion : VehiculoTerrestre
    {

        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, int pesoCarga) :base(cantidadRuedas,cantidadPuertas,color)
        {

            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
