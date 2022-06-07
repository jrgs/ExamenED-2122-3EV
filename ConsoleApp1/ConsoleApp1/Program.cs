using System;

namespace ConsoleApp1
{
    //YAG212
    // Clase bill
    // Dada una cantidad, la desglosa en billetes de 50, 20, 10
    //
    public class Billetes
    {
        //YAG212
        // numero de billetes de 50, 20, 10
        private int billetesDe50;
        private int billetesDe20;
        private int billetesDe10;


        public int BilletesDe50 
        { 
          get => billetesDe50;  
          set => billetesDe50 = value; 
        }
        public int BilletesDe20 
        { 
            get => billetesDe20; 
            set => billetesDe20 = value; 
        }
        public int BilletesDe10 
        { 
          get => billetesDe10; 
          set => billetesDe10 = value; 
        }
        /// <summary>
        /// Esto es 
        /// </summary>
        // constructor vacio, inicializa los atributos
        public Billetes()
        {
            BilletesDe50 = 0;
            BilletesDe20 = 0;
            BilletesDe10 = 0;
        }


        //YAG212
        // este método permite cambiar la cantidad total y recalcular
        /// <summary>
        /// Este metodo lo que hace es permitir cambiar la cantidad 
        /// <para>total del dinero y recalcular el dinero</para>
        /// </summary>
        /// <param name="cantidad"> Esto es la canidad que ingresas</param>
        public void establecerCantidad(int cantidad)
        {
          

            if ((cantidad % 10) != 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if ((cantidad >= 50))
            {
                BilletesDe50 = (cantidad / 50);
                cantidad = cantidad - (BilletesDe50 * 50);
            }
            if ((cantidad >= 20))
            {
                BilletesDe20 = (cantidad / 20);
                cantidad = cantidad - (BilletesDe20 * 20);
            }
            if ((cantidad >= 10))
            {
                BilletesDe10 = (cantidad / 10);
                cantidad = cantidad - (BilletesDe10 * 10);
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
            Billetes b = new Billetes();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cant = int.Parse(linea);
            //YAG2122
            try
            {
                b.establecerCantidad(cant);
                Console.WriteLine("BILLETES DE 50 : " + b.BilletesDe50);
                Console.WriteLine("BILLETES DE 20 : " + b.BilletesDe20);
                Console.WriteLine("BILLETES DE 10 : " + b.BilletesDe10);
            }
            catch
            {
                Console.WriteLine("Cantidad no válida.");
            }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
        }
    }
}
