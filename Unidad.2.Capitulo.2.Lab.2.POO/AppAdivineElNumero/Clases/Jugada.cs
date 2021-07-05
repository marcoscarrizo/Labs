using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugada
    {
        private int _numero;
        private bool _adivino;
        private int _intentos;

        public int numero { get; set; }
        public bool adivino { get; set; }
        public int intentos { get; set; }
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _numero = rnd.Next(maxNumero);
            
        }
        public void Comparar(int num)
        {
            if (_numero == num)
            {
                Console.WriteLine("¡Número adivinado!");
                _adivino = true;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ups, número equivocado :( Vuelve a intentarlo!");
                _intentos += 1;
                Console.ReadKey();
            }
        }

    }
}
