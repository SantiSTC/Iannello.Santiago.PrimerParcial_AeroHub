using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Listas
    {
        public static List<Aeronave> aviones;
        public static List<Viaje> viajes;
        public static List<Pasajero> pasajeros;

        static Listas()
        {
            aviones = new List<Aeronave>();
            viajes = new List<Viaje>();
            pasajeros = new List<Pasajero>();
          
            aviones.Add(new Aeronave("sas222ss",222,2,true,true,2222, pasajeros));
            aviones.Add(new Aeronave("sas333ss", 333, 3, true, true, 3333, pasajeros));

            viajes.Add(new Viaje("Bariloche", "Salta", new DateTime(2023, 9, 30), aviones[1], aviones[1].CantidadAsientos, aviones[1].Pasajeros));
            viajes.Add(new Viaje("Buenos Aires", "Roma", new DateTime(2023,6,8), aviones[0], aviones[0].CantidadAsientos, aviones[0].Pasajeros));
        }
    }
}
