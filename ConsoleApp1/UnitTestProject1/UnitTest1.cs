using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ConsoleApp1;
//using Billetes;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        //  public void TestPrimeraPruebaMPRG2122()
        public void TestMethod1()
        {
            int cantidad = 280;
            int billetes50 = 4;   // cambio 4
            int billetes20 = 1;
            int billetes10 = 1;

            Billetes objetoPrueba = new Billetes();

            objetoPrueba.EstablecerCantidad(cantidad);

            int actual50 = objetoPrueba.Billetes50;
            int actual20 = objetoPrueba.Billetes20;
            int actual10 = objetoPrueba.Billetes10;

            Assert.AreEqual(actual50, billetes50, 0, "Error Billetes 50");
            Assert.AreEqual(actual20, billetes20, 0, "Error Billetes 20");
            Assert.AreEqual(actual10, billetes10, 0, "Error Billetes 10");

        }
    }
}
