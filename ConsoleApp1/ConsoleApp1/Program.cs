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
    public class Billetes
    {
        // numero de billetes de 50, 20, 10 JSM2122
        /// <summary>
        /// Propiedades privadas de cada tipo de billete
        /// </summary>
        private int billetes50;
        private int billetes20;
        private int billetes10;

        /// <summary>
        /// getter y setter para acceder al valor de Billetes 50
        /// </summary>
        public int Billetes50 
        { 
            get => billetes50; 
            set => billetes50 = value; 
        }

        /// <summary>
        /// getter y setter para acceder al valor de Billetes 20
        /// </summary>
        public int Billetes20 
        { 
            get => billetes20; 
            set => billetes20 = value; 
        }
        /// <summary>
        /// getter y setter para acceder al valor de Billetes 10
        /// </summary>
        public int Billetes10 
        { 
            get => billetes10; 
            set => billetes10 = value; 
        }
        
        // constructor vacio, inicializa los atributos
        /// <summary>
        /// Inicializa la cantidad de billetes de donde empieza a contar los billetes
        /// </summary>
        public Billetes()
        {
            Billetes50 = 0;
            Billetes20 = 0;
            Billetes10 = 0;
        }
        

        // este método permite cambiar la cantidad total y recalcular
        /// <summary>
        /// Establece la cantidad de billetes necesarios para una cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public void EstablecerCantidad(int cantidad)
        {
            cantidad = CalcularCantidad(cantidad);

        }
        /// <summary>
        /// Metodo que calcula la cantidad de billetes de cada tipo que se necesitas para una cantidad
        /// </summary>
        /// <param name="cantidad">cantidad de billetes en numero entero</param>
        /// <returns>Devuelve la cantidad de billetes</returns>
        private int CalcularCantidad(int cantidad)
        {
            const int cincuenta = 50;
            const int veinte = 20;
            const int diez = 10;

            if ((cantidad % diez) != 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if ((cantidad >= cincuenta))
            {
                Billetes50 = (cantidad / cincuenta);
                cantidad = cantidad - (Billetes50 * cincuenta);
            }
            if ((cantidad >= veinte))
            {
                Billetes20 = (cantidad / veinte);
                cantidad = cantidad - (Billetes20 * veinte);
            }
            if ((cantidad >= diez))
            {
                Billetes10 = (cantidad / diez);
                cantidad = cantidad - (Billetes10 * diez);
            }

            return cantidad;
        }
    }

    class Program
    {
        // El siguiente programa calcula la cantidad necesaria de billetes de
        // cada tipo para una cantidad dada.
        // Sólo admite billetes de 50, 20 y 10. Si no es así, se produce una excepción
        /// <summary>
        /// Cantidad de billetes de cada tipo
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            int cantidad;
            string linea;

            Billetes billetes = new Billetes();

            Console.Write("Introduzca una cantidad: ");
            
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
            {
                billetes.EstablecerCantidad(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + billetes.Billetes50);
                Console.WriteLine("BILLETES DE 20 : " + billetes.Billetes20);
                Console.WriteLine("BILLETES DE 10 : " + billetes.Billetes10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); 
            Console.ReadLine();
        }
    }
}
