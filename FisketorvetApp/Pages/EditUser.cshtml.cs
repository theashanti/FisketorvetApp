using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisketorvetApp.Interfaces;
using FisketorvetApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FisketorvetApp.Pages
{
    public class EditUserModel : PageModel
    {
        private static  int UserId;
        
        [BindProperty]
        public User User { get; set; } = new User();
        
        private IUserRepository users;
        public EditUserModel(IUserRepository userService)
        {
            users = userService;
        }
        public void OnGet(int id)
        {
            UserId = id;
             User=users.GetUser(id);
        }

        public IActionResult OnPost(User User)
        {
            if (ModelState.IsValid)
            {
                User.Id = UserId;
                users.EditUser(User);
                HttpContext.Session.SetString("Name", User.Name);
                HttpContext.Session.SetString("Membership", User.ClubMembership.ToString());
               
                return RedirectToPage("Index");
            }
            return Page();
        }
    }


}
