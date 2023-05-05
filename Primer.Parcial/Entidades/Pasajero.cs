using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        protected int dni;
        protected int edad;
        protected ETipoEquipaje tipoEquipaje;
        protected float pesoEquipaje;

        public int Dni { get { return this.dni; } set { this.dni = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public ETipoEquipaje TipoEquipaje { get { return this.tipoEquipaje; } set { this.tipoEquipaje = value; } }
        public float PesoEquipaje { get { return this.pesoEquipaje; } set { this.pesoEquipaje = value; } }

        public Pasajero() : base()
        {
            this.dni = 0;
            this.edad = 0;
            this.tipoEquipaje = 0;
            this.pesoEquipaje = 0;
        }

        public Pasajero(string nombre, string apellido, int dni, int edad, ETipoEquipaje tipoEquipaje, float pesoEquipaje) : base(nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.tipoEquipaje = tipoEquipaje;
            this.pesoEquipaje = pesoEquipaje;
        }

        public virtual string Mostrar() 
        {
            return $"Nombre: {this.nombre} {this.apellido} - DNI: {this.dni} - Edad: {this.edad} - Equipaje: {this.tipoEquipaje} {this.pesoEquipaje}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Pasajero a, Pasajero b) 
        {
            return a.dni == b.dni;
        }

        public static bool operator !=(Pasajero a, Pasajero b)
        {
            return !(a == b);
        }
    }
}
