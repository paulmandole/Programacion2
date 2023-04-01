using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaseInterfacesEjercicio_I02___Control_de_aduana
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paqueton = new PaquetePesado("235153", 250m,"brasil","suiza",5000);
            bool expectec = false;
            bool actual;

            actual = paqueton.TienePrioridad;

            Assert.AreEqual(expectec, actual);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado paqueton = new PaquetePesado("235153", 100m, "brasil", "suiza", 5000);
            decimal expectec = 160;
            decimal actual;

            actual = paqueton.AplicarImpuestos();

            Assert.AreEqual(expectec, actual);
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            PaquetePesado paqueton = new PaquetePesado("235153", 100m, "brasil", "suiza", 5000);
            decimal expectec = 25;
            decimal actual;

            actual = ((IAfip)paqueton).AplicarImpuestos();

            Assert.AreEqual(expectec, actual);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            PaquetePesado paqueton = new PaquetePesado("235153", 100m, "brasil", "suiza", 5000);
            decimal expectec = 160;
            decimal actual;

            actual = paqueton.AplicarImpuestos();

            Assert.AreEqual(expectec, actual);
        }
    }
}
