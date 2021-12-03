using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


//Máté(modifications)
namespace FisketorvetApp.Pages
{
    public class IndexModel : PageModel
    {
        public string WELCOMMEN_ { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (HttpContext.Session.GetString("Name") == null)
            {

                WELCOMMEN_ = "Welcome to Fisketorvet";
            }
            else
            {
                WELCOMMEN_ = "Welcome " + HttpContext.Session.GetString("Name");

                //if (HttpContext.Session.GetString("Membership").Equals("false"))
                //{

                //}
                //else
                //{

                //}

            }
        }
       
    }
}