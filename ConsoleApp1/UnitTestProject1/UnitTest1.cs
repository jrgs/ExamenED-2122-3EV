using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConteoCorrecto_Test()
        {
            int cantidad = 280;
            int billetesCincuenta = 5;
            int billetesVeinte = 1;
            int billetesDiez = 1;

            Billetes_Scj2122 billetes = new Billetes_Scj2122();

            billetes.EstablecerCantidadTotal(cantidad);

            Assert.AreEqual(billetesCincuenta, billetes.CantidadCincuenta, 0.001, "La cantidad de billetes 50 no es correcta");
            Assert.AreEqual(billetesVeinte, billetes.CantidadVeinte, 0.001, "La cantidad de billetes 20 no es correcta");
            Assert.AreEqual(billetesDiez, billetes.CantidadDiez, 0.001, "La cantidad de billetes 10 no es correcta");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CantidadIntroducidaIncorrecta_Test()
        {
            int cantidad = 253;

            Billetes_Scj2122 billetes = new Billetes_Scj2122();

            billetes.EstablecerCantidadTotal(cantidad);

        }

    }
}
