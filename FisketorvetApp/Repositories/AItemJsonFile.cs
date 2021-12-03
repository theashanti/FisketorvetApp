using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Martin, Máté(modifications)

namespace FisketorvetApp.Repositories
{
    public class AItemJsonFile : ClothesRepository
    {
        string JsonFilePath = @"E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonClothes.json";
        private List<Clothes> items;

        public AItemJsonFile()
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
        

        public List<Clothes> Filter_By_StartCriteria(string criteria)
        {
            List<Clothes> filteredItems = new List<Clothes>();

            foreach (Clothes item in items)
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