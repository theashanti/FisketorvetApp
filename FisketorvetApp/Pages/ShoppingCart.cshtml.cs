using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetApp.Pages
{
    public class ShoppingCartModel : PageModel
    {
        [BindProperty]
        public List<AItem> Items { get; set; } = new List<AItem>();

        public int Total { get; set; }

        private ClothesRepository store;
        
        private IShoppingCartRepository cart;
        private IConsumablesRepository restaurant;
        public ShoppingCartModel(ClothesRepository itemService, IShoppingCartRepository cartServices, IConsumablesRepository restaurantServices)
        {
            store = itemService;
            cart = cartServices;
            restaurant = restaurantServices;
        }

        public void OnGet(int id, string name)
        {
            if(id != 0)
            {
                if(store.GetItem(id, name) == null)
                {
                    cart.DeleteItem(restaurant.GetConsumable(id, name));
                }
                else
                {
                    cart.DeleteItem(store.GetItem(id, name));
                }
                Items = cart.GetAllItems();
            }
            Items = cart.GetAllItems();

            Total = cart.TotaluPricu();
        }
    }
}
