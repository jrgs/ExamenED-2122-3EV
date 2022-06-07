using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Clase bill
    // Dada una cantidadTotal, la desglosa en billetes de 50, 20, 10    MPRG2122
    //
    public class Billetes
    {
        // numero de billetes de 50, 20, 10     MPRG2122
        private int billetes10;
        private int billetes50;
        private int billetes20;

        // constructor vacio, inicializa los atributos
        public Billetes()
        {
            Billetes50 = 0;
            Billetes20 = 0;
            Billetes10 = 0;
        }

        public int Billetes50 
        { 
            get => billetes50; 
            set => billetes50 = value; 
        }
        public int Billetes20 
        {
            get => billetes20;
            set => billetes20 = value;
        }
        public int Billetes10 
        {
            get => billetes10;
            set => billetes10 = value; }

        /*  este método permite cambiar la cantidadTotal total y recalcular      MPRG2122   */
        /// <summary>
        /// El método <see cref="EstablecerCantidad"/> obtiene el número necesario de los siguientes:
        /// <para><list type="bullet"</para>
        /// <item>Billetes 50</item>
        /// <item>Billetes 20</item>
        /// <item>Billetes 10</item>
        /// </summary>
        /// <summary> <param name="nuevaCantidadTotal">Se obtendrá por consola del usuario</param>
        /// <para>con la función <paramref name="Main"principal </summary></para>
        public void EstablecerCantidad(int nuevaCantidadTotal)
        {
            ///<exception cref="ArgumentOutOfRangeException">Única excepción generada</exception>
            if ((nuevaCantidadTotal % 10) != 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            ///TODO realizar resto de excepciones 
            if ((nuevaCantidadTotal >= 50))
            {
                Billetes50 = (nuevaCantidadTotal / 50);
                nuevaCantidadTotal = nuevaCantidadTotal - (Billetes50 * 50);
            }

            if ((nuevaCantidadTotal >= 20))
            {
                Billetes20 = (nuevaCantidadTotal / 20);
                nuevaCantidadTotal = nuevaCantidadTotal - (Billetes20 * 20);
            }

            if ((nuevaCantidadTotal >= 10))
            {
                Billetes10 = (nuevaCantidadTotal / 10);
                nuevaCantidadTotal = nuevaCantidadTotal - (Billetes10 * 10);
            }
        }
    }

    class Program
    {
        // El siguiente programa calcula la cantidadTotal necesaria de billetes de
        // cada tipo para una cantidadTotal dada.
        // Sólo admite billetes de 50, 20 y 10. Si no es así, se produce una excepción
        static void Main(string[] args)
        {
            int cantidadTotal;

            Billetes objetoBilletes = new Billetes();

            string linea;

            Console.Write("Introduzca una cantidadTotal: ");  //MPRG2122
            linea = Console.ReadLine(); 
            cantidadTotal = int.Parse(linea);

            try
            {
                objetoBilletes.EstablecerCantidad(cantidadTotal);
                Console.WriteLine("BILLETES DE 50 : " + objetoBilletes.Billetes50);
                Console.WriteLine("BILLETES DE 20 : " + objetoBilletes.Billetes20);
                Console.WriteLine("BILLETES DE 10 : " + objetoBilletes.Billetes10);
            }
            catch
            {
                Console.WriteLine("cantidadTotal no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
// MPRG2122