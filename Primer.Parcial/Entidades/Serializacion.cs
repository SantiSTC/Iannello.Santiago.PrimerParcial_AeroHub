using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
                        WriteIndented = true 
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

        public static bool SerializarXML(List<T> lista, string path) 
        {
            XmlSerializer serializer;
            bool retorno = false;

            try 
            {
                using (Serializacion<T>.writer = new StreamWriter(path)) 
                {
                    serializer = new XmlSerializer(typeof(List<T>));
                    serializer.Serialize(Serializacion<T>.writer, lista);
                    retorno = true;
                }
            }
            catch (Exception) 
            {
                retorno = false;
            }

            return retorno;
        }

        public static List<T> DeserializarXML(string path) 
        {
            XmlSerializer serializer;
            List<T> aux = new List<T>();

            try 
            {
                using (Serializacion<T>.reader = new StreamReader(path)) 
                {
                    serializer = new XmlSerializer(typeof(List<T>));
                    aux = (List<T>)serializer.Deserialize(Serializacion<T>.reader);
                }
            }
            catch (Exception) 
            {
                aux = new List<T>();
            }

            return aux;
        }
    }
}
