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
    public class ItemModel : PageModel
    {
       [BindProperty(SupportsGet =true)]
       public string Criteria { get; set; }


        [BindProperty]
        public List<Clothes> Items { get; set; } = new List<Clothes>();

        private ClothesRepository store;
        public ItemModel(ClothesRepository itemService)
        {
            store = itemService;
        }

        public void OnGet(string name)
        {
            
            Items = store.GetClothesForStore(name);
        }
    }
}
