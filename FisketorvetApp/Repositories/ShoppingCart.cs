using FisketorvetApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetApp.Models
{
    public class ShoppingCart : IShoppingCartRepository
    {
        //private int Id;
        private List<AItem> AItems;
        //private User User;

        public ShoppingCart()
        {
            //Id = id;
            //User = user;
            AItems = new List<AItem>();
        }

        public void AddItem(AItem item)
        {
            AItems.Add(item);
        }

        public void DeleteItem(AItem item)
        {
            AItems.Remove(item);
        }

        public int CalculateTotalPrice(User user, List<AItem> items)
        {
            int totalPrice = 0;

            if (user.ClubMembership == true)
            {
                foreach (AItem item in items)
                {
                    totalPrice = (item.Price * 9) / 10;
                }
            }
            else
            {
                foreach (AItem item in items)
                {
                    totalPrice = item.Price;
                }
            }
            return totalPrice;

        }
    }
}
