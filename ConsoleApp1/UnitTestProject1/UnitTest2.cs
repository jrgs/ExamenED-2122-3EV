using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void ProbarBilletes()
        {
            int cantidad = 280;
            int billetes50Esperados = 5;
            int billetes20Esperados = 1;
            int billetes10Esperados = 1;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50Esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20Esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10Esperados, b.Billete10FAM2122, 0.001);

        }

        [TestMethod]
        public void ProbarBilletesUnoDeCada()
        {
            int cantidad = 80;
            int billetes50Esperados = 1;
            int billetes20Esperados = 1;
            int billetes10Esperados = 1;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50Esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20Esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10Esperados, b.Billete10FAM2122, 0.001);

        }

        // autoria franco andres mattiazzo
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void BilletesMenorA10()
        {
            int cantidad = 5;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);
        }

        [TestMethod]
        public void ProbarBilletes50()
        {
            int cantidad = 50;
            int billetes50Esperados = 1;
            int billetes20Esperados = 0;
            int billetes10Esperados = 0;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50Esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20Esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10Esperados, b.Billete10FAM2122, 0.001);

        }

        [TestMethod]
        public void ProbarBilletes20()
        {
            int cantidad = 20;
            int billetes50Esperados = 0;
            int billetes20Esperados = 1;
            int billetes10Esperados = 0;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50Esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20Esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10Esperados, b.Billete10FAM2122, 0.001);

        }

        [TestMethod]
        public void ProbarBilletes10()
        {
            int cantidad = 10;
            int billetes50Esperados = 0;
            int billetes20Esperados = 0;
            int billetes10Esperados = 1;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50Esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20Esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10Esperados, b.Billete10FAM2122, 0.001);

        }
    }
}
