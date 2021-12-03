using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FisketorvetApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        public string IsClubMember()
        {

            foreach (User user in users.AllUsers())
            {
                if (user.ClubMembership == true)
                {
                    return "You are a club member";
                }
                else
                {
                    return "You are not a club member";
                }
            }
            return null;
    }

}