using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Martin

namespace FisketorvetApp.Interfaces
{
    public interface IItemRepository
    {
        public List<AItem> AllItems();
        
        public List<AItem> Filter_By_StartCriteria(string criteria);

        public AItem GetItem(int id);
    }
}
