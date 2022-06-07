using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    ///<summary>
    /// Clase Billete
    /// <remarks>Dada una cantidad, la desglosa en billetes de 50, 20, 10</remarks>
    /// </summary>
        public class Billete 

    {
        // numero de billetes de 50, 20, 10
        public int cantidadDe50;
        public int cantidadDe20;
        public int cantidadDe10;

        public int CantidadDe50 
        { 
            get {return cantidadDe50;} 
            set { cantidadDe50 = value;} 
        }

        public int CantidadDe20 
        { 
            get {return cantidadDe20;} 
            set { cantidadDe20 = value;} 
        }//CCC2122

        public int CantidadDe10 
        { 
            get {return cantidadDe10;} 
            set { cantidadDe10 = value;} 
        }

        // constructor vacio, inicializa los atributos
        public Billete()
        {
            cantidadDe50 = 0;
            cantidadDe20 = 0;
            cantidadDe10 = 0;
        }

        ///<summary>
        ///este método permite cambiar la cantidad total y recalcular
        ///<param name=cantidad>cantidad a calcular CCC2122</param>
        ///</summary>
        public void establecerCantidadTotal (int cantidad)
        {
            if ((cantidad % 10) != 0)//CCC2122
            { 
                throw new ArgumentOutOfRangeException();
            }

            if ((cantidad >= 50))//CCC2122
            {
                cantidadDe50 = (cantidad / 50);
                cantidad = cantidad - (cantidadDe50 * 50);
            }

            if ((cantidad >= 20))
            {
                cantidadDe20 = (cantidad / 20);
                cantidad = cantidad - (cantidadDe20 * 20);
            }

            if ((cantidad >= 10))
            {
                cantidadDe10 = (cantidad / 10);
                cantidad = cantidad - (cantidadDe10 * 10);
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
            Billete billetes = new Billete();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
            {
                billetes.establecerCantidadTotal(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + billetes.cantidadDe50);
                Console.WriteLine("BILLETES DE 20 : " + billetes.cantidadDe20);
                Console.WriteLine("BILLETES DE 10 : " + billetes.cantidadDe10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }
            
            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
