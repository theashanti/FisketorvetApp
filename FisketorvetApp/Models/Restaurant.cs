using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Máté
namespace FisketorvetApp.Models
{
    public class Restaurant : AStore
    {
        public Restaurant(string name, int phoneNumber, string location, string openingHours) : base(name, phoneNumber, location, openingHours)
        {

        }
    }
}
