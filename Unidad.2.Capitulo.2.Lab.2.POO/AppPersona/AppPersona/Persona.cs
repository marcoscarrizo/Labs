using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersona
{
    class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._dni = dni;
            Console.WriteLine("Se ha instanciado la Persona");
        }

        ~Persona()
        {
            Console.WriteLine("Se ha destruido la Persona");
        }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public int dni { get; set; }

        public string GetFullName()
        {
            return string.Concat(this._nombre + this._apellido);
        }

        public int GetAge()
        {
            return this._edad;
        }
    }
}
