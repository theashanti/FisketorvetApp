using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Martin

namespace FisketorvetApp.Pages
{
    public class CreateAccount : PageModel
    {
        [BindProperty]
        public User User { get; set; } = new User();
        
        private IUserRepository users;
        public CreateAccount(IUserRepository userService)
        {
            users = userService;
        }
        
        public void OnGet()
        {
            BOB, BOB
                asfasf
        }
        
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                users.AddUser(User);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}