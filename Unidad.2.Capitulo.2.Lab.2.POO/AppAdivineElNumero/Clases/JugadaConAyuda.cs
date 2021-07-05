using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero):base(maxNumero)
        {
          
        }

        new public void Comparar(int num)
        {
            if (base.numero == num)
            {
                Console.WriteLine("¡Número adivinado!");
                base.adivino = true;
                Console.ReadKey();
            }
            else
            {
                int res = Math.Abs(base.numero - num);
                if (res > 100)
                {
                    Console.WriteLine("El número está demasiado lejos :( Vuelve a intentarlo!");
                    base.intentos += 1;
                }
                else
                {
                    Console.WriteLine("El número está cerca! :D Vuelve a intentarlo!");
                    base.intentos += 1;
                }
                
            }
        }
    }
}