using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Domantas
namespace FisketorvetApp.Models
{
    public class Store : AStore
    {
        
        public Store(string name, int phoneNumber, string location, string openingHours) : base(name, phoneNumber, location, openingHours) 
        {

        }
    }
}
