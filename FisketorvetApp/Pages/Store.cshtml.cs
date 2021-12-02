using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetApp.Pages.Shared
{
    public class StoreModel : PageModel
    {
        private IStoreRepository stores;
        public StoreModel(IStoreRepository storeService)
        {
             stores= storeService;

        }

        public void OnGet()
        {

        }

    }
}
