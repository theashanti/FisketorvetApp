using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Martin

namespace FisketorvetApp.Interfaces
{
    public interface ClothesRepository
    {
        public List<Clothes> AllItems();

        
        public List<Clothes> GetClothesForStore(string name);

        public List<Clothes> Filter_By_StartCriteria(string criteria, List<Clothes> clothes);

        public Clothes GetItem(int id);
    }
}
