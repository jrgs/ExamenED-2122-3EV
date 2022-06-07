using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //PDMP-2122
    /// <summary>
    /// Dada una cantidad, la desglosa en billetes de 50, 20, 10
    /// </summary>
    /// <remarks> La cantiad debe ser mayor o igual a 10</remarks>
    public class DesgloseBilletes
    {
        /// <summary>
        /// Miembro Numero de billetes de 50
        /// </summary>
        private int numeroBilletes50;
        /// <summary>
        /// Miembro Numero de billetes de 20
        /// </summary>
        private int numeroBilletes20;
        /// <summary>
        /// Miembro Numero de billetes de 10
        /// </summary>
        private int numeroBilletes10;
        /// <summary>
        /// Valor de la constante 50
        /// </summary>
        private const int valorBillete50 = 50;
        /// <summary>
        /// Valor de la constante 20
        /// </summary>
        private const int valorBillete20 = 20;
        /// <summary>
        /// Valor de la constante 10
        /// </summary>
        private const int valorBillete10 = 10;

        /// <summary>
        /// Propiedad numero de billetes de 50
        /// </summary>
        /// <value>Numero Billetes 50</value>
        public int NumeroBilletes50 
        { 
            get => numeroBilletes50; 
            set => numeroBilletes50 = value; 
        }
        /// <summary>
        /// Propiedad numero de billetes de 20
        /// </summary>
        /// <value>Numero Billetes 20</value>
        public int NumeroBilletes20 
        { 
            get => numeroBilletes20; 
            set => numeroBilletes20 = value; 
        }
        /// <summary>
        /// Propiedad numero de billetes de 10
        /// </summary>
        /// <value>Numero Billetes 10</value>
        public int NumeroBilletes10 
        { 
            get => numeroBilletes10; 
            set => numeroBilletes10 = value; 
        }

        /// <summary>
        /// Constructor inicializacion a 0
        /// </summary>
        public DesgloseBilletes()
        {
            NumeroBilletes50 = 0;
            NumeroBilletes20 = 0;
            NumeroBilletes10 = 0;
        }

       /// <summary>
       /// Calcula la cantidad de billetes de 50 20 y 10
       /// </summary>
       /// <param name="importe">Valor entero y debe ser mayor o igual a 10</param>
        public void CambioCantidadYRecalculo(int importe)
        {
            if ((importe % valorBillete10) != 0)
                ///<exception cref="System.ArgumentOutOfRangeException">Cuando el importe es menor a 10</exception>
                throw new ArgumentOutOfRangeException();

            if ((importe >= valorBillete50))
            {
                NumeroBilletes50 = (importe / valorBillete50);
                importe = importe - (NumeroBilletes50 * valorBillete50);
            }
            if ((importe >= valorBillete20))
            {
                NumeroBilletes20 = (importe / valorBillete20);
                importe = importe - (NumeroBilletes20 * valorBillete20);
            }
            if ((importe >= valorBillete10))
            {
                NumeroBilletes10 = (importe / valorBillete10);
                importe = importe - (NumeroBilletes10 * valorBillete10);
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
            DesgloseBilletes b = new DesgloseBilletes();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cant = int.Parse(linea);

            try
            {
                b.CambioCantidadYRecalculo(cant);
                Console.WriteLine("BILLETES DE 50 : " + b.NumeroBilletes50);
                Console.WriteLine("BILLETES DE 20 : " + b.NumeroBilletes20);
                Console.WriteLine("BILLETES DE 10 : " + b.NumeroBilletes10);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
