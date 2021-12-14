using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Martin

namespace FisketorvetApp.Repositories
{
    public class AClothesJsonFile : ClothesRepository
    {
        //C:\Users\marti\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json
        //Máté directory: E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json
        //Ash C:\Users\ashan\OneDrive\Área de Trabalho\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json
        // mitra: C:\Users\Uni\Source2\Repos\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json
        // Dom : C:\Users\Lenovo\OneDrive - Zealand\GitHub\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json
        string JsonFilePath = @"C:\Users\Lenovo\OneDrive - Zealand\GitHub\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json";
        private List<Clothes> items;

        public AClothesJsonFile()
        {
            items = JsonHelper.ReadItemFile(JsonFilePath);
        }
        
        public List<Clothes> AllItems()
        {
            return JsonHelper.ReadItemFile(JsonFilePath);
        }
        
        //new get
        public List<Clothes> GetClothesForStore(string name)
        {
            List<Clothes> StoreItems = new List<Clothes>();
            foreach(Clothes item in items)
            {
                if (item.StoreName.Equals(name))
                {
                    StoreItems.Add(item);
                }
            }
            return StoreItems;
        }
        

        public List<Clothes> Filter_By_StartCriteria(string criteria, List<Clothes>ig)
        {
            List<Clothes> filteredItems = new List<Clothes>();

            foreach (Clothes item in ig)
            {
                if (item.Name.StartsWith(criteria))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        public Clothes GetItem(int id)
        {
            foreach (Clothes item in items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            
            return null;
        }
    }
}