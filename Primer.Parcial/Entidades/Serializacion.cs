using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Serializacion<T>
    {
        private static StreamReader? reader;
        private static StreamWriter? writer;

        public static bool Serializar(List<T> lista, string path)
        {
            bool retorno = false;

            try 
            {
                using(Serializacion<T>.writer = new StreamWriter(path)) 
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true // Para tener una salida JSON con formato legible
                    };

                    string json = System.Text.Json.JsonSerializer.Serialize(lista, options);
                    Serializacion<T>.writer.Write(json);
                    retorno = true;
                }
            }
            catch (Exception) 
            {
                retorno = false;
            }

            return retorno;
        }

        public static List<T> Deserializar(string path) 
        {
            List<T>? lista = new List<T>();

            try 
            {
                using(Serializacion<T>.reader = new StreamReader(path)) 
                {
                    string jsonString = File.ReadAllText(path);

                    lista = JsonConvert.DeserializeObject<List<T>>(jsonString);
                }
            }
            catch (Exception) 
            {
                lista = new List<T>();
            }

            return lista;
        }
    }
}
