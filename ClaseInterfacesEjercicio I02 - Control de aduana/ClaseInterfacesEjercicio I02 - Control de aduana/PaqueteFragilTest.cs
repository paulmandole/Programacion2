using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;


namespace ClaseInterfacesEjercicio_I02___Control_de_aduana
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil paquetito = new PaqueteFragil("12222123", 125m,"chaco","buenos Aires",100);
            bool expect = true;
            bool actual;

            actual = paquetito.TienePrioridad;

            Assert.AreEqual(expect, actual);
            
        }
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            PaqueteFragil paquetito = new PaqueteFragil("12222123", 100m, "chaco", "buenos Aires", 100);
            decimal expected = 35;
            decimal actual;

            actual = paquetito.Impuestos;

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            PaqueteFragil paquetito = new PaqueteFragil("12222123", 100m, "chaco", "buenos Aires", 100);
            decimal expected = 135;
            decimal actual;

            actual = paquetito.AplicarImpuestos();

            Assert.AreEqual(expected, actual);

        }


    }
}
