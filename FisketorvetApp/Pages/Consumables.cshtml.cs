using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//M�t�
namespace FisketorvetApp.Pages
{
    public class ConsumablesModel : PageModel
    {
        [BindProperty]
        public List<Consumable> Consumables { get; set; } = new List<Consumable>();

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }
        
        private static string storeQuery;
        public string Rname { get; set; }

        private IConsumablesRepository consumable;
        private IShoppingCartRepository cart;
        public ConsumablesModel(IConsumablesRepository consumableServices, IShoppingCartRepository cartServices)
        {
            consumable = consumableServices;
            cart = cartServices;
        }

        public void OnGet(string name, int id, string iname)
        {
            if (id != 0)
            {
                cart.AddItem(consumable.GetConsumable(id, iname));
                HttpContext.Session.SetInt32("CartCount", cart.GetAllItems().Count);
                Rname = storeQuery;
            }

            if (name != null)
            {
                storeQuery = name;
                Rname = name;
            }
            
            if (String.IsNullOrEmpty(Criteria))
            {
                Consumables = consumable.GetConsumablesForRestaurant(storeQuery);
            }
            else
            {
                Consumables = consumable.GetConsumablesForRestaurant(storeQuery);
                Consumables = consumable.Filter_By_StartCriteria(Criteria, Consumables);
            }
        }
    }
}
