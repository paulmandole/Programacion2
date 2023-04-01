using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClase11;

namespace TestIntExtendido
{
    [TestClass]
    public class FizzbuzzTest
    {
        [TestMethod]
        public void FizzBuzz_CuandoReciveUnIntDivisiblePorTres_DeberiaRetornarFizz()
        {
            //arrange
            int numero = 3;
            string expected = "Fizz";
            string actual;

            //act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoReciveUnIntDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            //arrange
            int numero = 5;
            string expected = "Buzz";
            string actual;

            //act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoReciveUnIntDivisiblePorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //arrange
            int numero = 105;
            string expected = "FizzBuzz";
            string actual;

            //act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoReciveUnIntNoDivisiblePorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //arrange
            int numero = 2;
            string expected = "2";
            string actual;

            //act
            actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
