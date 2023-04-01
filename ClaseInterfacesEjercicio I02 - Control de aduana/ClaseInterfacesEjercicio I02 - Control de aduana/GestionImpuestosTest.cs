using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace ClaseInterfacesEjercicio_I02___Control_de_aduana
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            List<Paquete> paquetes = new List<Paquete>();
            PaquetePesado paqueton = new PaquetePesado("235153", 100m, "brasil", "suiza", 5000);
            PaqueteFragil paquetito = new PaqueteFragil("12222123", 100m, "chaco", "buenos Aires", 100);
            PaqueteFragil paquetin = new PaqueteFragil("325451465", 500m, "brazil", "austria", 356);
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            paquetes.Add(paqueton);
            paquetes.Add(paquetito);
            paquetes.Add(paquetin);
            decimal expected = 245m;
            decimal actual;

            gestionImpuestos.RegistrarImpuestos(paquetes);


            actual = gestionImpuestos.CalcularTotalImpuestosAduana();

            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            List<Paquete> paquetes = new List<Paquete>();
            PaquetePesado paqueton = new PaquetePesado("235153", 100m, "brasil", "suiza", 5000);
            PaqueteFragil paquetito = new PaqueteFragil("12222123", 100m, "chaco", "buenos Aires", 100);
            PaqueteFragil paquetin = new PaqueteFragil("325451465", 500m, "brazil", "austria", 356);
            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            paquetes.Add(paqueton);
            paquetes.Add(paquetito);
            paquetes.Add(paquetin);
            decimal expected = 25;
            decimal actual;

            gestionImpuestos.RegistrarImpuestos(paquetes);


            actual = gestionImpuestos.CalcularTotalImpuestosAfip();

            Assert.AreEqual(expected, actual);



        }
    }
}
