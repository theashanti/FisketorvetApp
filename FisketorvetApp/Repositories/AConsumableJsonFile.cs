﻿using FisketorvetApp.Helpers;
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
        string JsonFilePath = @"E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonConsumables.json";
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


        public List<Consumable> Filter_By_StartCriteria(string criteria)
        {
            List<Consumable> filteredItems = new List<Consumable>();

            foreach (Consumable consumable in consumables)
            {
                if (consumable.Name.StartsWith(criteria))
                {
                    filteredItems.Add(consumable);
                }
            }

            return filteredItems;
        }

        public Consumable GetConsumable(int id)
        {
            foreach (Consumable consumable in consumables)
            {
                if (consumable.Id == id)
                {
                    return consumable;
                }
            }

            return null;
        }
    }
}