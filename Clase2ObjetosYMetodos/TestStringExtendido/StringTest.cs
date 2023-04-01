using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClase11;
using System;

namespace TestStringExtendido
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void ContarPalabras_CuandoReciveDosPalabrasSeparadasPorEspacio_DeberiaRetornarDos()
        {
            //Arrange preparacion
            string texto = "Hola Mundo";
            int expexted = 2;//lo que espero
            int actual;//valor q devuelve el metodo
            //act invocacion de los metodos a probar
            actual = texto.ContarPalabras();

            // assert se evaluan los resultados

            Assert.AreEqual(expexted, actual);
        }
        //Dividir_cuandoDIvisorEsCero_DeberiaRetornarDoubleMInValue   nombre posible

        [TestMethod]
        public void ContarPalabras_CuandoReciveDosPalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            //Arrange preparacion
            string texto = "Hola-Mundo";
            int expexted = 2;//lo que espero
            int actual;//valor q devuelve el metodo
            //act invocacion de los metodos a probar
            actual = texto.ContarPalabras();

            // assert se evaluan los resultados

            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        //Assert para capturar exepciones de el typo q espero
        [ExpectedException(typeof(ArgumentNullException))]
        public void ContarPalabras_CuandoReciveUnStringEmpty_LanzaArgumentExeption()
        {
            //Arrange
            string t = string.Empty;

            //act
            int actual = t.ContarPalabras();

           

        }
    }
}
