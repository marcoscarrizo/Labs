using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        public void F() { Console.WriteLine("A.F"); }
        public virtual void G() { Console.WriteLine("A.G"); } //Usamos Virtual para indicar a las clases derivadas que este método puede ser modificado
    }

    public class B : A
    {
        new public void F() { Console.WriteLine("B.F"); } //Con new ocultamos el método heredado
        public override void G() { Console.WriteLine("B.G"); } //Usamos Override para sobreescribir el comportamiento del método de la clase base heredado
    }
}

