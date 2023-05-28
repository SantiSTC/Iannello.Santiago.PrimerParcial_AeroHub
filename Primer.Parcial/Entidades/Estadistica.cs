using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Entidades
{
    public static class Estadistica
    {
        public static int ObtenerViajesRealizados() 
        {
            int contador = 0;

            foreach (Viaje item in Listas.viajes) 
            {
                if (item.Fecha < DateTime.Now) 
                {
                    contador++;
                }
            }

            return contador;
        }

        public static float ObtenerRecaudacion() 
        {
            float sumador = 0;

            foreach (Viaje item in Listas.viajes) 
            {
                foreach (Pasajero pasajero in item.Avion.Pasajeros) 
                {
                    if (pasajero.EsPremium)
                    {
                        sumador += item.CostoPremium;
                    }
                    else 
                    {
                        sumador += item.CostoTurista;
                    }
                }
            }

            return sumador;
        }

        public static Dictionary<string, int> ObtenerCantidadDePasajerosPorVuelo() 
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string cadena = "";

            foreach (Viaje item in Listas.viajes) 
            {
                cadena = $"{item.CiudadDePartida} a {item.CiudadDeDestino} - {item.Fecha.Date}";

                diccionario.Add(cadena, item.Pasajeros.Count);
            }

            return diccionario;
        }

        public static string ObtenerDestinoMasElegido() 
        {
            int contador = 0;
            int max = 0;
            string destMasElegido = "";
            List<string> destinos = new List<string>();

            foreach (EDestinoNacional dest in Enum.GetValues(typeof(EDestinoNacional))) 
            {
                destinos.Add(dest.ToString().Replace("_", " "));
            }
            foreach (EDestinoInternacional dest in Enum.GetValues(typeof(EDestinoInternacional)))
            {
                destinos.Add(dest.ToString().Replace("_", " "));
            }

            foreach (string destino in destinos) 
            {
                contador = 0;

                foreach (Viaje item in Listas.viajes)
                {
                    if (item.CiudadDeDestino.Replace("_", " ") == destino) 
                    {
                        contador++;
                    }
                }

                if (contador >= max) 
                {
                    max = contador;
                    destMasElegido = destino;
                }
            }

            return destMasElegido;
        }

        public static List<string> ObtenerDestinosOrdenadosPorFacturacion() 
        {
            Dictionary<string, float> dicccionario = new Dictionary<string, float>();
            List<string> destinos = new List<string>();
            List<string> destinosOrdenados = new List<string>();

            foreach (EDestinoNacional dest in Enum.GetValues(typeof(EDestinoNacional)))
            {
                destinos.Add(dest.ToString().Replace("_", " "));
            }
            foreach (EDestinoInternacional dest in Enum.GetValues(typeof(EDestinoInternacional)))
            {
                destinos.Add(dest.ToString().Replace("_", " "));
            }

            foreach (string destino in destinos) 
            {
                dicccionario.Add(destino, ObtenerRecaudacionPorDestino(destino));
            }

            var listaOrdenada = dicccionario.ToList().OrderByDescending(x  => x.Value);
            dicccionario.Clear();

            foreach (var item in listaOrdenada) 
            {
                dicccionario.Add(item.Key, item.Value);
            }

            foreach (var item in dicccionario) 
            {
                destinosOrdenados.Add(item.Key);
            }

            return destinosOrdenados;
        }

        private static float ObtenerRecaudacionPorDestino(string destino) 
        {
            float acumulador = 0;

            foreach (Viaje item in Listas.viajes) 
            {
                if (item.CiudadDeDestino == destino) 
                {
                    foreach(Pasajero pasajero in item.Pasajeros) 
                    {
                        if (pasajero.EsPremium)
                        {
                            acumulador += item.CostoPremium;
                        }
                        else 
                        {
                            acumulador += item.CostoTurista;
                        }
                    }
                }
            }

            return acumulador;
        }

        public static Dictionary<string, int> ObtenerHorasDeVueloPorAeronave() 
        {
            Dictionary<string, int> dicccionario = new Dictionary<string, int>();
            int acumulador;

            foreach (Viaje viaje in Listas.viajes) 
            {
                acumulador = 0;

                foreach(Aeronave avion in Listas.aviones) 
                {
                    if (viaje.Avion == avion) 
                    {
                        acumulador += viaje.Duracion;
                    }
                }

                if (!dicccionario.ContainsKey(viaje.Avion.Matricula))
                {
                    dicccionario.Add(viaje.Avion.Matricula, acumulador);
                }
                else 
                {
                    dicccionario[viaje.Avion.Matricula] += acumulador;
                }
            }

            return dicccionario;
        }

        public static Dictionary<string, float> ObtenerGananciasTotalesSegunServicio() 
        {
            Dictionary<string, float> dicccionario = new Dictionary<string, float>();
            
            dicccionario.Add("Internacional", ObtenerRecaudacionPorServicio(0));
            dicccionario.Add("Nacional", ObtenerRecaudacionPorServicio(1));

            return dicccionario;
        }

        private static float ObtenerRecaudacionPorServicio(int opcion) 
        {
            float acumulador = 0;

            if (opcion == 0)
            {
                foreach (Viaje viaje in Listas.viajes)
                {
                    if(viaje.CiudadDeDestino == "Roma" || viaje.CiudadDeDestino == "Miami" || viaje.CiudadDeDestino == "Recife" || viaje.CiudadDeDestino == "Acapulco")
                    {
                        foreach (Pasajero pasajero in viaje.Pasajeros)
                        {
                            if (pasajero.EsPremium)
                            {
                                acumulador += viaje.CostoPremium;
                            }
                            else
                            {
                                acumulador += viaje.CostoTurista;
                            }
                        }

                    }
                }
            }
            else 
            {
                foreach (Viaje viaje in Listas.viajes)
                {
                    if (!(viaje.CiudadDeDestino == "Roma") && !(viaje.CiudadDeDestino == "Miami") && !(viaje.CiudadDeDestino == "Recife") && !(viaje.CiudadDeDestino == "Acapulco"))
                    {
                        foreach (Pasajero pasajero in viaje.Pasajeros)
                        {
                            if (pasajero.EsPremium)
                            {
                                acumulador += viaje.CostoPremium;
                            }
                            else
                            {
                                acumulador += viaje.CostoTurista;
                            }
                        }

                    }
                }
            }

            return acumulador;
        }
    }
}
