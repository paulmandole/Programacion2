using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_CuandoReciveDosNumerosSeparadosPorComa_DevuelveLaSumaDeLosNumeros()
        {
            Calculadora c = new Calculadora();
            //Arrange
            string numeros = "//,\n2,10";
            int expected = 12;
            int actual;

            //act
            actual = c.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CuandoReciveUnaCantidadDesconocidadDeNumerosSeparadosPorComa_DevuelveLaSumaDeLosNumeros()
        {
            Calculadora c = new Calculadora();
            //Arrange
            string numeros = "//,\n2,10,100,352,10";
            int expected = 474;
            int actual;

            //act
            actual = c.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CuandoReciveUnaCantidadDesconocidadDeNumerosSeparadosPorComaOSaltoDeLinea_DevuelveLaSumaDeLosNumeros()
        {
            Calculadora c = new Calculadora();
            //Arrange
            string numeros = "//;\n2;10;100;352;10";
            int expected = 474;
            int actual;

            //act
            actual = c.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_CuandoReciveUnaCantidadDesconocidadDeNumerosSeparadosPorDiferentesLimitadores_DevuelveLaSumaDeLosNumeros()
        {
            Calculadora c = new Calculadora();
            //Arrange
            string numeros = "//-\n1-2-25-35-5";
            int expected = 68;
            int actual;

            //act
            actual = c.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
