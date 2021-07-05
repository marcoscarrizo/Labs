using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escriba una frase por favor");
            
            string inputTexto = Console.ReadLine();
            
            if (inputTexto != "")
            {
                ConsoleKeyInfo opcion = new ConsoleKeyInfo();
                do
                {
                    Console.WriteLine("Seleccione que Lógica desea aplicar:");
                    Console.WriteLine("1)IF");
                    Console.WriteLine("2)SWITCH");
                    Console.WriteLine("3)Salir");

                    opcion = Console.ReadKey();
                    
                } while (opcion.Key < ConsoleKey.D1 && opcion.Key > ConsoleKey.D3);

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        LogicaIf(inputTexto);
                        break;
                    case ConsoleKey.D2:
                        LogicaSwitch(inputTexto);
                        break;
                    case ConsoleKey.D3:
                        break;
                }

            }
            else
            {
                Console.WriteLine("No se encontró la frase, por favor intentelo nuevamente.");
            }
        }

        static ConsoleKeyInfo Opciones()
        {
            ConsoleKeyInfo opcion = new ConsoleKeyInfo();
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1) Frase en Mayúsculas");
                Console.WriteLine("2) Frase en Minúsculas");
                Console.WriteLine("3) Mostrar cantidad de caracteres de la Frase");
                Console.WriteLine("4) Salir");


                opcion = Console.ReadKey();
            } while (opcion.Key < ConsoleKey.D1 && opcion.Key > ConsoleKey.D4);
            return opcion;
        }

        static void LogicaIf(string inputTexto)
        {
            ConsoleKeyInfo opcion = new ConsoleKeyInfo();
            do
            {
                opcion = Opciones();

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Frase en Mayúsculas: {0}", inputTexto.ToUpper());
                    Console.ReadKey();
                }
                else
                {
                    if (opcion.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine("Frase en Minúsculas: {0}", inputTexto.ToLower());
                        Console.ReadKey();
                    }
                    else
                    {
                        if (opcion.Key == ConsoleKey.D3)
                        {
                            Console.WriteLine("Cantidad de Carácteres de la Frase: {0}", inputTexto.Length);
                            Console.ReadKey();
                        }
                    }
                }
            } while (opcion.Key < ConsoleKey.D1 && opcion.Key > ConsoleKey.D4);            
        }

        static void LogicaSwitch(string inputTexto)
        {
            ConsoleKeyInfo opcion = new ConsoleKeyInfo();
            do
            {
                opcion = Opciones();

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Frase en Mayúsculas: {0}", inputTexto.ToUpper());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Frase en Minúsculas: {0}", inputTexto.ToLower());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Cantidad de Carácteres de la Frase: {0}", inputTexto.Length);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            } while (opcion.Key < ConsoleKey.D1 && opcion.Key > ConsoleKey.D4);           
        }
    }
}
