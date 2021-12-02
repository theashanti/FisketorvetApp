using System.ComponentModel.DataAnnotations;

// Martin

namespace FisketorvetApp.Models
{
    public class User
    {
        public static int IdIncrementer { get; set; }
        
        public int Id { get; set; }
        
        [Required, MaxLength(100), Display(Name = "Type your name in here!")]
        public string Name { get; set; }
        
        [Required, MaxLength(100)]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required, Range(1, 9999)]
        public int DateOfBirthYear { get; set;}
        
        [Required, Range(1, 12)]
        public int DateOfBirthMonth { get; set;}
        
        [Required, Range(1, 31)]
        public int DateOfBirthDay { get; set;}
        
        [Required]
        public int PhoneNumber { get; set;}
        
        //[Required, MaxLength(200)]
        //public string Street { get; set;}
        
        //[Required]
        //public int HouseNumber { get; set; }
        
        //[Required, Range(1000, 9999)]
        //public int PostalCode { get; set; }
        
        //[Required , MaxLength(200)]
        //public string City { get; set; }
        
        //[Required]
        //public int CardNumber { get; set; }
        
        //[Required]
        //public int ExpirationDate { get; set; }
        
        //[Required, Range(0, 999)]
        //public int CSC { get; set; }
        
        //public bool ClubMembership { get; set; }

        /*public User(string name, string email, string password, int phoneNumber, 
                    int dateOfBirthYear, int dateOfBirthMonth, int dateOfBirthDay)
        {
            Id += 1;
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfBirthYear = dateOfBirthYear;
            DateOfBirthMonth = dateOfBirthMonth;
            DateOfBirthDay = dateOfBirthDay;
            ClubMembership = false;
        }*/

        public User()
        {
            Id = IdIncrementer;
            IdIncrementer += 1;
            //ClubMembership = false;
        }
    }
}