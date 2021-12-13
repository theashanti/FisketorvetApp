using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetApp.Interfaces
{
    public interface IShoppingCartRepository
    {
        public void AddItem(AItem item);

        public void DeleteItem(AItem item);
        public int CalculateTotalPrice(User user, List<AItem> items);
    }
}
