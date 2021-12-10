using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Máté

namespace FisketorvetApp.Interfaces
{
    public interface IConsumablesRepository
    {
        public List<Consumable> AllConsumables();


        public List<Consumable> GetConsumablesForRestaurant(string name);

        public List<Consumable> Filter_By_StartCriteria(string criteria, List<Consumable>edibles);

        public Consumable GetConsumable(int id);
    }
}
