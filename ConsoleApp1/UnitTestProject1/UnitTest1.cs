using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int cantidad = 280;
            int billetes50 = 5;
            int billetes20 = 1;
            int billetes10 = 1;

            VTM22Billete billete = new VTM22Billete();
            billete.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50, billete.Cantidad50, "No coincide el número de billetes de 50");
            Assert.AreEqual(billetes20, billete.Cantidad20, "No coincide el número de billetes de 20");
            Assert.AreEqual(billetes10, billete.Cantidad10, "No coincide el número de billetes de 10");
        }

        [TestMethod]
        [ExpectedException(ArgumentOutOfRangeException, "Se esperaba ArgumentOutOfRange")]

        public void MetodoTest_CantidadMenorDe10()
        {
            int cantidad = 7;

            VTM22Billete billete = new VTM22Billete();
            billete.EstablecerCantidad(cantidad);
        }
    }
}
