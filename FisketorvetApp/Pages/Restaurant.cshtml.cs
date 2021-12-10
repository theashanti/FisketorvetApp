using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//Máté
namespace FisketorvetApp.Pages
{
    public class RestaurantModel : PageModel
    {
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }

        private IRestaurantRepository restaurants;
        public RestaurantModel(IRestaurantRepository restaurantService)
        {
            restaurants = restaurantService;
        }

        public void OnGet()
        {
            if (String.IsNullOrEmpty(Criteria))
            {
                Restaurants = restaurants.AllRestaurants();
            }
            else
            {

                Restaurants = restaurants.Filter_By_StartCriteria(Criteria);
            }
        }
    }
}
