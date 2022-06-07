using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace ConsoleApp1PruebaSJD2122
{
    [TestClass]
    public class PruebaSJD2122
    {
        [TestMethod]
        public void ProbarCantidadesSJD2122()
        {
            int cantidad = 280;
            int billetes50 = 5;
            int billetes20 = 1;
            int billetes10 = 1;

            BilletesSJD2021 billetesTotal = new BilletesSJD2021();

            billetesTotal.EstablecerCantidadBilletes(cantidad);

            Assert.AreEqual(billetes50, billetesTotal.CantidadBilletes50);
            Assert.AreEqual(billetes20, billetesTotal.CantidadBilletes20);
            Assert.AreEqual(billetes10, billetesTotal.CantidadBilletes10);

        }

        [TestMethod]
        public void ComprobarCantidadBilletesNoDivisiblePorDiez()
        {
            int cantidad = 56;

            BilletesSJD2021 billetesTotal = new BilletesSJD2021();

            try
            {
                billetesTotal.EstablecerCantidadBilletes(cantidad);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BilletesSJD2021.mensajeCantidadNoDivisibleDiez);
                return;
            }

            Assert.Fail("La prueba se ha superado sin disparar la excepcion");
        }
    }
}
