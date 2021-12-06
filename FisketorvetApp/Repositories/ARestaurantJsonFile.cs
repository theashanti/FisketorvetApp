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
    public class ARestaurantJsonFile : IRestaurantRepository
    {
        string JsonFilePath = @"E:\FUSKETORVUTUE\theashanti\FisketorvetApp\FisketorvetApp\Data\JsonRestaurants.json";
        private List<Restaurant> restaurants;

        public ARestaurantJsonFile()
        {
            restaurants = JsonHelper.ReadRestaurantsFile(JsonFilePath);
        }

        public List<Restaurant> AllRestaurants()
        {
            return JsonHelper.ReadRestaurantsFile(JsonFilePath);
        }

        public List<Restaurant> Filter_By_StartCriteria(string criteria)
        {
            List<Restaurant> filteredStores = new List<Restaurant>();

            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Name.StartsWith(criteria))
                {
                    filteredStores.Add(restaurant);
                }
            }

            return filteredStores;
        }

        public Restaurant GetRestaurant(string name)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Name == name)
                {
                    return restaurant;
                }
            }

            return null;
        }
    }
}
