using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EstablecerCantidad_ValidCase()
        {
            int cantidad = 280;
            int billetes50 = 4;
            int billetes20 = 1;
            int billetes10 = 1;

            try
            {
                bill cartera = new bill();
                cartera.BilleteDe50 = billetes50;
                cartera.BilleteDe20 = billetes20;
                cartera.BilleteDe10 = billetes10;

                cartera.EstablecerCantidad(cantidad);
            }
            catch ( Exception e )
            {

                throw e;
            }

           // Assert.Fail("Ha fallado el programa");
        
           
        }

        [TestMethod]
        public void EstablecerCantidad_OutOfRange ()
        {
            int cantidad = 281;
            int billetes50 = 4;
            int billetes20 = 1;
            int billetes10 = 1;

            try
            {
                bill cartera = new bill();
                cartera.BilleteDe50 = billetes50;
                cartera.BilleteDe20 = billetes20;
                cartera.BilleteDe10 = billetes10;

                cartera.EstablecerCantidad(cantidad);
            }
            catch ( Exception e )
            {

                throw e;
            }
            

        }


        [TestMethod]
        public void EstablecerCantidad_ArgumentNegative ()
        {
            int cantidad = -280;
            int billetes50 = 4;
            int billetes20 = 1;
            int billetes10 = 1;

            try
            {
                bill cartera = new bill();
                cartera.BilleteDe50 = billetes50;
                cartera.BilleteDe20 = billetes20;
                cartera.BilleteDe10 = billetes10;

                cartera.EstablecerCantidad(cantidad);
            }
            catch ( Exception e )
            {

                throw e;
            }

        }



    }
}
