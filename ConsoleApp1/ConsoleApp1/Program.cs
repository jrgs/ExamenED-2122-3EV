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
    public class bill
    {
        // numero de billetes de 50, 20, 10
        private int billeteDe50;
        private int billeteDe20;
        private int billeteDe10;

        public int BilleteDe50 { get => billeteDe50; set => billeteDe50 = value; }
        public int BilleteDe20 { get => billeteDe20; set => billeteDe20 = value; }
        public int BilleteDe10 { get => billeteDe10; set => billeteDe10 =  value ; }


        // constructor vacio, inicializa los atributos
        public bill ()
        {
            BilleteDe50 = 0;
            BilleteDe20 = 0;
            BilleteDe10 = 0;
        }

        const int divisorUno = 10;
        const int divisorDos = 50;
        const int divisorTres = 20;
        
       

        //<summary>
          /// Este método permite cambiar la cantidad total y recalcular
          ///<param name="cantidad">campo que introducirá el usuario por teclado y que será comprobado por el método</param>
          ///<exception cref="ArgumentOutOfRangeException">Puede dar un error de fuera de rango si cantidad no es divisible entre 10</exception>
        //</summary>
        
        public void EstablecerCantidad ( int cantidad )
        {
            if ( ( cantidad % divisorUno ) != 0 )
                throw new ArgumentOutOfRangeException();

            if ( ( cantidad >= divisorDos ) )
            {
                BilleteDe50 = ( cantidad / 50 );
                cantidad = cantidad - ( BilleteDe50 * 50 );
            }
            if ( ( cantidad >= divisorTres ) )
            {
                BilleteDe20 = ( cantidad / divisorTres );
                cantidad = cantidad - ( BilleteDe20 * 20 );
            }
            if ( ( cantidad >= divisorUno ) )
            {
                BilleteDe10 = ( cantidad / divisorUno );
                cantidad = cantidad - ( BilleteDe10 * divisorUno );
            }

        }
    }

    class Program
    {
        
        static void Main ( string[] args )
        {
            int cantidadBilletes;
            bill cartera = new bill();

            cantidadBilletes = CalcularBilletes(cartera);
        }

        // El siguiente programa calcula la cantidad necesaria de billetes de
        // cada tipo para una cantidad dada.
        // Sólo admite billetes de 50, 20 y 10. Si no es así, se produce una excepción
        private static int CalcularBilletes ( bill cartera )
        {
            int cantidadBilletes;
            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidadBilletes = int.Parse(linea);

            try
            {
                cartera.EstablecerCantidad(cantidadBilletes);
                Console.WriteLine("BILLETES DE 50 : " + cartera.BilleteDe50);
                Console.WriteLine("BILLETES DE 20 : " + cartera.BilleteDe20);
                Console.WriteLine("BILLETES DE 10 : " + cartera.BilleteDe10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla.");
            Console.ReadLine();
            return cantidadBilletes;
        }
    }
}
