using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetApp.Pages
{
    public class ItemModel : PageModel
    {
        public List<Models.AItem> ListOfItems { get; }

        public void OnGet()
        {
        }
    }
}
