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
    public class ConsumablesModel : PageModel
    {
        [BindProperty]
        public List<Consumable> Consumables { get; set; } = new List<Consumable>();

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }

        private IConsumablesRepository consumable;
        public ConsumablesModel(IConsumablesRepository consumableServices)
        {
            consumable = consumableServices;
        }

        public void OnGet(string name)
        {

            Consumables = consumable.GetConsumablesForRestaurant(name);
        }
    }
}
