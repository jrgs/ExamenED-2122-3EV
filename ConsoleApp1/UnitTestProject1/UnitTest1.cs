using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;


//PDMP2122
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValoresCorrectosResultadoEsperado()
        {
            int cantidad = 280;
            int billetes50 = 5;
            int billetes20 = 1;
            int billetes10 = 1;

            DesgloseBilletes desglose = new DesgloseBilletes();

            desglose.CambioCantidadYRecalculo(cantidad);

            int actualBilletes50 = desglose.NumeroBilletes50;
            int actualBilletes20 = desglose.NumeroBilletes20;
            int actualBilletes10 = desglose.NumeroBilletes10;
            
            Assert.AreEqual(billetes50, actualBilletes50);
            Assert.AreEqual(billetes20, actualBilletes20);
            Assert.AreEqual(billetes10, actualBilletes10);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ImporteIncorrectoSeEsperaExcepcion()
        {
            int cantidad = 8;
            
            DesgloseBilletes desglose = new DesgloseBilletes();

            desglose.CambioCantidadYRecalculo(cantidad);

        }


    }
}
