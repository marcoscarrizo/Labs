using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantIteraciones = 5;
            string[] array = new string[cantIteraciones];
            

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese posición {0}:",i);
                array[i] = Console.ReadLine();
            }

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("Posición {0}: {1}", i, array[i]);
                Console.ReadKey();
            }
        }
    }
}
