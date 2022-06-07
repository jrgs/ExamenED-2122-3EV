namespace ConsoleApp1
{
    using System;

    // Clase bill
    // Dada una cantidad, la desglosa en billetes de 50, 20, 10
    // Agustin Perez 2122
    /// <summary>
    /// Defines the <see cref="Bill" />.
    /// </summary>
    public class Bill
    {
        // numero de billetes de 50, 20, 10
        /// <summary>
        /// Defines the b50, b20, b10.
        /// </summary>
        private int b50, b20, b10;

        /// <summary>
        /// Gets the mBillete50.
        /// </summary>
        public int mBillete50
        {
            get { return b50; }
        }

        /// <summary>
        /// Gets the mBillete20.
        /// </summary>
        public int mBillete20
        {
            get { return b20; }
        }

        /// <summary>
        /// Gets the mBillete10.
        /// </summary>
        public int mBillete10
        {
            get { return b10; }
        }

        // constructor vacio, inicializa los atributos
        /// <summary>
        /// Initializes a new instance of the <see cref="Bill"/> class.
        /// </summary>
        public Bill()
        {
            b50 = 0;
            b20 = 0;
            b10 = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bill"/> class.
        /// </summary>
        /// <param name="cant">The cant<see cref="int"/>.</param>
        public Bill(int cant)
        {
            establecerCantidad(cant);
        }

        // este método permite cambiar la cantidad total y recalcular
        /// <summary>
        /// Funcion para separar una cantidad en billetes de 50, 20 y 10.
        /// <remark>Minimo 10</remark>
        /// </summary>
        /// <param name="cantidadTotal">The cantidadTotal<see cref="int"/>.</param>
        private void establecerCantidad(int cantidadTotal)
        {
            if ((cantidadTotal % 10) != 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if ((cantidadTotal >= 50))
            {
                b50 = (cantidadTotal / 50);
                cantidadTotal = cantidadTotal - (b50 * 50);
            }
            if ((cantidadTotal >= 20))
            {
                b20 = (cantidadTotal / 20);
                cantidadTotal = cantidadTotal - (b20 * 20);
            }
            if ((cantidadTotal >= 10))
            {
                b10 = (cantidadTotal / 10);
                cantidadTotal = cantidadTotal - (b10 * 10);
            }
        }
    }

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        // El siguiente programa calcula la cantidad necesaria de billetes de
        // cada tipo para una cantidad dada.
        // Sólo admite billetes de 50, 20 y 10. Si no es así, se produce una excepción
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            int cant;
            string linea;

            Console.Write("Introduzca una cantidad: ");
            
            linea = Console.ReadLine();
            cant = int.Parse(linea);
            Bill bill = new Bill(cant);

            try
            {
                Console.WriteLine("BILLETES DE 50 : " + bill.mBillete50);
                Console.WriteLine("BILLETES DE 20 : " + bill.mBillete20);
                Console.WriteLine("BILLETES DE 10 : " + bill.mBillete10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
