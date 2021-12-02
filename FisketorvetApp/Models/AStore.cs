using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Domantas
namespace FisketorvetApp.Models
{
    public abstract class AStore
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Location { get; set; }
        public string OpeningHours { get; set; }

        public AStore(string name, int phoneNumber, string location, string openingHours)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Location = location;
            OpeningHours = openingHours;
        }
       

    }
}
