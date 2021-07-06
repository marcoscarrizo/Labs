using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int>();
            string op;
            do
            {
                Console.WriteLine("Ingrese número:");
                listaEnteros.Add(int.Parse(Console.ReadLine()));
                
                Console.WriteLine("¿Añadir otro número? (s/n)");
                op = Console.ReadLine();

            } while (op != "n");

            //Consulta LINQ
            var Mayores = from entero in listaEnteros
                          where entero > 20
                          select entero;

            Console.WriteLine("Los números mayores a 20 son:");
            
            foreach (var entero in Mayores)
            {
                Console.WriteLine(entero);
            }
            
        }
    }
}
