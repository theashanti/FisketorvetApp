using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//Máté

namespace FisketorvetApp.Pages.Shared
{
    public class StoreModel : PageModel
    {
        public List<Store> Stores { get; set; } = new List<Store>();

        [BindProperty(SupportsGet =true)]
        public string Criteria { get; set; }

        private IStoreRepository stores;
        public StoreModel(IStoreRepository storeService)
        {
             stores= storeService;

        }

        public void OnGet()
        {
            if (String.IsNullOrEmpty(Criteria))
            {
                Stores = stores.AllStores();
            }
            else
            {
                Stores = stores.Filter_By_StartCriteria(Criteria);
            }
        }

    }
}
