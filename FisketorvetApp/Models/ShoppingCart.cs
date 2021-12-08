using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetApp.Models
{
    public class ShoppingCart
    {
        private int Id { get; set; }
        private List<AItem> IItems { get; set; }= new List<AItem>();
        private User User { get; set; }

        public ShoppingCart(int id,List<AItem> iItems, User user)
        {
            Id = id;
            User = user;
        }
        
        public void AddItemt(AItem item)
        {
            IItems.Add(item);
        }



    }
}
