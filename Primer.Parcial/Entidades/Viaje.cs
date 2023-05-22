using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        protected string ciudadDePartida;
        protected string ciudadDeDestino;
        protected DateTime fecha;
        protected Aeronave avion;
        protected int asientos;
        protected List<Pasajero> pasajeros;
        private float costo;
        private int duracion;

        public string CiudadDePartida { get { return this.ciudadDePartida; } }
        public string CiudadDeDestino { get { return this.ciudadDeDestino; } }
        public DateTime Fecha { get { return this.fecha; } set { this.fecha = value; } }
        public Aeronave Avion { get { return this.avion; } }
        public int AsientosPremium { get { return (int)(this.asientos * (float)0.2); } }
        public int AsientosTurista { get { return this.asientos - AsientosPremium; } }

        public int Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public float CostoTurista
        {
            get 
            {
                if (this.ciudadDeDestino != EDestinoInternacional.Acapulco.ToString() && this.ciudadDeDestino != EDestinoInternacional.Miami.ToString() && this.ciudadDeDestino != EDestinoInternacional.Recife.ToString() && this.ciudadDeDestino != EDestinoInternacional.Roma.ToString())
                {
                    this.costo = 50 * this.duracion;
                }
                else 
                {
                    this.costo = 100 * this.duracion;
                }

                return this.costo;
            }
        }

        public float CostoPremium { get { return (this.costo * (float)0.35) + this.costo; } }

        public Viaje() 
        {
            this.ciudadDePartida = " ";
            this.ciudadDeDestino = " ";
            this.fecha = DateTime.Now;
            this.avion = new Aeronave();
            this.asientos = 0;
            this.pasajeros = new List<Pasajero>();
        }

        public Viaje(string partida, string destino, DateTime fecha, Aeronave avion, int asientos, List<Pasajero> pasajeros) 
        {
            this.ciudadDePartida = partida;
            this.ciudadDeDestino = destino;
            this.fecha = fecha;
            this.avion = avion;
            this.asientos = asientos;
            this.pasajeros = pasajeros;

            if (this.ciudadDeDestino != EDestinoInternacional.Acapulco.ToString() && this.ciudadDeDestino != EDestinoInternacional.Miami.ToString() && this.ciudadDeDestino != EDestinoInternacional.Recife.ToString() && this.ciudadDeDestino != EDestinoInternacional.Roma.ToString())
            {
                this.duracion = (new Random()).Next(2, 5);
            }
            else
            {
                this.duracion = (new Random()).Next(8, 13);
            }
        }

        public static List<Viaje> AgregarViaje(List<Viaje> lista, string partida, string destino, DateTime fecha, Aeronave avion, List<Pasajero> pasajeros) 
        {
            if (lista != null)
            {
                Viaje viaje = new Viaje(partida, destino, fecha, avion, avion.CantidadAsientos, pasajeros);
                lista.Add(viaje);
            }
            else 
            {
                lista = new List<Viaje>();
            }

            return lista;
        }

        public override string ToString()
        {
            return $"{this.ciudadDePartida} a {this.ciudadDeDestino} - {this.fecha.Date.ToShortDateString()}";
        }

        public static bool operator ==(Viaje v1, Viaje v2) 
        {
            return v1.avion == v2.avion && v1.fecha == v2.fecha;
        }

        public static bool operator !=(Viaje v1, Viaje v2) 
        {
            return !(v1 == v2);
        }

        public override bool Equals(object? obj)
        {
            bool rta = false;

            if (obj is Viaje)
            {
                rta = (Viaje)obj == this;
            }

            return rta;
        }
    }
}
