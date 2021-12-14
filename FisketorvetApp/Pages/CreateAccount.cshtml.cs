using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using FisketorvetApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Martin

namespace FisketorvetApp.Pages
{
    public class CreateAccount : PageModel
    {
        [BindProperty]
        public CreateAccountViewModel CreateAccountViewModel { get; set; } = new CreateAccountViewModel();
        
        private IUserRepository users;
        public CreateAccount(IUserRepository userService)
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
                if (CreateAccountViewModel.Password.Equals(CreateAccountViewModel.ConfirmPassword))
                {
                    User user = new User();
                    user.Name = CreateAccountViewModel.Name;
                    user.Email = CreateAccountViewModel.Email;
                    PasswordHasher<string> pw = new PasswordHasher<string>();
                    user.Password = pw.HashPassword(CreateAccountViewModel.Email, CreateAccountViewModel.Password);
                    user.ClubMembership = CreateAccountViewModel.ClubMembership;
                    user.PhoneNumber = CreateAccountViewModel.PhoneNumber;
                    user.DateOfBirthDay = CreateAccountViewModel.DateOfBirthDay;
                    user.DateOfBirthMonth = CreateAccountViewModel.DateOfBirthMonth;
                    user.DateOfBirthYear = CreateAccountViewModel.DateOfBirthYear;
                    user.Id = users.AllUsers().Count + 1;
                    
                    users.AddUser(user);
                    return RedirectToPage("/Index");
                }
            }
            return Page();
        }
    }
}