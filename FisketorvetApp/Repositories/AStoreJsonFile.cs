using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Domantas

namespace FisketorvetApp.Repositories
{
    public class AStoreJsonFile : IStoreRepository
    {
        //C:\Users\marti\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonStores.json
        //Máté directory: E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonStores.json
         //Ash C:\Users\ashan\OneDrive\Área de Trabalho\FisketorvetApp\FisketorvetApp\Data\JsonStores.json
         //mitra  C:\Users\Uni\Source2\Repos\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonStores.json
         //Dom: C:\Users\Lenovo\OneDrive - Zealand\Desktop\FisketorvetApp-master\FisketorvetApp\Data\JsonStores.json
        string JsonFilePath = @"E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonStores.json";
        private List<Store> stores;

        public AStoreJsonFile()
        {
            stores = JsonHelper.ReadStoresFile(JsonFilePath);
        }
        
        public List<Store> AllStores()
        {
            return JsonHelper.ReadStoresFile(JsonFilePath);
        } 

        public List<Store> Filter_By_StartCriteria(string criteria)
        {
            List<Store> filteredStores = new List<Store>();

            foreach (Store store in stores)
            {
                if (store.Name.StartsWith(criteria))
                {
                    filteredStores.Add(store);
                }
            }

            return filteredStores;
        }

        public Store GetStore(string name)
        {
            foreach (Store store in stores)
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