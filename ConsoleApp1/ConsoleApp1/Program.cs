using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Billetes_Scj2122
    {

        private int cantidadDiez;
        private int cantidadCincuenta;
        private int cantidadVeinte;


        public int CantidadCincuenta {  get => cantidadCincuenta; 
                                        set => cantidadCincuenta = value; }
        public int CantidadVeinte { get => cantidadVeinte; 
                                    set => cantidadVeinte = value; }
        public int CantidadDiez {   get => cantidadDiez; 
                                   set => cantidadDiez = value; }


        public Billetes_Scj2122()
        {
            CantidadCincuenta = 0;
            CantidadVeinte = 0;
            CantidadDiez = 0;
        }

        ///<summary>
        ///<para>Funcion que sirve para contar y recalcular la cantidad de billetes pasandole una cantidad total </para>
        ///<param name="cantidad"> La variable cantidad hace referencia a la cantidad total que posteriormente se desglosara en billetes</param>
        ///<returns>devuelve la cantidad de billetes de cada tipo que ha contabilizado dandole valor a los miembros de la clase</returns>
        ///<exception>Devuelve excepcion cuando introducimos un valor que al dividir por 10 su resto no sea 0</exception>
        ///</summary>
        ///<remarks>Se adjuntan pruebas unitarias</remarks>
        public void EstablecerCantidadTotal(int cantidad)
        {
            if ((cantidad % 10) != 0)
                throw new ArgumentOutOfRangeException();

            if ((cantidad >= 50))
            {
                CantidadCincuenta = cantidad / 50;
                cantidad = cantidad - (CantidadCincuenta * 50);
            }
            if ((cantidad >= 20))
            {
                CantidadVeinte = cantidad / 20;
                cantidad = cantidad - (CantidadVeinte * 20);
            }
            if ((cantidad >= 10))
            {
                CantidadDiez = cantidad / 10;
                cantidad = cantidad - (CantidadDiez * 10);
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
            Billetes_Scj2122 billetes = new Billetes_Scj2122();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
            {
                billetes.EstablecerCantidadTotal(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + billetes.CantidadCincuenta);
                Console.WriteLine("BILLETES DE 20 : " + billetes.CantidadVeinte);
                Console.WriteLine("BILLETES DE 10 : " + billetes.CantidadDiez);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
