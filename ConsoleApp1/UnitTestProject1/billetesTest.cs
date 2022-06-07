using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMP2122NS;


namespace UnitTestProject1
{
    [TestClass]
    public class billetesTest
    {
        public const string CantidadNoValida = "La cantidad introducida no es válida";
        [TestMethod]
        public void PruebaCantidadValida()
        {
            billetes prueba = new billetes();
            int cantidad = 280;
            int billetes50 = 5;
            int billetes20 = 14;
            int billetes10 = 28;

            prueba.EstablecerCantidad(cantidad);

            Console.WriteLine("BILLETES DE 50 : " + billetes50);
            Console.WriteLine("BILLETES DE 20 : " + billetes20);
            Console.WriteLine("BILLETES DE 10 : " + billetes10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),CantidadNoValida)]
       public void PruebaValoresFueraRango()
        {    
            int cantidad = -5;
            billetes prueba = new billetes();
            prueba.EstablecerCantidad(cantidad);
        }

        [TestMethod]
        public void PruebaFueraRangoTryCatch()
        {
            int cantidad = -5;
            billetes prueba = new billetes();
            try
            {
                prueba.EstablecerCantidad(cantidad);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, CantidadNoValida);
            }
        }
    }
}
