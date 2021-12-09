using System.ComponentModel.DataAnnotations;

namespace FisketorvetApp.ViewModels
{
    public class EditAccountViewModel
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Email { get; set; }
        [Required, MaxLength(200)]
        public string Password { get; set; }
        [Required, MaxLength(200)]
        public string ConfirmPassword { get; set; }
        [Required, Range(1, 9999)]
        public int DateOfBirthYear { get; set;}
        [Required, Range(1, 12)]
        public int DateOfBirthMonth { get; set;}
        [Required, Range(1, 31)]
        public int DateOfBirthDay { get; set;}
        [Required]
        public int PhoneNumber { get; set;}
        [Required]
        public bool ClubMembership { get; set; }
        
        public string Street { get; set; }
        
        public int HouseNumber { get; set; }
        
        public int PostalCode { get; set; }
        
        public string City { get; set; }
    }
}