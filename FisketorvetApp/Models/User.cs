using System.ComponentModel.DataAnnotations;

// Martin

namespace FisketorvetApp.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        //[Required, Range(1, 9999)]
        public int DateOfBirthYear { get; set;}
        
        //[Required, Range(1, 12)]
        public int DateOfBirthMonth { get; set;}
        
        //[Required, Range(1, 31)]
        public int DateOfBirthDay { get; set;}
        
        //[Required]
        public int PhoneNumber { get; set;}
               
        public bool ClubMembership { get; set; }
        
        //[Required, MaxLength(200)]
        public string Street { get; set; }

        //[Required]
        public int HouseNumber { get; set; }

        //[Required, Range(1000, 9999)]
        public int PostalCode { get; set; }

        //[Required, MaxLength(200)]
        public string City { get; set; }

        //public User()
        //{
        //    //Id = IdIncrementer;
        //    //IdIncrementer += 1;
        //    //ClubMembership = false;
        //    //Address = new Address();
        //}

    }
}