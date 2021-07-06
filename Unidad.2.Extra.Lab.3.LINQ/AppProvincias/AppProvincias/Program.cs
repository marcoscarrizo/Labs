using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProvincias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] provincias = {"Santa Fe", "Buenos Aires", "Córdoba", "Corrientes", "Entre Rios", "Tucumán", "Santiago del Estero", "Jujuy", "Salta", "Misiones", "Chaco", "Mendoza", "La Rioja", "La Pampa", "Chubut", "Rio Negro", "Formosa", "Tierra del Fuego" };

            Console.WriteLine("Seleccione:");
            Console.WriteLine("1) Provincias que empiezan con S");
            Console.WriteLine("2) Provincias que empiezan con T");
            
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    var ProvinciasConS = from provincia in provincias
                                         where provincia.StartsWith("S")
                                         select provincia;

                    foreach (var p in ProvinciasConS)
                    {
                        Console.WriteLine(p);
                    }
                    break;
                case 2:
                    var ProvinciasConT = from provincia in provincias
                                         where provincia.StartsWith("T")
                                         select provincia;

                    foreach (var p in ProvinciasConT)
                    {
                        Console.WriteLine(p);
                    }
                    break;
                default:
                    break;
            }
            
        }
    }
}
