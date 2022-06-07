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
            int billetes50 = 4;
            int billetes20 = 4;
            int billetes10 = 0;

            int billetesCount = 8;

            Billetes billetes = new Billetes();

            int billetesExpected = 8;
            int billetesExpected50 = 4;
            int billetesExpected20 = 4;
            int billetesExpected10 = 0;

            Assert.AreEqual(billetesExpected, billetesCount, 0.001, "La cantidad esta mal");
            Assert.AreEqual(billetesExpected50, billetes50, 0.001, "La cantidad de 50 esta mal");
            Assert.AreEqual(billetesExpected20, billetes20, 0.001, "La cantidad de 20 esta mal");
            Assert.AreEqual(billetesExpected10, billetes10, 0.001, "La cantidad de 10 esta mal");



        }
        [TestMethod]
        public void TestMethod2()
        {

            int cantidad = 9;

            Billetes billetes = new Billetes();

            try
            {
                
                int cantidadExpected = 10;
                cantidad = cantidadExpected;
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.cantidad, "la cantidad esta mal");
            }

            


        }
    }
}
