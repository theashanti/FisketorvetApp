using System.Collections.Generic;
using FisketorvetApp.Helpers;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;

// Martin

namespace FisketorvetApp.Repositories
{
    public class AItemJsonFile : IItemRepository
    {
        string JsonFilePath = @"C:\Users\Lenovo\OneDrive - Zealand\Software design\Project work\1 Semester exams project\FisketorvetAppPart2\FisketorvetApp\Data\JsonStores.json";
        private List<AItem> items;

        public AItemJsonFile()
        {
            items = JsonHelper.ReadItemFile(JsonFilePath);
        }
        
        public List<AItem> AllItems()
        {
            return JsonHelper.ReadItemFile(JsonFilePath);
        } 

        public List<AItem> Filter_By_StartCriteria(string criteria)
        {
            List<AItem> filteredItems = new List<AItem>();

            foreach (AItem item in items)
            {
                if (item.Name.StartsWith(criteria))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        public AItem GetItem(int id)
        {
            foreach (AItem item in items)
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