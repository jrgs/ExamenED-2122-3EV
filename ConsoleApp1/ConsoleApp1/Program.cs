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
        public int C50, C20, C10;

        // constructor vacio, inicializa los atributos
        public bill()
        {
            C50 = 0;
            C20 = 0;
            C10 = 0;
        }

        // este método permite cambiar la cantidad total y recalcular
        public void establecercant(int c)
        {
            if ((c % 10) != 0)
                throw new ArgumentOutOfRangeException();

            if ((c >= 50))
            {
                C50 = (c / 50);
                c = c - (C50 * 50);
            }
            if ((c >= 20))
            {
                C20 = (c / 20);
                c = c - (C20 * 20);
            }
            if ((c >= 10))
            {
                C10 = (c / 10);
                c = c - (C10 * 10);
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
            int cant;
            bill b = new bill();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cant = int.Parse(linea);

            try
            {
                b.establecercant(cant);
                Console.WriteLine("BILLETES DE 50 : " + b.C50);
                Console.WriteLine("BILLETES DE 20 : " + b.C20);
                Console.WriteLine("BILLETES DE 10 : " + b.C10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
