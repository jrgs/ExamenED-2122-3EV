using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        /*public void TestMethod1()
        {
            int cantidad = 280;
            int billetes50 = 4;
            int billetes20 = 1;
            int billetes10 = 1;
        }*/

        [TestMethod]
        public void Probarbilletes()
        {
            int cantidad = 280;
            int billetes50esperados = 5;
            int billetes20esperados = 1;
            int billetes10esperados = 1;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10esperados, b.Billete10FAM2122, 0.001);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Billetesmenora10()
        {
            int cantidad = 5;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);
        }

        [TestMethod]
        public void Probarbilletes50()
        {
            int cantidad = 250;
            int billetes50esperados = 5;
            int billetes20esperados = 0;
            int billetes10esperados = 0;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10esperados, b.Billete10FAM2122, 0.001);

        }

        [TestMethod]
        public void Probarbilletes20()
        {
            int cantidad = 60;
            int billetes50esperados = 0;
            int billetes20esperados = 3;
            int billetes10esperados = 0;

            Bill b = new Bill();

            b.EstablecerCantidad(cantidad);

            Assert.AreEqual(billetes50esperados, b.Billete50FAM2122, 0.001);
            Assert.AreEqual(billetes20esperados, b.Billetes20FAM2122, 0.001);
            Assert.AreEqual(billetes10esperados, b.Billete10FAM2122, 0.001);

        }
    }
}
