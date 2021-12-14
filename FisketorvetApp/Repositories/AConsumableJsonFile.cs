using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Máté
namespace FisketorvetApp.Repositories
{
    public class AConsumableJsonFile : IConsumablesRepository
    {
        //C:\Users\marti\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json
        //Máté directory: E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json
        //Ash C:\Users\ashan\OneDrive\Área de Trabalho\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json
        //mitra C:\Users\Uni\Source2\Repos\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json
        //Dom: C:\Users\Lenovo\OneDrive - Zealand\GitHub\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json
        string JsonFilePath = @"C:\Users\Martin\Desktop\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json";
        private List<Consumable> consumables;

        public AConsumableJsonFile()
        {
            consumables = JsonHelper.ReadConsumablesFile(JsonFilePath);
        }

        public List<Consumable> AllConsumables()
        {
            return JsonHelper.ReadConsumablesFile(JsonFilePath);
        }

        
        public List<Consumable> GetConsumablesForRestaurant(string name)
        {
            List<Consumable> StoreItems = new List<Consumable>();
            foreach (Consumable consumable in consumables)
            {
                if (consumable.StoreName.Equals(name))
                {
                    StoreItems.Add(consumable);
                }
            }
            return StoreItems;
        }


        public List<Consumable> Filter_By_StartCriteria(string criteria, List<Consumable>gh)
        {
            List<Consumable> filteredItems = new List<Consumable>();

            foreach (Consumable consumable in gh)
            {
                if (consumable.Name.StartsWith(criteria, StringComparison.CurrentCultureIgnoreCase))
                {
                    filteredItems.Add(consumable);
                }
            }

            return filteredItems;
        }

        public Consumable GetConsumable(int id, string name)
        {
            foreach (Consumable consumable in consumables)
            {
                if (consumable.Id == id && consumable.Name == name)
                {
                    return consumable;
                }
            }

            return null;
        }
    }
}
