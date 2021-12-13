using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetApp.Pages
{
    public class ShoppingCartModel : PageModel
    {
        private ClothesRepository store;
        private IShoppingCartRepository cart;
        private IConsumablesRepository restaurant;
        public ShoppingCartModel(ClothesRepository itemService, IShoppingCartRepository cartServices, IConsumablesRepository restaurantServices)
        {
            store = itemService;
            cart = cartServices;
            restaurant = restaurantServices;
        }

        public void OnGet(int id)
        {
            if(id != 0)
            {
                if(store.GetItem(id) == null)
                {
                    cart.DeleteItem(restaurant.GetConsumable(id));
                }
                else
                {
                    cart.DeleteItem(store.GetItem(id));
                }
            }
        }
    }
}
