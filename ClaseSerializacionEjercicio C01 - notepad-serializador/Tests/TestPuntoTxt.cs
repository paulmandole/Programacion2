using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Tests
{
    [TestClass]
    public class TestPuntoTxt
    {
        [TestMethod]
        public void ValidarExtension_AlLlamarDebeDevolverUnStringConLaExtencionTxt()
        {
            PuntoTxt txt =new PuntoTxt();
            string path = @"\Archivo.txt";
            bool expected = true;
            bool actual;

            actual = txt.ValidarExtension(path);

            Assert.AreEqual(expected, actual);

        }

        

    }
}
