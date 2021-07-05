using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Juan", "Perez", 20, 12345678);

            Console.WriteLine(p.GetFullName());
            Console.WriteLine(p.GetAge());

            Console.ReadKey();
            
        }
    }
}
