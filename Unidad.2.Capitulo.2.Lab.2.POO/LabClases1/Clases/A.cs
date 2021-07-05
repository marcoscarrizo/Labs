using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        public string NombreDeInstancia { get; set; }

        public A()
        {
            this.NombreDeInstancia = "Instancia sin nombre";
        }

        public A(string nombre)
        {
            this.NombreDeInstancia = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine(this.NombreDeInstancia);
        }

        public void M1()
        {
            Console.WriteLine("El método M1 ha sido invocado.");
        }

        public void M2()
        {
            Console.WriteLine("El método M2 ha sido invocado.");
        }

        public void M3()
        {
            Console.WriteLine("El método M3 ha sido invocado.");
        }
    }
}
