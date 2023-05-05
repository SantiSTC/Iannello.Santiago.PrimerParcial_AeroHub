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

        public string CiudadDePartida { get { return this.ciudadDePartida; } }
        public string CiudadDeDestino { get { return this.ciudadDeDestino; } }
        public DateTime Fecha { get { return this.fecha; } }
        public Aeronave Avion { get { return this.avion; } }
        public int AsientosPremium { get { return this.asientos * (int)0.2; } }
        public int AsientosTurista { get { return this.asientos - AsientosPremium; } }
        public float CostoPremium { get { return CostoTurista * (float)1.35; } }

        public float CostoTurista
        {
            get 
            {
                if (this.ciudadDeDestino != EDestinoInternacional.Acapulco.ToString() || this.ciudadDeDestino != EDestinoInternacional.Miami.ToString() || this.ciudadDeDestino != EDestinoInternacional.Recife.ToString() || this.ciudadDeDestino != EDestinoInternacional.Roma.ToString())
                {
                    return 50 * this.Duracion;
                }
                else 
                {
                    return 100 * this.Duracion;
                }
                
            }
        }
        public int Duracion 
        { 
            get 
            {
                Random rand = new Random();
                int horas;

                if (this.ciudadDeDestino != EDestinoInternacional.Acapulco.ToString() || this.ciudadDeDestino != EDestinoInternacional.Miami.ToString() || this.ciudadDeDestino != EDestinoInternacional.Recife.ToString() || this.ciudadDeDestino != EDestinoInternacional.Roma.ToString())
                {
                    horas = rand.Next(2, 5);
                }
                else 
                {
                    horas = rand.Next(8, 13);
                }

                return horas; 
            } 
        }
        public List<Pasajero> Pasajeros { get { return this.pasajeros; } }

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
        }

        public static List<Viaje> AgregarViaje(List<Viaje> lista, string partida, string destino, DateTime fecha, Aeronave avion, int asientos, List<Pasajero> pasajeros) 
        {
            if (lista != null)
            {
                Viaje viaje = new Viaje(partida, destino, fecha, avion, asientos, pasajeros);
                lista.Add(viaje);
            }
            else 
            {
                lista = new List<Viaje>();
            }

            return lista;
        }

        public List<Viaje> EliminarViaje(List<Viaje> lista, Viaje viaje) 
        {
            lista.Remove(viaje);
            return lista;
        }


    }
}
