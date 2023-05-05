using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public Persona() 
        {
            this.nombre = " ";
            this.apellido = " ";
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
