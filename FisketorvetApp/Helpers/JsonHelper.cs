using System.Collections.Generic;
using System.IO;
using FisketorvetApp.Models;
using Newtonsoft.Json;

// Martin

namespace FisketorvetApp.Helpers
{
    public class JsonHelper
    {
        public static List<User> ReadUserFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<User>>(jsonString);
        }

        public static void WriteUserFile(List<User> users, string filePath)
        {
            string output = JsonConvert.SerializeObject(users);
            
            File.WriteAllText(filePath, output);
        }

        public static List<AStore> ReadStoresFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<AStore>>(jsonString);
        }

        public static void WriteStoreFile(List<AStore> users, string filePath)
        {
            string output = JsonConvert.SerializeObject(users);

            File.WriteAllText(filePath, output);
        }
        
        public static List<AItem> ReadItemFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<AItem>>(jsonString);
        }

        public static void WriteItemFile(List<AItem> items, string filePath)
        {
            string output = JsonConvert.SerializeObject(items);

            File.WriteAllText(filePath, output);
        }
    }
}