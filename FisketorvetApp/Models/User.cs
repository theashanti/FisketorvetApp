using System.ComponentModel.DataAnnotations;

// Martin

namespace FisketorvetApp.Models
{
    public class User
    {
        //public static int IdIncrementer { get; set; }

        public Address Address { get; set; }
        
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
               
        public bool ClubMembership { get; set; }

        //public User()
        //{
        //    //Id = IdIncrementer;
        //    //IdIncrementer += 1;
        //    //ClubMembership = false;
        //    //Address = new Address();
        //}

    }
}