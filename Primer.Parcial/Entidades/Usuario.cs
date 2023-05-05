using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        protected int legajo;
        protected string correo;
        protected string clave;
        protected EPerfil perfil;

        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public string Correo { get { return this.correo; } set { this.correo = value; } }
        public string Clave { get { return this.clave; } set { this.clave = value; } }
        public EPerfil Perfil { get { return this.perfil; } set { this.perfil = value; } }

        public Usuario(string apellido, string nombre, int legajo, string correo, string clave, EPerfil perfil) : base(nombre, apellido)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        public virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.nombre} {this.apellido} - {this.legajo} - {this.correo} - {this.perfil}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static implicit operator int(Usuario a) 
        {
            return a.legajo;
        }

        public static bool operator ==(Usuario a, Usuario b) 
        {
            return a.legajo == b.legajo && a.apellido == b.apellido;
        }

        public static bool operator !=(Usuario a, Usuario b) 
        {
            return !(a == b);
        }
    }
}
