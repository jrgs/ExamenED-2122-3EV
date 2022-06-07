using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMP2122NS
{
    /// <summary>
    ///  Dada una cantidad, la desglosa en billetes de 50, 20, 10
    /// </summary>
    // Clase billetes
    // Dada una cantidad, la desglosa en billetes de 50, 20, 10
    //
    public class billetes
    {
        // numero de billetes de 50, 20, 10
        public int billetes50, billetes20, billetes10;

        /// <summary>
        /// Se inicializan las variables a0
        /// </summary>
        // constructor vacio, inicializa los atributos
        public billetes()
        {
            billetes50 = 0;
            billetes20 = 0;
            billetes10 = 0;
        }

        public const string CantidadNoValida = "La cantidad introducida no es válida";

        /// <summary>
        /// este método permite cambiar la cantidad total y recalcular
        /// </summary>
        /// <param name="cantidad">cantidad de dinero que se calcula y permite saber cuántos billetes de cada tipo hay y recalcula  lo que sobra</param>
        /// <exception cref="ArgumentOutOfRangeException">lanza una excepcion si la cantidad  no es múltiplo de 10</exception>



        // este método permite cambiar la cantidad total y recalcular
        public void EstablecerCantidad(int cantidad)
        {
            if ((cantidad % 10) != 0)
                throw new ArgumentOutOfRangeException("cantidad", cantidad, CantidadNoValida);
      
       
            if ((cantidad >= 50))
            {
                billetes50 = (cantidad / 50);
                cantidad = cantidad - (billetes50 * 50);
            }
            if ((cantidad >= 20))
            {
                billetes20 = (cantidad / 20);
                cantidad = cantidad - (billetes20 * 20);
            }
            if ((cantidad >= 10))
            {
                billetes10 = (cantidad / 10);
                cantidad = cantidad - (billetes10 * 10);
            }

        }
    }

    class Program
    {
        // El siguiente programa calcula la cantidad necesaria de billetes de
        // cada tipo para una cantidad dada.
        // Sólo admite billetes de 50, 20 y 10. Si no es así, se produce una excepción
        static void Main(string[] args)
        {
            int cantidad;
            billetes b = new billetes();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
            {
                b.EstablecerCantidad(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + b.billetes50);
                Console.WriteLine("BILLETES DE 20 : " + b.billetes20);
                Console.WriteLine("BILLETES DE 10 : " + b.billetes10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
