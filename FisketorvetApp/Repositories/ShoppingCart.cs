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
        private User User;

        public ShoppingCart()
        {
            //Id = id;
            //User = user;
            AItems = new List<AItem>();
            //AItems.Add(new Consumable(2, "Pizza", 90, "Large", "Dalle Valle"));
        }

        public void AddItem(AItem item)
        {
            AItems.Add(item);
        }

        public void DeleteItem(AItem item)
        {
            foreach (AItem i in AItems)
            {
                if (item.Id == i.Id)
                {
                    AItems.Remove(i);
                    break;
                }
            }
        }

        public int TotaluPricu()
        {
            int totalPrice = 0;

            foreach (AItem item in AItems)
              {
                    totalPrice += item.Price;
              }
            return totalPrice;
        }

        //public int CalculateTotalPrice()
        //{
        //    int totalPrice = 0;

        //    if (user.ClubMembership == true)
        //    {
        //        foreach (AItem item in items)
        //        {
        //            totalPrice = (item.Price * 9) / 10;
        //        }
        //    }
        //    else
        //    {
        //        foreach (AItem item in items)
        //        {
        //            totalPrice = item.Price;
        //        }
        //    }
        //    return totalPrice;

        //}

        public List<AItem> GetAllItems()
        {
            return AItems;
        }
    }
}
