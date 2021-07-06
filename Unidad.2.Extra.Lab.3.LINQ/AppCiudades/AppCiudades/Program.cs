using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AppCiudades
{
    public class Ciudad
    {
        private int _codigo;
        private string _nombre;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; } //Usando Lambda Expressions seria el equivalente a hacer un método Getter y Setter; con => indicamos qué hace nuestro método

        public string CovertirNombreAMayusculas() => _nombre.ToUpper(); //Ejemplo de método usando lambda expression

        public Ciudad(int codigo, string nombre)
        {
            _codigo = codigo;
            _nombre = nombre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrList = new ArrayList();
            arrList.Add(new Ciudad(2000, "Rosario"));
            arrList.Add(new Ciudad(1000, "Santa Fe"));
            arrList.Add(new Ciudad(1500, "Villa Constitución"));
            arrList.Add(new Ciudad(2500, "Arroyo Seco"));
            arrList.Add(new Ciudad(3000, "Pueblo Esther"));
            arrList.Add(new Ciudad(2600, "Alvear"));
            arrList.Add(new Ciudad(1700, "General Lagos"));
            arrList.Add(new Ciudad(1300, "San Nicólas"));
            arrList.Add(new Ciudad(1650, "Funes"));
            arrList.Add(new Ciudad(1800, "Roldan"));


            Console.WriteLine("Ingrese caracteristica a buscar:");
            string bus = Console.ReadLine();

            var CiuL = arrList.OfType<Ciudad>();

            var consulta = from c in CiuL
                           where c.Nombre.Contains(bus)
                           select c;

            

            foreach (Ciudad c in consulta) 
            {
                Console.WriteLine("La ciudad encontrada es {0}", c.Nombre);
                Console.WriteLine("Su Código Postal es {0}", c.Codigo);
            }
            

            Console.ReadKey();
        }
    }
}
