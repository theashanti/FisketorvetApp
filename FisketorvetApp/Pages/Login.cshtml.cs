using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace FisketorvetApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public User User { get; set; } = new User();

        public string ErrorMessage { get; set; }

        private IUserRepository users;
        public LoginModel(IUserRepository userService)
        {
            users = userService;
           
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                PasswordHasher<string> pw = new PasswordHasher<string>();
                
                foreach (User user in users.AllUsers())
                {
                   var verificationResult = pw.VerifyHashedPassword(Email, user.Password, Password);
                    if (Email.Equals(user.Email) && verificationResult == PasswordVerificationResult.Success)
                    {
                        HttpContext.Session.SetString("Name", user.Name);
                        HttpContext.Session.SetString("Membership", user.ClubMembership.ToString());
                        HttpContext.Session.SetInt32("Id", user.Id);

                        return RedirectToPage("/Index");
                    }
                    else
                    {
                        ErrorMessage = "This account does not exist";
                    }
                    
                }
                
            }

            return Page();
        }
    }
}
