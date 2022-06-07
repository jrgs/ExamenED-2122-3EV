using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void CalcularCantidadDeBilletes_CCC2122()
        {
            //Arrange
            int cantidad = 280;

            int billetes50 = 5;
            int billetes20 = 1;
            int billetes10 = 1;

            Billete billetes = new Billete();

            //Act
            billetes.establecerCantidadTotal(cantidad);

            //Assert
            Assert.AreEqual(billetes50, billetes20, billetes10, "No se ha calculado correctamente");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        private void CantidadNoDivisiblePorDiez_CCC2122()
        {
            //Arrange
            int cantidad = 25;
            Billete billetes = new Billete();


            //Act
            billetes.establecerCantidadTotal(cantidad);

            //Assert es manejado por la excepción

        }
    }
}
