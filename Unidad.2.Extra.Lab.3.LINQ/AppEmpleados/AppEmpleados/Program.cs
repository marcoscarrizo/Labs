using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleados
{
    public class Empleado 
    {
        private int _id;
        private string _nombre;
        private double _sueldo;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }

        //public Empleado(int id, string nombre, double sueldo)
        public Empleado()
        {
            //_id = id;
            //_nombre = nombre;
            //_sueldo = sueldo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> ListaEmpleados = new List<Empleado>();
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1) Añadir Empleado");
                Console.WriteLine("2) Ver Lista Empleados");
                Console.WriteLine("3) Salir");
                Console.WriteLine();

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Empleado e = new Empleado();
                        Console.Clear();
                        Console.WriteLine("Alta Empleado");

                        Console.WriteLine("Por favor ingrese el Id del Empleado");
                        e.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Por favor ingrese el Nombre del Empleado");
                        e.Nombre = Console.ReadLine();

                        Console.WriteLine("Por favor ingrese el Sueldo del Empleado");
                        e.Sueldo = double.Parse(Console.ReadLine());

                        ListaEmpleados.Add(e);

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("¿Cómo desea ordenar los datos?");
                        Console.WriteLine("1) Ascendente");
                        Console.WriteLine("2) Descendente");
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                foreach (var c in Descendente(ListaEmpleados))
                                {
                                    Console.WriteLine(c.Nombre, c.Sueldo);
                                }
                                Console.ReadKey();
                                break;

                            case 2:                                
                                foreach (var c in Descendente(ListaEmpleados))
                                {
                                    Console.WriteLine(c.Nombre,c.Sueldo);
                                }
                                Console.ReadKey();
                                break;

                            default:
                                break;
                        }
                        
                        break;

                    case 3:
                        break;
                }
            } while (op != 3);
            
        }

        static IOrderedEnumerable<Empleado> Ascendente(List<Empleado> ListaEmpleados)
        {
            var Consulta = from em in ListaEmpleados
                           orderby em.Sueldo //Ascendente
                           select em;
            return Consulta;
        }
        static IOrderedEnumerable<Empleado> Descendente(List<Empleado> ListaEmpleados)
        {
            var Consulta = from em in ListaEmpleados
                           orderby em.Sueldo descending //Descendiente
                           select em;
            return Consulta;
        }
    }
}
