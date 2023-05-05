using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeronave
    {
        protected string matricula;
        protected int cantAsientos;
        protected int cantBanios;
        protected bool internet;
        protected bool comida;
        protected float capacidadBodega;

        public string Matricula { get { return this.matricula; } set { this.matricula = value; } }
        public int CantidadAsientos { get { return this.cantAsientos; } set { this.cantAsientos = value; } }
        public int CantidadBanios { get { return this.cantBanios; } set { this.cantBanios = value; } }
        public bool Internet { get { return this.internet; } set { this.internet = value; } }
        public bool Comida { get { return this.comida; } set { this.comida = value; } }
        public float CapacidadBodega { get { return this.capacidadBodega; } set { this.capacidadBodega = value; } }

        public Aeronave() 
        {
            this.matricula = " ";
            this.cantAsientos = 0;
            this.cantBanios = 0;
            this.internet = false;
            this.comida = false;
            this.capacidadBodega = 0;
        }
        public Aeronave (string matricula, int cantAsientos, int cantBanios, bool internet, bool comida, float capacidadBodega) 
        {
            this.matricula = matricula;
            this.cantAsientos = cantAsientos;
            this.cantBanios = cantBanios;
            this.internet = internet;
            this.comida = comida;
            this.capacidadBodega = capacidadBodega;
        }

        public static List<Aeronave> AgregarAeronave(List<Aeronave> lista, string matricula, int cantAsientos, int cantBanios, bool internet, bool comida, float capacidadBodega) 
        {
            if (lista != null)
            {
                Aeronave avion = new Aeronave(matricula, cantAsientos, cantBanios, internet, comida, capacidadBodega);
                lista.Add(avion);
            }
            else 
            {
                lista = new List<Aeronave>();
            }
            
            return lista;
        }

        public List<Aeronave> EliminarAeronave(List<Aeronave> lista, Aeronave avion) 
        {
            if (lista.Contains(avion)) 
            {
                lista.Remove(avion);
            }

            return lista;
        }

        private string Mostrar() 
        {
            return $"Mat.: {this.matricula} - Capacidad: {this.cantAsientos}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }

    
}
