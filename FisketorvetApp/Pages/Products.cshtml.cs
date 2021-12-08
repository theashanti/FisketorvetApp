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
        public ProductModel(ClothesRepository itemService)
        {
            store = itemService;
        }

        public void OnGet(string name)
        {
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
                Items = store.Filter_By_StartCriteria(Criteria);
            }
        }
    }
}
