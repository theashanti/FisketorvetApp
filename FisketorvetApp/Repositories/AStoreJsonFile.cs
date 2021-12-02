using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Domantas

namespace FisketorvetApp.Repositories
{
    public class AStoreJsonFile : IStoreRepository
    {
        string JsonFilePath = @"C:\Users\Lenovo\OneDrive - Zealand\Software design\Project work\1 Semester exams project\FisketorvetAppPart2\FisketorvetApp\Data\JsonStores.json";
        private List<AStore> stores;

        public AStoreJsonFile()
        {
            stores = JsonHelper.ReadStoresFile(JsonFilePath);
        }
        
        public List<AStore> AllStores()
        {
            return JsonHelper.ReadStoresFile(JsonFilePath);
        } 

        public List<AStore> Filter_By_StartCriteria(string criteria)
        {
            List<AStore> filteredStores = new List<AStore>();

            foreach (AStore store in stores)
            {
                if (store.Name.StartsWith(criteria))
                {
                    filteredStores.Add(store);
                }
            }

            return filteredStores;
        }

        public AStore GetStore(string name)
        {
            foreach (AStore store in stores)
            {
                if (store.Name == name)
                {
                    return store;
                }
            }
            
            return null;
        }
    }
}