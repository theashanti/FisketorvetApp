using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using FisketorvetApp.Repositories;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//M�t�
namespace FisketorvetApp.Pages
{
    public class ProductModel : PageModel
    {
        
        [BindProperty(SupportsGet =true)]
        public string Criteria { get; set; }
       
        private static string storeQuery;
       
        [BindProperty]
        public List<Clothes> Items { get; set; } = new List<Clothes>();

        
        private ClothesRepository store;
        private IShoppingCartRepository cart;
        public ProductModel(ClothesRepository itemService, IShoppingCartRepository cartServices)
        {
            store = itemService;
            cart = cartServices;
        }

        public void OnGet(string name, int id)
        {
            if(id != 0)
            {
                cart.AddItem(store.GetItem(id));
            }

            if (name != null)
            {
                storeQuery = name;
            }


            if (String.IsNullOrEmpty(Criteria))
            {
               
                Items = store.GetClothesForStore(storeQuery);
                
            }
            else
            {
                
                Items = store.GetClothesForStore(storeQuery);
                Items = store.Filter_By_StartCriteria(Criteria, Items);
                
            }
        }
    }
}
