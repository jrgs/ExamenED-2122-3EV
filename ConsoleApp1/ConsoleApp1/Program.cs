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
    public class VTM22Billete
    {
        // numero de billetes de 50, 20, 10
        private int cantidad50, cantidad20, cantidad10;


        //Getter y setter

        public int Cantidad50
        {
            get => Cantidad50 = this.cantidad50;
            set { this.cantidad50 = value; }
        }

        public int Cantidad20
        {
            get => Cantidad20 = this.cantidad20;
            set { this.cantidad20 = value; }
        }

        public int Cantidad10
        {
            get => Cantidad10 = this.cantidad10;
            set { this.cantidad10 = value; }
        }

        // constructor vacio, inicializa los atributos
        public VTM22Billete()
        {
            cantidad50 = 0;
            cantidad20 = 0;
            cantidad10 = 0;
        }

        // este método permite cambiar la cantidad total y recalcular
        /// <summary>
        /// <para>Este método asigna el mínimo número de billetes combinados entre
        /// billetes de 10, 20 y 50 que sumen la cantidad inferior más cercana a <paramref name="cantidadTotal"/></para>
        /// <para>Divide entre cada tipo de billete, de mayor a menor, dividiendo cada vez el resto entre el valor de billete inmediatamente inferior</para>
        /// </summary>
        /// <param name="cantidadTotal">cantidadTotal es un número entero que representa la cantidad a dividir en billetes</param>
        /// <remarks>Si <paramref name="cantidadTotal"/> introducida es inferior a 10 saltará la excepción <exception>ArgumentOutOfRange</exception></remarks>
        /// 
        public void EstablecerCantidad(int cantidadTotal)
        {
            const int DIVISIBLE50 = 50, DIVISIBLE20 = 20, DIVISIBLE10 = 10;

            if ((cantidadTotal % DIVISIBLE10) != 0)
                throw new ArgumentOutOfRangeException();

            if ((cantidadTotal >= DIVISIBLE50))
            {
                cantidad50 = (cantidadTotal / DIVISIBLE50);
                cantidadTotal = cantidadTotal - (cantidad50 * DIVISIBLE50);
            }
            if ((cantidadTotal >= DIVISIBLE20))
            {
                /*cantidad20 = EsDivisible(cantidadToral, DIVISIBLE20)*/
                /*(cantidadTotal / DIVISIBLE20);*/
                cantidadTotal = cantidadTotal - (cantidad20 * DIVISIBLE20);
            }
            if ((cantidadTotal >= DIVISIBLE10))
            {
                cantidadTotal = NewMethod(cantidadTotal, DIVISIBLE10);
            }
        }

        private int NewMethod(int cantidadTotal, int DIVISIBLE10)
        {
            cantidad10 = (cantidadTotal / DIVISIBLE10);
            cantidadTotal = cantidadTotal - (cantidad10 * DIVISIBLE10);
            return cantidadTotal;
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
            VTM22Billete billete = new VTM22Billete();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
            {
                billete.EstablecerCantidad(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + billete.Cantidad50);
                Console.WriteLine("BILLETES DE 20 : " + billete.Cantidad20);
                Console.WriteLine("BILLETES DE 10 : " + billete.Cantidad10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
