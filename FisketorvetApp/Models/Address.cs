using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetApp.Models
{
    public class Address
    {
        //[Required, MaxLength(200)]
        public string Street { get; set; }

        //[Required]
        public int HouseNumber { get; set; }

       //[Required, Range(1000, 9999)]
        public int PostalCode { get; set; }

        //[Required, MaxLength(200)]
        public string City { get; set; }
    }
}
