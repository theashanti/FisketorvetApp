using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetApp.Services
{
    public class ShoppingCartService
    {

        public int CalculateTotalPrice(User user, List<AItem> items)
        {
            int totalPrice = 0;

            if(user.ClubMembership == true)
            {
                foreach(AItem item in items)
                {
                    totalPrice = (item.Price * 9) / 10;
                }
            }
            else
            {
                foreach(AItem item in items)
                {
                    totalPrice = item.Price;
                }
            }
            return totalPrice;
        }
    }
}
