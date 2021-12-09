using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using FisketorvetApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetApp.Pages
{
    public class EditUserModel : PageModel
    {
        [BindProperty]
        public EditAccountViewModel EditAccountViewModel { get; set; } = new EditAccountViewModel();
        
        [BindProperty]
        public User User { get; set; } = new User();

        private static int userId;

        private IUserRepository users;
        public EditUserModel(IUserRepository userService)
        {
            users = userService;
        }
        public void OnGet(int id)
        {
            User = users.GetUser(id);
            EditAccountViewModel.Name = User.Name;
            EditAccountViewModel.Email = User.Email;
            EditAccountViewModel.Password = User.Password;
            EditAccountViewModel.ConfirmPassword = User.Password;
            EditAccountViewModel.ClubMembership = User.ClubMembership;
            EditAccountViewModel.PhoneNumber = User.PhoneNumber;
            EditAccountViewModel.DateOfBirthDay = User.DateOfBirthDay;
            EditAccountViewModel.DateOfBirthMonth = User.DateOfBirthMonth;
            EditAccountViewModel.DateOfBirthYear = User.DateOfBirthYear;
            EditAccountViewModel.Street = User.Street;
            EditAccountViewModel.HouseNumber = User.HouseNumber;
            EditAccountViewModel.PostalCode = User.PostalCode;
            EditAccountViewModel.City = User.City;
            userId = id;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                users.GetUser(userId).Name = EditAccountViewModel.Name;
                users.GetUser(userId).Email = EditAccountViewModel.Email;
                users.GetUser(userId).Password = EditAccountViewModel.Password;
                users.GetUser(userId).ClubMembership = EditAccountViewModel.ClubMembership;
                users.GetUser(userId).PhoneNumber = EditAccountViewModel.PhoneNumber;
                users.GetUser(userId).DateOfBirthDay = EditAccountViewModel.DateOfBirthDay;
                users.GetUser(userId).DateOfBirthMonth = EditAccountViewModel.DateOfBirthMonth;
                users.GetUser(userId).DateOfBirthYear = EditAccountViewModel.DateOfBirthYear;
                users.GetUser(userId).Street = EditAccountViewModel.Street;
                users.GetUser(userId).HouseNumber  =  EditAccountViewModel.HouseNumber;
                users.GetUser(userId).PostalCode = EditAccountViewModel.PostalCode;
                users.GetUser(userId).City = EditAccountViewModel.City;
                users.WriteChanges();
                
                HttpContext.Session.SetString("Name", EditAccountViewModel.Name);
                HttpContext.Session.SetString("Membership", EditAccountViewModel.ClubMembership.ToString());
               
                return RedirectToPage("Index");
            }
            return Page();
        }
    }


}
