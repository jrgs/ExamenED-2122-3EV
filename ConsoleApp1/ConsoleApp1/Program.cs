using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BilletesSJD2021
    {
        private const int tipoBillete50 = 50;
        private const int tipoBillete20 = 20;
        private const int tipoBillete10 = 10;
        public const string mensajeCantidadNoDivisibleDiez = "La cantidad introducida no es divisible por diez";
        
        private int cantidadBilletes50;
        private int cantidadBilletes20;
        private int cantidadBilletes10;

        public int CantidadBilletes50 { get => cantidadBilletes50; set => cantidadBilletes50 = value; }
        public int CantidadBilletes20 { get => cantidadBilletes20; set => cantidadBilletes20 = value; }
        public int CantidadBilletes10 { get => cantidadBilletes10; set => cantidadBilletes10 = value; }

        public BilletesSJD2021()
        {
            CantidadBilletes50 = 0;
            CantidadBilletes20 = 0;
            CantidadBilletes10 = 0;
        }

        /// <summary>
        /// Método para calcular la cantidad de Billetes de 50, 20 y 10 tiene una cantidad pasada por parámetro.
        /// </summary>
        /// <param name="cantidad">La cantidad total de dinero que se pasa al método</param>
        /// <remarks>Se lanza una excepcion de ArgumentOutOfRange cuando la cantidad de dinero pasada NO es divisible por 10</remarks>
        /// <exception cref="ArgumentOutOfRangeException">La Excepción lanza un mensaje de Error<para>
        /// </para> que es la constante <see cref="mensajeCantidadNoDivisibleDiez"/>mensajeCantidadNoDivisible</exception>
        public void EstablecerCantidadBilletes(int cantidad)
        {
            if (cantidad % 10 != 0)
            {
                throw new ArgumentOutOfRangeException("cantidad", cantidad, mensajeCantidadNoDivisibleDiez);
            }

            /*if (cantidad == "")
            {
                throw new ArgumentNullException("cantidad");
            }*/
               
            if (cantidad >= tipoBillete50)
            {
                CantidadBilletes50 = (cantidad / tipoBillete50);
                cantidad = cantidad - (CantidadBilletes50 * tipoBillete50);
            }

            if (cantidad >= tipoBillete20)
            {
                CantidadBilletes20 = (cantidad / tipoBillete20);
                cantidad = cantidad - (CantidadBilletes20 * tipoBillete20);
            }

            if (cantidad >= tipoBillete10)
            {
                CantidadBilletes10 = (cantidad / tipoBillete10);
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            BilletesSJD2021 billetes = new BilletesSJD2021();

            Console.Write("Introduzca una cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            try
            {
                billetes.EstablecerCantidadBilletes(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + billetes.CantidadBilletes50);
                Console.WriteLine("BILLETES DE 20 : " + billetes.CantidadBilletes20);
                Console.WriteLine("BILLETES DE 10 : " + billetes.CantidadBilletes10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
