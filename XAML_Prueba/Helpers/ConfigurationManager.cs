using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace XAML_Prueba.Helpers
{
    public class ConfigurationManager
    {
        public static string GetConnectionString()
        {
            string pathToJson = "D:/C#/XAML_Prueba/XAML_Prueba/appsettings.json";
            string connectionString = "";

            try
            {
                string json = File.ReadAllText(pathToJson);
                JObject obj = JObject.Parse(json);
                connectionString = obj.SelectToken("ConnectionStrings.local").Value<string>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
            }


            return connectionString;
        }
    }
}
