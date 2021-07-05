using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Juego
    {
        private int _record;

        public int record { get; set; }
        public Juego()
        {

        }
        public void ComenzarJuego()
        {
            Console.Clear();
            PreguntarMaximo();

        }
        private void CompararRecord(JugadaConAyuda j)
        {
            if (j.adivino == true)
            {
                if (this._record > j.intentos)
                {
                    Console.WriteLine("¡Ha obtenido un nuevo record!");
                    _record = j.intentos;
                }
            }
            
            Continuar(j);
            
        }
        private void Continuar(JugadaConAyuda j)
        {
            string opcion;
            Console.WriteLine("¿Desea volver a Jugar? (s/n)");
            opcion = Console.ReadLine();
            if (opcion == "s")
            {
                if (j.adivino == true)
                {

                    ComenzarJuego();
                }
                else
                {
                    PreguntarNumero(j);
                }
                
            }
        }
        private void PreguntarMaximo()
        {
            //Preguntar Máximo 
            Console.WriteLine("Por favor ingrese el número máximo para jugar:");
            
            int max = int.Parse(Console.ReadLine());
            JugadaConAyuda j = new JugadaConAyuda(max);
            
            Console.WriteLine("¡Se ha generado con éxito el número a adivinar!");
            Console.WriteLine();
            PreguntarNumero(j);

        }
        private void PreguntarNumero(JugadaConAyuda j)
        {
            //Preguntar Número
            Console.WriteLine("Ingrese el número que crea que es:");
            int num = int.Parse(Console.ReadLine());
            j.Comparar(num);
            CompararRecord(j);

        }
    }
}
