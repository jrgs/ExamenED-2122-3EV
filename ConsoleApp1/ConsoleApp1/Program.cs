using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Clase bill
    // Dada una cantidad, la desglosa en billetes de 50, 20, 10
    //
    /// <summary>
    /// <para>Clase Bill</para>
    /// <para>esta clase almacena las funciones y atributos necesarios para que al introducir un valor</para>
    /// <para>siempre y cuando sea divisible por 10 nos lo divide en billetes de 10, 20 y 40</para>
    /// </summary>
    public class Bill
    {
        // numero de billetes de 50, 20, 10

        /// <summary>
        /// Cantidad de billetes de 10 es privada
        /// </summary>
        private int billetes10FAM2122;

    
        /// <summary>
        /// Cantidad de billetes de 50 es privada
        /// </summary>
        private int billete50FAM2122;

        /// <summary>
        /// Cantidad de billetes de 20 es privada
        /// </summary>
        private int billetes20FAM2122;


        /// <summary>
        /// <para>Establece el valor de los billetes de 50</para>
        /// <para>mediante set y get</para>
        /// </summary>
        public int Billete50FAM2122
        { get => billete50FAM2122; set => billete50FAM2122 = value; }

        /// <summary>
        /// <para>Establece el valor de los billetes de 20</para>
        /// <para>mediante set y get</para>
        /// </summary>
        public int Billetes20FAM2122
        { get => billetes20FAM2122; set => billetes20FAM2122 = value; }

        /// <summary>
        ///<para>Establece el valor de los billetes de 20</para>
        /// <para>mediante set y get</para>
        /// </summary>
        public int Billete10FAM2122
        { get => billetes10FAM2122; set => billetes10FAM2122 = value; }

        //autoria Franco Andres Mattiazzo

        // constructor vacio, inicializa los atributos
        /// <summary>
        /// constructor vacio que inicializa los atributos
        /// </summary>
        public Bill()
        {
            Billete50FAM2122 = 0;
            Billetes20FAM2122 = 0;
            Billete10FAM2122 = 0;
        }


        /// <summary>
        /// Metodo que introduciendo una cantidad total divide en cantidad de billetes
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Excepcion que se genera cuando se introduce un valor menor de 10</exception>
        /// <param name="cantidad"> Cantidad es el importe total introducido por el usuario</param>
        /// <remarks>Importante introducir siempre importes divisibles por 10 como minimo</remarks>
        //autoria franco andres mattiazzo
        public void EstablecerCantidad(int cantidad)
        {
            if ((cantidad % 10) != 0)
                throw new ArgumentOutOfRangeException();

            if ((cantidad >= 50))
            {
                Billete50FAM2122 = (cantidad / 50);
                cantidad = cantidad - (Billete50FAM2122 * 50);
            }
            if ((cantidad >= 20))
            {
                Billetes20FAM2122 = (cantidad / 20);
                cantidad = cantidad - (Billetes20FAM2122 * 20);
            }
            if ((cantidad >= 10))
            {
                Billete10FAM2122 = (cantidad / 10);
                cantidad = cantidad - (Billete10FAM2122 * 10);
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
            Bill b = new Bill();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
            {
                b.EstablecerCantidad(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + b.Billete50FAM2122);
                Console.WriteLine("BILLETES DE 20 : " + b.Billetes20FAM2122);
                Console.WriteLine("BILLETES DE 10 : " + b.Billete10FAM2122);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
