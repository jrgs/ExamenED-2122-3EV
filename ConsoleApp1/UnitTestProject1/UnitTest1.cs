using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    //YAPG2122
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int cantidad = 280;
            int billetes50 = 4;
            int billetes20 = 1;
            int billetes10 = 1;

            Billetes cllaseBilletes = new Billetes();

            cllaseBilletes.establecerCantidad(cantidad);
            Assert.AreEqual(4, billetes50, cantidad);
        }

        [TestMethod]
        public void comprobarSiReparteBienLosDe50()
        {
            int cantidad = 280;
            int billetes50 = 4;
       
            Billetes cllaseBilletes = new Billetes();

             cllaseBilletes.establecerCantidad(cantidad);

            Assert.AreEqual(4, billetes50, cantidad);
        }
        
        public void comprobarSiReparteBienLosDe20()
        {
            int cantidad = 280;
            int billetes20 = 1;
            
            Billetes cllaseBilletes = new Billetes();

            cllaseBilletes.establecerCantidad(cantidad);

            Assert.AreEqual(14, billetes20);


        }


    }
}
