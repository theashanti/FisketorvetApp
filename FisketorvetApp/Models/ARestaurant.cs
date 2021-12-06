using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Máté
namespace FisketorvetApp.Models
{
    public abstract class ARestaurant
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Location { get; set; }
        public string OpeningHours { get; set; }

        public ARestaurant(string name, int phoneNumber, string location, string openingHours)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Location = location;
            OpeningHours = openingHours;
        }
    }
}
