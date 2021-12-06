using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Máté
namespace FisketorvetApp.Interfaces
{
    public interface IRestaurantRepository
    {
        public List<Restaurant> AllRestaurants();


        public List<Restaurant> Filter_By_StartCriteria(string criteria);

        public Restaurant GetRestaurant(string name);
    }
}
